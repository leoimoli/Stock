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
