using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class StockWF : Master
    {
        public StockWF()
        {
            InitializeComponent();

        }
        public static int ProductoIngresado;
        private void StockWF_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Focus();
                CargarComboProveedor();
                Lista = new List<ListaStock>();
                Lista = Negocio.Consultar.ListaDeStock();
            }
            catch (Exception ex) { }
        }
        #region Metodos Generales
        private void HabilitarLabels()
        {
            EditCódigo_Producto.Visible = true;
            EditNombre_Producto.Visible = true;
            EditMarca_Producto.Visible = true;
            EditStock_Disponible.Visible = true;
            EditPrecio_de_Venta.Visible = true;
            EditFecha_Alta_Producto.Visible = true;
            EditUsuario_Creador.Visible = true;
        }
        public List<Entidades.ListaStock> Lista
        {
            set
            {
                lblUltimoMovimientos.Text = "Últimos Movimientos";
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "idProducto";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Código";
                dataGridView1.Columns[1].Width = 95;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Nombre";
                dataGridView1.Columns[2].Width = 95;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Marca";
                dataGridView1.Columns[3].Width = 95;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[3].Visible = false;

                dataGridView1.Columns[4].HeaderText = "Cantidad";
                dataGridView1.Columns[4].Width = 80;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;


                dataGridView1.Columns[5].HeaderText = "Fecha";
                dataGridView1.Columns[5].Width = 80;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[6].HeaderText = "Fecha";
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = false;
            }
        }
        private void CalcularCostos()
        {
            if (txtCantidad.Text != "" & txtValorUni.Text != "")
            {
                int cantidadIngresada = Convert.ToInt32(txtCantidad.Text);
                decimal ValorUnitarioIngresado = Convert.ToDecimal(txtValorUni.Text);
                decimal PrecioTotalCalculado;
                if (cantidadIngresada > 0 & ValorUnitarioIngresado > 0)
                {
                    PrecioTotalCalculado = cantidadIngresada * ValorUnitarioIngresado;
                    txtTotalCompra.Text = Convert.ToString(PrecioTotalCalculado);
                }
            }
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
                    //txtPrecioVenta.Text = Convert.ToString(ValorVentaCalculado);
                    txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                }
            }
        }
        private void LimpiarCampos()
        {
            txtTotalCompra.Clear();
            txtCodigoProducto.Clear();
            txtCantidad.Clear();
            dtFechaCompra.Value = DateTime.Now;
            txtValorUni.Clear();
            txtPrecioVenta.Clear();
            txtRemito.Clear();
            dtFechaVencimiento.Value = DateTime.Now;
            txtReditoPorcentual.Clear();
            txtPrecioVenta.Clear();
            List<string> Proveedores = Negocio.Consultar.CargarComboProveedor();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtCodigo.Clear();
            txtMarca.Clear();
            txtNombreProducto.Clear();
            txtCodigo.Focus();

            //// Limpiar Labels
            EditCódigo_Producto.Visible = false;
            EditNombre_Producto.Visible = false;
            EditMarca_Producto.Visible = false;
            EditStock_Disponible.Visible = false;
            EditPrecio_de_Venta.Visible = false;
            EditFecha_Alta_Producto.Visible = false;
            EditUsuario_Creador.Visible = false;
        }
        public static int idStockGrilla;
        public void CargarComboProveedor()
        {
            List<string> Proveedor = new List<string>();
            Proveedor = Negocio.Consultar.CargarComboProveedor();
            cmbProveedor.Items.Add("Seleccione");
            cmbProveedor.Items.Clear();
            foreach (string item in Proveedor)
            {
                cmbProveedor.Text = "Seleccione";
                cmbProveedor.Items.Add(item);
            }
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private Entidades.Stock CargarEntidad()
        {
            Entidades.Stock _stock = new Entidades.Stock();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _stock.idProducto = ProductoIngresado;
            _stock.CodigoProducto = txtCodigoProducto.Text;
            _stock.Cantidad = Convert.ToInt32(txtCantidad.Text);
            _stock.Proveedor = cmbProveedor.Text;
            DateTime fechaActual = DateTime.Now;
            _stock.FechaActual = fechaActual;
            _stock.FechaCompra = dtFechaCompra.Value;
            _stock.ValorUnitario = Convert.ToDecimal(txtValorUni.Text);
            _stock.ValorCompra = Convert.ToDecimal(txtTotalCompra.Text);
            _stock.Remito = txtRemito.Text;
            _stock.VencimientoLote = dtFechaVencimiento.Value;
            _stock.ReditoPorcentual = txtReditoPorcentual.Text;
            _stock.PrecioDeVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            _stock.idUsuario = idusuarioLogueado;
            return _stock;
        }
        #endregion
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Stock _stock = CargarEntidad();
                ProgressBar();
                bool Exito = Negocio.Stock.CargarStock(_stock);
                if (Exito == true)
                {
                    MessageBox.Show("SE REGISTRO EL STOCK EXITOSAMENTE.");
                    LimpiarCampos();
                    Lista = new List<ListaStock>();
                    Lista = Negocio.Consultar.ListaDeStock();
                }
            }
            catch (Exception ex)
            { }
        }
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
                        panel_CargarStock.Enabled = true;
                        lblStock.Text = "Ingreso de Stock";
                        ProductoIngresado = idProducto;
                        Lista = new List<ListaStock>();
                        Lista = Negocio.Consultar.ListaDeStockPoridProdcuto(idProducto);
                        txtCodigoProducto.Text = codigoIngresado;
                        txtCodigoProducto.Enabled = false;
                        ///// Armo una nueva lista para mostrar en el panel Información.
                        List<ListaStockProducto> _lista = new List<ListaStockProducto>();
                        _lista = Negocio.Consultar.ListarStockProdcuto(idProducto);
                        if (_lista.Count > 0)
                        {
                            lblEstadisticas.Text = "Información del producto ingresado";
                            lblInformacion.Visible = false;
                            var lista = _lista.First();
                            txtMarca.Text = lista.Marca;
                            txtNombreProducto.Text = lista.NombreProducto;
                            txtMarca.Enabled = false;
                            txtNombreProducto.Enabled = false;
                            HabilitarLabels();
                            EditCódigo_Producto.Text = lista.CodigoProducto;
                            EditNombre_Producto.Text = lista.NombreProducto;
                            EditMarca_Producto.Text = lista.Marca;
                            EditStock_Disponible.Text = Convert.ToString(lista.Cantidad);
                            EditPrecio_de_Venta.Text = Convert.ToString(lista.PrecioVenta);
                            EditFecha_Alta_Producto.Text = Convert.ToString(lista.FechaAlta);
                            EditUsuario_Creador.Text = lista.Apellido + "  " + lista.Nombre;
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Desea agregar un nuevo producto ?", "Producto Inexistente", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                        {
                            Producto _producto = new Producto();
                            _producto.Show();
                            Hide();
                        }
                    }
                }
                catch { }
            }
        }
        private void txtTotalCompra_Enter(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        private void txtValorUni_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        private void txtReditoPorcentual_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        #endregion       
    }
}