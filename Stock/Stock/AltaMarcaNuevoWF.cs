using Stock.Entidades;
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
    public partial class AltaMarcaNuevoWF : Form
    {
        public AltaMarcaNuevoWF()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
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
                        const string message2 = "Se registro la marca exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            { }
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
        private Marca CargarEntidad()
        {
            Marca _Marca = new Marca();
            _Marca.NombreMarca = txtNombreEmpresa.Text;
            return _Marca;
        }
        private void LimpiarCampos()
        {
            txtNombreEmpresa.Focus();
            txtNombreEmpresa.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
    }
}
