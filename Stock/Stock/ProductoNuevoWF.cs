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
    public partial class ProductoNuevoWF : Form
    {
        public ProductoNuevoWF()
        {
            InitializeComponent();
        }

        private void ProductoNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                string Perfil = Sesion.UsuarioLogueado.Perfil;
                if (Perfil == "SUPER ADMIN")
                {
                    btnCargaMasiva.Visible = true;
                }
                else
                {
                    btnCargaMasiva.Visible = false;
                }
                FuncionListarProductos();
                CargarCombo();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
        }

        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void FuncionListarProductos()
        {
            FuncionBuscartexto();
            dgvProductos.Rows.Clear();
            List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductos();
            if (ListaProductos.Count > 0)
            {
                foreach (var item in ListaProductos)
                {
                    dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto);
                }
            }
            dgvProductos.ReadOnly = true;
        }
        public void CargarCombo()
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
        }
        public static int idProductoSeleccionado = 0;
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Funcion = 2;
            if (this.dgvProductos.RowCount > 0)
            {
                panel1.Enabled = true;
                btnCrear.Enabled = true;
                idProductoSeleccionado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
                txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                cmbMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                textBox2.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                string TotalCaracteres = Convert.ToString(textBox2.Text.Length);
                lblContador.Visible = true;
                lblTotal.Visible = true;
                lblContador.Text = TotalCaracteres;
            }
            else
            {
                const string message2 = "Debe seleccionar un producto de la grilla.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        public static int Funcion = 0;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Productos _producto = CargarEntidad();
            if (idProductoSeleccionado > 0)
            {
                if (Funcion == 2)
                {
                    ProgressBar();
                    bool Exito = Negocio.Producto.EditarProducto(_producto, idProductoSeleccionado);
                    if (Exito == true)
                    {
                        const string message2 = "La edición del producto se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        FuncionListarProductos();
                    }
                }
            }
            else
            {
                bool Exito = Negocio.Producto.CargarProducto(_producto);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro el producto exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                    FuncionListarProductos();
                }
            }
        }
        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            textBox2.Clear();
            CargarCombo();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            chcProductoEspecial.Checked = false;
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
        private Productos CargarEntidad()
        {
            ///// Harcodear idUsuarios
            Productos _producto = new Productos();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _producto.CodigoProducto = txtCodigoProducto.Text;
            _producto.MarcaProducto = cmbMarca.Text;
            _producto.Descripcion = textBox2.Text;
            DateTime fechaActual = DateTime.Now;
            _producto.FechaDeAlta = fechaActual;
            _producto.idUsuario = idusuarioLogueado;
            if (chcProductoEspecial.Checked == true)
            {
                _producto.CodigoProducto = GenerarProductoEspecial(_producto.Descripcion);
                _producto.MarcaProducto = "No especifica";
                _producto.ProductoEspecial = 1;
            }
            else { _producto.ProductoEspecial = 0; }
            return _producto;
        }

        private string GenerarProductoEspecial(string descripcion)
        {
            String FechaDia = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            String Year = DateTime.Now.Year.ToString();
            string codigoEspecial = descripcion + Year + Month + FechaDia;
            return codigoEspecial;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Funcion = 3;
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
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto);
                    }
                }
                dgvProductos.ReadOnly = true;
            }
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
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto);
                    }
                }
                else
                {
                    const string message2 = "No existe ningun producto con el código ingresado.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
                dgvProductos.ReadOnly = true;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            LimpiarCampos();
            txtCodigoProducto.Focus();
            idProductoSeleccionado = 0;
            Funcion = 1;
            btnCrear.Enabled = true;
            lblContador.Visible = true;
            lblTotal.Visible = true;
            lblContador.Text = "0";
        }
        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            CargaMasivaProductosWF _carga = new CargaMasivaProductosWF();
            _carga.Show();
            Hide();
        }

        private void lblContador_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lblContador.Text = Convert.ToString(textBox2.Text.Length);
        }

        private void chcProductoEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProductoEspecial.Checked == true)
            {
                cmbMarca.Enabled = false;
                txtCodigoProducto.Enabled = false;
                txtDescripcion.Focus();
            }
            else
            {
                cmbMarca.Enabled = true;
                txtCodigoProducto.Enabled = true;
                txtCodigoProducto.Focus();
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                AltaMarcaNuevoWF _alta = new AltaMarcaNuevoWF();
                _alta.Show();
            }
            catch (Exception ex)
            { }
        }      
        private void ActualizarCombo(object sender, EventArgs e)
        {
            CargarCombo();
        }
    }
}
