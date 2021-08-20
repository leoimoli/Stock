using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaProductoVenta
    {
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioUnitario { get; set; }
        public byte[] Foto { get; set; }
        public decimal PrecioVentaFinal { get; set; }
        //public int idUsuario { get; set; }
        public DateTime Fecha { get; set; }

        public int ProductoEspecial { get; set; }
        public int idOferta { get; set; }

        //public decimal Efectivo { get; set; }
        //public decimal Vueto { get; set; }
    }
}
