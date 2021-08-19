using Stock.Negocio;
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
    public partial class DetallaVentaWF : Form
    {
        private int idOferta;

        public DetallaVentaWF(int idOferta)
        {
            InitializeComponent();
            this.idOferta = idOferta;
        }

        private void DetallaVentaWF_Load(object sender, EventArgs e)
        {
            dgvOfertas.Rows.Clear();
            List<Entidades.DetalleOferta> ListarProductos = OfertasNeg.BuscarDetalleOferta(idOferta);
            if (ListarProductos.Count > 0)
            {
                dgvOfertas.Visible = true;
                foreach (var item in ListarProductos)
                {
                    lblValor.Text = Convert.ToString(item.PrecioOferta);
                    dgvOfertas.Rows.Add(item.idProducto, item.CodigoProducto, item.Descripcion, item.Unidades);
                }
                dgvOfertas.AllowUserToAddRows = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
