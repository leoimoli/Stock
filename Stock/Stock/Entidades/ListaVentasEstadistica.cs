using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaVentasEstadistica
    {
        public string anno { get; set; }
        public string mes { get; set; }
        public int TotalVentasPorMes { get; set; }
    }
}
