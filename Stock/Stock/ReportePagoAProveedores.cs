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
    public partial class ReportePagoAProveedores : Form
    {
        public ReportePagoAProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void ArmoGrillaVentas(List<ListaCompras> resultado)
        {
            PanelResultado.Visible = true;
            decimal TotalCompras = 0;
            foreach (var item in resultado)
            {
                string fecha = item.Fecha.ToShortDateString();
                TotalCompras = Convert.ToDecimal(TotalCompras + item.MontoTotal);
                dgvCompras.Rows.Add(item.idCompra, item.Proveedor, fecha, item.MontoTotal);
            }
            /// Total de Ventas                 
            lblTotalVentas.Text = Convert.ToString(resultado.Count);
            /// Caja de Ventas
            List<Reporte_Ventas> listaVentas3 = new List<Reporte_Ventas>();
            listaVentas3 = ReportesDao.CajaDeVentas();
            lblCajaVentas.Text = Convert.ToString(TotalCompras);
        }
        private void SinResultados()
        {
            LimpiarCampos();
            const string message2 = "No se encontraron resultados disponibles.";
            const string caption2 = "Atención";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
        }
        private void LimpiarCampos()
        {
            lblCajaVentas.Text = "0";
            lblTotalVentas.Text = "0";
            dgvCompras.Rows.Clear();
        }
        private void btnVentasDelDia_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaComprasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasDelDia();
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                {
                    SinResultados();
                }
            }
            catch (Exception ex)
            { }
        }
        private void btnVentasAyer_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DateTime FechaHasta = DateTime.Now;
            DateTime FechaDesde = FechaHasta.AddDays(-1);
            FechaHasta = FechaDesde;
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasDeAyer();
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                { SinResultados(); }
            }
            catch (Exception ex)
            { }
        }
        private void btnVentasUltimosSiete_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DateTime FechaHasta = DateTime.Now;
            DateTime FechaDesde = FechaHasta.AddDays(-7);
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasUltimosSieteDias(FechaDesde, FechaHasta);
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                { SinResultados(); }
            }
            catch (Exception ex)
            { }
        }
        private void btnUltimosTreinta_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DateTime FechaHasta = DateTime.Now;
            DateTime FechaDesde = FechaHasta.AddDays(-30);
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasUltimos30Dias(FechaDesde, FechaHasta);
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                { SinResultados(); }
            }
            catch (Exception ex)
            { }
        }
        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            String MesAnterior = DateTime.Now.Month.ToString();
            int Mes = Convert.ToInt32(MesAnterior);
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasMesAnterior(Mes);
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                { SinResultados(); }
            }
            catch (Exception ex)
            { }
        }
        private void btnVentasMesAnterior_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            String MesAnterior = DateTime.Now.Month.ToString();
            int Mes = Convert.ToInt32(MesAnterior);
            Mes = Mes - 1;
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarComprasMesAnterior(Mes);
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else
                { SinResultados(); }
            }
            catch (Exception ex)
            { }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            List<ListaCompras> resultado = new List<ListaCompras>();
            List<Entidades.ListaComprasEstadistica> listaVentasEstadistica = new List<ListaComprasEstadistica>();
            try
            {
                DateTime FechaDesde = dtFechaDesde.Value.Date;
                DateTime FechaHasta = dtFechaHasta.Value.Date;
                ValidarFechas(FechaDesde, FechaHasta);
                resultado = Negocio.Consultar.ConsultarComprasReportePorFecha(FechaDesde, FechaHasta);
                if (resultado.Count > 0)
                {
                    ArmoGrillaVentas(resultado);
                }
                else { }
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
        private void btnExportar_Click(object sender, EventArgs e)
        {
            dgvCompras.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvCompras.MultiSelect = true;
            dgvCompras.SelectAll();
            DataObject dataObj = dgvCompras.GetClipboardContent();
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
