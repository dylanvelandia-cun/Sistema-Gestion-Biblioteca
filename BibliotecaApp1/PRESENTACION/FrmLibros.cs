
using System;
using System.Data;
using System.Windows.Forms;
using BibliotecaApp.Negocio;

namespace BibliotecaApp1.PRESENTACION
{
    public partial class FrmLibros : Form
    {
        private LibroNegocio negocio = new LibroNegocio();
        private int idLibroSeleccionado = 0;

        public FrmLibros()
        {
            InitializeComponent();
            CargarAutores();
            CargarEditoriales();
            CargarLibros();
        }

        // CARGAR LIBROS
        private void CargarLibros()
        {
            try
            {
                dgvLibros.AutoGenerateColumns = true;
                dgvLibros.Columns.Clear();
                dgvLibros.DataSource = negocio.ListarLibros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
        }

        // CARGAR AUTORES
        private void CargarAutores()
        {
            try
            {
                cmbAutor.DataSource = negocio.ListarAutores();
                cmbAutor.DisplayMember = "NombreCompleto";
                cmbAutor.ValueMember = "AutorId";
                cmbAutor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message);
            }
        }

        // CARGAR EDITORIALES
        private void CargarEditoriales()
        {
            try
            {
                cmbEditorial.DataSource = negocio.ListarEditoriales();
                cmbEditorial.DisplayMember = "Nombre";
                cmbEditorial.ValueMember = "EditorialId";
                cmbEditorial.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar editoriales: " + ex.Message);
            }
        }

        // GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                negocio.GuardarLibro(
                    txtISBN.Text.Trim(),
                    txtTitulo.Text.Trim(),
                    ObtenerAnio(),
                    Convert.ToInt32(txtExistencias.Text),
                    Convert.ToInt32(cmbAutor.SelectedValue),
                    Convert.ToInt32(cmbEditorial.SelectedValue)
                );

                MessageBox.Show("Libro guardado correctamente.");
                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar libro: " + ex.Message);
            }
        }

        // ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idLibroSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un libro de la tabla.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                negocio.ActualizarLibro(
                    idLibroSeleccionado,
                    txtISBN.Text.Trim(),
                    txtTitulo.Text.Trim(),
                    ObtenerAnio(),
                    Convert.ToInt32(txtExistencias.Text),
                    Convert.ToInt32(cmbAutor.SelectedValue),
                    Convert.ToInt32(cmbEditorial.SelectedValue)
                );

                MessageBox.Show("Libro actualizado correctamente.");
                CargarLibros();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar libro: " + ex.Message);
            }
        }

        // ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idLibroSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un libro de la tabla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar este libro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarLibro(idLibroSeleccionado);

                    MessageBox.Show("Libro eliminado correctamente.");
                    CargarLibros();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar libro: " + ex.Message);
            }
        }

        // LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtISBN.Clear();
            txtTitulo.Clear();
            txtAnio.Clear();
            txtExistencias.Clear();

            cmbAutor.SelectedIndex = -1;
            cmbEditorial.SelectedIndex = -1;

            idLibroSeleccionado = 0;
            dgvLibros.ClearSelection();
        }

        // VALIDAR CAMPOS
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtExistencias.Text))
            {
                MessageBox.Show("ISBN, título y existencias son obligatorios.");
                return false;
            }

            int existencias;
            if (!int.TryParse(txtExistencias.Text, out existencias) ||
                existencias < 0)
            {
                MessageBox.Show("Las existencias deben ser un número igual o mayor que cero.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                int anio;
                if (!int.TryParse(txtAnio.Text, out anio) ||
                    anio < 0 || anio > DateTime.Now.Year)
                {
                    MessageBox.Show("Escribe un año válido.");
                    return false;
                }
            }

            if (cmbAutor.SelectedValue == null ||
                cmbEditorial.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un autor y una editorial.");
                return false;
            }

            return true;
        }

        private int? ObtenerAnio()
        {
            if (string.IsNullOrWhiteSpace(txtAnio.Text))
                return null;

            return Convert.ToInt32(txtAnio.Text);
        }

        // SELECCIONAR LIBRO
        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];

                idLibroSeleccionado =
                    Convert.ToInt32(fila.Cells["LibroId"].Value);

                txtISBN.Text = fila.Cells["ISBN"].Value.ToString();
                txtTitulo.Text = fila.Cells["Titulo"].Value.ToString();

                txtAnio.Text = fila.Cells["Anio"].Value == DBNull.Value
                    ? ""
                    : fila.Cells["Anio"].Value.ToString();

                txtExistencias.Text =
                    fila.Cells["Existencias"].Value.ToString();

                SeleccionarCombo(cmbAutor, fila.Cells["Autor"].Value.ToString());
                SeleccionarCombo(cmbEditorial, fila.Cells["Editorial"].Value.ToString());
            }
        }

        private void SeleccionarCombo(ComboBox combo, string nombre)
        {
            for (int i = 0; i < combo.Items.Count; i++)
            {
                DataRowView fila = combo.Items[i] as DataRowView;

                if (fila != null &&
                    (fila.Row.Table.Columns.Contains("NombreCompleto")
                        ? fila["NombreCompleto"].ToString()
                        : fila["Nombre"].ToString()) == nombre)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }

            combo.SelectedIndex = -1;
        }

        // MÉTODOS CONSERVADOS DEL DISEÑADOR
        private void label3_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }

        private void lblTituloFormulario_Click(object sender, EventArgs e) { }
    }
}
