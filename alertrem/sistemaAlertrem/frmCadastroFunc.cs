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
using Bcrypt = BCrypt.Net.BCrypt;
using System.Runtime.InteropServices;

namespace sistemaAlertrem
{
    public partial class frmCadastroFunc : Form
    {
        public frmCadastroFunc()
        {
            InitializeComponent();
        }

        public Boolean verificarCampos()
        {
            if (txtNomeFunc.Text == "" || !(mskCPF.MaskCompleted) || !(mskTelefone.MaskCompleted) )
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public void CadastrarUsuarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_funcionarios(nome,cpf,telefone) values(@nome,@cpf,@telefone);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = mskCPF.Text;
            comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 20).Value = mskTelefone.Text;

            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFunc.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeFunc.Focus();
            }
            Conexao.fecharConexao();
            txtNomeFunc.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                if (Conexao.testarConexao())
                {
                    CadastrarUsuarios();
                }
                else
                {
                    MessageBox.Show("Banco Desconectado", "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
            txtNomeFunc.Focus();
        }
    }
}
