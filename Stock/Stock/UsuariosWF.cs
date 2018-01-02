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
                string[] Perfiles = Clases_Maestras.ValoresConstantes.Perfiles;
                cmbPerfil.Items.Add("Seleccione");
                foreach (string item in Perfiles)
                {
                    cmbPerfil.Text = "Seleccione";
                    cmbPerfil.Items.Add(item);
                }

                List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                ListaUsuarios = ListaReducidos;
            }
            catch (Exception ex)
            { }
        }
        #region Botones
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            ValidacionesUsuarioLogueado();
            HabilitarCampos();
        }
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string path = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(path);
            if (result == DialogResult.OK)
            {
                byte[] Imagen = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Imagen = ms.ToArray();
                    if (Imagen.Length > 50000)
                    {
                        MessageBox.Show("EL TAMAÑO DE LA IMAGEN ES SUPERIOR AL PERMITIDO. DEBE SER MENOR A 500kbs");
                        pictureBox1.Image = null;
                        txtImagen.Clear();
                    }
                }
            }
            else
            {
                txtImagen.Text = path;
                pictureBox1.ImageLocation = txtImagen.Text;
            }


            urla = path;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuarioSeleccionado = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);

                if (idUsuarioSeleccionado > 0)
                {
                    panel_CargaUsuario.Enabled = false;
                    Entidades.Usuarios _usuario = CargarEntidadEdicion();
                    ProgressBar();
                    bool Exito = Negocio.Usuario.EditarUsuario(_usuario);
                    if (Exito == true)
                    {
                        MessageBox.Show("LA EDICIÓN DEL USUARIO SE REALIZO EXITOSAMENTE.");
                        LimpiarCampos();
                        List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        ListaUsuarios = ListaReducidos;
                    }
                }
                else
                {
                    panel_CargaUsuario.Enabled = false;
                    Entidades.Usuarios _usuario = CargarEntidad();
                    ProgressBar();
                    bool Exito = Negocio.Usuario.CargarUsuario(_usuario);
                    if (Exito == true)
                    {
                        MessageBox.Show("SE REGISTRO EL USUARIO EXITOSAMENTE.");
                        LimpiarCampos();
                        List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        ListaUsuarios = ListaReducidos;
                    }
                }
            }
            catch (Exception ex)
            { }
        }
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
            cmbPerfil.Items.Add("Seleccione");
            foreach (string item in Perfiles)
            {
                cmbPerfil.Text = "Seleccione";
                cmbPerfil.Items.Add(item);
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

                //dataGridView1.Columns[2].HeaderText = "Nombre";
                //dataGridView1.Columns[2].Width = 100;
                //dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                //dataGridView1.Columns[3].HeaderText = "Dni";
                //dataGridView1.Columns[3].Width = 90;
                //dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                //dataGridView1.Columns[4].HeaderText = "FechaDeNacimiento";
                //dataGridView1.Columns[4].Width = 100;
                //dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[4].Visible = false;


                //dataGridView1.Columns[5].HeaderText = "FechaDeAlta";
                //dataGridView1.Columns[5].Width = 100;
                //dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[5].Visible = false;

                //dataGridView1.Columns[6].HeaderText = "FechaUltimaConexion";
                //dataGridView1.Columns[6].Width = 100;
                //dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[6].Visible = false;

                //dataGridView1.Columns[7].HeaderText = "Contraseña";
                //dataGridView1.Columns[7].Width = 100;
                //dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[7].Visible = false;

                //dataGridView1.Columns[8].HeaderText = "Contraseña2";
                //dataGridView1.Columns[8].Width = 100;
                //dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[8].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[8].Visible = false;


                //dataGridView1.Columns[9].HeaderText = "Perfil";
                //dataGridView1.Columns[9].Width = 100;
                //dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[9].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[9].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[9].Visible = false;

                //dataGridView1.Columns[10].HeaderText = "Estado";
                //dataGridView1.Columns[10].Width = 100;
                //dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[10].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[10].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[10].Visible = false;

                //dataGridView1.Columns[11].HeaderText = "Foto";
                //dataGridView1.Columns[11].Width = 100;
                //dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                //dataGridView1.Columns[11].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                //dataGridView1.Columns[11].HeaderCell.Style.ForeColor = Color.White;
                //dataGridView1.Columns[11].Visible = false;
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
            btnCargarImagen.Visible = true;
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblapellidoNombreEditar.Text = "Editar Usuario";
            panel_CargaUsuario.Enabled = true;
            var usuario = _usuario.First();
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
        private Usuarios CargarEntidadEdicion()
        {
            Usuarios _usuario = new Usuarios();
            _usuario.Apellido = txtApellido.Text;
            _usuario.Nombre = txtNombre.Text;
            DateTime fecha = dtFechaNacimiento.Value;
            _usuario.FechaDeNacimiento = fecha;
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
                int idUsuarioSeleccionado = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                UsuarioSeleccionado(idUsuarioSeleccionado);
            }
            catch (Exception ex)
            { }
        }
        #endregion
    }
}