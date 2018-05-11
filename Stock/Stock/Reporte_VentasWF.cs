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

                chcCliente.Checked = false;
                chcUsuario.Checked = false;
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                btnBuscar.Visible = true;
            }
        }
        private void chcUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUsuario.Checked == true)
            {
                chcFecha.Checked = false;
                chcCliente.Checked = false;
                groupBox2.Visible = true;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                txtDni.Focus();
                btnBuscarPorUsuario.Visible = true;
            }
        }
        private void chcCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCliente.Checked == true)
            {
                chcFecha.Checked = false;
                chcUsuario.Checked = false;
                groupBox3.Visible = true;
                groupBox2.Visible = false;
                groupBox1.Visible = false;
                txtDni.Focus();
                btnBuscarPorCliente.Visible = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entidades.ListaVentas> resultado = new List<ListaVentas>();
                DateTime FechaDesde = dtFechaDesde.Value.Date;
                DateTime FechaHasta = dtFechaHasta.Value.Date;
                ValidarFechas(FechaDesde, FechaHasta);
                Lista = resultado = Negocio.Consultar.ConsultarVentasPorFecha(FechaDesde, FechaHasta);

                var stores = from store in resultado
                                                group store by new
                                                {
                                                    store.Fecha.Month,
                                                    store.Fecha.Year
                                                }
                                                into g
                                                select new
                                                {
                                                    g.Key,
                                                    cantidad = g.Count()
                                                };



                //from student in resultado
                //group student.Fecha.Month & student.Fecha.Year by student.Fecha.Year into ResultadoGroup;


                //List<Entidades.ListaVentas> a =  resultado.GroupBy(x => x.Fecha.Month).ToList();
                //var b = a.GroupBy(x => x.Fecha.Year).ToList();

                List<ObjetoResultado> cantidadesMeses = new List<ObjetoResultado>();
                //#region consulta por mew
                //ObjetoResultado obj = new ObjetoResultado();
                //foreach (var item in resultado)
                //{

                //    switch (item.Fecha.Month)
                //    {
                //        case 1:


                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month;
                //                obj.anio = item.Fecha.Year;
                //                obj.nombre = "ENERO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }

                //            break;
                //        case 2:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month;
                //                obj.anio = item.Fecha.Year;
                //                obj.nombre = "FEBRERO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 3:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "MARZO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 4:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "ABRIL";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 5:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "MAYO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 6:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "JUNIO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 7:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "JULIO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 8:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "AGOSTO";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 9:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "SEPTIEMBRE";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 10:
                //            if (obj.cantidad == 0)
                //            {
                //                obj = new ObjetoResultado();
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "OCTUBRE";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 11:
                //            if (obj.cantidad == 0)
                //            {
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "NOVIEMBRE";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //        case 12:
                //            if (obj.cantidad == 0)
                //            {
                //                obj.cantidad++;
                //                obj.mes = item.Fecha.Month; obj.anio = item.Fecha.Year;
                //                obj.nombre = "DICIEMBRE";
                //                cantidadesMeses.Add(obj);
                //            }
                //            else
                //            {
                //                cantidadesMeses.Where(x => x.mes == item.Fecha.Month).LastOrDefault().cantidad = obj.cantidad++;
                //            }
                //            break;
                //    }
                //}
                //#endregion
                string[] series1 = { "Ventas" };
                // fillChart(series1, Lista);
            }
            catch { }
        }
        private void fillChart(string[] series1, List<ListaVentas> Lista)
        {
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            foreach (var item in Lista)
            {
                //chart1.Series[nombreNuevaSerie].Points.AddXY(item.mes, item.TotalCompras);
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

        private class ObjetoResultado
        {
            public int mes { get; set; }
            public int anio { get; set; }            
            public int cantidad { get; set; }
        }
    }
}
