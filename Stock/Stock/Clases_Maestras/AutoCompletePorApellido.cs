using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Stock.Clases_Maestras
{
    public class AutoCompletePorApellido
    {
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.db);
            conexion.Open();
            string consulta = "Select txApellido, txNombre from clientes";
            MySqlCommand cmd = new MySqlCommand(consulta, conexion);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            conexion.Close();
            return dt;
        }
        public static AutoCompleteStringCollection Autocomplete()
        {
            DataTable DT = Datos();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in DT.Rows)
            {
                string Apellido = Convert.ToString(row["txApellido"]);
                string Nombre = Convert.ToString(row["txNombre"]);
                string Persona = Apellido + "," + Nombre;
                coleccion.Add(Persona);
            }
            return coleccion;
        }
    }
}
