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
using MySql.Data.MySqlClient;



namespace sistemaAlertrem
{
    public partial class frmPesquisaUsuarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        Dictionary<string, int> usuarios = new Dictionary<string, int>();
        public frmPesquisaUsuarios()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            usuarios.Clear();
            carregaDados(txtUsuario.Text);
            //FrmResultadoPesquisa abrir = new FrmResultadoPesquisa(textUsuario.Text);
            //abrir.Show();
            //this.Hide();
        }

        public void carregaDados(string nome)
        {
            string commandString = $"select * from tb_perfis where nome like '%{nome}%'";

            MySqlCommand comm = new MySqlCommand
            {
                CommandText = commandString,
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };


            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbUsuarios.Items.Clear();
            while (DR.Read())
            {
                ltbUsuarios.Items.Add(DR[1]);
                usuarios.Add(DR[1].ToString(), int.Parse(DR[0].ToString() ));
            }

            Conexao.fecharConexao();

            
        }

        private void ltbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = usuarios[ltbUsuarios.SelectedItem.ToString()];
            frmUsuarioEspe abrir = new frmUsuarioEspe(id);
            abrir.ShowDialog();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                carregaDados(txtUsuario.Text);
            }
            
        }

        private void frmPesquisaUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
