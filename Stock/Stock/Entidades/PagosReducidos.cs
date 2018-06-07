using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class PagosReducidos
    {
        public int IdPago { get; set; }
        public decimal Monto { get; set; }
        public string Proveedor { get; set; }
        public string FechaDePago { get; set; }

    }
}
