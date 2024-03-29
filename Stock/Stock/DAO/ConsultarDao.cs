﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using MySql.Data.MySqlClient;
using System.Data;
using Stock.Negocio;
using System.Windows.Forms;

namespace Stock.DAO
{
    public static class ConsultarDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<Usuarios> LoginUsuario(string usuario, string contraseña)
        {
            try
            {
                connection.Close();
                string estado = "ACTIVO";
                connection.Open();
                List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                      new MySqlParameter("Dni_in", usuario),
                                       new MySqlParameter("Contraseña_in", contraseña),
             new MySqlParameter("Estado_in", estado)};
                string proceso = "LoginUsuario";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        Entidades.Usuarios listaUsuario = new Entidades.Usuarios();
                        listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                        listaUsuario.Apellido = item["txApellido"].ToString();
                        listaUsuario.Nombre = item["txNombre"].ToString();
                        listaUsuario.Dni = item["txDni"].ToString();
                        //listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                        //listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                        listaUsuario.Contraseña = item["txContrasena"].ToString();
                        listaUsuario.Estado = item["txEstado"].ToString();
                        listaUsuario.Perfil = item["txPerfil"].ToString();
                        lista.Add(listaUsuario);
                    }
                }
                connection.Close();
                return lista;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                string msjFinal = "Metodo: loginUsuario ---- '" + msj + "' ";
                throw new Exception(msj);
            }
        }

        public static bool ValidarProveedorExistentePorCuit(string cuit)
        {
            bool Existe = false;
            try
            {
                connection.Close();
                connection.Open();
                List<Entidades.Marca> lista = new List<Entidades.Marca>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = {
                                      new MySqlParameter("Cuit_in", cuit) };
                string proceso = "ValidarProveedorExistentePorCuit";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                DataSet ds = new DataSet();
                dt.Fill(ds, "proveedores");
                if (Tabla.Rows.Count > 0)
                {
                    Existe = true;
                }
                connection.Close();

            }
            catch (Exception ex)
            { }
            return Existe;
        }

        public static List<string> CargarMediosDePago()
        {
            connection.Close();
            connection.Open();
            List<string> lista = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CargarMediosDePago";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    lista.Add(item["nombre"].ToString());
                }
            }
            return lista;
        }

        public static List<ListaVentas> ConsultarVentasPorFechaAndCategoria(DateTime fechaDesde, DateTime fechaHasta, int idCategoria)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta),
             new MySqlParameter("idCategoria_in", idCategoria)};
            string proceso = "ConsultarVentasPorFechaAndCategoria";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idventa"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            connection.Close();
            return lista;
        }

        public static Usuarios ListaUsuarioPorId(int idUsuarioSeleccionado)
        {
            connection.Close();
            connection.Open();
            Entidades.Usuarios listaUsuario = new Entidades.Usuarios();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idUsuarioSeleccionado_in", idUsuarioSeleccionado) };
            string proceso = "ListaUsuarioPorId";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                    listaUsuario.Apellido = item["txApellido"].ToString();
                    listaUsuario.Nombre = item["txNombre"].ToString();
                    listaUsuario.Dni = item["txDni"].ToString();
                    listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                    listaUsuario.Contraseña = item["txContrasena"].ToString();
                    listaUsuario.Estado = item["txEstado"].ToString();
                    listaUsuario.Perfil = item["txPerfil"].ToString();
                }
            }
            connection.Close();
            return listaUsuario;
        }

        public static List<FechasFestivas> BuscarFechasFestivas()
        {
            connection.Close();
            connection.Open();
            List<FechasFestivas> lista = new List<FechasFestivas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "BuscarFechasFestivas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    FechasFestivas listaFechas = new FechasFestivas();
                    listaFechas.idFechaFestiva = Convert.ToInt32(item["idFechasFestivas"].ToString());
                    listaFechas.NombreEvento = item["NombreEvento"].ToString();
                    listaFechas.FechaDesde = item["FechaDesde"].ToString();
                    listaFechas.FechaHasta = item["FechaHasta"].ToString();
                    listaFechas.NombreImagen = item["NombreImagen"].ToString();
                    lista.Add(listaFechas);
                }
            }
            return lista;
        }

        public static List<DetalleCajaDiaria> ObtenerCajaDiaria()
        {
            List<DetalleCajaDiaria> cajaDiaria = new List<DetalleCajaDiaria>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("fechaHoy_in", DateTime.Now.AddHours(-3)) };
            string proceso = "ConsultarDetalleCajaDiaria";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            int idDescuentoUsuado = 0;
            List<int> ListaidDescuento = new List<int>();
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    DetalleCajaDiaria caja = new DetalleCajaDiaria();
                    caja.fecha = item["FECHA"].ToString();

                    DateTime fecha = Convert.ToDateTime(item["FECHA"].ToString());

                    caja.fecha = fecha.Day.ToString().PadLeft(2, '0') +
                           "/" + fecha.Month.ToString().PadLeft(2, '0') +
                           "/" + fecha.Year.ToString().PadLeft(4, '0');

                    caja.cantidad = item["CANTIDAD"].ToString();
                    caja.precio = item["PRECIO"].ToString();
                    caja.producto = item["PRODUCTO"].ToString();
                    caja.categoria = item["CATEGORIA"].ToString();
                    caja.medio = item["MEDIO"].ToString();
                    caja.idventa = item["ID"].ToString();

                    List<Descuentos> _listaDescuento = ObtenerDescuentos(caja.idventa);

                    if (_listaDescuento.Count > 0)
                    {
                        foreach (var itemDescuentos in _listaDescuento)
                        {
                            bool yaExiste = ListaidDescuento.Any(x => x == itemDescuentos.idDescuento);
                            if (yaExiste == false && caja.producto == itemDescuentos.Descripcion)
                            {
                                decimal Precio = Convert.ToDecimal(caja.precio) - itemDescuentos.Descuento;
                                caja.precio = Convert.ToString(Precio);
                                ListaidDescuento.Add(itemDescuentos.idDescuento);
                            }
                        }
                        //var elementoDescuento = _listaDescuento.Where(x => x.Descripcion == caja.producto).ToList();
                        //if (elementoDescuento != null && elementoDescuento.Count > 0 && (idDescuentoUsuado == 0 || idDescuentoUsuado != elementoDescuento.FirstOrDefault().idDescuento))
                        //{
                        //    decimal Precio = Convert.ToDecimal(caja.precio) - elementoDescuento.FirstOrDefault().Descuento;
                        //    idDescuentoUsuado = elementoDescuento.FirstOrDefault().idDescuento;
                        //    caja.precio = Convert.ToString(Precio);
                        //}
                    }
                    cajaDiaria.Add(caja);
                }
            }
            connection.Close();
            return cajaDiaria;
        }

        private static List<Descuentos> ObtenerDescuentos(string idventa)
        {
            List<Descuentos> _lista = new List<Descuentos>();
            try
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("idventa_in", idventa) };
                string proceso = "ObtenerDescuentosEnVentas";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        if (item["idDescuento"].ToString() != "")
                        {
                            Descuentos listaProducto = new Descuentos();
                            listaProducto.idDescuento = Convert.ToInt32(item["idDescuento"].ToString());
                            listaProducto.Descripcion = item["Descripcion"].ToString();
                            listaProducto.Descuento = Convert.ToDecimal(item["Descuento"].ToString());
                            _lista.Add(listaProducto);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _lista;
        }

        public static List<string> CargarComboCategoria()
        {
            connection.Close();
            connection.Open();
            List<string> _listaMarcas = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarCategorias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "categoriaproductos");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    _listaMarcas.Add(item["Nombre"].ToString());
                }
            }
            connection.Close();
            return _listaMarcas;
        }
        public static List<HistorialPagoProveedores> HistorialPagoAProveedores(int idMovimiento)
        {
            List<Entidades.HistorialPagoProveedores> lista = new List<Entidades.HistorialPagoProveedores>();
            lista = ObtenerDetalleInicialDeCompra(idMovimiento);
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idMovimiento_in", idMovimiento) };
            string proceso = "HistorialPagoAProveedoresPorIdMovimiento";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    HistorialPagoProveedores listaProductos = new HistorialPagoProveedores();
                    listaProductos.idHistorial = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaProductos.FechaPago = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaProductos.Monto = Convert.ToDecimal(item["Monto"].ToString());
                    listaProductos.idMovimiento = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaProductos.idUsuario = Convert.ToInt32(item["idUsuario"].ToString());
                    listaProductos.NombreUsuario = item["Apellido"].ToString() + ", " + item["Nombre"].ToString();
                    listaProductos.MontoAdeudado = Convert.ToDecimal(item["MontoAdeudado"].ToString());
                    lista.Add(listaProductos);
                }
            }
            connection.Close();
            return lista;
        }
        private static List<HistorialPagoProveedores> ObtenerDetalleInicialDeCompra(int idMovimiento)
        {
            connection.Close();
            connection.Open();
            List<Entidades.HistorialPagoProveedores> lista = new List<Entidades.HistorialPagoProveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idMovimiento_in", idMovimiento) };
            string proceso = "ObtenerDetalleInicialDeCompra";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    HistorialPagoProveedores listaProductos = new HistorialPagoProveedores();
                    listaProductos.idHistorial = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaProductos.FechaPago = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaProductos.Monto = Convert.ToDecimal(item["MontoTotal"].ToString());
                    listaProductos.idMovimiento = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaProductos.idUsuario = Convert.ToInt32(item["idUsuario"].ToString());
                    listaProductos.NombreUsuario = item["Apellido"].ToString() + ", " + item["Nombre"].ToString();
                    listaProductos.FacturaPaga = Convert.ToInt32(item["FacturaPaga"].ToString());
                    lista.Add(listaProductos);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasDelDia()
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultarComprasDelDia";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasReportePorRemito(string text)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("NroRemito_in", text) };
            string proceso = "ConsultarComprasReportePorRemito";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasDeAyer()
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultarComprasDeAyer";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static int BuscarIdMarca(string marca)
        {
            connection.Close();
            connection.Open();
            int idMarca = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Marca_in", marca) };
            string proceso = "BuscarIdMarca";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idMarca = Convert.ToInt32(item["idMarca"].ToString());
                }
            }
            connection.Close();
            return idMarca;
        }
        public static int BuscarIdCategoria(string categoria)
        {
            connection.Close();
            connection.Open();
            int idCategoria = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Categoria_in", categoria) };
            string proceso = "BuscarIdCategoria";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idCategoria = Convert.ToInt32(item["idCategoriaProductos"].ToString());
                }
            }
            connection.Close();
            return idCategoria;
        }
        public static List<ListaCompras> ConsultarComprasUltimos30Dias(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {   new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarComprasUltimos30Dias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasMesAnterior(int mes)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Mes_in", mes) };
            string proceso = "ConsultarComprasMesAnterior";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasReportePorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarComprasReportePorFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasUltimosSieteDias(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {   new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarComprasUltimosSieteDias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    listaCompras.Proveedor = item["Proveedor"].ToString();
                    DateTime fechaReal = Convert.ToDateTime(item["FechaPago"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.MontoTotal = Convert.ToDecimal(item["MontoTotal"].ToString());
                    lista.Add(listaCompras);
                }
            }
            return lista;
        }
        public static List<Ofertas> BuscarProductosDePromocion(List<Ofertas> promocion)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Ofertas> lista = new List<Entidades.Ofertas>();
            foreach (var item in promocion)
            {
                item.Productos = new List<Productos>();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("idOferta_in", item.idOferta) };
                string proceso = "BuscarProductosPorPromociones";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item2 in Tabla.Rows)
                    {
                        Entidades.Productos listaPrueba = new Entidades.Productos();
                        listaPrueba.idProducto = Convert.ToInt32(item2["idProducto"].ToString());
                        listaPrueba.Unidades = Convert.ToInt32(item2["Unidades"].ToString());
                        item.Productos.Add(listaPrueba);
                    }
                }
                lista.Add(item);
            }
            connection.Close();
            return lista;
        }
        public static List<Ofertas> BuscarPromociones(int idProducto)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Ofertas> lista = new List<Entidades.Ofertas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "BuscarPromociones";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Ofertas listaProductos = new Ofertas();
                    listaProductos.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProductos.idOferta = Convert.ToInt32(item["idOferta"].ToString());
                    listaProductos.Unidades = Convert.ToInt32(item["Unidades"].ToString());
                    listaProductos.PrecioCombo = Convert.ToDecimal(item["PrecioCombo"].ToString());
                    listaProductos.NombreOferta = item["NombreCombo"].ToString();
                    listaProductos.MontoDescuento = Convert.ToDecimal(item["MontoDescuento"].ToString());
                    lista.Add(listaProductos);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<DetalleOferta> BuscarDetalleOferta(int idOferta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.DetalleOferta> lista = new List<Entidades.DetalleOferta>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idOferta_in", idOferta) };
            string proceso = "BuscarDetalleOferta";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    DetalleOferta listaProductos = new DetalleOferta();
                    listaProductos.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProductos.CodigoProducto = item["CodigoProducto"].ToString();
                    listaProductos.Descripcion = item["Descripcion"].ToString();
                    listaProductos.Unidades = Convert.ToInt32(item["Unidades"].ToString());
                    listaProductos.PrecioOferta = Convert.ToDecimal(item["PrecioOferta"].ToString());
                    lista.Add(listaProductos);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Ofertas> ListaOfertas()
        {
            connection.Close();
            connection.Open();
            List<Ofertas> _listaProductos = new List<Ofertas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListaOfertas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Ofertas listaProducto = new Entidades.Ofertas();
                    listaProducto.idOferta = Convert.ToInt32(item["idOferta"].ToString());
                    listaProducto.NombreOferta = item["NombreCombo"].ToString();
                    listaProducto.FechaDesde = Convert.ToDateTime(item["FechaDesde"].ToString());
                    string fecha = item["FechaHasta"].ToString();
                    if (fecha != "")
                    {
                        listaProducto.FechaHasta = Convert.ToDateTime(item["FechaHasta"].ToString());
                    }
                    else { listaProducto.FechaHasta = Convert.ToDateTime("1 / 1 / 1900 00:00:00"); }
                    string Precio = item["PrecioCombo"].ToString();
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<Productos> ListaDeProductosPorMarca(string marca)
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("marca_in", marca) };
            string proceso = "ListaDeProductosPorMarca";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }

        public static int SeleccionarIdMedioDePagoPorNombre(string MedioDePago)
        {
            connection.Close();
            connection.Open();
            int idMedioPago = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("MedioDePago_in", MedioDePago) };
            string proceso = "SeleccionarIdMedioDePagoPorNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idMedioPago = Convert.ToInt32(item["idMedioPago"].ToString());
                }
            }
            return idMedioPago;
        }

        public static bool ValidarOferta(List<Ofertas> lista)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            List<string> listaId = new List<string>();
            int ElementosLista = lista.Count;
            int Contador = 1;
            string Valor;
            foreach (var item in lista)
            {
                if (Contador == lista.Count)
                {
                    Valor = Convert.ToString(item.idProducto);
                    listaId.Add(Valor);
                }
                else
                {
                    Valor = item.idProducto + ",";
                    listaId.Add(Valor);
                    Contador = Contador + 1;
                }
            }
            string listaString = listaId.Aggregate((x, y) => x + y);
            MySqlParameter[] oParam = {
                                      new MySqlParameter("listaId_in", listaString),
            new MySqlParameter("CantidadElementos_in", lista.Count)};
            string proceso = "ValidarOfertaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {

                foreach (DataRow item in Tabla.Rows)
                {
                    string valor = Convert.ToString(item.ItemArray[0]);
                    if (valor == "0")
                    {
                        Existe = false;
                    }
                    if (valor == "1")
                    {
                        Existe = true;
                    }
                }
            }
            connection.Close();
            return Existe;
        }
        public static bool ValidarProductoEspecial(string codigoProducto)
        {
            connection.Close();
            bool ProductoEspecial = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("CodigoProducto_in", codigoProducto) };
            string proceso = "ValidarProductoEspecial";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                ProductoEspecial = true;
            }
            connection.Close();
            return ProductoEspecial;
        }
        public static List<ListaVentas> ConsultarVentasDelDia()
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultarVentasDelDia";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            return lista;
        }
        public static List<ListaVentas> ConsultarVentasDeAyer()
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            string Fecha = DateTime.Today.AddDays(-1).ToShortDateString();
            string fechaDes = Fecha + " 00:" + "00:" + "00";
            string fechaHas = Fecha + " 23:" + "59:" + "59";
            DateTime FechaDesde = Convert.ToDateTime(fechaDes);
            DateTime FechaHasta = Convert.ToDateTime(fechaHas);
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta)};
            string proceso = "ConsultarVentasDeAyer";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);                 
                }
            }
            return lista;
        }
        public static List<Ofertas> ListaOfertasPorDescripcion(string nombreCombo)
        {
            connection.Close();
            connection.Open();
            List<Ofertas> _listaProductos = new List<Ofertas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("nombreCombo_in", nombreCombo) };
            string proceso = "ListaOfertasPorDescripcion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Ofertas listaProducto = new Entidades.Ofertas();
                    listaProducto.idOferta = Convert.ToInt32(item["idOferta"].ToString());
                    listaProducto.NombreOferta = item["NombreCombo"].ToString();
                    listaProducto.FechaDesde = Convert.ToDateTime(item["FechaDesde"].ToString());
                    string fecha = item["FechaHasta"].ToString();
                    if (fecha != "")
                    {
                        listaProducto.FechaHasta = Convert.ToDateTime(item["FechaHasta"].ToString());
                    }
                    else { listaProducto.FechaHasta = Convert.ToDateTime("1 / 1 / 1900 00:00:00"); }
                    string Precio = item["PrecioCombo"].ToString();
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<ListaVentas> ConsultarVentasMesAnterior(int mes)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Mes_in", mes) };
            string proceso = "ConsultarVentasMesAnterior";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            return lista;
        }
        public static bool ValidarCodigoAnulacion(string CodigoAnulacion)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Marca> lista = new List<Entidades.Marca>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("CodigoAnulacion_in", CodigoAnulacion) };
            string proceso = "ValidarCodigoAnulacion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static List<ListaVentas> ConsultarVentasUltimos30Dias(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {   new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarVentasUltimos30Dias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            return lista;
        }
        public static List<ListaVentas> ConsultarVentasUltimosSieteDias(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {   new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarVentasUltimosSieteDias";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            return lista;
        }
        public static List<Usuarios> BuscarUsuarioPorApellidoNombre(string ape, string nom)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Usuarios> _listaUsuarios = new List<Entidades.Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Apellido_in", ape),
            new MySqlParameter("Nombre_in", nom)};
            string proceso = "BuscarUsuarioPorApellidoNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Usuarios listaUsuarios = new Entidades.Usuarios();
                    listaUsuarios.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                    listaUsuarios.Apellido = item["txApellido"].ToString();
                    listaUsuarios.Nombre = item["txNombre"].ToString();
                    listaUsuarios.Dni = item["txDni"].ToString();
                    listaUsuarios.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuarios.Contraseña = item["txContrasena"].ToString();
                    listaUsuarios.Perfil = item["txPerfil"].ToString();
                    listaUsuarios.Estado = item["txEstado"].ToString();
                    _listaUsuarios.Add(listaUsuarios);
                }
            }
            connection.Close();
            return _listaUsuarios;
        }
        public static List<Archivos> BuscarArchivos(int idMovimiento)
        {
            connection.Close();
            connection.Open();
            List<Archivos> _lista = new List<Archivos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idMovimiento_in", idMovimiento) };
            string proceso = "BuscarArchivos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Archivos listaArchivos = new Entidades.Archivos();
                    listaArchivos.idArchivosCompras = Convert.ToInt32(item["idArchivosCompras"].ToString());
                    if (item[0].ToString() != string.Empty)
                    {
                        listaArchivos.Archivo1 = (byte[])item["Archivo"];
                    }
                    _lista.Add(listaArchivos);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Entidades.Clientes> BuscarClientePorApellidoNombre(string apellido, string nombre)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Clientes> _listaClientes = new List<Entidades.Clientes>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Apellido_in", apellido),
            new MySqlParameter("Nombre_in", nombre)};
            string proceso = "BuscarClientePorApellidoNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Clientes listaCliente = new Entidades.Clientes();
                    listaCliente.IdCliente = Convert.ToInt32(item["idClientes"].ToString());
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaCliente.Email = item["txEmail"].ToString();
                    listaCliente.Telefono = item["txTelefono"].ToString();
                    listaCliente.Calle = item["txCalle"].ToString();
                    listaCliente.Altura = item["txAltura"].ToString();
                    _listaClientes.Add(listaCliente);
                }
            }
            connection.Close();
            return _listaClientes;
        }
        public static List<HistorialProductoPrecioDeVenta> BuscarProductoHistorialPrecios(string codigo)
        {
            bool Existe = ValidarProductoExistente(codigo);
            List<HistorialProductoPrecioDeVenta> _lista = new List<HistorialProductoPrecioDeVenta>();
            if (Existe == true)
            {
                connection.Close();
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                DataTable Tabla = new DataTable();
                MySqlParameter[] oParam = { new MySqlParameter("Codigo_in", codigo) };
                string proceso = "BuscarProductoUltimoValorUnitario";
                MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
                dt.SelectCommand.CommandType = CommandType.StoredProcedure;
                dt.SelectCommand.Parameters.AddRange(oParam);
                dt.Fill(Tabla);
                if (Tabla.Rows.Count > 0)
                {
                    foreach (DataRow item in Tabla.Rows)
                    {
                        Entidades.HistorialProductoPrecioDeVenta _historialProductoPrecioDeVenta = new Entidades.HistorialProductoPrecioDeVenta();
                        _historialProductoPrecioDeVenta.ValorUnitario = Convert.ToDecimal(item["txValorUnitario"].ToString());
                        _historialProductoPrecioDeVenta.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                        _lista.Add(_historialProductoPrecioDeVenta);
                    }
                }
            }
            else
            {
                const string message = "El Producto ingresado no existe ¿Desea crear el producto?";
                const string caption = "Consulta";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        AltaProductoWF _alta = new AltaProductoWF(codigo);
                        _alta.Show();
                    }
                    else
                    {

                    }
                }

            }
            connection.Close();
            return _lista;
        }
        public static List<Entidades.Clientes> BuscarClientePorDni(string dni)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Clientes> _listaClientes = new List<Entidades.Clientes>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
            new MySqlParameter("Dni_in", dni)};
            string proceso = "BuscarClientePorDni";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Clientes listaCliente = new Entidades.Clientes();
                    listaCliente.IdCliente = Convert.ToInt32(item["idClientes"].ToString());
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaCliente.Email = item["txEmail"].ToString();
                    listaCliente.Telefono = item["txTelefono"].ToString();
                    listaCliente.Calle = item["txCalle"].ToString();
                    listaCliente.Altura = item["txAltura"].ToString();
                    _listaClientes.Add(listaCliente);
                }
            }
            connection.Close();
            return _listaClientes;
        }
        public static int BuscarUltimoMovimientoCargado()
        {
            connection.Close();
            connection.Open();
            int idMovimiento = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "BuscarUltimoMovimientoCargado";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idMovimiento = Convert.ToInt32(item["idMovimientoStock"].ToString());
                }
            }
            connection.Close();
            return idMovimiento;
        }
        public static List<ListaStock> ListarDetalleStock(int idMovimiento)
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idMovimiento_in", idMovimiento) };
            string proceso = "ListarDetalleStock";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.Remito = item["Remito"].ToString();
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.ValorUnitario = Convert.ToDecimal(item["txValorUnitario"].ToString());
                    listaStock.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    listaStock.NombreProducto = item["txDescripcion"].ToString();
                    listaStock.Archivos = Convert.ToInt32(item["Archivos"].ToString());
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<ListaStock> ConsultarUltimosIngresosDeStock()
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultarUltimosIngresosDeStock";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    DateTime fecha = Convert.ToDateTime(item["FechaFactura"].ToString());
                    listaStock.FechaIngreso = Convert.ToDateTime(fecha);
                    listaStock.Proveedor = item["Proveedor"].ToString();
                    listaStock.FacturaPagada = Convert.ToInt32(item["FacturaPaga"].ToString());
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<ListaStock> ConsultarIngresosDeStockPorFecha(string desde, string hasta)
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            DateTime FechaDesde = Convert.ToDateTime(desde);
            DateTime FechaHasta = Convert.ToDateTime(hasta);
            MySqlParameter[] oParam = {new MySqlParameter("Desde_in", FechaDesde),
            new MySqlParameter("Hasta_in", FechaHasta)};
            string proceso = "ConsultarIngresosDeStockPorFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idMovimientoStock"].ToString());
                    DateTime fecha = Convert.ToDateTime(item["FechaFactura"].ToString());
                    listaStock.FechaIngreso = Convert.ToDateTime(fecha);
                    listaStock.Proveedor = item["Proveedor"].ToString();
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static int ContadorProveedores()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorProveedores";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static List<ListaStock> ListaStockPorDescripcion(string descripcion)
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("descripcion_in", descripcion) };
            string proceso = "ListaStockPorDescripcion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = String.IsNullOrEmpty(item["txCantidad"].ToString()) ? 0 : Convert.ToInt32(item["txCantidad"].ToString());
                    listaStock.NombreProducto = item["txDescripcion"].ToString();
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<ListaStock> ListaStockPorCodigoProducto(string codigo)
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("codigo_in", codigo) };
            string proceso = "ListaStockPorCodigoProducto";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = String.IsNullOrEmpty(item["txCantidad"].ToString()) ? 0 : Convert.ToInt32(item["txCantidad"].ToString());
                    listaStock.NombreProducto = item["txDescripcion"].ToString();
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static int ContadorClientes()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorClientes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorProductos()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorProductos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorMarcas()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorMarcas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorVentas()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorTotalDeVentas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static int ContadorUsuarios()
        {
            connection.Close();
            connection.Open();
            int total = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ContadorUsuarios";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    total = Convert.ToInt32(item["Total"].ToString());
                }
            }
            connection.Close();
            return total;
        }
        public static List<Productos> BuscarProductosSinCodigo()
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("CodigoProducto_in", "0") };
            string proceso = "BuscarProductoSinCodigo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<Productos> ListarProductosPorProveedor(string proveedor)
        {
            List<Productos> _lista = new List<Productos>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Proveedor_in", proveedor) };
            string proceso = "ListarProductosPoridProveedor";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    _lista.Add(listaProducto);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Entidades.Pagos> ListaDePagos()
        {
            connection.Close();
            connection.Open();
            List<Entidades.Pagos> _listaProductos = new List<Entidades.Pagos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListaDePagos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Pagos listaPago = new Entidades.Pagos();
                    listaPago.IdPago = Convert.ToInt32(item["IdPagos"].ToString());
                    listaPago.FormaDePago = item["txFormaDePago"].ToString();
                    listaPago.NroCheque = item["txNroCheque"].ToString();
                    listaPago.Monto = Convert.ToDecimal(item["txMonto"].ToString());
                    listaPago.Proveedor = item["txProveedor"].ToString();
                    listaPago.FechaDePago = item["dtFechaDePago"].ToString();
                    listaPago.FechaIngreso = Convert.ToDateTime(item["dtFechaIngreso"].ToString());
                    listaPago.idUsuario = Convert.ToInt32(item["idUsuario"].ToString());
                    listaPago.Usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    _listaProductos.Add(listaPago);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<Productos> BusquedaProductoPorCodigoIngresado(string codigo)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Productos> lista = new List<Entidades.Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Codigo_in", codigo)};
            string proceso = "BusquedaProductoPorCodigo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {

                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.NombreCategoria = item["NombreCategoria"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    lista.Add(listaProducto);
                }
            }
            return lista;
        }
        public static List<Productos> BusquedaProductoPorDescripcion(string descripcion)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Productos> lista = new List<Entidades.Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Descripcion_in", descripcion)};
            string proceso = "BuscarProductoPorDescripcion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {

                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.NombreCategoria = item["NombreCategoria"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    lista.Add(listaProducto);
                }
            }
            return lista;
        }
        public static List<Productos> ListarProductoPorCodigo(string codigo)
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("codigo_in", codigo) };
            string proceso = "ListarConsultaProductoPorCodigo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    listaProducto.Cantidad = item["txCantidad"].ToString();
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static bool ValidarProductoMasivoExistente(string descripcion)
        {
            connection.Close();
            connection.Open();
            bool Exito = false;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Descripcion_in", descripcion)};
            string proceso = "ValidarProductoMasivoExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                Exito = true;
            }
            connection.Close();
            return Exito;
        }
        public static List<Productos> ListarProductoPorDescripcion(string descripcion)
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("descripcion_in", descripcion) };
            string proceso = "ListarProductoPorDescripcionSinCodigo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static decimal BuscarDeudaExistente(int idCliente)
        {
            connection.Close();
            connection.Open();
            Decimal DeudaVieja = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idCliente_in", idCliente)};
            string proceso = "BuscarDeudaPorCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    DeudaVieja = Convert.ToDecimal(item["txDeudaTotal"].ToString());

                }
            }
            connection.Close();
            return DeudaVieja;
        }
        public static List<Productos> ListarProductosPorMarca(string marca)
        {
            List<Productos> _lista = new List<Productos>();
            connection.Close();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("marca_in", marca) };
            string proceso = "ListarProductosPorMarca";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    _lista.Add(listaProducto);
                }
            }
            connection.Close();
            return _lista;
        }
        public static int BuscarPuntosViejos(int idCliente)
        {
            connection.Close();
            connection.Open();
            int PuntosViejos = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idCliente_in", idCliente)};
            string proceso = "BuscarPuntos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    PuntosViejos = Convert.ToInt32(item["txPuntos"].ToString());

                }
            }
            connection.Close();
            return PuntosViejos;
        }
        public static bool BuscarCCExistente(int idCliente)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idCliente_in", idCliente) };
            string proceso = "BuscarCCExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "cuentacorriente");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static List<ListaPagosDeDeudas> ConsultaPagoDeuda(int idClienteSeleccionado)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaPagosDeDeudas> lista = new List<Entidades.ListaPagosDeDeudas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("idClienteSeleccionado_in", idClienteSeleccionado)};
            string proceso = "ConsultaPagoDeuda";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaPagosDeDeudas listaPago = new Entidades.ListaPagosDeDeudas();
                    listaPago.idPago = Convert.ToInt32(item["idCliente"].ToString());
                    string apellido = item["txApellido"].ToString();
                    string nombre = item["txNombre"].ToString();
                    listaPago.Cliente = apellido + " " + nombre;
                    listaPago.Monto = Convert.ToDecimal(item["txPagoDeuda"].ToString());
                    listaPago.Fecha = Convert.ToDateTime(item["dtFecha"].ToString());
                    lista.Add(listaPago);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaVentas> ConsultarVentasPorUsuario(string dniUsuario)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("dniUsuario_in", dniUsuario)};
            string proceso = "ConsultarVentasPorUsuario";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idventas"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaCompras> ConsultarComprasPorProveedor(string proveedor)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("Proveedor_in", proveedor)};
            string proceso = "ConsultarComprasPorProveedor";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimiento"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFechaIngreso"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaCompras.Proveedor = item["idProveedor"].ToString();
                    //var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    //listaCompras.Proveedor = usuario;
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<CuentaCorriente> BuscarDeudaPorCliente(int idClienteSeleccionado)
        {
            connection.Close();
            connection.Open();
            List<Entidades.CuentaCorriente> lista = new List<Entidades.CuentaCorriente>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idCliente_in", idClienteSeleccionado)};
            string proceso = "BuscarDetalleDeudaPorCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.CuentaCorriente listaCliente = new Entidades.CuentaCorriente();
                    listaCliente.IdCliente = Convert.ToInt32(item["idCliente"].ToString());
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.Fecha = Convert.ToDateTime(item["dtFechaDeuda"].ToString());
                    listaCliente.Deuda = Convert.ToDecimal(item["txDeuda"].ToString());
                    listaCliente.DeudaTotal = Convert.ToDecimal(item["txDeudaTotal"].ToString());
                    lista.Add(listaCliente);
                }
            }
            connection.Close();
            return lista;
        }

        public static List<ListaComprasEstadistica> ConsultarComprasPorRemitoEstadistica(string remito)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaComprasEstadistica> lista = new List<Entidades.ListaComprasEstadistica>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Remito_in", remito)};
            string proceso = "ConsultarComprasPorRemitoEstadistica";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaComprasEstadistica listaCompras = new Entidades.ListaComprasEstadistica();
                    listaCompras.anno = item["anno"].ToString();
                    listaCompras.mes = item["mes"].ToString();
                    listaCompras.TotalComprasPorMes = Convert.ToInt32(item["Compras"].ToString());
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }



        public static List<Productos> BuscarProducto(string codigoProducto)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Productos> lista = new List<Entidades.Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("CodigoProducto_in", codigoProducto)};
            string proceso = "BuscarProducto";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaCompras = new Entidades.Productos();
                    listaCompras.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaCompras.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaCompras.NombreProducto = item["txNombreProducto"].ToString();
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }

        public static string BuscarProductoPorDescripcion(string descripcion)
        {
            connection.Close();
            connection.Open();
            string CodigoProducto = "0";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Descripcion_in", descripcion)};
            string proceso = "BuscarProductoPorDescripcion";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    CodigoProducto = item["txCodigoProducto"].ToString();
                }
            }
            connection.Close();
            return CodigoProducto;
        }

        public static List<ListaCompras> ConsultarComprasPorRemito(string remito)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("Remito_in", remito)};
            string proceso = "ConsultarComprasPorRemito";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimiento"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFechaIngreso"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaCompras.Proveedor = item["idProveedor"].ToString();
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaComprasEstadistica> ConsultarComprasPorProveedorEstadistica(string proveedor)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaComprasEstadistica> lista = new List<Entidades.ListaComprasEstadistica>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Proveedor_in", proveedor)};
            string proceso = "ConsultarComprasPorProveedorEstadistica";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaComprasEstadistica listaCompras = new Entidades.ListaComprasEstadistica();
                    listaCompras.anno = item["anno"].ToString();
                    listaCompras.mes = item["mes"].ToString();
                    listaCompras.TotalComprasPorMes = Convert.ToInt32(item["Compras"].ToString());

                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaComprasEstadistica> ConsultarComprasPorFechaEstadistica(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaComprasEstadistica> lista = new List<Entidades.ListaComprasEstadistica>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarComprasPorFechaEstadistica";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaComprasEstadistica listaCompras = new Entidades.ListaComprasEstadistica();
                    listaCompras.anno = item["anno"].ToString();
                    listaCompras.mes = item["mes"].ToString();
                    listaCompras.TotalComprasPorMes = Convert.ToInt32(item["Compras"].ToString());

                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Entidades.Proveedores> BuscarProvedorPorNombre(string nombreProveedor)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Proveedores> _lista = new List<Entidades.Proveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                       new MySqlParameter("NombreProveedor_in", nombreProveedor)};
            string proceso = "BuscarProvedorPorNombre";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Proveedores listaProveedor = new Entidades.Proveedores();
                    listaProveedor.idProveedor = Convert.ToInt32(item["idProveedores"].ToString());
                    listaProveedor.NombreEmpresa = item["txNombreEmpresa"].ToString();
                    listaProveedor.Contacto = item["txNombreContacto"].ToString();
                    listaProveedor.Email = item["txEmail"].ToString();
                    listaProveedor.SitioWeb = item["txSitioWeb"].ToString();
                    listaProveedor.Calle = item["txCalle"].ToString();
                    listaProveedor.Altura = item["txAltura"].ToString();
                    listaProveedor.Telefono = item["txTelefono"].ToString();
                    _lista.Add(listaProveedor);
                }
            }
            connection.Close();
            return _lista;
        }

        public static List<ListaStockFaltante> ListaStockFaltante()
        {
            connection.Close();
            connection.Open();
            List<ListaStockFaltante> _listaStocks = new List<ListaStockFaltante>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListaStockFaltante";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStockFaltante listaStock = new Entidades.ListaStockFaltante();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.Nombre = item["txDescripcion"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<ListaCompras> ConsultarComprasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaCompras> lista = new List<Entidades.ListaCompras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarComprasPorFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaCompras listaCompras = new Entidades.ListaCompras();
                    listaCompras.idCompra = Convert.ToInt32(item["idMovimiento"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFechaIngreso"].ToString());
                    listaCompras.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaCompras.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaCompras.Proveedor = item["idProveedor"].ToString();
                    //var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    //listaCompras.Proveedor = usuario;
                    lista.Add(listaCompras);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaVentasEstadistica> ConsultarVentasPorUsuarioEstadistica(string dniUsuario)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentasEstadistica> lista = new List<Entidades.ListaVentasEstadistica>();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = connection;
            DataTable Tabla2 = new DataTable();
            MySqlParameter[] oParam2 = {
                                        new MySqlParameter("dniUsuario_in", dniUsuario)};
            string proceso2 = "ConsultarVentasPorUsuarioEstadistica";
            MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
            dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt2.SelectCommand.Parameters.AddRange(oParam2);
            dt2.Fill(Tabla2);
            if (Tabla2.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla2.Rows)
                {
                    Entidades.ListaVentasEstadistica listaVenta = new Entidades.ListaVentasEstadistica();
                    listaVenta.mes = item["mes"].ToString();
                    listaVenta.anno = item["anno"].ToString();
                    listaVenta.TotalVentasPorMes = Convert.ToInt32(item["Ventas"].ToString());
                    lista.Add(listaVenta);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaVentasEstadistica> ConsultarVentasPorFechaEstadistica(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentasEstadistica> lista = new List<Entidades.ListaVentasEstadistica>();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = connection;
            DataTable Tabla2 = new DataTable();
            MySqlParameter[] oParam2 = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso2 = "ConsultarVentasPorFechaEstadistica";
            MySqlDataAdapter dt2 = new MySqlDataAdapter(proceso2, connection);
            dt2.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt2.SelectCommand.Parameters.AddRange(oParam2);
            dt2.Fill(Tabla2);
            if (Tabla2.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla2.Rows)
                {
                    Entidades.ListaVentasEstadistica listaVenta = new Entidades.ListaVentasEstadistica();
                    listaVenta.mes = item["mes"].ToString();
                    listaVenta.anno = item["anno"].ToString();
                    listaVenta.TotalVentasPorMes = Convert.ToInt32(item["Ventas"].ToString());
                    lista.Add(listaVenta);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaVentas> ConsultarVentasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            connection.Close();
            connection.Open();
            List<Entidades.ListaVentas> lista = new List<Entidades.ListaVentas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("FechaDesde_in", fechaDesde),
                                       new MySqlParameter("FechaHasta_in", fechaHasta)};
            string proceso = "ConsultarVentasPorFecha";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaVentas listaVenta = new Entidades.ListaVentas();
                    listaVenta.idVenta = Convert.ToInt32(item["idVenta"].ToString());
                    DateTime fechaReal = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVenta.Fecha = Convert.ToDateTime(fechaReal.ToShortDateString());
                    listaVenta.PrecioVenta = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    listaVenta.usuario = usuario;
                    lista.Add(listaVenta);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Entidades.Clientes> BuscarClienteIngresado(string dni)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Clientes> _listaClientes = new List<Entidades.Clientes>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("Dni_in", dni) };
            string proceso = "BuscarCliente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Clientes listaCliente = new Entidades.Clientes();
                    listaCliente.IdCliente = Convert.ToInt32(item["idClientes"].ToString());
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaCliente.Email = item["txEmail"].ToString();
                    listaCliente.Telefono = item["txTelefono"].ToString();
                    listaCliente.Calle = item["txCalle"].ToString();
                    listaCliente.Altura = item["txAltura"].ToString();
                    _listaClientes.Add(listaCliente);
                }
            }
            connection.Close();
            return _listaClientes;
        }
        public static List<Entidades.Clientes> ListarClientes()
        {
            connection.Close();
            connection.Open();
            List<Entidades.Clientes> _listaClientes = new List<Entidades.Clientes>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarClientes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Clientes listaCliente = new Entidades.Clientes();
                    listaCliente.IdCliente = Convert.ToInt32(item["idClientes"].ToString());
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaCliente.Email = item["txEmail"].ToString();
                    listaCliente.Telefono = item["txTelefono"].ToString();
                    listaCliente.Calle = item["txCalle"].ToString();
                    listaCliente.Altura = item["txAltura"].ToString();
                    _listaClientes.Add(listaCliente);
                }
            }
            connection.Close();
            return _listaClientes;
        }
        public static bool ValidarClienteExistente(string dni)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Dni_in", dni) };
            string proceso = "ValidarClienteExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "cliente");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static List<HistorialDelProductoSeleccionado> HistorialProducto(int idProducto)
        {
            connection.Close();
            connection.Open();
            List<HistorialDelProductoSeleccionado> _lista = new List<HistorialDelProductoSeleccionado>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "BuscarHistorialDelProductoSeleccionado";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.HistorialDelProductoSeleccionado _historialProducto = new Entidades.HistorialDelProductoSeleccionado();
                    _historialProducto.idPrecioVenta = Convert.ToInt32(item["idprecioVenta"].ToString());
                    _historialProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    _historialProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecio"].ToString());
                    _historialProducto.FechaCambio = Convert.ToDateTime(item["dtFechaCambio"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    _historialProducto.Usuario = usuario;
                    _lista.Add(_historialProducto);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<HistorialProductoPrecioDeVenta> HistorialPrecioDeVenta(int idProducto)
        {
            connection.Close();
            connection.Open();
            List<HistorialProductoPrecioDeVenta> _lista = new List<HistorialProductoPrecioDeVenta>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "BuscarHistorialPrecioDeVenta";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.HistorialProductoPrecioDeVenta _historialProductoPrecioDeVenta = new Entidades.HistorialProductoPrecioDeVenta();
                    _historialProductoPrecioDeVenta.idProducto = idProducto;
                    _historialProductoPrecioDeVenta.ValorUnitario = Convert.ToDecimal(item["txValorUnitario"].ToString());
                    var asss = item["ultimoPrecioVenta"].ToString();
                    if (asss != "")
                    {
                        _historialProductoPrecioDeVenta.PrecioDeVenta = Convert.ToDecimal(item["ultimoPrecioVenta"].ToString());
                    }
                    else { _historialProductoPrecioDeVenta.PrecioDeVenta = 0; }
                    _lista.Add(_historialProductoPrecioDeVenta);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<Entidades.Clientes> BuscarClientePorID(int idClienteSeleccionado)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Clientes> lista = new List<Entidades.Clientes>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idClientes_in", idClienteSeleccionado)};
            string proceso = "BuscarClientePorID";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Clientes listaCliente = new Entidades.Clientes();
                    listaCliente.IdCliente = Convert.ToInt32(item["idClientes"].ToString());
                    listaCliente.Dni = item["txDni"].ToString();
                    listaCliente.Sexo = item["txSexo"].ToString();
                    listaCliente.Apellido = item["txApellido"].ToString();
                    listaCliente.Nombre = item["txNombre"].ToString();
                    listaCliente.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaCliente.Email = item["txEmail"].ToString();
                    listaCliente.Telefono = item["txTelefono"].ToString();
                    listaCliente.Calle = item["txCalle"].ToString();
                    listaCliente.Altura = item["txAltura"].ToString();
                    lista.Add(listaCliente);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<ListaProductoVenta> BuscarProductoParaVenta(string codigoProducto)
        {
            connection.Close();
            connection.Open();
            List<ListaProductoVenta> _lista = new List<ListaProductoVenta>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("codigoProducto_in", codigoProducto) };
            string proceso = "VentaDeProducto";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaProductoVenta listaProducto = new Entidades.ListaProductoVenta();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = codigoProducto;
                    listaProducto.NombreProducto = item["txDescripcion"].ToString();
                    //listaProducto.PrecioUnitario = Convert.ToDecimal(item["txValorUnitario"].ToString());
                    if (item["txPrecioDeVenta"].ToString() != null & item["txPrecioDeVenta"].ToString() != "")
                    {
                        listaProducto.PrecioVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioVenta = Convert.ToDecimal("0.00");
                    }
                    listaProducto.ProductoEspecial = Convert.ToInt32(item["ProductoEspecial"].ToString());
                    _lista.Add(listaProducto);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<HistorialDelProveedor> BuscarHistorialDelProveedor(string Proveedor)
        {
            connection.Close();
            connection.Open();
            List<Entidades.HistorialDelProveedor> lista = new List<Entidades.HistorialDelProveedor>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Proveedor_in", Proveedor)};
            string proceso = "BuscarHistorialProveedor";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.HistorialDelProveedor historialProveedor = new Entidades.HistorialDelProveedor();
                    historialProveedor.año = item["anno"].ToString();
                    historialProveedor.mes = item["mes"].ToString();
                    historialProveedor.TotalCompras = Convert.ToInt32(item["Compras"].ToString());
                    lista.Add(historialProveedor);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<HistorialDelProductoSeleccionado> ListaHistorialPrecioDeVenta()
        {
            connection.Close();
            connection.Open();
            List<HistorialDelProductoSeleccionado> _lista = new List<HistorialDelProductoSeleccionado>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter() };
            string proceso = "ListaHistorialPrecioDeVenta";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.HistorialDelProductoSeleccionado _historialProducto = new Entidades.HistorialDelProductoSeleccionado();
                    //_historialProducto.idProducto = idProducto;
                    _historialProducto.idPrecioVenta = Convert.ToInt32(item["idprecioVenta"].ToString());
                    _historialProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    _historialProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecio"].ToString());
                    _historialProducto.FechaCambio = Convert.ToDateTime(item["dtFechaCambio"].ToString());
                    var usuario = item["txApellido"].ToString() + " " + item["txNombre"].ToString();
                    _historialProducto.Usuario = usuario;
                    _lista.Add(_historialProducto);
                }
            }
            connection.Close();
            return _lista;
        }
        public static List<ListaStock> ListarStock()
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarStock";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.NombreProducto = item["txDescripcion"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<int> ValidarStockExistente(int idProducto)
        {
            connection.Close();
            List<int> cantidad = new List<int>();
            connection.Open();
            List<Entidades.Marca> lista = new List<Entidades.Marca>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "ValidarStockExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    cantidad.Add(Convert.ToInt32(item["txCantidad"].ToString()));
                }
            }
            connection.Close();
            return cantidad;
        }
        public static int BuscarProductoPorCodigo(string codigoProducto)
        {
            connection.Close();
            connection.Open();
            int idProducto = 0;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("CodigoProducto_in", codigoProducto)};
            string proceso = "BuscarProductoPorCodigo";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    idProducto = Convert.ToInt32(item["idProducto"].ToString());
                }
            }
            connection.Close();
            return idProducto;
        }
        public static List<ListaStockProducto> ListarStockProdcuto(int idProducto)
        {
            connection.Close();
            connection.Open();
            List<ListaStockProducto> _listaStocks = new List<ListaStockProducto>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "ListarStockProductoPorIdProducto";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStockProducto listaStock = new Entidades.ListaStockProducto();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.NombreProducto = item["txNombreProducto"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = String.IsNullOrEmpty(item["txCantidad"].ToString()) ? 0 : Convert.ToInt32(item["txCantidad"].ToString());
                    listaStock.FechaAlta = Convert.ToDateTime(item["dtFechaAlta"].ToString());
                    listaStock.idUsuarioCreador = Convert.ToInt32(item["idUsuario"].ToString());
                    listaStock.PrecioVenta = String.IsNullOrEmpty(item["txPrecioDeVenta"].ToString()) ? 0 : Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    listaStock.Apellido = item["txApellido"].ToString();
                    listaStock.Nombre = item["txNombre"].ToString();
                    listaStock.Descripcion = item["txDescripcion"].ToString();
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<ListaStock> ListaDeStockPoridProdcuto(int idProducto)
        {
            connection.Close();
            connection.Open();
            List<ListaStock> _listaStocks = new List<ListaStock>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idProducto_in", idProducto) };
            string proceso = "ListarStockGeneralPorIdProducto";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.ListaStock listaStock = new Entidades.ListaStock();
                    listaStock.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaStock.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaStock.NombreProducto = item["txNombreProducto"].ToString();
                    listaStock.Marca = item["txMarcaProducto"].ToString();
                    listaStock.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    listaStock.FechaIngreso = Convert.ToDateTime(item["dtFechaIngreso"].ToString());
                    _listaStocks.Add(listaStock);
                }
            }
            connection.Close();
            return _listaStocks;
        }
        public static List<string> CargarComboProveedor()
        {
            connection.Close();
            connection.Open();
            List<string> _listaProveedores = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarProveedores";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    _listaProveedores.Add(item["txNombreEmpresa"].ToString());
                }
            }
            connection.Close();
            return _listaProveedores;
        }
        public static bool ValidarProveedorExistente(string nombreEmpresa)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Marca> lista = new List<Entidades.Marca>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreEmpresa_in", nombreEmpresa) };
            string proceso = "ValidarEmpresaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "proveedores");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static List<Productos> ListarProductos()
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarProductos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.NombreCategoria = item["NombreCategoria"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<Productos> ListarProductosSinPrecio()
        {
            connection.Close();
            connection.Open();
            List<Productos> _listaProductos = new List<Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarProductosSinPrecio";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    string Precio = item["txPrecioDeVenta"].ToString();
                    if (Precio != null & Precio != "")
                    {
                        listaProducto.PrecioDeVenta = Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    }
                    else
                    {
                        listaProducto.PrecioDeVenta = 0;
                    }
                    _listaProductos.Add(listaProducto);
                }
            }
            connection.Close();
            return _listaProductos;
        }
        public static List<Entidades.Proveedores> BuscarProveedorPorID(int idProveedorGrilla)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Proveedores> lista = new List<Entidades.Proveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("IDProveedor_in", idProveedorGrilla)};
            string proceso = "BuscarProveedorPorID";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            //DataSet ds = new DataSet();
            //dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                //foreach (DataRow item in ds.Tables[0].Rows)
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Proveedores listaProveedor = new Entidades.Proveedores();
                    listaProveedor.idProveedor = Convert.ToInt32(item["idProveedores"].ToString());
                    listaProveedor.Cuit = item["Cuit"].ToString();
                    listaProveedor.NombreEmpresa = item["txNombreEmpresa"].ToString();
                    listaProveedor.Contacto = item["txNombreContacto"].ToString();
                    listaProveedor.Email = item["txEmail"].ToString();
                    listaProveedor.SitioWeb = item["txSitioWeb"].ToString();
                    listaProveedor.Calle = item["txCalle"].ToString();
                    listaProveedor.Altura = item["txAltura"].ToString();
                    listaProveedor.Telefono = item["txTelefono"].ToString();
                    if (item[11].ToString() != string.Empty)
                    {
                        listaProveedor.Foto = (byte[])item["txFoto"];
                    }
                    lista.Add(listaProveedor);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Entidades.Proveedores> ListarProveedores()
        {
            connection.Close();
            connection.Open();
            List<Entidades.Proveedores> _listaProveedores = new List<Entidades.Proveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarProveedores";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            if (Tabla.Rows.Count > 0)
            {

                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Proveedores listaProveedor = new Entidades.Proveedores();
                    listaProveedor.idProveedor = Convert.ToInt32(item["idProveedores"].ToString());
                    listaProveedor.Cuit = item["Cuit"].ToString();
                    listaProveedor.NombreEmpresa = item["txNombreEmpresa"].ToString();
                    listaProveedor.Contacto = item["txNombreContacto"].ToString();
                    listaProveedor.Email = item["txEmail"].ToString();
                    listaProveedor.SitioWeb = item["txSitioWeb"].ToString();
                    listaProveedor.Calle = item["txCalle"].ToString();
                    listaProveedor.Altura = item["txAltura"].ToString();
                    listaProveedor.Telefono = item["txTelefono"].ToString();
                    _listaProveedores.Add(listaProveedor);
                }
            }
            connection.Close();
            return _listaProveedores;
        }
        public static List<Usuarios> BuscarUsuarioPorDNI(string dni)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("DNI_in", dni)};
            string proceso = "BuscarUsuarioPorDNI";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            //DataSet ds = new DataSet();
            //dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                //foreach (DataRow item in ds.Tables[0].Rows)
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Usuarios listaUsuario = new Entidades.Usuarios();
                    listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                    listaUsuario.Apellido = item["txApellido"].ToString();
                    listaUsuario.Nombre = item["txNombre"].ToString();
                    listaUsuario.Dni = item["txDni"].ToString();
                    listaUsuario.FechaDeNacimiento = Convert.ToDateTime(item["dtFechaNacimiento"].ToString());
                    listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                    listaUsuario.Contraseña = item["txContrasena"].ToString();
                    listaUsuario.Estado = item["txEstado"].ToString();
                    listaUsuario.Perfil = item["txPerfil"].ToString();
                    if (item[10].ToString() != string.Empty)
                    {
                        listaUsuario.Foto = (byte[])item["txFoto"];
                    }
                    lista.Add(listaUsuario);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Productos> BuscarProductoPorID(int idProductoGrilla)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Productos> lista = new List<Entidades.Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("IDProducto_in", idProductoGrilla)};
            string proceso = "BuscarProductoPorID";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {

                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Productos listaProducto = new Entidades.Productos();
                    listaProducto.idProducto = Convert.ToInt32(item["idProducto"].ToString());
                    listaProducto.CodigoProducto = item["txCodigoProducto"].ToString();
                    listaProducto.NombreProducto = item["txNombreProducto"].ToString();
                    listaProducto.MarcaProducto = item["txMarcaProducto"].ToString();
                    listaProducto.Descripcion = item["txDescripcion"].ToString();
                    if (item[7].ToString() != string.Empty)
                    {
                        listaProducto.Foto = (byte[])item["txFoto"];
                    }
                    //listaUsuario.CantidadVentasDelMes = String.IsNullOrEmpty(item["TotalVentas"].ToString()) ? 0 : Convert.ToInt32(item["TotalVentas"].ToString());
                    listaProducto.PrecioDeVenta = String.IsNullOrEmpty(item["txPrecioDeVenta"].ToString()) ? 0 : Convert.ToDecimal(item["txPrecioDeVenta"].ToString());
                    listaProducto.FechaDeAlta = Convert.ToDateTime(item["dtFechaAlta"].ToString());
                    var apellido = item["txApellido"].ToString();
                    var nombre = item["txNombre"].ToString();
                    listaProducto.Usuario = apellido + " " + nombre;
                    lista.Add(listaProducto);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<string> CargarCombomMarcas()
        {
            connection.Close();
            connection.Open();
            List<string> _listaMarcas = new List<string>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarMarcas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "marcas");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    _listaMarcas.Add(item["txNombreMarca"].ToString());
                }
            }
            connection.Close();
            return _listaMarcas;
        }
        public static bool ValidarMarcaExistente(string nombreMarca)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Marca> lista = new List<Entidades.Marca>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("NombreMarca_in", nombreMarca) };
            string proceso = "ValidarMarcaExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "marcas");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static bool ValidarProductoExistente(string codigoProducto)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Productos> lista = new List<Entidades.Productos>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("CodigoProducto_in", codigoProducto) };
            string proceso = "ValidarProductoExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "productos");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
        public static List<Usuarios> BuscarUsuarioPorID(int idUsuarioSeleccionado)
        {
            connection.Close();
            connection.Open();
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("ID_in", idUsuarioSeleccionado)};
            string proceso = "BuscarUsuarioPorID";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            //DataSet ds = new DataSet();
            //dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                //foreach (DataRow item in ds.Tables[0].Rows)
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Usuarios listaUsuario = new Entidades.Usuarios();
                    listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                    listaUsuario.Apellido = item["txApellido"].ToString();
                    listaUsuario.Nombre = item["txNombre"].ToString();
                    listaUsuario.Dni = item["txDni"].ToString();
                    listaUsuario.FechaDeNacimiento = Convert.ToDateTime(item["dtFechaNacimiento"].ToString());
                    listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                    listaUsuario.Contraseña = item["txContrasena"].ToString();
                    listaUsuario.Estado = item["txEstado"].ToString();
                    listaUsuario.Perfil = item["txPerfil"].ToString();
                    listaUsuario.NroLote = String.IsNullOrEmpty(item["ultimoLote"].ToString()) ? 0 : Convert.ToInt32(item["ultimoLote"].ToString());
                    listaUsuario.CantidadVentasDelMes = String.IsNullOrEmpty(item["TotalVentas"].ToString()) ? 0 : Convert.ToInt32(item["TotalVentas"].ToString());
                    listaUsuario.EfectivoVentasDelMes = String.IsNullOrEmpty(item["efectivoVentas"].ToString()) ? 0 : Convert.ToDecimal(item["efectivoVentas"].ToString());
                    if (item[10].ToString() != string.Empty)
                    {
                        listaUsuario.Foto = (byte[])item["txFoto"];
                    }
                    lista.Add(listaUsuario);
                }
            }
            connection.Close();
            return lista;
        }
        public static List<Usuarios> ListarUsuarios()
        {
            connection.Close();
            connection.Open();
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListarUsuarios";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            //DataSet ds = new DataSet();
            //dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                //foreach (DataRow item in ds.Tables[0].Rows)
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Usuarios listaUsuario = new Entidades.Usuarios();
                    listaUsuario.IdUsuario = Convert.ToInt32(item["idUsuarios"].ToString());
                    listaUsuario.Apellido = item["txApellido"].ToString();
                    listaUsuario.Nombre = item["txNombre"].ToString();
                    listaUsuario.Dni = item["txDni"].ToString();
                    listaUsuario.FechaDeAlta = Convert.ToDateTime(item["dtFechaDeAlta"].ToString());
                    listaUsuario.FechaUltimaConexion = Convert.ToDateTime(item["dtFechaUltimaConexion"].ToString());
                    listaUsuario.Contraseña = item["txContrasena"].ToString();
                    listaUsuario.Estado = item["txEstado"].ToString();
                    listaUsuario.Perfil = item["txPerfil"].ToString();
                    _listaUsuarios.Add(listaUsuario);
                }
            }
            connection.Close();
            return _listaUsuarios;
        }
        public static bool ValidarUsuarioExistente(string dni)
        {
            connection.Close();
            bool Existe = false;
            connection.Open();
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = {
                                      new MySqlParameter("Dni_in", dni) };
            string proceso = "ValidarUsuarioExistente";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            DataSet ds = new DataSet();
            dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                Existe = true;
            }
            connection.Close();
            return Existe;
        }
    }
}
