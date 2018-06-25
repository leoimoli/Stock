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
    public partial class CuentaCorrienteWF : Form
    {
        private int idVenta;
        private decimal totalPagar;
        public CuentaCorrienteWF(decimal totalPagar, int idVenta)
        {
            InitializeComponent();
            this.totalPagar = totalPagar;
            this.idVenta = idVenta;
        }
        private void CuentaCorrienteWF_Load(object sender, EventArgs e)
        {
            txtDeuda.Focus();
        }
        public static int idCliente;
        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Entidades.Clientes> _cliente = new List<Entidades.Clientes>();
                _cliente = Negocio.Consultar.BuscarClienteIngresado(txtDni.Text);
                idCliente = _cliente[0].IdCliente;
                if (_cliente.Count > 0)
                {
                    lblTotalPagar.Text = Convert.ToString(totalPagar);
                    var cliente = _cliente[0].Apellido + " " + _cliente[0].Nombre;
                    lblApellidoNombre.Text = cliente;
                    lblCliente.Visible = true;
                    lblApellidoNombre.Visible = true;
                    lblTotalPagar.Visible = true;
                    lblDni.Visible = false;
                    txtDni.Visible = false;
                    btnGuardar.Visible = true;
                    txtDeuda.Visible = true;
                    lblDeudaFijo.Visible = true;
                    lblTotalVentaVisible.Visible = true;
                }
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string DeudaGuardar = txtDeuda.Text;
                DateTime Fecha = DateTime.Now;
                bool exito = Negocio.Clientes.RegistrarCuentaCorriente(idCliente, DeudaGuardar, Fecha, idVenta);
                if (exito == true)
                {
                    MessageBox.Show("La deuda se registro exitosamente.");
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
