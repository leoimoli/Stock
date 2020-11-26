using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class PreciosNuevoWF : Form
    {
        public PreciosNuevoWF()
        {
            InitializeComponent();
        }

        private void PreciosNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionListarProductosConPrecios();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionListarProductosConPrecios()
        {
            FuncionBuscartexto();
            dgvProductos.Rows.Clear();
            List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductos();
            if (ListaProductos.Count > 0)
            {
                foreach (var item in ListaProductos)
                {
                    if (item.PrecioDeVenta > 0)
                    {
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                    }
                    else
                    {
                        item.PrecioDeVenta = Convert.ToDecimal("0.00");
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                    }
                }
            }
            dgvProductos.ReadOnly = true;
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void txtCodigoBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvProductos.Rows.Clear();
                string Codigo = txtCodigoBus.Text;
                List<Entidades.Productos> ListaProductos = Negocio.Consultar.BuscarProductoPorCodigoIngresado(Codigo);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        if (item.PrecioDeVenta > 0)
                        {
                            dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                        }
                        else
                        {
                            item.PrecioDeVenta = Convert.ToDecimal("0.00");
                            dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                        }
                    }
                }
                dgvProductos.ReadOnly = true;
            }
        }
        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvProductos.Rows.Clear();
                string Descripcion = txtDescipcionBus.Text;
                List<Entidades.Productos> ListaProductos = Negocio.Consultar.BuscarProductoPorDescripcion(Descripcion);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        if (item.PrecioDeVenta > 0)
                        {
                            dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                        }
                        else
                        {
                            item.PrecioDeVenta = Convert.ToDecimal("0.00");
                            dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                        }
                    }
                }
                dgvProductos.ReadOnly = true;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                idProductoIngresado = 0;
                lblCodigo.Visible = true;
                txtCodigoProducto.Visible = true;
                txtCodigoProducto.Focus();
            }
            catch (Exception ex)
            { }
        }
        public static int idProductoIngresado;
        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string Codigo = txtCodigoProducto.Text;
                    List<Entidades.HistorialProductoPrecioDeVenta> ListaProductos = Negocio.Consultar.BuscarProductoHistorialPrecios(Codigo);
                    if (ListaProductos.Count > 0)
                    {
                        foreach (var item in ListaProductos)
                        {
                            idProductoIngresado = item.idProducto;
                            txtValorUni.Text = Convert.ToString(item.ValorUnitario);
                        }
                        txtValorUni.Enabled = false;
                        txtReditoPorcentual.Enabled = true;
                        txtPrecioVenta.Enabled = true;
                        txtReditoPorcentual.Focus();
                    }
                    else
                    {
                        const string message2 = "El producto ingresado no posee ningun valor unitario de compra registrado.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        txtValorUni.Enabled = false;
                        txtReditoPorcentual.Enabled = false;
                        txtValorUni.Focus();
                    }

                }
            }
            catch (Exception ex)
            { }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.PrecioDeVenta _stock = CargarEntidad();
                bool Exito = Negocio.Stock.CargarPrecioDeVenta(_stock);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro el stock exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            lblCodigo.Visible = false;
            txtCodigoProducto.Visible = false;
            txtValorUni.Enabled = false;
            txtReditoPorcentual.Enabled = false;
            txtPrecioVenta.Enabled = false;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private Entidades.PrecioDeVenta CargarEntidad()
        {
            Entidades.PrecioDeVenta _stock = new Entidades.PrecioDeVenta();
            DateTime fechaActual = DateTime.Now;
            _stock.FechaActual = fechaActual;
            if (String.IsNullOrEmpty(txtReditoPorcentual.Text))
            {
                _stock.ReditoPorcentual = "0 %";
            }
            else { _stock.ReditoPorcentual = txtReditoPorcentual.Text; }

            if (!String.IsNullOrEmpty(txtPrecioVenta.Text))
            {
                string Valor = txtPrecioVenta.Text;
                var temp = Valor.Replace(".", "<TEMP>");
                var temp2 = temp.Replace(",", ",");
                var replaced = temp2.Replace("<TEMP>", ",");
                _stock.Precio = Convert.ToDecimal(replaced);
            }
            _stock.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
            _stock.idProducto = idProductoIngresado;
            return _stock;
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
        private void txtReditoPorcentual_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        private void CalcularCostos()
        {
            if (txtReditoPorcentual.Text != "   %" && txtValorUni.Text != "")
            {
                decimal ValorUnitario = Convert.ToDecimal(txtValorUni.Text);
                var split = txtReditoPorcentual.Text.Split('%')[0];
                split = split.Trim();
                decimal porcentaje = Convert.ToDecimal(split) / 100;
                decimal ValorVentaCalculado;
                if (ValorUnitario > 0 & porcentaje > 0)
                {
                    ValorVentaCalculado = ValorUnitario * porcentaje + ValorUnitario;
                    txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
                }
            }
        }
        public static int Funcion = 0;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcion = 2;
            List<Entidades.HistorialProductoPrecioDeVenta> _precio = new List<Entidades.HistorialProductoPrecioDeVenta>();
            idProductoIngresado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
            txtCodigoProducto.Visible = true;
            lblCodigo.Visible = true;
            txtCodigoProducto.Enabled = false;
            txtCodigoProducto.Text = Convert.ToString(this.dgvProductos.CurrentRow.Cells[1].Value);
            _precio = Negocio.Consultar.HistorialPrecioDeVenta(idProductoIngresado);
            HabilitarCamposProdcutoSeleccionado(_precio);
        }
        private void HabilitarCamposProdcutoSeleccionado(List<HistorialProductoPrecioDeVenta> precio)
        {
            if (precio.Count > 0)
            {
                var ListaPrecio = precio.First();
                txtValorUni.Text = Convert.ToString(ListaPrecio.ValorUnitario);
                txtReditoPorcentual.Enabled = true;
                txtPrecioVenta.Enabled = true;
                idProductoIngresado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
                string codigo = Convert.ToString(this.dgvProductos.CurrentRow.Cells[1].Value);
                string descripcion = Convert.ToString(this.dgvProductos.CurrentRow.Cells[2].Value);
                string marca = Convert.ToString(this.dgvProductos.CurrentRow.Cells[3].Value);
                string precioVenta = Convert.ToString(this.dgvProductos.CurrentRow.Cells[4].Value);
                dgvProductos.Rows.Clear();
                dgvProductos.Rows.Add(idProductoIngresado, codigo, descripcion, marca, precioVenta);
            }
            else
            {
                txtReditoPorcentual.Enabled = false;
                txtPrecioVenta.Enabled = true;
                idProductoIngresado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
                string codigo = Convert.ToString(this.dgvProductos.CurrentRow.Cells[1].Value);
                string descripcion = Convert.ToString(this.dgvProductos.CurrentRow.Cells[2].Value);
                string marca = Convert.ToString(this.dgvProductos.CurrentRow.Cells[3].Value);
                string precioVenta = Convert.ToString(this.dgvProductos.CurrentRow.Cells[4].Value);
                dgvProductos.Rows.Clear();
                dgvProductos.Rows.Add(idProductoIngresado, codigo, descripcion, marca, precioVenta);
            }
        }
        private void btnMasivos_Click(object sender, EventArgs e)
        {
            PrecioModificacionMasivoWF _precio = new PrecioModificacionMasivoWF();
            _precio.Show();
        }
    }
}
