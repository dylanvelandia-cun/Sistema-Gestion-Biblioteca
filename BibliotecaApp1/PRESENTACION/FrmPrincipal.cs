
using System;
using System.Windows.Forms;
using BibliotecaApp.Negocio;
using BibliotecaApp1.PRESENTACION;

namespace BibliotecaApp.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ProbarConexion();
            CargarIndicadores();
        }

        private void ProbarConexion()
        {
            ConexionNegocio negocio = new ConexionNegocio();

            if (negocio.VerificarConexion())
            {
                MessageBox.Show(
                    "¡Conexión exitosa con BibliotecaDB!",
                    "Sistema de Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "No se pudo conectar con SQL Server.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void CargarIndicadores()
        {
            PanelNegocio negocio = new PanelNegocio();

            try
            {
                lblTotalLibros.Text =
                    negocio.ObtenerTotalLibros().ToString();

                lblTotalUsuarios.Text =
                    negocio.ObtenerTotalUsuarios().ToString();

                lblTotalPrestamos.Text =
                    negocio.ObtenerTotalPrestamosActivos().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los indicadores: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
        }

        // BOTÓN INICIO
        private void btnInicio_Click(object sender, EventArgs e)
        {
            CargarIndicadores();

            MessageBox.Show(
                "Bienvenido al panel principal.",
                "Inicio",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmLibros formulario = new FrmLibros();
            formulario.ShowDialog();

            CargarIndicadores();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios formulario = new FrmUsuarios();
            formulario.ShowDialog();

            CargarIndicadores();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FrmAutores formulario = new FrmAutores();
            formulario.ShowDialog();
        }

        private void btnEditoriales_Click(object sender, EventArgs e)
        {
            FrmEditoriales formulario = new FrmEditoriales();
            formulario.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos formulario = new FrmPrestamos();
            formulario.ShowDialog();

            CargarIndicadores();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes formulario = new FrmReportes();
            formulario.ShowDialog();
        }

        // Eventos existentes del diseñador
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }
    }
}
