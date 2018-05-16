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
            if (chcFecha.Checked == true)
            {
                chcUsuario.Checked = false;
                groupBox6.Visible = true;
                groupBox3.Visible = false;
                btnBuscarPorFecha.Visible = true;
            }
        }
        private void chcUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUsuario.Checked == true)
            {
                chcFecha.Checked = false;
                groupBox6.Visible = false;
                groupBox3.Visible = true;
                btnBuscarPorUsuario.Visible = true;
                textBox1.Focus();
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
                MessageBox.Show("LA FECHA DESDE NO PUEDE SER MAYOR A LA FECHA HASTA");
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
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                ////dataGridView1.Columns[0].Visible = true;

                dataGridView1.Columns[1].HeaderText = "Fecha";
                dataGridView1.Columns[1].Width = 90;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Monto";
                dataGridView1.Columns[2].Width = 65;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Usuario";
                dataGridView1.Columns[3].Width = 95;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;
            }

        }
        private void btnBuscarPorUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                List<Entidades.ListaVentas> resultado = new List<ListaVentas>();
                List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
                if (chcUsuario.Checked == true)
                {
                  
                    string dniUsuario = textBox1.Text;
                    Lista = resultado = Negocio.Consultar.ConsultarVentasPorUsuario(dniUsuario);
                    if (resultado.Count > 0)
                    {
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
            }
            catch (Exception ex)
            { }
        }
        private void btnBuscarPorFecha_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series.Clear();
                List<Entidades.ListaVentas> resultado = new List<ListaVentas>();
                List<Entidades.ListaVentasEstadistica> listaVentasEstadistica = new List<ListaVentasEstadistica>();
                if (chcFecha.Checked == true)
                {
                    DateTime FechaDesde = dateTimePicker1.Value.Date;
                    DateTime FechaHasta = dateTimePicker2.Value.Date;
                    ValidarFechas(FechaDesde, FechaHasta);
                    Lista = resultado = Negocio.Consultar.ConsultarVentasPorFecha(FechaDesde, FechaHasta);
                    if (resultado.Count > 0)
                    {
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
            catch (Exception ex)
            { }
        }
    }
}
