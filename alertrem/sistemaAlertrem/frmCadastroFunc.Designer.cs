
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
            this.lblSenhaUsu = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.gpbCadastroUsuFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastroUsuFunc
            // 
            this.gpbCadastroUsuFunc.Controls.Add(this.mskTelefone);
            this.gpbCadastroUsuFunc.Controls.Add(this.mskCPF);
            this.gpbCadastroUsuFunc.Controls.Add(this.btnCadastrar);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblSenhaUsu);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblUsuario);
            this.gpbCadastroUsuFunc.Controls.Add(this.txtNomeFunc);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblNomeFunc);
            this.gpbCadastroUsuFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastroUsuFunc.Location = new System.Drawing.Point(16, 15);
            this.gpbCadastroUsuFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCadastroUsuFunc.Name = "gpbCadastroUsuFunc";
            this.gpbCadastroUsuFunc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCadastroUsuFunc.Size = new System.Drawing.Size(833, 284);
            this.gpbCadastroUsuFunc.TabIndex = 1;
            this.gpbCadastroUsuFunc.TabStop = false;
            this.gpbCadastroUsuFunc.Text = "Cadastro de Funcionários";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(577, 193);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(219, 48);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenhaUsu
            // 
            this.lblSenhaUsu.AutoSize = true;
            this.lblSenhaUsu.Location = new System.Drawing.Point(15, 193);
            this.lblSenhaUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaUsu.Name = "lblSenhaUsu";
            this.lblSenhaUsu.Size = new System.Drawing.Size(138, 36);
            this.lblSenhaUsu.TabIndex = 4;
            this.lblSenhaUsu.Text = "Telefone:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(15, 121);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 36);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "CPF:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(159, 46);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeFunc.MaxLength = 20;
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(495, 41);
            this.txtNomeFunc.TabIndex = 1;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AllowDrop = true;
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(15, 49);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(101, 36);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(159, 118);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(271, 41);
            this.mskCPF.TabIndex = 2;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(159, 190);
            this.mskTelefone.Mask = "(00) 0 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(271, 41);
            this.mskTelefone.TabIndex = 3;
            // 
            // frmCadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 312);
            this.Controls.Add(this.gpbCadastroUsuFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label lblSenhaUsu;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCPF;
    }
}