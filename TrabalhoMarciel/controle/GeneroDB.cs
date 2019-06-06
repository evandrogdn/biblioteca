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
        public static ArrayList getGeneros(NpgsqlConnection conexao, Consulta consulta)
        {
            ArrayList lista = new ArrayList();
            try
            {
                //Script de sql para rodar no banco de dados
                string sql = " select * from tbgenero ";
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
                    int gencodigo = dr.GetInt32(0);
                    //Segunda forma de obter o valor do campo através do nome do campo
                    gencodigo = (int)dr["gencodigo"];
                    string gennome = (string)dr["gennome"];
                    //Criando objeto do tipo estado e passando dados aos atributos
                    Genero genero = new Genero();
                    genero.gencodigo = gencodigo;
                    genero.gennome = gennome;
                    //Adicionando o objeto estado na lista que criamos anteriormente
                    lista.Add(genero);
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
                cmd.Parameters.Add("@gencodigo", NpgsqlTypes.NpgsqlDbType.Integer).Value = genero.gencodigo;
                cmd.Parameters.Add("@gennome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = genero.gennome;

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
