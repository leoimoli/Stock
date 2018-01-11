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

        }
    }
}
