
namespace sistemaAlertrem
{
    partial class frmEstacao1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstacao1));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.ltbEstacoes = new System.Windows.Forms.ListBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.lblEstacoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(672, 79);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 88);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(672, 188);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(102, 81);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(672, 308);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 81);
            this.btnVoltar2.TabIndex = 3;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // ltbEstacoes
            // 
            this.ltbEstacoes.FormattingEnabled = true;
            this.ltbEstacoes.Location = new System.Drawing.Point(12, 161);
            this.ltbEstacoes.Name = "ltbEstacoes";
            this.ltbEstacoes.Size = new System.Drawing.Size(464, 277);
            this.ltbEstacoes.TabIndex = 6;
            this.ltbEstacoes.Click += new System.EventHandler(this.ltbEstacoes_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(12, 95);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(273, 20);
            this.txtPesquisa.TabIndex = 0;
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(12, 79);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisa.TabIndex = 8;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // lblEstacoes
            // 
            this.lblEstacoes.AutoSize = true;
            this.lblEstacoes.Location = new System.Drawing.Point(12, 145);
            this.lblEstacoes.Name = "lblEstacoes";
            this.lblEstacoes.Size = new System.Drawing.Size(54, 13);
            this.lblEstacoes.TabIndex = 9;
            this.lblEstacoes.Text = "Estações:";
            // 
            // frmEstacao1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEstacoes);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.ltbEstacoes);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmEstacao1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.ListBox ltbEstacoes;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.Label lblEstacoes;
    }
}