using System;
using System.Windows.Forms;
using BibliotecaApp.Negocio;

namespace BibliotecaApp1.PRESENTACION
{
    public partial class FrmReportes : Form
    {
        private ReporteNegocio negocio = new ReporteNegocio();

        public FrmReportes()
        {
            InitializeComponent();

            cmbTipoReporte.Items.Clear();

            cmbTipoReporte.Items.Add("Libros registrados");
            cmbTipoReporte.Items.Add("Usuarios registrados");
            cmbTipoReporte.Items.Add("Todos los préstamos");
            cmbTipoReporte.Items.Add("Préstamos devueltos");
            cmbTipoReporte.Items.Add("Préstamos pendientes");

            cmbTipoReporte.SelectedIndex = 0;

            dgvReportes.AutoGenerateColumns = true;
            dgvReportes.ReadOnly = true;
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoReporte.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecciona un tipo de reporte.");
                    return;
                }

                dgvReportes.DataSource = negocio.ConsultarReporte(
                    cmbTipoReporte.Text
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar reporte: " + ex.Message);
            }
        }
    }
}