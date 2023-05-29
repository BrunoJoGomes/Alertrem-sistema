
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomentUsuEsp)).BeginInit();
            this.gpbDadosUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcomentUsuEsp
            // 
            this.dgvcomentUsuEsp.AllowUserToAddRows = false;
            this.dgvcomentUsuEsp.AllowUserToDeleteRows = false;
            this.dgvcomentUsuEsp.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvcomentUsuEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomentUsuEsp.Location = new System.Drawing.Point(16, 212);
            this.dgvcomentUsuEsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvcomentUsuEsp.Name = "dgvcomentUsuEsp";
            this.dgvcomentUsuEsp.ReadOnly = true;
            this.dgvcomentUsuEsp.RowHeadersWidth = 51;
            this.dgvcomentUsuEsp.Size = new System.Drawing.Size(1221, 292);
            this.dgvcomentUsuEsp.TabIndex = 1;
            this.dgvcomentUsuEsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomentUsuEsp_CellClick);
            // 
            // lblCampoNome
            // 
            this.lblCampoNome.AutoSize = true;
            this.lblCampoNome.Font = new System.Drawing.Font("Museo 700", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoNome.Location = new System.Drawing.Point(27, 39);
            this.lblCampoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampoNome.Name = "lblCampoNome";
            this.lblCampoNome.Size = new System.Drawing.Size(86, 28);
            this.lblCampoNome.TabIndex = 3;
            this.lblCampoNome.Text = "&Nome:";
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
            this.gpbDadosUsuario.Font = new System.Drawing.Font("Museo 700", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosUsuario.Location = new System.Drawing.Point(16, 42);
            this.gpbDadosUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosUsuario.Name = "gpbDadosUsuario";
            this.gpbDadosUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosUsuario.Size = new System.Drawing.Size(1221, 123);
            this.gpbDadosUsuario.TabIndex = 0;
            this.gpbDadosUsuario.TabStop = false;
            this.gpbDadosUsuario.Text = "&Dados do usuário";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Location = new System.Drawing.Point(941, 81);
            this.lblDataCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(0, 28);
            this.lblDataCadastro.TabIndex = 10;
            // 
            // lblCampoDataCadastro
            // 
            this.lblCampoDataCadastro.AutoSize = true;
            this.lblCampoDataCadastro.Location = new System.Drawing.Point(723, 81);
            this.lblCampoDataCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampoDataCadastro.Name = "lblCampoDataCadastro";
            this.lblCampoDataCadastro.Size = new System.Drawing.Size(210, 28);
            this.lblCampoDataCadastro.TabIndex = 9;
            this.lblCampoDataCadastro.Text = "&Data de cadastro: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(113, 81);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 28);
            this.lblEmail.TabIndex = 8;
            // 
            // lblCampoEmail
            // 
            this.lblCampoEmail.AutoSize = true;
            this.lblCampoEmail.Location = new System.Drawing.Point(27, 81);
            this.lblCampoEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampoEmail.Name = "lblCampoEmail";
            this.lblCampoEmail.Size = new System.Drawing.Size(97, 28);
            this.lblCampoEmail.TabIndex = 7;
            this.lblCampoEmail.Text = "&E-mail: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(480, 81);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(0, 28);
            this.lblCPF.TabIndex = 6;
            // 
            // lblCampoCPF
            // 
            this.lblCampoCPF.AutoSize = true;
            this.lblCampoCPF.Location = new System.Drawing.Point(411, 81);
            this.lblCampoCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampoCPF.Name = "lblCampoCPF";
            this.lblCampoCPF.Size = new System.Drawing.Size(61, 28);
            this.lblCampoCPF.TabIndex = 5;
            this.lblCampoCPF.Text = "&CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(121, 41);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 25);
            this.lblNome.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1077, 544);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUsuarioEspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1253, 651);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbDadosUsuario);
            this.Controls.Add(this.dgvcomentUsuEsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmUsuarioEspe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário";
            this.Load += new System.EventHandler(this.frmUsuarioEspe_Load);
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
        private System.Windows.Forms.Button button1;
    }
}