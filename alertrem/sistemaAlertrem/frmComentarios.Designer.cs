
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).BeginInit();
            this.gpbComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComentarios
            // 
            this.dgvComentarios.AllowDrop = true;
            this.dgvComentarios.AllowUserToAddRows = false;
            this.dgvComentarios.AllowUserToDeleteRows = false;
            this.dgvComentarios.AllowUserToResizeColumns = false;
            this.dgvComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvComentarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Museo 700", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComentarios.Location = new System.Drawing.Point(4, 26);
            this.dgvComentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComentarios.MultiSelect = false;
            this.dgvComentarios.Name = "dgvComentarios";
            this.dgvComentarios.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Museo 700", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComentarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComentarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvComentarios.Size = new System.Drawing.Size(1355, 446);
            this.dgvComentarios.TabIndex = 1;
            this.dgvComentarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComentarios_CellContentClick);
            // 
            // gpbComentarios
            // 
            this.gpbComentarios.Controls.Add(this.dgvComentarios);
            this.gpbComentarios.Font = new System.Drawing.Font("Museo 700", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComentarios.Location = new System.Drawing.Point(13, 13);
            this.gpbComentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbComentarios.Name = "gpbComentarios";
            this.gpbComentarios.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbComentarios.Size = new System.Drawing.Size(1363, 476);
            this.gpbComentarios.TabIndex = 1;
            this.gpbComentarios.TabStop = false;
            this.gpbComentarios.Text = "&Comentários";
            // 
            // btnVoltar2
            // 
            this.btnVoltar2.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar2.Image")));
            this.btnVoltar2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVoltar2.Location = new System.Drawing.Point(1236, 497);
            this.btnVoltar2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVoltar2.Name = "btnVoltar2";
            this.btnVoltar2.Size = new System.Drawing.Size(136, 49);
            this.btnVoltar2.TabIndex = 0;
            this.btnVoltar2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar2.UseVisualStyleBackColor = true;
            this.btnVoltar2.Click += new System.EventHandler(this.btnVoltar2_Click);
            // 
            // frmComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 556);
            this.Controls.Add(this.btnVoltar2);
            this.Controls.Add(this.gpbComentarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmComentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentários";
            this.Load += new System.EventHandler(this.frmComentarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComentarios)).EndInit();
            this.gpbComentarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComentarios;
        private System.Windows.Forms.GroupBox gpbComentarios;
        private System.Windows.Forms.Button btnVoltar2;
    }
}