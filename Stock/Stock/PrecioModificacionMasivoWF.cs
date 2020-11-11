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
    public partial class PrecioModificacionMasivoWF : Form
    {
        public PrecioModificacionMasivoWF()
        {
            InitializeComponent();
        }
        public static string Funcion = "Funcion";
        private void chcMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMarca.Checked == true)
            {
                txtBuscar.Clear();
                Funcion = "Marca";
                chcProveedor.Checked = false;
                txtBuscar.Visible = true;
                txtBuscar.Focus();
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteMarcas.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void chcProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProveedor.Checked == true)
            {
                txtBuscar.Clear();
                Funcion = "Proveedor";
                chcMarca.Checked = false;
                txtBuscar.Visible = true;
                txtBuscar.Focus();
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteProveedores.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel3.Enabled = true;
                if (Funcion == "Marca")
                {
                    List<string> ListaIdProducto = new List<string>();
                    dgvProductos.Rows.Clear();
                    string Marca = txtBuscar.Text;
                    List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductosPorMarca(Marca);
                    if (ListaProductos.Count > 0)
                    {
                        foreach (var item in ListaProductos)
                        {
                            string Producto = Convert.ToString(item.idProducto);
                            if (item.PrecioDeVenta > 0 & !ListaIdProducto.Any(x => x.ToString() == Producto))
                            {
                                dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                                ListaIdProducto.Add(Producto);
                            }
                            else { continue; }
                        }
                        lblGrilla.Visible = true;
                        lblTotal.Visible = true;
                        lblTotalEdit.Visible = true;
                        lblTotalEdit.Text = Convert.ToString(ListaIdProducto.Count);
                    }
                    dgvProductos.ReadOnly = true;
                }
                if (Funcion == "Proveedor")
                {
                    List<string> ListaIdProducto = new List<string>();
                    dgvProductos.Rows.Clear();
                    string Marca = txtBuscar.Text;
                    List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductosPorProveedor(Marca);
                    if (ListaProductos.Count > 0)
                    {
                        foreach (var item in ListaProductos)
                        {
                            string Producto = Convert.ToString(item.idProducto);
                            if (item.PrecioDeVenta > 0 & !ListaIdProducto.Any(x => x.ToString() == Producto))
                            {
                                dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                                ListaIdProducto.Add(Producto);
                            }
                            else { continue; }
                        }
                        lblGrilla.Visible = true;
                        lblTotal.Visible = true;
                        lblTotalEdit.Visible = true;
                        lblTotalEdit.Text = Convert.ToString(ListaIdProducto.Count);
                    }
                    dgvProductos.ReadOnly = true;
                }
            }
        }
        private void chcAumentar_CheckedChanged(object sender, EventArgs e)
        {
            if (chcAumentar.Checked == true)
            {
                chcBajar.Checked = false;
                txtReditoPorcentual.Enabled = true;
                txtReditoPorcentual.Focus();
            }
        }
        private void chcBajar_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBajar.Checked == true)
            {
                chcAumentar.Checked = false;
                txtReditoPorcentual.Enabled = true;
                txtReditoPorcentual.Focus();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito;
                if (chcMarca.Checked != true & chcProveedor.Checked != true & chcAumentar.Checked != true & chcBajar.Checked != true)
                {

                }
                else
                {
                    int Total = Convert.ToInt32(lblTotalEdit.Text);
                    string fun = Funcion;
                    string mensaje = "Usted Desea modificar el precio de venta de los '" + Total + "'  productos correspondientes '" + fun + "'  seleccionada?";
                    string message = mensaje;
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ///// 1 Aumento
                        ///// 2 Baja
                        int Estado = 0;
                        int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                        if (Funcion == "Marca")
                        {
                            if (chcAumentar.Checked == true)
                            {
                                Estado = 1;
                            }
                            if (chcBajar.Checked == true)
                            {
                                Estado = 2;
                            }
                            ProgressBar();
                            string marca = txtBuscar.Text;
                            string redito = txtReditoPorcentual.Text;
                            Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorMarca(marca, redito, idusuarioLogueado, Estado);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por marca";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                        }
                        if (Funcion == "Proveedor")
                        {
                            if (chcAumentar.Checked == true)
                            {
                                Estado = 1;
                            }
                            if (chcBajar.Checked == true)
                            {
                                Estado = 2;
                            }
                            ProgressBar();
                            string marca = txtBuscar.Text;
                            string redito = txtReditoPorcentual.Text;
                            Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorProveedor(marca, redito, idusuarioLogueado, Estado);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por marca";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            txtReditoPorcentual.Clear();
            txtReditoPorcentual.Enabled = false;
            chcAumentar.Checked = false;
            chcBajar.Checked = false;
            chcProveedor.Checked = false;
            chcMarca.Checked = true;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            dgvProductos.Rows.Clear();
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
    }
}
