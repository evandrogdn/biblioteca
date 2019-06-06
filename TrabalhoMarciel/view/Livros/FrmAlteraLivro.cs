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
        public FrmAlteraLivro(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            InitializeComponent();

            textBoxCodigo.Text = Convert.ToString(codigoRegistro);
            buscaLivro();
        }

        private void buscaLivro()
        {
            Livro livro = LivroDB.getGenero(conexao, Convert.ToInt32(textBoxCodigo.Text));
            textBoxNome.Text = livro.livnome;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            livro.livcodigo = Convert.ToInt32(textBoxCodigo.Text);
            livro.livnome = textBoxNome.Text;
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
