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
    public partial class ClientesNuevoWF : Form
    {
        public ClientesNuevoWF()
        {
            InitializeComponent();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void ClientesNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionListarClientes();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompletePorApellido.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void FuncionListarClientes()
        {
            FuncionBuscartexto();
            dgvClientes.Rows.Clear();
            List<Entidades.Clientes> ListaClientes = Negocio.Consultar.ListaDeClientes();
            if (ListaClientes.Count > 0)
            {
                foreach (var item in ListaClientes)
                {
                    string Apellido = item.Apellido;
                    string Nombre = item.Nombre;
                    string Persona = Apellido + "," + Nombre;
                    string Domicilio = item.Calle + "N°" + item.Altura;
                    dgvClientes.Rows.Add(item.IdCliente, Persona, Domicilio, item.Email, item.Telefono);
                }
            }
            dgvClientes.ReadOnly = true;
        }
        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarClientePorDescripcion();
            }
        }
        private void BuscarClientePorDescripcion()
        {
            dgvClientes.Rows.Clear();
            string Descripcion = txtDescipcionBus.Text;
            string Ape = Descripcion.Split(',')[0];
            string Nom = Descripcion.Split(',')[1];
            List<Entidades.Clientes> ListaClientes = Negocio.Consultar.BuscarClientePorApellidoNombre(Ape, Nom);
            if (ListaClientes.Count > 0)
            {
                foreach (var item in ListaClientes)
                {
                    string Apellido = item.Apellido;
                    string Nombre = item.Nombre;
                    string Persona = Apellido + "," + Nombre;
                    string Domicilio = item.Calle + "N°" + item.Altura;
                    dgvClientes.Rows.Add(item.IdCliente, Persona, Domicilio, item.Email, item.Telefono);
                }
            }
            dgvClientes.ReadOnly = true;
        }
        private void txtCodigoBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarClientePorDni();
            }
        }
        private void BuscarClientePorDni()
        {
            dgvClientes.Rows.Clear();
            string Dni = txtCodigoBus.Text;
            List<Entidades.Clientes> ListaClientes = Negocio.Consultar.BuscarClientePorDni(Dni);
            if (ListaClientes.Count > 0)
            {
                foreach (var item in ListaClientes)
                {
                    string Apellido = item.Apellido;
                    string Nombre = item.Nombre;
                    string Persona = Apellido + "," + Nombre;
                    string Domicilio = item.Calle + "N°" + item.Altura;
                    dgvClientes.Rows.Add(item.IdCliente, Persona, Domicilio, item.Email, item.Telefono);
                }
            }
            dgvClientes.ReadOnly = true;
        }
        public static int idClienteSeleccionado = 0;
        public static int Funcion = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCamposClienteNuevo();

            idClienteSeleccionado = 0;
            Funcion = 1;
            CargarCombo();
        }
        private void HabilitarCamposClienteNuevo()
        {
            txtDni.Enabled = true;
            txtDni.Focus();
            cmbSexo.Enabled = true;
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtCodArea.Enabled = true;
            txtTelefono.Enabled = true;
            txtCalle.Enabled = true;
            txtAltura.Enabled = true;
            CargarCombo();
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idClienteSeleccionado > 0)
                {
                    Entidades.Clientes _cliente = CargarEntidadEdicion();
                    bool Exito = Negocio.Clientes.EditarCliente(_cliente, idClienteSeleccionado);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "La edición del cliente se registro exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        FuncionListarClientes();
                    }
                }
                else
                {
                    Entidades.Clientes _cliente = CargarEntidad();
                    bool Exito = Negocio.Clientes.CargarCliente(_cliente);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el cliente exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        FuncionListarClientes();
                    }
                }
            }
            catch (Exception ex)
            {
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvClientes.RowCount > 0)
            {
                Funcion = 2;
                idClienteSeleccionado = Convert.ToInt32(this.dgvClientes.CurrentRow.Cells[0].Value);
                List<Entidades.Clientes> _clientes = new List<Entidades.Clientes>();
                _clientes = Negocio.Consultar.BuscarClientePorID(idClienteSeleccionado);
                HabilitarCamposClienteSeleccionado(_clientes);
            }
            else
            {
                const string message2 = "Debe seleccionar un cliente de la grilla.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void HabilitarCamposClienteSeleccionado(List<Clientes> _cliente)
        {
            btnGuardar.Visible = true;
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
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigoBus.Text != "")
            {
                BuscarClientePorDni();
            }
            if (txtDescipcionBus.Text != "")
            {
                BuscarClientePorDescripcion();
            }
        }
        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back);
        }
    }
}
