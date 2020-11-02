using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class ArchivosWF : Form
    {
        public ArchivosWF()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ArchivosWF_Load(object sender, EventArgs e)
        {

            txt1.Focus();
        }
        public static string urla;
        private void btnAdjuntar1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {
                    txt1.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    txt1.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        txt1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    //txt1.Text = path;
                    //txt1.ImageLocation = pictureBox1.Text;
                }
                lbl2.Visible = true;
                txt2.Visible = true;
                btnAdjuntar2.Visible = true;
                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdjuntar2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {
                    txt2.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    txt2.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        txt2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    txt2.Text = path;
                    txt2.ImageLocation = pictureBox1.Text;
                }
                lbl3.Visible = true;
                txt3.Visible = true;
                btnAdjuntar3.Visible = true;
                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdjuntar3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {
                    txt3.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    txt3.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        txt3.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    txt3.Text = path;
                    txt3.ImageLocation = pictureBox1.Text;
                }
                lbl4.Visible = true;
                txt4.Visible = true;
                btnAdjuntar4.Visible = true;
                urla = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdjuntar4_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "";
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                path = openFileDialog1.FileName;
                if (path != "")
                {
                    txt4.SizeMode = PictureBoxSizeMode.StretchImage;
                    var imagen = Image.FromFile(path);
                    txt4.Image = Image.FromFile(path);
                }
                if (result == DialogResult.OK)
                {
                    byte[] Imagen = null;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        txt4.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Imagen = ms.ToArray();

                    }
                }
                else
                {
                    txt4.Text = path;
                    txt4.ImageLocation = pictureBox1.Text;
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
                Archivos _archivos = CargarEntidad();
                int CodigoRespuesta = Negocio.Stock.GuardarArchivos(_archivos);
                if (CodigoRespuesta == 1)
                {
                    ProgressBar();
                    const string message2 = "Se registraron los archivos exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            txt1.Image = null;
            txt2.Image = null;
            txt3.Image = null;
            txt4.Image = null;
            txt2.Visible = false;
            txt3.Visible = false;
            txt4.Visible = false;
            btnAdjuntar2.Visible = false;
            btnAdjuntar3.Visible = false;
            btnAdjuntar4.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
        private Archivos CargarEntidad()
        {
            Archivos _archivos = new Archivos();
            byte[] Imagen1 = null;
            byte[] Imagen2 = null;
            byte[] Imagen3 = null;
            byte[] Imagen4 = null;

            MemoryStream ms = new MemoryStream();
            if (txt1.Image != null)
            {
                txt1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen1 = ms.ToArray();
                _archivos.Archivo1 = Imagen1;
            }
            MemoryStream ms2 = new MemoryStream();
            if (txt2.Image != null)
            {
                txt2.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen2 = ms2.ToArray();
                _archivos.Archivo2 = Imagen2;
            }            

            MemoryStream ms3 = new MemoryStream();
            if (txt3.Image != null)
            {
                txt3.Image.Save(ms3, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen3 = ms3.ToArray();
                _archivos.Archivo3 = Imagen3;
            }
          
            MemoryStream ms4 = new MemoryStream();
            if (txt4.Image != null)
            {
                txt3.Image.Save(ms4, System.Drawing.Imaging.ImageFormat.Jpeg);
                Imagen4 = ms4.ToArray();
                _archivos.Archivo4 = Imagen4;
            }                
            return _archivos;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void ArchivosWF_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
