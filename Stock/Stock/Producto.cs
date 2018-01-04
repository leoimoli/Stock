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
    public partial class Producto : Master
    {
        public Producto()
        {
            InitializeComponent();
        }
        private void Producto_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> Marcas = Negocio.Consultar.CargarComboMarcas();
                cmbMarca.Items.Add("Seleccione");
                foreach (string item in Marcas)
                {
                    cmbMarca.Text = "Seleccione";
                    cmbMarca.Items.Add(item);
                }
                //List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                //ListaUsuarios = ListaReducidos;
            }
            catch (Exception ex)
            { }
        }
        #region Metodos Generales
        private void HabilitarCampos()
        {
            btnAgregarMarca.Visible = true;
            panel_Producto.Enabled = true;
            txtCodigoProducto.Focus();
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnCargarImagen.Visible = true;
        }
        private Productos CargarEntidad()
        {
            Productos _producto = new Productos();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _producto.CodigoProducto = txtCodigoProducto.Text;
            _producto.NombreProducto = txtNombreProducto.Text;
            _producto.MarcaProducto = cmbMarca.Text;
            _producto.Descripcion = txtDescripcion.Text;
            DateTime fechaActual = DateTime.Now;
            _producto.FechaDeAlta = fechaActual;
            _producto.idUsuario = idusuarioLogueado;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _producto.Foto = Imagen;
            return _producto;
        }
        private Productos CargarEntidadEdicion()
        {
            Productos _producto = new Productos();
            _producto.CodigoProducto = txtCodigoProducto.Text;
            _producto.NombreProducto = txtNombreProducto.Text;
            _producto.MarcaProducto = cmbMarca.Text;
            _producto.Descripcion = txtDescripcion.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _producto.Foto = Imagen;
            return _producto;
        }
        private void LimpiarCampos()
        {
            throw new NotImplementedException();
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
        #endregion
        #region Botones
        private void btnProducto_Click(object sender, EventArgs e)
        {
            //id = 0;

            //LimpiarCampos();
            //ValidacionesUsuarioLogueado();
            HabilitarCampos();
        }
        public static int idProductoGrilla;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                int idProductoGrillaSeleccionado = idProductoGrilla;

                if (idProductoGrillaSeleccionado > 0)
                {
                    panel_Producto.Enabled = false;
                    Entidades.Productos _producto = CargarEntidadEdicion();
                    ProgressBar();
                    bool Exito = Negocio.Producto.EditarProducto(_producto, idProductoGrillaSeleccionado);
                    if (Exito == true)
                    {
                        MessageBox.Show("LA EDICIÓN DEL PRODUCTO SE REALIZO EXITOSAMENTE.");
                        LimpiarCampos();
                        //List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        //ListaUsuarios = ListaReducidos;
                    }
                }
                else
                {
                    panel_Producto.Enabled = false;
                    Entidades.Productos _producto = CargarEntidad();
                    ProgressBar();
                    bool Exito = Negocio.Producto.CargarProducto(_producto);
                    if (Exito == true)
                    {
                        MessageBox.Show("SE REGISTRO EL PRODUCTO EXITOSAMENTE.");
                        LimpiarCampos();
                        //List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        //ListaUsuarios = ListaReducidos;
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaWF _marca = new MarcaWF();
            _marca.Show();
        }

        #endregion
    }
}
