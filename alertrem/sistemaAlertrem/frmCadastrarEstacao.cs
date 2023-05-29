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
using System.Runtime.InteropServices;
using ViaCep;

namespace sistemaAlertrem
{
    public partial class frmCadastrarEstacao : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastrarEstacao()
        {
            InitializeComponent();
            buscaProximoCodigo();
        }

        public void buscaProximoCodigo()
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = "SELECT codigo + 1 FROM tb_estacoes ORDER BY codigo DESC LIMIT 1 ",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };

            int proximoId = int.Parse(comm.ExecuteScalar().ToString());
            txtCodigoEstacao.Text = proximoId.ToString();
            txtCodigoEstacao.Enabled = false;
        }
        public void limparCampos()
        {
            txtNomeEstacao.Clear();
            limpaEndereco3();
            limpaEndereco2();
            limpaEndereco1();
            txtNomeEstacao.Focus();
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
                ocultaEndereco2();
            }
            else
            {
                txtLogradouroEndereco1.Clear();
                txtNumeroEndereco1.Clear();
                txtBairroEndereco1.Clear();
                mskCEPEndereco1.Clear();
            }
        }
        private void limpaEndereco2()
        {
            txtLogradouroEndereco2.Clear();
            txtNumeroEndereco2.Clear();
            txtBairroEndereco2.Clear();
            mskCEPEndereco2.Clear();
        }
        private void limpaEndereco3()
        {
            txtLogradouroEndereco3.Clear();
            txtNumeroEndereco3.Clear();
            txtBairroEndereco3.Clear();
            mskCEPEndereco3.Clear();
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
            }
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
            int res = 0;
            try
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

                res = comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir endereço",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
            return res;
        }
        private void cadastrarEnderecos()
        {
            for (int i = 0; i < 3; i++)
            {
                GroupBox grupo = i == 0 ? gpbEndereco1 : i == 1 ? gpbEndereco2 : gpbEndereco3;
                string logradouro = i == 0 ? txtLogradouroEndereco1.Text : i == 1 ? txtLogradouroEndereco2.Text : txtLogradouroEndereco3.Text;
                string numero = i == 0 ? txtNumeroEndereco1.Text : i == 1 ? txtNumeroEndereco2.Text : txtNumeroEndereco3.Text;
                string bairro = i == 0 ? txtBairroEndereco1.Text : i == 1 ? txtBairroEndereco2.Text : txtBairroEndereco3.Text;
                string cep = i == 0 ? mskCEPEndereco1.Text : i == 1 ? mskCEPEndereco2.Text : mskCEPEndereco3.Text;
                string codigo_estacao = txtCodigoEstacao.Text;

                Boolean camposValidos = (logradouro != "" && numero != "" && bairro != "" && cep != "");

                if (grupo.Visible && camposValidos)
                {
                    int cadastrou = cadastraEndereco(logradouro, numero, bairro, cep, codigo_estacao);
                    if (cadastrou == 0)
                    {
                        MessageBox.Show("Erro ao cadastrar endereços.",
                            "Aviso do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    }
                }
            }
        }
        private void cadastrarEstacao()
        {
            string nome_estacao = txtNomeEstacao.Text;
            int cod_usuario = UsuarioAutenticado.CodigoUsuarioAutenticado;
            try
            {
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = "insert into tb_estacoes (nome, cod_usuario) values(@nome, @cod_usuario);",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome_estacao;
                comm.Parameters.Add("@cod_usuario", MySqlDbType.Int32, 11).Value = cod_usuario;

                int res = comm.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Estação cadastrada com sucesso!",
                           "Aviso do sistema",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar estação.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar estação.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        /*
                                     #####################
                                     ###### EVENTOS ######
                                     #####################
        */


        private void frmCadastrarEstacao_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
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
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarEstacao();
            cadastrarEnderecos();
            limparCampos();
            buscaProximoCodigo();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstac estacao = new frmEstac();
            estacao.Show();
            //this.Hide();
            this.Close();
        }
    }
}
