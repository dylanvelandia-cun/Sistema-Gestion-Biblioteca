using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class ReporteNegocio
    {
        private ReporteDatos datos = new ReporteDatos();

        public DataTable ConsultarReporte(string tipo)
        {
            return datos.ConsultarReporte(tipo);
        }
    }
}