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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado != null)
            {
                lblMaster_UsuarioLogin.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
                lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosWF _usuario = new UsuariosWF();
            _usuario.Show();
            Hide();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producto _producto = new Producto();
            _producto.Show();
            Hide();
        }
    }
}
