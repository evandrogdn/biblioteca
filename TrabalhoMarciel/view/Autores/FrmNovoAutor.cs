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
    public partial class FrmNovoAutor : Form {

        private NpgsqlConnection conexao = null;

        public FrmNovoAutor(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string autnome = textBoxAutorNome.Text;
            Autor autor = new Autor();
            autor.autnome = autnome;
            bool incluiu = AutorDB.setIncluiAutor(conexao, autor);
            if (incluiu) {
                MessageBox.Show("Registro Incluido!");
                Close();
            } else {
                MessageBox.Show("Falha ao Incluir Registro!");
            }
        }
    }
}
