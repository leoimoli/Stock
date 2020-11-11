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
                const string message = "El campo precio es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public static bool InsertPrecioDeVentaPorMarca(string marca, string Redito, int idUsuario, int Estado)
        {
            bool exito = false;
            List<Productos> _lista = new List<Productos>();
            _lista = DAO.ConsultarDao.ListarProductosPorMarca(marca);
            if (_lista.Count > 0)
            {
                foreach (var item in _lista)
                {
                    if (item.PrecioDeVenta > 0)
                    {
                        decimal PrecioDeVenta = item.PrecioDeVenta;
                        var split = Redito.Split('%')[0];
                        split = split.Trim();
                        decimal porcentaje = Convert.ToDecimal(split) / 100;
                        decimal ValorVentaCalculado = 0;
                        if (Estado == 1)
                        {
                            ValorVentaCalculado = PrecioDeVenta + PrecioDeVenta * porcentaje;
                            string ValorFinal = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                            ValorVentaCalculado = Convert.ToDecimal(ValorFinal);
                        }
                        if (Estado == 2)
                        {
                            ValorVentaCalculado = PrecioDeVenta - PrecioDeVenta * porcentaje;
                            string ValorFinal = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                            ValorVentaCalculado = Convert.ToDecimal(ValorFinal);
                        }
                        item.PrecioDeVenta = ValorVentaCalculado;
                        item.idUsuario = idUsuario;
                        item.FechaDeAlta = DateTime.Now;
                    }
                }
                exito = DAO.AgregarDao.InsertPrecioDeVentaMasivo(_lista);
            }
            else
            {

            }

            return exito;
        }

        public static bool InsertPrecioDeVentaPorProveedor(string proveedor, string nuevoRedito, int idUsuario, int Estado)
        {
            bool exito = false;
            List<Productos> _lista = new List<Productos>();
            List<Productos> _listaFinal = new List<Productos>();
            List<string> ListaIdProducto = new List<string>();
            _lista = DAO.ConsultarDao.ListarProductosPorProveedor(proveedor);

            if (_lista.Count > 0)
            {
                foreach (var item in _lista)
                {
                    string Producto = Convert.ToString(item.idProducto);
                    if (item.PrecioDeVenta > 0 & !ListaIdProducto.Any(x => x.ToString() == Producto))
                    {
                        ListaIdProducto.Add(Producto);
                        decimal PrecioDeVenta = item.PrecioDeVenta;
                        var split = nuevoRedito.Split('%')[0];
                        split = split.Trim();
                        decimal porcentaje = Convert.ToDecimal(split) / 100;
                        decimal ValorVentaCalculado = 0;
                        if (Estado == 1)
                        {
                            ValorVentaCalculado = PrecioDeVenta + PrecioDeVenta * porcentaje;
                            string ValorFinal = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                            ValorVentaCalculado = Convert.ToDecimal(ValorFinal);
                        }
                        if (Estado == 2)
                        {
                            ValorVentaCalculado = PrecioDeVenta - PrecioDeVenta * porcentaje;
                            string ValorFinal = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                            ValorVentaCalculado = Convert.ToDecimal(ValorFinal);
                        }
                        item.PrecioDeVenta = ValorVentaCalculado;
                        item.idUsuario = idUsuario;
                        item.FechaDeAlta = DateTime.Now;
                        _listaFinal.Add(item);
                    }
                }
                exito = DAO.AgregarDao.InsertPrecioDeVentaMasivo(_listaFinal);
            }
            else
            {

            }

            return exito;
        }
    }
}
