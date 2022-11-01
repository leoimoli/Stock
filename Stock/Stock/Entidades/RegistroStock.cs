using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class RegistroStock
    {
        public int idUsuario { get; set; }
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public string Proveedor { get; set; }
        public string Marca { get; set; }
        public string Remito { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaFactura { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal ValorTotalDeCompra { get; set; }

    }
}
