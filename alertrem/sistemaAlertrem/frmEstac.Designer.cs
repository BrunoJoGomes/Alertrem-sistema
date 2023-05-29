
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
            this.gpbPesquisaEstacao.Location = new System.Drawing.Point(15, 26);
            this.gpbPesquisaEstacao.Margin = new System.Windows.Forms.Padding(4);
            this.gpbPesquisaEstacao.Name = "gpbPesquisaEstacao";
            this.gpbPesquisaEstacao.Padding = new System.Windows.Forms.Padding(4);
            this.gpbPesquisaEstacao.Size = new System.Drawing.Size(1039, 513);
            this.gpbPesquisaEstacao.TabIndex = 1;
            this.gpbPesquisaEstacao.TabStop = false;
            this.gpbPesquisaEstacao.Enter += new System.EventHandler(this.gpbPesquisaEstacao_Enter);
            // 
            // ltbEstacao
            // 
            this.ltbEstacao.FormattingEnabled = true;
            this.ltbEstacao.ItemHeight = 30;
            this.ltbEstacao.Location = new System.Drawing.Point(41, 132);
            this.ltbEstacao.Margin = new System.Windows.Forms.Padding(4);
            this.ltbEstacao.Name = "ltbEstacao";
            this.ltbEstacao.Size = new System.Drawing.Size(688, 334);
            this.ltbEstacao.TabIndex = 16;
            this.ltbEstacao.SelectedIndexChanged += new System.EventHandler(this.ltbEstacao_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar Estação";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(299, 37);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(431, 37);
            this.txtPesquisar.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(803, 396);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(165, 75);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(803, 258);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(165, 75);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(803, 132);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(165, 75);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmEstac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gpbPesquisaEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEstac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstac";
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