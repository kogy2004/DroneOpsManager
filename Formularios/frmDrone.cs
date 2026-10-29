using DroneOpsManager.Clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace DroneOpsManager.Formularios
{
    public partial class frmDrone : Form
    {
        cConexion conexion;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int i, contador;
        cDrone drone = new cDrone();

        public frmDrone()
        {
            InitializeComponent();
            conexion = new cConexion();
            cargarDrones();
        }

        void llenar(DataTable dt, int i)
        {
            txtCodigo.Text = dt.Rows[i]["CodigoDrone"].ToString();
            txtMarca.Text = dt.Rows[i]["Marca"].ToString();
            txtModelo.Text = dt.Rows[i]["Modelo"].ToString();
            txtSerie.Text = dt.Rows[i]["NumeroSerie"].ToString();
            mtxtFecha.Text = Convert.ToDateTime(dt.Rows[i]["FechaCompra"]).ToString("dd/MM/yyyy");
            cmbEstado.Text = dt.Rows[i]["Estado"].ToString();
            txtHoras.Text = dt.Rows[i]["HorasVuelo"].ToString();
            contador = dt.Rows.Count;
        }

        void cargarDrones()
        {
            i = 0;
            cmd = new SqlCommand("SELECT * FROM Drones ORDER BY CodigoDrone", conexion.Abriconexion());
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

        // Lee y valida los campos del formulario.
        // Devuelve false y muestra el mensaje si algún dato es inválido.
        private bool LeerDatos()
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el código del dron.");
                txtCodigo.Focus();
                return false;
            }
            if (txtMarca.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la marca del dron.");
                txtMarca.Focus();
                return false;
            }
            if (txtModelo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el modelo del dron.");
                txtModelo.Focus();
                return false;
            }
            if (txtSerie.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de serie.");
                txtSerie.Focus();
                return false;
            }
            if (!mtxtFecha.MaskCompleted)
            {
                MessageBox.Show("Debe ingresar la fecha de compra (dd/MM/aaaa).");
                mtxtFecha.Focus();
                return false;
            }
            if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar el estado del dron.");
                cmbEstado.Focus();
                return false;
            }

            double horas;
            if (!double.TryParse(txtHoras.Text, out horas) || horas < 0)
            {
                MessageBox.Show("Las horas de vuelo deben ser un número mayor o igual a cero.");
                txtHoras.Focus();
                return false;
            }

            try
            {
                drone.FechaCompra = DateTime.ParseExact(mtxtFecha.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);
            }
            catch
            {
                MessageBox.Show("Fecha de compra inválida. Use el formato dd/MM/aaaa.");
                mtxtFecha.Focus();
                return false;
            }

            drone.CodigoDrone = txtCodigo.Text.Trim();
            drone.Marca = txtMarca.Text.Trim();
            drone.Modelo = txtModelo.Text.Trim();
            drone.NumeroSerie = txtSerie.Text.Trim();
            drone.Estado = cmbEstado.Text;   // RF-06: estados definidos
            drone.HorasVuelo = horas;
            return true;
        }

        // RF-13: avisa si el dron ya alcanzó el límite de horas de mantenimiento
        private void VerificarAlertaMantenimiento()
        {
            if (drone.NecesitaMantenimiento())
            {
                MessageBox.Show(
                    "Atención: el dron " + drone.CodigoDrone +
                    " alcanzó " + drone.HorasVuelo + " horas de vuelo. " +
                    "Requiere mantenimiento (límite: " + cDrone.LimiteHorasMantenimiento + " horas).",
                    "Alerta de mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (!LeerDatos())
            {
                return;
            }

            if (drone.Insertar())
            {
                MessageBox.Show("Dron ingresado correctamente.", "Ingreso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerificarAlertaMantenimiento();
                cargarDrones();
            }
            else
            {
                MessageBox.Show("No fue posible ingresar el dron (el código o el número de serie ya existe).",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el código del dron.");
                txtCodigo.Focus();
                return;
            }

            drone.CodigoDrone = txtCodigo.Text.Trim();
            if (drone.Consultar())
            {
                txtCodigo.Text = drone.CodigoDrone;
                txtMarca.Text = drone.Marca;
                txtModelo.Text = drone.Modelo;
                txtSerie.Text = drone.NumeroSerie;
                mtxtFecha.Text = drone.FechaCompra.ToString("dd/MM/yyyy");
                cmbEstado.Text = drone.Estado;
                txtHoras.Text = drone.HorasVuelo.ToString();
                VerificarAlertaMantenimiento();
            }
            else
            {
                MessageBox.Show("El código del dron no existe.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!LeerDatos())
            {
                return;
            }

            if (drone.Modificar())
            {
                MessageBox.Show("Dron modificado correctamente.", "Modificación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerificarAlertaMantenimiento();
                cargarDrones();
            }
            else
            {
                MessageBox.Show("No fue posible modificar el dron.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el código del dron.");
                txtCodigo.Focus();
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Está seguro de retirar este dron?", "Confirmar retiro",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            drone.CodigoDrone = txtCodigo.Text.Trim();
            if (drone.Retirar())
            {
                MessageBox.Show("Dron retirado correctamente.", "Retiro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDrones();
                Limpiar();
            }
            else
            {
                MessageBox.Show("No fue posible retirar el dron.", "Error",
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
            txtCodigo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtSerie.Clear();
            mtxtFecha.Clear();
            cmbEstado.SelectedIndex = -1;
            txtHoras.Clear();
            txtCodigo.Focus();
        }
    }
}