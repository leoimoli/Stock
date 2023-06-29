using Stock.DAO;
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
                throw new Exception(ex.Message);
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
            List<FechasFestivas> _listaFechas = new List<FechasFestivas>();
            _listaFechas = DAO.ConsultarDao.BuscarFechasFestivas();
            int AñoActual = DateTime.Now.Year;
            DateTime FechaActual = DateTime.Now;

            ///// Codigo para forzar fechas
            //AñoActual = AñoActual + 1;
            //FechaActual = Clases_Maestras.FechasFestivasForzadas.ForzarFecha();

            foreach (var item in _listaFechas)
            {
                string FechaDesde = item.FechaDesde + "/" + AñoActual;
                string FechaHasta = item.FechaHasta + "/" + AñoActual;
                if (FechaActual > Convert.ToDateTime(FechaDesde) && Convert.ToDateTime(FechaActual) < Convert.ToDateTime(FechaHasta))
                {
                    picFiestas.Visible = true;
                    Image imgFiestas = Image.FromFile(Environment.CurrentDirectory + "\\" + item.NombreImagen);
                    picFiestas.Image = imgFiestas;
                    break;
                }
                else
                {
                    picFiestas.Visible = false;
                }
            }
        }
    }
}

