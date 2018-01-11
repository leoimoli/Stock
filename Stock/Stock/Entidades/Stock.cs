using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class Stock
    {
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public string Proveedor { get; set; }
        public DateTime FechaCompra { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Remito { get; set; }
        public DateTime VencimientoLote { get; set; }
        public string ReditoPorcentual { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public DateTime FechaActual { get; set; }
        public int idUsuario { get; set; }
    }
}
