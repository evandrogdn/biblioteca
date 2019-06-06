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
        public FrmAlteraGenero(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            InitializeComponent();
            textBoxCodigo.Text = Convert.ToString(codigoRegistro);
            buscaGenero();
        }

        private void buscaGenero()
        {
            Genero genero = GeneroDB.getGenero(conexao, Convert.ToInt32(textBoxCodigo.Text));
            textBoxGeneroNome.Text = genero.gennome;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            genero.gencodigo = int.Parse(textBoxCodigo.Text);
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
