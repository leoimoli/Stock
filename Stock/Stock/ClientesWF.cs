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
            }
            catch (Exception ex)
            { }
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
                        MessageBox.Show("LA EDICIÓN DEL CLIENTE SE REALIZO EXITOSAMENTE.");
                        LimpiarCampos();
                        //List<Entidades.UsuarioReducido> ListaReducidos = CargarEntidadReducida(Negocio.Consultar.ListaDeUsuarios());
                        //ListaUsuarios = ListaReducidos;
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
                        MessageBox.Show("SE REGISTRO EL CLIENTE EXITOSAMENTE.");
                        LimpiarCampos();
                    }
                    else
                    {
                        HabilitarCampos();
                    }
                }
            }
            catch (Exception ex)
            { }
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
            string[] Sexo = Clases_Maestras.ValoresConstantes.Sexo;
            cmbSexo.Items.Add("Seleccione");
            foreach (string item in Sexo)
            {
                cmbSexo.Text = "Seleccione";
                cmbSexo.Items.Add(item);
            }

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
        private void ClienteSeleccionado(int idClienteSeleccionado)
        {
            try
            {
                List<Clientes> _cliente = new List<Clientes>();
                _cliente = Negocio.Consultar.BuscarClientePorID(idClienteSeleccionado);
                HabilitarCamposClienteSeleccionado(_cliente);
            }
            catch (Exception ex)
            { }
        }
        private void HabilitarCamposClienteSeleccionado(List<Clientes> _cliente)
        {
            // lblEstado.Visible = true;
            //checkBox1.Visible = true;
            //checkBox2.Visible = true;
            //btnCargarImagen.Visible = true;
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
            //txtCodArea.Text = usuario.Contraseña;
            //txtTelefono.Text = usuario.Perfil;
            txtCalle.Text = cliente.Calle;
            txtAltura.Text = cliente.Altura;
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
    }
}
