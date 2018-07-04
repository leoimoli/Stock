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
    public partial class ClientesWF : Master
    {
        public ClientesWF()
        {
            InitializeComponent();
        }
        private void ClientesWF_Load(object sender, EventArgs e)
        {
            try
            {
                List<Entidades.ClienteReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeClientes());
                ListaClientes = ListaReducidos;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private List<Entidades.ClienteReducido> CargarEntidadReducida(List<Clientes> listaClientes)
        {
            List<Entidades.ClienteReducido> _clienteReducido = new List<ClienteReducido>();
            foreach (var item in listaClientes)
            {
                _clienteReducido.Add(new ClienteReducido { IdUsuario = item.IdCliente, Usuario = item.Dni + ", " + item.Apellido + " " + item.Nombre });
            }
            return _clienteReducido;
        }
        public List<Entidades.ClienteReducido> ListaClientes
        {
            set
            {
                lblUltimoMovimientosUsuarios.Text = "Listado de Clientes:";
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.DataSource = value;
                var contadortotal = value.Count;
                lblTotal.Visible = true;
                label6.Visible = true;
                lblTotal.Text = Convert.ToString(contadortotal);

                dataGridView1.Columns[0].HeaderText = "id Cliente";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView1.Columns[0].Visible = false;

                dataGridView1.Columns[1].HeaderText = "Cliente";
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView1.Columns[1].HeaderCell.Style.ForeColor = Color.White;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                { }
                int idUsuarioSeleccionado = id;

                if (idUsuarioSeleccionado > 0)
                {
                    panel_Clientes.Enabled = false;
                    Entidades.Clientes _cliente = CargarEntidadEdicion();
                    ProgressBar();
                    bool Exito = Negocio.Clientes.EditarCliente(_cliente, idUsuarioSeleccionado);
                    if (Exito == true)
                    {
                        const string message2 = "La edición del cliente se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                }
                else
                {
                    panel_Clientes.Enabled = false;
                    Entidades.Clientes _cliente = CargarEntidad();
                    ProgressBar();
                    bool Exito = Negocio.Clientes.CargarCliente(_cliente);
                    if (Exito == true)
                    {
                        const string message2 = "Se registro el cliente exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                    }
                    else
                    {
                        HabilitarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private Clientes CargarEntidadEdicion()
        {

            Clientes _clientes = new Clientes();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _clientes.idUsuario = idusuarioLogueado;
            _clientes.Dni = txtDni.Text;
            _clientes.Sexo = cmbSexo.Text;
            _clientes.Apellido = txtApellido.Text;
            _clientes.Nombre = txtNombre.Text;
            _clientes.Email = txtEmail.Text;
            _clientes.Telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            _clientes.Calle = txtCalle.Text;
            _clientes.Altura = txtAltura.Text;
            return _clientes;
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtCodArea.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtCalle.Clear();
            txtAltura.Clear();
            DateTime fecha = DateTime.Now;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            cmbSexo.Enabled = true;
            CargarCombo();
        }
        private Clientes CargarEntidad()
        {
            Clientes _clientes = new Clientes();
            int idusuarioLogueado = Sesion.UsuarioLogueado.IdUsuario;
            _clientes.idUsuario = idusuarioLogueado;
            _clientes.Dni = txtDni.Text;
            _clientes.Sexo = cmbSexo.Text;
            _clientes.Apellido = txtApellido.Text;
            _clientes.Nombre = txtNombre.Text;
            _clientes.Email = txtEmail.Text;
            _clientes.Telefono = txtCodArea.Text + "-" + txtTelefono.Text;
            DateTime fechaActual = DateTime.Now;
            _clientes.FechaDeAlta = fechaActual;
            _clientes.Calle = txtCalle.Text;
            _clientes.Altura = txtAltura.Text;
            _clientes.FechaDeAlta = fechaActual;
            return _clientes;
            //DateTime fecha = dtFechaNacimiento.Value;
            //_usuario.FechaDeNacimiento = fecha;
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
        public static int id;
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            id = 0;
            txtDni.Focus();
            txtDni.Enabled = true;
            //lblEstado.Visible = false;
            //checkBox1.Visible = false;
            //checkBox2.Visible = false;
            LimpiarCampos();
            HabilitarCampos();
        }
        private void HabilitarCampos()
        {
            panel_Clientes.Enabled = true;
            txtDni.Focus();
            btnCancelar.Visible = true;
            btnGuardar.Visible = true;
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
            panelInformacion.Visible = false;
            dataGridView2.Visible = false;
        }
        private void CargarCombo()
        {
            string[] Perfiles = Clases_Maestras.ValoresConstantes.Sexo;
            cmbSexo.Items.Add("Seleccione");
            cmbSexo.Items.Clear();
            foreach (string item in Perfiles)
            {
                cmbSexo.Text = "Seleccione";
                cmbSexo.Items.Add(item);
            }
        }
        List<Clientes> Cliente = new List<Clientes>();
        private void ClienteSeleccionado(int idClienteSeleccionado)
        {
            try
            {
                List<Clientes> _cliente = new List<Clientes>();
                _cliente = Negocio.Consultar.BuscarClientePorID(idClienteSeleccionado);
                Cliente = _cliente;
                if (_cliente.Count > 0)
                {
                    List<CuentaCorriente> _deuda = new List<CuentaCorriente>();
                    _deuda = Negocio.Consultar.BuscarDeudaPorCliente(idClienteSeleccionado);
                    if (_deuda.Count > 0)
                    {
                        HabilitarCamposDeuda(_deuda);
                        ListaCuentaCorriente = _deuda;
                    }
                    else
                    {
                        BloquearCamposDeuda();
                    }
                }
                List<ListaPagosDeDeudas> _lista = new List<ListaPagosDeDeudas>();
                _lista = Negocio.Clientes.ConsultaPagoDeuda(id);
                if (_lista.Count > 0)
                {
                    btnVerPagos.Visible = true;
                }
                else
                { btnVerPagos.Visible = false; }
                HabilitarCamposClienteSeleccionado(_cliente);
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void BloquearCamposDeuda()
        {
            lblUsuarioEstadisticas.Text = "El Cliente no posee deudas pedientes de saldar";
            panelInformacion.Visible = false;
            dataGridView2.Visible = false;
        }
        private void HabilitarCamposDeuda(List<CuentaCorriente> _deuda)
        {
            dataGridView2.Visible = true;
            panelInformacion.Visible = true;
            var Deuda = _deuda.First();
            lblPersona.Visible = true;
            lblPersona.Text = Deuda.Apellido + " " + Deuda.Nombre;
            lblPendiente.Visible = true;
            lblPendiente.Text = Convert.ToString("$" + Deuda.DeudaTotal);
            btnCancelarDeuda.Visible = true;
            btnDescontar.Visible = true;
            btnVerPagos.Visible = true;
        }
        private void HabilitarCamposClienteSeleccionado(List<Clientes> _cliente)
        {
            btnGuardar.Visible = true;
            btnCancelar.Visible = true;
            lblapellidoNombreEditar.Text = "Editar Cliente";
            panel_Clientes.Enabled = true;
            var cliente = _cliente.First();
            txtDni.Text = cliente.Dni;
            txtDni.Enabled = false;
            txtApellido.Text = cliente.Apellido;
            txtNombre.Text = cliente.Nombre;
            txtEmail.Text = cliente.Email;
            txtCalle.Text = cliente.Calle;
            txtAltura.Text = cliente.Altura;
            cmbSexo.Text = cliente.Sexo;
            cmbSexo.Enabled = false;
            var telefono = cliente.Telefono;
            string var = telefono.ToString();
            var split1 = var.Split('-')[0];
            split1 = split1.Trim();
            txtCodArea.Text = split1;
            string var2 = telefono.ToString();
            var split2 = var2.Split('-')[1];
            split2 = split2.Trim();
            txtTelefono.Text = split2;
        }
        #region Eventos Grilla
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
        }
        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Cursor = Cursors.Hand;
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            { return; }
            this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                ClienteSeleccionado(id);
            }
            catch (Exception ex)
            { }
        }
        #endregion
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
        public List<Entidades.CuentaCorriente> ListaCuentaCorriente
        {
            set
            {
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.DataSource = value;
                dataGridView2.ReadOnly = true;

                dataGridView2.Columns[0].HeaderText = "id Cliente";
                dataGridView2.Columns[0].Width = 50;
                dataGridView2.Columns[0].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[0].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView2.Columns[0].HeaderCell.Style.ForeColor = Color.White;
                dataGridView2.Columns[0].Visible = false;

                dataGridView2.Columns[1].HeaderText = "Dni";
                dataGridView2.Columns[1].Width = 65;
                dataGridView2.Columns[1].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[1].HeaderCell.Style.Font = new Font("Tahoma", 7, FontStyle.Bold);
                dataGridView2.Columns[1].HeaderCell.Style.ForeColor = Color.White;

                dataGridView2.Columns[2].HeaderText = "Apellido";
                dataGridView2.Columns[2].Width = 95;
                dataGridView2.Columns[2].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[2].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[2].HeaderCell.Style.ForeColor = Color.White;

                dataGridView2.Columns[3].HeaderText = "Nombre";
                dataGridView2.Columns[3].Width = 95;
                dataGridView2.Columns[3].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[3].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[3].HeaderCell.Style.ForeColor = Color.White;
                dataGridView2.Columns[3].Visible = false;


                dataGridView2.Columns[4].HeaderText = "Deuda";
                dataGridView2.Columns[4].Width = 90;
                dataGridView2.Columns[4].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[4].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[4].HeaderCell.Style.ForeColor = Color.White;

                dataGridView2.Columns[5].HeaderText = "DeudaTotal";
                dataGridView2.Columns[5].Width = 125;
                dataGridView2.Columns[5].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[5].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[5].HeaderCell.Style.ForeColor = Color.White;
                dataGridView2.Columns[5].Visible = false;

                dataGridView2.Columns[6].HeaderText = "Fecha";
                dataGridView2.Columns[6].Width = 90;
                dataGridView2.Columns[6].HeaderCell.Style.BackColor = Color.DarkBlue;
                dataGridView2.Columns[6].HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                dataGridView2.Columns[6].HeaderCell.Style.ForeColor = Color.White;

            }
        }
        private void btnDescontar_Click(object sender, EventArgs e)
        {
            try
            {
                DescontarDeudaWF _descontar = new DescontarDeudaWF(Cliente, lblPendiente.Text);
                _descontar.Show();
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void btnCancelarDeuda_Click(object sender, EventArgs e)
        {
            try
            {
                const string message = "Desea cancelar la deuda que el cliente posee ?";
                const string caption = "Cancelar Deuda";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                {
                    if (result == DialogResult.Yes)
                    {

                        bool exito = Negocio.Clientes.ActualizarDeudaTotal(Cliente, lblPendiente.Text);
                        if (exito == true)
                        {
                            const string message2 = "La deuda del cliente se cancelo exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }
        private void btnVerPagos_Click(object sender, EventArgs e)
        {
            try
            {
                List<ListaPagosDeDeudas> _lista = new List<ListaPagosDeDeudas>();
                _lista = Negocio.Clientes.ConsultaPagoDeuda(id);
                if (_lista.Count > 0)
                {
                    PagosDeudaWF _pagos = new PagosDeudaWF(_lista);
                    _pagos.Show();
                }
            }
            catch (Exception ex)
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
