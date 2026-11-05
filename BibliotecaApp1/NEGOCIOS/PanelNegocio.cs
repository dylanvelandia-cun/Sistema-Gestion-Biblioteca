using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class PanelNegocio
    {
        private PanelDatos datos = new PanelDatos();

        public int ObtenerTotalLibros()
        {
            return datos.TotalLibros();
        }

        public int ObtenerTotalUsuarios()
        {
            return datos.TotalUsuarios();
        }

        public int ObtenerTotalPrestamosActivos()
        {
            return datos.TotalPrestamosActivos();
        }
    }
}