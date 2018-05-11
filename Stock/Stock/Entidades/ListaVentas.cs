using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Stock.Entidades
{
    public class ListaVentas
    {
        public int idVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string PrecioVenta { get; set; }
        public string usuario { get; set; }
    }
}
