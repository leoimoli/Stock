using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Producto
    {

        public static bool CargarProducto(Productos _producto)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_producto);
                bool UsuarioExistente = Negocio.Consultar.ValidarProductoExistente(_producto.CodigoProducto);
                if (UsuarioExistente == true)
                {
                    MessageBox.Show("YA EXISTE UN PRODUCTO REGISTRADO CON EL CÓDIGO INGRESADO.");
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertarProducto(_producto);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }
        public static bool EditarProducto(Productos _producto, int idProductoGrillaSeleccionado)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_producto);
                exito = DAO.EditarDao.EditarProducto(_producto, idProductoGrillaSeleccionado);
            }
            catch (Exception ex)
            { }
            return exito;
        }
        private static void ValidarDatos(Productos _producto)
        {
            if (String.IsNullOrEmpty(_producto.CodigoProducto))
            {
                MessageBox.Show("EL CAMPO CÓDIGO PRODUCTO ES OBLIGATORIO.");
                throw new Exception();
            }
        }
    }
}
