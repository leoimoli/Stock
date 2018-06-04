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
                            int cantidadingresada = 1;
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
                            lblVueltoFijo.Text = Convert.ToString(lista.PrecioUnitario);
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
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (listaProductos.Count > 0)
            {
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                int idusuario = idusuarioLogueado;
                listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
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
                var Efectivo = txtEfectivo.Text;
                var Vuelto = lblCambio.Text;
                ticket.AddFooterLine(Efectivo);
                ticket.AddFooterLine(Vuelto);
                // ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
                ticket.PrintTicket("RICOH MP C2004 PCL 6");
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
            }
        }
        void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F12")
            {
                if (listaProductos.Count > 0)
                {
                    {

                        int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                        int idusuario = idusuarioLogueado;
                        listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                        //CobrarWF _cobrar = new CobrarWF(listaProductos, idusuario);
                        //_cobrar.ShowDialog();
                        bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                        if (Exito == true)
                        {
                            BloquearPantalla();
                            const string message = "¿Desea cargar puntos al cliente?";
                            const string caption = "Cliente registrado";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);
                            {
                                if (result == DialogResult.Yes)
                                {
                                    Char delimiter = ',';
                                    String[] pts = lblTotalPagarReal.Text.Split(delimiter);
                                    int puntos = Convert.ToInt32(pts[0]);
                                    CargarPuntosWF _cargar = new CargarPuntosWF(puntos);
                                    _cargar.Show();
                                }
                                else
                                {
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

                                    ticket.AddFooterLine("VUELVA PRONTO Y SINO CHUPALA");

                                    // ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
                                    ticket.PrintTicket("RICOH MP C2004 PCL 6");
                                }

                            }
                        }
                    }
                }
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void txtEfectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtEfectivo.Text != "")
                    {
                        decimal TotalVenta = Convert.ToDecimal(lblTotalPagarReal.Text);
                        decimal Efectivo = Convert.ToDecimal(txtEfectivo.Text);
                        decimal Vuelto = Efectivo - TotalVenta;
                        lblCambio.Text = Convert.ToString(Vuelto);
                        btnCobrar.Visible = true;
                        txtEfectivo.Text = Convert.ToString(Efectivo);
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            txtEfectivo.Focus();
            lblEfectivoFijo.Visible = true;
            txtEfectivo.Visible = true;
            lblVueltoFijo.Visible = true;
            lblCambio.Visible = true;
            btnFinalizarVenta.Visible = false;
        }
    }
}


