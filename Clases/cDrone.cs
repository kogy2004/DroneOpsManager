using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DroneOpsManager.Clases
{
    public class cDrone
    {
        public int IdDrone { get; set; }
        public string CodigoDrone { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Estado { get; set; }
        public double HorasVuelo { get; set; }

        // Límite de horas de vuelo para exigir mantenimiento (RF-13)
        public const double LimiteHorasMantenimiento = 200;

        public cDrone()
        {

        }

        public cDrone(string codigoDrone, string marca, string modelo, string numeroSerie,
                        DateTime fechaCompra, string estado, double horasVuelo)
        {
            CodigoDrone = codigoDrone;
            Marca = marca;
            Modelo = modelo;
            NumeroSerie = numeroSerie;
            FechaCompra = fechaCompra;
            Estado = estado;
            HorasVuelo = horasVuelo;
        }

        cConexion conexion = new cConexion();

        // RF-13: indica si el dron ya alcanzó el límite de horas para mantenimiento
        public bool NecesitaMantenimiento()
        {
            return HorasVuelo >= LimiteHorasMantenimiento;
        }

        // Validación: solo se permiten los estados definidos en RF-06
        public bool EstadoValido()
        {
            return Estado == "Disponible" || Estado == "En misión"
                || Estado == "En mantenimiento" || Estado == "Fuera de servicio";
        }

        // Método para insertar un dron
        public bool Insertar()
        {
            string sql = @"INSERT INTO Drones (CodigoDrone, Marca, Modelo, NumeroSerie, FechaCompra, Estado, HorasVuelo)
                           VALUES (@Codigo, @Marca, @Modelo, @Serie, @FechaCompra, @Estado, @Horas)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@Codigo", CodigoDrone);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@Modelo", Modelo);
                comando.Parameters.AddWithValue("@Serie", NumeroSerie);
                comando.Parameters.AddWithValue("@FechaCompra", FechaCompra);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@Horas", HorasVuelo);

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

        // Método para consultar un dron por su código
        public bool Consultar()
        {
            string sql = @"SELECT * FROM Drones WHERE CodigoDrone = @Codigo";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@Codigo", CodigoDrone);
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conexion.CerrarConexion();

                if (dt.Rows.Count > 0)
                {
                    IdDrone = Convert.ToInt32(dt.Rows[0]["IdDrone"]);
                    CodigoDrone = dt.Rows[0]["CodigoDrone"].ToString();
                    Marca = dt.Rows[0]["Marca"].ToString();
                    Modelo = dt.Rows[0]["Modelo"].ToString();
                    NumeroSerie = dt.Rows[0]["NumeroSerie"].ToString();
                    FechaCompra = Convert.ToDateTime(dt.Rows[0]["FechaCompra"]);
                    Estado = dt.Rows[0]["Estado"].ToString();
                    HorasVuelo = Convert.ToDouble(dt.Rows[0]["HorasVuelo"]);
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

        // Método para modificar un dron
        public bool Modificar()
        {
            string sql = @"UPDATE Drones SET Marca = @Marca, Modelo = @Modelo, NumeroSerie = @Serie,
                           FechaCompra = @FechaCompra, Estado = @Estado, HorasVuelo = @Horas
                           WHERE CodigoDrone = @Codigo";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@Codigo", CodigoDrone);
                comando.Parameters.AddWithValue("@Marca", Marca);
                comando.Parameters.AddWithValue("@Modelo", Modelo);
                comando.Parameters.AddWithValue("@Serie", NumeroSerie);
                comando.Parameters.AddWithValue("@FechaCompra", FechaCompra);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@Horas", HorasVuelo);
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

        // Método para retirar (eliminar) un dron
        public bool Retirar()
        {
            string sql = @"DELETE FROM Drones WHERE CodigoDrone = @Codigo";
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());
                comando.Parameters.AddWithValue("@Codigo", CodigoDrone);
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

        // Método para listar los drones con filtros
        public DataTable Listar(string estado = null, string textoBusqueda = null)
        {
            string sql = @"SELECT IdDrone, CodigoDrone, Marca, Modelo, NumeroSerie, FechaCompra, Estado, HorasVuelo
                           FROM Drones
                           WHERE (@Estado IS NULL OR Estado = @Estado)
                           AND (@Texto IS NULL OR Marca LIKE '%' + @Texto + '%' OR CodigoDrone LIKE '%' + @Texto + '%' OR Modelo LIKE '%' + @Texto + '%')
                           ORDER BY CodigoDrone";

            DataTable dt = new DataTable();
            try
            {
                SqlCommand comando = new SqlCommand(sql, conexion.Abriconexion());

                SqlParameter pEstado = comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50);
                pEstado.Value = string.IsNullOrWhiteSpace(estado) ? (object)DBNull.Value : estado;

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
