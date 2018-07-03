using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class UsuariosWF : Master
    {
        public UsuariosWF()
        {
            InitializeComponent();
        }
        private void UsuariosWF_Load(object sender, EventArgs e)
        {
            try
            {
                List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                ListaUsuarios = ListaReducidos;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            id = 0;
            txtDni.Focus();
            txtDni.Enabled = true;
            lblEstado.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            LimpiarCampos();
            ValidacionesUsuarioLogueado();
            HabilitarCampos();
            lblapellidoNombreEditar.Text = "Nuevo Usuario";
            LimpiarLabels();
        }
        private void LimpiarLabels()
        {
            lblFechaCreacion.Visible = false;
            lblFechaUltimaConexion.Visible = false;
            label6lblFechaCreacion_base.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            lblUltimoLoteIngresado.Visible = false;
            lblVentasRealizadas.Visible = false;
            lblIngresoRecaudado.Visible = false;
            lblFechaUltimaConexion_base.Visible = false;
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
        public static int id;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuarioSeleccionado = id;

                if (idUsuarioSeleccionado > 0)
                {
                    panel_CargaUsuario.Enabled = false;
                    Entidades.Usuarios _usuario = CargarEntidadEdicion();
                    bool Exito = Negocio.Usuario.EditarUsuario(_usuario, idUsuarioSeleccionado);
                    if (Exito == true)
                    {
                        ProgressBar();
                        MessageBox.Show("LA EDICIÓN DEL USUARIO SE REALIZO EXITOSAMENTE.");
                        LimpiarCampos();
                        List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        ListaUsuarios = ListaReducidos;
                    }
                    else
                    {
                        panel_CargaUsuario.Enabled = true;
                        txtDni.Focus();
                    }
                }
                else
                {
                    panel_CargaUsuario.Enabled = false;
                    Entidades.Usuarios _usuario = CargarEntidad();
                    bool Exito = Negocio.Usuario.CargarUsuario(_usuario);
                    if (Exito == true)
                    {
                        ProgressBar();
                        MessageBox.Show("SE REGISTRO EL USUARIO EXITOSAMENTE.");
                        LimpiarCampos();
                        List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        ListaUsuarios = ListaReducidos;
                    }
                    else
                    {
                        panel_CargaUsuario.Enabled = true;
                        txtDni.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.BuscarUsuarioPorDNI(txtDniBuscar.Text));
        //        ListaUsuarios = ListaReducidos;
        //    }
        //    catch (Exception ex)
        //    { }
        //}
        #endregion
        #region Metodos Genericos
        private void HabilitarCampos()
        {
            panel_CargaUsuario.Enabled = true;
            txtDni.Focus();
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnCargarImagen.Visible = true;
            lblContraseña.Visible = true;
            lblRepitaContraseña.Visible = true;
            // pictureBox1.Visible = true;
            txtContraseña.Visible = true;
            txtRepiteContraseña.Visible = true;
            CargarCombo();
        }
        private void CargarCombo()
        {
            string[] Perfiles = Clases_Maestras.ValoresConstantes.Perfiles;
            cmbPerfil.Items.Add("Seleccione");
            cmbPerfil.Items.Clear();
            foreach (string item in Perfiles)
            {
                cmbPerfil.Text = "Seleccione";
                cmbPerfil.Items.Add(item);
            }
        }
        public static string urla;
        private void ValidacionesUsuarioLogueado()
        {
            try
            {
                string perfilUsuarioLogueado = Sesion.UsuarioLogueado.Perfil;
                if (perfilUsuarioLogueado != "ADMINISTRADOR")
                {
                    MessageBox.Show("EL USUARIO LOGUEADO NO TIENE PERMISO PARA LA CREACIÓN DE USUARIOS.");
                    throw new Exception();
                }
            }
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtContraseña.Clear();
            txtRepiteContraseña.Clear();
            DateTime fecha = DateTime.Now;
            dtFechaNacimiento.Value = fecha;
            string[] Perfiles = Clases_Maestras.ValoresConstantes.Perfiles;
            CargarCombo();
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
        private Usuarios CargarEntidad()
        {
            Usuarios _usuario = new Usuarios();
            _usuario.Dni = txtDni.Text;
            _usuario.Apellido = txtApellido.Text;
            _usuario.Nombre = txtNombre.Text;
            DateTime fecha = dtFechaNacimiento.Value;
            _usuario.FechaDeNacimiento = fecha;
            DateTime fechaActual = DateTime.Now;
            _usuario.FechaDeAlta = fechaActual;
            _usuario.FechaUltimaConexion = fechaActual;
            _usuario.Perfil = cmbPerfil.Text;
            _usuario.Estado = "ACTIVO";
            _usuario.Contraseña = txtContraseña.Text;
            _usuario.Contraseña2 = txtRepiteContraseña.Text;

            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _usuario.Foto = Imagen;
            return _usuario;
        }
        public List<Entidades.UsuarioReducido> ListaUsuarios
        {
            set
            {
                lblUltimoMovimientosUsuarios.Text = "Listado de Usuarios:";
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                var contadortotal = value.Count;
                lblTotal.Visible = true;
                label6.Visible = true;
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
        private List<Entidades.UsuarioReducido> CargarEntidadReducida(List<Usuarios> listaUsuarios)
        {
            List<Entidades.UsuarioReducido> _usuarioReducido = new List<UsuarioReducido>();
            foreach (var item in listaUsuarios)
            {
                _usuarioReducido.Add(new UsuarioReducido { IdUsuario = item.IdUsuario, Usuario = item.Dni + ", " + item.Apellido + " " + item.Nombre });
            }
            return _usuarioReducido;
        }
        private void UsuarioSeleccionado(int idUsuarioSeleccionado)
        {
            try
            {
                List<Usuarios> _usuario = new List<Usuarios>();
                _usuario = Negocio.Consultar.BuscarUsuarioPorID(idUsuarioSeleccionado);
                HabilitarCamposUsuarioSeleccionado(_usuario);
            }
            catch (Exception ex)
            { }
        }
        private void HabilitarCamposUsuarioSeleccionado(List<Usuarios> _usuario)
        {
            bool usuarioPermitido = ValidarPerfil();
            if (usuarioPermitido == true)
            {
                lblEstado.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                btnCargarImagen.Visible = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                lblapellidoNombreEditar.Text = "Editar Usuario";
                panel_CargaUsuario.Enabled = true;
                var usuario = _usuario.First();
                if (usuario.Estado == "ACTIVO")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = true;
                }
                txtDni.Text = usuario.Dni;
                txtDni.Enabled = false;
                txtApellido.Text = usuario.Apellido;
                txtNombre.Text = usuario.Nombre;
                txtContraseña.Text = usuario.Contraseña;
                txtRepiteContraseña.Text = usuario.Contraseña;
                cmbPerfil.Text = usuario.Perfil;
                string fecha = Convert.ToString(usuario.FechaDeNacimiento);
                dtFechaNacimiento.Value = Convert.ToDateTime(fecha);
                if (usuario.Foto != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(usuario.Foto);
                    pictureBox1.Image = foto1;
                }
                else
                {
                    pictureBox1.Image = null;
                }
                lblFechaCreacion.Visible = true;
                lblFechaUltimaConexion.Visible = true;
                label6lblFechaCreacion_base.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                lblUltimoLoteIngresado.Visible = true;
                lblVentasRealizadas.Visible = true;
                lblIngresoRecaudado.Visible = true;

                lblFechaUltimaConexion_base.Visible = true;
                label6lblFechaCreacion_base.Text = Convert.ToString(usuario.FechaDeAlta);
                lblFechaUltimaConexion_base.Text = Convert.ToString(usuario.FechaUltimaConexion);
                lblInformacion.Visible = false;
                lblUltimoLoteIngresado.Text = Convert.ToString(usuario.NroLote);
                lblVentasRealizadas.Text = Convert.ToString(usuario.CantidadVentasDelMes);
                lblIngresoRecaudado.Text = Convert.ToString(usuario.EfectivoVentasDelMes);
            }
            else
            {
                panel_CargaUsuario.Enabled = false;
                lblEstado.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                btnCargarImagen.Visible = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                lblapellidoNombreEditar.Text = "Editar Usuario";
                //panel_CargaUsuario.Enabled = true;
                var usuario = _usuario.First();
                if (usuario.Estado == "ACTIVO")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = true;
                }
                txtDni.Text = usuario.Dni;
                txtDni.Enabled = false;
                txtApellido.Text = usuario.Apellido;
                txtNombre.Text = usuario.Nombre;
                txtContraseña.Text = usuario.Contraseña;
                txtRepiteContraseña.Text = usuario.Contraseña;
                cmbPerfil.Text = usuario.Perfil;
                string fecha = Convert.ToString(usuario.FechaDeNacimiento);
                dtFechaNacimiento.Value = Convert.ToDateTime(fecha);
                if (usuario.Foto != null)
                {
                    Bitmap foto1 = Clases_Maestras.Funciones.byteToBipmap(usuario.Foto);
                    pictureBox1.Image = foto1;
                }
                else
                {
                    pictureBox1.Image = null;
                }
                lblFechaCreacion.Visible = true;
                lblFechaUltimaConexion.Visible = true;
                label6lblFechaCreacion_base.Visible = true;
                lblFechaUltimaConexion_base.Visible = true;
                label6lblFechaCreacion_base.Text = Convert.ToString(usuario.FechaDeAlta);
                lblFechaUltimaConexion_base.Text = Convert.ToString(usuario.FechaUltimaConexion);
                lblInformacion.Visible = false;
            }
            btnCancelar.Visible = false;
        }
        private bool ValidarPerfil()
        {
            bool PerfilHabilitado = true;
            try
            {
                string perfilUsuarioLogueado = Sesion.UsuarioLogueado.Perfil;
                if (perfilUsuarioLogueado != "ADMINISTRADOR")
                {
                    PerfilHabilitado = false;
                }
            }
            catch (Exception ex)
            { }
            return PerfilHabilitado;
        }
        private Usuarios CargarEntidadEdicion()
        {
            string estado = "ACTIVO";
            Usuarios _usuario = new Usuarios();
            if (checkBox2.Checked == true)
            {
                estado = "INACTIVO";
            }
            _usuario.Dni = txtDni.Text;
            _usuario.Apellido = txtApellido.Text;
            _usuario.Nombre = txtNombre.Text;
            DateTime fecha = dtFechaNacimiento.Value;
            _usuario.FechaDeNacimiento = fecha;
            _usuario.Perfil = cmbPerfil.Text;
            _usuario.Estado = estado;
            _usuario.Contraseña = txtContraseña.Text;
            _usuario.Contraseña2 = txtRepiteContraseña.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _usuario.Foto = Imagen;
            return _usuario;
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
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
                id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado(id);
            }
            catch (Exception ex)
            { }
        }
        #endregion
        #region Eventos Check
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
            }
        }

        #endregion
        private void txtDniBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDniBuscar.Text != "")
            {
                List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.BuscarUsuarioPorDNI(txtDniBuscar.Text));
                ListaUsuarios = ListaReducidos;
            }
            else
            {
                List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                ListaUsuarios = ListaReducidos;
            }
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
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
                        throw new Exception("EL TAMAÑO DE LA IMAGEN SUPERA EL MAXIMO PERMITIDO(1024x1024)");
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