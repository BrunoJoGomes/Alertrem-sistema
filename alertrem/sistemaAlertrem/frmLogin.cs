using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAlertrem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            {
                string usuario, senha;

                usuario = txtUsuario.Text;
                senha = txtSenha.Text;

                if (usuario.Equals("alertrem") && senha.Equals("alertrem"))
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

                    txtUsuario.Text = "";
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
            }
        }
    }
}