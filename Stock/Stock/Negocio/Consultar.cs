using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;

namespace Stock.Negocio
{
    public static class Consultar
    {
        public static List<Usuarios> LoginUsuario(string usuario, string contraseña)
        {
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            lista = DAO.ConsultarDao.LoginUsuario(usuario, contraseña);
            if (lista.Count > 0)
            {
                int idUsuario = Convert.ToInt32(lista[0].IdUsuario.ToString());
                //ActualizarDAO.ActualizarUltimaConexion(idUsuario);
            }
            return lista;
        }
        public static List<Entidades.Pagos> ListaDePagos()
        {
            {
                List<Entidades.Pagos> _listaPagos = new List<Entidades.Pagos>();
                try
                {
                    _listaPagos = DAO.ConsultarDao.ListaDePagos();
                }
                catch (Exception ex)
                { }
                return _listaPagos;
            }
        }

        public static List<Productos> ListaDeProductos()
        {
            List<Productos> _listaProductos = new List<Productos>();
            try
            {
                _listaProductos = DAO.ConsultarDao.ListarProductos();
            }
            catch (Exception ex)
            { }
            return _listaProductos;
        }

        public static List<Entidades.Clientes> ListaDeClientes()
        {
            List<Entidades.Clientes> _listaClientes = new List<Entidades.Clientes>();
            try
            {
                _listaClientes = DAO.ConsultarDao.ListarClientes();
            }
            catch (Exception ex)
            { }
            return _listaClientes;
        }

        public static List<Entidades.Clientes> BuscarClienteIngresado(string dni)
        {
            List<Entidades.Clientes> _cliente = new List<Entidades.Clientes>();
            try
            {
                _cliente = DAO.ConsultarDao.BuscarClienteIngresado(dni);
            }
            catch (Exception ex)
            { }
            return _cliente;
        }

        public static int BuscarPuntosViejos(int idCliente)
        {
            int PuntosViejos = 0;
            try
            {
                PuntosViejos = DAO.ConsultarDao.BuscarPuntosViejos(idCliente);
            }
            catch (Exception ex)
            { }
            return PuntosViejos;
        }
        public static bool ValidarClienteExistente(string dni)
        {
            bool existe = DAO.ConsultarDao.ValidarClienteExistente(dni);
            return existe;
        }

        public static List<ListaStock> ListaDeStock()
        {
            List<ListaStock> _listaStock = new List<ListaStock>();
            try
            {
                _listaStock = DAO.ConsultarDao.ListarStock();
            }
            catch (Exception ex)
            { }
            return _listaStock;
        }

