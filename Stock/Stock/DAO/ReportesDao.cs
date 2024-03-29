﻿using System;
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
    public class ReportesDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);

        public static List<Reporte_Proveedores> BuscarTotalComprasRealizadasProveedores()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Proveedores> _listaProveedores = new List<Reporte_Proveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "BuscarTotalComprasRealizadasProveedores";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Proveedores listaProveedores = new Entidades.Reporte_Proveedores();
                    //listaProveedores.idProveedor = Convert.ToInt32(item["idProducto"].ToString());
                    listaProveedores.NombreEmpresa = item["Proveedor"].ToString();
                    if (Convert.ToInt32(item["Total"].ToString()) > 0)
                    {
                        listaProveedores.TotalCompras = Convert.ToInt32(item["Total"].ToString());
                    }
                    else
                    {
                        listaProveedores.TotalCompras = 0;
                    }
                    _listaProveedores.Add(listaProveedores);
                }
            }
            connection.Close();
            return _listaProveedores;
        }
        public static List<Reporte_Ventas> BuscarProductosMasVendidos()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaventas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ProductoMasVendido";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    listaVentas.DescripcionProducto = item["txDescripcion"].ToString();
                    listaVentas.ProductoMasVendido = Convert.ToInt32(item["TotalVentas"].ToString());
                    _listaventas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaventas;
        }

        public static List<Reporte_Compras> PagoAProveedores()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Compras> _listaventas = new List<Reporte_Compras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultaagoAProveedores";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Compras lista = new Entidades.Reporte_Compras();
                    if (item["MontoTotal"].ToString() != null && item["MontoTotal"].ToString() != "" && Convert.ToDecimal(item["MontoTotal"].ToString()) > 0)
                    {
                        lista.PagoAProveedores = Convert.ToDecimal(item["MontoTotal"].ToString());
                    }
                    else
                    { lista.PagoAProveedores = 0; }
                    _listaventas.Add(lista);
                }
            }
            connection.Close();
            return _listaventas;
        }

        public static List<Reporte_Ventas> CajaDeVentas()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaventas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CajaDeVentas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    if (item["Total"].ToString() != null && item["Total"].ToString() != "" && Convert.ToDecimal(item["Total"].ToString()) > 0)
                    {
                        listaVentas.CajaDeVentas = Convert.ToDecimal(item["Total"].ToString());
                    }
                    else
                    { listaVentas.CajaDeVentas = 0; }
                    _listaventas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaventas;
        }

        public static void EliminarVentasTemporales(int idUsuario)
        {
            try
            {
                connection.Close();
                connection.Open();
                string proceso = "SP_Eliminar_VentaTemporal";
                MySqlCommand cmd = new MySqlCommand(proceso, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            { }
        }

        public static List<DetalleCajaDiaria> BuscarDetalleVenta(int idUsuario)
        {
            List<DetalleCajaDiaria> cajaDiaria = new List<DetalleCajaDiaria>();
            connection.Close();
            connection.Open();
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("idUsuario_in", idUsuario) };
            //cmd.CommandTimeout = 6000;

            string proceso = "SP_Consultar_BuscarDetalleVentaPorId";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.SelectCommand.CommandTimeout = 3000;
            dt.Fill(Tabla);
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
        public static bool GenerarTablaTemporalDetalleVenta(List<ListaVentas> resultado, int idUsuario)
        {
            bool Exito = false;
            try
            {
                foreach (var item in resultado)
                {
                    connection.Close();
                    connection.Open();
                    string proceso = "SP_Insertar_InsertarVentaTemporal";
                    MySqlCommand cmd = new MySqlCommand(proceso, connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("idVenta_in", item.idVenta);
                    cmd.Parameters.AddWithValue("idUsuario_in", idUsuario);
                    cmd.ExecuteNonQuery();
                }
                Exito = true;
                connection.Close();
            }
            catch (Exception ex)
            { }
            return Exito;
        }
        public static List<Reporte_Compras> CajaDeCompras()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Compras> _listaCompras = new List<Reporte_Compras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "CajaDeCompras";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Compras listaCompras = new Entidades.Reporte_Compras();
                    if (item["Total"].ToString() != null && item["Total"].ToString() != "" && Convert.ToDecimal(item["Total"].ToString()) > 0)
                    {
                        listaCompras.CajaDeCompras = Convert.ToDecimal(item["Total"].ToString());
                    }
                    else
                    { listaCompras.CajaDeCompras = 0; }
                    _listaCompras.Add(listaCompras);
                }
            }
            connection.Close();
            return _listaCompras;
        }
        public static List<Reporte_Compras> TotalDeCompras()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Compras> _listaCompras = new List<Reporte_Compras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "TotalDeCompras";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Compras listaCompras = new Entidades.Reporte_Compras();
                    if (Convert.ToInt32(item["Total"].ToString()) > 0)
                    {
                        listaCompras.TotalDeComprasGenerales = Convert.ToInt32(item["Total"].ToString());
                    }
                    else
                    { listaCompras.TotalDeComprasGenerales = 0; }
                    _listaCompras.Add(listaCompras);
                }
            }
            connection.Close();
            return _listaCompras;
        }
        public static List<Reporte_Ventas> BuscarTodasLasVentas()
        {
            String Año = DateTime.Now.Year.ToString();

            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);

            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);
            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaventas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta)};
            string proceso = "BuscarTodasLasVentas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    listaVentas.Fecha = Convert.ToDateTime(item["dtFecha"].ToString());
                    listaVentas.Precio = Convert.ToDecimal(item["txPrecioVentaFinal"].ToString());
                    _listaventas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaventas;
        }
        public static List<Reporte_Proveedores> BuscarMovimientoStock()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Proveedores> _listaProveedores = new List<Reporte_Proveedores>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "BuscarMovimientoStock";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Proveedores listaProveedores = new Entidades.Reporte_Proveedores();
                    listaProveedores.Fecha = Convert.ToDateTime(item["FechaFactura"].ToString());
                    listaProveedores.Proveedor = item["Proveedor"].ToString();
                    listaProveedores.Remito = item["Remito"].ToString();
                    _listaProveedores.Add(listaProveedores);
                }
            }
            connection.Close();
            return _listaProveedores;
        }
        public static List<Reporte_Ventas> ListadoProductosMasVendidos()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaventas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ListadoProductosMasVendidos";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    listaVentas.DescripcionProducto = item["txDescripcion"].ToString();
                    listaVentas.ProductoMasVendido = Convert.ToInt32(item["TotalVentas"].ToString());
                    _listaventas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaventas;
        }
        public static List<Reporte_Ventas> TotalDeVentas()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaventas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "TotalDeVentas";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    listaVentas.TotalDeVentasGenerales = Convert.ToInt32(item["Total"].ToString());
                    _listaventas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaventas;
        }
        public static List<Reporte_Compras> PagosCompras()
        {
            connection.Close();
            connection.Open();
            List<Reporte_Compras> _listaCompras = new List<Reporte_Compras>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { };
            string proceso = "ConsultaIngresoStock";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            Entidades.Reporte_Compras listaCompras = new Entidades.Reporte_Compras();
            decimal CalculoGasto = 0;
            decimal ValorFinal = 0;
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    listaCompras.Cantidad = Convert.ToInt32(item["txCantidad"].ToString());
                    listaCompras.ValorUnitario = Convert.ToDecimal(item["txValorUnitario"].ToString());
                    _listaCompras.Add(listaCompras);
                }
            }
            if (_listaCompras.Count > 0)
            {
                foreach (var item in _listaCompras)
                {
                    CalculoGasto = item.Cantidad * item.ValorUnitario;
                    ValorFinal = ValorFinal + CalculoGasto;
                }
                listaCompras.CajaDePagos = ValorFinal;
                _listaCompras.Add(listaCompras);
            }
            else
            {
                listaCompras.CajaDePagos = 0;
                _listaCompras.Add(listaCompras);
            }
            connection.Close();
            return _listaCompras;
        }
        public static List<Reporte_Ventas> BuscarVentasPorMes()
        {
            String Año = DateTime.Now.Year.ToString();

            string FechaArmadaDesde = "01/01/" + Año;
            DateTime FechaDesde = Convert.ToDateTime(FechaArmadaDesde);

            string FechaArmadaHasta = "31/12/" + Año;
            DateTime FechaHasta = Convert.ToDateTime(FechaArmadaHasta);

            connection.Close();
            connection.Open();
            List<Reporte_Ventas> _listaVentas = new List<Reporte_Ventas>();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            DataTable Tabla = new DataTable();
            MySqlParameter[] oParam = { new MySqlParameter("FechaDesde_in", FechaDesde),
            new MySqlParameter("FechaHasta_in", FechaHasta)};
            string proceso = "BuscarVentasPorMes";
            MySqlDataAdapter dt = new MySqlDataAdapter(proceso, connection);
            dt.SelectCommand.CommandType = CommandType.StoredProcedure;
            dt.SelectCommand.Parameters.AddRange(oParam);
            dt.Fill(Tabla);
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in Tabla.Rows)
                {
                    Entidades.Reporte_Ventas listaVentas = new Entidades.Reporte_Ventas();
                    //listaProveedores.idProveedor = Convert.ToInt32(item["idProducto"].ToString());
                    listaVentas.mes = item["mes"].ToString();
                    if (Convert.ToInt32(item["Ventas"].ToString()) > 0)
                    {
                        listaVentas.TotalVentasPorMes = Convert.ToInt32(item["Ventas"].ToString());
                    }
                    else
                    { listaVentas.TotalVentasPorMes = 0; }
                    _listaVentas.Add(listaVentas);
                }
            }
            connection.Close();
            return _listaVentas;


        }
    }
}
