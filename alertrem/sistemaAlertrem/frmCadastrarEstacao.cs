﻿using System;
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
    public partial class frmCadastrarEstacao : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastrarEstacao()
        {
            InitializeComponent();
            buscaProximoCodigo();
        }

        public void buscaProximoCodigo()
        {
            MySqlCommand comm = new MySqlCommand
            {
                //CommandText = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'db_alertrem' AND TABLE_NAME = 'tb_estacoes'",
                CommandText = "SELECT codigo + 1 FROM tb_estacoes ORDER BY codigo DESC LIMIT 1 ",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };

            int proximoId = int.Parse(comm.ExecuteScalar().ToString());
            txtCodigo.Text = proximoId.ToString();
            txtCodigo.Enabled = false;
        }

        public void limparCampos()
        {
            txtNome.Clear();
            txtLocalizacao.Clear();
            txtNome.Focus();
        }

        public bool verificaCampos()
        {
            if (txtNome.Text.Length < 5 || txtLocalizacao.Text.Length < 5)
            {
                MessageBox.Show("Favor inserir valores corretamente!",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void cadastraEstacao()
        {
            MySqlCommand comm = new MySqlCommand
            {
                CommandText = "INSERT INTO tb_estacoes (nome, localizacao) VALUES (@nome, @localizacao)",
                CommandType = CommandType.Text,
                Connection = Conexao.obterConexao()
            };
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            comm.Parameters.Add("@localizacao", MySqlDbType.VarChar, 150).Value = txtLocalizacao.Text;

            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Estação cadastrada com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                buscaProximoCodigo();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar estação, tente novamente mais tarde.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
                                     #####################
                                     ###### EVENTOS ######
                                     #####################
        */

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                cadastraEstacao();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLocalizacao.Focus();
            }
        }

        private void txtLocalizacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCadastrar.Focus();
            }
        }

        private void frmCadastrarEstacao_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}