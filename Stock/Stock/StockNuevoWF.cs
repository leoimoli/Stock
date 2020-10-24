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
                CargarCombo();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
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
        public void CargarCombo()
        {
            List<string> Marcas = new List<string>();
            Marcas = Negocio.Consultar.CargarComboProveedor();
            cmbProveedor.Items.Add("Seleccione");
            cmbProveedor.Items.Clear();
            foreach (string item in Marcas)
            {
                cmbProveedor.Text = "Seleccione";
                cmbProveedor.Items.Add(item);
            }
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorDescripcion.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCodigoBus_KeyDown(object sender, KeyEventArgs e)
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
}
