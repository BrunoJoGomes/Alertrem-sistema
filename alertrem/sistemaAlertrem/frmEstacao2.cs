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

namespace sistemaAlertrem
{
    public partial class frmEstacao2 : Form
    {
        public frmEstacao2()
        {
            InitializeComponent();
        }

        public frmEstacao2(string nome)
        {
            InitializeComponent();
            carregaDados(nome);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (Conexao.testarConexao())
            {
                if (txtNome.Text.Equals("") || txtLocalizacao.Text.Equals(""))
                {
                    MessageBox.Show("Por favor, insira o nome e a localização da estação", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MySqlCommand comm = new MySqlCommand();
                    comm.CommandText = "insert into tb_estacoes(nome,localizacao,banheiro,elevador,terminal_interurbano,terminal_urbano,transferencia_interna,bicicletario,banheiro_acessivel,estacao_acessivel,rampa,transposicao_plataformas,escadas_rolantes,acesso_elevador,lanchonete,emporio,caixa_eletronico,calcados,telefone_p_surdos,piso_tatil,transferencia_gratuita,acessorios,farmacia,rota_acessivel,achados_perdidos) " +
                        "values(@nome,@localizacao,@banheiro,@elevador,@terminal_interurbano,@terminal_urbano,@transferencia_interna,@bicicletario,@banheiro_acessivel,@estacao_acessivel,@rampa,@transposicao_plataformas,@escadas_rolantes,@acesso_elevador,@lanchonete,@emporio,@caixa_eletronico,@calcados,@telefone_p_surdos,@piso_tatil,@transferencia_gratuita,@acessorios,@farmacia,@rota_acessivel,@achados_perdidos);";
                    comm.CommandType = CommandType.Text;

                    //string[] valores = new string[21];
                    Dictionary<string, string> valores = new Dictionary<string, string>();
                    int i = 0;
                    foreach (Control gpbBox in gpbCaracteristicas.Controls)
                    {
                        foreach (RadioButton radio in gpbBox.Controls)
                        {
                            if (i < 23)
                            {
                                if (radio.Checked)
                                {
                                    valores.Add(gpbBox.Name, radio.Text);
                                    //valores[i]  = radio.Text;
                                    //i++;
                                    //Console.WriteLine($"{gpbBox.Name} = {radio.Checked}");
                                }
                            }
                        }
                    }
                    //foreach (string x in valores)
                    //{
                    Console.WriteLine(valores);
                    //}

                    comm.Parameters.Clear();
                    comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                    comm.Parameters.Add("@localizacao", MySqlDbType.VarChar, 50).Value = txtLocalizacao.Text;
                    comm.Parameters.Add("@banheiro", MySqlDbType.VarChar, 50).Value = valores["gpbBanheiro"];
                    comm.Parameters.Add("@elevador", MySqlDbType.VarChar, 50).Value = valores["gpbElevador"];
                    comm.Parameters.Add("@terminal_interurbano", MySqlDbType.VarChar, 60).Value = valores["gpbTerminalInterurbano"];
                    comm.Parameters.Add("@terminal_urbano", MySqlDbType.VarChar, 256).Value = valores["gpbTerminalUrbano"];
                    comm.Parameters.Add("@transferencia_interna", MySqlDbType.VarChar, 256).Value = valores["gpbTransferenciaInterna"];
                    comm.Parameters.Add("@bicicletario", MySqlDbType.VarChar, 256).Value = valores["gpbBicicletario"];
                    comm.Parameters.Add("@banheiro_acessivel", MySqlDbType.VarChar, 256).Value = valores["gpbBanheiroAcessivel"];
                    comm.Parameters.Add("@estacao_acessivel", MySqlDbType.VarChar, 256).Value = valores["gpbEstacaoAcessivel"];
                    comm.Parameters.Add("@rampa", MySqlDbType.VarChar, 256).Value = valores["gpbRampa"];
                    comm.Parameters.Add("@transposicao_plataformas", MySqlDbType.VarChar, 256).Value = valores["gpbTransposicaoPlataformas"];
                    comm.Parameters.Add("@escadas_rolantes", MySqlDbType.VarChar, 256).Value = valores["gpbEscadasRolantes"];
                    comm.Parameters.Add("@acesso_elevador", MySqlDbType.VarChar, 256).Value = valores["gpbAcessoElevador"];
                    comm.Parameters.Add("@lanchonete", MySqlDbType.VarChar, 256).Value = valores["gpbLanchonete"];
                    comm.Parameters.Add("@emporio", MySqlDbType.VarChar, 256).Value = valores["gpbEmporio"];
                    comm.Parameters.Add("@caixa_eletronico", MySqlDbType.VarChar, 256).Value = valores["gpbCaixaEletronico"];
                    comm.Parameters.Add("@calcados", MySqlDbType.VarChar, 256).Value = valores["gpbCalcados"];
                    comm.Parameters.Add("@telefone_p_surdos", MySqlDbType.VarChar, 256).Value = valores["gpbTelefonePSurdos"];
                    comm.Parameters.Add("@piso_tatil", MySqlDbType.VarChar, 256).Value = valores["gpbPisoTatil"];
                    comm.Parameters.Add("@transferencia_gratuita", MySqlDbType.VarChar, 256).Value = valores["gpbTransferenciaGratuita"];
                    comm.Parameters.Add("@acessorios", MySqlDbType.VarChar, 256).Value = valores["gpbAcessorios"];
                    comm.Parameters.Add("@farmacia", MySqlDbType.VarChar, 256).Value = valores["gpbFarmacia"];
                    comm.Parameters.Add("@rota_acessivel", MySqlDbType.VarChar, 256).Value = valores["gpbRotaAcessivel"];
                    comm.Parameters.Add("@achados_perdidos", MySqlDbType.VarChar, 256).Value = valores["gpbAchadosPerdidos"];

                    comm.Connection = Conexao.obterConexao();
                    int res = comm.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("Estação cadastrada com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar estação", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Conexao.fecharConexao();
                }

            }
            else
            {
                MessageBox.Show("Banco Desconectado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        public void carregaDados(string nome="")
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tb_estacoes where nome like '%{nome}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            txtCodigo.Text = DR.GetInt32(0).ToString();
            txtNome.Text = DR.GetString(1);
            txtLocalizacao.Text = DR.GetString(2);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmEstacao1 estacao = new frmEstacao1();
            estacao.Show();
            this.Hide();
        }
    }
}
