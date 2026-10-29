using System;

namespace DroneOpsManager.Clases
{
    public class cFactura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public int IdMision { get; set; }
        public DateTime FechaFactura { get; set; }
        public double Subtotal { get; set; }
        public double IVA { get; private set; }
        public double Total { get; private set; }
        public string EstadoPago { get; set; }

        // Porcentaje de IVA configurado para el negocio
        public const double PorcentajeIVA = 0.19;

        public cFactura()
        {

        }

        public cFactura(int idCliente, int idMision, DateTime fechaFactura, double subtotal)
        {
            IdCliente = idCliente;
            IdMision = idMision;
            FechaFactura = fechaFactura;
            Subtotal = subtotal;
        }

        // RF-14: calcula el IVA (19 %) y el total de la factura
        public void CalcularTotal()
        {
            IVA = Subtotal * PorcentajeIVA;
            Total = Subtotal + IVA;
        }

        // =====================================================
        // PENDIENTE PARA LA PRÓXIMA ENTREGA
        // - Generar la factura de una misión finalizada y
        //   guardarla en las tablas Facturas y DetalleFactura
        // - Consultar pagos y registrar abonos
        // =====================================================
    }
}
