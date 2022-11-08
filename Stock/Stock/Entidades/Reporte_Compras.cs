using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class Reporte_Compras
    {
        public int TotalDeComprasGenerales { get; set; }
        public decimal CajaDePagos { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal CajaDeCompras { get; set; }
        public decimal PagoAProveedores { get; set; }
    }
}
