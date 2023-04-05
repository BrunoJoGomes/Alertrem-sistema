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
    public partial class frmUsuarioEspe : Form
    {
        public frmUsuarioEspe(string nome)
        {
            InitializeComponent();
            carregaDados(nome);
        }

        public frmUsuarioEspe()
        {
            InitializeComponent();
        }



        private void dgvcomentUsuEsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void carregaDados(string nome, int id = 0)
        {
            string commandString = id != 0 ? $"select * from tb_comentarios where cod_usuario = {id}" : "select * from tb_usuarios";

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

            dgvcomentUsuEsp.DataSource = tabela;

            //dataGrDados.Columns["descricao"].Width = 300;

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "Excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvcomentUsuEsp.Columns.Add(btnExcluir);

            // Impede que o usuário redimensione as colunas e linhas do DataGridView
            dgvcomentUsuEsp.AllowUserToResizeColumns = false;
            dgvcomentUsuEsp.AllowUserToResizeRows = false;

            // Define o modo de ajuste da altura das linhas para exibir o conteúdo completo
            dgvcomentUsuEsp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Define a propriedade de ajuste de altura das linhas para que o conteúdo completo seja exibido
            dgvcomentUsuEsp.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Faz com que o DataGridView ocupe 100% do espaço disponível
            //dataGrDados.Dock = DockStyle.Fill;
        }

        private void lblUsuarioESpe_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarEspeci_Click(object sender, EventArgs e)
        {
            FrmResultadoPesquisa abrir = new FrmResultadoPesquisa();
            abrir.Show();
            this.Hide();
        }
    }
}
