using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class PagosWF : Master
    {
        public PagosWF()
        {
            InitializeComponent();
        }
        private void PagosWF_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombos();
                //List<Entidades.PagosReducidos> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDePagos());
                ListaPagos = Negocio.Consultar.ListaDePagos();
                //ListaPagos = ListaReducidos;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        //private List<Entidades.PagosReducidos> CargarEntidadReducida(List<Entidades.Pagos> listaPagos)
        //{
        //    List<PagosReducidos> _pagoReducido = new List<PagosReducidos>();
        //    foreach (var item in listaPagos)
        //    {
        //        _pagoReducido.Add(new PagosReducidos { IdPago = item.IdPago, Monto = item.Monto, Proveedor = item.Proveedor, FechaDePago = item.FechaDePago });
        //    }
        //    return _pagoReducido;
        //}
        public List<Entidades.Pagos> ListaPagos
        {
            set
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;

                dataGridView1.Columns[0].HeaderText = "Nro.Pago";
                dataGridView1.Columns[0].Width = 70;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Forma";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[1].Visible = false;

                dataGridView1.Columns[2].HeaderText = "Cheque";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[2].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[2].Visible = false;

                dataGridView1.Columns[3].HeaderText = "Monto";
                dataGridView1.Columns[3].Width = 60;
                dataGridView1.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[3].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[4].HeaderText = "Proveedor";
                dataGridView1.Columns[4].Width = 70;
                dataGridView1.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[4].HeaderCell.Style.ForeColor = Color.White;


                dataGridView1.Columns[5].HeaderText = "Fecha";
                dataGridView1.Columns[5].Width = 60;
                dataGridView1.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[5].HeaderCell.Style.ForeColor = Color.White;

                dataGridView1.Columns[6].HeaderText = "Fecha2";
                dataGridView1.Columns[6].Width = 80;
                dataGridView1.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[6].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[6].Visible = false;

                dataGridView1.Columns[7].HeaderText = "Usuario";
                dataGridView1.Columns[7].Width = 70;
                dataGridView1.Columns[7].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[7].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[7].Visible = false;

                dataGridView1.Columns[8].HeaderText = "Usuario";
                dataGridView1.Columns[8].Width = 90;
                dataGridView1.Columns[8].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[8].HeaderCell.Style.ForeColor = Color.White;
            }
        }
        public void CargarCombos()
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
            string[] Perfiles = Clases_Maestras.ValoresConstantes.TipoDePago;
            cmbFormaPago.Items.Add("Seleccione");
            cmbFormaPago.Items.Clear();
            foreach (string item in Perfiles)
            {
                cmbFormaPago.Text = "Seleccione";
                cmbFormaPago.Items.Add(item);
            }
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            try
            {
                panel_RegistrarPago.Enabled = true;
                btnGuardar.Visible = true;
                btnCancelar.Visible = true;
            }
            catch (Exception ex) { }

        }
        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text == "CHEQUE")
            {
                txtCheque.Enabled = true;
            }
            else { txtCheque.Enabled = false; }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Pagos _pagos = CargarEntidad();
                ProgressBar();
                bool Exito = Negocio.Pagos.RegistrarPago(_pagos);
                if (Exito == true)
                {
                    MessageBox.Show("El pago se registro exitosamente.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
        }
        private void ProgressBar()
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100000;
            progressBar1.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                Caluculate(j);
                progressBar1.PerformStep();
            }
        }
        private void Caluculate(int i)
        {
            double pow = Math.Pow(i, i);
        }
        private void LimpiarCampos()
        {
            txtCheque.Clear();
            txtMonto.Clear();
            CargarCombos();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private Pagos CargarEntidad()
        {
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            Pagos _pagos = new Pagos();
            _pagos.FormaDePago = cmbFormaPago.Text;
            _pagos.NroCheque = txtCheque.Text;
            _pagos.Monto = Convert.ToDecimal(txtMonto.Text);
            DateTime fecha = dateTimePicker1.Value;
            _pagos.FechaDePago = fecha.ToShortDateString();
            _pagos.Proveedor = cmbProveedor.Text;
            _pagos.FechaIngreso = DateTime.Now;
            _pagos.idUsuario = idusuarioLogueado;
            return _pagos;
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}

