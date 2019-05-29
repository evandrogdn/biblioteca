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
    public class GeneroDB
    {
        public static ArrayList getGeneros(NpgsqlConnection conexao)
        {
            ArrayList lista = new ArrayList();

            try
            {
                string sql = "select * from tbgenero order by gencodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int gencodigo = (int)dr["gencodigo"];
                    string gennome = (string)dr["gennome"];

                    Genero genero = new Genero();
                    genero.gencodigo = gencodigo;
                    genero.gennome = gennome;
                    lista.Add(genero);
                }

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return lista;
        }

        public static bool setIncluiGenero(NpgsqlConnection conexao, Genero genero)
        {
            bool incluiu = false;

            try
            {
                string sql = "insert into tbgenero (gennome) values (@gennome);";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@gennome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = genero.gennome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) incluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return incluiu;
        }

        public static bool setExcluiGenero(NpgsqlConnection conexao, int gencodigo)
        {
            bool excluiu = false;

            try
            {
                string sql = "delete from tbgenero where gencodigo = @gencodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@gencodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = gencodigo;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) excluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return excluiu;
        }

        public static bool setAlteraGenero(NpgsqlConnection conexao, Genero genero)
        {
            bool alterou = false;

            try
            {
                string sql = "update tbgenero set gennome = @gennome where gencodigo = @gencodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = genero.gencodigo;
                cmd.Parameters.Add("@gencodigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = genero.gennome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) alterou = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return alterou;
        }

        public static Genero getGenero(NpgsqlConnection conexao, int autcodigo)
        {
            Genero genero = new Genero();

            try
            {
                string sql = "select * from tbgenero where gencodigo = @gencodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@gencodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = autcodigo;

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return genero;
        }
    }
}
