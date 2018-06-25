using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Stock
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            t.Start();
        }

        private void Master_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioLogueado != null)
            {
                lblMaster_UsuarioLogin.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
                //lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now);
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

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockWF _stock = new StockWF();
            _stock.Show();
            Hide();
        }
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasWF _ventas = new VentasWF();
            _ventas.Show();
            Hide();
        }

        private void timer1_Tick(object sender, ElapsedEventArgs el)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblMaster_FechaHoraReal.Text = DateTime.Now.ToString();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesWF _clientes = new ClientesWF();
            _clientes.Show();
            Hide();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_VentasWF _reporte = new Reporte_VentasWF();
            _reporte.Show();
            Hide();
        }

        private void consultasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reporte_VentasWF _reporte = new Reporte_VentasWF();
            _reporte.Show();
            Hide();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrecioDeVentaWF _precio = new PrecioDeVentaWF();
            _precio.Show();
            Hide();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagosWF _pagos = new PagosWF();
            _pagos.Show();
            Hide();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 _inicio = new Form2();
            _inicio.Show();
            Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
