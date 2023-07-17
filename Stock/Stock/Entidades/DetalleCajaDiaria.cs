using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class DetalleCajaDiaria
    {
        public string idventa { get; set; }
        public string fecha { get; set; }
        public string cantidad { get; set; }
        public string precio { get; set; }
        public string producto { get; set; }
        public string categoria { get; set; }
        public string medio { get; set; }
        public decimal MontoDescuento { get; set; }    
    }
}
