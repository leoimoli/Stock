using Stock.Entidades;
using System;
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
    public partial class CobrarWF : Form
    {
        public CobrarWF()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
        }
        public CobrarWF(List<ListaProductoVenta> listaProductos, int idusuario) : this()
        {
            this.listaProductos = listaProductos;
            this.idusuario = idusuario;
        }
        private void CobrarWF_Load(object sender, EventArgs e)
        {
            txtEfectivo.Focus();
            lblTotalPagar.Text = Convert.ToString(listaProductos[0].PrecioVentaFinal);
        }
        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtEfectivo.Text != "")
                    {
                        decimal TotalVenta = listaProductos[0].PrecioVentaFinal;
                        decimal Efectivo = Convert.ToDecimal(txtEfectivo.Text);
                        decimal Vuelto = Efectivo - TotalVenta;
                        lblCambio.Text = Convert.ToString(Vuelto);
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
            //if (Exito == true)
            //{
            //    BloquearPantalla();
            //}
        }
        private void BloquearPantalla()
        {
            //dgvVentas.Enabled = false;
            //panel1.Enabled = false;
            //panel2.Enabled = false;
            //dgvVentas.Focus();
        }
        void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F2")
            {
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                txtTitulaTarjate.Focus();
                chcVisa.Visible = true;
                chcMaster.Visible = true;
            }
        }
    }
}
