using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class CargaMasivaProductosWF : Form
    {
        public CargaMasivaProductosWF()
        {
            InitializeComponent();
        }
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = "";
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                txtRuta.Text = path;
                sr.Close();
            }
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            btnImportar.Enabled = true;
            Datos();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
        public static List<Entidades.Productos> ListaStatic;
        private void Datos()
        {
            string RutaCargada = txtRuta.Text;
            //Hoja desde donde obtendremos los datos
            string hoja = "Hoja1";
            //Cadena de conexión
            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                           RutaCargada +
                            ";Extended Properties='Excel 12.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(conexion);
            //Consulta contra la hoja de Excel
            OleDbCommand cmd = new OleDbCommand("Select * From [" + hoja + "$]", con);
            //Conectarse al archivo de Excel
            con.Open();
            OleDbDataAdapter sda = new OleDbDataAdapter(cmd);
            DataTable data = new DataTable();
            //Cargar los datos
            sda.Fill(data);
            List<Entidades.Productos> listaPreguntas = new List<Entidades.Productos>();
            try
            {
                if (data.Rows.Count > 0)
                {
                    foreach (DataRow item in data.Rows)
                    {
                        Entidades.Productos list = new Entidades.Productos();
                        if (item[0].ToString() == "Codigo")
                        {
                            list.CodigoProducto = "0";
                        }
                        list.CodigoProducto = Convert.ToString(item[0].ToString());
                        if (list.CodigoProducto == "0")
                        { continue; }
                        list.Descripcion = item[1].ToString();
                        list.MarcaProducto = item[2].ToString();
                        list.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
                        list.FechaDeAlta = DateTime.Now;
                        dgvProductos.Rows.Add(list.CodigoProducto, list.Descripcion, list.MarcaProducto);
                        listaPreguntas.Add(list);
                        label5.Visible = true;
                        label4.Visible = true;
                        ListaStatic = listaPreguntas;
                        label4.Text = Convert.ToString(listaPreguntas.Count);
                        dgvProductos.Visible = true;
                        btnGuardar.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NewMasterWF _master = new NewMasterWF();
            _master.Show();
            Hide();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ProgressBar();
            int Exito = DAO.AgregarDao.GuardarCargaMasivaProductos(ListaStatic);
            if (Exito == 1)
            {
                string Numero = Convert.ToString(Exito);
                string message2 = "Se registraron los productos exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                LimpiarCampos();
            }
        }
        private void LimpiarCampos()
        {
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
    }
}
