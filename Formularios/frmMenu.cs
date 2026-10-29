using System;
using System.Windows.Forms;

namespace DroneOpsManager.Formularios
{
    public partial class frmMenu : Form
    {
        private Form activeForm = null;

        public frmMenu()
        {
            InitializeComponent();
            disenoPersonal();
        }

        void disenoPersonal()
        {
            pnlClientes.Visible = false;
            pnlDrones.Visible = false;
        }

        void ocultarSubmenu()
        {
            if (pnlClientes.Visible)
                pnlClientes.Visible = false;
            if (pnlDrones.Visible)
                pnlDrones.Visible = false;
        }

        void mostrarSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void AbrirenPanel(Form frmHijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = frmHijo;
            frmHijo.TopLevel = false;
            frmHijo.FormBorderStyle = FormBorderStyle.None;
            frmHijo.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(frmHijo);
            pnlCentral.Tag = frmHijo;
            frmHijo.BringToFront();
            frmHijo.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlClientes);
        }

        private void btnRegistroC_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmCliente());
            ocultarSubmenu();
        }

        private void btnListadoC_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmListadoC());
            ocultarSubmenu();
        }

        private void btnDrones_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(pnlDrones);
        }

        private void btnRegistroD_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmDrone());
            ocultarSubmenu();
        }

        private void btnListadoD_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmListadoD());
            ocultarSubmenu();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmPiloto());
        }

        private void btnMisiones_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmMision());
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmMantenimiento());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmInventario());
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmFactura());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirenPanel(new frmReportes());
        }
    }
}