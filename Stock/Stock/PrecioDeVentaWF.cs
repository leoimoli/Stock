using Stock.Entidades;
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
    public partial class PrecioDeVentaWF : Master
    {
        public PrecioDeVentaWF()
        {
            InitializeComponent();
        }

        private void PrecioDeVentaWF_Load(object sender, EventArgs e)
        {
            try
            {
                ListaHistorialPrecioDeVenta = Negocio.Consultar.ListaHistorialPrecioDeVenta();
            }
            catch (Exception ex)
            { }

        }
        public List<Entidades.HistorialDelProductoSeleccionado> ListaHistorialDelProductoSeleccionado
        {
            set
            {
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.DataSource = value;
                dataGridView2.ReadOnly = true;

                dataGridView2.Columns[0].HeaderText = "id Movimiento";
                dataGridView2.Columns[0].Width = 95;
                dataGridView2.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView2.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView2.Columns[0].Visible = true;

                dataGridView2.Columns[1].HeaderText = "Código Producto";
                dataGridView2.Columns[1].Width = 95;
                dataGridView2.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView2.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                dataGridView2.Columns[1].Visible = true;

                dataGridView2.Columns[2].HeaderText = "Precio de venta";
                dataGridView2.Columns[2].Width = 95;
                dataGridView2.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView2.Columns[3].HeaderText = "Fecha de Cambio";
                dataGridView2.Columns[3].Width = 125;
                dataGridView2.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView2.Columns[4].HeaderText = "Usuario";
                dataGridView2.Columns[4].Width = 95;
                dataGridView2.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            }
        }
        public List<Entidades.HistorialDelProductoSeleccionado> ListaHistorialPrecioDeVenta
        {
            set
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "id Movimiento";
                dataGridView1.Columns[0].Width = 95;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Código Producto";
                dataGridView1.Columns[1].Width = 95;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[1].Visible = true;

                dataGridView1.Columns[2].HeaderText = "Precio de venta";
                dataGridView1.Columns[2].Width = 95;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Fecha de Cambio";
                dataGridView1.Columns[3].Width = 125;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "Usuario";
                dataGridView1.Columns[4].Width = 95;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            }
        }
        private void CalcularCostos()
        {
            if (txtTotalCompra.Text != "" & txtReditoPorcentual.Text != "   %")
            {
                decimal totalCompraIngresada = Convert.ToDecimal(txtValorUni.Text);
                var split = txtReditoPorcentual.Text.Split('%')[0];
                split = split.Trim();
                decimal porcentaje = Convert.ToDecimal(split) / 100;
                decimal ValorVentaCalculado;
                if (totalCompraIngresada > 0 & porcentaje > 0)
                {
                    ValorVentaCalculado = totalCompraIngresada * porcentaje + totalCompraIngresada;
                    txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado,2));
                }
            }
        }
        #region Botones
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string codigoIngresado = txtCodigo.Text;
                    int idProducto = Negocio.Consultar.BuscarProductoPorCodigo(codigoIngresado);
                    if (idProducto > 0)
                    {
                        List<HistorialProductoPrecioDeVenta> Lista = new List<HistorialProductoPrecioDeVenta>();
                        Lista = Negocio.Consultar.HistorialPrecioDeVenta(idProducto);
                        var lista = Lista.First();
                        txtValorUni.Text = Convert.ToString(lista.ValorUnitario);
                        txtTotalCompra.Text = Convert.ToString(lista.PrecioTotalDeCompra);
                        txtPrecioActualVenta.Text = Convert.ToString(lista.PrecioDeVenta);
                        ListaHistorialDelProductoSeleccionado = Negocio.Consultar.HistorialProducto(idProducto);
                    }
                }
                catch { }
            }
        }

        private void txtReditoPorcentual_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
    }
    #endregion
}
