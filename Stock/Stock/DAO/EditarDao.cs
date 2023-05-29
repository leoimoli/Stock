using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace Stock.DAO
{
    public class EditarDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static bool EditarUsuario(Usuarios _usuario, int idusuario)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarUsuario";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idUsuario_in", idusuario);
            cmd.Parameters.AddWithValue("Apellido_in", _usuario.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _usuario.Nombre);
            //cmd.Parameters.AddWithValue("FechaDeNacimiento_in", _usuario.FechaDeNacimiento);
            //cmd.Parameters.AddWithValue("Contraseña_in", _usuario.Contraseña);
            cmd.Parameters.AddWithValue("Perfil_in", _usuario.Perfil);
            cmd.Parameters.AddWithValue("Estado_in", _usuario.Estado);
            cmd.Parameters.AddWithValue("CodigoAnulacion_in", _usuario.CodigoAnulacion);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool ActualizarVenta(decimal valorNuevo, int idVenta)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            ///PROCEDIMIENTO
            string proceso = "ActualizarVenta";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("valorNuevo_in", valorNuevo);
            DateTime Fecha = DateTime.Now;
            cmd.Parameters.AddWithValue("idVenta_in", idVenta);
            cmd.ExecuteNonQuery();
            connection.Close();
            exito = true;
            return exito;
        }

        public static void ActualizarUltimaConexion(int idUsuario)
        {
            connection.Close();
            connection.Open();
            ///PROCEDIMIENTO
            string proceso = "ActualizarUltimaConexion";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
            DateTime Fecha = DateTime.Now;
            cmd.Parameters.AddWithValue("FechaUltimaConexion_in", Fecha);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void ActualizarEstadoOferta()
        {
            DateTime FechaActual = DateTime.Now;
            connection.Close();
            connection.Open();
            ///PROCEDIMIENTO
            string proceso = "ActualizarEstadoOfertaAutomatico";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FechaActual_in", FechaActual);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static bool EditarProducto(Productos _producto, int idProductoGrillaSeleccionado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarProducto";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProductoGrillaSeleccionado);
            cmd.Parameters.AddWithValue("CodigoProducto_in", _producto.CodigoProducto);
            cmd.Parameters.AddWithValue("NombreProducto_in", _producto.NombreProducto);
            cmd.Parameters.AddWithValue("MarcaProducto_in", _producto.MarcaProducto);
            cmd.Parameters.AddWithValue("idCategoria_in", _producto.idCategoria);
            cmd.Parameters.AddWithValue("Descripcion_in", _producto.Descripcion);
            cmd.Parameters.AddWithValue("Foto_in", _producto.Foto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool ActualizarPuntaje(int idCliente, int actualizarPuntos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "ActualizarPuntos";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("actualizarPuntos_in", actualizarPuntos);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool EditarCliente(Clientes _cliente, int idUsuarioSeleccionado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarCliente";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idClientes_in", idUsuarioSeleccionado);
            cmd.Parameters.AddWithValue("Apellido_in", _cliente.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _cliente.Nombre);
            cmd.Parameters.AddWithValue("Email_in", _cliente.Email);
            cmd.Parameters.AddWithValue("Telefono_in", _cliente.Telefono);
            cmd.Parameters.AddWithValue("Calle_in", _cliente.Calle);
            cmd.Parameters.AddWithValue("Altura_in", _cliente.Altura);
            cmd.Parameters.AddWithValue("idUsuario_in", _cliente.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool EditarCodigo(string nuevoCodigo, int idProductoSeleccionado, string MarcaProducto)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarCodigo";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProductoSeleccionado);
            cmd.Parameters.AddWithValue("NuevoCodigo_in", nuevoCodigo);
            cmd.Parameters.AddWithValue("MarcaProducto_in", MarcaProducto);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool ActualizarStock(int idProducto, int cantidad)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarStock";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProducto);
            cmd.Parameters.AddWithValue("cantidad_in", cantidad);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool ActualizarDeuda(decimal dEUDA, int idCliente)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "ActualizarDeuda";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("Deuda_in", dEUDA);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static int ActualizarEstadoArchivo(int idMovimiento)
        {
            int exito = 0;
            int Estado = 1;
            connection.Close();
            connection.Open();
            string Actualizar = "ActualizarEstadoArchivo";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.ExecuteNonQuery();
            exito = 1;
            connection.Close();
            return exito;
        }

        public static bool ActualizarPrecioDeVentaProductoMasivo(List<Productos> _lista)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            foreach (var item in _lista)
            {
                string Actualizar = "ActualizarPrecioDeVentaProducto";
                MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idProducto_in", item.idProducto);
                cmd.Parameters.AddWithValue("precioDeVenta_in", item.PrecioDeVenta);
                cmd.ExecuteNonQuery();
            }
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool EditarProveedor(Proveedores _proveedor, int idProductoGrillaSeleccionado)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "EditarProveedor";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProveedor_in", idProductoGrillaSeleccionado);
            cmd.Parameters.AddWithValue("Cuit_in", _proveedor.Cuit);
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

        public static bool ModificarEstadoDetalleCuentaCorriente(int idCliente)
        {
            string Estado = "INACTIVO";
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "ModificarEstadoDetalleCuentaCorriente";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool ActualizarPrecioDeVentaProducto(int idProducto, decimal precioDeVenta)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "ActualizarPrecioDeVentaProducto";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", idProducto);
            cmd.Parameters.AddWithValue("precioDeVenta_in", precioDeVenta);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool EliminarVenta(int idVenta)
        {
            bool exito = false;
            exito = ActualizarStockVentaCancelada(idVenta);
            if (exito == true)
            {
                connection.Close();
                connection.Open();
                string Actualizar = "EliminarDetalleVenta";
                MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idVenta_in", idVenta);
                cmd.ExecuteNonQuery();
                exito = true;
                if (exito == true)
                {
                    connection.Close();
                    connection.Open();
                    string Actualizar2 = "EliminarVenta";
                    MySqlCommand cmd2 = new MySqlCommand(Actualizar2, connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("idVenta_in", idVenta);
                    cmd2.ExecuteNonQuery();
                    exito = true;
                }
            }
            connection.Close();
            return exito;
        }
        public static bool ActualizarEstadoOferta(int idOferta)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string Actualizar = "ActualizarEstadoOferta";
            MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idoferta_in", idOferta);
            cmd.Parameters.AddWithValue("Estado_in", 0);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        private static bool ActualizarStockVentaCancelada(int idVenta)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            List<ListaStock> _stock = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idVenta_in", idVenta) };
            string proceso = "BuscarProductosPorVenta";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock lista = new Entidades.ListaStock();
                    lista.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    lista.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    _stock.Add(lista);
                }
            }
            if (_stock.Count > 0)
            {
                List<int> stockExistente = new List<int>();
                foreach (var item in _stock)
                {
                    stockExistente = DAO.ConsultarDao.ValidarStockExistente(item.idProducto);
                    if (stockExistente.Count > 0)
                    {
                        int cant = Convert.ToInt32(stockExistente[0].ToString());
                        item.Cantidad = item.Cantidad + cant;
                        ActualizarStock(item.idProducto, item.Cantidad);
                    }
                }
            }
            exito = true;
            connection.Close();
            return exito;
        }

        public static bool AnularOfertasExistentesParaElProducto(int idProductoSeleccionado)
        {
            bool Exito = false;
            try
            {
                List<Ofertas> listaOfertas = ListarOfertasPorProducto(idProductoSeleccionado);
                if (listaOfertas.Count > 0)
                    foreach (var item in listaOfertas)
                    {
                        connection.Close();
                        connection.Open();
                        string Actualizar = "SP_Editar_ActualizarEstadoOfertaPorCambioDePrecio";
                        MySqlCommand cmd = new MySqlCommand(Actualizar, connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("idoferta_in", item.idOferta);
                        cmd.Parameters.AddWithValue("Estado_in", 0);
                        cmd.ExecuteNonQuery();
                        Exito = true;
                        connection.Close();
                    }
            }
            catch (Exception ex)
            { }

            return Exito;
        }
        private static List<Ofertas> ListarOfertasPorProducto(int idProductoSeleccionado)
        {
            List<Ofertas> _lista = new List<Ofertas>();
            try
            {
                connection.Close();
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("idProductoSeleccionado_in", idProductoSeleccionado) };
                string proceso = "ListarOfertasPorProducto";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        Ofertas listaProducto = new Ofertas();
                        listaProducto.idOferta = Convert.ToInt32(item["idOferta"].ToString());
                        listaProducto.NombreOferta = item["Nombre"].ToString();
                        listaProducto.FechaDesde = Convert.ToDateTime(item["FechaDesde"].ToString());
                        string fecha = item["FechaHasta"].ToString();
                        if (fecha != "")
                        {
                            listaProducto.FechaHasta = Convert.ToDateTime(item["FechaHasta"].ToString());
                        }
                        else { listaProducto.FechaHasta = Convert.ToDateTime("1 / 1 / 1900 00:00:00"); }
                        string Precio = item["PrecioCombo"].ToString();
                        listaProducto.PrecioCombo = Convert.ToDecimal(Precio);
                        _lista.Add(listaProducto);
                    }
                }
                connection.Close();

            }
            catch (Exception ex)
            { }
            return _lista;
        }
    }
}
