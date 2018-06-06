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
        public static bool InsertPrecioDeVentaPorMarca(string marca, string Redito, int idUsuario)
        {
            bool exito = false;
            List<Productos> _lista = new List<Productos>();
            _lista = DAO.ConsultarDao.ListarProductosPorMarca(marca);
            if (_lista.Count > 0)
            {
                foreach (var item in _lista)
                {
                    decimal PrecioDeVenta = item.PrecioDeVenta;
                    var split = Redito.Split('%')[0];
                    split = split.Trim();
                    decimal porcentaje = Convert.ToDecimal(split) / 100;
                    decimal ValorVentaCalculado;
                    ValorVentaCalculado = PrecioDeVenta * porcentaje + PrecioDeVenta;
                    string ValorFinal = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                    ValorVentaCalculado = Convert.ToDecimal(ValorFinal);
                    item.PrecioDeVenta = ValorVentaCalculado;
                    item.idUsuario = idUsuario;
                    item.FechaDeAlta = DateTime.Now;
                }
                exito = DAO.AgregarDao.InsertPrecioDeVentaMasivo(_lista);
            }
            else
            {
                MessageBox.Show("No hay productos para actualizar con los parametros de busqueda utilizados.");
                throw new Exception();
            }

            return exito;
        }
    }
}
