using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DroneOpsManager.Clases
{
    public class cCliente : cPersona
    {
        public int IdCliente { get; set; }
        // En la base de datos Documento se guarda como NIT (único)
        public string NIT { get; set; }
        public string NombreEmpresa { get; set; }
        public string Contacto { get; set; }
        public string Correo { get; set; }

        public cCliente()
        {

        }

        public cCliente(string documento, string nombre, string direccion, string telefono, DateTime fechaNacimiento,
                        string nit, string nombreEmpresa, string contacto, string correo)
            : base(documento, nombre, direccion, telefono, fechaNacimiento)
        {
            NIT = nit;
            NombreEmpresa = nombreEmpresa;
            Contacto = contacto;
            Correo = correo;
        }

        cConexion conexion = new cConexion();

        // RF-04: valida que no exista un cliente con el mismo NIT
        public bool ExisteNIT()
        {
            string sql = @"SELECT COUNT(*) FROM Clientes WHERE NIT = @NIT";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@NIT", NIT);
                int cantidad = Convert.ToInt32(comando.ExecuteScalar());
                conexion.CerrarConexion();
                return cantidad > 0;
            }
            catch (Exception)
            {
                conexion.CerrarConexion();
                return false;
            }
        }

        // Método para insertar un cliente
        public bool Insertar()
        {
            string sql = @"INSERT INTO Clientes (NombreEmpresa, NIT, Contacto, Correo, Telefono, Direccion)
                           VALUES (@NombreEmpresa, @NIT, @Contacto, @Correo, @Telefono, @Direccion)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                comando.Parameters.AddWithValue("@NIT", NIT);
                comando.Parameters.AddWithValue("@Contacto", Contacto);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Direccion", Direccion);

                int filas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();
                return filas > 0;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show("ERROR AL INGRESAR: \n\n" + ex.Message);
                return false;
            }
        }

        // Método para consultar un cliente por su NIT
        public bool Consultar()
        {
            string sql = @"SELECT * FROM Clientes WHERE NIT = @NIT";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@NIT", NIT);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.CerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    IdCliente = Convert.ToInt32(dt.Rows[0]["IdCliente"]);
                    NIT = dt.Rows[0]["NIT"].ToString();
                    NombreEmpresa = dt.Rows[0]["NombreEmpresa"].ToString();
                    Contacto = dt.Rows[0]["Contacto"].ToString();
                    Correo = dt.Rows[0]["Correo"].ToString();
                    Telefono = dt.Rows[0]["Telefono"].ToString();
                    Direccion = dt.Rows[0]["Direccion"].ToString();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                conexion.CerrarConexion();
                return false;
            }
        }

        // Método para modificar un cliente
        public bool Modificar()
        {
            string sql = @"UPDATE Clientes SET NombreEmpresa = @NombreEmpresa, Contacto = @Contacto,
                           Correo = @Correo, Telefono = @Telefono, Direccion = @Direccion
                           WHERE NIT = @NIT";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                comando.Parameters.AddWithValue("@NIT", NIT);
                comando.Parameters.AddWithValue("@Contacto", Contacto);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                int filas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();
                return filas > 0;
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show("Error al modificar: " + ex.Message);
                return false;
            }
        }

        // Método para retirar (eliminar) un cliente
        public bool Retirar()
        {
            string sql = @"DELETE FROM Clientes WHERE NIT = @NIT";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@NIT", NIT);
                int filas = comando.ExecuteNonQuery();
                conexion.CerrarConexion();
                return filas > 0;
            }
            catch (Exception)
            {
                conexion.CerrarConexion();
                return false;
            }
        }

        // Método para listar los clientes con filtro de búsqueda
        public DataTable Listar(string textoBusqueda = null)
        {
            string sql = @"SELECT IdCliente, NombreEmpresa, NIT, Contacto, Correo, Telefono, Direccion
                           FROM Clientes
                           WHERE (@Texto IS NULL OR NombreEmpresa LIKE '%' + @Texto + '%' OR NIT LIKE '%' + @Texto + '%')
                           ORDER BY NombreEmpresa";

            DataTable dt = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());

                SqlParameter pTexto = comando.Parameters.Add("@Texto", SqlDbType.NVarChar, 100);
                pTexto.Value = string.IsNullOrWhiteSpace(textoBusqueda) ? (object)DBNull.Value : textoBusqueda.Trim();

                SqlDataAdapter da = new SqlDataAdapter(comando);
                da.Fill(dt);
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                conexion.CerrarConexion();
                MessageBox.Show("ERROR AL CONSULTAR EL LISTADO:\n\n" + ex.Message);
            }
            return dt;
        }
    }
}
