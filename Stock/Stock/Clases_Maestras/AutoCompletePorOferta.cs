﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stock.Clases_Maestras
{
   public class AutoCompletePorOferta
    {
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = new MySqlConnection(Properties.Settings.Default.db);
            conexion.Open();
            string consulta = "Select NombreCombo from ofertas";
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
                coleccion.Add(Convert.ToString(row["NombreCombo"]));
            }
            return coleccion;
        }
    }
}
