
namespace sistemaAlertrem
{
    partial class FrmResultadoPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResultadoPesquisa));
            this.dataGrDados = new System.Windows.Forms.DataGridView();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrDados
            // 
            this.dataGrDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrDados.Location = new System.Drawing.Point(12, 103);
            this.dataGrDados.Name = "dataGrDados";
            this.dataGrDados.Size = new System.Drawing.Size(688, 389);
            this.dataGrDados.TabIndex = 1;
            this.dataGrDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrDados_CellClick);
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.gpbMenu.Location = new System.Drawing.Point(-6, -1);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(820, 56);
            this.gpbMenu.TabIndex = 10;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(726, 411);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 81);
            this.btnVoltar2.TabIndex = 11;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // FrmResultadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 504);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.dataGrDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResultadoPesquisa";
            this.Text = "Alertrem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrDados;
        private System.Windows.Forms.GroupBox gpbMenu;
        private System.Windows.Forms.Button btnVoltar2;
    }
}