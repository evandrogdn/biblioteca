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
                    int localizacao = (int)dr["localizacao"];
                    int genero = (int)dr["genero"];

                    Livro livro = new Livro();
                    livro.livcodigo = livcodigo;
                    livro.livnome = livnome;
                    livro.localizacao = localizacao;
                    livro.genero = genero;
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
                string sql = "insert into tblivro (livnome, localizacao, genero) values (@livnome, @localizacao, @genero, @autor);";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@livnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.livnome;
                cmd.Parameters.Add("@localizacao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.localizacao;
                cmd.Parameters.Add("@genero", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.genero;
                cmd.Parameters.Add("@autor", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.autor;


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
                string sql = "update tblivro set livnome = @livnome, localizacao = @localizacao, genero = @genero where livcodigo = @livcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.livcodigo;
                cmd.Parameters.Add("@livnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.livnome;
                cmd.Parameters.Add("@localizacao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.localizacao;
                cmd.Parameters.Add("@genero", NpgsqlTypes.NpgsqlDbType.Varchar).Value = livro.genero;
                
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
