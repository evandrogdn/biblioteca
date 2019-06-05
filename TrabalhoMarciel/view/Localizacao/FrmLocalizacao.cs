using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoMarciel.controle;

namespace TrabalhoMarciel.view.Localizacao {
    public partial class FrmLocalizacao : Form {

        private NpgsqlConnection conexao = null;
        public FrmLocalizacao(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();

            atualizaTela();
        }

        private void atualizaTela()
        {
            ArrayList lista = LocalizacaoDB.getLocalizacoes(conexao);
            dataGridView1.DataSource = lista;
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            FrmNovoLocalizacao form = new FrmNovoLocalizacao(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            int loccodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FrmAlteraLocalizacao form = new FrmAlteraLocalizacao(conexao, loccodigo);
            form.ShowDialog();
            atualizaTela();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int loccodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            bool excluiu = LocalizacaoDB.setExcluiLocalizacao(conexao, loccodigo);
            if (excluiu)
            {
                MessageBox.Show("Registro excluído com sucesso!");
                atualizaTela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir  o registro!");
            }
        }
    }
}
