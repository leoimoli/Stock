using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class VueltoWF : Form
    {
        private List<ListaProductoVenta> listaProductos;
        private int idusuario;

        public VueltoWF(List<ListaProductoVenta> listaProductos, int idusuario)
        {
            InitializeComponent();
            this.listaProductos = listaProductos;
            lblTotalPagar.Text = Convert.ToString(listaProductos[0].PrecioVentaFinal);
            txtEfectivo.Focus();
            this.idusuario = idusuario;
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

        private void VueltoWF_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimirTicket_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
            }
            catch (Exception ex)
            { }
        }
    }
}
