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
        public static int ProductoIngresado;
        private void PrecioDeVentaWF_Load(object sender, EventArgs e)
        {
            try
            {
                ListaHistorialPrecioDeVenta = Negocio.Consultar.ListaHistorialPrecioDeVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
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

                dataGridView1.Columns[3].HeaderText = "Fecha de Modificación";
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
                    txtPrecioVenta.Text = Convert.ToString(decimal.Round(ValorVentaCalculado, 2));
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
                    txtReditoPorcentual.Enabled = true;
                    txtPrecioVenta.Enabled = true;
                    string codigoIngresado = txtCodigo.Text;
                    int idProducto = Negocio.Consultar.BuscarProductoPorCodigo(codigoIngresado);
                    if (idProducto > 0)
                    {
                        ProductoIngresado = idProducto;
                        List<HistorialProductoPrecioDeVenta> Lista = new List<HistorialProductoPrecioDeVenta>();
                        Lista = Negocio.Consultar.HistorialPrecioDeVenta(idProducto);
                        if (Lista.Count == 0)
                        {
                            MessageBox.Show("El producto ingresado no posee un precio de venta previamente cargado.");
                            throw new Exception();
                        }
                        else
                        {
                            var lista = Lista.First();
                            txtValorUni.Text = Convert.ToString(lista.ValorUnitario);
                            txtTotalCompra.Text = Convert.ToString(lista.PrecioTotalDeCompra);
                            txtPrecioActualVenta.Text = Convert.ToString(lista.PrecioDeVenta);
                            ListaHistorialDelProductoSeleccionado = Negocio.Consultar.HistorialProducto(idProducto);
                        }
                    }
                }
                catch { }

            }
        }
        private void txtReditoPorcentual_TextChanged(object sender, EventArgs e)
        {
            CalcularCostos();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito;
                if (chcMarca.Checked == true)
                {
                    string marca = txtMarca.Text;
                    string NuevoRedito = txtReditoPorcentual.Text;
                    if (NuevoRedito == "" || NuevoRedito == "   %")
                    {
                        MessageBox.Show("Debe ingresar el rédito porcentual que desea obtener de la marca seleccionada");
                        throw new Exception();
                    }
                    int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                    int idUsuario = idusuarioLogueado;
                    ProgressBar();
                    Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorMarca(marca, NuevoRedito, idUsuario);
                }
                else
                {
                    Entidades.PrecioDeVenta _precio = CargarEntidad();
                    ProgressBar();
                    Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVenta(_precio);
                }
                if (Exito == true)
                {
                    MessageBox.Show("Se registro el nuevo precio de venta exitosamente.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtTotalCompra.Clear();
            txtValorUni.Clear();
            txtPrecioVenta.Clear();
            txtReditoPorcentual.Clear();
            txtPrecioVenta.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            ListaHistorialPrecioDeVenta = Negocio.Consultar.ListaHistorialPrecioDeVenta();
            ListaHistorialDelProductoSeleccionado = Negocio.Consultar.HistorialProducto(ProductoIngresado);
            txtPrecioActualVenta.Clear();
            txtCodigo.Clear();
            txtMarca.Clear();
        }
        private PrecioDeVenta CargarEntidad()
        {
            Entidades.PrecioDeVenta _precio = new Entidades.PrecioDeVenta();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _precio.idProducto = ProductoIngresado;
            _precio.ReditoPorcentual = txtReditoPorcentual.Text;
            if (txtPrecioVenta.Text != "")
            {
                _precio.Precio = Convert.ToDecimal(txtPrecioVenta.Text);
            }
            DateTime fechaActual = DateTime.Now;
            _precio.FechaActual = fechaActual;
            _precio.idUsuario = idusuarioLogueado;
            return _precio;
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
        private void chcPorCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcPorCodigo.Checked == true)
            {
                lblValorOMarcaFijo.Text = "Último valor unitario";
                txtValorUni.Visible = true;
                txtMarca.Visible = false;
                chcMarca.Checked = false;
                txtCodigo.Visible = true;
                lblCodigoFijo.Visible = true;
                txtCodigo.Focus();
                cmbMarca.Visible = false;
                lblMarcaFijo.Visible = false;
                txtTotalCompra.Visible = true;
                txtPrecioVenta.Visible = true;
                txtPrecioActualVenta.Visible = true;
                lblPrecioFijo.Visible = true;
                lblUltimoPrecioFijo.Visible = true;
                lblPrecioActualFijo.Visible = true;
            }
        }
        private void chcMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMarca.Checked == true)
            {
                lblValorOMarcaFijo.Text = "Marca Seleccionada";
                txtValorUni.Visible = false;
                txtMarca.Visible = true;
                chcPorCodigo.Checked = false;
                txtCodigo.Visible = false;
                lblCodigoFijo.Visible = false;
                cmbMarca.Focus();
                cmbMarca.Visible = true;
                lblMarcaFijo.Visible = true;
                CargarComboMarcas();
                txtTotalCompra.Visible = false;
                txtPrecioVenta.Visible = false;
                txtPrecioActualVenta.Visible = false;
                lblPrecioFijo.Visible = false;
                lblUltimoPrecioFijo.Visible = false;
                lblPrecioActualFijo.Visible = false;
            }
        }
        private void CargarComboMarcas()
        {
            List<string> Marcas = new List<string>();
            Marcas = Negocio.Consultar.CargarComboMarcas();
            cmbMarca.Items.Add("Seleccione");
            cmbMarca.Items.Clear();
            foreach (string item in Marcas)
            {
                cmbMarca.Text = "Seleccione";
                cmbMarca.Items.Add(item);
            }
            cmbMarca.Items.Add("Seleccione");
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarca.Text = cmbMarca.Text;
            txtReditoPorcentual.Enabled = true;
            txtReditoPorcentual.Focus();
        }

        private void panel200_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    #endregion
}
