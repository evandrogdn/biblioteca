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

namespace TrabalhoMarciel.view.Livros {
    public partial class FrmLivro : Form {

        private NpgsqlConnection conexao = null;
        public FrmLivro(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();

            atualizaTela();
            comboBoxCampo.SelectedIndex = 1;
            comboBoxTipo.SelectedIndex = 0;
            textBoxDescricao.Focus();
        }

        private void atualizaTela()
        {
            ArrayList lista = LivroDB.getLivros(conexao);
            dataGridView1.DataSource = lista;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Novo_Click(object sender, EventArgs e)
        {
            FrmNovoLivro form = new FrmNovoLivro(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            int livcodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FrmAlteraLivro form = new FrmAlteraLivro(conexao, livcodigo);
            form.ShowDialog();
            atualizaTela();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int livcodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            bool excluir = LivroDB.setExcluiLivro(conexao, livcodigo);
            if (excluir)
            {
                MessageBox.Show("Registro Excluído com sucesso!");
                atualizaTela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro!");
            }
        }
        private void Consulta()
        {
            Consulta consulta = new Consulta();
            switch (comboBoxCampo.SelectedIndex)
            {
                case 0:
                    consulta.campo = "livcodigo";
                    break;
                default:
                    consulta.campo = "livnome";
                    break;
            }
            consulta.tipo = comboBoxTipo.SelectedIndex;
            consulta.descricao = textBoxDescricao.Text;
            dataGridView1.DataSource = LivroDB.getLivros(conexao, consulta);
        }

        private void TextBoxDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se pressionado a tecla enter
            if (e.KeyChar == (char)13)
            {
                Consulta();
            }
        }
    }
}
