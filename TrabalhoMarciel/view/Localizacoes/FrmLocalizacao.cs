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
using TrabalhoMarciel.modelo;

namespace TrabalhoMarciel.view.Localizacoes {
    public partial class FrmLocalizacao : Form {

        private NpgsqlConnection conexao = null;
        public FrmLocalizacao(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();

            atualizaTela();
            comboBoxCampo.SelectedIndex = 1;
            comboBoxTipo.SelectedIndex = 0;
            textBoxDescricao.Focus();
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

        private void consulta()
        {
            Consulta consulta = new Consulta();
            switch (comboBoxCampo.SelectedIndex)
            {
                case 0:
                    consulta.campo = "est_sigla";
                    break;
                default:
                    consulta.campo = "nome";
                    break;
            }
            consulta.tipo = comboBoxTipo.SelectedIndex;
            consulta.descricao = textBoxDescricao.Text;
            dataGridView1.DataSource = LocalizacaoDB.getLocalizacoes(conexao);
        }
    }
}
