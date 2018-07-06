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
using System.Windows.Forms.DataVisualization.Charting;

namespace Stock
{
    public partial class ProveedoresWF : Master
    {
        public ProveedoresWF()
        {
            InitializeComponent();
        }
        private void ProveedoresWF_Load(object sender, EventArgs e)
        {
            try
            {
                txtBuscador.Focus();
                List<Entidades.ProveedorReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProveedores());
                ListaProveedores = ListaReducidos;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
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
                        ProgressBar();
                        const string message2 = "La edición del proveedor se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        List<Entidades.ProveedorReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProveedores());
                        ListaProveedores = ListaReducidos;
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
                        const string message2 = "Se registro el proveedor exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        List<Entidades.ProveedorReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProveedores());
                        ListaProveedores = ListaReducidos;
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        #endregion
        #region Metodos Generales
        public static string urla;
        private void btnCargarImagen_Click_1(object sender, EventArgs e)
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
        private void ProveedorSeleccionado(int idProveedorGrilla)
        {
            try
            {
                List<Entidades.Proveedores> _proveedor = new List<Entidades.Proveedores>();
                _proveedor = Negocio.Consultar.BuscarProveedorPorID(idProveedorGrilla);
                HabilitarCamposUsuarioSeleccionado(_proveedor);
            }
            catch (Exception ex)
            { }
        }
        private void HabilitarCamposUsuarioSeleccionado(List<Entidades.Proveedores> _proveedor)
        {

            btnCargarImagen.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblapellidoNombreEditar.Text = "Editar Proveedor";
            panel_Proveedores.Enabled = true;
            var proveedor = _proveedor.First();
            txtNombreEmpresa.Text = proveedor.NombreEmpresa;
            txtNombreEmpresa.Enabled = false;
            txtPersonaContacto.Text = proveedor.Contacto;
            txtEmail.Text = proveedor.Email;
            txtSitioWeb.Text = proveedor.SitioWeb;
            txtCalle.Text = proveedor.Calle;
            txtAltura.Text = proveedor.Altura;
            var codigo = proveedor.Telefono.Split('-');
            txtCodArea.Text = codigo[0];
            txtTelefono.Text = codigo[1];
            if (proveedor.Foto != null)
            {
                Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(proveedor.Foto);
                pictureBox1.Image = foto1;
            }
            else
            {
                pictureBox1.Image = null;
            }

            ///// Trabajo Gráfico.........
            List<HistorialDelProveedor> _historial = new List<HistorialDelProveedor>();
            _historial = Negocio.Consultar.HistorialDelProveedor(proveedor.NombreEmpresa);
            if (_historial.Count > 0)
            {
                string[] series1 = { proveedor.NombreEmpresa };
                fillChart(series1, _historial);
                btnCancelar.Visible = false;
            }
            else
            {
                lblUsuarioEstadisticas.Text = "El proveedor no tiene historial de compras para mostrar";
            }
        }
        private void fillChart(string[] series1, List<HistorialDelProveedor> _historial)
        {
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            foreach (var item in _historial)
            {
                chart1.Series[nombreNuevaSerie].Points.AddXY(item.mes, item.TotalCompras);
            }

        }

        public List<Entidades.ProveedorReducido> ListaProveedores
        {
            set
            {
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                var contadortotal = value.Count;
                lblTotal.Visible = true;
                label1.Visible = true;
                lblTotal.Text = Convert.ToString(contadortotal);

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
        private List<Entidades.ProveedorReducido> CargarEntidadReducida(List<Proveedores> listaProveedores)
        {
            List<Entidades.ProveedorReducido> _proveedorReducido = new List<ProveedorReducido>();
            foreach (var item in listaProveedores)
            {
                _proveedorReducido.Add(new ProveedorReducido { idProveedor = item.idProveedor, Proveedor = item.NombreEmpresa });
            }
            return _proveedorReducido;
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
            string telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _proveedor.Telefono = telefono;
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
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _proveedor.NombreEmpresa = txtNombreEmpresa.Text;
            _proveedor.Contacto = txtPersonaContacto.Text;
            _proveedor.Email = txtEmail.Text;
            _proveedor.SitioWeb = txtSitioWeb.Text;
            _proveedor.Calle = txtCalle.Text;
            _proveedor.Altura = txtAltura.Text;
            string telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _proveedor.Telefono = telefono;
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
                idProveedorGrilla = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                ProveedorSeleccionado(idProveedorGrilla);
            }
            catch (Exception ex)
            { }
        }

        #endregion

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtBuscador.Text != "")
                    {
                        List<Entidades.ProveedorReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.BuscarProvedorPorNombre(txtBuscador.Text));
                        ListaProveedores = ListaReducidos;
                    }
                    else
                    {
                        List<Entidades.ProveedorReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeProveedores());
                        ListaProveedores = ListaReducidos;
                    }
                }
                catch (Exception ex)
                {
                    const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Warning);
                    throw new Exception();
                }
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

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
    }
}

