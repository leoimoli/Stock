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
    public partial class DescontarDeudaWF : Form
    {
        private List<Clientes> cliente;
        private string Deuda;
        public DescontarDeudaWF(List<Clientes> cliente, string Deuda)
        {
            InitializeComponent();
            this.Deuda = Deuda;
            this.cliente = cliente;
        }

        private void DescontarDeudaWF_Load(object sender, EventArgs e)
        {
            var _cliente = cliente.First();
            lblApellidoNombre.Text = _cliente.Apellido + " " + _cliente.Nombre;
            lblTotalPagar.Text = Deuda;
            lblTotalPagar.Visible = true;
            txtPago.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal PagoIngresado = Convert.ToDecimal(txtPago.Text);
                bool exito = Negocio.Clientes.ActualizarDeuda(cliente, Deuda, PagoIngresado);
                if (exito == true)
                {
                    const string message2 = "Se registro el descuento exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    Hide();
                }
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
    }
}
