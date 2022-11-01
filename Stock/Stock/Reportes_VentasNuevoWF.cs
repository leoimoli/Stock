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
            LimpiarCampos();
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
        private void btnVentasDelDia_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasDelDia();
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
        private void SinResultados()
        {
            LimpiarCampos();
            const string message2 = "No se encontraron resultados disponibles.";
            const string caption2 = "Atención";
            var result2 = MessageBox.Show(message2, caption2,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Exclamation);
        }
        private void ArmoGrillaVentas(List<ListaVentas> resultado)
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
        private void btnVentasAyer_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DateTime FechaHasta = DateTime.Now;
            DateTime FechaDesde = FechaHasta.AddDays(-1);
            FechaHasta = FechaDesde;
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasDeAyer();
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
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasUltimosSieteDias(FechaDesde, FechaHasta);
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
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasUltimos30Dias(FechaDesde, FechaHasta);
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
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasMesAnterior(Mes);
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
            List<ListaVentas> resultado = new List<ListaVentas>();
            List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
            try
            {
                resultado = Negocio.Consultar.ConsultarVentasMesAnterior(Mes);
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
        private void LimpiarCampos()
        {
            lblCajaVentas.Text = "0";
            lblTotalVentas.Text = "0";
            dgvVentas.Rows.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewMasterWF _master = new NewMasterWF();
            _master.Show();
            Hide();
        }
        private void Reportes_VentasNuevoWF_Load(object sender, EventArgs e)
        {
            string perfil = Sesion.UsuarioLogueado.Perfil;
            if (perfil != "1" && perfil != "SUPER ADMIN")
            {
                btnEliminar.Visible = false;
            }
            else { btnEliminar.Visible = true; }
        }
        public static int idVenta;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<Entidades.HistorialProductoPrecioDeVenta> _precio = new List<Entidades.HistorialProductoPrecioDeVenta>();
            idVenta = Convert.ToInt32(this.dgvVentas.CurrentRow.Cells[0].Value);
            string msj = "ATENCIÓN: Usted desea eliminar la venta Nro: '" + idVenta + "'?";
            //const string message = msj;
            const string caption = "Consulta";
            var result = MessageBox.Show(msj, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            {
                if (result == DialogResult.Yes)
                {
                    bool exito = DAO.EditarDao.EliminarVenta(idVenta);
                    if (exito == true)
                    {
                        const string message2 = "Se elimino la venta exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                   else
                    {
                        const string message2 = "ATENCIÓN: No se pudo eliminar la venta.";
                        const string caption2 = "Atención";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
                else
                {

                }

            }
        }
    }
}





