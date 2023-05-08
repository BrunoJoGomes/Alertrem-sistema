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
            txtPesquisa.Focus();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        public void carregaDados()
        {
            string commandString = "select codigo as 'Código', nome as 'Nome', usuario as 'Usuário', data_hora as 'Data e hora de criação' from tb_funcionarios";

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


            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvFuncionarios.Columns.Add(btnEditar);

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroFunc cadastro = new frmCadastroFunc();
            cadastro.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                MessageBox.Show("Escreva algo na caixa de texto para ser pesquisado.", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = $"select codigo as 'Código', nome as 'Nome', usuario as 'Usuário', data_hora as 'Data e hora de criação' from tb_funcionarios where nome like '%{txtPesquisa.Text}%'";
                comm.CommandType = CommandType.Text;

                comm.Connection = Conexao.obterConexao();

                MySqlDataAdapter adapter = new MySqlDataAdapter(comm);
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                Conexao.fecharConexao();

                dgvFuncionarios.DataSource = tabela;
                txtPesquisa.Focus();
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFuncionarios.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dgvFuncionarios.Rows[e.RowIndex].Cells["codigo"].Value;

                DialogResult confirma = MessageBox.Show($"Você quer mesmo apagar este funcionário?",
                    "Confirmação de exclusão de registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if (confirma == DialogResult.Yes)
                {
                    apagaRegistro(codigo);
                    dgvFuncionarios.Rows.RemoveAt(e.RowIndex);
                }

            }

            else if(e.ColumnIndex == dgvFuncionarios.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dgvFuncionarios.Rows[e.RowIndex].Cells["codigo"].Value;
                string nome = dgvFuncionarios.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                string usuario = dgvFuncionarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();

                editarFunc(codigo, nome, usuario);
            }
        }

        public void apagaRegistro(int id_funcionario)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"delete from tb_funcionarios where codigo = {id_funcionario}",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Registro Excluido com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();
        }

        public void editarFunc(int codigo, string nome, string usuario)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"update tb_funcionarios set nome ='{nome}', usuario ='{usuario}' where codigo = {codigo};",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };

            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Registro atualizado com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar registro", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();


        }
    }
}

