using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaStock
    {
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Decimal PrecioDeVenta { get; set; }
        public string Remito { get; set; }
        public string Proveedor { get; set; }

    }
}
