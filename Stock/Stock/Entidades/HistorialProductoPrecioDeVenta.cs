using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class HistorialProductoPrecioDeVenta
    {
        public int idProducto { get; set; }
        public decimal ValorUnitario { get; set; }
        public string ReditoPorcentual { get; set; }
        public decimal PrecioTotalDeCompra { get; set; }
        public decimal PrecioDeVenta { get; set; }
    }
}
