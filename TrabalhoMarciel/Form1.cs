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
using TrabalhoMarciel.view.Autores;
using TrabalhoMarciel.view.Generos;
using TrabalhoMarciel.view.Livros;
using TrabalhoMarciel.view.Localizacoes;

namespace TrabalhoMarciel
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conexao = null;

        public Form1()
        {
            InitializeComponent();
            //criando e recebendo conexão ativa com o banco de dados
            conexao = Conexao.getConexao();
            InitializeComponent();
            //Verificando se houve conexão com o banco
            if (conexao == null)
            {
                //Se não houve, gera mensagem para o usuário e finaliza a aplicação
                MessageBox.Show("Erro de conexão com o banco. Aplicação será finalizada.");
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            FrmLivro form = new FrmLivro(conexao);
            form.showDialog();
        }

        private void button3_Click(object sender, EventArgs e) {
            FrmGenero form = new FrmGenero(conexao);
            form.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAutores_Click(object sender, EventArgs e)
        {
            FrmAutor form = new FrmAutor(conexao);
            form.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Fechando a conexão com o banco de dados
            Conexao.setFechaConexao(conexao);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FrmLocalizacao form = new FrmLocalizacao(conexao);
            form.ShowDialog();
        }
    }
}
