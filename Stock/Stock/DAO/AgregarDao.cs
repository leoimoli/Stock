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
