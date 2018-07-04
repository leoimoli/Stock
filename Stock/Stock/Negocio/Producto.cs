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
                    const string message = "Ya existe un producto registrado con el código ingresado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertarProducto(_producto);
                }
            }
            catch (Exception ex)
            {
              
            }
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
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return exito;
        }
        private static void ValidarDatos(Productos _producto)
        {
            if (String.IsNullOrEmpty(_producto.CodigoProducto))
            {

                const string message = "El campo código es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
    }
}
