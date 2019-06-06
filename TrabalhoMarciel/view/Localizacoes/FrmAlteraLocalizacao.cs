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
    public partial class FrmAlteraLocalizacao : Form {
        private NpgsqlConnection conexao = null;
        public FrmAlteraLocalizacao(NpgsqlConnection conexao, int codigoRegistro) {
            this.conexao = conexao;
            InitializeComponent();
            textBoxCodigo.Text = Convert.ToString(codigoRegistro);

            buscaLocalizacao();
        }
        
        private void buscaLocalizacao()
        {
            Localizacao localizacao = LocalizacaoDB.getLocalizacao(conexao, Convert.ToInt32(textBoxCodigo.Text));
            textBoxNome.Text = localizacao.locnome;
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            Localizacao localizacao = new Localizacao();
            localizacao.loccodigo = Convert.ToInt32(textBoxCodigo.Text);
            localizacao.locnome = textBoxNome.Text;
            bool alterou = LocalizacaoDB.setAlteraLocalizacao(conexao, localizacao);
            if (alterou)
            {
                MessageBox.Show("Registro Alterado!");
                Close();
            }
            else
            {
                MessageBox.Show("Falha ao Altarar o Registro!");
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
