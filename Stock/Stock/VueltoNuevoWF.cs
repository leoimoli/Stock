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
    public partial class VueltoNuevoWF : Form
    {
        private decimal precioVentaFinal;
        public VueltoNuevoWF(decimal precioVentaFinal)
        {
            InitializeComponent();
            this.precioVentaFinal = precioVentaFinal;
            lblTotal.Text = Convert.ToString(precioVentaFinal);
            lblEfectivo.Focus();
        }
        private void lblEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal Total = Convert.ToDecimal(lblTotal.Text);
                decimal Efectivo = Convert.ToDecimal(lblEfectivo.Text);
                decimal Vuelto = Efectivo - Total;
                lblVuelto.Text = Convert.ToString(Vuelto);
            }
            if (e.KeyCode == Keys.Escape)
            {
                const string message2 = "Se registro la venta exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                Close();
            }
        }
        private void VueltoNuevoWF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                const string message2 = "Se registro la venta exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                Close();
            }
            if (e.KeyCode == Keys.Delete)
            {              
                Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            const string message2 = "Se registro la venta exitosamente.";
            const string caption2 = "Éxito";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Asterisk);
            Close();
        }
    }
}
