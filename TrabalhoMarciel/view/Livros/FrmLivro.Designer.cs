namespace TrabalhoMarciel.view.Livros {
    partial class FrmLivro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.livcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.livcodigo,
            this.livnome});
            this.dataGridView1.Location = new System.Drawing.Point(13, 124);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(357, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // livcodigo
            // 
            this.livcodigo.DataPropertyName = "livcodigo";
            this.livcodigo.HeaderText = "Código";
            this.livcodigo.Name = "livcodigo";
            // 
            // livnome
            // 
            this.livnome.DataPropertyName = "livnome";
            this.livnome.HeaderText = "Nome";
            this.livnome.Name = "livnome";
            this.livnome.Width = 200;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(395, 170);
            this.Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(100, 28);
            this.Alterar.TabIndex = 7;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(395, 218);
            this.Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 28);
            this.Excluir.TabIndex = 6;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(395, 124);
            this.Novo.Margin = new System.Windows.Forms.Padding(4);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(100, 28);
            this.Novo.TabIndex = 5;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(237, 52);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(263, 22);
            this.textBoxDescricao.TabIndex = 15;
            this.textBoxDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDescricao_KeyPress);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Contém",
            "Inicia com",
            "Termina com",
            ">=",
            "<=",
            "Igual"});
            this.comboBoxTipo.Location = new System.Drawing.Point(129, 52);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(99, 24);
            this.comboBoxTipo.TabIndex = 14;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Codigo",
            "Nome"});
            this.comboBoxCampo.Location = new System.Drawing.Point(21, 52);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(99, 24);
            this.comboBoxCampo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Campo";
            // 
            // FrmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 510);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.comboBoxCampo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLivro";
            this.Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.DataGridViewTextBoxColumn livcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn livnome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}