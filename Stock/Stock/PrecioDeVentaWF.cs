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
    public partial class PrecioDeVentaWF : Master
    {
        public PrecioDeVentaWF()
        {
            InitializeComponent();
        }

        private void PrecioDeVentaWF_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    string codigoIngresado = txtCodigo.Text;
                    int idProducto = Negocio.Consultar.BuscarProductoPorCodigo(codigoIngresado);
                    if (idProducto > 0)
                    {
                        List<HistorialProductoPrecioDeVenta> Lista = new List<HistorialProductoPrecioDeVenta>();
                        Lista = Negocio.Consultar.HistorialPrecioDeVenta(idProducto);
                        //txtCodigoProducto.Text = codigoIngresado;
                        //txtCodigoProducto.Enabled = false;
                        /////// Armo una nueva lista para mostrar en el panel Información.
                        //List<ListaStockProducto> _lista = new List<ListaStockProducto>();
                        //_lista = Negocio.Consultar.ListarStockProdcuto(idProducto);
                        //if (_lista.Count > 0)
                        //{
                        //    lblEstadisticas.Text = "Información del producto ingresado";
                        //    lblInformacion.Visible = false;
                        //    var lista = _lista.First();
                        //    txtMarca.Text = lista.Marca;
                        //    txtNombreProducto.Text = lista.NombreProducto;
                        //    txtMarca.Enabled = false;
                        //    txtNombreProducto.Enabled = false;
                        //    HabilitarLabels();
                        //    EditCódigo_Producto.Text = lista.CodigoProducto;
                        //    EditNombre_Producto.Text = lista.NombreProducto;
                        //    EditMarca_Producto.Text = lista.Marca;
                        //    EditStock_Disponible.Text = Convert.ToString(lista.Cantidad);
                        //    EditPrecio_de_Venta.Text = Convert.ToString(lista.PrecioVenta);
                        //    EditFecha_Alta_Producto.Text = Convert.ToString(lista.FechaAlta);
                        //    EditUsuario_Creador.Text = lista.Apellido + "  " + lista.Nombre;
                    }
                }
                catch { }
            }
            //else
            //{
            //    if (MessageBox.Show("Desea agregar un nuevo producto ?", "Producto Inexistente", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
            //    {
            //        Producto _producto = new Producto();
            //        _producto.Show();
            //        Hide();
            //    }
            //}
        }
    }
    #endregion
}
