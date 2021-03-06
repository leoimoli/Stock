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
            //  string campo = Convert.ToString(totalPagar);
            //string valor =  campo.Replace(",", ".");         
            txtDeuda.Text = Convert.ToString(totalPagar);
            txtDeuda.Focus();
        }
        public static int idCliente;
        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<Entidades.Clientes> _cliente = new List<Entidades.Clientes>();
                _cliente = Negocio.Consultar.BuscarClienteIngresado(txtDni.Text);
               
                if (_cliente.Count > 0)
                {
                    idCliente = _cliente[0].IdCliente;
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
                else
                {
                    const string message = "Desea agregar un nuevo cliente?";
                    const string caption = "Cliente Inexistente";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            ClientesWF _clientePantalla = new ClientesWF();
                            _clientePantalla.Show();
                            Hide();
                        }
                    }
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
                    const string message2 = "Se registro la deuda exitosamente.";
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
