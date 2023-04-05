
namespace sistemaAlertrem
{
    partial class usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuarios));
            this.pictBoxCor = new System.Windows.Forms.PictureBox();
            this.pictboxImagemUsu = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAdicionarfoto = new System.Windows.Forms.Button();
            this.btnExcuirfoto = new System.Windows.Forms.Button();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagemUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBoxCor
            // 
            this.pictBoxCor.BackColor = System.Drawing.Color.SpringGreen;
            this.pictBoxCor.Location = new System.Drawing.Point(0, -1);
            this.pictBoxCor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictBoxCor.Name = "pictBoxCor";
            this.pictBoxCor.Size = new System.Drawing.Size(806, 63);
            this.pictBoxCor.TabIndex = 0;
            this.pictBoxCor.TabStop = false;
            // 
            // pictboxImagemUsu
            // 
            this.pictboxImagemUsu.ErrorImage = null;
            this.pictboxImagemUsu.Image = ((System.Drawing.Image)(resources.GetObject("pictboxImagemUsu.Image")));
            this.pictboxImagemUsu.Location = new System.Drawing.Point(264, 121);
            this.pictboxImagemUsu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictboxImagemUsu.Name = "pictboxImagemUsu";
            this.pictboxImagemUsu.Size = new System.Drawing.Size(226, 147);
            this.pictboxImagemUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictboxImagemUsu.TabIndex = 2;
            this.pictboxImagemUsu.TabStop = false;
            this.pictboxImagemUsu.Click += new System.EventHandler(this.pictboxImagemUsu_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(700, 425);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(73, 48);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdicionarfoto
            // 
            this.btnAdicionarfoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdicionarfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarfoto.Image")));
            this.btnAdicionarfoto.Location = new System.Drawing.Point(509, 132);
            this.btnAdicionarfoto.Name = "btnAdicionarfoto";
            this.btnAdicionarfoto.Size = new System.Drawing.Size(86, 57);
            this.btnAdicionarfoto.TabIndex = 6;
            this.btnAdicionarfoto.Text = "Adicionar Foto";
            this.btnAdicionarfoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdicionarfoto.UseVisualStyleBackColor = false;
            this.btnAdicionarfoto.Click += new System.EventHandler(this.btnAdicionarfoto_Click);
            // 
            // btnExcuirfoto
            // 
            this.btnExcuirfoto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExcuirfoto.Image = ((System.Drawing.Image)(resources.GetObject("btnExcuirfoto.Image")));
            this.btnExcuirfoto.Location = new System.Drawing.Point(509, 213);
            this.btnExcuirfoto.Name = "btnExcuirfoto";
            this.btnExcuirfoto.Size = new System.Drawing.Size(86, 55);
            this.btnExcuirfoto.TabIndex = 7;
            this.btnExcuirfoto.Text = "Excluir Foto";
            this.btnExcuirfoto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcuirfoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcuirfoto.UseVisualStyleBackColor = false;
            this.btnExcuirfoto.Click += new System.EventHandler(this.button2_Click);
            // 
            // textUsuario
            // 
            this.textUsuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(228, 323);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(304, 29);
            this.textUsuario.TabIndex = 8;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(227, 296);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(324, 376);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 66);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.btnExcuirfoto);
            this.Controls.Add(this.btnAdicionarfoto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictboxImagemUsu);
            this.Controls.Add(this.pictBoxCor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "usuarios";
            this.Text = "usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictboxImagemUsu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBoxCor;
        private System.Windows.Forms.PictureBox pictboxImagemUsu;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAdicionarfoto;
        private System.Windows.Forms.Button btnExcuirfoto;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnPesquisar;
    }
}