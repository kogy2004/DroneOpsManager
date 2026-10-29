using System;

namespace DroneOpsManager.Clases
{
    public class cMision
    {
        public int IdMision { get; set; }
        public int IdCliente { get; set; }
        public string NombreMision { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Ubicacion { get; set; }
        public string Estado { get; set; }
        public double Costo { get; set; }

        // Estados permitidos según el enunciado
        // Programada, En ejecución, Finalizada, Cancelada

        public cMision()
        {

        }

        public cMision(int idCliente, string nombreMision, string descripcion, DateTime fechaInicio,
                       DateTime fechaFin, string ubicacion, string estado, double costo)
        {
            IdCliente = idCliente;
            NombreMision = nombreMision;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Ubicacion = ubicacion;
            Estado = estado;
            Costo = costo;
        }

        // =====================================================
        // PENDIENTE PARA LA PRÓXIMA ENTREGA
        // - Crear misión en la tabla Misiones (RF-09)
        // - Asignar piloto habilitado y dron disponible (RF-10),
        //   validando licencia vigente y estado del dron
        // - Registrar inicio, finalización e incidentes (RF-11)
        // =====================================================
    }
}
