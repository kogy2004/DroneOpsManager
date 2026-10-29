using System.Data;
using System.Data.SqlClient;

namespace DroneOpsManager.Clases
{
    internal class cConexion
    {
        // Ruta de conexión a la base de datos DroneOpsManagerDB.
        // IMPORTANTE: ejecutar primero el script DroneOpsManagerDB.sql en SQL Server.
        // Si usas SQL Server Express cambia el Data Source por: .\SQLEXPRESS
        static private string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Downloads\Drones\DroneOpsManager\DroneOpsManagerDB.mdf;Integrated Security=True;Connect Timeout=30";

        // Variable para cargar la base de datos
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        // Método para abrir la base de datos
        public SqlConnection Abriconexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        // Método para cerrar la base de datos
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
