using System;

namespace DroneOpsManager.Clases
{
    public class cItemInventario
    {
        public int IdItem { get; set; }
        public string NombreItem { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public int StockMinimo { get; set; }
        public double PrecioUnitario { get; set; }

        public cItemInventario()
        {

        }

        public cItemInventario(string nombreItem, string categoria, int cantidad, int stockMinimo, double precioUnitario)
        {
            NombreItem = nombreItem;
            Categoria = categoria;
            Cantidad = cantidad;
            StockMinimo = stockMinimo;
            PrecioUnitario = precioUnitario;
        }

        // Alerta cuando las existencias llegan al stock mínimo
        public bool TieneStockBajo()
        {
            return Cantidad <= StockMinimo;
        }

        // =====================================================
        // PENDIENTE PARA LA PRÓXIMA ENTREGA
        // - Registrar entradas y salidas en MovimientosInventario
        //   actualizando automáticamente la cantidad (RF-13/RNF)
        // - Listar items con existencias y alertas de stock
        // =====================================================
    }
}
