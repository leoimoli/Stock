using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
   public class HistorialPagoProveedores
    {
        public int idHistorial { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public int idMovimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int idUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public decimal MontoAdeudado { get; set; }
        public string Descripcion { get; set; }
        public int FacturaPaga { get; set; }
    }
}
