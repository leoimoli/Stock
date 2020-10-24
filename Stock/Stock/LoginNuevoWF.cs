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
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
