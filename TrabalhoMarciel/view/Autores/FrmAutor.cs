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

namespace TrabalhoMarciel.view.Autores {
    public partial class FrmAutor : Form {

        private NpgsqlConnection conexao = null;
        public FrmAutor(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();

            atualizaTela();
        }

        private void atualizaTela()
        {
            ArrayList lista = AutorDB.getAutors(conexao);
            dataGridView1.DataSource = lista;
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            FrmNovoAutor form = new FrmNovoAutor(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            int autcodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FrmAlteraAutor form = new FrmAlteraAutor(conexao, autcodigo);
            form.ShowDialog();
            atualizaTela();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int autcodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            bool excluir = AutorDB.setExcluiAutor(conexao, autcodigo);
            if (excluir)
            {
                MessageBox.Show("Registro Excluído!");
                atualizaTela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir o registro!");
            }
        }
    }
}
