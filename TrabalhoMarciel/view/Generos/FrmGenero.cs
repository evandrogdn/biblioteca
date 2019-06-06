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

namespace TrabalhoMarciel.view.Generos {
    public partial class FrmGenero : Form {

        private NpgsqlConnection conexao = null;
        public FrmGenero(NpgsqlConnection conexao) {
            this.conexao = conexao;
            InitializeComponent();

            atualizaTela();
            comboBoxCampo.SelectedIndex = 1;
            comboBoxTipo.SelectedIndex = 0;
            textBoxDescricao.Focus();
        }

        private void atualizaTela()
        {
            ArrayList lista = GeneroDB.getGeneros(conexao);
            dataGridView1.DataSource = lista;
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            FrmNovoGenero form = new FrmNovoGenero(conexao);
            form.ShowDialog();
            atualizaTela();
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            int gencodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FrmAlteraGenero form = new FrmAlteraGenero(conexao, gencodigo);
            form.ShowDialog();
            atualizaTela();
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            int gencodigo = (int)dataGridView1.CurrentRow.Cells[0].Value;
            bool excluir = GeneroDB.setExcluiGenero(conexao, gencodigo);
            if (excluir) {
                MessageBox.Show("Registro Excluído");
                atualizaTela();
            } else {
                MessageBox.Show("Erro ao excluir o registro!");
            }
        }

        private void Consulta()
        {
            Consulta consulta = new Consulta();
            switch (comboBoxCampo.SelectedIndex)
            {
                case 0:
                    consulta.campo = "gencodigo";
                    break;
                default:
                    consulta.campo = "gennome";
                    break;
            }
            consulta.tipo = comboBoxTipo.SelectedIndex;
            consulta.descricao = textBoxDescricao.Text;
            dataGridView1.DataSource = GeneroDB.getGeneros(conexao, consulta);
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
