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
    public partial class AltaProductoWF : Form
    {
        private string codigo;

        public AltaProductoWF(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
        }
        private void AltaProductoWF_Load(object sender, EventArgs e)
        {
            CargarCombo();
            txtCodigoProducto.Text = codigo;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Productos _producto = CargarEntidad();
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
                Close();
            }
        }
        private Productos CargarEntidad()
        {
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
        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            textBox2.Clear();
            CargarCombo();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
    }
}
