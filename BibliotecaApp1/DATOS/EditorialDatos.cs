using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class EditorialDatos
    {
        private Conexion conexion = new Conexion();

        public DataTable ListarEditoriales()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT EditorialId, Nombre, Pais
                    FROM Editoriales";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public void GuardarEditorial(string nombre, string pais)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Editoriales (Nombre, Pais)
                    VALUES (@Nombre, @Pais)";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Pais", pais);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarEditorial(int id, string nombre, string pais)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Editoriales
                    SET Nombre = @Nombre,
                        Pais = @Pais
                    WHERE EditorialId = @EditorialId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@EditorialId", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Pais", pais);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarEditorial(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta =
                    "DELETE FROM Editoriales WHERE EditorialId = @EditorialId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@EditorialId", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}