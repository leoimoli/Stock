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
                ListaUsuarios = Negocio.Consultar.ListaDeUsuarios();
            }
            catch (Exception ex)
            { }
        }
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
        private void HabilitarCampos()
        {
            panel_CargaUsuario.Enabled = true;
            txtDni.Focus();
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            btnCargarImagen.Visible = true;
            lblContraseña.Visible = true;
            lblRepitaContraseña.Visible = true;
            pictureBox1.Visible = true;
            txtContraseña.Visible = true;
            txtRepiteContraseña.Visible = true;
        }
        public static string urla;
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
                panel_CargaUsuario.Enabled = false;
                Entidades.Usuarios _usuario = CargarEntidad();
                ProgressBar();
                bool Exito = Negocio.Usuario.CargarUsuario(_usuario);
                if (Exito == true)
                {
                    MessageBox.Show("SE REGISTRO EL USUARIO EXITOSAMENTE.");
                    LimpiarCampos();
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
            pictureBox1 = null;
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
        public List<Entidades.Usuarios> ListaUsuarios
        {
            set
            {
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                //dataGridView1.AutoGenerateColumns = true;

                dataGridView1.Columns[0].HeaderText = "id Usuario";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Apellido";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Nombre";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Dni";
                dataGridView1.Columns[3].Width = 90;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "FechaDeNacimiento";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[4].Visible = false;


                dataGridView1.Columns[5].HeaderText = "FechaDeAlta";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[6].HeaderText = "FechaUltimaConexion";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = false;

                dataGridView1.Columns[7].HeaderText = "Contraseña";
                dataGridView1.Columns[7].Width = 100;
                dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.Columns[8].HeaderText = "Contraseña2";
                dataGridView1.Columns[8].Width = 100;
                dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[8].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[8].Visible = false;


                dataGridView1.Columns[9].HeaderText = "Perfil";
                dataGridView1.Columns[9].Width = 100;
                dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[9].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[9].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[9].Visible = false;

                dataGridView1.Columns[10].HeaderText = "Estado";
                dataGridView1.Columns[10].Width = 100;
                dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[10].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[10].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[10].Visible = false;

                dataGridView1.Columns[11].HeaderText = "Foto";
                dataGridView1.Columns[11].Width = 100;
                dataGridView1.Columns[11].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[11].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[11].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[11].Visible = false;
            }
        }
    }
}