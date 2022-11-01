using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaCompras
    {
        public int idCompra { get; set; }
        public DateTime Fecha { get; set; }
        //public string PrecioVenta { get; set; }
        public string CodigoProducto { get; set; }
        public string Proveedor { get; set; }
        public decimal MontoTotal { get; set; }
    }
}
