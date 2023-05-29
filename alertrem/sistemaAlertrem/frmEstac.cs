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

namespace sistemaAlertrem
{
    public partial class frmEstac : Form
    {
        Dictionary<string, int> estacoes = new Dictionary<string, int>();

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmEstac()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string commandString = $"select * from tb_estacoes where nome like '%{txtPesquisar.Text}%'";

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
            ltbEstacao.Items.Clear();
            while (DR.Read())
            {
                ltbEstacao.Items.Add(DR[1].ToString());
                estacoes.Add(DR[1].ToString(), int.Parse(DR[0].ToString()));
            }

            Conexao.fecharConexao();
        }

        private void gpbPesquisaEstacao_Enter(object sender, EventArgs e)
        {

        }

        private void ltbEstacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = estacoes[ltbEstacao.SelectedItem.ToString()];
            frmSobreEstacao abrir = new frmSobreEstacao(id);
            abrir.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarEstacao abrir = new frmCadastrarEstacao();
            abrir.Show();
            this.Hide();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        private void frmEstac_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
