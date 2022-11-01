using Stock.DAO;
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
    public partial class LoginNuevoWF : Form
    {
        public LoginNuevoWF()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            List<Entidades.Usuarios> usuarios = new List<Entidades.Usuarios>();
            try
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtClave.Text;
                usuarios = Negocio.Consultar.LoginUsuario(usuario, contraseña);
                if (usuarios.Count == 0)
                {
                    const string message2 = "Usuario/contraseña ingresado incorrecta.";
                    const string caption2 = "Error";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
                else
                {
                    Sesion.UsuarioLogueado = usuarios.First();
                    NewMasterWF _inicio = new NewMasterWF();
                    _inicio.Show();
                    Hide();
                    EditarDao.ActualizarEstadoOferta();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ConexionWF _cone = new ConexionWF();
            _cone.Show();
        }

        private void LoginNuevoWF_Load(object sender, EventArgs e)
        {
            ValidarFechasFestivas();
        }
        private void ValidarFechasFestivas()
        {
            int AñoActual = DateTime.Now.Year;
            DateTime FechaActual = DateTime.Now;
            string PruebaIncio = Convert.ToString(30 + "/" + 10 + "/" + AñoActual + " " + "23" + ":59" + ":59");
            string PruebaFin = Convert.ToString(02 + "/" + 11 + "/" + AñoActual + " " + "23" + ":59" + ":59");
            string FiestasNavideñas = Convert.ToString(07 + "/" + 12 + "/" + AñoActual + " " + "23" + ":59" + ":59");
            string FechaFinFiestas = Convert.ToString(06 + "/" + 01 + "/" + AñoActual + " " + "23" + ":59" + ":59");
            //// Imagenes Navideñas
            if (FechaActual > Convert.ToDateTime(PruebaIncio) && Convert.ToDateTime(FechaActual) < Convert.ToDateTime(PruebaFin))
            {
                Image imgFiestas = Image.FromFile(Environment.CurrentDirectory + "\\" + @"Feliz-Fiesta-Login.gif");
                picFiestas.Image = imgFiestas;
            }
            else
            {
                picFiestas.Visible = false;
            }
        }
    }
}

