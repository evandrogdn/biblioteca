namespace TrabalhoMarciel.view.Generos {
    partial class FrmGenero {
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
            this.gencodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gennome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(403, 133);
            this.Alterar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(100, 28);
            this.Alterar.TabIndex = 11;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(403, 169);
            this.Excluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 28);
            this.Excluir.TabIndex = 10;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Novo
            // 
            this.Novo.Location = new System.Drawing.Point(403, 97);
            this.Novo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gencodigo,
            this.gennome});
            this.dataGridView1.Location = new System.Drawing.Point(24, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(352, 367);
            this.dataGridView1.TabIndex = 8;
            // 
            // gencodigo
            // 
            this.gencodigo.DataPropertyName = "gencodigo";
            this.gencodigo.HeaderText = "Codigo";
            this.gencodigo.Name = "gencodigo";
            // 
            // gennome
            // 
            this.gennome.DataPropertyName = "gennome";
            this.gennome.HeaderText = "Nome";
            this.gennome.Name = "gennome";
            this.gennome.Width = 200;
            // 
            // FrmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 480);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Novo);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGenero";
            this.Text = "FrmGenero";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gencodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gennome;
    }
}