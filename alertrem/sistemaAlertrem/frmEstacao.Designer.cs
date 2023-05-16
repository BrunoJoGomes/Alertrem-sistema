
namespace sistemaAlertrem
{
    partial class frmEstacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstacao));
            this.gpbPesquisaEstacao = new System.Windows.Forms.GroupBox();
            this.cbbEstacao = new System.Windows.Forms.ComboBox();
            this.txtLocalizacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEstacao = new System.Windows.Forms.Button();
            this.btnCaracteristica = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbPesquisaEstacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisaEstacao
            // 
            this.gpbPesquisaEstacao.Controls.Add(this.cbbEstacao);
            this.gpbPesquisaEstacao.Controls.Add(this.txtLocalizacao);
            this.gpbPesquisaEstacao.Controls.Add(this.txtNome);
            this.gpbPesquisaEstacao.Controls.Add(this.txtCodigo);
            this.gpbPesquisaEstacao.Controls.Add(this.lblLocalizacao);
            this.gpbPesquisaEstacao.Controls.Add(this.lblNome);
            this.gpbPesquisaEstacao.Controls.Add(this.lblCodigo);
            this.gpbPesquisaEstacao.Controls.Add(this.btnSalvar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnDeletar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnEditar);
            this.gpbPesquisaEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisaEstacao.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisaEstacao.Name = "gpbPesquisaEstacao";
            this.gpbPesquisaEstacao.Size = new System.Drawing.Size(779, 289);
            this.gpbPesquisaEstacao.TabIndex = 0;
            this.gpbPesquisaEstacao.TabStop = false;
            this.gpbPesquisaEstacao.Text = "Pesquisar Estação";
            // 
            // cbbEstacao
            // 
            this.cbbEstacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbbEstacao.FormattingEnabled = true;
            this.cbbEstacao.Location = new System.Drawing.Point(26, 42);
            this.cbbEstacao.Name = "cbbEstacao";
            this.cbbEstacao.Size = new System.Drawing.Size(452, 33);
            this.cbbEstacao.TabIndex = 1;
            this.cbbEstacao.Text = "Selecione";
            this.cbbEstacao.SelectedValueChanged += new System.EventHandler(this.cbbEstacao_SelectedValueChanged);
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLocalizacao.Location = new System.Drawing.Point(174, 198);
            this.txtLocalizacao.Multiline = true;
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Size = new System.Drawing.Size(345, 71);
            this.txtLocalizacao.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Location = new System.Drawing.Point(108, 151);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(382, 31);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.cbbEstacao_SelectedValueChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(122, 103);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(382, 31);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(23, 223);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(133, 25);
            this.lblLocalizacao.TabIndex = 5;
            this.lblLocalizacao.Text = "Localização:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 154);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(74, 25);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 106);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(579, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(113, 43);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(579, 130);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(113, 43);
            this.btnDeletar.TabIndex = 6;
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(579, 62);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(113, 43);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEstacao
            // 
            this.btnEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstacao.Location = new System.Drawing.Point(12, 322);
            this.btnEstacao.Name = "btnEstacao";
            this.btnEstacao.Size = new System.Drawing.Size(213, 36);
            this.btnEstacao.TabIndex = 8;
            this.btnEstacao.Text = "Cadastrar Estação";
            this.btnEstacao.UseVisualStyleBackColor = true;
            this.btnEstacao.Click += new System.EventHandler(this.btnEstacao_Click);
            // 
            // btnCaracteristica
            // 
            this.btnCaracteristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaracteristica.Location = new System.Drawing.Point(295, 322);
            this.btnCaracteristica.Name = "btnCaracteristica";
            this.btnCaracteristica.Size = new System.Drawing.Size(253, 36);
            this.btnCaracteristica.TabIndex = 9;
            this.btnCaracteristica.Text = "Cadastrar Características";
            this.btnCaracteristica.UseVisualStyleBackColor = true;
            this.btnCaracteristica.Click += new System.EventHandler(this.btnCaracteristica_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(625, 322);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(166, 36);
            this.btnSair.TabIndex = 10;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmEstacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 386);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCaracteristica);
            this.Controls.Add(this.btnEstacao);
            this.Controls.Add(this.gpbPesquisaEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estação";
            this.gpbPesquisaEstacao.ResumeLayout(false);
            this.gpbPesquisaEstacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisaEstacao;
        private System.Windows.Forms.ComboBox cbbEstacao;
        private System.Windows.Forms.TextBox txtLocalizacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEstacao;
        private System.Windows.Forms.Button btnCaracteristica;
        private System.Windows.Forms.Button btnSair;
    }
}