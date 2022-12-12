using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class FechasFestivas
    {
        public int idFechaFestiva { get; set; }
        public string NombreEvento { get; set; }
        public string FechaDesde { get; set; }
        public string FechaHasta { get; set; }
        public string NombreImagen { get; set; }
    }
}
