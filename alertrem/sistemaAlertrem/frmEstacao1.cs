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
    public partial class frmEstacao1 : Form
    {
        public frmEstacao1()
        {
            InitializeComponent();
            CarregaDados();
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb1_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb2_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void ptb3_Click(object sender, EventArgs e)
        {
            frmEstacao2 OutroFrm = new frmEstacao2();
            OutroFrm.ShowDialog();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        public void CarregaDados(string nome="")
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select nome from tb_estacoes where nome like '%{nome}%';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            ltbEstacoes.Items.Clear();
            while (DR.Read())
            {
                ltbEstacoes.Items.Add(DR[0]);
            }

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        public void PesquisarEstacao(string nome)
        {
            frmEstacao2 estacao = new frmEstacao2(nome);


        }

        private void ltbEstacoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ltbEstacoes.SelectedItem.
        }
    }
}
