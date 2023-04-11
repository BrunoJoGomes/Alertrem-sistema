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
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            carregaDados();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        public void carregaDados()
        {
            string commandString = "select * from tb_funcionarios";

            MySqlCommand comm = new MySqlCommand
            {
                CommandText = commandString,
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };


            MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            Conexao.fecharConexao();

            dgvFuncionarios.DataSource = tabela;

            //dgvComentarios.Columns["descricao"].Width = 300;

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "Excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvFuncionarios.Columns.Add(btnExcluir);

            // Impede que o usuário redimensione as colunas e linhas do DataGridView
            dgvFuncionarios.AllowUserToResizeColumns = false;
            dgvFuncionarios.AllowUserToResizeRows = false;

            // Define o modo de ajuste da altura das linhas para exibir o conteúdo completo
            dgvFuncionarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Define a propriedade de ajuste de altura das linhas para que o conteúdo completo seja exibido
            dgvFuncionarios.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Faz com que o DataGridView ocupe 100% do espaço disponível
            // dgvFuncionarios.Dock = DockStyle.Fill;
        }
    }
}

