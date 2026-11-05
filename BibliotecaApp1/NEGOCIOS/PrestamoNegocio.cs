using System;
using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class PrestamoNegocio
    {
        private PrestamoDatos datos = new PrestamoDatos();

        public DataTable ListarPrestamos()
        {
            return datos.ListarPrestamos();
        }

        public DataTable ListarUsuarios()
        {
            return datos.ListarUsuarios();
        }

        public DataTable ListarLibros()
        {
            return datos.ListarLibros();
        }

        public void GuardarPrestamo(
            int usuarioId,
            int libroId,
            DateTime fechaPrestamo,
            DateTime? fechaDevolucion,
            string estado)
        {
            datos.GuardarPrestamo(
                usuarioId,
                libroId,
                fechaPrestamo,
                fechaDevolucion,
                estado
            );
        }

        public void ActualizarPrestamo(
            int id,
            int usuarioId,
            int libroId,
            DateTime fechaPrestamo,
            DateTime? fechaDevolucion,
            string estado)
        {
            datos.ActualizarPrestamo(
                id,
                usuarioId,
                libroId,
                fechaPrestamo,
                fechaDevolucion,
                estado
            );
        }

        public void EliminarPrestamo(int id)
        {
            datos.EliminarPrestamo(id);
        }
    }
}