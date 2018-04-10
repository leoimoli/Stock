using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class PrecioDeVenta_Negocio
    {
        public static bool InsertPrecioDeVenta(PrecioDeVenta _precio)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_precio);
                exito = DAO.AgregarDao.InsertPrecioDeVenta(_precio);
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarDatos(PrecioDeVenta _precio)
        {
            var precio = Convert.ToString(_precio.Precio);
            if (precio == "0")
            {
                MessageBox.Show("EL CAMPO PRECIO ES OBLIGATORIO.");
                throw new Exception();
            }
        }
    }
}
