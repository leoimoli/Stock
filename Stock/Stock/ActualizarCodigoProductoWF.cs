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
    public partial class ActualizarCodigoProductoWF : Form
    {
        public ActualizarCodigoProductoWF()
        {
            InitializeComponent();
        }
        private void ActualizarCodigoProductoWF_Load(object sender, EventArgs e)
        {
            List<Entidades.Productos> ListaGrilla = Negocio.Producto.BuscarProductosSinCodigo();
            ListaProductos = ListaGrilla;
        }

        public List<Entidades.Productos> ListaProductos
        {
            set
            {
                //dataGridView1.ColumnHeadersVisible = false;
                //dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                label6.Text = Convert.ToString(value.Count);
                label6.Visible = true;
                label7.Visible = true;
                btnBuscar.Visible = true;
                txtBuscarProducto.Enabled = true;

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                

                dataGridView1.Columns[1].HeaderText = "Código";
                dataGridView1.Columns[1].Width = 40;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "txNombreProducto";
                dataGridView1.Columns[2].Width = 250;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "txMarca";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "txDescripcion";
                dataGridView1.Columns[4].Width = 300;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[5].HeaderText = "Fecha";
                dataGridView1.Columns[5].Width = 60;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[6].HeaderText = "idUsuario";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = false;

                dataGridView1.Columns[7].HeaderText = "Usuario";
                dataGridView1.Columns[7].Width = 150;
                dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.Columns[8].HeaderText = "txFoto";
                dataGridView1.Columns[8].Width = 150;
                dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[8].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[8].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[8].Visible = false;

                dataGridView1.Columns[9].HeaderText = "txPrecioDeVenta";
                dataGridView1.Columns[9].Width = 150;
                dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[9].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[9].Visible = false;

                dataGridView1.Columns[10].HeaderText = "Cantidad";
                dataGridView1.Columns[10].Width = 150;
                dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[10].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[10].Visible = false;
            }
        }
    }
}
