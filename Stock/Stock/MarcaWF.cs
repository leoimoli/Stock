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
    public partial class MarcaWF : Form
    {
        public MarcaWF()
        {
            InitializeComponent();
        }
        #region Metodos Generales
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
        private Marca CargarEntidad()
        {
            Marca _Marca = new Marca();
            _Marca.NombreMarca = txtNombreMarca.Text;
            byte[] Imagen = null;
            MemoryStream ms = new MemoryStream();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen = ms.ToArray();
            }
            _Marca.Foto = Imagen;
            return _Marca;
        }
        private void LimpiarCampos()
        {
            txtNombreMarca.Focus();
            txtNombreMarca.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            pictureBox1.Image = null;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    Entidades.Marca _marca = CargarEntidad();
                    ProgressBar();
                    bool Exito = Negocio.Marca.CargarMarca(_marca);
                    if (Exito == true)
                    {
                        MessageBox.Show("SE REGISTRO LA MARCA EXITOSAMENTE.");
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion


    }
}
