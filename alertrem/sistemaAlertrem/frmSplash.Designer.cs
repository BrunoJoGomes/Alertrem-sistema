﻿
namespace sistemaAlertrem
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.lblPorcent = new System.Windows.Forms.Label();
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.btnLoading = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctIcone
            // 
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(281, 95);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(255, 193);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIcone.TabIndex = 0;
            this.pctIcone.TabStop = false;
            // 
            // lblPorcent
            // 
            this.lblPorcent.AutoSize = true;
            this.lblPorcent.Font = new System.Drawing.Font("Museo 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcent.Location = new System.Drawing.Point(389, 300);
            this.lblPorcent.Name = "lblPorcent";
            this.lblPorcent.Size = new System.Drawing.Size(38, 23);
            this.lblPorcent.TabIndex = 1;
            this.lblPorcent.Text = "0%";
            // 
            // pgbLoading
            // 
            this.pgbLoading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pgbLoading.Location = new System.Drawing.Point(281, 326);
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(255, 14);
            this.pgbLoading.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Museo 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(348, 352);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(135, 23);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Carregando...";
            // 
            // btnLoading
            // 
            this.btnLoading.Font = new System.Drawing.Font("Museo 700", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoading.Location = new System.Drawing.Point(661, 399);
            this.btnLoading.Name = "btnLoading";
            this.btnLoading.Size = new System.Drawing.Size(127, 39);
            this.btnLoading.TabIndex = 0;
            this.btnLoading.Text = "Loading";
            this.btnLoading.UseVisualStyleBackColor = true;
            this.btnLoading.Click += new System.EventHandler(this.btnLoading_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 58);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLoading);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.pctIcone);
            this.Controls.Add(this.lblPorcent);
            this.Name = "frmSplash";
            this.Text = "frmSplash";
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctIcone;
        private System.Windows.Forms.Label lblPorcent;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button btnLoading;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}