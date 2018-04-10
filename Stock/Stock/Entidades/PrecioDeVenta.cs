using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class PrecioDeVenta
    {
        public int idProducto { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaActual { get; set; }
        public string ReditoPorcentual { get; set; }
        public int idUsuario { get; set; }
    }
}
