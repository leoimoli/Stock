using Stock.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Reflection;

namespace Stock
{
    public partial class Reporte_VentasWF : Master2
    {
        public Reporte_VentasWF()
        {
            InitializeComponent();
        }

        private void Reporte_VentasWF_Load(object sender, EventArgs e)
        {
            grbFiltros.Text = "Filtros";
        }
        private void chcFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtDni.Clear();
            if (chcFecha.Checked == true)
            {
                chcUsuario.Checked = false;
                txtDni.Enabled = false;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
                button1.Visible = true;
            }
        }
        private void chcUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUsuario.Checked == true)
            {
                chcFecha.Checked = false;
                txtDni.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                txtDni.Focus();
                button1.Visible = true;
            }
        }
        private void fillChart(string[] series1, List<ListaVentasEstadistica> Lista)
        {
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            foreach (var item in Lista)
            {
                chart1.Series[nombreNuevaSerie].Points.AddXY(item.mes, item.TotalVentasPorMes);
            }

        }
        private void ValidarFechas(DateTime fechaDesde, DateTime fechaHasta)
        {
            if (fechaDesde > fechaHasta)
            {
                const string message = "La fecha desde no puede ser mayor a la fecha hasta.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
        public List<Entidades.ListaVentas> Lista
        {
            set
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "Nro.Venta";
                dataGridView1.Columns[0].Width = 65;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = System.Drawing.Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = System.Drawing.Color.White;
                ////dataGridView1.Columns[0].Visible = true;

                dataGridView1.Columns[1].HeaderText = "Fecha";
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = System.Drawing.Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = System.Drawing.Color.White;

                dataGridView1.Columns[2].HeaderText = "Monto";
                dataGridView1.Columns[2].Width = 65;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = System.Drawing.Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = System.Drawing.Color.White;

                dataGridView1.Columns[3].HeaderText = "Usuario";
                dataGridView1.Columns[3].Width = 95;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = System.Drawing.Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = System.Drawing.Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Entidades.ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                if (chcUsuario.Checked == true)
                {
                    chart1.Series.Clear();

                    string dniUsuario = txtDni.Text;
                    Lista = resultado = Negocio.Consultar.ConsultarVentasPorUsuario(dniUsuario);
                    if (resultado.Count > 0)
                    {
                        btnExcel.Visible = true;
                        lblTotal1.Visible = true;
                        lblTotal2.Visible = true;
                        lblTotal2.Text = Convert.ToString(resultado.Count);
                        listaVentasEstadistica = Negocio.Consultar.ConsultarVentasPorUsuarioEstadistica(dniUsuario);
                        string[] series1 = { "Ventas" };
                        fillChart(series1, listaVentasEstadistica);
                    }
                    else
                    {
                        lblTotal1.Visible = true;
                        lblTotal2.Visible = true;
                        lblTotal2.Text = Convert.ToString(0);
                        chart1.Series.Clear();
                    }
                }
                else
                {
                    if (chcFecha.Checked == true)
                    {
                        DateTime FechaDesde = dateTimePicker1.Value.Date;
                        DateTime FechaHasta = dateTimePicker2.Value.Date;
                        ValidarFechas(FechaDesde, FechaHasta);
                        Lista = resultado = Negocio.Consultar.ConsultarVentasPorFecha(FechaDesde, FechaHasta);
                        if (resultado.Count > 0)
                        {
                            btnExcel.Visible = true;
                            lblTotal1.Visible = true;
                            lblTotal2.Visible = true;
                            lblTotal2.Text = Convert.ToString(resultado.Count);
                            listaVentasEstadistica = Negocio.Consultar.ConsultarVentasPorFechaEstadistica(FechaDesde, FechaHasta);
                            string[] series1 = { "Ventas" };
                            fillChart(series1, listaVentasEstadistica);
                        }
                        else
                        {
                            lblTotal1.Visible = true;
                            lblTotal2.Visible = true;
                            lblTotal2.Text = Convert.ToString(0);
                            chart1.Series.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            { }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();

            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            //Open an excel instance and paste the copied data
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
