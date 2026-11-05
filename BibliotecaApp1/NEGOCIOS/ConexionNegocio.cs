
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class ConexionNegocio
    {
        private Conexion conexion = new Conexion();

        public bool VerificarConexion()
        {
            return conexion.ProbarConexion();
        }
    }
}
