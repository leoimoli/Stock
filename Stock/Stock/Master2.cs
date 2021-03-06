﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Master2 : Master
    {
        public Master2()
        {
            InitializeComponent();
        }
        private void Master_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado != null)
            {
                //lblMaster_UsuarioLogin.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
                //lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_VentasWF _reporte = new Reporte_VentasWF();
            _reporte.Show();
            Hide();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Reporte_ComprasWF _compra = new Reporte_ComprasWF();
            _compra.Show();
            Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Reporte_ProductoWF _producto = new Reporte_ProductoWF();
            _producto.Show();
            Hide();
        }
    }
}
