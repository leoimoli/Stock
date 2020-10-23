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
        public static List<Productos> BuscarProductosSinCodigo()
        {
            List<Productos> _listaProductos = new List<Productos>();
            try
            {
                _listaProductos = DAO.ConsultarDao.BuscarProductosSinCodigo();
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
            return _listaProductos;
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
            if (String.IsNullOrEmpty(_producto.Descripcion))
            {

                const string message = "El campo Descripción es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }

        public static bool EditarCodigo(string nuevoCodigo, int idProductoSeleccionado, string MarcaProducto)
        {
            bool exito = false;
            try
            {
                bool CodigoExistente = Negocio.Consultar.ValidarProductoExistente(nuevoCodigo);
                if (CodigoExistente == true)
                {
                    const string message = "Ya existe un producto registrado con el código ingresado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    //throw new Exception();
                }
                else
                {
                    exito = DAO.EditarDao.EditarCodigo(nuevoCodigo, idProductoSeleccionado, MarcaProducto);
                }
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

        public static int GaurdarProductosMasivo(List<Productos> listaGuardar)
        {
            int exito = 0;
            try
            {
                exito = DAO.AgregarDao.InsertarProductoMasivo(listaGuardar);
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
    }
}
