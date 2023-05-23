
namespace sistemaAlertrem
{
    partial class frmPerfilFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfilFuncionario));
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.cbbFuncionario = new System.Windows.Forms.ComboBox();
            this.lblNomeDeUsu = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(32, 46);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(121, 13);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Selecione o funcionário:";
            // 
            // cbbFuncionario
            // 
            this.cbbFuncionario.FormattingEnabled = true;
            this.cbbFuncionario.Location = new System.Drawing.Point(153, 38);
            this.cbbFuncionario.Name = "cbbFuncionario";
            this.cbbFuncionario.Size = new System.Drawing.Size(213, 21);
            this.cbbFuncionario.TabIndex = 1;
            // 
            // lblNomeDeUsu
            // 
            this.lblNomeDeUsu.AutoSize = true;
            this.lblNomeDeUsu.Location = new System.Drawing.Point(32, 100);
            this.lblNomeDeUsu.Name = "lblNomeDeUsu";
            this.lblNomeDeUsu.Size = new System.Drawing.Size(90, 13);
            this.lblNomeDeUsu.TabIndex = 2;
            this.lblNomeDeUsu.Text = "Nome de usuário:";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Enabled = false;
            this.txtNomeUsuario.Location = new System.Drawing.Point(153, 92);
            this.txtNomeUsuario.MaxLength = 50;
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(213, 20);
            this.txtNomeUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(32, 162);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(93, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha de acesso:";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtSenha.Location = new System.Drawing.Point(153, 155);
            this.txtSenha.MaxLength = 50;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = 'l';
            this.txtSenha.Size = new System.Drawing.Size(213, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Confirme a senha:";
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.Enabled = false;
            this.txtConfirmaSenha.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtConfirmaSenha.Location = new System.Drawing.Point(153, 214);
            this.txtConfirmaSenha.MaxLength = 50;
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.PasswordChar = 'l';
            this.txtConfirmaSenha.Size = new System.Drawing.Size(213, 20);
            this.txtConfirmaSenha.TabIndex = 4;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(32, 317);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 87);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnCriar
            // 
            this.btnCriar.Image = ((System.Drawing.Image)(resources.GetObject("btnCriar.Image")));
            this.btnCriar.Location = new System.Drawing.Point(477, 38);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(101, 87);
            this.btnCriar.TabIndex = 5;
            this.btnCriar.Text = "&Criar";
            this.btnCriar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(480, 224);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 87);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(480, 317);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 87);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(477, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(101, 87);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmPerfilFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.txtConfirmaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.lblNomeDeUsu);
            this.Controls.Add(this.cbbFuncionario);
            this.Controls.Add(this.lblFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPerfilFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlerTrem";
            this.Load += new System.EventHandler(this.frmPerfilFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ComboBox cbbFuncionario;
        private System.Windows.Forms.Label lblNomeDeUsu;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
    }
}