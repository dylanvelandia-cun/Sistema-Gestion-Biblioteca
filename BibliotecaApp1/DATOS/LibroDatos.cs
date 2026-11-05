
using System;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class LibroDatos
    {
        private Conexion conexion = new Conexion();

        // LISTAR LIBROS
        public DataTable ListarLibros()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        L.LibroId,
                        L.ISBN,
                        L.Titulo,
                        L.Anio,
                        L.Existencias,
                        A.Nombre AS Autor,
                        E.Nombre AS Editorial
                    FROM Libros L
                    INNER JOIN Autores A ON L.AutorId = A.AutorId
                    INNER JOIN Editoriales E ON L.EditorialId = E.EditorialId";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        // LISTAR AUTORES
        public DataTable ListarAutores()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT AutorId,
                           Nombre + ' ' + Apellido AS NombreCompleto
                    FROM Autores";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        // LISTAR EDITORIALES
        public DataTable ListarEditoriales()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT EditorialId, Nombre
                    FROM Editoriales";

                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        // GUARDAR LIBRO
        public void GuardarLibro(string isbn, string titulo,
            int? anio, int existencias, int autorId, int editorialId)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Libros
                    (ISBN, Titulo, Anio, Existencias, AutorId, EditorialId)
                    VALUES
                    (@ISBN, @Titulo, @Anio, @Existencias, @AutorId, @EditorialId)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@Anio",
                    anio.HasValue ? (object)anio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Existencias", existencias);
                cmd.Parameters.AddWithValue("@AutorId", autorId);
                cmd.Parameters.AddWithValue("@EditorialId", editorialId);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR LIBRO
        public void ActualizarLibro(int id, string isbn, string titulo,
            int? anio, int existencias, int autorId, int editorialId)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Libros
                    SET ISBN = @ISBN,
                        Titulo = @Titulo,
                        Anio = @Anio,
                        Existencias = @Existencias,
                        AutorId = @AutorId,
                        EditorialId = @EditorialId
                    WHERE LibroId = @LibroId";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@LibroId", id);
                cmd.Parameters.AddWithValue("@ISBN", isbn);
                cmd.Parameters.AddWithValue("@Titulo", titulo);
                cmd.Parameters.AddWithValue("@Anio",
                    anio.HasValue ? (object)anio.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Existencias", existencias);
                cmd.Parameters.AddWithValue("@AutorId", autorId);
                cmd.Parameters.AddWithValue("@EditorialId", editorialId);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ELIMINAR LIBRO
        public void EliminarLibro(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta =
                    "DELETE FROM Libros WHERE LibroId = @LibroId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@LibroId", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
