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
                FuncionListarProductos();              
                CargarCombo();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionListarProductos()
        {
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
            idProductoSeleccionado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
            txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            cmbMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
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
            return _producto;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Funcion = 3;
        }
    }
}
