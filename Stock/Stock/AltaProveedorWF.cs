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
    public partial class AltaProveedorWF : Form
    {
        public AltaProveedorWF()
        {
            InitializeComponent();
        }
        private void AltaProveedorWF_Load(object sender, EventArgs e)
        {
            txtNombreEmpresa.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidades.Proveedores _proveedor = CargarEntidad();
            ProgressBar();
            bool Exito = Negocio.Proveedores.CargarProducto(_proveedor);
            if (Exito == true)
            {
                const string message2 = "Se registro el proveedor exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                LimpiarCampos();
                Close();
            }
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
        private Proveedores CargarEntidad()
        {
            Proveedores _proveedor = new Proveedores();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _proveedor.NombreEmpresa = txtNombreEmpresa.Text;
            _proveedor.Contacto = txtPersonaContacto.Text;
            _proveedor.Email = txtEmail.Text;
            _proveedor.SitioWeb = txtSitioWeb.Text;
            _proveedor.Calle = txtCalle.Text;
            _proveedor.Altura = txtAltura.Text;
            string telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _proveedor.Telefono = telefono;
            DateTime fechaActual = DateTime.Now;
            _proveedor.FechaDeAlta = fechaActual;
            _proveedor.idUsuario = idusuarioLogueado;
            return _proveedor;
        }
        private void LimpiarCampos()
        {
            txtNombreEmpresa.Clear();
            txtPersonaContacto.Clear();
            txtEmail.Clear();
            txtSitioWeb.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            txtCodArea.Clear();
            txtTelefono.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
