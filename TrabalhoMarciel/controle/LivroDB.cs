using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoMarciel.modelo;

namespace TrabalhoMarciel.controle
{
    public class LivroDB
    {
        public static ArrayList getLivros(NpgsqlConnection conexao, Consulta consulta)
        {
            ArrayList lista = new ArrayList();
            try
            {
                //Script de sql para rodar no banco de dados
                string sql = " select * from tblivro ";
                switch (consulta.tipo)
                {
                    case 0://contém  
                           //função UPPER para trasnformar tudo em maiúsculo para consulta
                           //função CAST para trasnformar campos numéricos em texto e aplicar a mesma estrutura para consulta
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) LIKE UPPER('%" + consulta.descricao + "%')";
                        break;
                    case 1://Inicia com
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) LIKE UPPER('" + consulta.descricao + "%')";
                        break;
                    case 2://Termina com
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) LIKE UPPER('%" + consulta.descricao + "')";
                        break;
                    case 3://Maior ou igual
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) >= UPPER('" + consulta.descricao + "')";
                        break;
                    case 4://Menor ou igual
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) <= UPPER('" + consulta.descricao + "')";
                        break;
                    default: //Igual
                        sql += " where UPPER(CAST(" + consulta.campo + " AS TEXT)) = UPPER('" + consulta.descricao + "')";
                        break;
                }
                sql += " order by " + consulta.campo;

                //Objeto command para executar o comando sql
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao; //passando a conexão com o banco que será utilizada 
                cmd.CommandText = sql; //passando o comando sql
                //Criando objeto data reader que receberá a listagem dos campos que retornará do comando de sql
                NpgsqlDataReader dr = cmd.ExecuteReader();
                //Percorrendo a listagem com o campos
                while (dr.Read())
                {
                    //Primeira forma de obter valor do campo através do indice de retorno do sql
                    int livcodigo = dr.GetInt32(0);
                    //Segunda forma de obter o valor do campo através do nome do campo
                    livcodigo = (int)dr["livcodigo"];
                    string livnome = (string)dr["livnome"];
                    //Criando objeto do tipo estado e passando dados aos atributos
                    Livro livro = new Livro();
                    livro.livcodigo = livcodigo;
                    livro.livnome = livnome;
                    //Adicionando o objeto estado na lista que criamos anteriormente
                    lista.Add(livro);
                }
                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                //Gerando informação de erro em caso de gerar alguma exceção
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return lista;
        }

        public static ArrayList getLivros(NpgsqlConnection conexao)
        {
            ArrayList lista = new ArrayList();

            try
            {
                string sql = "select * from tblivro order by livcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int livcodigo = (int)dr["livcodigo"];
                    string livnome = (string)dr["livnome"];

                    Livro livro = new Livro();
                    livro.livcodigo = livcodigo;
                    livro.livnome = livnome;
                    lista.Add(livro);
                }

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return lista;
        }

        public static bool setIncluiLivro(NpgsqlConnection conexao, Livro livro)
        {
            bool incluiu = false;

            try
            {
                string sql = "insert into tblivro (livnome) values (@livnome);";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@livnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.livnome;


                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) incluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return incluiu;
        }

        public static bool setExcluiLivro(NpgsqlConnection conexao, int livcodigo)
        {
            bool excluiu = false;

            try
            {
                string sql = "delete from tblivro where livcodigo = @livcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@livcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = livcodigo;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) excluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return excluiu;
        }

        public static bool setAlteraLivro(NpgsqlConnection conexao, Livro livro)
        {
            bool alterou = false;

            try
            {
                string sql = "update tblivro set livnome = @livnome where livcodigo = @livcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@livcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = livro.livcodigo;
                cmd.Parameters.Add("@livnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.livnome;
                
                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) alterou = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return alterou;
        }

        public static Livro getGenero(NpgsqlConnection conexao, int livcodigo)
        {
            Livro livro = new Livro();

            try
            {
                string sql = "select * from tblivro where livcodigo = @livcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@livcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = livcodigo;

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return livro;
        }
    }
}
