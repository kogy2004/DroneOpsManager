using System;

namespace DroneOpsManager.Clases
{
    public class cMantenimiento
    {
        public int IdMantenimiento { get; set; }
        public int IdDrone { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string TipoMantenimiento { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public DateTime ProximaRevision { get; set; }

        // Tipos: Preventivo, Correctivo, Cambio de batería,
        // Cambio de hélices, Calibración, Actualización de software

        public cMantenimiento()
        {

        }

        public cMantenimiento(int idDrone, DateTime fechaMantenimiento, string tipoMantenimiento,
                              string descripcion, double costo, DateTime proximaRevision)
        {
            IdDrone = idDrone;
            FechaMantenimiento = fechaMantenimiento;
            TipoMantenimiento = tipoMantenimiento;
            Descripcion = descripcion;
            Costo = costo;
            ProximaRevision = proximaRevision;
        }

        // =====================================================
        // PENDIENTE PARA LA PRÓXIMA ENTREGA
        // - Registrar mantenimientos en la tabla Mantenimiento (RF-12)
        // - Descontar repuestos del inventario cuando se reemplacen
        //   componentes
        // =====================================================
    }
}
