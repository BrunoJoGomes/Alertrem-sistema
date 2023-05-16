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
        public frmUsuarioEspe(int cod_usuario)
        {
            InitializeComponent();
            carregaDados(cod_usuario);
        }

        public frmUsuarioEspe()
        {
            InitializeComponent();
        }

        public void carregaDados(int id)
        {
            carregaGrid(id);
            carregaLabesl(id);
        }

        private void btnVoltarEspeci_Click(object sender, EventArgs e)
        {
            frmMenu abrir = new frmMenu();
            abrir.Show();
            this.Hide();
        }

        public void carregaLabesl(int id)
        {
            string commandString = $"select * from tb_usuarios where codigo = {id}";
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = commandString,
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            lblNome.Text = DR.GetString(1);
            lblEmail.Text = DR.GetString(4);
            string cpf = DR.GetString(5);
            lblCPF.Text = cpf;
            lblDataCadastro.Text = DR.GetString(7).Split()[0];
        }

        public void carregaGrid(int id)
        {
            string commandString = $"select codigo as 'Código', data_hora as 'Data e hora do comentário', tipo as 'Tipo', descricao as 'Descrição', " +
                $"motivo as 'Motivo', numero_carro as 'Número do carro', cod_estacao as 'Código da estação'" +
                $" from tb_reclamacoes where cod_usu = {id}";

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

            dgvcomentUsuEsp.Columns["Descrição"].Width = 300;

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

        }

        public void apagaRegistro(int id_comentario)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"delete from tb_reclamacoes where codigo = {id_comentario}",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Registro excluido com sucesso!", "Aviso do Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();
        }

        private void dgvcomentUsuEsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvcomentUsuEsp.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dgvcomentUsuEsp.Rows[e.RowIndex].Cells["codigo"].Value;

                DialogResult confirma = MessageBox.Show($"Você quer mesmo apagar o comentário com id {codigo}?",
                    "Confirmação de exclusão de registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if (confirma == DialogResult.Yes)
                {
                    apagaRegistro(codigo);
                    dgvcomentUsuEsp.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            FrmResultadoPesquisa abrir = new FrmResultadoPesquisa();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmResultadoPesquisa abrir = new FrmResultadoPesquisa();
            this.Hide();
        }
    }
}
