using System;
using System.Data;
using System.Data.SqlClient;

namespace BibliotecaApp.Datos
{
    public class ReporteDatos
    {
        public DataTable ConsultarReporte(string tipo)
        {
            DataTable tabla = new DataTable();

            string consulta = "";

            switch (tipo)
            {
                case "Libros registrados":
                    consulta = @"
                        SELECT 
                            LibroId,
                            ISBN,
                            Titulo,
                            Anio,
                            Existencias
                        FROM Libros";
                    break;

                case "Usuarios registrados":
                    consulta = @"
                        SELECT 
                            UsuarioId,
                            Nombre,
                            Apellido,
                            Documento,
                            Telefono,
                            Correo
                        FROM Usuarios";
                    break;

                case "Todos los préstamos":
                    consulta = @"
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
                    break;

                case "Préstamos devueltos":
                    consulta = @"
                        SELECT 
                            P.PrestamoId,
                            U.Nombre + ' ' + U.Apellido AS Usuario,
                            L.Titulo AS Libro,
                            P.FechaPrestamo,
                            P.FechaDevolucion,
                            P.Estado
                        FROM Prestamos P
                        INNER JOIN Usuarios U ON P.UsuarioId = U.UsuarioId
                        INNER JOIN Libros L ON P.LibroId = L.LibroId
                        WHERE P.Estado = 'Devuelto'";
                    break;

                case "Préstamos pendientes":
                    consulta = @"
                        SELECT 
                            P.PrestamoId,
                            U.Nombre + ' ' + U.Apellido AS Usuario,
                            L.Titulo AS Libro,
                            P.FechaPrestamo,
                            P.FechaDevolucion,
                            P.Estado
                        FROM Prestamos P
                        INNER JOIN Usuarios U ON P.UsuarioId = U.UsuarioId
                        INNER JOIN Libros L ON P.LibroId = L.LibroId
                        WHERE P.Estado = 'Prestado'";
                    break;
            }

            Conexion conectar = new Conexion();

            using (SqlConnection conexion = conectar.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }
    }
}