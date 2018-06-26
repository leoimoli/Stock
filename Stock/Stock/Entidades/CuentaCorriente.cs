using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class CuentaCorriente
    {
        public int IdCliente { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public decimal Deuda { get; set; }
        public decimal DeudaTotal { get; set; }
        public DateTime Fecha { get; set; }
    }
}
