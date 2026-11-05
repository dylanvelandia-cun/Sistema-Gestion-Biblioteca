using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class UsuarioNegocio
    {
        private UsuarioDatos datos = new UsuarioDatos();

        public DataTable ListarUsuarios()
        {
            return datos.ListarUsuarios();
        }

        public void GuardarUsuario(string nombre, string apellido,
            string documento, string telefono, string correo)
        {
            datos.GuardarUsuario(nombre, apellido, documento, telefono, correo);
        }

        public void ActualizarUsuario(int id, string nombre,
            string apellido, string documento, string telefono, string correo)
        {
            datos.ActualizarUsuario(id, nombre, apellido, documento, telefono, correo);
        }

        public void EliminarUsuario(int id)
        {
            datos.EliminarUsuario(id);
        }
    }
}