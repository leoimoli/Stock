using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.Entidades;

namespace Stock
{
    public partial class HistorialPagoProveedoresWF : Form
    {
        private int idMovimiento;

        public HistorialPagoProveedoresWF(int idMovimiento)
        {
            InitializeComponent();
            this.idMovimiento = idMovimiento;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            VerDetalleMovimientoWF _ver = new VerDetalleMovimientoWF(idMovimiento, null, null, FacturaPaga);
            _ver.Show();
        }

        private void HistorialPagoProveedoresWF_Load(object sender, EventArgs e)
        {
            try
            {
                ConsultaMovimiento();
            }
            catch (Exception ex)
            { }
        }

        private void ConsultaMovimiento()
        {
            dgvProductos.Rows.Clear();
            List<Entidades.HistorialPagoProveedores> Lista = Negocio.Consultar.HistorialPagoAProveedores(idMovimiento);
            if (Lista.Count > 0)
            {
                string Fecha = "";
                foreach (var item in Lista)
                {
                    FacturaPaga = item.FacturaPaga;
                    Fecha = item.FechaPago.ToShortDateString();
                    if (item.FacturaPaga == 1)
                    {
                        lblMontoAdeudado.Text = "0";
                        btnPago.Enabled = false;
                    }
                    else
                    {
                        lblMontoAdeudado.Text = item.Monto.ToString("N", new CultureInfo("es-CL"));
                        btnPago.Enabled = true;
                    }

                    dgvProductos.Rows.Add(" ", Fecha, item.Monto, item.NombreUsuario);
                    break;
                }
            }
            if (Lista.Count > 1)
            {
                int ContadorElementos = 0;
                for (int item = 1; item < Lista.Count; item++)
                {
                    ContadorElementos = ContadorElementos + 1;
                    if (ContadorElementos == 1)
                    {
                        if (Lista[item].MontoAdeudado > 0)
                        {
                            btnPago.Enabled = true;
                        }
                        else
                        { btnPago.Enabled = false; }
                        lblMontoAdeudado.Text = Lista[item].MontoAdeudado.ToString("N", new CultureInfo("es-CL"));
                    }
                    dgvProductos.Rows.Add(Lista[item].idHistorial, Lista[item].FechaPago, Lista[item].Monto, Lista[item].NombreUsuario);
                }
            }
        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            // solo 1 punto decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
            //e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            grbRegistroPago.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.HistorialPagoProveedores _pago = CargarEntidad();
                bool Exito = Negocio.Proveedores.InsertarPagoAProveedores(_pago);
                if (Exito == true)
                {
                    ProgressBar();
                    const string message2 = "Se registro el pago a proveedor exitosamente.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Asterisk);
                    LimpiarCampos();
                    RecalcularMonto(_pago.Monto);
                }
            }
            catch (Exception ex)
            { }
        }

        private void RecalcularMonto(decimal Monto)
        {
            decimal MontoActual = Convert.ToDecimal(lblMontoAdeudado.Text);
            decimal MontoRecalculado = MontoActual - Monto;
            lblMontoAdeudado.Text = MontoRecalculado.ToString("N", new CultureInfo("es-CL"));
            ConsultaMovimiento();
        }

        private void LimpiarCampos()
        {
            grbRegistroPago.Enabled = false;
            txtMonto.Clear();
            dtFecha.Value = DateTime.Now;
            textBox2.Clear();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
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
        public static int FacturaPaga;
        private HistorialPagoProveedores CargarEntidad()
        {
            HistorialPagoProveedores _historialPago = new HistorialPagoProveedores();
            _historialPago.FechaPago = dtFecha.Value;
            _historialPago.Monto = Convert.ToDecimal(txtMonto.Text);
            _historialPago.Descripcion = textBox2.Text;
            _historialPago.idUsuario = Sesion.UsuarioLogueado.IdUsuario;
            _historialPago.idMovimiento = idMovimiento;
            DateTime fechaActual = DateTime.Now;
            _historialPago.FechaRegistro = fechaActual;
            decimal MontoAdeudado = Convert.ToDecimal(lblMontoAdeudado.Text);
            decimal MontoActual = Convert.ToDecimal(txtMonto.Text);
            _historialPago.MontoAdeudado = MontoAdeudado - MontoActual;
            if (_historialPago.MontoAdeudado == 0)
            {
                _historialPago.FacturaPaga = 1;
            }
            FacturaPaga = _historialPago.FacturaPaga;
            return _historialPago;
        }
    }
}
