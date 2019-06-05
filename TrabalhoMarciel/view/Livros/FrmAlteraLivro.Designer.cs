namespace TrabalhoMarciel.view.Livros {
    partial class FrmAlteraLivro {
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
            this.comboBoxLocalizacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAutor = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLocalizacao
            // 
            this.comboBoxLocalizacao.FormattingEnabled = true;
            this.comboBoxLocalizacao.Location = new System.Drawing.Point(16, 175);
            this.comboBoxLocalizacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxLocalizacao.Name = "comboBoxLocalizacao";
            this.comboBoxLocalizacao.Size = new System.Drawing.Size(383, 24);
            this.comboBoxLocalizacao.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Localização";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(19, 126);
            this.comboBoxGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(383, 24);
            this.comboBoxGenero.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Gênero";
            // 
            // comboBoxAutor
            // 
            this.comboBoxAutor.FormattingEnabled = true;
            this.comboBoxAutor.Location = new System.Drawing.Point(17, 77);
            this.comboBoxAutor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAutor.Name = "comboBoxAutor";
            this.comboBoxAutor.Size = new System.Drawing.Size(383, 24);
            this.comboBoxAutor.TabIndex = 22;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(197, 207);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(205, 28);
            this.buttonCancelar.TabIndex = 21;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.ButtonCancelar_Click);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(17, 207);
            this.buttonConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(172, 28);
            this.buttonConfirmar.TabIndex = 20;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.ButtonConfirmar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Autor";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(17, 30);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(383, 22);
            this.textBoxNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome";
            // 
            // FrmAlteraLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 246);
            this.Controls.Add(this.comboBoxLocalizacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxAutor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAlteraLivro";
            this.Text = "[Alterando] Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLocalizacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAutor;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
    }
}