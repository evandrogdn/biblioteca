﻿namespace TrabalhoMarciel.view.Autores {
    partial class FrmAutor {
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
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Novo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.autcodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(407, 134);
            this.Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(100, 28);
            this.Alterar.TabIndex = 11;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(407, 181);
            this.Excluir.Margin = new System.Windows.Forms.Padding(4);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 28);
            this.Excluir.TabIndex = 10;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(407, 84);
            this.Novo.Margin = new System.Windows.Forms.Padding(4);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(100, 28);
            this.Novo.TabIndex = 9;
            this.Novo.Text = "Novo";
            this.Novo.UseVisualStyleBackColor = true;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.autcodigo,
            this.nome});
            this.dataGridView1.Location = new System.Drawing.Point(13, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 367);
            this.dataGridView1.TabIndex = 8;
            // 
            // autcodigo
            // 
            this.autcodigo.DataPropertyName = "autcodigo";
            this.autcodigo.HeaderText = "Codigo";
            this.autcodigo.Name = "autcodigo";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "autnome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 200;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(234, 36);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(263, 22);
            this.textBoxDescricao.TabIndex = 17;
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
            this.comboBoxTipo.Location = new System.Drawing.Point(126, 36);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(99, 24);
            this.comboBoxTipo.TabIndex = 16;
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Items.AddRange(new object[] {
            "Sigla",
            "Nome"});
            this.comboBoxCampo.Location = new System.Drawing.Point(18, 36);
            this.comboBoxCampo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(99, 24);
            this.comboBoxCampo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Campo";
            // 
            // FrmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 462);
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
            this.Name = "FrmAutor";
            this.Text = "Autores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn autcodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}