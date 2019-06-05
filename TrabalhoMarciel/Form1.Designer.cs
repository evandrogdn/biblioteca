namespace TrabalhoMarciel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLivros = new System.Windows.Forms.Button();
            this.buttonAutores = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLivros
            // 
            this.buttonLivros.Location = new System.Drawing.Point(16, 15);
            this.buttonLivros.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLivros.Name = "buttonLivros";
            this.buttonLivros.Size = new System.Drawing.Size(169, 42);
            this.buttonLivros.TabIndex = 0;
            this.buttonLivros.Text = "Livros";
            this.buttonLivros.UseVisualStyleBackColor = true;
            this.buttonLivros.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAutores
            // 
            this.buttonAutores.Location = new System.Drawing.Point(16, 90);
            this.buttonAutores.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAutores.Name = "buttonAutores";
            this.buttonAutores.Size = new System.Drawing.Size(169, 42);
            this.buttonAutores.TabIndex = 1;
            this.buttonAutores.Text = "Autores";
            this.buttonAutores.UseVisualStyleBackColor = true;
            this.buttonAutores.Click += new System.EventHandler(this.ButtonAutores_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Generos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 261);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Localizacao";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonAutores);
            this.Controls.Add(this.buttonLivros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLivros;
        private System.Windows.Forms.Button buttonAutores;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

