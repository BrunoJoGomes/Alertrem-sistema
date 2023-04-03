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
using Bcrypt = BCrypt.Net.BCrypt;

namespace sistemaAlertrem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            testarConexao();
        }

        public Boolean verificarCampos(){
            if (txtNomeFunc.Text == "" || txtUsu.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Favor preencher todos os campos");
                return false;
            }
            return true;
        }

        public void CadastrarUsuarios()
        {
            string salt = Bcrypt.GenerateSalt(); 
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_funcionarios(nome,usuario,salt,senha) values(@nome,@usuario,@salt,@senha);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = txtUsu.Text;
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 60).Value = salt;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = Bcrypt.HashPassword(txtSenha.Text,salt);

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexao.fecharConexao();
            txtNomeFunc.Clear();
            txtUsu.Clear();
            txtSenha.Clear();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                if (Conexao.testarConexao())
                {
                    CadastrarUsuarios();
                }
                else
                {
                    MessageBox.Show("Banco Desconectado","Mensagem do Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                testarConexao();
                
            }
            
        }

        public void testarConexao()
        {
            if (Conexao.testarConexao())
            {
                lblStatusBanco.Text = "Conectado";
                lblStatusBanco.ForeColor = Color.Green;
            }
            else
            {
                lblStatusBanco.Text = "Desconectado";
                lblStatusBanco.ForeColor = Color.Red;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void pcbEstacoes_Click(object sender, EventArgs e)
        {
            frmEstacao1 estacao = new frmEstacao1();
            estacao.Show();
            this.Hide();
        }

        private void pcbComentarios_Click(object sender, EventArgs e)
        {
            frmComentarios reclamacoes = new frmComentarios();
            reclamacoes.Show();
            this.Hide();
        }
    }
}
