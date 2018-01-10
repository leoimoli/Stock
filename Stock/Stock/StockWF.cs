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
    public partial class StockWF : Master
    {
        public StockWF()
        {
            InitializeComponent();
        }

        private void StockWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboProveedor();
            }
            catch { }
        }

        #region Metodos Generales
        public static int idStockGrilla;
        public void CargarComboProveedor()
        {
            List<string> Marcas = new List<string>();
            Marcas = Negocio.Consultar.CargarComboProveedor();
            cmbProveedor.Items.Add("Seleccione");
            cmbProveedor.Items.Clear();
            foreach (string item in Marcas)
            {
                cmbProveedor.Text = "Seleccione";
                cmbProveedor.Items.Add(item);
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
        //private Stock CargarEntidad()
        //{
        //    Productos _producto = new Productos();
        //    int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
        //    _producto.CodigoProducto = txtCodigoProducto.Text;
        //    _producto.NombreProducto = txtNombreProducto.Text;
        //    _producto.MarcaProducto = cmbMarca.Text;
        //    _producto.Descripcion = txtDescripcion.Text;
        //    DateTime fechaActual = DateTime.Now;
        //    _producto.FechaDeAlta = fechaActual;
        //    _producto.idUsuario = idusuarioLogueado;
        //    byte[] Imagen = null;
        //    MemoryStream ms = new MemoryStream();
        //    if (pictureBox1.Image != null)
        //    {
        //        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
        //        Imagen = ms.ToArray();
        //    }
        //    _producto.Foto = Imagen;
        //    return _producto;
        //}
        #endregion
        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                int idStockGrillaSeleccionado = idStockGrilla;

                if (idStockGrillaSeleccionado > 0)
                {
                    //Entidades.Productos _producto = CargarEntidadEdicion();
                    //ProgressBar();
                    //bool Exito = Negocio.Producto.EditarProducto(_producto, idProductoGrillaSeleccionado);
                    //if (Exito == true)
                    //{
                    //    MessageBox.Show("LA EDICIÓN DEL PRODUCTO SE REALIZO EXITOSAMENTE.");
                    //    LimpiarCampos();
                    //    List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                    //    ListaProductos = ListaReducidos;
                    //}
                }
                else
                {
                    //    Entidades.Productos _producto = CargarEntidad();
                    //    ProgressBar();
                    //    bool Exito = Negocio.Producto.CargarProducto(_producto);
                    //    if (Exito == true)
                    //    {
                    //        MessageBox.Show("SE REGISTRO EL PRODUCTO EXITOSAMENTE.");
                    //        LimpiarCampos();
                    //        List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                    //        ListaProductos = ListaReducidos;
                    //    }
                }
            }
            catch (Exception ex)
            { }
        }
        #endregion
    }
}
