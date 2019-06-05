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

namespace TrabalhoMarciel.view.Generos {
    public partial class FrmNovoGenero : Form {

        private NpgsqlConnection conexao = null;
        public FrmNovoGenero(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            string gennome = textBoxGeneroNome.Text;
            Genero genero = new Genero();
            genero.gennome = gennome;
            bool incluiu = GeneroDB.setIncluiGenero(conexao, genero);
            if (incluiu) {
                MessageBox.Show("Registro Incluido!");
                Close();
            } else {
                MessageBox.Show("Falha ao Incluir Registro!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


}
