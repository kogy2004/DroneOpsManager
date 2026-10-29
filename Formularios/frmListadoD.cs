using DroneOpsManager.Clases;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DroneOpsManager.Formularios
{
    public partial class frmListadoD : Form
    {
        private const string MensajeBusqueda = "Marca, modelo o código";
        cDrone drone = new cDrone();

        public frmListadoD()
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
            if (dgvDrones.Columns[nombreColumna] != null)
                dgvDrones.Columns[nombreColumna].HeaderText = nuevoTitulo;
        }

        private void OcultarColumna(string nombreColumna)
        {
            if (dgvDrones.Columns[nombreColumna] != null)
                dgvDrones.Columns[nombreColumna].Visible = false;
        }

        private void ConsultarDrones()
        {
            // Filtro por estado: null significa "Todos"
            string estado = null;
            if (cmbEstado.SelectedIndex > 0)
            {
                estado = cmbEstado.Text;
            }

            var textoBusqueda = txtBuscar.Text == MensajeBusqueda ? string.Empty : txtBuscar.Text;

            DataTable dt = drone.Listar(estado, textoBusqueda);

            dgvDrones.DataSource = dt;
            OcultarColumna("IdDrone");
            RenombrarColumna("CodigoDrone", "Código");
            RenombrarColumna("NumeroSerie", "Número de serie");
            RenombrarColumna("FechaCompra", "Fecha de compra");
            RenombrarColumna("HorasVuelo", "Horas de vuelo");

            if (dgvDrones.Columns["FechaCompra"] != null)
            {
                dgvDrones.Columns["FechaCompra"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            lblTotal.Text = $"Total: {dt.Rows.Count} dron(es)";
        }

        private void frmListadoD_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            MostrarBusqueda();
            ConsultarDrones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultarDrones();
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