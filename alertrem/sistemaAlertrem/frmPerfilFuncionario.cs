﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using Bcrypt = BCrypt.Net.BCrypt;

namespace sistemaAlertrem
{
    public partial class frmPerfilFuncionario : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmPerfilFuncionario()
        {
            InitializeComponent();
            carregaComboFuncionario();
        }

        private void frmPerfilFuncionario_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        List<string> codigos = new List<string>();
        public void carregaComboFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome,codigo from tb_funcionarios;";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR = comm.ExecuteReader();
            cbbFuncionario.Items.Clear();
            codigos.Clear();
            while (DR.Read())
            {
                cbbFuncionario.Items.Add(DR.GetString(0));
                codigos.Add(DR.GetString(1));
            }
            Conexao.fecharConexao();
        }

        public void preencheDados(string cod_funcionario)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"select * from tb_usuarios where cod_funcionario = '{cod_funcionario}';";
            comm.CommandType = CommandType.Text;
            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR = comm.ExecuteReader();
            
            
            txtCodFunc.Text = cod_funcionario;
            if(DR.Read())
            {

                txtNomeUsuario.Text = DR.GetString(1);
                txtSenha.Text = DR.GetString(3);
                txtConfirmaSenha.Text = DR.GetString(3);
            }

        }

        private void cbbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbbFuncionario.SelectedIndex;
            limparCampos();
            preencheDados(codigos[index]);
            
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            txtNomeUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirmaSenha.Enabled = true;

        }


        public void cadastrarUsuarios(string codFunc)
        {
            string senha = txtSenha.Text;
            string salt = Bcrypt.GenerateSalt();
            senha = Bcrypt.HashPassword(senha, salt);
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_usuarios(usuario,salt,senha,cod_funcionario) values (@usuario,@salt,@senha,@codigo);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = txtNomeUsuario.Text;
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 256).Value = salt;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = senha;
            comm.Parameters.Add("@codigo", MySqlDbType.Int32, 11).Value = codFunc;
            comm.Connection = Conexao.obterConexao();

            int i = comm.ExecuteNonQuery();

            if(i == 1)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário!",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

            cbbFuncionario.Text = "";
            txtCodFunc.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();

            txtCodFunc.Enabled = false;
            txtNomeUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;

        }

        public void limparCampos()
        {
            cbbFuncionario.Text = "";
            txtCodFunc.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
            cbbFuncionario.Focus();

            txtCodFunc.Enabled = false;
            txtNomeUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text != "" && txtSenha.Text != "" && txtConfirmaSenha.Text != "")
            {
                if (txtSenha.Text == txtConfirmaSenha.Text)
                {
                    if (verificarCampos())
                    {
                        editarUsuarios(txtCodFunc.Text);

                    }
                    else
                    {
                        cadastrarUsuarios(txtCodFunc.Text);
                    }
                }
                else
                {
                    MessageBox.Show("As senha não são iguais",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }
        }

        public void editarUsuarios(string codFunc)
        {
            string senha = txtSenha.Text;
            string salt = Bcrypt.GenerateSalt();
            senha = Bcrypt.HashPassword(senha, salt);
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tb_usuarios set usuario = @usuario, salt = @salt, senha = @senha where cod_funcionario="+codFunc+";";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = txtNomeUsuario.Text;
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 256).Value = salt;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = senha;
            comm.Connection = Conexao.obterConexao();

            int i = comm.ExecuteNonQuery();

            if (i == 1)
            {
                MessageBox.Show("Usuário alterado com sucesso!",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Erro ao alterar usuário!",
                   "Aviso do sistema",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error,
                   MessageBoxDefaultButton.Button1);
            }

            Conexao.fecharConexao();

            cbbFuncionario.Text = "";
            txtCodFunc.Clear();
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();

            txtCodFunc.Enabled = false;
            txtNomeUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmaSenha.Enabled = false;
        }

        public Boolean verificarCampos()
        {
            string codigo = txtCodFunc.Text;
            MySqlDataReader DR = Conexao.select("cod_funcionario","tb_usuarios",$"cod_funcionario = {codigo}");
            return DR.Read()?true:false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
