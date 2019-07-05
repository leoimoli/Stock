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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosWF _usuario = new UsuariosWF();
            _usuario.Show();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Producto _producto = new Producto();
            _producto.Show();
            Hide();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ProveedoresWF _proveedores = new ProveedoresWF();
            _proveedores.Show();
            Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StockWF _stock = new StockWF();
            _stock.Show();
            Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Reporte_VentasWF _reporte = new Reporte_VentasWF();
            _reporte.Show();
            Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            VentasWF _ventas = new VentasWF();
            _ventas.Show();
            Hide();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
            ListaStockFaltante = Negocio.Consultar.ListaStockFaltante();
            if (Sesion.UsuarioLogueado.Perfil != "SUPERADMIN")
            { btnSuperAdmin.Visible = false; }
        }
        public List<Entidades.ListaStockFaltante> ListaStockFaltante
        {
            set
            {
                if (value.Count > 0)
                {
                    lblAtencion.Visible = true;
                    lblStock.Visible = true;
                    dataGridView1.Visible = true;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.DataSource = value;

                    dataGridView1.Columns[0].HeaderText = "Código Producto";
                    dataGridView1.Columns[0].Width = 95;
                    dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[1].HeaderText = "Descripción";
                    dataGridView1.Columns[1].Width = 400;
                    dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[2].HeaderText = "Marca";
                    dataGridView1.Columns[2].Width = 95;
                    dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                    dataGridView1.Columns[3].HeaderText = "Cantidad Actual";
                    dataGridView1.Columns[3].Width = 95;
                    dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                    dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PagosWF _pagos = new PagosWF();
            _pagos.Show();
            Hide();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            PrecioDeVentaWF _precios = new PrecioDeVentaWF();
            _precios.Show();
        }

        private void btnSuperAdmin_Click(object sender, EventArgs e)
        {
            MenuSuperAdminWF _super = new MenuSuperAdminWF();
            _super.Show();
            Hide();
        }
    }
}
