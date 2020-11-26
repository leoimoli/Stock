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
            label2.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
            txtCodigo.Focus();
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
                            dgvVentas.Rows.Add(lista.idProducto, lista.CodigoProducto, lista.NombreProducto, cantidadingresada, lista.PrecioVenta, PrecioFinal);
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
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
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
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
            }
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
        private void FacturarVenta()
        {
            if (listaProductos.Count > 0)
            {
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                int idusuario = idusuarioLogueado;
                listaProductos[0].PrecioVentaFinal = Convert.ToDecimal(lblTotalPagarReal.Text);
                //bool Exito = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                idVenta = Negocio.Ventas.RegistrarVenta(listaProductos, idusuario);
                BloquearPantalla();
                VueltoNuevoWF _vuelto = new VueltoNuevoWF(listaProductos[0].PrecioVentaFinal);
                _vuelto.Show();
                //GenerarTicket();               
            }
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
            panel1.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombreBuscar.Enabled = false;
            txtCantidad.Enabled = false;
            dgvVentas.Focus();
        }
        private void dgvVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DesbloquearPantalla();
            }
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
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
            panel1.Enabled = true;
            txtCodigo.Enabled = true;
            txtNombreBuscar.Enabled = true;
            txtCantidad.Enabled = true;
            lblTotalPagarReal.Text = "0"; txtCodigo.Clear();
            dgvVentas.Rows.Clear();
            txtCodigo.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.ReadOnly = true;
        }
        private void VentasNuevoWF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                DesbloquearPantalla();
            }
            if (e.KeyCode.ToString() == "F12")
            {
                FacturarVenta();
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
    }
}
