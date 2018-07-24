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
    public partial class Reporte_ProductoWF : Master2
    {
        public Reporte_ProductoWF()
        {
            InitializeComponent();
        }
        private void Reporte_ProductoWF_Load(object sender, EventArgs e)
        {
            txtProducto.AutoCompleteCustomSource = Clases_Maestras.AutoCompleClass.Autocomplete();
            txtProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void chcNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtProducto.Clear();
            if (chcNombre.Checked == true)
            {
                txtProducto.Enabled = true;
                txtProducto.Focus(); ;
                lblProducto.Text = "Nombre Producto";
                chcCodigo.Checked = false;
                button1.Visible = true;
            }
        }
        private void chcCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtProducto.Clear();
            if (chcCodigo.Checked == true)
            {
                txtProducto.Enabled = true;
                txtProducto.Focus();
                lblProducto.Text = "Código Producto";
                chcNombre.Checked = false;
                button1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chcNombre.Checked == true)
                {
                    string descripcion = txtProducto.Text;
                    Lista = Negocio.Consultar.ListarProductoPorDescripcion(descripcion);
                }
                else
                {
                    if (chcCodigo.Checked == true)
                    {
                        string codigo = txtProducto.Text;
                        Lista = Negocio.Consultar.ConsultaProductoPorCodigo(codigo);
                    }
                }
            }
            catch (Exception ex)
            { }

        }
        public List<Entidades.Productos> Lista
        {
            set
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "Id Producto";
                dataGridView1.Columns[0].Width = 65;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                ////dataGridView1.Columns[0].Visible = true;

                dataGridView1.Columns[1].HeaderText = "Código Producto";
                dataGridView1.Columns[1].Width = 125;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Nombre";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Marca";
                dataGridView1.Columns[3].Width = 75;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "Descripcion";
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[5].HeaderText = "FechaDeAlta";
                dataGridView1.Columns[5].Width = 95;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[5].Visible = false;

                dataGridView1.Columns[6].HeaderText = "idUsuario";
                dataGridView1.Columns[6].Width = 95;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = false;

                dataGridView1.Columns[7].HeaderText = "Usuario";
                dataGridView1.Columns[7].Width = 95;
                dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[7].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.Columns[8].HeaderText = "Foto";
                dataGridView1.Columns[8].Width = 95;
                dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[8].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[8].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[8].Visible = false;

                dataGridView1.Columns[9].HeaderText = "Precio de Venta";
                dataGridView1.Columns[9].Width = 80;
                dataGridView1.Columns[9].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[9].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[9].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[10].HeaderText = "Stock";
                dataGridView1.Columns[10].Width = 80;
                dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[10].HeaderCell.Style.ForeColor = Color.White;
            }
        }
    }
}

