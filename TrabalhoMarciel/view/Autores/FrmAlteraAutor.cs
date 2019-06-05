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
        private int codigoRegistro = 0;
        public FrmAlteraAutor(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            this.codigoRegistro = codigoRegistro;
            InitializeComponent();
            buscaAutor();
        }

        private void buscaAutor()
        {
            Autor autor = AutorDB.getAutor(conexao, this.codigoRegistro);
            textBoxAutorNome.Text = autor.autnome;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.autcodigo = this.codigoRegistro;
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
