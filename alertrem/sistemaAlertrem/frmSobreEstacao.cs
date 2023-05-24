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
    public partial class frmSobreEstacao : Form
    {
        public frmSobreEstacao(int codigo_estacao)
        {
            InitializeComponent();
            preencheCampos();
        }

        private void preencheCampos()
        {
            MySqlDataReader DR = Conexao.select("codigo, nome", "tb_estacoes");
            DR.Read();

            txtCodigoEstacao.Text = DR.GetString(0);
            txtNomeEstacao.Text = DR.GetString(1);

            DR = Conexao.select("rua, numero, bairro, cep", "tb_enderecos");
            for (int i = 0; i < 3; i++)
            {
                TextBox logradouro = i == 0 ? txtLogradouroEndereco1 : i == 1 ? txtLogradouroEndereco2 : txtLogradouroEndereco3;
                TextBox numero = i == 0 ? txtNumeroEndereco1 : i == 1 ? txtNumeroEndereco2 : txtNumeroEndereco3;
                TextBox bairro = i == 0 ? txtBairroEndereco1 : i == 1 ? txtBairroEndereco2 : txtBairroEndereco3;
                MaskedTextBox cep = i == 0 ? mskCEPEndereco1 : i == 1 ? mskCEPEndereco2 : mskCEPEndereco3;
                if (DR.Read())
                {
                    logradouro.Text = DR.GetString(0);
                    numero.Text = DR.GetString(1);
                    bairro.Text = DR.GetString(2);
                    cep.Text = DR.GetString(3);

                    if (i == 1) { mostrarEndereco2Preenchido(); }
                    if (i == 2) { mostrarEndereco3Preenchido(); }
                }
            }
        }
        private void habilitaCampos()
        {

        }
        private void limpaEndereco1()
        {
            txtLogradouroEndereco1.Clear();
            txtNumeroEndereco1.Clear();
            txtBairroEndereco1.Clear();
            mskCEPEndereco1.Clear();
        }
        private void limpaEndereco2()
        {
            txtLogradouroEndereco2.Clear();
            txtNumeroEndereco2.Clear();
            txtBairroEndereco2.Clear();
            mskCEPEndereco2.Clear();
        }
        private void limpaEndereco3()
        {
            txtLogradouroEndereco3.Clear();
            txtNumeroEndereco3.Clear();
            txtBairroEndereco3.Clear();
            mskCEPEndereco3.Clear();
        }
        private void mostrarEndereco2()
        {
            btnAdicionarEndereco2.Visible = false;
            gpbEndereco2.Visible = true;
            btnRemoverEndereco2.Visible = true;
            btnAdicionarEndereco3.Visible = true;
            gpbEndereco2.Enabled = true;
            mskCEPEndereco2.Focus();
        }
        private void mostrarEndereco3()
        {
            btnAdicionarEndereco3.Visible = false;
            gpbEndereco3.Visible = true;
            btnRemoverEndereco3.Visible = true;
            gpbEndereco3.Enabled = true;
            mskCEPEndereco3.Focus();
        }
        private void mostrarEndereco2Preenchido()
        {
            gpbEndereco2.Visible = true;
            btnRemoverEndereco2.Visible = true;
            btnAdicionarEndereco2.Visible = false;
            btnAdicionarEndereco3.Visible = true;
        }
        private void mostrarEndereco3Preenchido()
        {
            gpbEndereco3.Visible = true;
            btnRemoverEndereco3.Visible = true;
            btnAdicionarEndereco3.Visible = false;
        }
        private void ocultaEndereco2()
        {
            if (gpbEndereco3.Visible == false)
            {
                btnAdicionarEndereco2.Visible = true;
                gpbEndereco2.Visible = false;
                btnRemoverEndereco2.Visible = false;
                btnAdicionarEndereco3.Visible = false;
            }
            limpaEndereco2();
        }
        private void ocultaEndereco3()
        {
            limpaEndereco3();
            btnAdicionarEndereco3.Visible = true;
            gpbEndereco3.Visible = false;
            btnRemoverEndereco3.Visible = false;
            if (txtLogradouroEndereco2.Text == "" && txtNumeroEndereco2.Text == "" && txtBairroEndereco2.Text == "" && !mskCEPEndereco2.MaskCompleted)
            {
                ocultaEndereco2();
            }
        }

        private void btnAdicionarEndereco2_Click(object sender, EventArgs e)
        {
            mostrarEndereco2();
        }
        private void btnAdicionarEndereco3_Click(object sender, EventArgs e)
        {
            mostrarEndereco3();
        }
        private void btnRemoverEndereco3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                ocultaEndereco3();
            }
        }
        private void btnRemoverEndereco2_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                ocultaEndereco2();
            }
        }
        private void btnRemoverEndereco1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que quer excluir este endereço?",
                "Aviso do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.Yes)
            {
                limpaEndereco1();
            }
        }
    }
}
