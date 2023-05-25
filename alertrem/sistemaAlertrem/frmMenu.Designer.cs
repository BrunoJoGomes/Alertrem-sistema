
namespace sistemaAlertrem
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnComentarios = new System.Windows.Forms.Button();
            this.btnEstacoes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblReclamacoes = new System.Windows.Forms.Label();
            this.lblEstacoes = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblStatusBanco = new System.Windows.Forms.Label();
            this.lblStatusLinha = new System.Windows.Forms.Label();
            this.btnPerfilFunc = new System.Windows.Forms.Button();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.gpbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gpbMenu.Controls.Add(this.lblUsuarios);
            this.gpbMenu.Controls.Add(this.btnPerfilFunc);
            this.gpbMenu.Controls.Add(this.btnFuncionarios);
            this.gpbMenu.Controls.Add(this.btnComentarios);
            this.gpbMenu.Controls.Add(this.btnEstacoes);
            this.gpbMenu.Controls.Add(this.btnClientes);
            this.gpbMenu.Controls.Add(this.lblFunc);
            this.gpbMenu.Controls.Add(this.lblReclamacoes);
            this.gpbMenu.Controls.Add(this.lblEstacoes);
            this.gpbMenu.Controls.Add(this.lblClientes);
            this.gpbMenu.Location = new System.Drawing.Point(-5, 104);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(816, 254);
            this.gpbMenu.TabIndex = 1;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            this.gpbMenu.Enter += new System.EventHandler(this.gpbMenu_Enter);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionarios.Image")));
            this.btnFuncionarios.Location = new System.Drawing.Point(480, 76);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(127, 84);
            this.btnFuncionarios.TabIndex = 4;
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnComentarios
            // 
            this.btnComentarios.Image = ((System.Drawing.Image)(resources.GetObject("btnComentarios.Image")));
            this.btnComentarios.Location = new System.Drawing.Point(335, 76);
            this.btnComentarios.Name = "btnComentarios";
            this.btnComentarios.Size = new System.Drawing.Size(127, 85);
            this.btnComentarios.TabIndex = 3;
            this.btnComentarios.UseVisualStyleBackColor = true;
            this.btnComentarios.Click += new System.EventHandler(this.btnComentarios_Click);
            // 
            // btnEstacoes
            // 
            this.btnEstacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnEstacoes.Image")));
            this.btnEstacoes.Location = new System.Drawing.Point(193, 76);
            this.btnEstacoes.Name = "btnEstacoes";
            this.btnEstacoes.Size = new System.Drawing.Size(127, 85);
            this.btnEstacoes.TabIndex = 2;
            this.btnEstacoes.UseVisualStyleBackColor = true;
            this.btnEstacoes.Click += new System.EventHandler(this.btnEstacoes_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(50, 76);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(127, 85);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFunc.Location = new System.Drawing.Point(493, 164);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(100, 20);
            this.lblFunc.TabIndex = 9;
            this.lblFunc.Text = "Funcionários";
            // 
            // lblReclamacoes
            // 
            this.lblReclamacoes.AutoSize = true;
            this.lblReclamacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReclamacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReclamacoes.Location = new System.Drawing.Point(349, 163);
            this.lblReclamacoes.Name = "lblReclamacoes";
            this.lblReclamacoes.Size = new System.Drawing.Size(99, 20);
            this.lblReclamacoes.TabIndex = 7;
            this.lblReclamacoes.Text = "Comentários";
            // 
            // lblEstacoes
            // 
            this.lblEstacoes.AutoSize = true;
            this.lblEstacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEstacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstacoes.Location = new System.Drawing.Point(218, 163);
            this.lblEstacoes.Name = "lblEstacoes";
            this.lblEstacoes.Size = new System.Drawing.Size(76, 20);
            this.lblEstacoes.TabIndex = 5;
            this.lblEstacoes.Text = "Estações";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(80, 163);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(66, 20);
            this.lblClientes.TabIndex = 3;
            this.lblClientes.Text = "Clientes";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.LightGray;
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(11, 383);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(127, 55);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblStatusBanco
            // 
            this.lblStatusBanco.AutoSize = true;
            this.lblStatusBanco.Location = new System.Drawing.Point(145, 50);
            this.lblStatusBanco.Name = "lblStatusBanco";
            this.lblStatusBanco.Size = new System.Drawing.Size(0, 13);
            this.lblStatusBanco.TabIndex = 6;
            // 
            // lblStatusLinha
            // 
            this.lblStatusLinha.AutoSize = true;
            this.lblStatusLinha.Location = new System.Drawing.Point(637, 50);
            this.lblStatusLinha.Name = "lblStatusLinha";
            this.lblStatusLinha.Size = new System.Drawing.Size(0, 13);
            this.lblStatusLinha.TabIndex = 7;
            // 
            // btnPerfilFunc
            // 
            this.btnPerfilFunc.Image = ((System.Drawing.Image)(resources.GetObject("btnPerfilFunc.Image")));
            this.btnPerfilFunc.Location = new System.Drawing.Point(626, 76);
            this.btnPerfilFunc.Name = "btnPerfilFunc";
            this.btnPerfilFunc.Size = new System.Drawing.Size(127, 84);
            this.btnPerfilFunc.TabIndex = 5;
            this.btnPerfilFunc.UseVisualStyleBackColor = true;
            this.btnPerfilFunc.Click += new System.EventHandler(this.btnPerfilFunc_Click);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.Location = new System.Drawing.Point(653, 164);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(72, 20);
            this.lblUsuarios.TabIndex = 14;
            this.lblUsuarios.Text = "Usuários";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusLinha);
            this.Controls.Add(this.lblStatusBanco);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlerTrem";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.gpbMenu.ResumeLayout(false);
            this.gpbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblReclamacoes;
        private System.Windows.Forms.Label lblEstacoes;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblStatusBanco;
        private System.Windows.Forms.Label lblStatusLinha;
        private System.Windows.Forms.Button btnComentarios;
        private System.Windows.Forms.Button btnEstacoes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnPerfilFunc;
        private System.Windows.Forms.Label lblUsuarios;
    }
}