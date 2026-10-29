using DroneOpsManager.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DroneOpsManager.Formularios
{
    public partial class frmListadoC : Form
    {
        private const string MensajeBusqueda = "Nombre o NIT";
        cCliente cliente = new cCliente();

        public frmListadoC()
        {
            InitializeComponent();
        }

        void MostrarBusqueda()
        {
            txtBuscar.Text = MensajeBusqueda;
            txtBuscar.ForeColor = Color.Gray;
        }

        private void RenombrarColumna(string nombreColumna, string nuevoTitulo)
        {
            if (dgvClientes.Columns[nombreColumna] != null)
                dgvClientes.Columns[nombreColumna].HeaderText = nuevoTitulo;
        }

        private void OcultarColumna(string nombreColumna)
        {
            if (dgvClientes.Columns[nombreColumna] != null)
                dgvClientes.Columns[nombreColumna].Visible = false;
        }

        private void ConsultarClientes()
        {
            var textoBusqueda = txtBuscar.Text == MensajeBusqueda ? string.Empty : txtBuscar.Text;

            DataTable dt = cliente.Listar(textoBusqueda);

            dgvClientes.DataSource = dt;
            OcultarColumna("IdCliente");
            RenombrarColumna("NombreEmpresa", "Nombre / Empresa");
            RenombrarColumna("NIT", "NIT");
            RenombrarColumna("Contacto", "Contacto");
            RenombrarColumna("Correo", "Correo");
            RenombrarColumna("Telefono", "Teléfono");
            RenombrarColumna("Direccion", "Dirección");

            lblTotal.Text = $"Total: {dt.Rows.Count} cliente(s)";
        }

        private void frmListadoC_Load(object sender, EventArgs e)
        {
            MostrarBusqueda();
            ConsultarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == MensajeBusqueda)
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                MostrarBusqueda();
            }
        }
    }
}