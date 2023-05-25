using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ViaCep;

namespace sistemaAlertrem
{
    public partial class frmSobreEstacao : Form
    {
        public frmSobreEstacao(int codigo_estacao)
        {
            InitializeComponent();
            preencheCampos(codigo_estacao);
        }

        private void preencheCampos(int codigo_estacao)
        {
            MySqlDataReader DR = Conexao.select("codigo, nome", "tb_estacoes", $"codigo = {codigo_estacao}");
            DR.Read();

            txtCodigoEstacao.Text = DR.GetString(0);
            txtNomeEstacao.Text = DR.GetString(1);

            DR = Conexao.select("codigo, rua, numero, bairro, cep", "tb_enderecos", $"cod_estacao = {codigo_estacao}");
            for (int i = 0; i < 3; i++)
            {
                TextBox logradouro = i == 0 ? txtLogradouroEndereco1 : i == 1 ? txtLogradouroEndereco2 : txtLogradouroEndereco3;
                TextBox numero = i == 0 ? txtNumeroEndereco1 : i == 1 ? txtNumeroEndereco2 : txtNumeroEndereco3;
                TextBox bairro = i == 0 ? txtBairroEndereco1 : i == 1 ? txtBairroEndereco2 : txtBairroEndereco3;
                TextBox codigo = i == 0 ? txtCodigoEndereco1 : i == 1 ? txtCodigoEndereco2 : txtCodigoEndereco3;
                MaskedTextBox cep = i == 0 ? mskCEPEndereco1 : i == 1 ? mskCEPEndereco2 : mskCEPEndereco3;

                if (DR.Read())
                {
                    logradouro.Text = DR.GetString(1);
                    numero.Text = DR.GetString(2);
                    bairro.Text = DR.GetString(3);
                    cep.Text = DR.GetString(4);
                    codigo.Text = DR.GetInt32(0).ToString();

                    if (i == 1) { mostrarEndereco2Preenchido(); }
                    if (i == 2) { mostrarEndereco3Preenchido(); }
                }
            }
        }
        private void habilitaCampos()
        {
            txtNomeEstacao.Enabled = true;
            gpbEndereco1.Enabled = true;
            if (gpbEndereco2.Visible)
            {
                gpbEndereco2.Enabled = true;
            }
            if (gpbEndereco3.Visible)
            {
                gpbEndereco3.Enabled = true;
            }
        }
        private void desabilitaCampos()
        {
            txtNomeEstacao.Enabled = false;
            gpbEndereco1.Enabled = false;
            if (gpbEndereco2.Visible)
            {
                gpbEndereco2.Enabled = false;
            }
            if (gpbEndereco3.Visible)
            {
                gpbEndereco3.Enabled = false;
            }
        }
        private void limpaEndereco1()
        {
            if (gpbEndereco2.Visible && endereco2EstaVazio()) { ocultaEndereco2(); }
            if (gpbEndereco2.Visible)
            {
                txtLogradouroEndereco1.Text = txtLogradouroEndereco2.Text;
                txtNumeroEndereco1.Text = txtNumeroEndereco2.Text;
                txtBairroEndereco1.Text = txtBairroEndereco2.Text;
                mskCEPEndereco1.Text = mskCEPEndereco2.Text;
                txtCodigoEndereco1.Text = txtCodigoEndereco2.Text;
                ocultaEndereco2();
            }
            else
            {
                txtLogradouroEndereco1.Clear();
                txtNumeroEndereco1.Clear();
                txtBairroEndereco1.Clear();
                mskCEPEndereco1.Clear();
                txtCodigoEndereco1.Clear();
            }
        }
        private void limpaEndereco2()
        {
            txtLogradouroEndereco2.Clear();
            txtNumeroEndereco2.Clear();
            txtBairroEndereco2.Clear();
            mskCEPEndereco2.Clear();
            txtCodigoEndereco2.Clear();
        }
        private void limpaEndereco3()
        {
            txtLogradouroEndereco3.Clear();
            txtNumeroEndereco3.Clear();
            txtBairroEndereco3.Clear();
            mskCEPEndereco3.Clear();
            txtCodigoEndereco3.Clear();
        }
        private void mostrarEndereco2()
        {
            if (endereco1EstaVazio())
            {
                MessageBox.Show("Preencha o campo do primeiro endereço antes de adicionar um segundo endereço.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                btnAdicionarEndereco2.Visible = false;
                gpbEndereco2.Visible = true;
                btnRemoverEndereco2.Visible = true;
                btnAdicionarEndereco3.Visible = true;
                gpbEndereco2.Enabled = true;
                mskCEPEndereco2.Focus();
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
        }
        private void mostrarEndereco3()
        {
            if (endereco2EstaVazio())
            {
                MessageBox.Show("Preencha o campo do segundo endereço antes de adicionar um terceiro endereço.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                btnAdicionarEndereco3.Visible = false;
                gpbEndereco3.Visible = true;
                btnRemoverEndereco3.Visible = true;
                gpbEndereco3.Enabled = true;
                mskCEPEndereco3.Focus();
                btnEditar.Enabled = false;
                btnSalvar.Enabled = true;
            }
        }
        private void mostrarEndereco2Preenchido()
        {
            gpbEndereco2.Visible = true;
            btnRemoverEndereco2.Visible = true;
            btnAdicionarEndereco2.Visible = false;
            btnAdicionarEndereco3.Visible = true;
        }
        private void mostrarEndereco3Preenchido()
        {
            gpbEndereco3.Visible = true;
            btnRemoverEndereco3.Visible = true;
            btnAdicionarEndereco3.Visible = false;
        }
        private void ocultaEndereco2()
        {
            if (gpbEndereco3.Visible && endereco3EstaVazio()) { ocultaEndereco3(); }
            if (gpbEndereco3.Visible)
            {
                txtLogradouroEndereco2.Text = txtLogradouroEndereco3.Text;
                txtNumeroEndereco2.Text = txtNumeroEndereco3.Text;
                txtBairroEndereco2.Text = txtBairroEndereco3.Text;
                mskCEPEndereco2.Text = mskCEPEndereco3.Text;
                txtCodigoEndereco2.Text = txtCodigoEndereco3.Text;
                ocultaEndereco3();
            }
            else
            {
                limpaEndereco2();

                btnAdicionarEndereco2.Visible = true;
                gpbEndereco2.Visible = false;
                btnRemoverEndereco2.Visible = false;
                btnAdicionarEndereco3.Visible = false;
            }
        }
        private void ocultaEndereco3()
        {
            limpaEndereco3();

            btnAdicionarEndereco3.Visible = true;
            gpbEndereco3.Visible = false;
            btnRemoverEndereco3.Visible = false;

            if (endereco2EstaVazio()) { ocultaEndereco2(); }
        }
        private Boolean endereco1EstaVazio()
        {
            return (txtLogradouroEndereco1.Text == "" 
                && txtNumeroEndereco1.Text == "" 
                && txtBairroEndereco1.Text == "" 
                && !mskCEPEndereco1.MaskCompleted);
        }
        private Boolean endereco2EstaVazio()
        {
            return (txtLogradouroEndereco2.Text == ""
                && txtNumeroEndereco2.Text == "" 
                && txtBairroEndereco2.Text == "" 
                && !mskCEPEndereco2.MaskCompleted);
        }
        private Boolean endereco3EstaVazio()
        {
            return (txtLogradouroEndereco3.Text == "" 
                && txtNumeroEndereco3.Text == "" 
                && txtBairroEndereco3.Text == "" 
                && !mskCEPEndereco3.MaskCompleted);
        }
        private string[] buscaCEP(string CEP)
        {
            string[] dados = new string[2];
            try
            {
                ViaCepClient endereco = new ViaCepClient();
                ViaCepResult resultado = endereco.Search(CEP);

                dados[0] = resultado.Street;
                dados[1] = resultado.Neighborhood;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao buscar por CEP.\nInforme um CEP válido.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            return dados;
        }
        private void preencherEndereco(TextBox logradouro, TextBox bairro, MaskedTextBox CEP)
        {
            string[] infos = buscaCEP(CEP.Text);
            (logradouro.Text, bairro.Text) = (infos[0], infos[1]);
        }
        private int cadastraEndereco(string logradouro, string numero, string bairro, string cep, string codigo_estacao)
        {
            MySqlCommand comm = new MySqlCommand 
            {
                CommandText = "insert into tb_enderecos (rua, numero, bairro, cep, cod_estacao) values(@rua, @numero, @bairro, @cep, @cod_estacao);",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            comm.Parameters.Clear();
            comm.Parameters.Add("@rua", MySqlDbType.VarChar, 100).Value = logradouro;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32, 11).Value = codigo_estacao;

            int res = comm.ExecuteNonQuery();
            Conexao.fecharConexao();
            return res;
        }
        private int atualizaEndereco(string logradouro, string numero, string bairro, string cep, string codigo, string codigo_estacao)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"UPDATE tb_enderecos SET rua = @rua, numero = @numero, bairro = @bairro, cep = @cep WHERE codigo = @codigo AND cod_estacao = @cod_estacao",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            comm.Parameters.Clear();
            comm.Parameters.Add("@rua", MySqlDbType.VarChar, 100).Value = logradouro;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 6).Value = numero;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32, 11).Value = codigo_estacao;
            comm.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = codigo;

            int res = comm.ExecuteNonQuery();
            Conexao.fecharConexao();
            return res;
        }
        private void verificarCampos()
        {
            int cadastrou = 2, atualizou = 2;
            for (int i = 0; i < 3; i++)
            {
                GroupBox grupo = i == 0 ? gpbEndereco1 : i == 1 ? gpbEndereco2 : gpbEndereco3;
                string logradouro = i == 0 ? txtLogradouroEndereco1.Text : i == 1 ? txtLogradouroEndereco2.Text : txtLogradouroEndereco3.Text;
                string numero = i == 0 ? txtNumeroEndereco1.Text : i == 1 ? txtNumeroEndereco2.Text : txtNumeroEndereco3.Text;
                string bairro = i == 0 ? txtBairroEndereco1.Text : i == 1 ? txtBairroEndereco2.Text : txtBairroEndereco3.Text;
                string codigo = i == 0 ? txtCodigoEndereco1.Text : i == 1 ? txtCodigoEndereco2.Text : txtCodigoEndereco3.Text;
                string cep = i == 0 ? mskCEPEndereco1.Text : i == 1 ? mskCEPEndereco2.Text : mskCEPEndereco3.Text;
                string codigo_estacao = txtCodigoEstacao.Text;

                if (codigo == "" && grupo.Visible)
                {
                    cadastrou = cadastraEndereco(logradouro, numero, bairro, cep, codigo_estacao);
                    if (cadastrou == 0)
                    {
                        MessageBox.Show("Erro ao cadastrar endereços.",
                            "Aviso do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    }
                }
                else if (grupo.Visible)
                {
                    atualizou = atualizaEndereco(logradouro, numero, bairro, cep, codigo, codigo_estacao);
                    if (atualizou == 0)
                    {
                        MessageBox.Show("Erro ao atualizar endereços.",
                            "Aviso do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    }
                }
            }
            if (cadastrou == 1)
            {
                MessageBox.Show("Endereços cadastrados com sucesso!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else if (atualizou == 1)
            {
                MessageBox.Show("Endereços aualizados com sucesso!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnAdicionarEndereco2_Click(object sender, EventArgs e)
        {
            mostrarEndereco2();
        }
        private void btnAdicionarEndereco3_Click(object sender, EventArgs e)
        {
            mostrarEndereco3();
        }
        private void btnRemoverEndereco1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                limpaEndereco1();
            }
        }
        private void btnRemoverEndereco2_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                ocultaEndereco2();
            }
        }
        private void btnRemoverEndereco3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                ocultaEndereco3();
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
        }
        private void mskCEPEndereco1_TextChanged(object sender, EventArgs e)
        {
            if (mskCEPEndereco1.MaskCompleted && txtLogradouroEndereco1.Text == "") 
            { 
                preencherEndereco(txtLogradouroEndereco1, txtBairroEndereco1, mskCEPEndereco1);
                txtNumeroEndereco1.Focus();
            }
        }
        private void mskCEPEndereco2_TextChanged(object sender, EventArgs e)
        {
            if (mskCEPEndereco2.MaskCompleted && txtLogradouroEndereco2.Text == "")
            {
                preencherEndereco(txtLogradouroEndereco2, txtBairroEndereco2, mskCEPEndereco2);
                txtNumeroEndereco2.Focus();
            }
        }
        private void mskCEPEndereco3_TextChanged(object sender, EventArgs e)
        {
            if (mskCEPEndereco3.MaskCompleted && txtLogradouroEndereco3.Text == "")
            {
                preencherEndereco(txtLogradouroEndereco3, txtBairroEndereco3, mskCEPEndereco3);
                txtNumeroEndereco3.Focus();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            verificarCampos();
            desabilitaCampos();
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
        }
    }
}
