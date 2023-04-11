
namespace sistemaAlertrem
{
    partial class frmComentarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComentarios));
            this.dgvComentarios = new System.Windows.Forms.DataGridView();
            this.gpbComentarios = new System.Windows.Forms.GroupBox();
            this.btnVoltar2 = new System.Windows.Forms.Button();
            this.gpbMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            this.gpbComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComentarios
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Museo 700", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComentarios.Location = new System.Drawing.Point(6, 39);
            this.dgvComentarios.Name = "dgvComentarios";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Museo 700", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComentarios.Size = new System.Drawing.Size(776, 330);
            this.dgvComentarios.TabIndex = 0;
            this.dgvComentarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComentarios_CellContentClick);
            // 
            // gpbComentarios
            // 
            this.gpbComentarios.Controls.Add(this.dgvComentarios);
            this.gpbComentarios.Font = new System.Drawing.Font("Museo 700", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComentarios.Location = new System.Drawing.Point(12, 70);
            this.gpbComentarios.Name = "gpbComentarios";
            this.gpbComentarios.Size = new System.Drawing.Size(798, 387);
            this.gpbComentarios.TabIndex = 1;
            this.gpbComentarios.TabStop = false;
            this.gpbComentarios.Text = "Comentarios";
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(816, 376);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(102, 81);
            this.btnVoltar2.TabIndex = 4;
            this.btnVoltar2.Text = "&Voltar";
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // gpbMenu
            // 
            this.gpbMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.gpbMenu.Location = new System.Drawing.Point(-1, -1);
            this.gpbMenu.Name = "gpbMenu";
            this.gpbMenu.Size = new System.Drawing.Size(992, 56);
            this.gpbMenu.TabIndex = 10;
            this.gpbMenu.TabStop = false;
            this.gpbMenu.Text = "Menu";
            // 
            // frmComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 491);
            this.Controls.Add(this.gpbMenu);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.gpbComentarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alertrem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            this.gpbComentarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.GroupBox gpbComentarios;
        private System.Windows.Forms.Button btnVoltar2;
        private System.Windows.Forms.GroupBox gpbMenu;
    }
}