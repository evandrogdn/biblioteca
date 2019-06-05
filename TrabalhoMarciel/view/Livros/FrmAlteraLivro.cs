using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoMarciel.controle;
using TrabalhoMarciel.modelo;

namespace TrabalhoMarciel.view.Livros {
    public partial class FrmAlteraLivro : Form {

        private NpgsqlConnection conexao = null;
        private int codigoRegistro = 0;
        public FrmAlteraLivro(NpgsqlConnection conexao, int codigoRegistro) {
            this.codigoRegistro = codigoRegistro;
            this.conexao = conexao;
            InitializeComponent();

            buscaLivro();
        }

        private void buscaLivro()
        {
            Livro livro = LivroDB.getGenero(conexao, this.codigoRegistro);
            textBoxNome.Text = livro.livnome;
            comboBoxAutor.Text          = livro.autor;
            comboBoxGenero.Text         = livro.genero;
            comboBoxLocalizacao.Text    = livro.localizacao;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.livcodigo = this.codigoRegistro;
            livro.livnome = textBoxNome.Text;
            livro.autor = comboBoxAutor.Text;
            livro.genero = comboBoxGenero.Text;
            livro.localizacao = comboBoxLocalizacao.Text;
            bool alterou = LivroDB.setAlteraLivro(conexao, livro);
            if (alterou) {
                MessageBox.Show("Registro Alterado!");
                Close();
            } else {
                MessageBox.Show("Falha ao Altarar o Registro!");
            }
        }
    }
}
