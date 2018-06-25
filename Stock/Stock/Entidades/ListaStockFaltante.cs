using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class ListaStockFaltante
    {
        public string CodigoProducto { get; set; }
        public string Marca { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }

    }
}
