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
        }            
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
    }
}
