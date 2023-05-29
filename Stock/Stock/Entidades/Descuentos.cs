using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class Descuentos
    {
        public int idDescuento { get; set; }
        public int idOferta { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal MontoOferta { get; set; }
        public decimal Descuento { get; set; }
    }
}
