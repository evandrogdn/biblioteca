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

namespace TrabalhoMarciel.view.Localizacoes {
    public partial class FrmNovoLocalizacao : Form {
        private NpgsqlConnection conexao = null;

        public FrmNovoLocalizacao(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            string locnome = textBoxLocalizacao.Text;
            Localizacao localizacao = new Localizacao();
            localizacao.locnome = locnome;
            bool incluiu = LocalizacaoDB.setIncluiLocalizacao(conexao, localizacao);
            if (incluiu)
            {
                MessageBox.Show("Registro Incluido!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao Incluir Registro!");
            }
        }
    }
}
