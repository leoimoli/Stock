using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

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
            txtBuscarProducto.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteProductosSinCodigo.Autocomplete();
            txtBuscarProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBuscarProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "txNombreProducto";
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "txMarca";
                dataGridView1.Columns[3].Width = 100;
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
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdProducto.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value);
                txtNombreProducto.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
                string Marca = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
                if (Marca == "\"Carga Masiva No Especifica\"")
                {
                    CargarCombo();
                }
                else
                {
                    cmbMarca.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
                }
                txtDescripcion.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
                groupBox1.Enabled = true;
                txtCodigoProducto.Focus();
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
                btnGenerarCodigo.Enabled = true;
                //ProductoSeleccionado(idProductoGrilla);
            }
            catch (Exception ex)
            { }
        }
        public void CargarCombo()
        {
            List<string> Marcas = new List<string>();
            Marcas = Negocio.Consultar.CargarComboMarcas();
            cmbMarca.Items.Add("Seleccione");
            cmbMarca.Items.Clear();
            foreach (string item in Marcas)
            {
                cmbMarca.Text = "Seleccione";
                cmbMarca.Items.Add(item);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string DescripcionProducto = txtBuscarProducto.Text;
                ListaProductos = Negocio.Consultar.ListarProductoPorDescripcion(DescripcionProducto);
            }
            catch (Exception ex)
            {

            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdProducto.Clear();
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Productos _producto = CargarEntidad();
                bool Exito = Negocio.Producto.EditarCodigo(_producto.CodigoProducto, _producto.idProducto, _producto.MarcaProducto);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro el producto exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtDescripcion.Clear();
            //txtMarcaProducto.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            List<Entidades.Productos> ListaGrilla = Negocio.Producto.BuscarProductosSinCodigo();
            ListaProductos = ListaGrilla;

        }
        private Productos CargarEntidad()
        {
            Productos _producto = new Productos();
            _producto.idProducto = Convert.ToInt32(txtIdProducto.Text);
            _producto.CodigoProducto = txtCodigoProducto.Text;
            _producto.NombreProducto = txtNombreProducto.Text;
            _producto.MarcaProducto = cmbMarca.Text;
            _producto.Descripcion = txtDescripcion.Text;
            return _producto;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form2 _inicio = new Form2();
            _inicio.Show();
            Hide();
        }
    }
}
