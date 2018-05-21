using Stock.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Reporte_ComprasWF : Master2
    {
        public Reporte_ComprasWF()
        {
            InitializeComponent();
        }
        private void Reporte_ComprasWF_Load(object sender, EventArgs e)
        {
            CargarComboProveedor();
        }
        private void CargarComboProveedor()
        {
            List<string> Proveedor = new List<string>();
            Proveedor = Negocio.Consultar.CargarComboProveedor();
            cmbProveedor.Items.Add("Seleccione");
            cmbProveedor.Items.Clear();
            foreach (string item in Proveedor)
            {
                cmbProveedor.Text = "Seleccione";
                cmbProveedor.Items.Add(item);
            }
        }
        private void chcFecha_CheckedChanged(object sender, EventArgs e)
        {
            txtRemito.Clear();
            if (chcFecha.Checked == true)
            {
                chcPorRemito.Checked = false;
                chcProveedor.Checked = false;
                cmbProveedor.Enabled = false;
                txtRemito.Enabled = false;
                dtFechaDesde.Enabled = true;
                dtFechaHasta.Enabled = true;
                btnBuscar.Visible = true;
            }
        }
        private void chcProveedor_CheckedChanged(object sender, EventArgs e)
        {
            txtRemito.Clear();
            if (chcProveedor.Checked == true)
            {
                chcPorRemito.Checked = false;
                chcFecha.Checked = false;
                cmbProveedor.Enabled = true;
                txtRemito.Enabled = false;
                dtFechaDesde.Enabled = false;
                dtFechaHasta.Enabled = false;
                btnBuscar.Visible = true;
            }
        }
        private void chcPorRemito_CheckedChanged(object sender, EventArgs e)
        {
            txtRemito.Clear();
            if (chcPorRemito.Checked == true)
            {
                chcProveedor.Checked = false;
                chcFecha.Checked = false;
                cmbProveedor.Enabled = false;
                txtRemito.Enabled = true;
                dtFechaDesde.Enabled = false;
                dtFechaHasta.Enabled = false;
                txtRemito.Focus();
                btnBuscar.Visible = true;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                chart1.Series.Clear();
                List<Entidades.ListaCompras> resultado = new List<ListaCompras>();
                List<Entidades.ListaComprasEstadistica> listaComprasEstadistica = new List<ListaComprasEstadistica>();
                if (chcFecha.Checked == true)
                {
                    DateTime FechaDesde = dtFechaDesde.Value.Date;
                    DateTime FechaHasta = dtFechaHasta.Value.Date;
                    ValidarFechas(FechaDesde, FechaHasta);
                    Lista = resultado = Negocio.Consultar.ConsultarComprasPorFecha(FechaDesde, FechaHasta);
                    if (resultado.Count > 0)
                    {
                        lblTotal1.Visible = true;
                        lblTotal2.Visible = true;
                        lblTotal2.Text = Convert.ToString(resultado.Count);
                        listaComprasEstadistica = Negocio.Consultar.ConsultarComprasPorFechaEstadistica(FechaDesde, FechaHasta);
                        string[] series1 = { "Compras" };
                        fillChart(series1, listaComprasEstadistica);
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
                    if (chcProveedor.Checked == true)
                    {
                        string Proveedor = cmbProveedor.Text;
                        Lista = new List<ListaCompras>();
                        Lista = resultado = Negocio.Consultar.ConsultarComprasPorProveedor(Proveedor);
                        if (resultado.Count > 0)
                        {
                            lblTotal1.Visible = true;
                            lblTotal2.Visible = true;
                            lblTotal2.Text = Convert.ToString(resultado.Count);
                            listaComprasEstadistica = Negocio.Consultar.ConsultarComprasPorProveedorEstadistica(Proveedor);
                            string[] series1 = { "Compras" };
                            fillChart(series1, listaComprasEstadistica);
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
                        if (chcPorRemito.Checked == true)
                        {
                            string Remito = txtRemito.Text;
                            Lista = new List<ListaCompras>();
                            Lista = resultado = Negocio.Consultar.ConsultarComprasPorRemito(Remito);
                            if (resultado.Count > 0)
                            {
                                lblTotal1.Visible = true;
                                lblTotal2.Visible = true;
                                lblTotal2.Text = Convert.ToString(resultado.Count);
                                listaComprasEstadistica = Negocio.Consultar.ConsultarComprasPorRemitoEstadistica(Remito);
                                string[] series1 = { "Compras" };
                                fillChart(series1, listaComprasEstadistica);
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
            }
            catch (Exception ex)
            { }
        }
        private void fillChart(string[] series1, List<ListaComprasEstadistica> Lista)
        {
            chart1.Series.Clear();
            string nombreNuevaSerie = series1[0].ToString();
            chart1.Series.Add(nombreNuevaSerie);
            foreach (var item in Lista)
            {
                chart1.Series[nombreNuevaSerie].Points.AddXY(item.mes, item.TotalComprasPorMes);
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
        public List<Entidades.ListaCompras> Lista
        {
            set
            {
                List<Entidades.ListaCompras> resultado = new List<ListaCompras>();
                DataGridViewLinkColumn seleccionar = new DataGridViewLinkColumn();
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "Nro.Compra";
                dataGridView1.Columns[0].Width = 65;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Fecha";
                dataGridView1.Columns[1].Width = 70;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[2].HeaderText = "Código Producto";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[3].HeaderText = "Proveedor";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                DataGridViewButtonColumn BotonSeleccionar = new DataGridViewButtonColumn();
                BotonSeleccionar.Name = "Ver";
                BotonSeleccionar.HeaderText = "Ver";
                this.dataGridView1.Columns.Add(BotonSeleccionar);
                dataGridView1.Columns[4].Width = 60;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 10, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;
            }

        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Ver" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celBoton = this.dataGridView1.Rows[e.RowIndex].Cells["Ver"] as DataGridViewButtonCell;
                string reemplazarDebug = "bin\\Debug\\";
                string reemplazarRelease = "bin\\Release\\";
                string pathBase = Properties.Settings.Default.Imagen;
                string path = pathBase + "\\" + "Seleccionar.ico";
                path = path.Replace(reemplazarDebug, string.Empty);
                path = path.Replace(reemplazarRelease, string.Empty);
                Icon icoAtomico = new Icon(path);

                e.Graphics.DrawIcon(icoAtomico, e.CellBounds.Left + 25, e.CellBounds.Top + 3);
                this.dataGridView1.Rows[e.RowIndex].Height = icoAtomico.Height + 5;
                e.Handled = true;
            }
        }
        private void ClickBoton(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 4)
            {
                //var idCliente = Convert.ToString(this.dgvListaDeClientes.CurrentRow.Cells[0].Value);
                //var NombreRazonSocial = Convert.ToString(this.dgvListaDeClientes.CurrentRow.Cells[1].Value);
                //var Cuit = Convert.ToString(this.dgvListaDeClientes.CurrentRow.Cells[2].Value);
                //EjerciciosCliente _ejercicio = new EjerciciosCliente(idCliente, NombreRazonSocial, Cuit, 0, "", "");
                //Close();
                //_ejercicio.ShowDialog();
            }
        }
    }
}
