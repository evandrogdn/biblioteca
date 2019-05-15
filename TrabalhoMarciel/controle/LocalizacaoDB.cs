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
    public class LocalizacaoDB
    {
        public static ArrayList getGeneros(NpgsqlConnection conexao)
        {
            ArrayList lista = new ArrayList();

            try
            {
                string sql = "select * from tblocalizacao order by loccodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int loccodigo = (int)dr["gencodigo"];
                    string locnome = (string)dr["gennome"];

                    Localizacao localizacao = new Localizacao();
                    localizacao.loccodigo = loccodigo;
                    localizacao.locnome = locnome;
                    lista.Add(localizacao);
                }

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return lista;
        }

        public static bool setIncluiLocalizacao(NpgsqlConnection conexao, Localizacao localizacao)
        {
            bool incluiu = false;

            try
            {
                string sql = "insert into tblocalizacao (locnome) values (@locnome);";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@locnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = localizacao.locnome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) incluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return incluiu;
        }

        public static bool setExcluiGenero(NpgsqlConnection conexao, int loccodigo)
        {
            bool excluiu = false;

            try
            {
                string sql = "delete from tblocalizacao where loccodigo = @loccodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@loccodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = loccodigo;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) excluiu = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return excluiu;
        }

        public static bool setAlteraGenero(NpgsqlConnection conexao, Localizacao localizacao)
        {
            bool alterou = false;

            try
            {
                string sql = "update tblocalizacao set locnome = @locnome where loccodigo = @loccodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@loccodigo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = localizacao.loccodigo;
                cmd.Parameters.Add("@locnome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = localizacao.locnome;

                int valor = cmd.ExecuteNonQuery();
                if (valor == 1) alterou = true;
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return alterou;
        }

        public static Localizacao getGenero(NpgsqlConnection conexao, int loccodigo)
        {
            Localizacao localizacao = new Localizacao();

            try
            {
                string sql = "select * from tblocalizacao where loccodigo = @loccodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@loccodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = loccodigo;

                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                dr.Close();
            }
            catch (NpgsqlException erro)
            {
                Console.WriteLine("Erro de sql: " + erro.Message);
            }

            return localizacao;
        }
    }
}
