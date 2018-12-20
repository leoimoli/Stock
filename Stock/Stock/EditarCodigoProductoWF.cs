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
    public partial class EditarCodigoProductoWF : Form
    {
        public EditarCodigoProductoWF()
        {
            InitializeComponent();
        }
        private void EditarCodigoProductoWF_Load(object sender, EventArgs e)
        {
            txtNombreProductoBuscar.Focus();
            txtNombreProductoBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleClass.Autocomplete();
            txtNombreProductoBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombreProductoBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public static int idProductoSeleccionado;
        private void txtNombreProductoBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string descripcion = txtNombreProductoBuscar.Text;
                    var CodigoProducto = Negocio.Consultar.BuscarPorDescripcion(descripcion);
                    string codigo = Convert.ToString(CodigoProducto);
                    int idProducto = Negocio.Consultar.BuscarProductoPorCodigo(codigo);
                    if (idProducto > 0)
                    {
                        List<ListaStock> Lista = new List<ListaStock>();
                        Lista = new List<ListaStock>();
                        Lista = Negocio.Consultar.ListaDeStockPoridProdcuto(idProducto);
                        if (Lista.Count > 0)
                        {
                            idProductoSeleccionado = 0;
                            var _lista = Lista.First();
                            idProductoSeleccionado = _lista.idProducto;
                            txtMarca.Text = _lista.Marca;
                            txtCodigoProductoActual.Text = _lista.CodigoProducto;
                            txtNuevoCodigoProducto.Enabled = true;
                            txtNuevoCodigoProducto.Focus();
                            btnGuardar.Visible = true;
                            btnCancelar.Visible = true;
                            btnVolver.Visible = true;
                        }
                    }
                }
                catch (Exception ex)
                { }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoProductoActual.Text != txtNuevoCodigoProducto.Text)
                {
                    string nuevoCodigo = txtNuevoCodigoProducto.Text;
                    ProgressBar();
                    bool Exito = Negocio.Producto.EditarCodigo(nuevoCodigo, idProductoSeleccionado);
                    if (Exito == true)
                    {
                        const string message2 = "La edición del código del producto se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception)
            { }
        }
        private void LimpiarCampos()
        {
            txtNombreProductoBuscar.Clear();
            txtMarca.Clear();
            txtCodigoProductoActual.Clear();
            txtNuevoCodigoProducto.Clear();
            txtNombreProductoBuscar.Focus();
            txtMarca.Enabled = false;
            txtCodigoProductoActual.Enabled = false;
            txtNuevoCodigoProducto.Enabled = false;
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
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Producto _producto = new Producto();
            _producto.Show();
            Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProductoBuscar.Clear();
            txtMarca.Clear();
            txtCodigoProductoActual.Clear();
            txtNuevoCodigoProducto.Clear();
            txtNombreProductoBuscar.Focus();
            txtMarca.Enabled = false;
            txtCodigoProductoActual.Enabled = false;
            txtNuevoCodigoProducto.Enabled = false;
            progressBar1.Visible = false;
        }
    }
}
