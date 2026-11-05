
using System;
using System.Windows.Forms;
using BibliotecaApp.Negocio;

namespace BibliotecaApp1.PRESENTACION
{
    public partial class FrmAutores : Form
    {
        private AutorNegocio negocio = new AutorNegocio();
        private int idAutorSeleccionado = 0;

        public FrmAutores()
        {
            InitializeComponent();
            CargarAutores();
        }

        // CARGAR AUTORES
        private void CargarAutores()
        {
            try
            {
                dgvAutores.AutoGenerateColumns = true;
                dgvAutores.Columns.Clear();
                dgvAutores.DataSource = negocio.ListarAutores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message);
            }
        }

        // GUARDAR AUTOR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                negocio.GuardarAutor(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim()
                );

                MessageBox.Show("Autor guardado correctamente.");

                CargarAutores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar autor: " + ex.Message);
            }
        }

        // ACTUALIZAR AUTOR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAutorSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un autor de la tabla.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                negocio.ActualizarAutor(
                    idAutorSeleccionado,
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim()
                );

                MessageBox.Show("Autor actualizado correctamente.");

                CargarAutores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar autor: " + ex.Message);
            }
        }

        // ELIMINAR AUTOR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idAutorSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un autor de la tabla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar este autor?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarAutor(idAutorSeleccionado);

                    MessageBox.Show("Autor eliminado correctamente.");

                    CargarAutores();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar autor: " + ex.Message);
            }
        }

        // LIMPIAR CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();

            idAutorSeleccionado = 0;
            dgvAutores.ClearSelection();
        }

        // VALIDAR CAMPOS
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Debes ingresar el nombre y apellido del autor.");
                return false;
            }

            return true;
        }

        // SELECCIONAR AUTOR
        private void dgvAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idAutorSeleccionado = Convert.ToInt32(
                    dgvAutores.Rows[e.RowIndex].Cells["AutorId"].Value
                );

                txtNombre.Text =
                    dgvAutores.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

                txtApellido.Text =
                    dgvAutores.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            }
        }
    }
}
