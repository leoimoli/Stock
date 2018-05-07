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
            }
        }
        private void chcUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chcUsuario.Checked == true)
            {
                chcFecha.Checked = false;
                chcCliente.Checked = false;
            }
        }
        private void chcCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chcCliente.Checked == true)
            {
                chcFecha.Checked = false;
                chcUsuario.Checked = false;
            }
        }
    }
}
