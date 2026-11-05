using System;
using System.Data.SqlClient;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Datos
{
    public class PanelDatos
    {
        public int TotalLibros()
        {
            Conexion conectar = new Conexion();

            using (SqlConnection conexion = conectar.ObtenerConexion())
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM Libros";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    return Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }

        public int TotalUsuarios()
        {
            Conexion conectar = new Conexion();

            using (SqlConnection conexion = conectar.ObtenerConexion())
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM Usuarios";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    return Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }

        public int TotalPrestamosActivos()
        {
            Conexion conectar = new Conexion();

            using (SqlConnection conexion = conectar.ObtenerConexion())
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) FROM Prestamos WHERE Estado = 'Prestado'";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    return Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }
    }
}