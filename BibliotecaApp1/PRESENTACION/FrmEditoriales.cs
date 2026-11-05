using System;
using System.Windows.Forms;
using BibliotecaApp.Negocio;

namespace BibliotecaApp1.PRESENTACION
{
    public partial class FrmEditoriales : Form
    {
        private EditorialNegocio negocio = new EditorialNegocio();
        private int idEditorialSeleccionada = 0;

        public FrmEditoriales()
        {
            InitializeComponent();
            CargarEditoriales();
        }

        private void CargarEditoriales()
        {
            try
            {
                dgvEditoriales.AutoGenerateColumns = true;
                dgvEditoriales.Columns.Clear();
                dgvEditoriales.DataSource = negocio.ListarEditoriales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar editoriales: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                negocio.GuardarEditorial(
                    txtNombre.Text.Trim(),
                    txtPais.Text.Trim()
                );

                MessageBox.Show("Editorial guardada correctamente.");
                CargarEditoriales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar editorial: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idEditorialSeleccionada == 0)
                {
                    MessageBox.Show("Selecciona una editorial de la tabla.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                negocio.ActualizarEditorial(
                    idEditorialSeleccionada,
                    txtNombre.Text.Trim(),
                    txtPais.Text.Trim()
                );

                MessageBox.Show("Editorial actualizada correctamente.");
                CargarEditoriales();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar editorial: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idEditorialSeleccionada == 0)
                {
                    MessageBox.Show("Selecciona una editorial de la tabla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar esta editorial?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarEditorial(idEditorialSeleccionada);

                    MessageBox.Show("Editorial eliminada correctamente.");
                    CargarEditoriales();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar editorial: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtPais.Clear();

            idEditorialSeleccionada = 0;
            dgvEditoriales.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Debes ingresar el nombre y el país de la editorial.");
                return false;
            }

            return true;
        }

        private void dgvEditoriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEditorialSeleccionada = Convert.ToInt32(
                    dgvEditoriales.Rows[e.RowIndex].Cells["EditorialId"].Value
                );

                txtNombre.Text =
                    dgvEditoriales.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                txtPais.Text =
                    dgvEditoriales.Rows[e.RowIndex].Cells["Pais"].Value.ToString();
            }
        }
    }
}