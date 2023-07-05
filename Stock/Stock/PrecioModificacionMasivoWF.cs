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
    public partial class PrecioModificacionMasivoWF : Form
    {
        public PrecioModificacionMasivoWF()
        {
            InitializeComponent();
        }
        public static string Funcion = "Funcion";
        private void chcMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMarca.Checked == true)
            {
                txtBuscar.Clear();
                Funcion = "Marca";
                chcProveedor.Checked = false;
                txtBuscar.Visible = true;
                txtBuscar.Focus();
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteMarcas.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void chcProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chcProveedor.Checked == true)
            {
                txtBuscar.Clear();
                Funcion = "Proveedor";
                chcMarca.Checked = false;
                txtBuscar.Visible = true;
                txtBuscar.Focus();
                txtBuscar.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteProveedores.Autocomplete();
                txtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                panel3.Enabled = true;
                if (Funcion == "Marca")
                {
                    List<string> ListaIdProducto = new List<string>();
                    dgvProductos.Rows.Clear();
                    string Marca = txtBuscar.Text;
                    List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductosPorMarca(Marca);
                    if (ListaProductos.Count > 0)
                    {
                        foreach (var item in ListaProductos)
                        {
                            string Producto = Convert.ToString(item.idProducto);
                            if (item.PrecioDeVenta > 0 & !ListaIdProducto.Any(x => x.ToString() == Producto))
                            {
                                dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                                ListaIdProducto.Add(Producto);
                            }
                            else { continue; }
                        }
                        lblGrilla.Visible = true;
                        lblTotal.Visible = true;
                        lblTotalEdit.Visible = true;
                        lblTotalEdit.Text = Convert.ToString(ListaIdProducto.Count);
                    }
                    dgvProductos.ReadOnly = true;
                }
                if (Funcion == "Proveedor")
                {
                    List<string> ListaIdProducto = new List<string>();
                    dgvProductos.Rows.Clear();
                    string Marca = txtBuscar.Text;
                    List<Entidades.Productos> ListaProductos = Negocio.Consultar.ListaDeProductosPorProveedor(Marca);
                    if (ListaProductos.Count > 0)
                    {
                        foreach (var item in ListaProductos)
                        {
                            string Producto = Convert.ToString(item.idProducto);
                            if (item.PrecioDeVenta > 0 & !ListaIdProducto.Any(x => x.ToString() == Producto))
                            {
                                dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.MarcaProducto, item.PrecioDeVenta);
                                ListaIdProducto.Add(Producto);
                            }
                            else { continue; }
                        }
                        lblGrilla.Visible = true;
                        lblTotal.Visible = true;
                        lblTotalEdit.Visible = true;
                        lblTotalEdit.Text = Convert.ToString(ListaIdProducto.Count);
                    }
                    dgvProductos.ReadOnly = true;
                }
            }
        }
        private void chcAumentar_CheckedChanged(object sender, EventArgs e)
        {
            if (chcAumentar.Checked == true)
            {
                chcBajar.Checked = false;
                txtReditoPorcentual.Enabled = true;
                txtReditoPorcentual.Focus();
            }
        }
        private void chcBajar_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBajar.Checked == true)
            {
                chcAumentar.Checked = false;
                txtReditoPorcentual.Enabled = true;
                txtReditoPorcentual.Focus();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Exito;
                if (chcMarca.Checked != true & chcProveedor.Checked != true & chcAumentar.Checked != true & chcBajar.Checked != true)
                {

                }
                else
                {
                    int Total = Convert.ToInt32(lblTotalEdit.Text);
                    string fun = Funcion;
                    string mensaje = "Usted Desea modificar el precio de venta de los '" + Total + "'  productos correspondientes '" + fun + "'  seleccionada?";
                    string message = mensaje;
                    const string caption = "Atención";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        ///// 1 Aumento
                        ///// 2 Baja
                        int Estado = 0;
                        int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
                        if (Funcion == "Marca")
                        {
                            if (chcAumentar.Checked == true)
                            {
                                Estado = 1;
                            }
                            if (chcBajar.Checked == true)
                            {
                                Estado = 2;
                            }
                            ProgressBar();
                            string marca = txtBuscar.Text;
                            string redito = txtReditoPorcentual.Text;
                            Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorMarca(marca, redito, idusuarioLogueado, Estado);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por marca";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                        }
                        if (Funcion == "Proveedor")
                        {
                            if (chcAumentar.Checked == true)
                            {
                                Estado = 1;
                            }
                            if (chcBajar.Checked == true)
                            {
                                Estado = 2;
                            }
                            ProgressBar();
                            string marca = txtBuscar.Text;
                            string redito = txtReditoPorcentual.Text;
                            Exito = Negocio.PrecioDeVenta_Negocio.InsertPrecioDeVentaPorProveedor(marca, redito, idusuarioLogueado, Estado);
                            if (Exito == true)
                            {
                                const string message2 = "Se registro el nuevo precio de venta exitosamente.";
                                const string caption2 = "Modificar precio por marca";
                                var result2 = MessageBox.Show(message2, caption2,
                                                             MessageBoxButtons.OK,
                                                             MessageBoxIcon.Asterisk);
                                LimpiarCampos();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            { }
        }
        private void LimpiarCampos()
        {
            txtReditoPorcentual.Clear();
            txtReditoPorcentual.Enabled = false;
            chcAumentar.Checked = false;
            chcBajar.Checked = false;
            chcProveedor.Checked = false;
            chcMarca.Checked = true;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            dgvProductos.Rows.Clear();
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
        private void PrecioModificacionMasivoWF_Load(object sender, EventArgs e)
        {

        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Green);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }       
    }
}
