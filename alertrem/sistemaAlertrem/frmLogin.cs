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
using System.Runtime.InteropServices;

namespace sistemaAlertrem
{
    public partial class frmLogin : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            if (!txtUsuario.Text.Equals("") && !txtSenha.Text.Equals(""))
            {
                pesquisaUsuario(usuario, senha);
            }
            else
            {
                MessageBox.Show("Insira dados válidos!",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
        }

        public void pesquisaUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"select * from tb_funcionarios where usuario like '{usuario}'",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            MySqlDataReader DR = comm.ExecuteReader();
            DR.Read();

            if (DR.HasRows)
            {
                if (DR.GetString(4) == Bcrypt.HashPassword(senha, DR.GetString(3) ))
                {
                    frmMenu abrir = new frmMenu();
                    abrir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    txtUsuario.Clear();
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuário não existe no banco!",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }

            Conexao.fecharConexao();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}