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
    public partial class LoginWF : Form
    {
        public LoginWF()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Entidades.Usuarios> usuarios = new List<Entidades.Usuarios>();
            try
            {
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;
                usuarios = Negocio.Consultar.LoginUsuario(usuario, contraseña);
                if (usuarios.Count == 0)
                {
                    MessageBox.Show("Usuario ingresado/contraseña incorrecta.");
                    throw new Exception();
                }
                else
                {
                    Sesion.UsuarioLogueado = usuarios.First();
                    Form2 _inicio = new Form2();
                    _inicio.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
