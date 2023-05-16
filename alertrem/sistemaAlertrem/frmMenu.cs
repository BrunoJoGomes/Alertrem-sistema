using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace sistemaAlertrem
{
    public partial class frmMenu : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmMenu()
        {
            InitializeComponent();
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

        private void pcbFunc_Click(object sender, EventArgs e)
        {
            frmFuncionarios funcionarios = new frmFuncionarios();
            funcionarios.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuarios usuarios = new frmPesquisaUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEstacao estacao = new frmEstacao();
            estacao.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmComentarios reclamacoes = new frmComentarios();
            reclamacoes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmFuncionarios funcionarios = new frmFuncionarios();
            funcionarios.Show();
            this.Hide();
        }
    }
}
