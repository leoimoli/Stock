using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Clases_Maestras;
using static Stock.Clases_Maestras.RutasDeAcceso;

namespace Stock
{
    public partial class CargaMasivaDeProductosWF : Form
    {
        public CargaMasivaDeProductosWF()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            btnCargar.Enabled = false;
            Datos();
            LimpiarCampos();
        }
        public static List<Entidades.Productos> listaGuardar;
        public List<Entidades.Productos> ListaProductos
        {
            set
            {
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                var contadortotal = value.Count;
                label2.Visible = true;
                label1.Visible = true;
                label2.Text = Convert.ToString(contadortotal);
                listaGuardar = value;
                //dataGridView1.AutoGenerateColumns = true;
                //dataGridView1.sty

                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "txCodigoProducto";
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "txNombreProducto";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "txMarca";
                dataGridView1.Columns[3].Width = 60;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "txDescripcion";
                dataGridView1.Columns[4].Width = 60;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[5].HeaderText = "Fecha";
                dataGridView1.Columns[5].Width = 60;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[6].HeaderText = "idUsuario";
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;

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

                dataGridView1.Columns[10].HeaderText = "Cantidad";
                dataGridView1.Columns[10].Width = 150;
                dataGridView1.Columns[10].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[10].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[10].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[10].Visible = false;
            }
        }
        private void Datos()
        {
            Productos_CargaMasiva ruta = new Productos_CargaMasiva();
            //Obtenemos el archivo desde la ubicación actual
            var executableFolderPath = ruta.Carpeta;
            //Hoja desde donde obtendremos los datos
            string hoja = "Hoja1";
            //Cadena de conexión
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + executableFolderPath +
                            "\\CargaMasivaProducto.xlsx" +
                            ";Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(conexion);
            //Consulta contra la hoja de Excel
            OleDbCommand cmd = new OleDbCommand("Select * From [" + hoja + "$]", con);
            List<Entidades.Productos> listaVotos = new List<Entidades.Productos>();
            try
            {
                //Conectarse al archivo de Excel
                con.Open();
                OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
                DataTable data = new DataTable();
                //Cargar los datos
                sda.Fill(data);
                //Cargar la grilla
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        Entidades.Productos list = new Entidades.Productos();
                        list.CodigoProducto = item[0].ToString();
                        list.NombreProducto = item[1].ToString();
                        list.MarcaProducto = item[2].ToString();
                        list.Descripcion = item[3].ToString();
                        list.FechaDeAlta = DateTime.Now;
                        list.idUsuario = Convert.ToInt32(item[4].ToString());
                        //list.Foto = Convert.ToByte(item[6].ToString());
                        list.PrecioDeVenta = Convert.ToDecimal(item[5].ToString());
                        listaVotos.Add(list);
                    }
                }
                ListaProductos = listaVotos;
                btnGuardar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la lectura del archivo");
            }
            finally
            {
                //Funcione o no, cerramos la cadena de conexión
                con.Close();

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
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            bool exito = Negocio.Producto.GaurdarProductosMasivo(listaGuardar);
            if (exito == true)
            { MessageBox.Show("Se registraron los productos exitosamente."); }
            else { MessageBox.Show("Fallo la carga masiva de productos."); }
            LimpiarCampos();
        }
    }
}
