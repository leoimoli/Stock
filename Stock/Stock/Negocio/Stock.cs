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
    }
}
