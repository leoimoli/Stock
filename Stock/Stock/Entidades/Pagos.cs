using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public string FormaDePago { get; set; }
        public string NroCheque { get; set; }
        public decimal Monto { get; set; }
        public string Proveedor { get; set; }
        public string FechaDePago { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int idUsuario { get; set; }
        public string  Usuario { get; set; }
    }
}
