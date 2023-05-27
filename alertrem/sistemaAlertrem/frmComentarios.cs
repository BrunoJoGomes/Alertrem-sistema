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
    public partial class frmComentarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmComentarios()
        {
            InitializeComponent();
            carregaDados();
        }
        public void carregaDados()
        {
            string commandString = "select codigo as 'Código', data_hora as 'Postado em', descricao as 'Reclamação'," +
                "motivo as 'Motivo', numero_carro as 'Carro', cod_usuario as 'Usuário', cod_estacao as 'Estação' from tb_reclamacoes";

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

            dgvComentarios.DataSource = tabela;

            dgvComentarios.Columns["Reclamação"].Width = 300;

            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.Name = "Excluir";
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "Excluir";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvComentarios.Columns.Add(btnExcluir);         
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
                MessageBox.Show("Registro Excluido com Sucesso!", "Aviso do Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro", "Aviso do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Conexao.fecharConexao();
        }

        private void dgvComentarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvComentarios.Columns["Excluir"].Index && e.RowIndex >= 0)
            {
                int codigo = (int)dgvComentarios.Rows[e.RowIndex].Cells["Código"].Value;

                DialogResult confirma = MessageBox.Show($"Você quer mesmo apagar o comentário com id {codigo}?",
                    "Confirmação de exclusão de registro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if (confirma == DialogResult.Yes) {
                    apagaRegistro(codigo);
                    dgvComentarios.Rows.RemoveAt(e.RowIndex);
                }

            }
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void frmComentarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}
