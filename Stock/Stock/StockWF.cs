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
                CargarComboProveedor();
            }
            catch (Exception ex) { }
        }
        #region Metodos Generales
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
                decimal totalCompraIngresada = Convert.ToDecimal(txtTotalCompra.Text);
                var split = txtReditoPorcentual.Text.Split('%')[0];
                split = split.Trim();
                decimal porcentaje = Convert.ToDecimal(split) / 100;
                decimal ValorVentaCalculado;
                if (totalCompraIngresada > 0 & porcentaje > 0)
                {
                    ValorVentaCalculado = totalCompraIngresada * porcentaje + totalCompraIngresada;
                    txtPrecioVenta.Text = Convert.ToString(ValorVentaCalculado);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtCantidad.Clear();
            dtFechaCompra.Value = DateTime.Now;
            txtValorUni.Clear();
            txtPrecioVenta.Clear();
            txtRemito.Clear();
            dtFechaVencimiento.Value = DateTime.Now;
            txtReditoPorcentual.Clear();
            txtPrecioVenta.Clear();
            List<string> Marcas = Negocio.Consultar.CargarComboMarcas();
            //cmbMarca.Items.Add("Seleccione");
            //foreach (string item in Marcas)
            //{
            //    cmbMarca.Text = "Seleccione";
            //    cmbMarca.Items.Add(item);
            //}
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
                    //List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                    //ListaProductos = ListaReducidos;
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
                        ProductoIngresado = idProducto;
                        txtCodigoProducto.Text = codigoIngresado;
                        txtCodigoProducto.Enabled = false;
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
        #endregion
        private void txtReditoPorcentual_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
    }
}