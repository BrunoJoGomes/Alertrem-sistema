using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistemaAlertrem
{
    class Conexao
    {
        private static string connString = "Server=10.23.49.40; port=3306; uid=alertrem; pwd=alertrem; database=db_alertrem";
        //private static string connString = "Server=127.0.0.1; port=3306; uid=alertrem; pwd=alertrem; database=db_alertrem";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

        public static bool testarConexao()
        {
            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        public static MySqlDataReader select(string campo, string tabela, string where = "")
        {
            try
            {
                MySqlCommand comm;
                if (where == "")
                {
                    comm = new MySqlCommand
                    {
                        CommandText = $"SELECT {campo} FROM {tabela}",
                        CommandType = CommandType.Text,
                        Connection = Conexao.obterConexao()
                    };
                }
                else
                {
                    comm = new MySqlCommand
                    {
                        CommandText = $"SELECT {campo} FROM {tabela} where {where}",
                        CommandType = CommandType.Text,
                        Connection = Conexao.obterConexao()
                    };
                }
                Console.WriteLine(comm.CommandText);
                return comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro no select\n\n{e}\n\n");
                return null;
            }
        }
    }
}
