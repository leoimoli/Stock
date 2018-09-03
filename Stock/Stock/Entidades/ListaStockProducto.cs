using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Entidades
{
    public class ListaStockProducto
    {
        public int idProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAlta { get; set; }
        public int idUsuarioCreador { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
