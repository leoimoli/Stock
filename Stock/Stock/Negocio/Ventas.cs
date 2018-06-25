using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;

namespace Stock.Negocio
{
    public class Ventas
    {
        public static int RegistrarVenta(List<ListaProductoVenta> listaProductos, int idusuario)
        {
            int idVenta = 0;
            try
            {
                idVenta = DAO.AgregarDao.InsertVenta(listaProductos, idusuario);
            }
            catch (Exception ex)
            { }
            return idVenta;
        }
    }
}
