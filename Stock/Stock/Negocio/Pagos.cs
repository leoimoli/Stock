using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Pagos
    {
        public static bool RegistrarPago(Entidades.Pagos _pagos)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_pagos);
                exito = DAO.AgregarDao.RegistrarPago(_pagos);
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarDatos(Entidades.Pagos _pagos)
        {
            var monto = Convert.ToString(_pagos.Monto);
            if (String.IsNullOrEmpty(monto))
            {
                const string message = "El campo monto producto es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();

            }
            if (String.IsNullOrEmpty(_pagos.Proveedor) || _pagos.Proveedor == "Seleccione")
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

