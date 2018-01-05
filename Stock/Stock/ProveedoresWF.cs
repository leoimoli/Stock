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
using System.IO;

namespace Stock
{
    public partial class ProveedoresWF : Master
    {
        public ProveedoresWF()
        {
            InitializeComponent();
        }


        #region Botones
        public static int idProveedorGrilla;
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            idProveedorGrilla = 0;

            txtNombreEmpresa.Enabled = true;
            txtNombreEmpresa.Focus();
            LimpiarCampos();
            HabilitarCampos();
        }
        #endregion
        #region Metodos Generales
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
            txtImagen.Clear();
            List<string> Marcas = Negocio.Consultar.CargarComboMarcas();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            pictureBox1.Image = null;
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
        private void HabilitarCampos()
        {
            panel_Proveedores.Enabled = true;
            txtNombreEmpresa.Focus();
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnCargarImagen.Visible = true;
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
            _proveedor.Telefono = txtTelefono.Text;
            DateTime fechaActual = DateTime.Now;
            _proveedor.FechaDeAlta = fechaActual;
            _proveedor.idUsuario = idusuarioLogueado;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _proveedor.Foto = Imagen;
            return _proveedor;
        }
        private Proveedores CargarEntidadEdicion()
        {
            Proveedores _proveedor = new Proveedores();
            _proveedor.NombreEmpresa = txtNombreEmpresa.Text;
            _proveedor.Contacto = txtPersonaContacto.Text;
            _proveedor.Email = txtEmail.Text;
            _proveedor.SitioWeb = txtSitioWeb.Text;
            _proveedor.Calle = txtCalle.Text;
            _proveedor.Altura = txtAltura.Text;
            _proveedor.Telefono = txtTelefono.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _proveedor.Foto = Imagen;
            return _proveedor;
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int idProductoGrillaSeleccionado = idProveedorGrilla;

                if (idProductoGrillaSeleccionado > 0)
                {

                    panel_Proveedores.Enabled = false;
                    Entidades.Proveedores _proveedor = CargarEntidadEdicion();
                    ProgressBar();
                    bool Exito = Negocio.Proveedores.EditarProducto(_proveedor, idProductoGrillaSeleccionado);
                    if (Exito == true)
                    {
                        MessageBox.Show("LA EDICIÓN DEL PRODUCTO SE REALIZO EXITOSAMENTE.");
                        LimpiarCampos();
                        //List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                        //ListaProductos = ListaReducidos;
                    }
                }
                else
                {
                    panel_Proveedores.Enabled = false;
                    Entidades.Proveedores _proveedor = CargarEntidad();
                    ProgressBar();
                    bool Exito = Negocio.Proveedores.CargarProducto(_proveedor);
                    if (Exito == true)
                    {
                        MessageBox.Show("SE REGISTRO EL PRODUCTO EXITOSAMENTE.");
                        LimpiarCampos();
                        //List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                        //ListaProductos = ListaReducidos;
                    }
                }
            }
            catch (Exception ex)
            { }
        }
    }
}
