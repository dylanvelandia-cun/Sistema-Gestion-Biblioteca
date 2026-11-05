
using System;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class UsuarioDatos
    {
        private Conexion conexion = new Conexion();

        public DataTable ListarUsuarios()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT UsuarioId, Nombre, Apellido,
                           Documento, Telefono, Correo
                    FROM Usuarios";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public void GuardarUsuario(string nombre, string apellido,
            string documento, string telefono, string correo)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Usuarios
                    (Nombre, Apellido, Documento, Telefono, Correo)
                    VALUES
                    (@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@Telefono",
                    string.IsNullOrWhiteSpace(telefono) ? (object)DBNull.Value : telefono);
                cmd.Parameters.AddWithValue("@Correo",
                    string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarUsuario(int id, string nombre,
            string apellido, string documento, string telefono, string correo)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Usuarios
                    SET Nombre = @Nombre,
                        Apellido = @Apellido,
                        Documento = @Documento,
                        Telefono = @Telefono,
                        Correo = @Correo
                    WHERE UsuarioId = @UsuarioId";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@UsuarioId", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Documento", documento);
                cmd.Parameters.AddWithValue("@Telefono",
                    string.IsNullOrWhiteSpace(telefono) ? (object)DBNull.Value : telefono);
                cmd.Parameters.AddWithValue("@Correo",
                    string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarUsuario(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta =
                    "DELETE FROM Usuarios WHERE UsuarioId = @UsuarioId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@UsuarioId", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
