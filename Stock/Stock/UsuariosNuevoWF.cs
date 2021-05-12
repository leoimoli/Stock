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
    public partial class UsuariosNuevoWF : Form
    {
        public UsuariosNuevoWF()
        {
            InitializeComponent();
        }
        private void UsuariosNuevoWF_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionListarUsuarios();
                FuncionBuscartexto();
            }
            catch (Exception ex)
            { }
        }
        private void FuncionBuscartexto()
        {
            txtDescipcionBus.AutoCompleteCustomSource = Clases_Maestras.AutoCompleteUsuarios.Autocomplete();
            txtDescipcionBus.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDescipcionBus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void FuncionListarUsuarios()
        {
            try
            {
                FuncionBuscartexto();
                dgvUsuarios.Rows.Clear();
                List<Entidades.Usuarios> Lista = Negocio.Consultar.ListaDeUsuarios();
                if (Lista.Count > 0)
                {
                    foreach (var item in Lista)
                    {
                        string Apellido = item.Apellido;
                        string Nombre = item.Nombre;
                        string Persona = Apellido + "," + Nombre;
                        string Dni = item.Dni;
                        string Perfil = item.Perfil;
                        dgvUsuarios.Rows.Add(item.IdUsuario, Persona, Dni, Perfil);
                    }
                }
                dgvUsuarios.ReadOnly = true;
            }
            catch (Exception ex)
            {
            }
        }
        public static int Funcion = 0;
        private void txtDescipcionBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvUsuarios.Rows.Clear();
                string Descripcion = txtDescipcionBus.Text;
                string Ape = Descripcion.Split(',')[0];
                string Nom = Descripcion.Split(',')[1];
                List<Entidades.Usuarios> Lista = Negocio.Consultar.BuscarUsuarioPorApellidoNombre(Ape, Nom);
                if (Lista.Count > 0)
                {
                    foreach (var item in Lista)
                    {
                        string Apellido = item.Apellido;
                        string Nombre = item.Nombre;
                        string Persona = Apellido + "," + Nombre;
                        string Dni = item.Dni;
                        string Perfil = item.Perfil;
                        dgvUsuarios.Rows.Add(item.IdUsuario, Persona, Dni, Perfil);
                    }
                }
                dgvUsuarios.ReadOnly = true;
            }
        }
        private void txtCodigoBus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvUsuarios.Rows.Clear();
                string Dni = txtCodigoBus.Text;
                List<Entidades.Usuarios> Lista = Negocio.Consultar.BuscarUsuarioPorDNI(Dni);
                if (Lista.Count > 0)
                {
                    foreach (var item in Lista)
                    {
                        string Apellido = item.Apellido;
                        string Nombre = item.Nombre;
                        string Persona = Apellido + "," + Nombre;
                        string DniPer = item.Dni;
                        string Perfil = item.Perfil;
                        dgvUsuarios.Rows.Add(item.IdUsuario, Persona, DniPer, Perfil);
                    }
                }
                dgvUsuarios.ReadOnly = true;
            }
        }
        public static int idUsuarioSeleccionado = 0;
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDni.Enabled = true;
            txtContraseña.Enabled = true;
            txtRepitaContraseña.Enabled = true;
            LimpiarCampos();
            txtDni.Focus();
            idUsuarioSeleccionado = 0;
            Funcion = 1;
            lblEstado.Visible = false;
            chcActivo.Visible = false;
            chcInactivo.Visible = false;
        }
        private void LimpiarCampos()
        {
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtContraseña.Clear();
            txtRepitaContraseña.Clear();
            CargarCombo();
            progressBar1.Value = Convert.ToInt32(null);
            progressBar1.Visible = false;
        }
        private void CargarCombo()
        {
            string[] Perfiles = Clases_Maestras.ValoresConstantes.Perfiles;
            cmbPerfil.Items.Add("Seleccione");
            cmbPerfil.Items.Clear();
            foreach (string item in Perfiles)
            {
                cmbPerfil.Text = "Seleccione";
                cmbPerfil.Items.Add(item);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.RowCount > 0)
            {
                Funcion = 2;
                idUsuarioSeleccionado = Convert.ToInt32(this.dgvUsuarios.CurrentRow.Cells[0].Value);
                string Persona = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                string Ape = Persona.Split(',')[0];
                string Nom = Persona.Split(',')[1];
                txtApellido.Text = Ape;
                txtNombre.Text = Nom;
                txtDni.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                cmbPerfil.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtContraseña.Enabled = false;
                txtRepitaContraseña.Enabled = false;
                chcActivo.Visible = true;
                chcInactivo.Visible = true;
                lblEstado.Visible = true;
            }
            else
            {
                const string message2 = "Debe seleccionar un usuario de la grilla.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idUsuarioSeleccionado > 0)
                {
                    if (Funcion == 2)
                    {
                        Entidades.Usuarios _usuario = CargarEntidadEdicion();
                        bool Exito = Negocio.Usuario.EditarUsuario(_usuario, idUsuarioSeleccionado);
                        if (Exito == true)
                        {
                            ProgressBar();
                            const string message2 = "La edición del usuario se registro exitosamente.";
                            const string caption2 = "Éxito";
                            var result2 = MessageBox.Show(message2, caption2,
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Asterisk);
                            LimpiarCampos();
                            FuncionListarUsuarios();
                        }
                    }
                }
                else
                {
                    Entidades.Usuarios _usuario = CargarEntidad();
                    bool Exito = Negocio.Usuario.CargarUsuario(_usuario);
                    if (Exito == true)
                    {
                        ProgressBar();
                        const string message2 = "Se registro el usuario exitosamente.";
                        const string caption2 = "Éxito";
                        var result2 = MessageBox.Show(message2, caption2,
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Asterisk);
                        LimpiarCampos();
                        FuncionListarUsuarios();
                    }
                }
            }
            catch (Exception ex)
            { }
        }

        private Usuarios CargarEntidadEdicion()
        {
            string estado = "ACTIVO";
            Usuarios _usuario = new Usuarios();
            if (chcInactivo.Checked == true)
            {
                estado = "INACTIVO";
            }
            _usuario.Dni = txtDni.Text;
            _usuario.Apellido = txtApellido.Text;
            _usuario.Nombre = txtNombre.Text;
            _usuario.Perfil = cmbPerfil.Text;
            _usuario.Estado = estado;
            return _usuario;
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
        private Usuarios CargarEntidad()
        {
            Usuarios _usuario = new Usuarios();
            _usuario.Dni = txtDni.Text;
            _usuario.Apellido = txtApellido.Text;
            _usuario.Nombre = txtNombre.Text;
            DateTime fechaActual = DateTime.Now;
            _usuario.FechaDeAlta = fechaActual;
            _usuario.FechaUltimaConexion = fechaActual;
            _usuario.Perfil = cmbPerfil.Text;
            _usuario.Estado = "ACTIVO";
            _usuario.Contraseña = txtContraseña.Text;
            _usuario.Contraseña2 = txtRepitaContraseña.Text;
            return _usuario;
        }

        private void chcInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcInactivo.Checked == true)
            {
                chcActivo.Checked = false;
            }
        }

        private void chcActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chcActivo.Checked == true)
            {
                chcInactivo.Checked = false;
            }
        }
    }
}
