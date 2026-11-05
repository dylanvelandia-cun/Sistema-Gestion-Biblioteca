
using System.Data;
using BibliotecaApp.Datos;

namespace BibliotecaApp.Negocio
{
    public class LibroNegocio
    {
        private LibroDatos datos = new LibroDatos();

        // LISTAR LIBROS
        public DataTable ListarLibros()
        {
            return datos.ListarLibros();
        }

        // LISTAR AUTORES
        public DataTable ListarAutores()
        {
            return datos.ListarAutores();
        }

        // LISTAR EDITORIALES
        public DataTable ListarEditoriales()
        {
            return datos.ListarEditoriales();
        }

        // GUARDAR LIBRO
        public void GuardarLibro(string isbn, string titulo,
            int? anio, int existencias, int autorId, int editorialId)
        {
            datos.GuardarLibro(
                isbn, titulo, anio, existencias, autorId, editorialId);
        }

        // ACTUALIZAR LIBRO
        public void ActualizarLibro(int id, string isbn, string titulo,
            int? anio, int existencias, int autorId, int editorialId)
        {
            datos.ActualizarLibro(
                id, isbn, titulo, anio, existencias, autorId, editorialId);
        }

        // ELIMINAR LIBRO
        public void EliminarLibro(int id)
        {
            datos.EliminarLibro(id);
        }
    }
}
