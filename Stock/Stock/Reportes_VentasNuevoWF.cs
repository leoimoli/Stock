using Stock.DAO;
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

namespace Stock
{
    public partial class Reportes_VentasNuevoWF : Form
    {
        public Reportes_VentasNuevoWF()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                DateTime FechaDesde = dtFechaDesde.Value.Date;
                DateTime FechaHasta = dtFechaHasta.Value.Date;
                ValidarFechas(FechaDesde, FechaHasta);
                resultado = Negocio.Consultar.ConsultarVentasPorFecha(FechaDesde, FechaHasta);
                if (resultado.Count > 0)
                {
                    PanelResultado.Visible = true;
                    decimal TotalVentas = 0;
                    foreach (var item in resultado)
                    {
                        string fecha = item.Fecha.ToShortDateString();
                        TotalVentas = Convert.ToDecimal(TotalVentas + item.PrecioVenta);
                        dgvVentas.Rows.Add(item.idVenta, fecha, item.PrecioVenta);
                    }
                    /// Total de Ventas                 
                    lblTotalVentas.Text = Convert.ToString(resultado.Count);
                    /// Caja de Ventas
                    List<Reporte_Ventas> listaVentas3 = new List<Reporte_Ventas>();
                    listaVentas3 = ReportesDao.CajaDeVentas();
                    lblCajaVentas.Text = Convert.ToString(TotalVentas);
                }
                else { PanelResultado.Visible = false; }
            }
            catch (Exception ex)
            { }


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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            dgvVentas.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvVentas.MultiSelect = true;
            dgvVentas.SelectAll();
            DataObject dataObj = dgvVentas.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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


