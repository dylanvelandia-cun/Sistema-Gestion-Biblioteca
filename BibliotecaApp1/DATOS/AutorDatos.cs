
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class AutorDatos
    {
        private Conexion conexion = new Conexion();

        // LISTAR AUTORES
        public DataTable ListarAutores()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT AutorId, Nombre, Apellido
                    FROM Autores";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        // GUARDAR AUTOR
        public void GuardarAutor(string nombre, string apellido)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Autores (Nombre, Apellido)
                    VALUES (@Nombre, @Apellido)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR AUTOR
        public void ActualizarAutor(int id, string nombre, string apellido)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Autores
                    SET Nombre = @Nombre,
                        Apellido = @Apellido
                    WHERE AutorId = @AutorId";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@AutorId", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ELIMINAR AUTOR
        public void EliminarAutor(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta =
                    "DELETE FROM Autores WHERE AutorId = @AutorId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@AutorId", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
