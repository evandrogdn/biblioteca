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

namespace TrabalhoMarciel.view.Autores {
    public partial class FrmAlteraAutor : Form {

        private NpgsqlConnection conexao = null;
        public FrmAlteraAutor(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            InitializeComponent();

            textBoxCodigo.Text = codigoRegistro.ToString();
            buscaAutor();
        }

        private void buscaAutor()
        {
            Autor autor = AutorDB.getAutor(conexao, int.Parse(textBoxCodigo.Text));
            textBoxAutorNome.Text = autor.autnome;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.autcodigo = int.Parse(textBoxCodigo.Text);
            autor.autnome = textBoxAutorNome.Text;
            bool alterou = AutorDB.setAlteraAutor(conexao, autor);
            if (alterou)
            {
                MessageBox.Show("Registro Alterado!");
                Close();
            } else {
                MessageBox.Show("Falha ao Altarar o Registro!");
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
