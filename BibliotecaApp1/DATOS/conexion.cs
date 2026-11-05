
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Data Source=DESKTOP-UKNM6V8\SQLEXPRESS;
              Initial Catalog=BibliotecaDB;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public bool ProbarConexion()
        {
            try
            {
                using (SqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
