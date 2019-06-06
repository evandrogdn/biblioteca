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
    public partial class FrmNovoLivro : Form {

        private NpgsqlConnection conexao = null;
        public FrmNovoLivro(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            string livnome = textBoxLivroNome.Text;
            Livro livro = new Livro();
            livro.livnome = livnome;
            bool alterou = LivroDB.setIncluiLivro(conexao, livro);
            if (alterou) {
                MessageBox.Show("Registro Alterado!");
                Close();
            } else {
                MessageBox.Show("Falha ao Altarar o Registro!");
            }
        }
    }
}
