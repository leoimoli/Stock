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
    public static class ConsultarDao
    {
        private static MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(Properties.Settings.Default.db);
        public static List<Usuarios> LoginUsuario(string usuario, string contraseña)
        {
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
                    lista.Add(listaUsuario);
                }
            }
            connection.Close();
            return lista;
        }

        public static bool ValidarProveedorExistente(string nombreEmpresa)
        {
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "productos");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "proveedores");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
                    if (item[10].ToString() != string.Empty)
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
            dt.Fill(ds, "proveedores");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "productos");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
        public static List<Usuarios> ListarUsuarios()
        {
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
            DataSet ds = new DataSet();
            dt.Fill(ds, "usuarios");
            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow item in ds.Tables[0].Rows)
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
