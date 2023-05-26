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
            carregarTodosDados();
        }

        private void carregarTodosDados()
        {
            carregaComboCaracteristica();
            carregaComboEstadoOperacional();
            carregarDataGrid();
            carregaListaCaracteristica();
            carregaListaEstadoOperacional();
        }

        /*
                T A B P A G E   S O B R E   A   E S T A Ç Ã O
        */

        private void preencheCampos(int codigo_estacao)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Erro ao preencher os campos.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
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
        private int atualizaEndereco(string logradouro, string numero, string bairro, string cep, string codigo, string codigo_estacao)
        {
            int res = 0;
            try
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

        /*
                T A B P A G E   A D I C I O N A R   C A R A C T E R Í S T I C A
        */

        List<string> codigosCaracteristicas = new List<string>();
        List<string> listaCaracteristicas = new List<string>();
        List<string> codigosEstadosOperacionais = new List<string>();
        List<string> listaEstadosOperacionais = new List<string>();
        private void carregarDataGrid()
        {
            dgvCaracteristicas.Rows.Clear();
            cbbCaracteristica.Text = "Selecione";
            cbbEstadoOperacional.Text = "Selecione";

            try
            {
                MySqlDataReader DR;
                DR = Conexao.select("*", "tb_estacao_caracteristica_estado_operacional", $"cod_estacao = {txtCodigoEstacao.Text}");
                while (DR.Read() )
                {
                    // Convertendo o código da chave estrangeira pelo conteúdo da tabela correspondente.
                    int indexCaracteristica = codigosCaracteristicas.FindIndex(x => x == DR.GetString(2));
                    string caracteristica = cbbCaracteristica.Items[indexCaracteristica].ToString();
                
                    int indexEstadoOperacional = codigosEstadosOperacionais.FindIndex(x => x == DR.GetString(3));
                    string estadoOperacional = cbbEstadoOperacional.Items[indexEstadoOperacional].ToString();

                    dgvCaracteristicas.Rows.Add(
                        DR.GetInt32(0),
                        caracteristica,
                        estadoOperacional
                    );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar o DataGrid.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void carregaComboCaracteristica()
        {
            codigosCaracteristicas.Clear();
            listaCaracteristicas.Clear();
            cbbCaracteristica.Items.Clear();

            try
            {
                MySqlDataReader DR = Conexao.select("codigo, nome", "tb_caracteristicas");

                while (DR.Read())
                {
                    codigosCaracteristicas.Add(DR.GetInt32(0).ToString() );
                    listaCaracteristicas.Add(DR.GetString(1) );
                    cbbCaracteristica.Items.Add(DR.GetString(1) );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar combo de caracteristicas.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void carregaComboEstadoOperacional()
        {
            codigosEstadosOperacionais.Clear();
            listaEstadosOperacionais.Clear();
            cbbEstadoOperacional.Items.Clear();

            try
            {
                MySqlDataReader DR = Conexao.select("codigo, estado", "tb_estados_operacionais");

                while (DR.Read())
                {
                    codigosEstadosOperacionais.Add(DR.GetInt32(0).ToString() );
                    listaEstadosOperacionais.Add(DR.GetString(1) );
                    cbbEstadoOperacional.Items.Add(DR.GetString(1) );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar combo de estados operacionais.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private Boolean valoresNasCombosSaoValidos()
        {
            if (cbbEstadoOperacional.Text == "Selecione"
                || cbbCaracteristica.Text == "Selecione")
            {
                return false;
            }
            return true;
        }
        private void selecionaValoresNasCombos(string caracteristica, string estadoOperacional)
        {
            cbbCaracteristica.SelectedIndex = cbbCaracteristica.Items.IndexOf(caracteristica);
            cbbEstadoOperacional.SelectedIndex = cbbEstadoOperacional.Items.IndexOf(estadoOperacional);
        }
        private void inserirCaracteristica()
        {
            int indexCaracteristica = cbbCaracteristica.SelectedIndex;
            string codigoDaCaracteristica = codigosCaracteristicas[indexCaracteristica];

            int indexEstadoOperacional = cbbEstadoOperacional.SelectedIndex;
            string codigoDoEstadoOperacional = codigosEstadosOperacionais[indexEstadoOperacional];

            try
            {
                // Verifica se já existe registo no banco
                MySqlDataReader DR = Conexao.select("*", "tb_estacao_caracteristica_estado_operacional", 
                    $"cod_caracteristica = '{codigoDaCaracteristica}' AND cod_estacao = '{txtCodigoEstacao.Text}'");
                DR.Read();
                if (DR.HasRows)
                {
                    MessageBox.Show("Erro ao inserir!\nCaracterística já existente no banco!",
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"INSERT INTO tb_estacao_caracteristica_estado_operacional (cod_estacao, cod_caracteristica, cod_estado_operacional) " +
                    $"VALUES (@cod_estacao, @cod_caracteristica, @cod_estado)",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32, 11).Value = txtCodigoEstacao.Text;
                comm.Parameters.Add("@cod_caracteristica", MySqlDbType.Int32, 11).Value = codigoDaCaracteristica;
                comm.Parameters.Add("@cod_estado", MySqlDbType.Int32, 11).Value = codigoDoEstadoOperacional;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Característica inserida com sucesso!", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao inserir característica", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao inserir característica.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void editarCaracteristica()
        {
            int indexCaracteristica = cbbCaracteristica.SelectedIndex;
            string codigoDaCaracteristica = codigosCaracteristicas[indexCaracteristica];

            int indexEstadoOperacional = cbbEstadoOperacional.SelectedIndex;
            string codigoDoEstadoOperacional = codigosEstadosOperacionais[indexEstadoOperacional];

            try
            {
                MySqlDataReader DR = Conexao.select("codigo", "tb_estacao_caracteristica_estado_operacional", 
                    $"cod_caracteristica = '{codigoDaCaracteristica}' AND cod_estacao = '{txtCodigoEstacao.Text}'");
                DR.Read();

                if (!DR.HasRows)
                {
                    MessageBox.Show("Erro ao editar característica.\nValores inexistentes no banco. Adicione antes de atualizar", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"UPDATE tb_estacao_caracteristica_estado_operacional SET " +
                    $"cod_estado_operacional = @cod_estado_operacional WHERE cod_caracteristica = @cod_caracteristica AND cod_estacao = @cod_estacao",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@cod_estado_operacional", MySqlDbType.Int32, 11).Value = codigoDoEstadoOperacional;
                comm.Parameters.Add("@cod_caracteristica", MySqlDbType.Int32, 11).Value = codigoDaCaracteristica;
                comm.Parameters.Add("@cod_estacao", MySqlDbType.Int32, 11).Value = txtCodigoEstacao.Text;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Característica editada com sucesso!", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao editar característica!", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao editar característica!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void deletarCaracteristica(Boolean todas = false)
        {
            string commString;
            if (todas)
            {
                DialogResult confirma = MessageBox.Show($"Tem certeza que quer apagar TODAS características " +
                    $"da estação {txtNomeEstacao.Text}?\nEssa operação não é reversível!",
                    "Mensagem do sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                if (confirma == DialogResult.No)
                {
                    return;
                }

                commString = $"DELETE FROM tb_estacao_caracteristica_estado_operacional WHERE cod_estacao = {txtCodigoEstacao.Text}";
            }
            else
            {
                int indexCaracteristica = cbbCaracteristica.SelectedIndex;
                string codigoDaCaracteristica = codigosCaracteristicas[indexCaracteristica];
                DialogResult confirma = MessageBox.Show("Tem certeza que quer apagar a característica" +
                    $" '{cbbCaracteristica.Text}' da estação {txtNomeEstacao.Text}?",
                    "Mensagem do sistema",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button2);
                if (confirma == DialogResult.No)
                {
                    return;
                }

                commString = $"DELETE FROM tb_estacao_caracteristica_estado_operacional WHERE cod_caracteristica = {codigoDaCaracteristica} AND cod_estacao = {txtCodigoEstacao.Text}";
            }

            try
            {
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = commString,
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };

                int res = comm.ExecuteNonQuery();

                if (res >= 1)
                {
                    MessageBox.Show("Característica(s) deletada(s) com sucesso!", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar característica(s).", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao deletar característica(s).",
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
                T A B P A G E   C A D A S T R A R   C A R A C T E R Í S T I C A
        */

        private void carregaListaCaracteristica()
        {
            ltbCaracteristica.Items.Clear();
            try
            {
                MySqlDataReader DR = Conexao.select("nome", "tb_caracteristicas");
                while (DR.Read() )
                {
                    ltbCaracteristica.Items.Add(DR.GetString(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar lista de características",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private int proximoCodigoCaracteristica()
        {
            MySqlDataReader DR = Conexao.select("codigo + 1", "tb_caracteristicas", "1 ORDER BY codigo desc limit 1");
            DR.Read();
            int codigo = DR.GetInt32(0);
            Conexao.fecharConexao();
            return codigo;
        }
        private void cadastrarCaracteristica()
        {
            string caracteristica = txtCaracteristica.Text;

            try
            {
                // Verifica se já existe registo no banco
                MySqlDataReader DR = Conexao.select("*", "tb_caracteristicas", $"nome = '{caracteristica}'");
                DR.Read();
                if (DR.HasRows)
                {
                    MessageBox.Show("Erro ao cadastrar!\nCaracterística já existente no banco!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"INSERT INTO tb_caracteristicas (nome) VALUES (@nome)",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = caracteristica;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Característica cadastrada com sucesso!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar característica.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar característica.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void modificarCaracteristica()
        {
            string codigo = txtCodigoCaracteristica.Text;
            string caracteristica = txtCaracteristica.Text;

            try
            {
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"UPDATE tb_caracteristicas SET nome = @nome WHERE codigo = @codigo",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = caracteristica;
                comm.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = codigo;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Característica modificada com sucesso!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao modificar característica.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao modificar característica.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void validaPesquisaCaracteristica()
        {
            string caracteristica = txtPesquisarCaracteristica.Text;
            if (caracteristica != "")
            {
                pesquisarCaracteristica(caracteristica);
            }
            else
            {
                MessageBox.Show("Digite o valor a ser pesquisado.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPesquisarCaracteristica.Focus();
            }
        }
        private void pesquisarCaracteristica(string caracteristica)
        {
            ltbCaracteristica.Items.Clear();
            try
            {
                MySqlDataReader DR = Conexao.select("nome", "tb_caracteristicas", $"nome like '%{caracteristica}%' ");
                while (DR.Read())
                {
                    ltbCaracteristica.Items.Add(DR.GetString(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar pela caracteristica.",
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
                T A B P A G E   C A D A S T R A R   E S T A D O   O P E R A C I O N A L
        */

        private void carregaListaEstadoOperacional()
        {
            ltbEstadoOperacional.Items.Clear();
            try
            {
                MySqlDataReader DR = Conexao.select("estado", "tb_estados_operacionais");
                while (DR.Read() )
                {
                    ltbEstadoOperacional.Items.Add(DR.GetString(0));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao carregar lista de estados operacionais.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private int proximoCodigoEstadoOperacional()
        {
            MySqlDataReader DR = Conexao.select("codigo + 1", "tb_estados_operacionais", "1 ORDER BY codigo desc limit 1");
            DR.Read();
            int codigo = DR.GetInt32(0);
            Conexao.fecharConexao();
            return codigo;
        }
        private void cadastrarEstadoOperacional()
        {
            string estado = txtEstadoOperacional.Text;
            try
            {
                // Verifica se já existe registo no banco
                MySqlDataReader DR = Conexao.select("*", "tb_estados_operacionais", $"estado = '{estado}'");
                DR.Read();
                if (DR.HasRows)
                {
                    MessageBox.Show("Erro ao cadastrar!\nEstado operacional já existente no banco!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"INSERT INTO tb_estados_operacionais (estado) VALUES (@estado)",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@estado", MySqlDbType.VarChar, 50).Value = estado;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Estado operacional cadastrado com sucesso!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao modificar estado operacional.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar estado operacional.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }

        }
        private void modificarEstadoOperacional()
        {
            string codigo = txtCodigoEstadoOperacional.Text;
            string estado = txtEstadoOperacional.Text;

            try
            {
                MySqlCommand comm = new MySqlCommand
                {
                    CommandText = $"UPDATE tb_estados_operacionais SET estado = @estado WHERE codigo = @codigo",
                    CommandType = CommandType.Text,
                    Connection = Conexao.obterConexao()
                };
                comm.Parameters.Clear();
                comm.Parameters.Add("@estado", MySqlDbType.VarChar, 50).Value = estado;
                comm.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = codigo;

                int res = comm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Estado operacional cadastrado com sucesso!",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    carregarDataGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao modificar estado operacional.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao modificar estado operacional.",
                        "Aviso do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }
        private void validaPesquisaEstadoOperacional()
        {
            string estado = txtPesquisarEstadoOperacional.Text;
            if (estado != "")
            {
                pesquisarEstadoOperacional(estado);
            }
            else
            {
                MessageBox.Show("Digite o valor a ser pesquisado.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPesquisarEstadoOperacional.Focus();
            }
        }
        private void pesquisarEstadoOperacional(string estado)
        {
            ltbEstadoOperacional.Items.Clear();
            try
            {
                MySqlDataReader DR = Conexao.select("estado", "tb_estados_operacionais", $"estado like '%{estado}%' ");
                while (DR.Read())
                {
                    ltbEstadoOperacional.Items.Add(DR.GetString(0) );
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao pesquisar pelo estado operacional.",
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
                E V E N T O S   A   P A R T I R   D A Q U I 
        */

        /* #####   TABPAGE SOBRE A ESTAÇÃO   #####*/
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

        /* #####   TABPAGE ADICIONAR CARACTERÍSTICA   #####*/
        private void btnAdicionarCaracteristica_Click(object sender, EventArgs e)
        {
            if (valoresNasCombosSaoValidos())
            {
                inserirCaracteristica();
            }
            else
            {
                MessageBox.Show("Selecione uma característica e um estado operacional!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void dgvCaracteristicas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string caracteristica = dgvCaracteristicas.Rows[e.RowIndex].Cells["caracteristica"].Value.ToString();
                string estado_operacional = dgvCaracteristicas.Rows[e.RowIndex].Cells["estadoOperacional"].Value.ToString();
                selecionaValoresNasCombos(caracteristica, estado_operacional);
            }
        }
        private void btnEditarCaracteristica_Click(object sender, EventArgs e)
        {
            if (valoresNasCombosSaoValidos())
            {
                editarCaracteristica();
            }
            else
            {
                MessageBox.Show("Selecione uma característica e um estado operacional!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnRemoverCaracteristica_Click(object sender, EventArgs e)
        {
            if (valoresNasCombosSaoValidos())
            {
                deletarCaracteristica();
            }
            else
            {
                MessageBox.Show("Selecione uma característica e um estado operacional!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void btnRemoverTodasCaracteristicas_Click(object sender, EventArgs e)
        {
            deletarCaracteristica(true);
        }


        /* #####   TABPAGE CADASTRAR CARACTERÍSTICA   #####*/
        private void ltbCaracteristica_SelectedIndexChanged(object sender, EventArgs e)
        {
            string caracteristica = ltbCaracteristica.SelectedItem.ToString();
            int indexCaracteristica = listaCaracteristicas.FindIndex(x => x == caracteristica);
            string codigo = codigosCaracteristicas[indexCaracteristica];

            txtCodigoCaracteristica.Text = codigo;
            txtCaracteristica.Text = caracteristica;
            btnModificarCaracteristica.Enabled = true;
            btnNovaCaracteristica.Enabled = true;
            txtCaracteristica.Enabled = false;
            btnCadastrarCaracteristica.Enabled = false;
            btnSalvarAlteracoesCaracteristica.Enabled = false;
        }
        private void btnNovaCaracteristica_Click(object sender, EventArgs e)
        {
            btnNovaCaracteristica.Enabled = false;
            btnModificarCaracteristica.Enabled = false;
            btnSalvarAlteracoesCaracteristica.Enabled = false;
            btnCadastrarCaracteristica.Enabled = true;
            txtCodigoCaracteristica.Text = proximoCodigoCaracteristica().ToString();
            txtCaracteristica.Enabled = true;
            txtCaracteristica.Clear();
            txtCaracteristica.Focus();
        }
        private void btnCadastrarCaracteristica_Click(object sender, EventArgs e)
        {
            if (txtCaracteristica.Text != "")
            {
                cadastrarCaracteristica();
                txtCaracteristica.Enabled = false;
                carregaListaCaracteristica();
                carregaComboCaracteristica();
            }
        }
        private void btnSalvarAlteracoesCaracteristica_Click(object sender, EventArgs e)
        {
            if (txtCaracteristica.Text != "")
            {
                modificarCaracteristica();
                txtCaracteristica.Enabled = false;
                carregaListaCaracteristica();
                carregaComboCaracteristica();
            }
        }
        private void btnModificarCaracteristica_Click(object sender, EventArgs e)
        {
            btnModificarCaracteristica.Enabled = false;
            txtCaracteristica.Enabled = true;
            //btnNovaCaracteristica.Enabled = false;
            btnCadastrarCaracteristica.Enabled = false;
            btnSalvarAlteracoesCaracteristica.Enabled = true;
            txtCaracteristica.Focus();
        }
        private void btnPesquisarCaracteristica_Click(object sender, EventArgs e)
        {
            validaPesquisaCaracteristica();
        }

        /* #####   TABPAGE CADASTRAR ESTADO OPERACIONAL   #####*/
        private void ltbEstadoOperacional_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = ltbEstadoOperacional.SelectedItem.ToString();
            int indexCodigo = listaEstadosOperacionais.FindIndex(x => x == estado) ;
            string codigo = codigosEstadosOperacionais[indexCodigo];

            txtCodigoEstadoOperacional.Text = codigo;
            txtEstadoOperacional.Text = estado;
            btnModificarEstadoOperacional.Enabled = true;
            btnNovoEstadoOperacional.Enabled = true;
            txtEstadoOperacional.Enabled = false;
            btnCadastrarEstadoOperacional.Enabled = false;
            btnSalvarEstadoOperacional.Enabled = false;
        }
        private void btnNovoEstadoOperacional_Click(object sender, EventArgs e)
        {
            btnNovoEstadoOperacional.Enabled = false;
            btnModificarEstadoOperacional.Enabled = false;
            btnSalvarEstadoOperacional.Enabled = false;
            btnCadastrarEstadoOperacional.Enabled = true;
            txtCodigoEstadoOperacional.Text = proximoCodigoEstadoOperacional().ToString();
            txtEstadoOperacional.Enabled = true;
            txtEstadoOperacional.Clear();
            txtEstadoOperacional.Focus();
        }
        private void btnCadastrarEstadoOperacional_Click(object sender, EventArgs e)
        {
            if (txtEstadoOperacional.Text != "")
            {
                cadastrarEstadoOperacional();
                txtEstadoOperacional.Enabled = false;
                carregaListaEstadoOperacional();
                carregaComboEstadoOperacional();
            }
        }
        private void btnSalvarEstadoOperacional_Click(object sender, EventArgs e)
        {
            if (txtEstadoOperacional.Text != "")
            {
                modificarEstadoOperacional();
                txtEstadoOperacional.Enabled = false;
                carregaListaEstadoOperacional();
                carregaComboEstadoOperacional();
            }
        }
        private void btnModificarEstadoOperacional_Click(object sender, EventArgs e)
        {
            btnModificarEstadoOperacional.Enabled = false;
            txtEstadoOperacional.Enabled = true;
            //btnNovoEstadoOperacional.Enabled = false;
            btnCadastrarEstadoOperacional.Enabled = false;
            btnSalvarEstadoOperacional.Enabled = true;
            txtEstadoOperacional.Focus();
        }
        private void btnPesquisarEstadoOperacional_Click(object sender, EventArgs e)
        {
            validaPesquisaEstadoOperacional();
        }
    }
}
