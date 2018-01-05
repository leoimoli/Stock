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
                    Form1 _inicio = new Form1();
                    _inicio.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                //resultado.Exito = false;
                //resultado.Errores = new List<string>();
                //resultado.Errores.Add(e.Message);
            }
            //return resultado;
        }
    }
}
