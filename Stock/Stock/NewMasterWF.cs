using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Stock
{
    public partial class NewMasterWF : Form
    {
        public NewMasterWF()
        {
            InitializeComponent();
            AbrirFormEnPanel(new InicioNuevoWF());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void MenuCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenuPequeño_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 201)
            {
                MenuVertical.Width = 55;
            }
            else
            {
                if (MenuVertical.Width == 55)
                {
                    MenuVertical.Width = 201;
                }
            }
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProductoNuevoWF());
        }
        private void NewMasterWF_Load(object sender, EventArgs e)
        {
            label6.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioNuevoWF());
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new StockNuevoWF());
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProveedoresNuevoWF());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClientesNuevoWF());
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PreciosNuevoWF());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentasNuevoWF _ventas = new VentasNuevoWF();
            _ventas.Show();
            Hide();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReportesNuevoWF());
        }
    }
}
