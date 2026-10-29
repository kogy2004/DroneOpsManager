using DroneOpsManager.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DroneOpsManager.Formularios
{
    public partial class frmCliente : Form
    {
        cConexion conexion;     // variable para llamar a la clase
        SqlCommand cmd;         // para llamar los comandos
        SqlDataAdapter da;      // para las consultas
        DataTable dt;           // como se van a traer los datos
        int i, contador;        // índice y contador
        cCliente cliente = new cCliente();

        public frmCliente()
        {
            InitializeComponent();
            conexion = new cConexion();
            cargarClientes();
        }

        void llenar(DataTable dt, int i)
        {
            txtNit.Text = dt.Rows[i]["NIT"].ToString();
            txtNombre.Text = dt.Rows[i]["NombreEmpresa"].ToString();
            txtDireccion.Text = dt.Rows[i]["Direccion"].ToString();
            txtTelefono.Text = dt.Rows[i]["Telefono"].ToString();
            txtCorreo.Text = dt.Rows[i]["Correo"].ToString();
            txtContacto.Text = dt.Rows[i]["Contacto"].ToString();
            contador = dt.Rows.Count;
        }

        void cargarClientes()
        {
            i = 0;
            cmd = new SqlCommand("SELECT * FROM Clientes ORDER BY NombreEmpresa", conexion.Abriconexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            conexion.CerrarConexion();
            if (dt.Rows.Count > 0)
            {
                llenar(dt, i);
            }
            else
            {
                Limpiar();
                contador = 0;
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (txtNit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el NIT del cliente.");
                txtNit.Focus();
                return;
            }
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre o empresa del cliente.");
                txtNombre.Focus();
                return;
            }

            cliente.NIT = txtNit.Text.Trim();
            cliente.NombreEmpresa = txtNombre.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();
            cliente.Correo = txtCorreo.Text.Trim();
            cliente.Contacto = txtContacto.Text.Trim();

            // RF-04: no permitir dos clientes con el mismo NIT
            if (cliente.ExisteNIT())
            {
                MessageBox.Show("Ya existe un cliente registrado con ese NIT.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNit.Focus();
                return;
            }

            if (cliente.Insertar())
            {
                MessageBox.Show("Cliente ingresado correctamente.", "Ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarClientes();
            }
            else
            {
                MessageBox.Show("No fue posible ingresar el cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtNit.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el NIT del cliente.");
                txtNit.Focus();
                return;
            }

            cliente.NIT = txtNit.Text.Trim();
            if (cliente.Consultar())
            {
                txtNit.Text = cliente.NIT;
                txtNombre.Text = cliente.NombreEmpresa;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtCorreo.Text = cliente.Correo;
                txtContacto.Text = cliente.Contacto;
            }
            else
            {
                MessageBox.Show("El NIT no existe.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el NIT del cliente.");
                txtNit.Focus();
                return;
            }

            cliente.NIT = txtNit.Text.Trim();
            cliente.NombreEmpresa = txtNombre.Text.Trim();
            cliente.Direccion = txtDireccion.Text.Trim();
            cliente.Telefono = txtTelefono.Text.Trim();
            cliente.Correo = txtCorreo.Text.Trim();
            cliente.Contacto = txtContacto.Text.Trim();

            if (cliente.Modificar())
            {
                MessageBox.Show("Cliente modificado correctamente.", "Modificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarClientes();
            }
            else
            {
                MessageBox.Show("No fue posible modificar el cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtNit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el NIT del cliente.");
                txtNit.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de retirar este cliente?", "Confirmar retiro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            cliente.NIT = txtNit.Text.Trim();
            if (cliente.Retirar())
            {
                MessageBox.Show("Cliente retirado correctamente.", "Retiro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarClientes();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible retirar el cliente.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                i = 0;
                llenar(dt, i);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                llenar(dt, i);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (i < contador - 1)
            {
                i++;
                llenar(dt, i);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (contador > 0)
            {
                i = contador - 1;
                llenar(dt, i);
            }
        }

        private void Limpiar()
        {
            txtNit.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtContacto.Clear();
            txtNit.Focus();
        }
    }
}