        public static List<ListaVentas> ConsultarVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ListaVentas> _lista = new List<ListaVentas>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarVentasPorFecha(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaVentasEstadistica> ConsultarVentasPorFechaEstadistica(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ListaVentasEstadistica> _lista = new List<ListaVentasEstadistica>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarVentasPorFechaEstadistica(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaVentas> ConsultarVentasPorUsuario(string dniUsuario)
        {
            List<ListaVentas> _lista = new List<ListaVentas>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarVentasPorUsuario(dniUsuario);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaCompras> ConsultarComprasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ListaCompras> _lista = new List<ListaCompras>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorFecha(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaComprasEstadistica> ConsultarComprasPorFechaEstadistica(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ListaComprasEstadistica> _lista = new List<ListaComprasEstadistica>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorFechaEstadistica(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaCompras> ConsultarComprasPorProveedor(string proveedor)
        {
            List<ListaCompras> _lista = new List<ListaCompras>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorProveedor(proveedor);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaVentasEstadistica> ConsultarVentasPorUsuarioEstadistica(string dniUsuario)
        {
            List<ListaVentasEstadistica> _lista = new List<ListaVentasEstadistica>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarVentasPorUsuarioEstadistica(dniUsuario);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaComprasEstadistica> ConsultarComprasPorProveedorEstadistica(string proveedor)
        {
            List<ListaComprasEstadistica> _lista = new List<ListaComprasEstadistica>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorProveedorEstadistica(proveedor);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaCompras> ConsultarComprasPorRemito(string remito)
        {
            List<ListaCompras> _lista = new List<ListaCompras>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorRemito(remito);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaProductoVenta> BuscarProductoParaVenta(string codigoProducto)
        {
            List<ListaProductoVenta> _lista = new List<ListaProductoVenta>();
            try
            {
                _lista = DAO.ConsultarDao.BuscarProductoParaVenta(codigoProducto);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<ListaComprasEstadistica> ConsultarComprasPorRemitoEstadistica(string remito)
        {
            List<ListaComprasEstadistica> _lista = new List<ListaComprasEstadistica>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultarComprasPorRemitoEstadistica(remito);
            }
            catch (Exception ex)
            { }
            return _lista;
        }

        public static List<HistorialProductoPrecioDeVenta> HistorialPrecioDeVenta(int idProducto)
        {
            List<HistorialProductoPrecioDeVenta> _listaHistorialProductoPrecioDeVenta = new List<HistorialProductoPrecioDeVenta>();
            try
            {
                _listaHistorialProductoPrecioDeVenta = DAO.ConsultarDao.HistorialPrecioDeVenta(idProducto);
            }
            catch (Exception ex)
            { }
            return _listaHistorialProductoPrecioDeVenta;
        }

        public static List<HistorialDelProductoSeleccionado> HistorialProducto(int idProducto)
        {
            List<HistorialDelProductoSeleccionado> _historialProducto = new List<HistorialDelProductoSeleccionado>();
            try
            {
                _historialProducto = DAO.ConsultarDao.HistorialProducto(idProducto);
            }
            catch (Exception ex)
            { }
            return _historialProducto;
        }

        public static int BuscarProductoPorCodigo(string codigoProducto)
        {
            int idProducto = 0;
            try
            {
                idProducto = DAO.ConsultarDao.BuscarProductoPorCodigo(codigoProducto);
            }
            catch (Exception ex)
            { }
            return idProducto;
        }

        public static bool ValidarProveedorExistente(string nombreEmpresa)
        {
            bool existe = DAO.ConsultarDao.ValidarProveedorExistente(nombreEmpresa);
            return existe;
        }

        public static List<string> CargarComboProveedor()
        {
            List<string> lista = new List<string>();
            lista = DAO.ConsultarDao.CargarComboProveedor();
            return lista;
        }

        public static List<string> CargarComboMarcas()
        {
            List<string> lista = new List<string>();
            lista = DAO.ConsultarDao.CargarCombomMarcas();
            return lista;
        }

        public static bool ValidarMarcaExistente(string nombreMarca)
        {
            bool existe = DAO.ConsultarDao.ValidarMarcaExistente(nombreMarca);
            return existe;
        }
        public static bool ValidarProductoExistente(string codigoProducto)
        {
            bool existe = DAO.ConsultarDao.ValidarProductoExistente(codigoProducto);
            return existe;
        }
        public static bool ValidarUsuarioExistente(string dni)
        {
            bool existe = DAO.ConsultarDao.ValidarUsuarioExistente(dni);
            return existe;
        }
        public static List<Usuarios> ListaDeUsuarios()
        {
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            try
            {
                _listaUsuarios = DAO.ConsultarDao.ListarUsuarios();
            }
            catch (Exception ex)
            { }
            return _listaUsuarios;
        }
        public static List<Usuarios> BuscarUsuarioPorID(int idUsuarioSeleccionado)
        {
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            try
            {
                _listaUsuarios = DAO.ConsultarDao.BuscarUsuarioPorID(idUsuarioSeleccionado);
            }
            catch (Exception ex)
            { }
            return _listaUsuarios;
        }

        public static List<Productos> BuscarProductoPorID(int idProductoGrilla)
        {
            List<Productos> _listaProductos = new List<Productos>();
            try
            {
                _listaProductos = DAO.ConsultarDao.BuscarProductoPorID(idProductoGrilla);
            }
            catch (Exception ex)
            { }
            return _listaProductos;
        }

        public static List<Usuarios> BuscarUsuarioPorDNI(string dni)
        {
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            try
            {
                _listaUsuarios = DAO.ConsultarDao.BuscarUsuarioPorDNI(dni);
            }
            catch (Exception ex)
            { }
            return _listaUsuarios;
        }

        public static List<Entidades.Proveedores> ListaDeProveedores()
        {
            List<Entidades.Proveedores> _listaProveedores = new List<Entidades.Proveedores>();
            try
            {
                _listaProveedores = DAO.ConsultarDao.ListarProveedores();
            }
            catch (Exception ex)
            { }
            return _listaProveedores;
        }
        public static List<Entidades.Proveedores> BuscarProveedorPorID(int idProveedorGrilla)
        {
            List<Entidades.Proveedores> _listaProveedores = new List<Entidades.Proveedores>();
            try
            {
                _listaProveedores = DAO.ConsultarDao.BuscarProveedorPorID(idProveedorGrilla);
            }
            catch (Exception ex)
            { }
            return _listaProveedores;
        }

        public static List<HistorialDelProveedor> HistorialDelProveedor(string Proveedor)
        {
            List<Entidades.HistorialDelProveedor> _listaHistorialProveedores = new List<Entidades.HistorialDelProveedor>();
            try
            {
                _listaHistorialProveedores = DAO.ConsultarDao.BuscarHistorialDelProveedor(Proveedor);
            }
            catch (Exception ex)
            { }
            return _listaHistorialProveedores;
        }

        public static List<HistorialDelProductoSeleccionado> ListaHistorialPrecioDeVenta()
        {
            List<HistorialDelProductoSeleccionado> _listaHistorialProductoPrecioDeVenta = new List<HistorialDelProductoSeleccionado>();
            try
            {
                _listaHistorialProductoPrecioDeVenta = DAO.ConsultarDao.ListaHistorialPrecioDeVenta();
            }
            catch (Exception ex)
            { }
            return _listaHistorialProductoPrecioDeVenta;
        }

        public static List<Entidades.Clientes> BuscarClientePorID(int idClienteSeleccionado)
        {
            List<Entidades.Clientes> _Cliente = new List<Entidades.Clientes>();
            try
            {
                _Cliente = DAO.ConsultarDao.BuscarClientePorID(idClienteSeleccionado);
            }
            catch (Exception ex)
            { }
            return _Cliente;
        }

        public static List<ListaStock> ListaDeStockPoridProdcuto(int idProducto)
        {
            List<ListaStock> _listaStock = new List<ListaStock>();
            try
            {
                _listaStock = DAO.ConsultarDao.ListaDeStockPoridProdcuto(idProducto);
            }
            catch (Exception ex)
            { }
            return _listaStock;
        }
        public static List<ListaStockProducto> ListarStockProdcuto(int idProducto)
        {
            List<ListaStockProducto> _listaStock = new List<ListaStockProducto>();
            try
            {
                _listaStock = DAO.ConsultarDao.ListarStockProdcuto(idProducto);
            }
            catch (Exception ex)
            { }
            return _listaStock;
        }
    }
}
