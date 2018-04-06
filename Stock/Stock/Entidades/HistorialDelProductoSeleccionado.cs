using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class HistorialDelProductoSeleccionado
    {
        public int idPrecioVenta { get; set; }
        public string CodigoProducto { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public DateTime FechaCambio { get; set; }
        public string Usuario { get; set; }
    }
}
