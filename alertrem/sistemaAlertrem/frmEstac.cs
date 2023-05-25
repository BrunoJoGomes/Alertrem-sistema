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
    public partial class frmEstac : Form
    {
        Dictionary<string, int> estacoes = new Dictionary<string, int>();

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
            estacoes.Clear();
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
    }
}
