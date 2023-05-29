
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
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblSenhaUsu = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.gpbCadastroUsuFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastroUsuFunc
            // 
            this.gpbCadastroUsuFunc.Controls.Add(this.mskTelefone);
            this.gpbCadastroUsuFunc.Controls.Add(this.mskCPF);
            this.gpbCadastroUsuFunc.Controls.Add(this.btnCadastrar);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblSenhaUsu);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblCPF);
            this.gpbCadastroUsuFunc.Controls.Add(this.txtNome);
            this.gpbCadastroUsuFunc.Controls.Add(this.lblNomeFunc);
            this.gpbCadastroUsuFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastroUsuFunc.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastroUsuFunc.Name = "gpbCadastroUsuFunc";
            this.gpbCadastroUsuFunc.Size = new System.Drawing.Size(625, 213);
            this.gpbCadastroUsuFunc.TabIndex = 0;
            this.gpbCadastroUsuFunc.TabStop = false;
            this.gpbCadastroUsuFunc.Text = "Cadastrar funcionário";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(120, 153);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskTelefone.Mask = "(00) 0 0000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(201, 35);
            this.mskTelefone.TabIndex = 3;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTelefone.Click += new System.EventHandler(this.mskTelefone_Click);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(119, 94);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(202, 35);
            this.mskCPF.TabIndex = 2;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCPF.Click += new System.EventHandler(this.mskCPF_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(433, 157);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(164, 39);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblSenhaUsu
            // 
            this.lblSenhaUsu.AutoSize = true;
            this.lblSenhaUsu.Location = new System.Drawing.Point(11, 157);
            this.lblSenhaUsu.Name = "lblSenhaUsu";
            this.lblSenhaUsu.Size = new System.Drawing.Size(116, 29);
            this.lblSenhaUsu.TabIndex = 4;
            this.lblSenhaUsu.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(11, 98);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(67, 29);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 37);
            this.txtNome.MaxLength = 20;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(372, 35);
            this.txtNome.TabIndex = 1;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AllowDrop = true;
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(11, 40);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(85, 29);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // frmCadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 237);
            this.Controls.Add(this.gpbCadastroUsuFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlerTrem";
            this.gpbCadastroUsuFunc.ResumeLayout(false);
            this.gpbCadastroUsuFunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastroUsuFunc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblSenhaUsu;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskCPF;
    }
}