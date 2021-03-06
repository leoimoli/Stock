﻿using Stock.Entidades;
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
                txtNombreProductoBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleClass.Autocomplete();
                txtNombreProductoBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtNombreProductoBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ListaHistorialPrecioDeVenta = Negocio.Consultar.ListaHistorialPrecioDeVenta();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
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
            if (txtPrecioActualVenta.Text != "" & txtReditoPorcentual.Text != "   %")
            {
                ///// Realizo el calculo teniendo en cuenta el valor actual de venta.
                decimal totalCompraIngresada = Convert.ToDecimal(txtPrecioActualVenta.Text);
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
            else
                if (txtTotalCompra.Text != "" & txtReditoPorcentual.Text != "   %")
            {
                decimal totalCompraIngresada = Convert.ToDecimal(txtValorUnit.Text);
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
                    if (txtCodigo.Text == "0")
                    {
                        const string message = "El código del producto es invalido.";
                        const string caption = "Atención";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Warning);
                        throw new Exception();
                    }
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
                            const string message = "El producto ingresado no posee un precio de venta previamente cargado.";
                            const string caption = "Atención";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                       MessageBoxIcon.Exclamation);
                            throw new Exception();
                        }
                        else
                        {
                            var lista = Lista.First();
                            txtValorUnit.Text = Convert.ToString(lista.ValorUnitario);
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
                lblEnProgreso.Visible = true;
                bool Exito;
                if (chcMarca.Checked == true)
                {
                    string marca = txtMarca.Text;
                    string NuevoRedito = txtReditoPorcentual.Text;
                    if (NuevoRedito == "" || NuevoRedito == "   %")
                    {
                        const string message3 = "Debe ingresar el rédito porcentual que desea obtener de la marca seleccionada.";
                        const string caption3 = "Atención";
                        var result3 = MessageBox.Show(message3, caption3,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                    const string message = "Desea modificar el precio de venta de los productos correspondientes a la marca seleccionada?";
                    const string caption = "Modificar precio por marca";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                            int idUsuario = idusuarioLogueado;
                            InhabilitarPaneles();
                            ProgressBar();
                            Exito = true;
                            //Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorMarca(marca, NuevoRedito, idUsuario);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por marca";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                            else
                            {
                                const string message3 = "Los productos asociados a la marca seleccionada, no tiene un precio de venta predefinido que se pueda modificar.";
                                const string caption3 = "Modificar precio por marca";
                                var result3 = MessageBox.Show(message3, caption3,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                            }
                        }

                    }
                }
                if (chcProveedor.Checked == true)
                {
                    string proveedor = txtMarca.Text;
                    string NuevoRedito = txtReditoPorcentual.Text;
                    if (NuevoRedito == "" || NuevoRedito == "   %")
                    {
                        const string message3 = "Debe ingresar el rédito porcentual que desea obtener de la marca seleccionada.";
                        const string caption3 = "Atención";
                        var result3 = MessageBox.Show(message3, caption3,
                                                     MessageBoxButtons.OK,
                                                   MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                    const string message = "Desea modificar el precio de venta de los productos correspondientes al proveedor seleccionada?";
                    const string caption = "Modificar precio por proveedor";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                            int idUsuario = idusuarioLogueado;
                            ProgressBar();
                            Exito = true;
                            //Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorProveedor(proveedor, NuevoRedito, idUsuario);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por proveedor";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                            else
                            {
                                const string message3 = "Los productos asociados al proveedor seleccionada, no tiene un precio de venta predefinido que se pueda modificar.";
                                const string caption3 = "Modificar precio por marca";
                                var result3 = MessageBox.Show(message3, caption3,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Exclamation);
                            }
                        }

                    }
                }
                else
                {
                    Entidades.PrecioDeVenta _precio = CargarEntidad();
                    ProgressBar();
                    Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVenta(_precio);
                    if (Exito == true)
                    {
                        const string message = "Se registro el nuevo precio de venta exitosamente.";
                        const string caption = "Modificar precio por marca";
                        var result = MessageBox.Show(message, caption,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
                lblEnProgreso.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
            LimpiarCampos();
        }

        private void InhabilitarPaneles()
        {
            panel200.Enabled = false;
            panel6.Enabled = false;
            panel_Producto.Enabled = false;
        }

        private void LimpiarCampos()
        {
            txtTotalCompra.Clear();
            txtValorUnit.Clear();
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
            panel200.Enabled = true;
            panel6.Enabled = true;
            panel_Producto.Enabled = true;
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
                cmbProveedores.Visible = false;
                lblValorOMarcaFijo.Text = "Último valor unitario";
                txtValorUnit.Visible = true;
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
                chcProducto.Checked = false;
                txtNombreProductoBuscar.Visible = false;
                lblNombreProducto.Visible = false;
                chcProveedor.Checked = false;
            }
        }
        private void chcMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMarca.Checked == true)
            {
                cmbProveedores.Visible = false;
                lblValorOMarcaFijo.Text = "Marca Seleccionada";
                txtValorUnit.Visible = false;
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
                chcProducto.Checked = false;
                txtNombreProductoBuscar.Visible = false;
                lblNombreProducto.Visible = false;
                chcProveedor.Checked = false;
            }
        }
        private void chcProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProducto.Checked == true)
            {
                cmbProveedores.Visible = false;
                lblValorOMarcaFijo.Text = "Último valor unitario";
                txtValorUnit.Visible = true;
                txtMarca.Visible = false;
                chcMarca.Checked = false;
                txtCodigo.Visible = false;
                chcMarca.Checked = false;
                txtCodigo.Visible = false;
                lblCodigoFijo.Visible = false;
                cmbMarca.Visible = false;
                lblMarcaFijo.Visible = false;
                txtTotalCompra.Visible = true;
                txtPrecioVenta.Visible = true;
                txtPrecioActualVenta.Visible = true;
                lblPrecioFijo.Visible = true;
                lblUltimoPrecioFijo.Visible = true;
                lblPrecioActualFijo.Visible = true;
                txtNombreProductoBuscar.Visible = true;
                txtNombreProductoBuscar.Focus();
                lblNombreProducto.Visible = true;
                lblNombreProducto.Text = "Nombre Producto";
                chcPorCodigo.Checked = false;
                chcProveedor.Checked = false;
            }
        }
        private void chcProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProveedor.Checked == true)
            {
                txtMarca.Visible = true;
                chcMarca.Checked = false;
                cmbProveedores.Visible = true;
                lblValorOMarcaFijo.Text = "Proveedor Seleccionado";
                txtValorUnit.Visible = false;
                chcPorCodigo.Checked = false;
                txtCodigo.Visible = false;
                lblCodigoFijo.Visible = false;
                cmbProveedores.Focus();
                cmbMarca.Visible = false;
                lblMarcaFijo.Visible = false;
                txtTotalCompra.Visible = false;
                txtPrecioVenta.Visible = false;
                txtPrecioActualVenta.Visible = false;
                lblPrecioFijo.Visible = false;
                lblUltimoPrecioFijo.Visible = false;
                lblPrecioActualFijo.Visible = false;
                chcProducto.Checked = false;
                txtNombreProductoBuscar.Visible = false;
                lblNombreProducto.Visible = false;
                chcProveedor.Checked = true;
                CargarComboProveedores();
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
        private void CargarComboProveedores()
        {
            List<string> Proveedor = new List<string>();
            Proveedor = Negocio.Consultar.CargarComboProveedor();
            cmbProveedores.Items.Add("Seleccione");
            cmbProveedores.Items.Clear();
            foreach (string item in Proveedor)
            {
                cmbProveedores.Text = "Seleccione";
                cmbProveedores.Items.Add(item);
            }
            cmbProveedores.Items.Add("Seleccione");
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarca.Text = cmbMarca.Text;
            txtReditoPorcentual.Enabled = true;
            txtReditoPorcentual.Focus();
        }
        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarca.Text = cmbProveedores.Text;
            txtReditoPorcentual.Enabled = true;
            txtReditoPorcentual.Focus();
        }
        private void panel200_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtNombreProductoBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtReditoPorcentual.Enabled = true;
                    txtPrecioVenta.Enabled = true;

                    string DescripcionProducto = txtNombreProductoBuscar.Text;
                    var codigo = Negocio.Consultar.BuscarPorDescripcion(DescripcionProducto);
                    string codigoIngresado = Convert.ToString(codigo);
                    int idProducto = Negocio.Consultar.BuscarProductoPorCodigo(codigoIngresado);
                    if (idProducto > 0)
                    {
                        ProductoIngresado = idProducto;
                        List<HistorialProductoPrecioDeVenta> Lista = new List<HistorialProductoPrecioDeVenta>();
                        Lista = Negocio.Consultar.HistorialPrecioDeVenta(idProducto);
                        if (Lista.Count == 0)
                        {
                            const string message = "El producto ingresado no posee un precio de venta previamente cargado.";
                            const string caption = "Atención";
                            var result = MessageBox.Show(message, caption,
                                                         MessageBoxButtons.OK,
                                                       MessageBoxIcon.Exclamation);
                            LimpiarCampos();
                            throw new Exception();

                        }
                        else
                        {
                            var lista = Lista.First();
                            txtValorUnit.Text = Convert.ToString(lista.ValorUnitario);
                            txtTotalCompra.Text = Convert.ToString(lista.PrecioTotalDeCompra);
                            txtPrecioActualVenta.Text = Convert.ToString(lista.PrecioDeVenta);
                            ListaHistorialDelProductoSeleccionado = Negocio.Consultar.HistorialProducto(idProducto);
                        }
                    }
                }
                catch { }

            }
        }
    }
    #endregion
}
