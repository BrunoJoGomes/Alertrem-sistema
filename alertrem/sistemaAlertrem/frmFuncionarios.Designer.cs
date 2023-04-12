
namespace sistemaAlertrem
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 110);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(516, 328);
            this.dgvFuncionarios.TabIndex = 0;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Font = new System.Drawing.Font("Museo 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(686, 357);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 81);
            this.btnVoltar2.TabIndex = 1;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.gpbMenu.Location = new System.Drawing.Point(-5, 0);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(809, 56);
            this.gpbMenu.TabIndex = 10;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Museo 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(686, 270);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(102, 81);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(12, 83);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(56, 13);
            this.lblPesquisar.TabIndex = 12;
            this.lblPesquisar.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(74, 76);
            this.txtPesquisa.MaxLength = 100;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(350, 20);
            this.txtPesquisa.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Museo 700", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(686, 183);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 81);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.dgvFuncionarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
    }
}