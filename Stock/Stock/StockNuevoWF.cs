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
    public partial class StockNuevoWF : Form
    {
        public StockNuevoWF()
        {
            InitializeComponent();
        }

        private void StockNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionListarProductos();
                FuncionBuscartexto();
                FuncionListaMovimientos();
            }
            catch (Exception ex)
            { }
        }

        private void FuncionListaMovimientos()
        {
            dgvMovimientos.Rows.Clear();
            List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ConsultarUltimosIngresosDeStock();
            if (ListaProductos.Count > 0)
            {
                foreach (var item in ListaProductos)
                {
                    string Fecha = item.FechaIngreso.ToShortDateString();
                    dgvMovimientos.Rows.Add(item.idProducto, Fecha, item.Proveedor);
                }
                lblTotal.Visible = true;
                lblTotalEdit.Visible = true;
                lblTotalEdit.Text = Convert.ToString(ListaProductos.Count);
            }
            dgvProductos.ReadOnly = true;
        }
        private void FuncionListarProductos()
        {
            FuncionBuscartexto();
            dgvProductos.Rows.Clear();
            List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListaDeStock();
            if (ListaProductos.Count > 0)
            {
                foreach (var item in ListaProductos)
                {
                    dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.NombreProducto, item.Cantidad);
                }
            }
            dgvProductos.ReadOnly = true;
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvProductos.Rows.Clear();
                string Descripcion = txtDescipcionBus.Text;

                List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListaStockPorDescripcion(Descripcion);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.NombreProducto, item.Cantidad);
                    }
                }
                dgvProductos.ReadOnly = true;
            }

        }

        private void txtCodigoBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvProductos.Rows.Clear();
                string Codigo = txtCodigoBus.Text;

                List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ListaStockPorCodigoProducto(Codigo);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        dgvProductos.Rows.Add(item.idProducto, item.CodigoProducto, item.NombreProducto, item.Cantidad);
                    }
                }
                dgvProductos.ReadOnly = true;
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            RegistroStockWF _registro = new RegistroStockWF();
            _registro.Show();
        }
        private void btnVer_Click(object sender, EventArgs e)
        {
            int idMovimiento = Convert.ToInt32(dgvMovimientos.CurrentRow.Cells[0].Value.ToString());
            string Fecha = dgvMovimientos.CurrentRow.Cells[1].Value.ToString();
            string Proveedor = dgvMovimientos.CurrentRow.Cells[2].Value.ToString();
            this.WindowState = FormWindowState.Minimized;
            VerDetalleMovimientoWF _ver = new VerDetalleMovimientoWF(idMovimiento, Fecha, Proveedor);
            _ver.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Desde = "";
            string Hasta = "";
            if (txtDesde.Text != "")
            {
                Boolean Validacion = EsFecha(txtDesde.Text);
                if (Validacion == true)
                {
                    Desde = txtDesde.Text;
                }
                else
                {
                    const string message2 = "La fecha Desde ingresada es invalida.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
            }
            if (txtHasta.Text != "")
            {
                Boolean Validacion = EsFecha(txtHasta.Text);
                if (Validacion == true)
                {
                    Hasta = txtHasta.Text;
                }
                else
                {
                    const string message2 = "La fecha Hasta ingresada es invalida.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                }
            }
            if (Desde != "" & Hasta != "")
            {
                dgvMovimientos.Rows.Clear();
                List<Entidades.ListaStock> ListaProductos = Negocio.Consultar.ConsultarIngresosDeStockPorFecha(Desde, Hasta);
                if (ListaProductos.Count > 0)
                {
                    foreach (var item in ListaProductos)
                    {
                        string Fecha = item.FechaIngreso.ToShortDateString();
                        dgvMovimientos.Rows.Add(item.idProducto, Fecha, item.Proveedor);
                    }
                    lblTotal.Visible = true;
                    lblTotalEdit.Visible = true;
                    lblTotalEdit.Text = Convert.ToString(ListaProductos.Count);
                }
                else
                {
                    const string message2 = "No se encontro información cargada para la fecha ingresada.";
                    const string caption2 = "Atención";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                    lblTotal.Visible = true;
                    lblTotalEdit.Visible = true;
                    lblTotalEdit.Text = Convert.ToString(0);
                }
                dgvProductos.ReadOnly = true;
            }
        }
        public static Boolean EsFecha(String fecha)
        {
            try
            {
                DateTime.Parse(fecha);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
