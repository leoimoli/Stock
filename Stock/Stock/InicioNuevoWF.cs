using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Stock
{
    public partial class InicioNuevoWF : Form
    {
        public InicioNuevoWF()
        {
            InitializeComponent();
        }

        private void InicioNuevoWF_Load(object sender, EventArgs e)
        {
            ///// Armo Panel de Informacion
            int totalProvedores = DAO.ConsultarDao.ContadorProveedores();
            int Clientes = DAO.ConsultarDao.ContadorClientes();
            int Productos = DAO.ConsultarDao.ContadorProductos();
            int Marcas = DAO.ConsultarDao.ContadorMarcas();
            decimal Ventas = DAO.ConsultarDao.ContadorVentas();
            int Usuarios = DAO.ConsultarDao.ContadorUsuarios();

            lblContadorProveedores.Text = Convert.ToString(totalProvedores);
            lblContadorClientes.Text = Convert.ToString(Clientes);
            lblContadorProdcutos.Text = Convert.ToString(Productos);
            lblContadorMarcas.Text = Convert.ToString(Marcas);
            lblContadorVentas.Text = Convert.ToString(Ventas);
            lblContadorUsuarios.Text = Convert.ToString(Usuarios);

            ///// Dia y Hora
            CheckForIllegalCrossThreadCalls = false;
            System.Timers.Timer t = new System.Timers.Timer(1000);
            t.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            t.Start();
            String DiaDeLaSemana = DateTime.Now.DayOfWeek.ToString();
            string Dia = ValidarDia(DiaDeLaSemana);
            String FechaDia = DateTime.Now.Day.ToString();
            String Month = DateTime.Now.Month.ToString();
            string Mes = ValidarMes(Month);
            String Year = DateTime.Now.Year.ToString();
            int month = Convert.ToInt32(Month);
            int year = Convert.ToInt32(Year);
            lblDia.Text = Dia + "," + " " + FechaDia +" "+"de" + " " + Mes + " " + Year;
            ///// Completo Grilla con informacion
            List<Entidades.ListaStockFaltante> ListaStockFaltante = new List<Entidades.ListaStockFaltante>();
            ListaStockFaltante = Negocio.Consultar.ListaStockFaltante();
            if (ListaStockFaltante.Count > 0)
            {
                foreach (var item in ListaStockFaltante)
                {
                    dgvProductos.Rows.Add(item.Nombre, item.Marca, item.Cantidad);
                }
            }
            dgvProductos.ReadOnly = true;

        }
        private string ValidarDia(string diaDeLaSemana)
        {
            string Dia = "";
            if (diaDeLaSemana == "Monday")
            {
                Dia = "Lunes";
            }
            if (diaDeLaSemana == "Tuesday")
            {
                Dia = "Martes";
            }
            if (diaDeLaSemana == "Wednesday")
            {
                Dia = "Miercoles";
            }
            if (diaDeLaSemana == "Thursday")
            {
                Dia = "Jueves";
            }
            if (diaDeLaSemana == "Friday")
            {
                Dia = "Viernes";
            }
            if (diaDeLaSemana == "Saturday")
            {
                Dia = "Sábado";
            }
            if (diaDeLaSemana == "Sunday")
            {
                Dia = "Domingo";
            }
            return Dia;
        }
        private string ValidarMes(string Month)
        {
            string Mes = "";
            if (Month == "1")
            {
                Mes = "Enero";
            }
            if (Month == "2")
            {
                Mes = "Febrero";
            }
            if (Month == "3")
            {
                Mes = "Marzo";
            }
            if (Month == "4")
            {
                Mes = "Abril";
            }
            if (Month == "5")
            {
                Mes = "Mayo";
            }
            if (Month == "6")
            {
                Mes = "Junio";
            }
            if (Month == "7")
            {
                Mes = "Julio";
            }
            if (Month == "8")
            {
                Mes = "Agosto";
            }
            if (Month == "9")
            {
                Mes = "Septiembre";
            }
            if (Month == "10")
            {
                Mes = "Octubre";
            }
            if (Month == "11")
            {
                Mes = "Noviembre";
            }
            if (Month == "12")
            {
                Mes = "Diciembre";
            }
            return Mes;
        }
        private void timer1_Tick(object sender, ElapsedEventArgs el)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblMaster_FechaHoraReal.Text = Convert.ToString(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
