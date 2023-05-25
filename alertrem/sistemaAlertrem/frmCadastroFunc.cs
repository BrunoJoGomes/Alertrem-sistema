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
using Bcrypt = BCrypt.Net.BCrypt;
using System.Runtime.InteropServices;

namespace sistemaAlertrem
{
    public partial class frmCadastroFunc : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);
        public frmCadastroFunc()
        {
            InitializeComponent();
        }

        public Boolean verificarCampos()
        {
            if (txtNomeFunc.Text == "" || txtUsu.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos");
                return false;
            }
            return true;
        }

        


        public void CadastrarUsuarios()
        {
            string salt = Bcrypt.GenerateSalt();
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tb_funcionarios(nome,usuario,salt,senha) values(@nome,@usuario,@salt,@senha);";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = txtNomeFunc.Text;
            comm.Parameters.Add("@usuario", MySqlDbType.VarChar, 50).Value = txtUsu.Text;
            comm.Parameters.Add("@salt", MySqlDbType.VarChar, 60).Value = salt;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 256).Value = Bcrypt.HashPassword(txtSenha.Text, salt);



            comm.Connection = Conexao.obterConexao();
            int res = comm.ExecuteNonQuery();
            if (res == 1)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeFunc.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeFunc.Focus();
            }
            Conexao.fecharConexao();
            txtNomeFunc.Clear();
            txtUsu.Clear();
            txtSenha.Clear();
            
         



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

        private void txtNomeFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroFunc_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }
    }
}