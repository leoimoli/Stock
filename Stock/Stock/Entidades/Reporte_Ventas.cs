using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class Reporte_Ventas
    {
        public string anno { get; set; }
        public string mes { get; set; }
        public int TotalVentasPorMes { get; set; }
        public int TotalDeVentasGenerales { get; set; }
        public decimal CajaDeVentas { get; set; }
    }
}
