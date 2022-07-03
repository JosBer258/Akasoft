using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace ConexionDB
{
    public class Conexion
    {
        public string sql;
        public SqlConnection cnn;
        public SqlCommand comandosql;
        public SqlDataReader dr;
        public DataTable dt;
        public SqlDataAdapter da;

        public Conexion()
        {
            this.cnn = new SqlConnection(@"Data Source=DESKTOP-4UE71IO\SQLEXPRESS;Initial Catalog=; integrated security=true;");
        }

        public void Abrir()
        {
            try
            {
                cnn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de Conexion +", ex.Message);
            }
        }

        public void Cerrar()
        {
            cnn.Close();
        }

    }
}
