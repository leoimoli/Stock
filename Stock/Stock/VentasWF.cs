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
    public partial class VentasWF : Master
    {
        public VentasWF()
        {
            InitializeComponent();
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
                            label3.Text = Convert.ToString(lista.PrecioUnitario);
                            lblNombreProducto.Text = lista.NombreProducto;
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
                if (Exito == true)
                {
                    //MessageBox.Show("SE REGISTRO EL COBRO EXITOSAMENTE.");
                    BloquearPantalla();
                }
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
                label3.Text = "0";
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
    }
}
