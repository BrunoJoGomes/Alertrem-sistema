
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGrDados = new System.Windows.Forms.DataGridView();
            this.dgvNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGrDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNome,
            this.dataDeCadastro,
            this.codigo,
            this.cpf,
            this.Email});
            this.dataGrDados.Location = new System.Drawing.Point(2, 87);
            this.dataGrDados.Name = "dataGrDados";
            this.dataGrDados.Size = new System.Drawing.Size(776, 338);
            this.dataGrDados.TabIndex = 1;
            this.dataGrDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrDados_CellContentClick);
            // 
            // dgvNome
            // 
            this.dgvNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvNome.HeaderText = "Nome";
            this.dgvNome.MaxInputLength = 100;
            this.dgvNome.Name = "dgvNome";
            this.dgvNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNome.Width = 150;
            // 
            // dataDeCadastro
            // 
            this.dataDeCadastro.HeaderText = "dataCadastro";
            this.dataDeCadastro.MaxInputLength = 100;
            this.dataDeCadastro.Name = "dataDeCadastro";
            this.dataDeCadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDeCadastro.Width = 150;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "codigo";
            this.codigo.MaxInputLength = 100;
            this.codigo.Name = "codigo";
            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigo.Width = 150;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "cpf";
            this.cpf.MaxInputLength = 100;
            this.cpf.Name = "cpf";
            this.cpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cpf.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MaxInputLength = 100;
            this.Email.Name = "Email";
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Email.Width = 150;
            // 
            // FrmResultadoPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrDados);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmResultadoPesquisa";
            this.Text = "FrmResultadoPesquisa";
            this.Load += new System.EventHandler(this.FrmResultadoPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGrDados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}