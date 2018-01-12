using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using Stock.Negocio;

namespace Stock.DAO
{
    public class AgregarDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool InsertUsuario(Usuarios _usuario)
        {
            bool exito = false;
            connection.Open();
            string proceso = "AltaUsuario";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dni_in", _usuario.Dni);
            cmd.Parameters.AddWithValue("Apellido_in", _usuario.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _usuario.Nombre);
            cmd.Parameters.AddWithValue("FechaDeNacimiento_in", _usuario.FechaDeNacimiento);
            cmd.Parameters.AddWithValue("Contraseña_in", _usuario.Contraseña);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _usuario.FechaDeAlta);
            cmd.Parameters.AddWithValue("FechaUltimaConexion_in", _usuario.FechaUltimaConexion);
            cmd.Parameters.AddWithValue("Perfil_in", _usuario.Perfil);
            cmd.Parameters.AddWithValue("Estado_in", _usuario.Estado);
            cmd.Parameters.AddWithValue("Foto_in", _usuario.Foto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertarStock(Entidades.Stock _stock)
        {
            bool exito = false;
            //bool stockExistente = DAO.ConsultarDao.ValidarStockExistente(_stock.idProducto);
            List<int> stockExistente = new List<int>();
            stockExistente = DAO.ConsultarDao.ValidarStockExistente(_stock.idProducto);
            if (stockExistente.Count > 0)
            {
                int cant =Convert.ToInt32(stockExistente[0].ToString());
                _stock.Cantidad = _stock.Cantidad + cant;
                exito = DAO.EditarDao.ActualizarStock(_stock.idProducto, _stock.Cantidad);
            }
            else
            {
                exito = InsertarStock(_stock.idProducto, _stock.Cantidad, _stock.CodigoProducto);
            }
            if (_stock.PrecioDeVenta > 0)
            {
                exito = InsertarPrecioVenta(_stock.idProducto, _stock.PrecioDeVenta, _stock.FechaActual, _stock.idUsuario);
            }
            if (exito == true)
            {
                connection.Close();
                connection.Open();
                string proceso = "AltaMovimientoStock";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idProducto_in", _stock.idProducto);
                cmd.Parameters.AddWithValue("Cantidad_in", _stock.Cantidad);
                cmd.Parameters.AddWithValue("Proveedor_in", _stock.Proveedor);
                cmd.Parameters.AddWithValue("FechaCompra_in", _stock.FechaCompra);
                cmd.Parameters.AddWithValue("ValorUnitario_in", _stock.ValorUnitario);
                cmd.Parameters.AddWithValue("ValorCompra_in", _stock.ValorCompra);
                cmd.Parameters.AddWithValue("Remito_in", _stock.Remito);
                cmd.Parameters.AddWithValue("VencimientoLote_in", _stock.VencimientoLote);
                cmd.Parameters.AddWithValue("ReditoPorcentual_in", _stock.ReditoPorcentual);
                cmd.Parameters.AddWithValue("PrecioDeVenta_in", _stock.PrecioDeVenta);
                cmd.Parameters.AddWithValue("FechaActual_in", _stock.FechaActual);
                cmd.Parameters.AddWithValue("idUsuario_in", _stock.idUsuario);
                cmd.ExecuteNonQuery();
                exito = true;
                connection.Close();
                return exito;
            }
            else
            {
                exito = false;
            }
            return exito;
        }
        private static bool InsertarPrecioVenta(int idProducto, decimal precioDeVenta, DateTime fechaActual, int idUsuario)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "InsertarHistorialPrecioDeVenta";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProducto);
            cmd.Parameters.AddWithValue("PrecioDeVenta_in", precioDeVenta);
            cmd.Parameters.AddWithValue("FechaActual_in", fechaActual);
            cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            if (exito == true)
            {
                exito = DAO.EditarDao.ActualizarPrecioDeVentaProducto(idProducto, precioDeVenta);
            }
            return exito;
        }
        private static bool InsertarStock(int idProducto, int cantidad, string codigoProducto)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaStock";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProducto);
            cmd.Parameters.AddWithValue("CodigoProducto_in", codigoProducto);
            cmd.Parameters.AddWithValue("Cantidad_in", cantidad);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertProveedor(Entidades.Proveedores _proveedor)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaProveedor";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreEmpresa_in", _proveedor.NombreEmpresa);
            cmd.Parameters.AddWithValue("Contacto_in", _proveedor.Contacto);
            cmd.Parameters.AddWithValue("Email_in", _proveedor.Email);
            cmd.Parameters.AddWithValue("SitioWeb_in", _proveedor.SitioWeb);
            cmd.Parameters.AddWithValue("Calle_in", _proveedor.Calle);
            cmd.Parameters.AddWithValue("Altura_in", _proveedor.Altura);
            cmd.Parameters.AddWithValue("Telefono_in", _proveedor.Telefono);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _proveedor.FechaDeAlta);
            cmd.Parameters.AddWithValue("idUsuario_in", _proveedor.idUsuario);
            cmd.Parameters.AddWithValue("Foto_in", _proveedor.Foto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertMarca(Entidades.Marca _marca)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaMarca";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NombreMarca_in", _marca.NombreMarca);
            cmd.Parameters.AddWithValue("Foto_in", _marca.Foto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertarProducto(Productos _producto)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaProducto";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CodigoProducto_in", _producto.CodigoProducto);
            cmd.Parameters.AddWithValue("NombreProducto_in", _producto.NombreProducto);
            cmd.Parameters.AddWithValue("MarcaProducto_in", _producto.MarcaProducto);
            cmd.Parameters.AddWithValue("Descripcion_in", _producto.Descripcion);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _producto.FechaDeAlta);
            cmd.Parameters.AddWithValue("idUsuario_in", _producto.idUsuario);
            cmd.Parameters.AddWithValue("Foto_in", _producto.Foto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
    }
}
