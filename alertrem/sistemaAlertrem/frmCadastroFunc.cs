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
    public partial class frmCadastroFunc : Form
    {
        public frmCadastroFunc()
        {
            InitializeComponent();
        }

        public Boolean verificarCampos()
        {
            if (txtNome.Text != "" && validaCPF(mskCPF.Text) && mskTelefone.MaskCompleted)
            {
                return true;
            }
            MessageBox.Show("Preencha todos os campos corretamente!",
                "Aviso do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            return false;
        }
        public static bool validaCPF(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }
        public void limparCampos()
        {
            txtNome.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            txtNome.Focus();
        }
        public void cadastrarFuncionario()
        {
            string nome = txtNome.Text;
            string CPF = mskCPF.Text;
            string telefone = mskTelefone.Text;

            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tb_funcionarios (nome, cpf, telefone) values (@nome, @cpf, @telefone)";
                comm.CommandType = CommandType.Text;
                comm.Connection = Conexao.obterConexao();

                comm.Parameters.Clear();
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = nome;
                comm.Parameters.Add("@cpf", MySqlDbType.VarChar, 14).Value = CPF;
                comm.Parameters.Add("@telefone", MySqlDbType.VarChar, 20).Value = telefone;

                int res = comm.ExecuteNonQuery();
                if (res == 1)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário.", 
                        "Aviso do sistema", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao cadastrar funcionário.",
                    "Aviso do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                cadastrarFuncionario();
                limparCampos();
            }
            txtNome.Focus();
        }
        private void mskTelefone_Click(object sender, EventArgs e)
        {
            mskTelefone.Select(0, 0);
        }
        private void mskCPF_Click(object sender, EventArgs e)
        {
            mskCPF.Select(0, 0);
        }
    }
}
