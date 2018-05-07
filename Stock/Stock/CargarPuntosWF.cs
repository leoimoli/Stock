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
    public partial class CargarPuntosWF : Form
    {
        private int puntos;
        public CargarPuntosWF(int puntos)
        {
            InitializeComponent();
            this.puntos = puntos;
            idCliente = 0;
        }
        private void CargarPuntosWF_Load(object sender, EventArgs e)
        {
            txtDni.Focus();
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
                    lblPuntosVariables.Text = Convert.ToString(puntos);
                    var cliente = _cliente[0].Apellido + " " + _cliente[0].Nombre;
                    lblApellidoNombre.Text = cliente;
                    lblCliente.Visible = true;
                    lblApellidoNombre.Visible = true;
                    lblPuntosVisible.Visible = true;
                    lblPuntosVariables.Visible = true;
                    lblPuntosVisible.Visible = true;
                    lblDni.Visible = false;
                    txtDni.Visible = false;
                    btnGuardar.Visible = true;
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool exito = Negocio.Clientes.RegistrarPuntos(idCliente, lblPuntosVariables.Text);
                if (exito == true)
                {
                    MessageBox.Show("LOS PUNTOS SE REGISTRARON EXITOSAMENTE.");
                    Hide();
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
