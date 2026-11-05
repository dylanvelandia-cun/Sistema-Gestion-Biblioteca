
using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class AutorNegocio
    {
        private AutorDatos datos = new AutorDatos();

        public DataTable ListarAutores()
        {
            return datos.ListarAutores();
        }

        public void GuardarAutor(string nombre, string apellido)
        {
            datos.GuardarAutor(nombre, apellido);
        }

        public void ActualizarAutor(int id, string nombre, string apellido)
        {
            datos.ActualizarAutor(id, nombre, apellido);
        }

        public void EliminarAutor(int id)
        {
            datos.EliminarAutor(id);
        }
    }
}
