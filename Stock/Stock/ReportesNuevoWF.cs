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
//using System.Windows.Forms.DataVisualization.Charting;

namespace Stock
{
    public partial class ReportesNuevoWF : Form
    {
        public ReportesNuevoWF()
        {
            InitializeComponent();
        }

        private void ReportesNuevoWF_Load(object sender, EventArgs e)
        {
            List<Reporte_Proveedores> listaProveedores = new List<Reporte_Proveedores>();
            List<Reporte_Ventas> listaVentas = new List<Reporte_Ventas>();


            ////// Grafico Proveedores
            listaProveedores = ReportesDao.BuscarTotalComprasRealizadasProveedores();
            if (listaProveedores.Count > 0)
            {
                DiseñoGraficoProveedores(listaProveedores);
            }

            ////// Grafico Ventas
            listaVentas = ReportesDao.BuscarVentasPorMes();
            if (listaVentas.Count > 0)
            {
                DiseñoGraficoVentas(listaVentas);
            }

            ////// Reportes Botones
            /// Total de Ventas
            List<Reporte_Ventas> listaVentas2 = new List<Reporte_Ventas>();
            listaVentas2 = ReportesDao.TotalDeVentas();
            lblTotalVentas.Text = Convert.ToString(listaVentas2[0].TotalDeVentasGenerales);
            /// Caja de Ventas
            List<Reporte_Ventas> listaVentas3 = new List<Reporte_Ventas>();
            listaVentas3 = ReportesDao.CajaDeVentas();
            lblTotalVentas.Text = Convert.ToString(listaVentas3[0].CajaDeVentas);
            /// Total de Compras
            List<Reporte_Compras> listaCompras = new List<Reporte_Compras>();
            listaCompras = ReportesDao.TotalDeCompras();
            lblTotalVentas.Text = Convert.ToString(listaCompras[0].TotalDeComprasGenerales);
            /// Pagos de Compras
            List<Reporte_Compras> listaCompras2 = new List<Reporte_Compras>();
            listaCompras2 = ReportesDao.PagosCompras();
            lblTotalVentas.Text = Convert.ToString(listaCompras2[0].CajaDePagos);
        }
        private void DiseñoGraficoVentas(List<Reporte_Ventas> listaVentas)
        {
            List<string> Mes = new List<string>();
            List<string> Total = new List<string>();
            String Año = DateTime.Now.Year.ToString();
            foreach (var item in listaVentas)
            {
                Mes.Add(item.mes);
                string total = Convert.ToString(item.TotalVentasPorMes);
                Total.Add(total);
            }
            chartVentas.Series[0].Points.DataBindXY(Mes, Total);
        }

        private void DiseñoGraficoProveedores(List<Reporte_Proveedores> listaProveedores)
        {
            List<string> Nombre = new List<string>();
            List<string> Total = new List<string>();
            foreach (var item in listaProveedores)
            {
                Nombre.Add(item.NombreEmpresa);
                string total = Convert.ToString(item.TotalCompras);
                Total.Add(total);
            }
            chartProveedores.Series[0].Points.DataBindXY(Nombre, Total);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
