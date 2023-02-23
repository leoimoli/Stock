using BarcodeLib;
using Stock.Entidades;
using Stock.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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
                CargarComboCategoria();
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
                    dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.NombreCategoria);
                }
            }
            dgvProductos.ReadOnly = true;
        }
        public void CargarCombo()
        {
            List<string> Marcas = new List<string>();
            Marcas = Negocio.Consultar.CargarComboMarcas();           
            foreach (string item in Marcas)
            {
                if (cmbMarca.Items.Count == 0)
                {
                    cmbMarca.Items.Insert(0, "Seleccione");
                    cmbMarca.SelectedIndex = 0;
                }
                cmbMarca.Items.Add(item);
            }
        }
        public void CargarComboCategoria()
        {
            List<string> Categoria = new List<string>();
            Categoria = Negocio.Consultar.CargarComboCategoria();           
            foreach (string item in Categoria)
            {
                if (cmbCategoria.Items.Count == 0)
                {
                    cmbCategoria.Items.Insert(0, "Seleccione");
                    cmbCategoria.SelectedIndex = 0;
                }
                cmbCategoria.Items.Add(item);
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
                cmbCategoria.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
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
            try
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
                    if (chcProductoEspecial.Checked == true)
                    {
                        if (panelCodigo.BackgroundImage != null)
                        {
                            /////GUARDO EL CODIGO DE BARRA GENERADO.
                            string folderPath = "C:\\Stocom-Archivos\\CodigoDeBarra\\";
                            if (!Directory.Exists(folderPath))
                            {
                                Directory.CreateDirectory(folderPath);
                            }
                            string NombreArchivo = codigoStatico.RawData;
                            codigoStatico.SaveImage(folderPath + NombreArchivo + "' .jpg", SaveTypes.JPG);
                        }
                        else
                        {
                            const string message2 = "Atención: De generar un código de barra para el producto.";
                            const string caption2 = "Atención";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);

                        }
                    }

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
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            txtCodigoProducto.Clear();
            textBox2.Clear();
            CargarCombo();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            chcProductoEspecial.Checked = false;
            panelCodigo.BackgroundImage = null;
            codigoStatico = null;
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
            _producto.idCategoria = Consultar.BuscarIdCategoria(cmbCategoria.Text);
            _producto.Descripcion = textBox2.Text;
            DateTime fechaActual = DateTime.Now;
            _producto.FechaDeAlta = fechaActual;
            _producto.idUsuario = idusuarioLogueado;
            if (chcProductoEspecial.Checked == true)
            {
                // _producto.CodigoProducto = GenerarProductoEspecial(_producto.Descripcion);
                //_producto.MarcaProducto = "No especifica";
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
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.NombreCategoria);
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
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.NombreCategoria);
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
            FuncionNuevoProducto_HabilitarCampos();

        }

        private void FuncionNuevoProducto_HabilitarCampos()
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
            chcProductoEspecial.Enabled = true;
            btnGuardar.Enabled = true;
            textBox2.Enabled = true;
            btnImprimirCodigo.Enabled = true;
            txtCodigoProducto.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbMarca.Enabled = true;
            txtDescripcion.Enabled = true;
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
                txtCodigoProducto.Enabled = false;
                cmbCategoria.Focus();
                btnGenerarCodigo.Visible = true;
            }
            else
            {
                txtCodigoProducto.Enabled = true;
                txtCodigoProducto.Focus();
                btnGenerarCodigo.Visible = false;
                panelCodigo.Visible = false;
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

        public static Barcode codigoStatico = null;
        private void GenerarCodigoDeBarra()
        {
            string InicioCodigo = "";
            int idMarca = Consultar.BuscarIdMarca(cmbMarca.Text);
            int idCategoria = Consultar.BuscarIdCategoria(cmbCategoria.Text);

            string ParteCentralCodigo = Convert.ToString(idMarca + idCategoria + 1);
            string Dia = Convert.ToString(DateTime.Now.Date.Day);
            string Mes = Convert.ToString(DateTime.Now.Date.Month);
            string Año = Convert.ToString(DateTime.Now.Date.Year);
            string Hora = Convert.ToString(DateTime.Now.Hour);
            string Minutos = Convert.ToString(DateTime.Now.Minute);
            string Segundos = Convert.ToString(DateTime.Now.Second);
            string ParteFinalCodigo = Dia + Mes + Año;
            string CodigoArmado = ParteCentralCodigo + ParteFinalCodigo + Hora + Minutos + Segundos;
            int ContadorCaracteresInt = CodigoArmado.Length;
            if (ContadorCaracteresInt <= 16)
            {
                InicioCodigo = "999";
                CodigoArmado = InicioCodigo + ParteCentralCodigo + ParteFinalCodigo + Hora + Minutos + Segundos;
            }
            if (ContadorCaracteresInt == 17)
            {
                InicioCodigo = "99";
                CodigoArmado = InicioCodigo + ParteCentralCodigo + ParteFinalCodigo + Hora + Minutos + Segundos;
            }
            if (ContadorCaracteresInt == 18)
            {
                InicioCodigo = "9";
                CodigoArmado = InicioCodigo + ParteCentralCodigo + ParteFinalCodigo + Hora + Minutos + Segundos;
            }

            ///// Validamos que el código ya no exista.
            bool CodigoExistente = Consultar.ValidarProductoExistente(CodigoArmado);
            if (CodigoExistente == false)
            {
                string Contenido = CodigoArmado;
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;
                codigo.Alignment = AlignmentPositions.CENTER;
                codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);
                Image img = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 200, 140);
                codigoStatico = codigo;
                //codigoStatico.SaveImage(@"C:\Users\Usuario\source\repos\Pulpejitos-Repositorio\VETERINARIA\Img\Codigos_De_Barra\ '" + CodigoArmado + "' .jpg", SaveTypes.JPG);
                panelCodigo.BackgroundImage = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 400, 100);
                txtCodigoProducto.Text = CodigoArmado;
            }
            else
            {
                CodigoArmado = InicioCodigo + ParteCentralCodigo + ParteFinalCodigo + Hora + Minutos + Segundos + 1;
                string Contenido = CodigoArmado;
                Barcode codigo = new Barcode();
                codigo.IncludeLabel = true;
                codigo.Alignment = AlignmentPositions.CENTER;
                codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);
                Image img = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 200, 140);
                codigoStatico = codigo;
                //codigoStatico.SaveImage(@"C:\Users\Usuario\source\repos\Pulpejitos-Repositorio\VETERINARIA\Img\Codigos_De_Barra\ '" + CodigoArmado + "' .jpg", SaveTypes.JPG);
                panelCodigo.BackgroundImage = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 400, 100);
                txtCodigoProducto.Text = CodigoArmado;
            }
        }
        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCamposobligatorios();
                GenerarCodigoDeBarra();
            }
            catch (Exception ex)
            { }
        }
        private void ValidarCamposobligatorios()
        {
            if (String.IsNullOrEmpty(cmbCategoria.Text))
            {
                const string message = "Atención: Para generar un código de barra de seleccionar un items del campo Categoria.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(cmbMarca.Text))
            {
                const string message = "Atención: Para generar un código de barra de seleccionar un items del campo Marca.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        private void btnImprimirCod_Click(object sender, EventArgs e)
        {
            try
            {
                Funcion = 4;
                if (this.dgvProductos.RowCount > 0)
                {
                    FuncionImprimirCodigo_HabilitarCampos();

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
            catch (Exception ex)
            { }
        }
        public static Barcode codigoStaticoImpimir = null;
        private void FuncionImprimirCodigo_HabilitarCampos()
        {
            panel1.Enabled = true;
            btnCrear.Enabled = true;
            idProductoSeleccionado = Convert.ToInt32(this.dgvProductos.CurrentRow.Cells[0].Value);
            txtCodigoProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            cmbMarca.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            cmbCategoria.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            chcProductoEspecial.Enabled = false;
            btnGuardar.Enabled = false;
            textBox2.Enabled = false;
            btnImprimirCodigo.Enabled = true;
            txtCodigoProducto.Enabled = false;
            cmbCategoria.Enabled = false;
            cmbMarca.Enabled = false;
            txtDescripcion.Enabled = false;
            string TotalCaracteres = Convert.ToString(textBox2.Text.Length);
            lblContador.Visible = true;
            lblTotal.Visible = true;
            lblContador.Text = TotalCaracteres;

            string CodigoArmado = txtCodigoProducto.Text;
            string Contenido = CodigoArmado;
            Barcode codigo = new Barcode();
            codigo.IncludeLabel = true;
            codigo.Alignment = AlignmentPositions.CENTER;
            codigo.LabelFont = new Font(FontFamily.GenericMonospace, 14, FontStyle.Regular);
            Image img = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 200, 140);
            codigoStaticoImpimir = codigo;
            panelCodigo.BackgroundImage = codigo.Encode(TYPE.CODE128, Contenido, Color.Black, Color.White, 400, 100);
            btnImprimirCodigo.Visible = true;
        }

        private void btnImprimirCodigo_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            Image newImage = panelCodigo.BackgroundImage;
            float x = 0;
            float y = 0;
            RectangleF srcRect = new RectangleF(0.0F, -20.0F, 500.0F, 150.0F);
            GraphicsUnit units = GraphicsUnit.Pixel;
            //e.Graphics.DrawString("Hola Mundo", font, Brushes.Black, new RectangleF(0, 10, 120, 20));
            e.Graphics.DrawImage(newImage, x, y, srcRect, units);
        }
    }
}
