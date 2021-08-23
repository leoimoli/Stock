using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class Ofertas
    {
        public int idOferta { get; set; }
        public string NombreOferta { get; set; }
        public DateTime FechaDelRegistro { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal PrecioCombo { get; set; }
        public int Estado { get; set; }
        public int idProducto { get; set; }
        public int Unidades { get; set; }
        public int idUsuario { get; set; }
        public List<Entidades.Productos> Productos { get; set; }
        public decimal MontoDescuento { get; set; }

        public decimal ValorProducto { get; set; }
    }
}
