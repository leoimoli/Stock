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
    public partial class ProveedoresNuevoWF : Form
    {
        public ProveedoresNuevoWF()
        {
            InitializeComponent();
        }
        private void ProveedoresNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionListarproveedores();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteProveedores.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void FuncionListarproveedores()
        {
            FuncionBuscartexto();
            dgvProveedores.Rows.Clear();
            List<Entidades.Proveedores> ListaProveedores = Negocio.Consultar.ListaDeProveedores();
            if (ListaProveedores.Count > 0)
            {
                foreach (var item in ListaProveedores)
                {
                    string Calle = item.Calle;
                    string Altura = item.Altura;
                    string Domicilio = Calle + "N° " + item.Altura;
                    dgvProveedores.Rows.Add(item.idProveedor, item.NombreEmpresa, Domicilio, item.Telefono);
                }
            }
            dgvProveedores.ReadOnly = true;
        }
    }
}
