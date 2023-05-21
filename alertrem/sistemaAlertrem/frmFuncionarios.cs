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
    public partial class frmFuncionarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
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
            string commandString = "select codigo as 'Código', nome as 'Nome', cpf as 'CPF', telefone as 'Telefone', data_cadastro as 'Data de cadastro' from tb_funcionarios";

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

            dgvFuncionarios.Columns.Clear();
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
            DialogResult flag = cadastro.ShowDialog();
            carregaDados();
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
                comm.CommandText = $"select codigo as 'Código', nome as 'Nome', cpf as 'CPF', telefone as 'Telefone', data_cadastro as 'Data de cadastro' from tb_funcionarios where nome like '%{txtPesquisa.Text}%'";
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
                int codigo = (int)dgvFuncionarios.Rows[e.RowIndex].Cells["Código"].Value;

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
                int codigo = (int)dgvFuncionarios.Rows[e.RowIndex].Cells["Código"].Value;
                string nome = dgvFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                string cpf = dgvFuncionarios.Rows[e.RowIndex].Cells["CPF"].Value.ToString();
                string telefone = dgvFuncionarios.Rows[e.RowIndex].Cells["Telefone"].Value.ToString();

                editarFunc(codigo, nome, cpf, telefone);
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
                MessageBox.Show("Dados do funcionário excluido com sucesso!", "Aviso do sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Erro ao excluir os dados do funcionário", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();
        }

        public void editarFunc(int codigo, string nome, string cpf, string telefone)
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = $"update tb_funcionarios set nome ='{nome}', cpf ='{cpf}', telefone = '{telefone}' where codigo = {codigo};",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };

            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Dados do funcionário atualizado com Sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar os dados do funcionário", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();


        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}

