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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosWF _usuario = new UsuariosWF();
            _usuario.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Producto _producto = new Producto();
            _producto.Show();
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StockWF _stock = new StockWF();
            _stock.Show();
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_VentasWF _reporte = new Reporte_VentasWF();
            _reporte.Show();
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            VentasWF _ventas = new VentasWF();
            _ventas.Show();
            Hide();
        }
    }
}
