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

        public static int InsertVenta(List<ListaProductoVenta> listaProductos, int idUsuario)
        {
            int idUltimoVenta = 0;
            connection.Close();
            connection.Open();
            var producto = listaProductos.First();
            producto.Fecha = DateTime.Now;
            string proceso = "AltaVenta";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("PrecioVentaFinal_in", producto.PrecioVentaFinal);
            cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
            cmd.Parameters.AddWithValue("Fecha_in", producto.Fecha);
            //cmd.ExecuteNonQuery();
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idUltimoVenta = Convert.ToInt32(r["ID"].ToString());
            }
            if (idUltimoVenta > 0)
            {
                // exito = RegistrarDetalleVenta(listaProductos, idUltimoVenta);
                RegistrarDetalleVenta(listaProductos, idUltimoVenta);
            }
            if (idUltimoVenta > 0)
            {
                //if (exito == true)
                //{
                //exito = ActualizarStockPorProductosVendidos(listaProductos);
                ActualizarStockPorProductosVendidos(listaProductos);
                //}
                //exito = true;
            }
            connection.Close();
            return idUltimoVenta;
        }
        public static bool InsertarListaStock(List<RegistroStock> listaStock)
        {
            bool exito = false;
            int idMovimiento = 0;
            connection.Close();
            connection.Open();
            string proceso = "AltaMovimientoStock";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Proveedor_in", listaStock[0].Proveedor);
            cmd.Parameters.AddWithValue("FechaCompra_in", listaStock[0].FechaFactura);
            cmd.Parameters.AddWithValue("Remito_in", listaStock[0].Remito);
            cmd.Parameters.AddWithValue("FechaActual_in", DateTime.Now);
            cmd.Parameters.AddWithValue("idUsuario_in", listaStock[0].idUsuario);
            cmd.Parameters.AddWithValue("Archivos_in", 0);
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                idMovimiento = Convert.ToInt32(r["ID"].ToString());
            }
            if (idMovimiento > 0)
            {
                exito = true;
            }
            else
            {
                exito = false;
            }

            if (exito == true)
            {
                foreach (var item in listaStock)
                {
                    int CantidadTotal = 0;
                    List<int> stockExistente = new List<int>();
                    stockExistente = DAO.ConsultarDao.ValidarStockExistente(item.idProducto);
                    if (stockExistente.Count > 0)
                    {
                        int cant = Convert.ToInt32(stockExistente[0].ToString());
                        CantidadTotal = item.Cantidad + cant;
                        exito = DAO.EditarDao.ActualizarStock(item.idProducto, CantidadTotal);
                    }
                    else
                    {
                        exito = InsertarStock(item.idProducto, item.Cantidad, item.CodigoProducto);
                    }

                    if (exito == true)
                    {
                        connection.Close();
                        connection.Open();
                        string proceso2 = "AltaDetalleStock";
                        MySqlCommand cmd2 = new MySqlCommand(proceso2, connection);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("idProducto_in", item.idProducto);
                        cmd2.Parameters.AddWithValue("Cantidad_in", item.Cantidad);
                        cmd2.Parameters.AddWithValue("ValorUnitario_in", item.ValorUnitario);
                        cmd2.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
                        cmd2.ExecuteNonQuery();
                        exito = true;
                        connection.Close();
                    }
                    else
                    {
                        exito = false;
                    }
                }
            }
            return exito;
        }
        public static int GuardarCargaMasivaProductos(List<Productos> listaStatic)
        {
            int Exito = 0;
            foreach (var item in listaStatic)
            {
                bool ProductoExistente = Negocio.Consultar.ValidarProductoExistente(item.CodigoProducto);
                if (ProductoExistente == true)
                {
                    continue;
                }
                else
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "AltaProducto";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CodigoProducto_in", item.CodigoProducto);
                    cmd.Parameters.AddWithValue("NombreProducto_in", item.NombreProducto);
                    cmd.Parameters.AddWithValue("MarcaProducto_in", item.MarcaProducto);
                    cmd.Parameters.AddWithValue("Descripcion_in", item.Descripcion);
                    cmd.Parameters.AddWithValue("FechaDeAlta_in", item.FechaDeAlta);
                    cmd.Parameters.AddWithValue("idUsuario_in", item.idUsuario);
                    cmd.Parameters.AddWithValue("Foto_in", item.Foto);
                    cmd.ExecuteNonQuery();
                }
                Exito = 1;
            }
            connection.Close();
            return Exito;
        }
        public static bool CargarPrecioDeVenta(Entidades.Stock stock)
        {
            bool Exito = false;
            connection.Close();
            connection.Open();
            string proceso = "CargarPrecioDeVenta";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idProducto_in", stock.idProducto);
            cmd.Parameters.AddWithValue("PrecioDeVenta_in", stock.PrecioDeVenta);
            cmd.Parameters.AddWithValue("FechaActual_in", stock.FechaActual);
            cmd.Parameters.AddWithValue("idUsuario_in", stock.idUsuario);
            cmd.ExecuteNonQuery();

            Exito = true;
            return Exito;
        }
        public static int GuardarArchivos(Archivos archivos)
        {
            int idMovimiento = DAO.ConsultarDao.BuscarUltimoMovimientoCargado();
            int exito = 0;
            if (archivos.Archivo1 != null)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarArchivos";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Archivo_in", archivos.Archivo1);
                cmd.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
                cmd.ExecuteNonQuery();
            }
            if (archivos.Archivo2 != null)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarArchivos";
                MySqlCommand cmd2 = new MySqlCommand(proceso, connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("Archivo_in", archivos.Archivo2);
                cmd2.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
                cmd2.ExecuteNonQuery();
            }
            if (archivos.Archivo3 != null)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarArchivos";
                MySqlCommand cmd3 = new MySqlCommand(proceso, connection);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("Archivo_in", archivos.Archivo3);
                cmd3.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
                cmd3.ExecuteNonQuery();
            }
            if (archivos.Archivo4 != null)
            {
                connection.Close();
                connection.Open();
                string proceso = "GuardarArchivos";
                MySqlCommand cmd4 = new MySqlCommand(proceso, connection);
                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("Archivo_in", archivos.Archivo4);
                cmd4.Parameters.AddWithValue("idMovimiento_in", idMovimiento);
                cmd4.ExecuteNonQuery();
            }
            exito = DAO.EditarDao.ActualizarEstadoArchivo(idMovimiento);
            exito = 1;
            connection.Close();
            return exito;
        }
        public static bool RegistrarPago(Entidades.Pagos _pagos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarPagos";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("FormaDePago_in", _pagos.FormaDePago);
            cmd.Parameters.AddWithValue("NroCheque_in", _pagos.NroCheque);
            cmd.Parameters.AddWithValue("Monto_in", _pagos.Monto);
            cmd.Parameters.AddWithValue("Proveedor_in", _pagos.Proveedor);
            cmd.Parameters.AddWithValue("FechaDePago_in", _pagos.FechaDePago);
            cmd.Parameters.AddWithValue("FechaIngreso_in", _pagos.FechaIngreso);
            cmd.Parameters.AddWithValue("idUsuario_in", _pagos.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool RegistrarPagoDeDeuda(decimal valorDeuda, int idCliente, int idUsuario)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarPagoDeDeuda";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("valorDeuda_in", valorDeuda);
            cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
            cmd.Parameters.AddWithValue("Fecha_in", DateTime.Now);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool RegistrarPuntos(int idCliente, int actualizarPuntos)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "RegistrarPuntos";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("actualizarPuntos_in", actualizarPuntos);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertarDetalleCuentaCorriente(int idCliente, decimal deudaGuardar, DateTime fecha, int idVenta)
        {
            string Estado = "ACTIVA";
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaDetalleCuentaCorriente";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("deudaGuardar_in", deudaGuardar);
            cmd.Parameters.AddWithValue("fecha_in", fecha);
            cmd.Parameters.AddWithValue("idVenta_in", idVenta);
            cmd.Parameters.AddWithValue("Estado_in", Estado);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertarCuentaCorriente(int idCliente, decimal deudaGuardar)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "InsertarCuentaCorriente";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idCliente_in", idCliente);
            cmd.Parameters.AddWithValue("deudaGuardar_in", deudaGuardar);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static int InsertarProductoMasivo(List<Productos> listaGuardar)
        {
            int idUltimoProductoCargado = 0;
            int exito = 0;
            connection.Close();
            connection.Open();

            for (int i = 0; i < listaGuardar.Count; i++)
            {
                //bool ProductoExistente = ConsultarDao.ValidarProductoMasivoExistente(listaGuardar[i].Descripcion);
                //if (ProductoExistente != true)
                //{
                string proceso = "AltaProductoMasivo";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("CodigoProducto_in", listaGuardar[i].CodigoProducto);
                cmd.Parameters.AddWithValue("NombreProducto_in", listaGuardar[i].NombreProducto);
                cmd.Parameters.AddWithValue("MarcaProducto_in", listaGuardar[i].MarcaProducto);
                cmd.Parameters.AddWithValue("Descripcion_in", listaGuardar[i].Descripcion);
                cmd.Parameters.AddWithValue("FechaDeAlta_in", listaGuardar[i].FechaDeAlta);
                cmd.Parameters.AddWithValue("idUsuario_in", listaGuardar[i].idUsuario);
                cmd.Parameters.AddWithValue("Foto_in", listaGuardar[i].Foto);
                cmd.Parameters.AddWithValue("PrecioDeVenta_in", listaGuardar[i].PrecioDeVenta);
                //cmd.ExecuteNonQuery();
                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    idUltimoProductoCargado = Convert.ToInt32(r["ID"].ToString());

                }
                if (idUltimoProductoCargado > 0)
                {
                    r.Close();
                    string proceso2 = "AltaProductoPorProveedor";
                    MySqlCommand cmd2 = new MySqlCommand(proceso2, connection);
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.AddWithValue("idProducto_in", idUltimoProductoCargado);
                    cmd2.Parameters.AddWithValue("idProveedor_in", listaGuardar[i].idProveedor);
                    cmd2.Parameters.AddWithValue("ProductoCompartido_in", null);
                    cmd2.ExecuteNonQuery();
                }
                if (listaGuardar[i].PrecioDeVenta != null && listaGuardar[i].PrecioDeVenta > 0)
                {
                    bool Exito = false;
                    string proceso3 = "InsertarHistorialPrecioDeVenta";
                    MySqlCommand cmd3 = new MySqlCommand(proceso3, connection);
                    cmd3.CommandType = CommandType.StoredProcedure;
                    cmd3.Parameters.AddWithValue("idProducto_in", idUltimoProductoCargado);
                    cmd3.Parameters.AddWithValue("PrecioDeVenta_in", listaGuardar[i].PrecioDeVenta);
                    cmd3.Parameters.AddWithValue("FechaActual_in", listaGuardar[i].FechaDeAlta);
                    cmd3.Parameters.AddWithValue("idUsuario_in", listaGuardar[i].idUsuario);
                    cmd3.ExecuteNonQuery();
                    Exito = true;
                    if (Exito == true)
                    {
                        Exito = DAO.EditarDao.ActualizarPrecioDeVentaProducto(idUltimoProductoCargado, listaGuardar[i].PrecioDeVenta);
                    }
                    exito = exito + 1;
                }
            }
            connection.Close();
            return exito;
        }
        public static bool InsertPrecioDeVentaMasivo(List<Productos> _lista)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            foreach (var item in _lista)
            {
                string proceso = "InsertarHistorialPrecioDeVenta";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idProducto_in", item.idProducto);
                cmd.Parameters.AddWithValue("PrecioDeVenta_in", item.PrecioDeVenta);
                cmd.Parameters.AddWithValue("FechaActual_in", item.FechaDeAlta);
                cmd.Parameters.AddWithValue("idUsuario_in", item.idUsuario);
                cmd.ExecuteNonQuery();
            }
            exito = true;
            connection.Close();
            if (exito == true)
            {
                exito = DAO.EditarDao.ActualizarPrecioDeVentaProductoMasivo(_lista);
            }
            return exito;
        }
        public static bool InsertCliente(Entidades.Clientes _cliente)
        {
            bool exito = false;
            connection.Close();
            connection.Open();
            string proceso = "AltaCliente";
            MySqlCommand cmd = new MySqlCommand(proceso, connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Dni_in", _cliente.Dni);
            cmd.Parameters.AddWithValue("Sexo_in", _cliente.Sexo);
            cmd.Parameters.AddWithValue("Apellido_in", _cliente.Apellido);
            cmd.Parameters.AddWithValue("Nombre_in", _cliente.Nombre);
            cmd.Parameters.AddWithValue("Email_in", _cliente.Email);
            cmd.Parameters.AddWithValue("Telefono_in", _cliente.Telefono);
            cmd.Parameters.AddWithValue("FechaDeAlta_in", _cliente.FechaDeAlta);
            cmd.Parameters.AddWithValue("Calle_in", _cliente.Calle);
            cmd.Parameters.AddWithValue("Altura_in", _cliente.Altura);
            cmd.Parameters.AddWithValue("idUsuario_in", _cliente.idUsuario);
            cmd.ExecuteNonQuery();
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertPrecioDeVenta(PrecioDeVenta _precio)
        {
            bool exito = false;

            if (_precio.Precio > 0)
            {
                exito = InsertarPrecioVenta(_precio.idProducto, _precio.Precio, _precio.FechaActual, _precio.idUsuario);
            }
            else
            {
                exito = false;
            }
            return exito;
        }
        private static bool ActualizarStockPorProductosVendidos(List<ListaProductoVenta> listaProductos)
        {
            bool exito = false;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                connection.Close();
                connection.Open();
                string proceso = "ActualizarStock";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idProducto_in", listaProductos[i].idProducto);
                cmd.Parameters.AddWithValue("Cantidad_in", listaProductos[i].Cantidad);
                cmd.ExecuteNonQuery();
            }
            return exito;
        }
        private static bool RegistrarDetalleVenta(List<ListaProductoVenta> listaProductos, int idUltimoVenta)
        {
            bool exito = false;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                connection.Close();
                connection.Open();
                string proceso = "RegistrarDetalleVenta";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idUltimaVenta_in", idUltimoVenta);
                cmd.Parameters.AddWithValue("idProducto_in", listaProductos[i].idProducto);
                cmd.Parameters.AddWithValue("Cantidad_in", listaProductos[i].Cantidad);
                cmd.Parameters.AddWithValue("PrecioUnitario_in", listaProductos[i].PrecioUnitario);
                cmd.ExecuteNonQuery();
            }
            exito = true;
            connection.Close();
            return exito;
        }
        public static bool InsertUsuario(Usuarios _usuario)
        {
            bool exito = false;
            connection.Close();
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
            int CantidadEnviada = _stock.Cantidad;
            //bool stockExistente = DAO.ConsultarDao.ValidarStockExistente(_stock.idProducto);
            List<int> stockExistente = new List<int>();
            stockExistente = DAO.ConsultarDao.ValidarStockExistente(_stock.idProducto);
            if (stockExistente.Count > 0)
            {
                int cant = Convert.ToInt32(stockExistente[0].ToString());
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
                cmd.Parameters.AddWithValue("Cantidad_in", CantidadEnviada);
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
