using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMarciel.controle
{
    public class Conexao
    {
        public static NpgsqlConnection getConexao()
        {
            //Objeto que conterá a conexao ativa com o banco de dados
            NpgsqlConnection conexao = null;

            try
            {
                // Criando o objeto com a url de conexão passando por parametro os dados para a conexao com o banco de dados
                conexao = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=financeiro;");
                //Abrindo a conexão para o objeto tendo assim uma conexao ativa com o banco de dados
                conexao.Open();
            }
            catch (NpgsqlException erro)
            {
                conexao = null;
                // Mensagem de erro em caso de gerar alguma exceção. a variável erro é o objeto que vai conter as informações de erro e da exceção gerada
                Console.WriteLine("Erro de Conexao com o banco: " + erro.Message);
            }

            return conexao;
        }

        /// <summary>
        /// Método responsável porn fechar a conexão com o banco de dados
        /// </summary>
        /// <param name="conexao">Conexao com o banco de dados que é desejado fechar</param>
        public static void setFechaConexao(NpgsqlConnection conexao)
        {
            // Verificandon se o objeto conexao existe para então tentar fechar o mesmo
            if (conexao != null)
            {
                try
                {
                    // Método para fechar a conexão
                    conexao.Close();
                }
                catch (NpgsqlException erro)
                {
                    // Em caso de erro ao fechar a conexão gera mensagem que vai conter as informações da exceção gerada
                    Console.WriteLine("Erro ao fechar conexão: " + erro.Message);
                }
            }
        }

    }
}
