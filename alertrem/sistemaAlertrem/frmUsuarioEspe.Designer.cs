﻿
namespace sistemaAlertrem
{
    partial class frmUsuarioEspe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioEspe));
            this.dgvcomentUsuEsp = new System.Windows.Forms.DataGridView();
            this.lblCampoNome = new System.Windows.Forms.Label();
            this.gpbDadosUsuario = new System.Windows.Forms.GroupBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.lblCampoDataCadastro = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCampoEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblCampoCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomentUsuEsp)).BeginInit();
            this.gpbDadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcomentUsuEsp
            // 
            this.dgvcomentUsuEsp.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvcomentUsuEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomentUsuEsp.Location = new System.Drawing.Point(12, 218);
            this.dgvcomentUsuEsp.Name = "dgvcomentUsuEsp";
            this.dgvcomentUsuEsp.Size = new System.Drawing.Size(916, 237);
            this.dgvcomentUsuEsp.TabIndex = 1;
            this.dgvcomentUsuEsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomentUsuEsp_CellClick);
            // 
            // lblCampoNome
            // 
            this.lblCampoNome.AutoSize = true;
            this.lblCampoNome.Font = new System.Drawing.Font("Museo 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoNome.Location = new System.Drawing.Point(23, 22);
            this.lblCampoNome.Name = "lblCampoNome";
            this.lblCampoNome.Size = new System.Drawing.Size(60, 19);
            this.lblCampoNome.TabIndex = 3;
            this.lblCampoNome.Text = "Nome:";
            // 
            // gpbDadosUsuario
            // 
            this.gpbDadosUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gpbDadosUsuario.Controls.Add(this.lblDataCadastro);
            this.gpbDadosUsuario.Controls.Add(this.lblCampoDataCadastro);
            this.gpbDadosUsuario.Controls.Add(this.lblEmail);
            this.gpbDadosUsuario.Controls.Add(this.lblCampoEmail);
            this.gpbDadosUsuario.Controls.Add(this.lblCPF);
            this.gpbDadosUsuario.Controls.Add(this.lblCampoCPF);
            this.gpbDadosUsuario.Controls.Add(this.lblNome);
            this.gpbDadosUsuario.Controls.Add(this.lblCampoNome);
            this.gpbDadosUsuario.Font = new System.Drawing.Font("Museo 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosUsuario.Location = new System.Drawing.Point(12, 97);
            this.gpbDadosUsuario.Name = "gpbDadosUsuario";
            this.gpbDadosUsuario.Size = new System.Drawing.Size(916, 100);
            this.gpbDadosUsuario.TabIndex = 0;
            this.gpbDadosUsuario.TabStop = false;
            this.gpbDadosUsuario.Text = "Dados do usuário";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(703, 66);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(0, 19);
            this.lblDataCadastro.TabIndex = 10;
            // 
            // lblCampoDataCadastro
            // 
            this.lblCampoDataCadastro.AutoSize = true;
            this.lblCampoDataCadastro.Location = new System.Drawing.Point(542, 66);
            this.lblCampoDataCadastro.Name = "lblCampoDataCadastro";
            this.lblCampoDataCadastro.Size = new System.Drawing.Size(149, 19);
            this.lblCampoDataCadastro.TabIndex = 9;
            this.lblCampoDataCadastro.Text = "Data de Cadastro: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(83, 66);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 19);
            this.lblEmail.TabIndex = 8;
            // 
            // lblCampoEmail
            // 
            this.lblCampoEmail.AutoSize = true;
            this.lblCampoEmail.Location = new System.Drawing.Point(20, 66);
            this.lblCampoEmail.Name = "lblCampoEmail";
            this.lblCampoEmail.Size = new System.Drawing.Size(61, 19);
            this.lblCampoEmail.TabIndex = 7;
            this.lblCampoEmail.Text = "Email: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(356, 66);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 19);
            this.lblCPF.TabIndex = 6;
            // 
            // lblCampoCPF
            // 
            this.lblCampoCPF.AutoSize = true;
            this.lblCampoCPF.Location = new System.Drawing.Point(308, 66);
            this.lblCampoCPF.Name = "lblCampoCPF";
            this.lblCampoCPF.Size = new System.Drawing.Size(43, 19);
            this.lblCampoCPF.TabIndex = 5;
            this.lblCampoCPF.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(84, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 20);
            this.lblNome.TabIndex = 4;
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Font = new System.Drawing.Font("Museo 700", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(826, 461);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 81);
            this.btnVoltar2.TabIndex = 2;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.gpbMenu.Location = new System.Drawing.Point(-1, -1);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(954, 56);
            this.gpbMenu.TabIndex = 11;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // frmUsuarioEspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.gpbDadosUsuario);
            this.Controls.Add(this.dgvcomentUsuEsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuarioEspe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomentUsuEsp)).EndInit();
            this.gpbDadosUsuario.ResumeLayout(false);
            this.gpbDadosUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcomentUsuEsp;
        private System.Windows.Forms.Label lblCampoNome;
        private System.Windows.Forms.GroupBox gpbDadosUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCampoCPF;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCampoEmail;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.Label lblCampoDataCadastro;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.GroupBox gpbMenu;
    }
}