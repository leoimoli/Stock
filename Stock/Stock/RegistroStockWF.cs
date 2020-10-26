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
    public partial class RegistroStockWF : Form
    {


        public RegistroStockWF()
        {
            InitializeComponent();
        }
        public static int idProdcutoStatic;
        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string Descripcion = txtDescipcionBus.Text;
                List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListaStockPorDescripcion(Descripcion);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        idProdcutoStatic = item.idProducto;
                        panel3.Enabled = true;
                        txtCodigoProducto.Text = item.CodigoProducto;
                        txtDescripcion.Text = item.NombreProducto;
                        txtMarca.Text = item.Marca;
                    }
                    ListaProveedores();
                    txtProveedor.Focus();
                    txtCodigoBus.Clear();
                    txtDescipcionBus.Clear();
                    txtProveedor.Enabled = true;
                    txtRemito.Enabled = true;
                    dtFechaCompra.Enabled = true;

                }
                else
                {
                    const string message = "El producto no existe. Desea agregar un nuevo producto ?";
                    const string caption = "Producto Inexistente";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    {
                        if (result == DialogResult.Yes)
                        {
                        }
                    }
                    dgvProductos.ReadOnly = true;
                }
            }
        }
        private void ListaProveedores()
        {
            txtProveedor.AutoCompleteCustomSource = Clases_Maestras.ListarProveedores.Autocomplete();
            txtProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void RegistroStockWF_Load(object sender, EventArgs e)
        {
            txtDescipcionBus.Focus();
            FuncionBuscartexto();
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
                string Codigo = txtCodigoBus.Text;
                List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListaStockPorCodigoProducto(Codigo);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        idProdcutoStatic = item.idProducto;
                        panel3.Enabled = true;
                        txtCodigoProducto.Text = item.CodigoProducto;
                        txtDescripcion.Text = item.NombreProducto;
                        txtMarca.Text = item.Marca;
                    }
                    ListaProveedores();
                    txtProveedor.Focus();
                    txtCodigoBus.Clear();
                    txtDescipcionBus.Clear();
                    txtProveedor.Enabled = true;
                    txtRemito.Enabled = true;
                    dtFechaCompra.Enabled = true;
                }
                dgvProductos.ReadOnly = true;
            }
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            Entidades.RegistroStock Entidad = CargarEntidad();
            dgvProductos.Rows.Add(Entidad.idProducto, Entidad.CodigoProducto, Entidad.Descripcion, Entidad.Cantidad, Entidad.ValorUnitario);
            txtProveedor.Enabled = false;
            dtFechaCompra.Enabled = false;
            txtRemito.Enabled = false;
            txtCantidad.Clear();
            txtValorUni.Clear();
            txtCodigoProducto.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtDescipcionBus.Focus();
        }
        private RegistroStock CargarEntidad()
        {
            RegistroStock _producto = new RegistroStock();
            _producto.idProducto = idProdcutoStatic;
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _producto.idUsuario = idusuarioLogueado;
            _producto.CodigoProducto = txtCodigoProducto.Text;
            _producto.Marca = txtMarca.Text;
            _producto.Proveedor = txtProveedor.Text;
            _producto.Remito = txtRemito.Text;
            _producto.Descripcion = txtDescripcion.Text;
            _producto.FechaFactura = Convert.ToDateTime(dtFechaCompra.Text);
            string Valor = txtValorUni.Text;
            var temp = Valor.Replace(".", "<TEMP>");
            var temp2 = temp.Replace(",", ",");
            var replaced = temp2.Replace("<TEMP>", ",");
            _producto.ValorUnitario = Convert.ToDecimal(replaced);
            _producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            return _producto;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public static string idProductoSeleccionado;
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            idProductoSeleccionado = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<RegistroStock> ListaStock = new List<RegistroStock>();
                ListaStock = CargarEntidadFinal();
                bool Exito = Negocio.Stock.CargarlistaStock(ListaStock);
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
            {
                throw new Exception();
            }
        }
        private void LimpiarCampos()
        {
            txtDescipcionBus.Clear();
            txtCodigoBus.Clear();
            txtCodigoProducto.Clear();
            txtMarca.Clear();
            txtDescripcion.Clear();
            txtProveedor.Clear();
            dtFechaCompra.Value = DateTime.Now;
            txtRemito.Clear();
            txtCantidad.Clear();
            txtValorUni.Clear();
            dgvProductos.Rows.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private List<RegistroStock> CargarEntidadFinal()
        {
            List<RegistroStock> ListaStock = new List<RegistroStock>();
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                RegistroStock Lista = new RegistroStock();
                Lista.idProducto = Convert.ToInt32(row.Cells[0].Value.ToString());
                int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                Lista.idUsuario = idusuarioLogueado;
                Lista.CodigoProducto = row.Cells[1].Value.ToString();
                Lista.Marca = txtMarca.Text;
                Lista.Proveedor = txtProveedor.Text;
                Lista.Remito = txtRemito.Text;
                Lista.Descripcion = row.Cells[2].Value.ToString();
                Lista.FechaFactura = Convert.ToDateTime(dtFechaCompra.Text);
                Lista.ValorUnitario = Convert.ToDecimal(row.Cells[4].Value.ToString());
                Lista.Cantidad = Convert.ToInt32(row.Cells[3].Value.ToString());
                ListaStock.Add(Lista);
            }
            return ListaStock;
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
