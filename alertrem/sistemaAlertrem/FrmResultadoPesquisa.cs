using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistemaAlertrem
{
    public partial class FrmResultadoPesquisa : Form
    {
        public FrmResultadoPesquisa()
        {
            InitializeComponent();
        }

        MySqlConnection conn = Conexao.obterConexao();
        public MySqlCommand cmd = new MySqlCommand();

        public DataTable dt = new DataTable();
        public MySqlDataAdapter da = new MySqlDataAdapter();
        public DataSet ds = new DataSet();


        public void ExecutarConsulta(string sql)
        {
            try
            {
                Conexao.obterConexao();
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch 
            {
                throw;
            }
                  
        }


        public DataTable GetRegistros(string MySql)
        {
            try
            {
                dt = new DataTable();
                da = new MySqlDataAdapter(MySql, conn);
                da.Fill(dt);
                return dt;
            }
            catch
            {
                throw;
            }
        }


        class Conexao
        {
            MySqlConnection conn = new MySqlConnection();
            private static string connString = "Server=10.23.49.30; port=3306; uid=alertrem; pwd=alertrem;database=db_alertrem";
            private static MySqlConnection con = null;


            public static MySqlConnection obterConexao()
            {
                con = new MySqlConnection(connString);
                try
                {
                    con.Open();
                }
                catch (MySqlException)
                {
                    con = null;
                }
                return con;
            }

            public static void fecharConexao()
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
        
        

        private void FrmResultadoPesquisa_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void TbResultado_Click(object sender, EventArgs e)
        {

        }

        private void dataGrDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
