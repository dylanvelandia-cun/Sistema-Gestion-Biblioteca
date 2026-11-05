using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class EditorialNegocio
    {
        private EditorialDatos datos = new EditorialDatos();

        public DataTable ListarEditoriales()
        {
            return datos.ListarEditoriales();
        }

        public void GuardarEditorial(string nombre, string pais)
        {
            datos.GuardarEditorial(nombre, pais);
        }

        public void ActualizarEditorial(int id, string nombre, string pais)
        {
            datos.ActualizarEditorial(id, nombre, pais);
        }

        public void EliminarEditorial(int id)
        {
            datos.EliminarEditorial(id);
        }
    }
}