using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class Productos
    {
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string MarcaProducto { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public byte[] Foto { get; set; }
        public decimal PrecioDeVenta { get; set; }
        public string Cantidad { get; set; }
        public int idProveedor { get; set; }
    }
}
