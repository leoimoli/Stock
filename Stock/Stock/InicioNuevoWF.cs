using Stock.Entidades;
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
            ////// Obtener Informacion clima
            ObtenerInformacion();
            ///// Armo Panel de Informacion
            int totalProvedores = DAO.ConsultarDao.ContadorProveedores();
            int Clientes = DAO.ConsultarDao.ContadorClientes();
            int Productos = DAO.ConsultarDao.ContadorProductos();
            int Marcas = DAO.ConsultarDao.ContadorMarcas();
            int Ventas = DAO.ConsultarDao.ContadorVentas();
            int Usuarios = DAO.ConsultarDao.ContadorUsuarios();

            if (Ventas > 9999)
            {
                lblContadorVentas.Text = "+ 10.000";
            }
            if (Ventas > 99999)
            {
                lblContadorVentas.Text = "+ 100.000";
            }
            if (Ventas > 999999)
            {
                lblContadorVentas.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorVentas.Text = Convert.ToString(Ventas);
            }
            if (Productos > 9999)
            {
                lblContadorProdcutos.Text = "+ 10.000";
            }
            if (Productos > 99999)
            {
                lblContadorProdcutos.Text = "+ 100.000";
            }
            if (Productos > 999999)
            {
                lblContadorProdcutos.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorProdcutos.Text = Convert.ToString(Productos);
            }
            if (Clientes > 9999)
            {
                lblContadorClientes.Text = "+ 10.000";
            }
            if (Clientes > 99999)
            {
                lblContadorClientes.Text = "+ 100.000";
            }
            if (Clientes > 999999)
            {
                lblContadorClientes.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorClientes.Text = Convert.ToString(Clientes);
            }
            if (totalProvedores > 9999)
            {
                lblContadorProveedores.Text = "+ 10.000";
            }
            if (totalProvedores > 99999)
            {
                lblContadorProveedores.Text = "+ 100.000";
            }
            if (totalProvedores > 999999)
            {
                lblContadorProveedores.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorProveedores.Text = Convert.ToString(totalProvedores);
            }
            if (Marcas > 9999)
            {
                lblContadorMarcas.Text = "+ 10.000";
            }
            if (Marcas > 99999)
            {
                lblContadorMarcas.Text = "+ 100.000";
            }
            if (Marcas > 999999)
            {
                lblContadorMarcas.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorMarcas.Text = Convert.ToString(Marcas);
            }
            if (Usuarios > 9999)
            {
                lblContadorUsuarios.Text = "+ 10.000";
            }
            if (Usuarios > 99999)
            {
                lblContadorUsuarios.Text = "+ 100.000";
            }
            if (Usuarios > 999999)
            {
                lblContadorUsuarios.Text = "+ 1.000.000";
            }
            else
            {
                lblContadorUsuarios.Text = Convert.ToString(Usuarios);
            }
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
            lblDia.Text = Dia + "," + " " + FechaDia + " " + "de" + " " + Mes + " " + Year;
            /////// Completo Grilla con informacion
            //List<Entidades.ListaStockFaltante> ListaStockFaltante = new List<Entidades.ListaStockFaltante>();
            //ListaStockFaltante = Negocio.Consultar.ListaStockFaltante();
            //if (ListaStockFaltante.Count > 0)
            //{
            //    foreach (var item in ListaStockFaltante)
            //    {
            //        if (item.CodigoProducto != "PAGOPROVEEDORES22")
            //        { dgvProductos.Rows.Add(item.Nombre, item.Marca, item.Cantidad); }

            //    }
            //}
            //dgvProductos.ReadOnly = true;

            /////// Completo Caja Diaria
            ObtengoCajaDiaria();

        }

        private void ObtengoCajaDiaria()
        {
            List<DetalleCajaDiaria> ListaVentasDiarias = new List<DetalleCajaDiaria>();
            List<DetalleCajaDiaria> ListaVentasDiariasFinal = new List<DetalleCajaDiaria>();
            // Completo Grilla con informacion para las ventas diarias.
            ListaVentasDiarias = DAO.ConsultarDao.ObtenerCajaDiaria();
            if (ListaVentasDiarias.Count > 0)
            {
                DetalleCajaDiaria detalle = new DetalleCajaDiaria();

                foreach (var item in ListaVentasDiarias)
                {
                    if (string.IsNullOrEmpty(detalle.medio) || detalle.medio != item.medio)
                    {
                        if (!string.IsNullOrEmpty(detalle.precio))
                            ListaVentasDiariasFinal.Add(detalle);

                        detalle = new DetalleCajaDiaria();
                        detalle.producto = "-";
                        detalle.categoria = "-";
                        detalle.cantidad = "-";
                        detalle.idventa = "-";
                        detalle.medio = item.medio;
                        detalle.precio = item.precio;
                        detalle.fecha = DateTime.Today.Day.ToString().PadLeft(2, '0') +
                                        "/" + DateTime.Today.Month.ToString().PadLeft(2, '0') +
                                        "/" + DateTime.Today.Year.ToString().PadLeft(4, '0');



                    }
                    else
                    {
                        detalle.precio = (decimal.Parse(detalle.precio) + decimal.Parse(item.precio)).ToString();
                    }
                    ListaVentasDiariasFinal.Add(item);
                }

                ListaVentasDiariasFinal.Add(detalle);
                if (ListaVentasDiariasFinal.Count > 0)
                {
                    foreach (var item in ListaVentasDiariasFinal)
                    {
                        dgvProductos.Rows.Add(item.idventa, item.fecha, item.producto, item.cantidad, item.precio, item.categoria, item.medio);
                    }
                    dgvProductos.ReadOnly = true;
                }
            }
        }
        private void ObtenerInformacion()
        {
            BuscarClima();
        }
        private void BuscarClima()
        {
            pictureBox7.Load($"https://w.bookcdn.com/weather/picture/3_55558_1_4_137AE9_350_ffffff_333333_08488D_1_ffffff_333333_0_6.png?scode=49053&domid=582&anc_id=81469");
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
