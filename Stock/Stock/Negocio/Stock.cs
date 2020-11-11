using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Stock
    {
        public static bool CargarStock(Entidades.Stock _stock)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_stock);
                exito = DAO.AgregarDao.InsertarStock(_stock);
            }
            catch (Exception ex)
            { }
            return exito;
        }
        private static void ValidarDatos(Entidades.Stock _stock)
        {
            if (_stock.Cantidad == 0)
            {
                const string message = "El campo cantidad es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_stock.Proveedor))
            {
                const string message = "El campo proveedor es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static bool CargarlistaStock(List<RegistroStock> listaStock)
        {
            bool exito = false;
            try
            {
                exito = DAO.AgregarDao.InsertarListaStock(listaStock);
            }
            catch (Exception ex)
            { }
            return exito;
        }

        public static int GuardarArchivos(Archivos archivos)
        {
            int exito = 0;
            try
            {
                exito = DAO.AgregarDao.GuardarArchivos(archivos);
            }
            catch (Exception ex)
            { }
            return exito;
        }
        public static bool CargarPrecioDeVenta(Entidades.PrecioDeVenta precio)
        {
            bool exito = false;
            try
            {
                if (precio.Precio == 0)
                {
                    const string message = "El precio de venta es obligatorio.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                exito = DAO.AgregarDao.InsertPrecioDeVenta(precio);
            }
            catch (Exception ex)
            { }
            return exito;
        }
    }
}
