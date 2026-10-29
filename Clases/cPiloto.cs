using System;

namespace DroneOpsManager.Clases
{
    // Hereda de cPersona: Documento, Nombre, Direccion, Telefono, FechaNacimiento
    public class cPiloto : cPersona
    {
        public int IdPiloto { get; set; }
        public string Apellido { get; set; }
        public string Licencia { get; set; }
        public DateTime FechaVencimientoLicencia { get; set; }
        public string Correo { get; set; }
        public string Especialidad { get; set; }
        public double HorasVuelo { get; set; }

        public cPiloto()
        {

        }

        public cPiloto(string documento, string nombre, string apellido, string telefono,
                       string licencia, DateTime fechaVencimientoLicencia, string especialidad)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Licencia = licencia;
            FechaVencimientoLicencia = fechaVencimientoLicencia;
            Especialidad = especialidad;
        }

        // RF-08: un piloto solo puede asignarse a misiones si la licencia está vigente
        public bool LicenciaVigente()
        {
            return FechaVencimientoLicencia.Date >= DateTime.Now.Date;
        }

        public int DiasParaVencerLicencia()
        {
            TimeSpan diferencia = FechaVencimientoLicencia.Date - DateTime.Now.Date;
            return diferencia.Days;
        }

        // =====================================================
        // PENDIENTE PARA LA PRÓXIMA ENTREGA
        // Los métodos de acceso a la base de datos (Insertar,
        // Consultar, Modificar, Retirar y Listar) se implementarán
        // igual que en cCliente y cDrone, usando la tabla Pilotos.
        // =====================================================
    }
}
