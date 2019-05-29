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
    public class AutorDB
    {
        public static ArrayList getAutors(NpgsqlConnection conexao)
        {
            ArrayList lista = new ArrayList();

            try
            {
                string sql = "select * from tbautor order by autcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int autcodigo = (int)dr["autcodigo"];
                    string autnome = (string)dr["autnome"];

                    Autor Autor = new Autor();
                    Autor.autcodigo = autcodigo;
                    Autor.autnome = autnome;
                    lista.Add(Autor);
                }

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return lista;
        }

        public static bool setIncluiAutor(NpgsqlConnection conexao, Autor autor)
        {
            bool incluiu = false;

            try
            {
                string sql = "insert into tbautor (autnome) values (@autnome);";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = autor.autnome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) incluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return incluiu;
        }

        public static bool setExcluiAutor(NpgsqlConnection conexao, int autcodigo)
        {
            bool excluiu = false;

            try
            {
                string sql = "delete from tbautor where autcodigo = @autcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = autcodigo;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) excluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return excluiu;
        }

        public static bool setAlteraAutor(NpgsqlConnection conexao, Autor autor)
        {
            bool alterou = false;

            try
            {
                string sql = "update tbautor set autnome = @autnome where autcodigo = @autcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = autor.autcodigo;
                cmd.Parameters.Add("@autnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = autor.autnome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) alterou = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return alterou;
        }

        public static Autor getAutor(NpgsqlConnection conexao, int autcodigo)
        {
            Autor autor = new Autor();

            try
            {
                string sql = "select * from tbautor where autcodigo = @autcodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = autcodigo;

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return autor;
        }
    }
}
