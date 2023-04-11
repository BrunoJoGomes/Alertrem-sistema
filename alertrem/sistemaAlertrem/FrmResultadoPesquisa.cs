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
    public partial class FrmResultadoPesquisa : Form
    {
        public FrmResultadoPesquisa()
        {
            InitializeComponent();
            //carregaDados();
        }

        public FrmResultadoPesquisa(string nome)
        {
            InitializeComponent();
            carregaDados(nome);
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
            Conexao.fecharConexao();

            dataGrDados.DataSource = tabela;

            //dataGrDados.Columns["descricao"].Width = 300;

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "Excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dataGrDados.Columns.Add(btnExcluir);

            // Impede que o usuário redimensione as colunas e linhas do DataGridView
            dataGrDados.AllowUserToResizeColumns = false;
            dataGrDados.AllowUserToResizeRows = false;

            // Define o modo de ajuste da altura das linhas para exibir o conteúdo completo
            dataGrDados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Define a propriedade de ajuste de altura das linhas para que o conteúdo completo seja exibido
            dataGrDados.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Faz com que o DataGridView ocupe 100% do espaço disponível
            //dataGrDados.Dock = DockStyle.Fill;
        }

        private void dataGrDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celula = dataGrDados.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //Console.WriteLine(celula.DataGridView[1, e.RowIndex].Value);
            frmUsuarioEspe abrir = new frmUsuarioEspe(int.Parse( celula.DataGridView[1, e.RowIndex].Value.ToString() ));
            abrir.ShowDialog();

            //Console.WriteLine($"{dataGrDados.SelectedRows[0]}");
            //frmUsuarioEspe abrir = new frmUsuarioEspe(dataGrDados.Columns[e.ColumnIndex][e.RowIndex];
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmPesquisaUsuarios abrir = new frmPesquisaUsuarios();
            abrir.Show();
            this.Hide();
        }
    }
}
