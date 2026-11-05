using System;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class PrestamoDatos
    {
        private Conexion conexion = new Conexion();

        public DataTable ListarPrestamos()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        P.PrestamoId,
                        U.Nombre + ' ' + U.Apellido AS Usuario,
                        L.Titulo AS Libro,
                        P.FechaPrestamo,
                        P.FechaDevolucion,
                        P.Estado
                    FROM Prestamos P
                    INNER JOIN Usuarios U ON P.UsuarioId = U.UsuarioId
                    INNER JOIN Libros L ON P.LibroId = L.LibroId";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public DataTable ListarUsuarios()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT UsuarioId,
                           Nombre + ' ' + Apellido AS NombreCompleto
                    FROM Usuarios";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public DataTable ListarLibros()
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    SELECT LibroId, Titulo
                    FROM Libros";

                SqlDataAdapter adaptador =
                    new SqlDataAdapter(consulta, cn);

                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public void GuardarPrestamo(
            int usuarioId,
            int libroId,
            DateTime fechaPrestamo,
            DateTime? fechaDevolucion,
            string estado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO Prestamos
                    (UsuarioId, LibroId, FechaPrestamo, FechaDevolucion, Estado)
                    VALUES
                    (@UsuarioId, @LibroId, @FechaPrestamo, @FechaDevolucion, @Estado)";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@LibroId", libroId);
                cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                cmd.Parameters.AddWithValue(
                    "@FechaDevolucion",
                    (object)fechaDevolucion ?? DBNull.Value
                );
                cmd.Parameters.AddWithValue("@Estado", estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarPrestamo(
            int id,
            int usuarioId,
            int libroId,
            DateTime fechaPrestamo,
            DateTime? fechaDevolucion,
            string estado)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta = @"
                    UPDATE Prestamos
                    SET UsuarioId = @UsuarioId,
                        LibroId = @LibroId,
                        FechaPrestamo = @FechaPrestamo,
                        FechaDevolucion = @FechaDevolucion,
                        Estado = @Estado
                    WHERE PrestamoId = @PrestamoId";

                SqlCommand cmd = new SqlCommand(consulta, cn);

                cmd.Parameters.AddWithValue("@PrestamoId", id);
                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@LibroId", libroId);
                cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                cmd.Parameters.AddWithValue(
                    "@FechaDevolucion",
                    (object)fechaDevolucion ?? DBNull.Value
                );
                cmd.Parameters.AddWithValue("@Estado", estado);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarPrestamo(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                string consulta =
                    "DELETE FROM Prestamos WHERE PrestamoId = @PrestamoId";

                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@PrestamoId", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}