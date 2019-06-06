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
        public static ArrayList getLocalizacoes(NpgsqlConnection conexao, Consulta consulta)
        {
            ArrayList lista = new ArrayList();
            try
            {
                //Script de sql para rodar no banco de dados
                string sql = " select * from tblocalizacao ";
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
                    int loccodigo = dr.GetInt32(0);
                    //Segunda forma de obter o valor do campo através do nome do campo
                    loccodigo = (int)dr["loccodigo"];
                    string locnome = (string)dr["locnome"];
                    //Criando objeto do tipo estado e passando dados aos atributos
                    Localizacao localizacao = new Localizacao();
                    localizacao.loccodigo = loccodigo;
                    localizacao.locnome = locnome;
                    //Adicionando o objeto estado na lista que criamos anteriormente
                    lista.Add(localizacao);
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

        public static ArrayList getLocalizacoes(NpgsqlConnection conexao)
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
                    int loccodigo = (int)dr["loccodigo"];
                    string locnome = (string)dr["locnome"];

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

        public static bool setExcluiLocalizacao(NpgsqlConnection conexao, int loccodigo)
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

        public static bool setAlteraLocalizacao(NpgsqlConnection conexao, Localizacao localizacao)
        {
            bool alterou = false;

            try
            {
                string sql = "update tblocalizacao set locnome = @locnome where loccodigo = @loccodigo;";
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sql;
                cmd.Parameters.Add("@loccodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = localizacao.loccodigo;
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

        public static Localizacao getLocalizacao(NpgsqlConnection conexao, int loccodigo)
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
