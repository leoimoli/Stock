using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock.Negocio
{
    public class OfertasNeg
    {
        public static int RegistrarOferta(Ofertas oferta, List<Ofertas> lista)
        {
            int exito = 0;
            try
            {
                ValidarDatos(oferta);
                bool MarcaExistente = Negocio.Consultar.ValidarOferta(lista);
                if (MarcaExistente == true)
                {
                    const string message = "Ya existe una oferta Vigente para los productos ingresados.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.RegistrarOferta(oferta, lista);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarDatos(Ofertas oferta)
        {
            if (String.IsNullOrEmpty(oferta.NombreOferta))
            {
                const string message = "El campo nombre de oferta es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }

            if (oferta.FechaDesde < oferta.FechaHasta)
            {
                const string message = "La fecha hasta no puede ser mayor a la fecha desde .";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }

            if (oferta.PrecioCombo <= 0)
            {
                const string message = "Falta ingresar un precio de venta para la oferta.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
    }
}
