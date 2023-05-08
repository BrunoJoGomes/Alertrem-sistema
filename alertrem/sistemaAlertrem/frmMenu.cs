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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            testarConexao();
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
            frmEstacao estacao = new frmEstacao();
            estacao.Show();
            this.Hide();
        }

        private void pcbComentarios_Click(object sender, EventArgs e)
        {
            frmComentarios reclamacoes = new frmComentarios();
            reclamacoes.Show();
            this.Hide();
        }

        private void pcbUsuarios_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuarios usuarios = new frmPesquisaUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void pcbFunc_Click(object sender, EventArgs e)
        {
            frmFuncionarios funcionarios = new frmFuncionarios();
            funcionarios.Show();
            this.Hide();
        }
    }
}
