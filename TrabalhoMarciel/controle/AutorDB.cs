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
        public static ArrayList getAutors(NpgsqlConnection conexao, Consulta consulta)
        {
            ArrayList lista = new ArrayList();
            try
            {
                //Script de sql para rodar no banco de dados
                string sql = " select * from tbautor ";
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
                    int autcodigo = dr.GetInt32(0);
                    //Segunda forma de obter o valor do campo através do nome do campo
                    autcodigo = (int)dr["autcodigo"];
                    string autnome = (string)dr["autnome"];
                    //Criando objeto do tipo estado e passando dados aos atributos
                    Autor autor = new Autor();
                    autor.autcodigo = autcodigo;
                    autor.autnome = autnome;
                    //Adicionando o objeto estado na lista que criamos anteriormente
                    lista.Add(autor);
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
                cmd.Parameters.Add("@autcodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = autor.autcodigo;
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
