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

            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorOferta.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;

            FuncionListarOfertas();
        }
        private void FuncionListarOfertas()
        {
            dgvOfertas.Rows.Clear();
            List<Entidades.Ofertas> ListaOfertas = Negocio.Consultar.ListaOfertas();
            if (ListaOfertas.Count > 0)
            {
                foreach (var item in ListaOfertas)
                {
                    string fechaDesde = item.FechaDesde.ToShortDateString();
                    if (item.FechaHasta == Convert.ToDateTime("1 / 1 / 1900 00:00:00"))
                    {
                        dgvOfertas.Rows.Add(item.idOferta, item.NombreOferta, fechaDesde, null);
                    }
                    else
                    {
                        string fechaHasta = item.FechaHasta.ToShortDateString();
                        dgvOfertas.Rows.Add(item.idOferta, item.NombreOferta, fechaDesde, fechaHasta);
                    }
                }
            }
            dgvOfertas.ReadOnly = true;
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
            dtFechaHasta.Value = Convert.ToDateTime("1 / 1 / 1900 00:00:00");
            chcFechaHasta.Checked = false;
            dtFechaHasta.Enabled = false;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            txtNombreCombo.Focus();
            listaProductos.Clear();
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
                if (lista.PrecioVenta == 0)
                {
                    const string message = "El producto seleccionado no posee un precio de venta.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                }
                else
                {
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
            }
            catch (Exception ex)
            { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal ValorTotal = 0;
                List<Ofertas> _lista = new List<Ofertas>();
                foreach (DataGridViewRow dr in dgvOfertasCombo.Rows)
                {
                    Entidades.Ofertas _item = new Entidades.Ofertas();
                    _item.idProducto = Convert.ToInt32(dr.Cells["id"].Value);
                    _item.Unidades = Convert.ToInt32(dr.Cells["uni"].Value);
                    _item.ValorProducto = Convert.ToDecimal(dr.Cells["PrecioVenta"].Value);
                    _lista.Add(_item);
                }
                foreach (var item in _lista)
                {
                    decimal calculoValorCantidad = item.ValorProducto * item.Unidades;
                    ValorTotal = ValorTotal + calculoValorCantidad;
                }
                decimal MontoCombo = Convert.ToDecimal(txtPrecioCombo.Text);
                decimal MontoDescuento = ValorTotal - MontoCombo;
                Entidades.Ofertas _oferta = CargarEntidad();
                _oferta.MontoDescuento = MontoDescuento;
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
                    FuncionListarOfertas();
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
            else
            {
                dtFechaHasta.Value = Convert.ToDateTime("1 / 1 / 1900 00:00:00");
                dtFechaHasta.Enabled = false;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtNombreCombo.Focus();
        }

        private void dgvOfertasCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                dgvOfertasCombo.Rows.Remove(dgvOfertasCombo.CurrentRow);
            }
        }

        private void dgvOfertas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvOfertas.Columns[e.ColumnIndex].Name == "Detalle" && e.RowIndex >= 0)
            {
                //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                //DataGridViewButtonCell BotonVer = this.dgvOfertas.Rows[e.RowIndex].Cells["Detalle"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Ver1.ico");
                //e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                //this.dgvOfertas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                //this.dgvOfertas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                //e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && this.dgvOfertas.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                //e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                //DataGridViewButtonCell BotonVer = this.dgvOfertas.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                //Icon icoAtomico = new Icon(Environment.CurrentDirectory + "\\" + @"Eliminar1.ico");
                //e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 20, e.CellBounds.Top + 4);
                //this.dgvOfertas.Rows[e.RowIndex].Height = icoAtomico.Height + 8;
                //this.dgvOfertas.Columns[e.ColumnIndex].Width = icoAtomico.Width + 40;
                //e.Handled = true;
            }
        }
        private void dgvOfertas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOfertas.CurrentCell.ColumnIndex == 4)
            {
                int idOferta = Convert.ToInt32(this.dgvOfertas.CurrentRow.Cells[0].Value.ToString());
                DetallaVentaWF frm2 = new DetallaVentaWF(idOferta);
                frm2.Show();
            }

            if (dgvOfertas.CurrentCell.ColumnIndex == 5)
            {
                const string message = "Desea dar de baja la oferta seleccionada?";
                const string caption = "Atención:";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {
                        int idOferta = Convert.ToInt32(this.dgvOfertas.CurrentRow.Cells[0].Value.ToString());
                        bool Exito = DAO.EditarDao.ActualizarEstadoOferta(idOferta);
                        if (Exito == true)
                        {
                            const string message2 = "Se elimino la oferta exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            FuncionListarOfertas();
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvOfertas.Rows.Clear();
                List<Entidades.Ofertas> ListaOfertas = Negocio.Consultar.ListaOfertasPorDescripcion(txtDescipcionBus.Text);
                if (ListaOfertas.Count > 0)
                {
                    foreach (var item in ListaOfertas)
                    {
                        string fechaDesde = item.FechaDesde.ToShortDateString();
                        if (item.FechaHasta == Convert.ToDateTime("1 / 1 / 1900 00:00:00"))
                        {
                            dgvOfertas.Rows.Add(item.idOferta, item.NombreOferta, fechaDesde, null);
                        }
                        else
                        {
                            string fechaHasta = item.FechaHasta.ToShortDateString();
                            dgvOfertas.Rows.Add(item.idOferta, item.NombreOferta, fechaDesde, fechaHasta);
                        }
                    }
                }
                dgvOfertas.ReadOnly = true;
            }
        }
    }
}

