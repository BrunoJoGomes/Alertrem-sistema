
namespace sistemaAlertrem
{
    partial class frmEstac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstac));
            this.gpbPesquisaEstacao = new System.Windows.Forms.GroupBox();
            this.ltbEstacao = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.gpbPesquisaEstacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisaEstacao
            // 
            this.gpbPesquisaEstacao.Controls.Add(this.ltbEstacao);
            this.gpbPesquisaEstacao.Controls.Add(this.label1);
            this.gpbPesquisaEstacao.Controls.Add(this.txtPesquisar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnVoltar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnCadastrar);
            this.gpbPesquisaEstacao.Controls.Add(this.btnPesquisar);
            this.gpbPesquisaEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisaEstacao.Location = new System.Drawing.Point(11, 21);
            this.gpbPesquisaEstacao.Name = "gpbPesquisaEstacao";
            this.gpbPesquisaEstacao.Size = new System.Drawing.Size(779, 417);
            this.gpbPesquisaEstacao.TabIndex = 1;
            this.gpbPesquisaEstacao.TabStop = false;
            this.gpbPesquisaEstacao.Enter += new System.EventHandler(this.gpbPesquisaEstacao_Enter);
            // 
            // ltbEstacao
            // 
            this.ltbEstacao.FormattingEnabled = true;
            this.ltbEstacao.ItemHeight = 25;
            this.ltbEstacao.Location = new System.Drawing.Point(31, 107);
            this.ltbEstacao.Name = "ltbEstacao";
            this.ltbEstacao.Size = new System.Drawing.Size(517, 254);
            this.ltbEstacao.TabIndex = 2;
            this.ltbEstacao.SelectedIndexChanged += new System.EventHandler(this.ltbEstacao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar Estação";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(224, 30);
            this.txtPesquisar.MaxLength = 110;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(324, 31);
            this.txtPesquisar.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(602, 322);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(124, 66);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(602, 210);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 61);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(602, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 61);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmEstac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbPesquisaEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEstac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlerTrem";
            this.gpbPesquisaEstacao.ResumeLayout(false);
            this.gpbPesquisaEstacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisaEstacao;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltbEstacao;
    }
}