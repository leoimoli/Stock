using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPrintTicket;
using Stock.Entidades;
using Stock.Negocio;
using Utils;

namespace Stock
{
    public partial class VueltoNuevoWF : Form
    {
        private decimal precioVentaFinal;
        private bool AplicaDescuento;
        private int idVenta;
        public static decimal ValorOriginal;
        private List<ListaProductoVenta> lista;
        private List<DetalleOferta> listaOfertas;
        public VueltoNuevoWF(decimal precioVentaFinal, bool AplicaDescuento, int idVenta, List<ListaProductoVenta> lista, List<DetalleOferta> listaOfertas)
        {
            InitializeComponent();
            this.precioVentaFinal = precioVentaFinal;
            this.AplicaDescuento = AplicaDescuento;
            this.idVenta = idVenta;
            lblTotal.Text = Convert.ToString(precioVentaFinal);
            lblTotal.ForeColor = Color.White;
            ValorOriginal = Convert.ToDecimal(lblTotal.Text);
            this.lista = lista;
            listaProductos = lista;
            this.listaOfertas = listaOfertas;
            VentaConDescuento = AplicaDescuento;
            listaOfertasStatic = listaOfertas;
        }
        public static List<DetalleOferta> listaOfertasStatic;
        private void lblEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal Total = Convert.ToDecimal(lblTotal.Text);
                decimal Efectivo = Convert.ToDecimal(lblEfectivo.Text);
                decimal Vuelto = Efectivo - Total;
                lblVuelto.Text = Convert.ToString(Vuelto);
                lblVuelto.ForeColor = Color.White;
            }
            if (e.KeyCode == Keys.Escape)
            {
                RecalcularVenta();
            }
            if (e.KeyCode.ToString() == "F10")
            {
                grbDescuentos.Visible = true;
                txtReditoPorcentual.Focus();
            }
        }
        private void VueltoNuevoWF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                RecalcularVenta();
            }
            if (e.KeyCode == Keys.Delete)
            {
                Close();
            }

            if (e.KeyCode.ToString() == "F10")
            {
                grbDescuentos.Visible = true;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RecalcularVenta();
        }
        public static bool Bonificaciones;
        private void RecalcularVenta()
        {
            contadorModificaciones = 1;
            bool Exito = false;
            decimal ValorNuevo = Convert.ToDecimal(lblTotal.Text);
            if (ValorOriginal != ValorNuevo)
            {
                Exito = Negocio.Ventas.ActualizarVenta(ValorNuevo, idVenta);
                Bonificaciones = true;
            }
            else { Exito = true; }
            if (Exito == true)
            {
                Tkt(idVenta, lista);
                const string message2 = "Se registro la venta exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                Close();
            }
        }
        private static List<ListaProductoVenta> listaProductos;
        private static bool VentaConDescuento;
        public static decimal MontoBonificacion;
        public static void Tkt(int idVenta, List<Entidades.ListaProductoVenta> listaProducto)
        {
            CrearTicket ticket = new CrearTicket();
            if (VentaConDescuento == true)
            {
                //if (venta.Comprobante.Cae_afip != null && venta.Comprobante.Cae_afip != "")
                //ticket.Encabezado(venta.Comprobante.Numero_comprobante, true);
                if (idVenta > 0)
                {
                    ticket.Encabezado(Convert.ToString(idVenta), false);
                }
                //else
                //    ticket.Encabezado(venta.IdVenta.ToString(), false);
                foreach (var item in listaProducto)
                {
                    double ProductoMontoTotal = Convert.ToDouble(item.Cantidad * item.PrecioVenta);
                    ticket.AgregaArticulo(item.NombreProducto, item.Cantidad, Convert.ToDouble(item.PrecioVenta), ProductoMontoTotal);
                }
                if (listaOfertasStatic.Count > 0)
                {
                    foreach (var item in listaOfertasStatic)
                    {
                        ticket.AgregarDescuentos(item.Descripcion, null, Convert.ToDouble(item.MontoDescuento), null);
                    }
                }
                if (Bonificaciones == true)
                {
                    ticket.AgregarDescuentos("BONIFICACIÓN APLICADA", null, Convert.ToDouble(MontoBonificacion), null);
                }


                //if (venta.Comprobante.Cae_afip != null && venta.Comprobante.Cae_afip != "")
                //ticket.AgregaTotales(venta.Total, venta.Comprobante.Cae_afip, venta.Comprobante.Fecha_vto_cae_afip.Value.ToShortDateString());

                //ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
                //else
                ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
            }
            else
            {
                //if (venta.Comprobante.Cae_afip != null && venta.Comprobante.Cae_afip != "")
                //ticket.Encabezado(venta.Comprobante.Numero_comprobante, true);
                if (idVenta > 0)
                {
                    ticket.Encabezado(Convert.ToString(idVenta), false);
                }
                //else
                //    ticket.Encabezado(venta.IdVenta.ToString(), false);
                foreach (var item in listaProducto)
                {
                    double ProductoMontoTotal = Convert.ToDouble(item.Cantidad * item.PrecioVenta);
                    ticket.AgregaArticulo(item.NombreProducto, item.Cantidad, Convert.ToDouble(item.PrecioVenta), ProductoMontoTotal);
                }
                if (Bonificaciones == true)
                {
                    ticket.AgregarDescuentos("BONIFICACIÓN APLICADA", null, Convert.ToDouble(MontoBonificacion), null);
                }
                //if (venta.Comprobante.Cae_afip != null && venta.Comprobante.Cae_afip != "")
                //ticket.AgregaTotales(venta.Total, venta.Comprobante.Cae_afip, venta.Comprobante.Fecha_vto_cae_afip.Value.ToShortDateString());

                //ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
                //else
                ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
            }
        }
        private void VueltoNuevoWF_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado.Perfil == "1" || Sesion.UsuarioLogueado.Perfil == "SUPER ADMIN")
            {
                btnDescuentos.Visible = true;
            }
            else { btnDescuentos.Visible = false; }

            if (AplicaDescuento == true)
            {
                lblDescuentos.Visible = true;
                this.ActiveControl = lblEfectivo;
                lblEfectivo.Focus();
            }
            else
            {
                lblDescuentos.Visible = false;
                this.ActiveControl = lblEfectivo;
                lblEfectivo.Focus();
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            grbDescuentos.Visible = true;
            txtReditoPorcentual.Focus();
        }
        private void btnAplicarPorcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                CalcularCostos();
            }
            catch (Exception ex)
            { }
        }
        public static decimal ValorVentaOriginal;
        public static int contadorModificaciones = 1;
        private void CalcularCostos()
        {
            if (contadorModificaciones == 1)
            {
                ValorVentaOriginal = Convert.ToDecimal(lblTotal.Text);
                decimal NuevoValorVenta = Convert.ToDecimal(lblTotal.Text);
                decimal ValorVenta = ValorVentaOriginal;
                if (txtReditoPorcentual.Text != "   %" && ValorVenta > 0)
                {
                    var split = txtReditoPorcentual.Text.Split('%')[0];
                    split = split.Trim();
                    decimal porcentaje = Convert.ToDecimal(split) / 100;
                    decimal ValorVentaCalculado;
                    if (ValorVenta > 0 & porcentaje > 0)
                    {
                        ValorVentaCalculado = ValorVenta - ValorVenta * porcentaje;
                        lblTotal.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                        txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                        MontoBonificacion = Convert.ToDecimal(decimal.Round(ValorVentaCalculado, 2));
                    }
                }
                contadorModificaciones = contadorModificaciones + 1;
            }
            else if (contadorModificaciones > 1)
            {
                decimal NuevoValorVenta = ValorVentaOriginal;
                decimal ValorVenta = ValorVentaOriginal;
                if (txtReditoPorcentual.Text != "   %" && ValorVenta > 0)
                {
                    var split = txtReditoPorcentual.Text.Split('%')[0];
                    split = split.Trim();
                    decimal porcentaje = Convert.ToDecimal(split) / 100;
                    decimal ValorVentaCalculado;
                    if (ValorVenta > 0 & porcentaje > 0)
                    {
                        ValorVentaCalculado = ValorVenta - ValorVenta * porcentaje;
                        lblTotal.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                        txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                        MontoBonificacion = Convert.ToDecimal(decimal.Round(ValorVentaCalculado, 2));
                    }
                }
                contadorModificaciones = contadorModificaciones + 1;
            }
            lblEfectivo.Focus();
        }
        private void btnAplicarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                AplicarNuevoPrecio();
            }
            catch (Exception ex)
            { }
        }
        private void AplicarNuevoPrecio()
        {
            if (contadorModificaciones == 1)
            {
                ValorVentaOriginal = Convert.ToDecimal(lblTotal.Text);
                decimal ValorNuevo = Convert.ToDecimal(txtPrecioVenta.Text);
                lblTotal.Text = Convert.ToString(decimal.Round(ValorNuevo, 2));
                contadorModificaciones = contadorModificaciones + 1;
            }
            else if (contadorModificaciones > 1)
            {
                decimal ValorNuevo = Convert.ToDecimal(txtPrecioVenta.Text);
                lblTotal.Text = Convert.ToString(decimal.Round(ValorNuevo, 2));
                contadorModificaciones = contadorModificaciones + 1;
            }
            lblEfectivo.Focus();
        }

        private void btnCancelarDescuento1_Click(object sender, EventArgs e)
        {
            try
            {
                txtReditoPorcentual.Clear();
                lblTotal.Text = Convert.ToString(ValorVentaOriginal);
                contadorModificaciones = 1;
                txtPrecioVenta.Clear();
            }
            catch (Exception ex)
            { }
        }
        private void btnCancelaDescuento2_Click(object sender, EventArgs e)
        {
            try
            {
                txtPrecioVenta.Clear();
                lblTotal.Text = Convert.ToString(ValorVentaOriginal);
                contadorModificaciones = 1;
            }
            catch (Exception ex)
            { }
        }
        private void txtReditoPorcentual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCostos();
            }
           
        }
        private void txtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AplicarNuevoPrecio();
            }
        }
    }
}
