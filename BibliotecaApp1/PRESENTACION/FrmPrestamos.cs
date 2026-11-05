using System;
using System.Windows.Forms;
using BibliotecaApp.Negocio;

namespace BibliotecaApp1.PRESENTACION
{
    public partial class FrmPrestamos : Form
    {
        private PrestamoNegocio negocio = new PrestamoNegocio();
        private int idPrestamoSeleccionado = 0;

        public FrmPrestamos()
        {
            InitializeComponent();

            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Prestado");
            cmbEstado.Items.Add("Devuelto");
            cmbEstado.Items.Add("Vencido");
            cmbEstado.SelectedIndex = 0;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(15);

            CargarUsuarios();
            CargarLibros();
            CargarPrestamos();
        }

        private void CargarUsuarios()
        {
            cmbUsuario.DataSource = negocio.ListarUsuarios();
            cmbUsuario.DisplayMember = "NombreCompleto";
            cmbUsuario.ValueMember = "UsuarioId";
            cmbUsuario.SelectedIndex = -1;
        }

        private void CargarLibros()
        {
            cmbLibro.DataSource = negocio.ListarLibros();
            cmbLibro.DisplayMember = "Titulo";
            cmbLibro.ValueMember = "LibroId";
            cmbLibro.SelectedIndex = -1;
        }

        private void CargarPrestamos()
        {
            try
            {
                dgvPrestamos.AutoGenerateColumns = true;
                dgvPrestamos.Columns.Clear();
                dgvPrestamos.DataSource = negocio.ListarPrestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar préstamos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                negocio.GuardarPrestamo(
                    Convert.ToInt32(cmbUsuario.SelectedValue),
                    Convert.ToInt32(cmbLibro.SelectedValue),
                    dtpFechaPrestamo.Value.Date,
                    dtpFechaDevolucion.Value.Date,
                    cmbEstado.Text
                );

                MessageBox.Show("Préstamo guardado correctamente.");

                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar préstamo: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPrestamoSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un préstamo de la tabla.");
                    return;
                }

                if (!ValidarCampos())
                    return;

                negocio.ActualizarPrestamo(
                    idPrestamoSeleccionado,
                    Convert.ToInt32(cmbUsuario.SelectedValue),
                    Convert.ToInt32(cmbLibro.SelectedValue),
                    dtpFechaPrestamo.Value.Date,
                    dtpFechaDevolucion.Value.Date,
                    cmbEstado.Text
                );

                MessageBox.Show("Préstamo actualizado correctamente.");

                CargarPrestamos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar préstamo: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idPrestamoSeleccionado == 0)
                {
                    MessageBox.Show("Selecciona un préstamo de la tabla.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de eliminar este préstamo?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (respuesta == DialogResult.Yes)
                {
                    negocio.EliminarPrestamo(idPrestamoSeleccionado);

                    MessageBox.Show("Préstamo eliminado correctamente.");

                    CargarPrestamos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar préstamo: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbUsuario.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;

            dtpFechaPrestamo.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(15);

            idPrestamoSeleccionado = 0;
            dgvPrestamos.ClearSelection();
        }

        private bool ValidarCampos()
        {
            if (cmbUsuario.SelectedIndex == -1 ||
                cmbLibro.SelectedIndex == -1 ||
                cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un usuario, un libro y un estado.");
                return false;
            }

            if (dtpFechaDevolucion.Value.Date < dtpFechaPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución no puede ser anterior al préstamo.");
                return false;
            }

            return true;
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idPrestamoSeleccionado = Convert.ToInt32(
                    dgvPrestamos.Rows[e.RowIndex].Cells["PrestamoId"].Value
                );

                cmbUsuario.Text =
                    dgvPrestamos.Rows[e.RowIndex].Cells["Usuario"].Value.ToString();

                cmbLibro.Text =
                    dgvPrestamos.Rows[e.RowIndex].Cells["Libro"].Value.ToString();

                dtpFechaPrestamo.Value = Convert.ToDateTime(
                    dgvPrestamos.Rows[e.RowIndex].Cells["FechaPrestamo"].Value
                );

                if (dgvPrestamos.Rows[e.RowIndex].Cells["FechaDevolucion"].Value != DBNull.Value)
                {
                    dtpFechaDevolucion.Value = Convert.ToDateTime(
                        dgvPrestamos.Rows[e.RowIndex].Cells["FechaDevolucion"].Value
                    );
                }

                cmbEstado.Text =
                    dgvPrestamos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstado.Text == "Devuelto")
            {
                dtpFechaDevolucion.Value = DateTime.Today;
            }
        }
    }
}