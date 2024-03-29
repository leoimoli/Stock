﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
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
    public partial class VentasNuevoWF : Form
    {
        public VentasNuevoWF()
        {
            InitializeComponent();
            ValidarFechasFestivas();
        }
        private void ValidarFechasFestivas()
        {
            List<FechasFestivas> _listaFechas = new List<FechasFestivas>();
            _listaFechas = DAO.ConsultarDao.BuscarFechasFestivas();
            int AñoActual = DateTime.Now.Year;
            DateTime FechaActual = DateTime.Now;

            ///// Codigo para forzar fechas
            //AñoActual = AñoActual + 1;
            //FechaActual = Clases_Maestras.FechasFestivasForzadas.ForzarFecha();          

            foreach (var item in _listaFechas)
            {
                string FechaDesde = item.FechaDesde + "/" + AñoActual;
                string FechaHasta = item.FechaHasta + "/" + AñoActual;
                if (FechaActual > Convert.ToDateTime(FechaDesde) && Convert.ToDateTime(FechaActual) < Convert.ToDateTime(FechaHasta))
                {
                    picNavidad.Visible = true;
                    Image imgFiestas = Image.FromFile(Environment.CurrentDirectory + "\\" + item.NombreImagen);
                    picNavidad.Image = imgFiestas;
                    break;
                }
                else
                {
                    picNavidad.Visible = false;
                }
            }
        }
        private void VentasNuevoWF_Load(object sender, EventArgs e)
        {
            CargarComboMediosDePago();
            lblUsuario.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
            txtNombreBuscar.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            txtNombreBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtNombreBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void CargarComboMediosDePago()
        {
            List<string> Medios = DAO.ConsultarDao.CargarMediosDePago();
            cmbMediosDePago.Items.Clear();
            foreach (string item in Medios)
            {
                cmbMediosDePago.Text = "EFECTIVO";
                cmbMediosDePago.Items.Add(item);
            }
        }

        public static List<Entidades.ListaProductoVenta> listaProductos;
        public static List<Entidades.ListaProductoVenta> listaProductosConDescuentos;
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
                    lblCategoria.Visible = true;
                    lblCategoria.Text = _lista[0].NombreProducto;
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
                if (_listaEspeciales.Count == 0)
                {
                    ListaProductoVenta elemento = new ListaProductoVenta();
                    elemento.Cantidad = cantidadingresada;
                    _listaEspeciales.Add(elemento);
                }
                else
                {
                    _listaEspeciales[0].Cantidad = cantidadingresada;
                }
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
                lblCategoria.Text = "";
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
            if (e.KeyCode == Keys.Enter || KeyCodeSubValor == "Sub_Enter")
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

                    //CalcularTotales();
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

        private void CalcularTotales()
        {
            List<Entidades.ListaProductoVenta> listaProductosDinamica = new List<ListaProductoVenta>();
            decimal SubTotal = 0;
            int TotalProductos = 0;
            decimal MontoDescuento = 0;
            decimal MontoTotal = 0;
            int CantidadReal = 0;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                ///// Calculo SUBTOTAL
                decimal PrecioTotal = Convert.ToInt32(row.Cells["PrecioTotal"].Value);
                SubTotal = SubTotal + PrecioTotal;
                //lblSubtotal.Text = Convert.ToString(SubTotal);

                ///// Calculo la cantidad de productos.
                int Valor = Convert.ToInt32(row.Cells["Cantidad"].Value);
                TotalProductos = TotalProductos + Valor;
                //lblTotalProductos.Text = Convert.ToString(TotalProductos);

                /////// Busco Descuentos             

                //listaProductosConDescuentos = BuscarPromociones(listaProductos);
                //if (listaProductosConDescuentos.Count > 0)
                //{
                //    foreach (var item in listaProductosConDescuentos)
                //    {
                //        DetalleOferta detalle = new DetalleOferta();
                //        MontoDescuento = MontoDescuento + item.MontoDescuento;
                //        lblDescuentos.Text = Convert.ToString(MontoDescuento);
                //    }
                //}
                ///// Calculo Total 
                MontoTotal = SubTotal - MontoDescuento;
                //lblTotal.Text = Convert.ToString(MontoTotal);
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
            CargarComboMediosDePago();
            dgvVentas.Focus();
        }
        public static string ProductoEliminar;
        public static string KeyCodeSubValor = "";
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

                groupBox2.Visible = true;
                txtCodigoAnulacion.Focus();

                //ProductoEliminar = dgvVentas.CurrentRow.Cells[1].Value.ToString();
                //decimal Monto = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[5].Value.ToString());
                //dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
                //EliminarProductoDeLista(Monto);
                //txtNombreBuscar.Focus();
                //VentaCerrada = false;
            }
            if (e.KeyCode == Keys.C)
            {
                string Descripcion = "Carniceria";
                string CodigoProducto = DAO.ConsultarDao.BuscarProductoPorDescripcion(Descripcion);
                txtNombreBuscar.Text = CodigoProducto;
                KeyCodeSubValor = "Sub_Enter";
                txtNombreBuscar_KeyDown(Keys.Enter, e);
                lblCategoria.Visible = true;
                lblCategoria.Text = "Carniceria";
                groupBox1.Visible = true;
                txtMonto.Focus();
                KeyCodeSubValor = "";
            }
            if (e.KeyCode == Keys.V)
            {
                string Descripcion = "Verduleria";
                string CodigoProducto = DAO.ConsultarDao.BuscarProductoPorDescripcion(Descripcion);
                txtNombreBuscar.Text = CodigoProducto;
                KeyCodeSubValor = "Sub_Enter";
                txtNombreBuscar_KeyDown(Keys.Enter, e);
                lblCategoria.Visible = true;
                lblCategoria.Text = "Verduleria";
                groupBox1.Visible = true;
                txtMonto.Focus();
                KeyCodeSubValor = "";
            }
            if (e.KeyCode == Keys.F)
            {
                string Descripcion = "Fiambreria";
                string CodigoProducto = DAO.ConsultarDao.BuscarProductoPorDescripcion(Descripcion);
                txtNombreBuscar.Text = CodigoProducto;
                KeyCodeSubValor = "Sub_Enter";
                txtNombreBuscar_KeyDown(Keys.Enter, e);
                lblCategoria.Visible = true;
                lblCategoria.Text = "Fiambreria";
                groupBox1.Visible = true;
                txtMonto.Focus();
                KeyCodeSubValor = "";
            }
            if (e.KeyCode == Keys.P)
            {
                string Descripcion = "Panaderia";
                string CodigoProducto = DAO.ConsultarDao.BuscarProductoPorDescripcion(Descripcion);
                txtNombreBuscar.Text = CodigoProducto;
                KeyCodeSubValor = "Sub_Enter";
                txtNombreBuscar_KeyDown(Keys.Enter, e);
                lblCategoria.Visible = true;
                lblCategoria.Text = "Panaderia";
                groupBox1.Visible = true;
                txtMonto.Focus();
                KeyCodeSubValor = "";
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
            DefinirTamañosFormMaximo();
        }
        private void DefinirTamañosFormNormal()
        {

            Form form1 = new Form();
            form1.StartPosition = FormStartPosition.CenterScreen;
            form1.Padding = new System.Windows.Forms.Padding(0);
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            panel3.Width = 1099;
            panel3.Height = 521;
            dgvVentas.Height = 339;
            dgvVentas.Width = 850;
            dgvVentas.Columns[1].Width = 200;
            dgvVentas.Columns[2].Width = 255;
            this.groupBox3.Location = new System.Drawing.Point(28, 397);
            this.Location = new Point(50, 50); //sobra si tienes la posición en el diseño
            this.Size = new Size(1300, 650);
        }
        private void DefinirTamañosFormMaximo()
        {
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 100;
            this.Height = bounds.Height - 100;
            dgvVentas.Height = 500;
            dgvVentas.Width = 1000;
            dgvVentas.Columns[1].Width = 250;
            dgvVentas.Columns[2].Width = 350;
            this.groupBox3.Location = new System.Drawing.Point(28, 550);

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            DefinirTamañosFormNormal();
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
        public static decimal PrecioFinal;
        public static List<DetalleOferta> listaOfertas;
        private void FacturarVenta()
        {
            List<DetalleOferta> lista = new List<DetalleOferta>();
            if (listaProductos.Count > 0)
            {
                List<Entidades.ListaProductoVentaEspejo> listaProductosOriginal = new List<ListaProductoVentaEspejo>();
                foreach (var item in listaProductos)
                {
                    Entidades.ListaProductoVentaEspejo ProductosOriginal = new Entidades.ListaProductoVentaEspejo();
                    ProductosOriginal.Cantidad = item.Cantidad;
                    ProductosOriginal.CodigoProducto = item.CodigoProducto;

                    ProductosOriginal.Fecha = item.Fecha;
                    ProductosOriginal.idOferta = item.idOferta;

                    ProductosOriginal.idProducto = item.idProducto;
                    ProductosOriginal.NombreProducto = item.NombreProducto;

                    ProductosOriginal.PrecioUnitario = item.PrecioUnitario;
                    ProductosOriginal.PrecioVenta = item.PrecioVenta;

                    ProductosOriginal.PrecioVentaFinal = item.PrecioVentaFinal;
                    ProductosOriginal.ProductoEspecial = item.ProductoEspecial;
                    listaProductosOriginal.Add(ProductosOriginal);
                }
                int idMedioDePago = DAO.ConsultarDao.SeleccionarIdMedioDePagoPorNombre(cmbMediosDePago.Text);

                listaProductosConDescuentos = BuscarPromociones(listaProductos);
                if (listaProductosConDescuentos.Count > 0)
                {
                    int contarDescuentos = 1;
                    decimal PrecioVentaOrig = Convert.ToDecimal(lblTotalPagarReal.Text);
                    foreach (var item in listaProductosConDescuentos)
                    {
                        if (contarDescuentos == 1)
                        {
                            PrecioFinal = PrecioVentaOrig + item.PrecioVentaFinal;
                            contarDescuentos = contarDescuentos + 1;
                        }
                        else
                        {
                            PrecioFinal = PrecioFinal + item.PrecioVentaFinal;
                            contarDescuentos = contarDescuentos + 1;
                        }

                        DetalleOferta detalle = new DetalleOferta();
                        detalle.Descripcion = item.NombreProducto;
                        detalle.PrecioOferta = item.PrecioUnitario;
                        detalle.MontoDescuento = item.MontoDescuento * item.Cantidad;
                        detalle.idOferta = item.idOferta;
                        lista.Add(detalle);
                    }
                    List<Entidades.ListaProductoVenta> listaProductos = new List<ListaProductoVenta>();

                    foreach (var item in listaProductosOriginal)
                    {
                        Entidades.ListaProductoVenta Productos = new Entidades.ListaProductoVenta();
                        Productos.Cantidad = item.Cantidad;
                        Productos.CodigoProducto = item.CodigoProducto;

                        Productos.Fecha = item.Fecha;
                        Productos.idOferta = item.idOferta;

                        Productos.idProducto = item.idProducto;
                        Productos.NombreProducto = item.NombreProducto;

                        Productos.PrecioUnitario = item.PrecioUnitario;
                        Productos.PrecioVenta = item.PrecioVenta;

                        Productos.PrecioVentaFinal = PrecioFinal;
                        Productos.ProductoEspecial = item.ProductoEspecial;
                        listaProductos.Add(Productos);
                    }
                    listaOfertas = lista;
                    VentaCerrada = true;
                    int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                    int idusuario = idusuarioLogueado;
                    listaProductos[0].PrecioVentaFinal = PrecioFinal;
                    idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario, idMedioDePago);
                    bool Exito = Negocio.Ventas.RegistrarDescuentosParaVenta(idVenta, listaOfertas);
                    bool AplicaDescuento = true;
                    BloquearPantalla();
                    VueltoNuevoWF _vuelto = new VueltoNuevoWF(listaProductos[0].PrecioVentaFinal, AplicaDescuento, idVenta, listaProductos, listaOfertas);
                    _vuelto.Show();
                    //string ImprimeTicket = Properties.Settings.Default.imprimeTicket;
                    //if (ImprimeTicket == "True")
                    //{
                    //    Tkt(idVenta, listaProductos);
                    //}


                    //DesbloquearPantalla();
                    lblBack.Visible = true;
                }
                else
                {
                    VentaCerrada = true;
                    int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                    int idusuario = idusuarioLogueado;
                    listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                    //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                    idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario, idMedioDePago);
                    bool AplicaDescuento = false;
                    BloquearPantalla();
                    VueltoNuevoWF _vuelto = new VueltoNuevoWF(listaProductos[0].PrecioVentaFinal, AplicaDescuento, idVenta, listaProductos, listaOfertas);
                    _vuelto.Show();
                    //string ImprimeTicket = Properties.Settings.Default.imprimeTicket;
                    //if (ImprimeTicket == "True")
                    //{
                    //    //GenerateTicketAndOpenCashDrawer();
                    //    Tkt(idVenta, listaProductos);
                    //}
                    //DesbloquearPantalla();
                    lblBack.Visible = true;
                }
            }
        }

        private List<Entidades.ListaProductoVenta> BuscarPromociones(List<Entidades.ListaProductoVenta> listaProductosEspejo)
        {
            double totalDescuento = 0;
            List<Entidades.ListaProductoVenta> listaDescuentos = new List<Entidades.ListaProductoVenta>();
            foreach (var producto in listaProductosEspejo)
            {
                if (producto.Cantidad > 0)
                {
                    List<Ofertas> promociones = Ventas.BuscarPromociones("", producto.idProducto, 2).OrderBy(x => x.PrecioCombo).ToList();
                    foreach (var item in promociones)
                    {
                        if (item.Productos.Count == 1)
                        {
                            int cantidad = producto.Cantidad / item.Productos.First().Unidades;
                            if (cantidad != 0)
                            {
                                double descuento_promocion = Convert.ToDouble((producto.PrecioVenta * (cantidad * item.Productos.First().Unidades)) - (cantidad * item.PrecioCombo));
                                Entidades.ListaProductoVenta descuento = new Entidades.ListaProductoVenta();
                                descuento.idOferta = item.idOferta;
                                descuento.PrecioVentaFinal = Convert.ToDecimal(-descuento_promocion);
                                descuento.NombreProducto = "DESCUENTO APLICADO POR " + item.NombreOferta;
                                descuento.Cantidad = cantidad;
                                descuento.PrecioUnitario = item.PrecioCombo;
                                descuento.MontoDescuento = item.MontoDescuento;
                                listaDescuentos.Add(descuento);
                                totalDescuento = totalDescuento + descuento_promocion;
                                producto.Cantidad = producto.Cantidad - (cantidad * item.Productos.First().Unidades);
                            }
                        }
                        else
                        {
                            if (!listaDescuentos.Exists(e => e.idOferta == item.idOferta))
                            {
                                double totalProductosPromocion = 0;
                                int cantidadPromociones = 10000;
                                bool promocionCompleta = true;
                                foreach (var itemNEW in item.Productos)
                                {
                                    Entidades.ListaProductoVenta productoVenta = listaProductosEspejo.Find(e => e.idProducto == itemNEW.idProducto);
                                    if (productoVenta != null)
                                    {
                                        if ((productoVenta.Cantidad / itemNEW.Unidades) == 0)
                                        {
                                            promocionCompleta = false;
                                            break;
                                        }
                                        else
                                        {
                                            int posiblesPromociones = productoVenta.Cantidad / itemNEW.Unidades;
                                            cantidadPromociones = cantidadPromociones > posiblesPromociones ? posiblesPromociones : cantidadPromociones;
                                            totalProductosPromocion = totalProductosPromocion + Convert.ToDouble(productoVenta.PrecioVenta);
                                        }
                                    }
                                    else
                                    {
                                        promocionCompleta = false;
                                        break;
                                    }
                                }
                                if (promocionCompleta)
                                {
                                    if (!listaDescuentos.Exists(e => e.idOferta == item.idOferta))
                                    {
                                        Entidades.ListaProductoVenta descuento = new Entidades.ListaProductoVenta();
                                        double descuento_promocion = ((cantidadPromociones * totalProductosPromocion) - (cantidadPromociones * Convert.ToDouble(item.PrecioCombo)));
                                        descuento.idOferta = item.idOferta;
                                        descuento.PrecioVentaFinal = Convert.ToDecimal(-descuento_promocion);
                                        descuento.NombreProducto = "DESCUENTO APLICADO POR " + item.NombreOferta;
                                        descuento.Cantidad = cantidadPromociones;
                                        descuento.PrecioUnitario = item.PrecioCombo;
                                        descuento.MontoDescuento = item.MontoDescuento;
                                        listaDescuentos.Add(descuento);
                                        totalDescuento = totalDescuento + descuento_promocion;
                                        foreach (var item2 in item.Productos)
                                        {
                                            Entidades.ListaProductoVenta productoVenta = listaProductosEspejo.Find(e => e.idProducto == item2.idProducto);
                                            productoVenta.Cantidad = productoVenta.Cantidad - (cantidadPromociones * item2.Unidades);
                                        }
                                    }
                                }
                            }
                        }

                    }
                }

            }
            return listaDescuentos;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            lblCategoria.Text = "";
            groupBox1.Visible = false;
        }

        private void txtCodigoAnulacion_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string CodigoAnulacion = txtCodigoAnulacion.Text;
                    bool CodigoValido = DAO.ConsultarDao.ValidarCodigoAnulacion(CodigoAnulacion);
                    if (CodigoValido == true)
                    {
                        txtCodigoAnulacion.Clear();
                        groupBox2.Visible = false;
                        ProductoEliminar = dgvVentas.CurrentRow.Cells[1].Value.ToString();
                        decimal Monto = Convert.ToDecimal(dgvVentas.CurrentRow.Cells[5].Value.ToString());
                        dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
                        EliminarProductoDeLista(Monto);
                        txtNombreBuscar.Focus();
                        VentaCerrada = false;
                    }
                    else
                    {
                        txtCodigoAnulacion.Clear();
                        const string message2 = "Atención: El código ingresado es incorrecto.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Green);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Transparent);
        }
    }
}

