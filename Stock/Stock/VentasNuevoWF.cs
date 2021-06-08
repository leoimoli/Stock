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
using Utils;

namespace Stock
{
    public partial class VentasNuevoWF : Form
    {
        public VentasNuevoWF()
        {
            InitializeComponent();
        }
        private void VentasNuevoWF_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
            txtNombreBuscar.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            txtNombreBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtNombreBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static List<Entidades.ListaProductoVenta> listaProductos;
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarProductoPorCodigo();
            }
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
            }
        }
        List<Entidades.ListaProductoVenta> _listaEspeciales = new List<Entidades.ListaProductoVenta>();
        private void BuscarProductoPorCodigo()
        {
            try
            {
                if (txtCodigo.Text == "0")
                {
                    const string message = "El código del producto es invalido.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    throw new Exception();
                }
                string codigoProducto;
                if (txtCodigo.Text != "")
                { codigoProducto = txtCodigo.Text; }
                else
                { codigoProducto = txtNombreBuscar.Text; }
                bool EsEspecial = Negocio.Consultar.ValidarProductoEspecial(codigoProducto);

                if (!listaProductos.Any(x => x.CodigoProducto == codigoProducto))
                {
                    ListaProductoEnGrilla();
                }
                else
                {
                    if (listaProductos.Any(x => x.CodigoProducto == codigoProducto) && EsEspecial == true)
                    {
                        ListaProductoEnGrilla();
                    }
                    else
                    {
                        int cantidadingresada = 1;
                        if (txtCantidad.Text != "")
                        {
                            cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                        }
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == codigoProducto)
                            {
                                int CantidadOld = Convert.ToInt32(row.Cells[3].Value.ToString());
                                int CantidadNew = Convert.ToInt32(cantidadingresada.ToString());
                                int cantidad = CantidadOld + CantidadNew;
                                listaProductos[row.Index].Cantidad = cantidad;
                                row.Cells[3].Value = cantidad;
                                decimal ValorVenta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                                decimal PrecioFinal = cantidad * ValorVenta;
                                row.Cells[5].Value = PrecioFinal;
                            }
                        }
                    }
                }
                decimal PrecioTotalFinal = 0;
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells[4].Value != null)
                        PrecioTotalFinal += Convert.ToDecimal(row.Cells[5].Value.ToString());
                }
                txtCodigo.Clear();
                lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
            }
            catch (Exception ex)
            { }
        }
        private void ListaProductoEnGrilla()
        {
            string codigoProducto;
            if (txtCodigo.Text != "")
            { codigoProducto = txtCodigo.Text; }
            else
            { codigoProducto = txtNombreBuscar.Text; }
            List<Entidades.ListaProductoVenta> _lista = new List<Entidades.ListaProductoVenta>();
            _lista = Negocio.Consultar.BuscarProductoParaVenta(codigoProducto);
            if (_lista.Count > 0 && _lista[0].ProductoEspecial == 0 && _lista[0].PrecioVenta > 0)
            {
                int cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                _lista[0].Cantidad = cantidadingresada;
                var lista = _lista.First();
                listaProductos.Add(lista);
                decimal PrecioFinal = lista.PrecioVenta * cantidadingresada;
                dgvVentas.Rows.Add(lista.idProducto, lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
                txtCodigo.Clear();
                txtCantidad.Text = "1";
            }
            else
            {
                if (_lista[0].ProductoEspecial == 1)
                {
                    _listaEspeciales = _lista;
                    groupBox1.Visible = true;
                    txtMonto.Focus();
                }
                else
                {
                    const string message2 = "El producto ingresado no existe o no tiene un precio de venta cargado.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
            }
        }
        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                decimal MontoEspecial = Convert.ToDecimal(txtMonto.Text);
                int cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                _listaEspeciales[0].Cantidad = cantidadingresada;
                var lista = _listaEspeciales.First();
                listaProductos.Add(lista);
                lista.PrecioVenta = MontoEspecial;
                decimal PrecioFinal = MontoEspecial;
                dgvVentas.Rows.Add(lista.idProducto, lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
                txtCodigo.Clear();
                txtCantidad.Text = "1";
                txtMonto.Clear();
                groupBox1.Visible = false;

                decimal PrecioTotalFinal = 0;
                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells[4].Value != null)
                        PrecioTotalFinal += Convert.ToDecimal(row.Cells[5].Value.ToString());
                }
                txtCodigo.Clear();
                lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
                txtNombreBuscar.Focus();
            }
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string codigoProducto;
                    if (txtCodigo.Text == "")
                    {
                        codigoProducto = txtNombreBuscar.Text;
                        codigoProducto = Convert.ToString(Negocio.Consultar.BuscarPorDescripcion(codigoProducto));
                    }
                    else
                    { codigoProducto = txtCodigo.Text; }

                    List<Entidades.ListaProductoVenta> _lista = new List<Entidades.ListaProductoVenta>();
                    int cantidadingresada = 1;
                    if (txtCantidad.Text != "")
                    {
                        cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                    }
                    if (!listaProductos.Any(x => x.CodigoProducto == codigoProducto))
                    {
                        _lista = Negocio.Consultar.BuscarProductoParaVenta(codigoProducto);
                        if (_lista.Count > 0)
                        {
                            _lista[0].Cantidad = cantidadingresada;
                            var lista = _lista.First();
                            listaProductos.Add(lista);
                            decimal PrecioFinal = lista.PrecioVenta * cantidadingresada;
                            dgvVentas.Rows.Add(lista.idProducto, lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
                            txtCodigo.Clear();
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == codigoProducto)
                            {
                                int CantidadOld = Convert.ToInt32(row.Cells[3].Value.ToString());
                                int CantidadNew = Convert.ToInt32(cantidadingresada.ToString());
                                int cantidad = CantidadOld + CantidadNew;
                                listaProductos[row.Index].Cantidad = cantidad;
                                row.Cells[3].Value = cantidad;
                                decimal ValorVenta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                                decimal PrecioFinal = cantidad * ValorVenta;
                                row.Cells[5].Value = PrecioFinal;
                            }
                        }
                    }
                    txtCodigo.Clear();
                    cantidadingresada = 1;
                    txtCantidad.Text = "1";
                    txtCodigo.Focus();
                    decimal PrecioTotalFinal = 0;
                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (row.Cells[5].Value != null)
                            PrecioTotalFinal += Convert.ToDecimal(row.Cells[5].Value.ToString());
                    }
                    lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
                }
                catch (Exception ex)
                { }
            }
        }
        private void txtNombreBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string descripcion = txtNombreBuscar.Text;
                    var CodigoProducto = Negocio.Consultar.BuscarPorDescripcion(descripcion);
                    if (CodigoProducto == "0")
                    {
                        BuscarProductoPorCodigo();
                    }
                    else
                    {
                        txtCodigo.Text = Convert.ToString(CodigoProducto);
                        BuscarProductoPorCodigo();
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                { }
            }
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
            }

        }
        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombreBuscar.Clear();
            txtCantidad.Text = "1";
            //txtNombreBuscar.Focus();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        public static int idVenta;
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            FacturarVenta();
        }
        bool VentaCerrada = false;
        private void FacturarVenta()
        {
            if (listaProductos.Count > 0)
            {
                VentaCerrada = true;
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                int idusuario = idusuarioLogueado;
                listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                BloquearPantalla();
                VueltoNuevoWF _vuelto = new VueltoNuevoWF(listaProductos[0].PrecioVentaFinal);
                _vuelto.Show();
                Tkt(idVenta, listaProductos);
                //DesbloquearPantalla();
                lblBack.Visible = true;
            }
        }
        public static void Tkt(int idVenta, List<Entidades.ListaProductoVenta> listaProducto)
        {
            CrearTicket ticket = new CrearTicket();
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
            //if (venta.Comprobante.Cae_afip != null && venta.Comprobante.Cae_afip != "")
            //ticket.AgregaTotales(venta.Total, venta.Comprobante.Cae_afip, venta.Comprobante.Fecha_vto_cae_afip.Value.ToShortDateString());

            //ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
            //else
            ticket.AgregaTotales(Convert.ToDouble(listaProductos[0].PrecioVentaFinal), null, null);
        }
        private void GenerarTicket()
        {
            ///// GENERAR TICKET.........
            //Ticket ticket = new Ticket();
            //ticket.AddHeaderLine("Almacen Lo del vecino");
            //ticket.AddHeaderLine("EXPEDIDO EN:");
            //ticket.AddHeaderLine("213 bis N°1111");
            //ticket.AddHeaderLine("La Plata, BsAS");
            //ticket.AddHeaderLine("RFC: CSI-020226-MV4");
            //ticket.AddSubHeaderLine("Ticket # 1");
            //ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
            //foreach (DataGridViewRow row in dgvVentas.Rows)
            //{
            //    if (row.Cells[0].Value != null)
            //    {
            //        ticket.AddItem(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[4].Value.ToString());
            //    }
            //}             
            //ticket.AddTotal("TOTAL", lblTotalPagarReal.Text);
            //ticket.AddTotal("", "");              
            //ticket.AddTotal("", "");
            //var Efectivo = textBox1.Text;
            //var Vuelto = lblCambio.Text;
            //ticket.AddFooterLine(Efectivo);
            //ticket.AddFooterLine(Vuelto);
            //ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
            //ticket.PrintTicket("RICOH MP C2004 PCL 6");
            //btnCuentaCorriente.Visible = true;
            //}
        }
        private void BloquearPantalla()
        {
            dgvVentas.Enabled = false;
            panel4.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombreBuscar.Enabled = false;
            txtCantidad.Enabled = false;
            dgvVentas.Focus();
        }
        public static string ProductoEliminar;
        private void dgvVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DesbloquearPantalla();
                lblBack.Visible = false;
            }
            if (e.KeyCode.ToString() == "F12")
            {
                if (VentaCerrada == true)
                { }
                else { FacturarVenta(); }               
            }
            if (e.KeyCode == Keys.Delete)
            {
                ProductoEliminar = dgvVentas.CurrentRow.Cells[1].Value.ToString();
                decimal Monto = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[5].Value.ToString());
                dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
                EliminarProductoDeLista(Monto);
                txtNombreBuscar.Focus();
                VentaCerrada = false;
            }
        }
        private void ModificarGrilla()
        {
            string codigoProducto = Convert.ToString(this.dgvVentas.CurrentRow.Cells[1].Value);
            int cantidadingresada = Convert.ToInt32(this.dgvVentas.CurrentRow.Cells[3].Value); ;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == codigoProducto)
                {
                    int cantidad = cantidadingresada;
                    listaProductos[row.Index].Cantidad = cantidad;
                    row.Cells[3].Value = cantidad;
                    decimal ValorVenta = Convert.ToDecimal(row.Cells[4].Value.ToString());
                    decimal PrecioFinal = cantidad * ValorVenta;
                    row.Cells[5].Value = PrecioFinal;
                }
            }
            decimal PrecioTotalFinal = 0;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells[4].Value != null)
                    PrecioTotalFinal += Convert.ToDecimal(row.Cells[5].Value.ToString());
            }
            txtCodigo.Clear();
            lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
        }
        private void DesbloquearPantalla()
        {
            dgvVentas.Enabled = true;
            panel4.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombreBuscar.Enabled = true;
            txtCantidad.Enabled = true;
            lblTotalPagarReal.Text = "0"; txtCodigo.Clear();
            dgvVentas.Rows.Clear();
            txtNombreBuscar.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.ReadOnly = true;
            lblBack.Visible = false;
        }
        private void VentasNuevoWF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DesbloquearPantalla();
            }
            if (e.KeyCode.ToString() == "F12")
            {
                if (VentaCerrada == true)
                { }
                else { FacturarVenta(); }
            }
        }
        private void dgvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ModificarGrilla();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NewMasterWF _inicio = new NewMasterWF();
            _inicio.Show();
            Hide();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        private void EliminarProductoDeLista(decimal Monto)
        {
            try
            {
                foreach (var item in listaProductos)
                {
                    string BuscoCodigo = item.CodigoProducto;
                    if (BuscoCodigo == ProductoEliminar)
                    {
                        decimal PrecioAcumuladoViejo = Convert.ToDecimal(lblTotalPagarReal.Text);
                        decimal ValorRestar = Monto;
                        decimal NuevoPrecioFinal = PrecioAcumuladoViejo - ValorRestar;
                        item.PrecioVentaFinal = NuevoPrecioFinal;
                        lblTotalPagarReal.Text = Convert.ToString(NuevoPrecioFinal);
                        listaProductos.Remove(item);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

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
        private void btnClaro_Click(object sender, EventArgs e)
        {
            txtNombreBuscar.Focus();
            panel3.BackColor = Color.WhiteSmoke;
            dgvVentas.BackgroundColor = Color.WhiteSmoke;
            panel4.BackColor = Color.Gray;
            dgvVentas.GridColor = Color.LightSlateGray;
            lblTotalPagarReal.BackColor = Color.White;
            lblTotalPagarReal.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            label1.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            groupBox1.BackColor = Color.Gray;
            txtMonto.ForeColor = Color.Black;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvVentas.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvVentas.RowsDefaultCellStyle.ForeColor = Color.Black;
            dgvVentas.RowsDefaultCellStyle.SelectionBackColor = Color.Gray;
        }
        private void btnOscuro_Click(object sender, EventArgs e)
        {
            txtNombreBuscar.Focus();
            panel3.BackColor = Color.FromArgb(49, 66, 82);
            dgvVentas.BackgroundColor = Color.FromArgb(49, 66, 82);
            panel4.BackColor = Color.FromArgb(49, 66, 82);
            dgvVentas.GridColor = Color.LightSlateGray;
            lblTotalPagarReal.BackColor = Color.FromArgb(49, 66, 82);
            lblTotalPagarReal.ForeColor = Color.White;
            button1.BackColor = Color.FromArgb(49, 66, 82);
            button1.ForeColor = Color.White;
            label1.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            groupBox1.BackColor = Color.FromArgb(49, 66, 82);
            txtMonto.ForeColor = Color.Black;
            dgvVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvVentas.RowsDefaultCellStyle.BackColor = Color.FromArgb(49, 66, 82);
            dgvVentas.RowsDefaultCellStyle.ForeColor = Color.White;
            dgvVentas.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
        }
    }
}
