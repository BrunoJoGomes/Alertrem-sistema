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
            Conexao.fecharConexao();
            

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisa.Text != "")
            {
                string nome = txtPesquisa.Text;
                CarregaDados(nome);

            }
            else
            {
                MessageBox.Show("Por favor, insira um nome a ser pesquisado", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisa.Focus();
            }
        }


        private void ltbEstacoes_Click(object sender, EventArgs e)
        {

            string nome = ltbEstacoes.SelectedItem.ToString();
            frmEstacao2 estacao = new frmEstacao2(nome);
            estacao.Show();
            this.Hide();

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmEstacao2 estacao = new frmEstacao2();
            estacao.Show();
            this.Hide();
        }
    }
}
