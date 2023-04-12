
namespace sistemaAlertrem
{
    partial class frmCadastroFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroFunc));
            this.gpbCadastroUsuFunc = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaUsu = new System.Windows.Forms.Label();
            this.txtUsu = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.gpbCadastroUsuFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastroUsuFunc
            // 
            this.gpbCadastroUsuFunc.Controls.Add(this.btnCadastrar);
            this.gpbCadastroUsuFunc.Controls.Add(this.txtSenha);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblSenhaUsu);
            this.gpbCadastroUsuFunc.Controls.Add(this.txtUsu);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblUsuario);
            this.gpbCadastroUsuFunc.Controls.Add(this.txtNomeFunc);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblNomeFunc);
            this.gpbCadastroUsuFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastroUsuFunc.Location = new System.Drawing.Point(79, 36);
            this.gpbCadastroUsuFunc.Name = "gpbCadastroUsuFunc";
            this.gpbCadastroUsuFunc.Size = new System.Drawing.Size(467, 160);
            this.gpbCadastroUsuFunc.TabIndex = 1;
            this.gpbCadastroUsuFunc.TabStop = false;
            this.gpbCadastroUsuFunc.Text = "Cadastro de Funcionários";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(352, 103);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 36);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(89, 113);
            this.txtSenha.MaxLength = 100;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(173, 25);
            this.txtSenha.TabIndex = 3;
            // 
            // lblSenhaUsu
            // 
            this.lblSenhaUsu.AutoSize = true;
            this.lblSenhaUsu.Location = new System.Drawing.Point(14, 116);
            this.lblSenhaUsu.Name = "lblSenhaUsu";
            this.lblSenhaUsu.Size = new System.Drawing.Size(60, 20);
            this.lblSenhaUsu.TabIndex = 4;
            this.lblSenhaUsu.Text = "Senha:";
            // 
            // txtUsu
            // 
            this.txtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.Location = new System.Drawing.Point(89, 70);
            this.txtUsu.MaxLength = 50;
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(213, 26);
            this.txtUsu.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(14, 77);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(89, 31);
            this.txtNomeFunc.MaxLength = 50;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(372, 26);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(14, 37);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(55, 20);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // frmCadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 237);
            this.Controls.Add(this.gpbCadastroUsuFunc);
            this.Name = "frmCadastroFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.gpbCadastroUsuFunc.ResumeLayout(false);
            this.gpbCadastroUsuFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastroUsuFunc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenhaUsu;
        private System.Windows.Forms.TextBox txtUsu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblNomeFunc;
    }
}