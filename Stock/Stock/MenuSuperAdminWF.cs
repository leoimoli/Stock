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
    public partial class MenuSuperAdminWF : Master
    {
        public MenuSuperAdminWF()
        {
            InitializeComponent();
        }

        private void MenuSuperAdminWF_Load(object sender, EventArgs e)
        {

        }

        private void btnCargaMasiva_Click(object sender, EventArgs e)
        {
            CargaMasivaDeProductosWF _carga = new CargaMasivaDeProductosWF();
            _carga.Show();
            Hide();
        }

        private void btnActualizarCodigos_Click(object sender, EventArgs e)
        {
            ActualizarCodigoProductoWF _actualizar = new ActualizarCodigoProductoWF();
            _actualizar.Show();
            Hide();
        }
    }
}
