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
    public partial class OfertasWF : Form
    {
        public OfertasWF()
        {
            InitializeComponent();
        }
        private void OfertasWF_Load(object sender, EventArgs e)
        {
            txtDescipcionBus.Focus();
            listaProductos = new List<Entidades.ListaProductoVenta>();
            txtCodigoProducto.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtCodigoProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCodigoProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string descripcion = txtCodigoProducto.Text;
                    var CodigoProducto = Negocio.Consultar.BuscarPorDescripcion(descripcion);
                    if (CodigoProducto == "0")
                    {
                        BuscarProductoPorCodigo();
                    }
                    else
                    {
                        txtCodigoProducto.Text = Convert.ToString(CodigoProducto);
                        BuscarProductoPorCodigo();
                    }
                    LimpiarCampos();
                }
                catch (Exception ex)
                { }
            }
        }

        private void LimpiarCamposExito()
        {
            txtNombreCombo.Clear();
            txtCodigoProducto.Clear();
            txtCantidad.Text = "1";
            txtCodigoProducto.Focus();
            dtFechaDesde.Value = DateTime.Now;
            dtFechaHasta.Value = DateTime.Now;
            txtPrecioCombo.Clear();
            dgvOfertasCombo.Rows.Clear();
            chcFechaHasta.Checked = false;
            dtFechaHasta.Enabled = false;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }

        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            txtCantidad.Text = "1";
            txtCodigoProducto.Focus();
        }
        public static List<Entidades.ListaProductoVenta> listaProductos;
        private void BuscarProductoPorCodigo()
        {
            try
            {
                string codigoProducto;
                codigoProducto = txtCodigoProducto.Text;
                var CodigoProducto = Negocio.Consultar.BuscarPorDescripcion(codigoProducto);
                if (codigoProducto == "0")
                {
                    BuscarProductoPorCodigo();
                }
                List<Entidades.ListaProductoVenta> _lista = new List<Entidades.ListaProductoVenta>();
                //bool EsEspecial = Negocio.Consultar.ValidarProductoEspecial(codigoProducto);
                _lista = Negocio.Consultar.BuscarProductoParaVenta(codigoProducto);

                var lista = _lista.First();
                int unidades = Convert.ToInt32(txtCantidad.Text);
                if (!listaProductos.Any(x => x.CodigoProducto == codigoProducto))
                {
                    listaProductos.Add(lista);
                    dgvOfertasCombo.Rows.Add(lista.idProducto, lista.CodigoProducto, lista.NombreProducto, lista.PrecioVenta, unidades);
                }
                else
                {
                    const string message = "Ya se encuentra cargado en la lista el producto de seleccionado.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                }
                txtCodigoProducto.Clear();
            }
            catch (Exception ex)
            { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Ofertas> _lista = new List<Ofertas>();
                foreach (DataGridViewRow dr in dgvOfertasCombo.Rows)
                {
                    Entidades.Ofertas _item = new Entidades.Ofertas();
                    _item.idProducto = Convert.ToInt32(dr.Cells["id"].Value);
                    _item.Unidades = Convert.ToInt32(dr.Cells["uni"].Value);
                    _lista.Add(_item);
                }
                Entidades.Ofertas _oferta = CargarEntidad();
                int Exito = Negocio.OfertasNeg.RegistrarOferta(_oferta, _lista);
                if (Exito == 1)
                {
                    ProgressBar();
                    const string message2 = "Se registro la oferta exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCamposExito();
                }
            }
            catch (Exception ex)
            { }
        }
        private Ofertas CargarEntidad()
        {
            Entidades.Ofertas _oferta = new Entidades.Ofertas();
            DateTime fechaActual = DateTime.Now;
            _oferta.FechaDelRegistro = fechaActual;
            _oferta.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
            _oferta.NombreOferta = txtNombreCombo.Text;
            _oferta.FechaDesde = dtFechaDesde.Value;
            if (chcFechaHasta.Enabled == true)
            { _oferta.FechaHasta = dtFechaHasta.Value; }

            else { _oferta.FechaHasta = Convert.ToDateTime(" "); }
            _oferta.FechaHasta = dtFechaHasta.Value;
            _oferta.PrecioCombo = Convert.ToDecimal(txtPrecioCombo.Text);
            _oferta.Estado = 1;
            _oferta.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
            return _oferta;
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
        private void chcFechaHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chcFechaHasta.Checked == true)
            {
                dtFechaHasta.Enabled = true;
                dtFechaHasta.Value = DateTime.Now;
            }
            else { dtFechaHasta.Enabled = false; }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
        }
    }
}

