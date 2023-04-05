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
        Dictionary<string, int> usuarios = new Dictionary<string, int>();
        public frmPesquisaUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
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
            string commandString = $"select * from tb_usuarios where nome like '%{nome}%'";

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
    }
}
