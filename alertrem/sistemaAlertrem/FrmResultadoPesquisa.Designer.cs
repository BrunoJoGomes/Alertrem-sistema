
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGrDados = new System.Windows.Forms.DataGridView();
            this.btnVoltarPesq = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrDados)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SpringGreen;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGrDados
            // 
            this.dataGrDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrDados.Location = new System.Drawing.Point(2, 87);
            this.dataGrDados.Name = "dataGrDados";
            this.dataGrDados.Size = new System.Drawing.Size(776, 338);
            this.dataGrDados.TabIndex = 1;
            this.dataGrDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrDados_CellClick);
            // 
            // btnVoltarPesq
            // 
            this.btnVoltarPesq.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltarPesq.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarPesq.Image")));
            this.btnVoltarPesq.Location = new System.Drawing.Point(665, 442);
            this.btnVoltarPesq.Name = "btnVoltarPesq";
            this.btnVoltarPesq.Size = new System.Drawing.Size(100, 50);
            this.btnVoltarPesq.TabIndex = 2;
            this.btnVoltarPesq.UseVisualStyleBackColor = false;
            this.btnVoltarPesq.Click += new System.EventHandler(this.btnVoltarPesq_Click);
            // 
            // FrmResultadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btnVoltarPesq);
            this.Controls.Add(this.dataGrDados);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmResultadoPesquisa";
            this.Text = "FrmResultadoPesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrDados;
        private System.Windows.Forms.Button btnVoltarPesq;
    }
}