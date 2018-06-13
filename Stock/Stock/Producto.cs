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

                lblUltimoMovimientosProductos.Text = "Últimos Productos cargados";
                List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                ListaProductos = ListaReducidos;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        #region Metodos Generales
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
        public static int idProductoGrilla;
        private List<Entidades.ProductoReducido> CargarEntidadReducida(List<Entidades.Productos> listaProductos)
        {
            List<ProductoReducido> _productoReducido = new List<ProductoReducido>();
            foreach (var item in listaProductos)
            {
                _productoReducido.Add(new ProductoReducido { idProducto = item.idProducto, Producto = item.CodigoProducto + ", " + item.NombreProducto });
            }
            return _productoReducido;
        }
        public List<Entidades.ProductoReducido> ListaProductos
        {
            set
            {
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                //dataGridView1.AutoGenerateColumns = true;
                //dataGridView1.sty

                dataGridView1.Columns[0].HeaderText = "id Usuario";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Usuario";
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            }
        }
        private void HabilitarCampos()
        {
            CargarCombo();
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
            _producto.Descripcion = textBox2.Text;
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
            _producto.Descripcion = textBox2.Text;
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
            txtCodigoBusqueda.Clear();
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            textBox2.Clear();
            txtImagen.Clear();
            List<string> Marcas = Negocio.Consultar.CargarComboMarcas();
            cmbMarca.Items.Add("Seleccione");
            foreach (string item in Marcas)
            {
                cmbMarca.Text = "Seleccione";
                cmbMarca.Items.Add(item);
            }
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
        private void ProductoSeleccionado(int idProductoGrilla)
        {
            try
            {
                List<Entidades.Productos> _producto = new List<Entidades.Productos>();
                _producto = Negocio.Consultar.BuscarProductoPorID(idProductoGrilla);
                HabilitarCamposProductoSeleccionado(_producto);
            }
            catch (Exception ex)
            { }
        }
        private void HabilitarCamposProductoSeleccionado(List<Productos> _producto)
        {
            lblHistorialProducto.Text = "Historial Producto";
            btnCargarImagen.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblapellidoNombreEditar.Text = "Editar Producto";
            panel_Producto.Enabled = true;
            var producto = _producto.First();
            txtCodigoProducto.Text = producto.CodigoProducto;
            txtCodigoProducto.Enabled = false;
            txtNombreProducto.Text = producto.NombreProducto;
            textBox2.Text = producto.Descripcion;
            cmbMarca.Text = producto.MarcaProducto;
            if (producto.Foto != null)
            {
                Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(producto.Foto);
                pictureBox1.Image = foto1;
            }
            else
            {
                pictureBox1.Image = null;
            }
            EditCódigo_Producto.Text = producto.CodigoProducto;
            EditNombre_Producto.Text = producto.NombreProducto;
            EditMarca_Producto.Text = producto.MarcaProducto;
            EditUsuario_Creador.Text = producto.Usuario;
            EditPrecioDeVenta_Producto.Text = Convert.ToString(producto.PrecioDeVenta);
            EditFecha_Alta_Producto.Text = Convert.ToString(producto.FechaDeAlta);
            EditCódigo_Producto.Visible = true;
            EditNombre_Producto.Visible = true;
            EditMarca_Producto.Visible = true;
            EditUsuario_Creador.Visible = true;
            EditFecha_Alta_Producto.Visible = true;
            EditPrecioDeVenta_Producto.Visible = true;
        }
        #endregion
        #region Botones
        public static string urla;
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {

                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    if (imagen.Size.Height > 1024 || imagen.Size.Width > 1024)
                    {
                        throw new Exception("EL TAMAÑO DE LA IMAGEN SUPERA EL PERMITIDO(1024x1024)");
                    }
                    pictureBox1.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    txtImagen.Text = path;
                    pictureBox1.ImageLocation = txtImagen.Text;
                }

                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigoBusqueda.Text != "")
            {
                txtCodigoProducto.Text = txtCodigoBusqueda.Text;
                txtCodigoProducto.Enabled = false;
            }
            lblHistorialProducto.Text = "No hay información del producto para visualizar";
            EditCódigo_Producto.Visible = false;
            EditNombre_Producto.Visible = false;
            EditMarca_Producto.Visible = false;
            EditUsuario_Creador.Visible = false;
            EditFecha_Alta_Producto.Visible = false;
            EditPrecioDeVenta_Producto.Visible = false;
            idProductoGrilla = 0;
            //txtCodigoProducto.Enabled = true;
            //txtCodigoProducto.Focus();
            // LimpiarCampos();
            HabilitarCampos();
        }
        public static int idProductoGrillaSeleccionado;
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
                        List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                        ListaProductos = ListaReducidos;
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
                        List<Entidades.ProductoReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProductos());
                        ListaProductos = ListaReducidos;
                    }
                    else
                    {
                        lblHistorialProducto.Text = "No hay información del producto para visualizar";
                        EditCódigo_Producto.Visible = false;
                        EditNombre_Producto.Visible = false;
                        EditMarca_Producto.Visible = false;
                        EditUsuario_Creador.Visible = false;
                        EditFecha_Alta_Producto.Visible = false;
                        EditPrecioDeVenta_Producto.Visible = false;
                        idProductoGrilla = 0;
                        txtCodigoProducto.Enabled = true;
                        txtCodigoProducto.Focus();
                        LimpiarCampos();
                        HabilitarCampos();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaWF _marca = new MarcaWF();
            _marca.Show();
        }
        private void cmbMarca_Click(object sender, EventArgs e)
        {
            CargarCombo();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        #endregion
        #region Eventos Grilla
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                idProductoGrilla = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                ProductoSeleccionado(idProductoGrilla);
            }
            catch (Exception ex)
            { }
        }


        #endregion

        private void btnRemarcarPrecio_Click(object sender, EventArgs e)
        {
            PrecioDeVentaWF _precio = new PrecioDeVentaWF();
            _precio.Show();
            Hide();
        }
    }
}
