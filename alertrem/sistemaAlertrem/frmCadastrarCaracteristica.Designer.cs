
namespace sistemaAlertrem
{
    partial class frmCadastrarCaracteristica
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
            this.gpbInfoEstacao = new System.Windows.Forms.GroupBox();
            this.gpbCaracteristicas = new System.Windows.Forms.GroupBox();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.lblCampoNome = new System.Windows.Forms.Label();
            this.lblCampoLocalizacao = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.lblCampoCodigo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstacao = new System.Windows.Forms.ComboBox();
            this.cbbCaracteristica = new System.Windows.Forms.ComboBox();
            this.cbbEstadoOperacional = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnRemoverTodos = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_estacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbInfoEstacao.SuspendLayout();
            this.gpbCaracteristicas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbInfoEstacao
            // 
            this.gpbInfoEstacao.Controls.Add(this.cbbEstacao);
            this.gpbInfoEstacao.Controls.Add(this.lblCodigo);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoCodigo);
            this.gpbInfoEstacao.Controls.Add(this.lblLocalizacao);
            this.gpbInfoEstacao.Controls.Add(this.lblNome);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoLocalizacao);
            this.gpbInfoEstacao.Controls.Add(this.lblCampoNome);
            this.gpbInfoEstacao.Controls.Add(this.lblSelecionar);
            this.gpbInfoEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoEstacao.Location = new System.Drawing.Point(12, 12);
            this.gpbInfoEstacao.Name = "gpbInfoEstacao";
            this.gpbInfoEstacao.Size = new System.Drawing.Size(1057, 145);
            this.gpbInfoEstacao.TabIndex = 0;
            this.gpbInfoEstacao.TabStop = false;
            this.gpbInfoEstacao.Text = "Informações sobre a estação";
            // 
            // gpbCaracteristicas
            // 
            this.gpbCaracteristicas.Controls.Add(this.cbbEstadoOperacional);
            this.gpbCaracteristicas.Controls.Add(this.cbbCaracteristica);
            this.gpbCaracteristicas.Controls.Add(this.lblEstado);
            this.gpbCaracteristicas.Controls.Add(this.lblCaracteristicas);
            this.gpbCaracteristicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCaracteristicas.Location = new System.Drawing.Point(12, 309);
            this.gpbCaracteristicas.Name = "gpbCaracteristicas";
            this.gpbCaracteristicas.Size = new System.Drawing.Size(576, 130);
            this.gpbCaracteristicas.TabIndex = 1;
            this.gpbCaracteristicas.TabStop = false;
            this.gpbCaracteristicas.Text = "Características";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.AllowUserToAddRows = false;
            this.dgvCaracteristicas.AllowUserToDeleteRows = false;
            this.dgvCaracteristicas.AllowUserToResizeColumns = false;
            this.dgvCaracteristicas.AllowUserToResizeRows = false;
            this.dgvCaracteristicas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.tipo,
            this.nome_estado,
            this.nome_estacao});
            this.dgvCaracteristicas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(12, 163);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.Size = new System.Drawing.Size(1057, 140);
            this.dgvCaracteristicas.TabIndex = 2;
            this.dgvCaracteristicas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaracteristicas_CellClick);
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Location = new System.Drawing.Point(6, 38);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(201, 20);
            this.lblSelecionar.TabIndex = 0;
            this.lblSelecionar.Text = "Selecione uma estação:";
            // 
            // lblCampoNome
            // 
            this.lblCampoNome.AutoSize = true;
            this.lblCampoNome.Location = new System.Drawing.Point(6, 70);
            this.lblCampoNome.Name = "lblCampoNome";
            this.lblCampoNome.Size = new System.Drawing.Size(60, 20);
            this.lblCampoNome.TabIndex = 1;
            this.lblCampoNome.Text = "Nome:";
            // 
            // lblCampoLocalizacao
            // 
            this.lblCampoLocalizacao.AutoSize = true;
            this.lblCampoLocalizacao.Location = new System.Drawing.Point(6, 109);
            this.lblCampoLocalizacao.Name = "lblCampoLocalizacao";
            this.lblCampoLocalizacao.Size = new System.Drawing.Size(109, 20);
            this.lblCampoLocalizacao.TabIndex = 2;
            this.lblCampoLocalizacao.Text = "Localização:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(72, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 20);
            this.lblNome.TabIndex = 3;
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(121, 109);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(0, 20);
            this.lblLocalizacao.TabIndex = 4;
            // 
            // lblCampoCodigo
            // 
            this.lblCampoCodigo.AutoSize = true;
            this.lblCampoCodigo.Location = new System.Drawing.Point(506, 38);
            this.lblCampoCodigo.Name = "lblCampoCodigo";
            this.lblCampoCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCampoCodigo.TabIndex = 5;
            this.lblCampoCodigo.Text = "Código:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(582, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 20);
            this.lblCodigo.TabIndex = 6;
            // 
            // lblCaracteristicas
            // 
            this.lblCaracteristicas.AutoSize = true;
            this.lblCaracteristicas.Location = new System.Drawing.Point(6, 48);
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            this.lblCaracteristicas.Size = new System.Drawing.Size(245, 20);
            this.lblCaracteristicas.TabIndex = 0;
            this.lblCaracteristicas.Text = "Selecione uma característica:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(9, 84);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(266, 20);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Selecione o estado operacional:";
            // 
            // cbbEstacao
            // 
            this.cbbEstacao.FormattingEnabled = true;
            this.cbbEstacao.Location = new System.Drawing.Point(213, 35);
            this.cbbEstacao.Name = "cbbEstacao";
            this.cbbEstacao.Size = new System.Drawing.Size(230, 28);
            this.cbbEstacao.TabIndex = 7;
            this.cbbEstacao.Text = "Selecione";
            this.cbbEstacao.SelectedIndexChanged += new System.EventHandler(this.cbbEstacao_SelectedValueChanged);
            // 
            // cbbCaracteristica
            // 
            this.cbbCaracteristica.FormattingEnabled = true;
            this.cbbCaracteristica.Items.AddRange(new object[] {
            "Banheiro",
            "Elevador",
            "Terminal_Interurbano_de_Onibus",
            "Terminal_Urbano_de_Onibus",
            "Transferencia_interna_gratuita",
            "Bicicletario",
            "Banheiro_Acessivel",
            "Estacao_Acessivel",
            "Rampa",
            "Transposicao_de_plataformas",
            "Escadas_rolantes",
            "Acesso_elevador",
            "Lanchonete",
            "Emporio",
            "Caixa_eletronico",
            "Calcados",
            "Telefone_para_surdos",
            "Piso_Tatil",
            "Transferencia_gratuita_cptm_metro",
            "Acessorios",
            "Farmacia",
            "Rota_acesssvel",
            "Achados_e_perdidos"});
            this.cbbCaracteristica.Location = new System.Drawing.Point(257, 45);
            this.cbbCaracteristica.Name = "cbbCaracteristica";
            this.cbbCaracteristica.Size = new System.Drawing.Size(313, 28);
            this.cbbCaracteristica.TabIndex = 2;
            this.cbbCaracteristica.Text = "Selecione";
            // 
            // cbbEstadoOperacional
            // 
            this.cbbEstadoOperacional.FormattingEnabled = true;
            this.cbbEstadoOperacional.Location = new System.Drawing.Point(281, 81);
            this.cbbEstadoOperacional.Name = "cbbEstadoOperacional";
            this.cbbEstadoOperacional.Size = new System.Drawing.Size(289, 28);
            this.cbbEstadoOperacional.TabIndex = 3;
            this.cbbEstadoOperacional.Text = "Selecione";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(610, 331);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(138, 46);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdcionar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(610, 383);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(138, 46);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(931, 354);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(138, 46);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(771, 331);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 46);
            this.btnRemover.TabIndex = 6;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRemoverTodos
            // 
            this.btnRemoverTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverTodos.Location = new System.Drawing.Point(771, 383);
            this.btnRemoverTodos.Name = "btnRemoverTodos";
            this.btnRemoverTodos.Size = new System.Drawing.Size(138, 46);
            this.btnRemoverTodos.TabIndex = 7;
            this.btnRemoverTodos.Text = "Remover todos";
            this.btnRemoverTodos.UseVisualStyleBackColor = true;
            this.btnRemoverTodos.Click += new System.EventHandler(this.btnRemoveTodos_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // nome_estado
            // 
            this.nome_estado.HeaderText = "Estado Operacional";
            this.nome_estado.Name = "nome_estado";
            // 
            // nome_estacao
            // 
            this.nome_estacao.HeaderText = "Estação";
            this.nome_estacao.Name = "nome_estacao";
            // 
            // frmCadastrarCaracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 451);
            this.Controls.Add(this.btnRemoverTodos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvCaracteristicas);
            this.Controls.Add(this.gpbCaracteristicas);
            this.Controls.Add(this.gpbInfoEstacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCaracteristica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Características da estação";
            this.gpbInfoEstacao.ResumeLayout(false);
            this.gpbInfoEstacao.PerformLayout();
            this.gpbCaracteristicas.ResumeLayout(false);
            this.gpbCaracteristicas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbInfoEstacao;
        private System.Windows.Forms.ComboBox cbbEstacao;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCampoCodigo;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCampoLocalizacao;
        private System.Windows.Forms.Label lblCampoNome;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.GroupBox gpbCaracteristicas;
        private System.Windows.Forms.ComboBox cbbEstadoOperacional;
        private System.Windows.Forms.ComboBox cbbCaracteristica;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_estacao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnRemoverTodos;
    }
}