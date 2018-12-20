using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPrintTicket;

namespace Stock
{
    public partial class VentasWF : Master
    {
        public VentasWF()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Menu_KeyDown);
        }
        private void VentasWF_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.ReadOnly = true;
            txtNombreBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleClass.Autocomplete();
            txtNombreBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static List<Entidades.ListaProductoVenta> listaProductos;
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string codigoProducto = txtCodigo.Text;
                    List<Entidades.ListaProductoVenta> _lista = new List<Entidades.ListaProductoVenta>();

                    if (!listaProductos.Any(x => x.CodigoProducto == codigoProducto))
                    {
                        _lista = Negocio.Consultar.BuscarProductoParaVenta(codigoProducto);
                        if (_lista.Count > 0)
                        {
                            int cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                            _lista[0].Cantidad = cantidadingresada;
                            var lista = _lista.First();
                            listaProductos.Add(lista);
                            decimal PrecioFinal = lista.PrecioVenta * cantidadingresada;
                            dgvVentas.Rows.Add(lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
                            if (lista.Foto != null)
                            {
                                Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(lista.Foto);
                                pictureBox1.Image = foto1;
                            }
                            //label3.Text = Convert.ToString(lista.PrecioUnitario);
                            lblNombreProducto.Text = lista.NombreProducto;
                            txtCodigo.Clear();
                            txtCantidad.Text = "1";
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
                    else
                    {
                        int cantidadingresada = 1;
                        if (txtCantidad.Text != "")
                        {
                            cantidadingresada = Convert.ToInt32(txtCantidad.Text);
                        }
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigoProducto)
                            {
                                int CantidadOld = Convert.ToInt32(row.Cells[2].Value.ToString());
                                int CantidadNew = Convert.ToInt32(cantidadingresada.ToString());
                                int cantidad = CantidadOld + CantidadNew;
                                listaProductos[row.Index].Cantidad = cantidad;
                                row.Cells[2].Value = cantidad;
                                decimal ValorVenta = Convert.ToDecimal(row.Cells[3].Value.ToString());
                                decimal PrecioFinal = cantidad * ValorVenta;
                                row.Cells[4].Value = PrecioFinal;
                            }
                        }

                    }
                    decimal PrecioTotalFinal = 0;
                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (row.Cells[4].Value != null)
                            PrecioTotalFinal += Convert.ToDecimal(row.Cells[4].Value.ToString());
                    }
                    txtCodigo.Clear();
                    lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
                }
                catch (Exception ex)
                { }
            }
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string codigoProducto = txtCodigo.Text;
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
                            dgvVentas.Rows.Add(lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
                            if (lista.Foto != null)
                            {
                                Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(lista.Foto);
                                pictureBox1.Image = foto1;
                            }
                            // lblVueltoFijo.Text = Convert.ToString(lista.PrecioUnitario);
                            lblNombreProducto.Text = lista.NombreProducto;
                            txtCodigo.Clear();
                        }
                    }
                    else
                    {
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigoProducto)
                            {
                                int CantidadOld = Convert.ToInt32(row.Cells[2].Value.ToString());
                                int CantidadNew = Convert.ToInt32(cantidadingresada.ToString());
                                int cantidad = CantidadOld + CantidadNew;
                                listaProductos[row.Index].Cantidad = cantidad;
                                row.Cells[2].Value = cantidad;
                                decimal ValorVenta = Convert.ToDecimal(row.Cells[3].Value.ToString());
                                decimal PrecioFinal = cantidad * ValorVenta;
                                row.Cells[4].Value = PrecioFinal;
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
                        if (row.Cells[4].Value != null)
                            PrecioTotalFinal += Convert.ToDecimal(row.Cells[4].Value.ToString());
                    }
                    lblTotalPagarReal.Text = Convert.ToString(PrecioTotalFinal);
                }
                catch (Exception ex)
                { }
            }
        }
        public static int idVenta;
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count > 0)
            {
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                int idusuario = idusuarioLogueado;
                listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                BloquearPantalla();
                ///// GENERAR TICKET.........
                Ticket ticket = new Ticket();

                ticket.AddHeaderLine("La Brújula");
                ticket.AddHeaderLine("EXPEDIDO EN:");
                ticket.AddHeaderLine("44 N°1111");
                ticket.AddHeaderLine("La Plata, BsAS");
                ticket.AddHeaderLine("RFC: CSI-020226-MV4");

                ticket.AddSubHeaderLine("Ticket # 1");
                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                foreach (DataGridViewRow row in dgvVentas.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        ticket.AddItem(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[4].Value.ToString());
                    }

                }
                //ticket.AddTotal("SUBTOTAL", "12.00");
                //ticket.AddTotal("IVA", "0");
                ticket.AddTotal("TOTAL", lblTotalPagarReal.Text);
                ticket.AddTotal("", "");
                //ticket.AddTotal("RECIBIDO", "0");
                //ticket.AddTotal("CAMBIO", "0");
                ticket.AddTotal("", "");
                var Efectivo = textBox1.Text;
                var Vuelto = lblCambio.Text;
                ticket.AddFooterLine(Efectivo);
                ticket.AddFooterLine(Vuelto);
                // ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
                //ticket.PrintTicket("RICOH MP C2004 PCL 6");
                btnCuentaCorriente.Visible = true;
                //}
            }
        }
        private void BloquearPantalla()
        {
            //dgvVentas.Enabled = false;
            panel1.Enabled = false;
            panel2.Enabled = false;
            dgvVentas.Focus();
        }
        private void dgvVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                panel1.Enabled = true;
                panel2.Enabled = true;
                lblTotalPagarReal.Text = "0";
                lblVueltoFijo.Text = "0";
                lblNombreProducto.Text = "Nuevo Producto";
                txtCodigo.Clear();
                dgvVentas.Rows.Clear();
                txtCodigo.Focus();
                listaProductos = new List<Entidades.ListaProductoVenta>();
                dgvVentas.RowHeadersVisible = false;
                dgvVentas.ReadOnly = true;
                pictureBox1.Image = null;
                lblEfectivoFijo.Visible = false;
                btnCuentaCorriente.Visible = false;
                textBox1.Visible = false;
                textBox1.Clear();
                lblCambio.Visible = false;
                lblVueltoFijo.Visible = false;
                btnCobrar.Visible = false;
                btnFinalizarVenta.Visible = true;
            }
        }
        void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F12")
            {
                if (listaProductos.Count > 0)
                {
                    int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                    int idusuario = idusuarioLogueado;
                    listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                    //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                    idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                    BloquearPantalla();
                    ///// GENERAR TICKET.........
                    Ticket ticket = new Ticket();

                    ticket.AddHeaderLine("La Brújula");
                    ticket.AddHeaderLine("EXPEDIDO EN:");
                    ticket.AddHeaderLine("44 N°1111");
                    ticket.AddHeaderLine("La Plata, BsAS");
                    ticket.AddHeaderLine("RFC: CSI-020226-MV4");

                    ticket.AddSubHeaderLine("Ticket # 1");
                    ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            ticket.AddItem(row.Cells[2].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[4].Value.ToString());
                        }

                    }
                    //ticket.AddTotal("SUBTOTAL", "12.00");
                    //ticket.AddTotal("IVA", "0");
                    ticket.AddTotal("TOTAL", lblTotalPagarReal.Text);
                    ticket.AddTotal("", "");
                    //ticket.AddTotal("RECIBIDO", "0");
                    //ticket.AddTotal("CAMBIO", "0");
                    ticket.AddTotal("", "");
                    var Efectivo = textBox1.Text;
                    var Vuelto = lblCambio.Text;
                    ticket.AddFooterLine(Efectivo);
                    ticket.AddFooterLine(Vuelto);
                    // ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
                    //ticket.PrintTicket("RICOH MP C2004 PCL 6");
                    //btnCuentaCorriente.Visible = true;
                    //}
                }
            }
            if (e.KeyCode.ToString() == "F10")
            {
                btnCobrar.Visible = true;
                btnCuentaCorriente.Visible = true;
                lblEfectivoFijo.Visible = true;
                textBox1.Visible = true;
                textBox1.Focus();
                lblVueltoFijo.Visible = true;
                lblCambio.Visible = true;
                btnFinalizarVenta.Visible = false;
            }
            if (e.KeyCode.ToString() == "F1")
            {
                decimal TotalPagar = Convert.ToDecimal(lblTotalPagarReal.Text);
                CuentaCorrienteWF _cuenta = new CuentaCorrienteWF(TotalPagar, idVenta);
                _cuenta.Show();
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (textBox1.Text != "")
                    {
                        decimal TotalVenta = Convert.ToDecimal(lblTotalPagarReal.Text);
                        decimal Efectivo = Convert.ToDecimal(textBox1.Text);
                        decimal Vuelto = Efectivo - TotalVenta;
                        lblCambio.Text = Convert.ToString(Vuelto);
                        btnCobrar.Visible = true;
                        textBox1.Text = Convert.ToString(Efectivo);
                        lblEfectivoFijo.Visible = true;
                        lblCambio.Visible = true;
                        lblVueltoFijo.Visible = true;

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
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            btnCobrar.Visible = true;
            btnCuentaCorriente.Visible = false;
            lblEfectivoFijo.Visible = true;
            textBox1.Visible = true;
            textBox1.Focus();
            lblVueltoFijo.Visible = true;
            lblCambio.Visible = true;
            btnFinalizarVenta.Visible = false;
        }
        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            try
            {
                decimal TotalPagar = Convert.ToDecimal(lblTotalPagarReal.Text);
                CuentaCorrienteWF _cuenta = new CuentaCorrienteWF(TotalPagar, idVenta);
                _cuenta.Show();
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
        public static string ProductoEliminar;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count > 0)
            {
                if (dgvVentas.CurrentRow.Cells[0].Value != null)
                {
                    ProductoEliminar = dgvVentas.CurrentRow.Cells[0].Value.ToString();
                    dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
                    EliminarProductoDeLista();
                }
            }
        }
        private void EliminarProductoDeLista()
        {
            try
            {
                foreach (var item in listaProductos)
                {
                    string BuscoCodigo = item.CodigoProducto;
                    if (BuscoCodigo == ProductoEliminar)
                    {
                        decimal PrecioAcumuladoViejo = Convert.ToDecimal(lblTotalPagarReal.Text);
                        decimal ValorRestar = item.PrecioVenta;
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
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
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
                    if (CodigoProducto != "")
                    {
                        txtCodigo.Text = Convert.ToString(CodigoProducto);
                        txtNombreBuscar.Clear();
                        txtCodigo.Focus();
                    }

                }
                catch (Exception ex)
                { }
            }
        }
    }
}



