
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
            this.btnEcluirContEsp = new System.Windows.Forms.Button();
            this.btnVoltarEspeci = new System.Windows.Forms.Button();
            this.lblUsuarioESpe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblalgumcoisa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomentUsuEsp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcomentUsuEsp
            // 
            this.dgvcomentUsuEsp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvcomentUsuEsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomentUsuEsp.Location = new System.Drawing.Point(12, 167);
            this.dgvcomentUsuEsp.Name = "dgvcomentUsuEsp";
            this.dgvcomentUsuEsp.Size = new System.Drawing.Size(916, 288);
            this.dgvcomentUsuEsp.TabIndex = 0;
            this.dgvcomentUsuEsp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomentUsuEsp_CellContentClick);
            // 
            // btnEcluirContEsp
            // 
            this.btnEcluirContEsp.BackColor = System.Drawing.SystemColors.Control;
            this.btnEcluirContEsp.Image = ((System.Drawing.Image)(resources.GetObject("btnEcluirContEsp.Image")));
            this.btnEcluirContEsp.Location = new System.Drawing.Point(54, 468);
            this.btnEcluirContEsp.Name = "btnEcluirContEsp";
            this.btnEcluirContEsp.Size = new System.Drawing.Size(96, 68);
            this.btnEcluirContEsp.TabIndex = 1;
            this.btnEcluirContEsp.UseVisualStyleBackColor = false;
            // 
            // btnVoltarEspeci
            // 
            this.btnVoltarEspeci.BackColor = System.Drawing.SystemColors.Control;
            this.btnVoltarEspeci.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltarEspeci.Image")));
            this.btnVoltarEspeci.Location = new System.Drawing.Point(775, 475);
            this.btnVoltarEspeci.Name = "btnVoltarEspeci";
            this.btnVoltarEspeci.Size = new System.Drawing.Size(104, 53);
            this.btnVoltarEspeci.TabIndex = 2;
            this.btnVoltarEspeci.UseVisualStyleBackColor = false;
            this.btnVoltarEspeci.Click += new System.EventHandler(this.btnVoltarEspeci_Click);
            // 
            // lblUsuarioESpe
            // 
            this.lblUsuarioESpe.AutoSize = true;
            this.lblUsuarioESpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioESpe.Location = new System.Drawing.Point(87, 16);
            this.lblUsuarioESpe.Name = "lblUsuarioESpe";
            this.lblUsuarioESpe.Size = new System.Drawing.Size(51, 20);
            this.lblUsuarioESpe.TabIndex = 3;
            this.lblUsuarioESpe.Text = "Nome";
            this.lblUsuarioESpe.Click += new System.EventHandler(this.lblUsuarioESpe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblalgumcoisa);
            this.groupBox1.Controls.Add(this.lblUsuarioESpe);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(916, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblalgumcoisa
            // 
            this.lblalgumcoisa.AutoSize = true;
            this.lblalgumcoisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalgumcoisa.Location = new System.Drawing.Point(233, 16);
            this.lblalgumcoisa.Name = "lblalgumcoisa";
            this.lblalgumcoisa.Size = new System.Drawing.Size(51, 20);
            this.lblalgumcoisa.TabIndex = 4;
            this.lblalgumcoisa.Text = "label1";
            // 
            // frmUsuarioEspe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(940, 546);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVoltarEspeci);
            this.Controls.Add(this.btnEcluirContEsp);
            this.Controls.Add(this.dgvcomentUsuEsp);
            this.Name = "frmUsuarioEspe";
            this.Text = "frmUsuarioEspe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomentUsuEsp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcomentUsuEsp;
        private System.Windows.Forms.Button btnEcluirContEsp;
        private System.Windows.Forms.Button btnVoltarEspeci;
        private System.Windows.Forms.Label lblUsuarioESpe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblalgumcoisa;
    }
}