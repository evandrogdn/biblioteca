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
    public partial class FrmAlteraGenero : Form {

        private NpgsqlConnection conexao = null;
        private int codigoRegistro = 0;
        public FrmAlteraGenero(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            this.codigoRegistro = codigoRegistro;
            InitializeComponent();
            buscaGenero();
        }

        private void buscaGenero()
        {
            Genero genero = GeneroDB.getGenero(conexao, this.codigoRegistro);
            textBoxGeneroNome.Text = genero.gennome;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.gencodigo = this.codigoRegistro;
            genero.gennome = textBoxGeneroNome.Text;
            bool alterou = GeneroDB.setAlteraGenero(conexao, genero);
            if (alterou) {
                MessageBox.Show("Registro Alterado!");
                Close();
            } else {
                MessageBox.Show("Falha ao Altarar o Registro!");
            }
        }
    }
}
