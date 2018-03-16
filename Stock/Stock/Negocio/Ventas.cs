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
        public static bool RegistrarVenta(List<ListaProductoVenta> listaProductos, int idusuario)
        {
            bool exito = false;
            try
            {
                exito = DAO.AgregarDao.InsertVenta(listaProductos, idusuario);
            }
            catch (Exception ex)
            { }
            return exito;
        }
    }
}
