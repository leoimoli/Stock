using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stock.DAO;
using Stock.Entidades;

namespace Stock
{
    public partial class NewMasterWF : Form
    {
        public NewMasterWF()
        {
            InitializeComponent();
            ValidarFechasFestivas();
            AbrirFormEnPanel(new InicioNuevoWF());
            if (Sesion.UsuarioLogueado.Perfil == "1" || Sesion.UsuarioLogueado.Perfil == "SUPER ADMIN")
            {
                btnOfertas.Visible = true;
            }
            else { btnOfertas.Visible = false; }
        }
        private void ValidarFechasFestivas()
        {
            List<FechasFestivas> _listaFechas = new List<FechasFestivas>();
            _listaFechas = DAO.ConsultarDao.BuscarFechasFestivas();
            int AñoActual = DateTime.Now.Year;
            DateTime FechaActual = DateTime.Now;

            ///// Codigo para forzar fechas
            //AñoActual = AñoActual + 1;
            //FechaActual = Clases_Maestras.FechasFestivasForzadas.ForzarFecha();

            foreach (var item in _listaFechas)
            {
                string FechaDesde = item.FechaDesde + "/" + AñoActual;
                string FechaHasta = item.FechaHasta + "/" + AñoActual;
                if (FechaActual > Convert.ToDateTime(FechaDesde) && Convert.ToDateTime(FechaActual) < Convert.ToDateTime(FechaHasta))
                {
                    picNavidad.Visible = true;
                    Image imgFiestas = Image.FromFile(Environment.CurrentDirectory + "\\" + item.NombreImagen);
                    picNavidad.Image = imgFiestas;
                    break;
                }
                else
                {
                    picNavidad.Visible = false;
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            this.Size = new Size(this.Width +60, Screen.PrimaryScreen.WorkingArea.Size.Height);
            //this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {           
            this.Location = new Point(50, 50); //sobra si tienes la posición en el diseño
            this.Size = new Size(1300, 650);
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void MenuCabecera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnMenuPequeño_Click(object sender, EventArgs e)
        {
            //if (MenuVertical.Width == 201)
            //{
            //    MenuVertical.Width = 55;
            //}
            //else
            //{
            //    if (MenuVertical.Width == 55)
            //    {
            //        MenuVertical.Width = 201;
            //    }
            //}
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProductoNuevoWF());
        }
        private void NewMasterWF_Load(object sender, EventArgs e)
        {
            label6.Text = Sesion.UsuarioLogueado.Apellido + "  " + Sesion.UsuarioLogueado.Nombre;
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioNuevoWF());
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new StockNuevoWF());
        }
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProveedoresNuevoWF());
        }
        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClientesNuevoWF());
        }
        private void btnPagos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new PreciosNuevoWF());
        }
        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentasNuevoWF _ventas = new VentasNuevoWF();
            _ventas.Show();
            Hide();
        }
        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ReportesNuevoWF());
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new UsuariosNuevoWF());
        }
        private void btnOfertas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new OfertasWF());
        }
        public static int contadorClic = 0;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (contadorClic == 0)
            {
                txtNuevaClave.Visible = true;
                txtNuevaClave.Focus();
                btnModificarClave.Visible = true;
                label6.Text = "Ingrese Nueva Contraseña";
                label6.Font = new Font(label6.Font.Name, 9);
                contadorClic = contadorClic + 1;
            }
            else
            {
                txtNuevaClave.Visible = false;
                btnModificarClave.Visible = false;
                label6.Text = Sesion.UsuarioLogueado.Apellido + " " + Sesion.UsuarioLogueado.Nombre;
                contadorClic = 0;
            }
        }

        private void btnModificarClave_Click(object sender, EventArgs e)
        {
            string clave = txtNuevaClave.Text;
            //string claveCifrada = cifrar(clave);
            bool Exito = EditarDao.ResetearClave(clave);
            if (Exito == true)
            {
                const string message2 = "Se reseteo la clave exitosamente.";
                const string caption2 = "Éxito";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Asterisk);
                txtNuevaClave.Clear();
                txtNuevaClave.Visible = false;
                btnModificarClave.Visible = false;
                label6.Text = Sesion.UsuarioLogueado.Apellido + " " + Sesion.UsuarioLogueado.Nombre;
                contadorClic = 0;
            }
            else
            {
                const string message2 = "Atención: Fallo el reseteo de la clave. Intente nuevamente.";
                const string caption2 = "Atención";
                var result2 = MessageBox.Show(message2, caption2,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
            }
        }
        public string cifrar(string clave)
        {
            byte[] llave; //Arreglo donde guardaremos la llave para el cifrado 3DES.
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(clave); //Arreglo donde guardaremos la cadena descifrada.
            // Ciframos utilizando el Algoritmo MD5.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            llave = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(clave));
            md5.Clear();
            //Ciframos utilizando el Algoritmo 3DES.
            TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
            tripledes.Key = llave;
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateEncryptor(); // Iniciamos la conversión de la cadena
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length); //Arreglo de bytes donde guardaremos la cadena cifrada.
            tripledes.Clear();
            return Convert.ToBase64String(resultado, 0, resultado.Length); // Convertimos la cadena y la regresamos.
        }
    }
}
