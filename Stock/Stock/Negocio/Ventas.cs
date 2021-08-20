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

        public static List<Ofertas> BuscarPromociones(string v1, int idProducto, int v2)
        {
            List<Ofertas> promocion = new List<Ofertas>();
            try
            {
                promocion = DAO.ConsultarDao.BuscarPromociones(idProducto);
                if (promocion.Count > 0)
                {
                    promocion = DAO.ConsultarDao.BuscarProductosDePromocion(promocion);
                }
            }
            catch (Exception ex)
            { }
            return promocion;
        }
    }
}
