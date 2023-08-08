using Stock.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
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
            int totalProvedores = 0;
            int Clientes = 0;
            int Productos = 0;
            int Marcas = 0;
            int Ventas = 0;
            int Usuarios = 0;
            try
            {
                totalProvedores = DAO.ConsultarDao.ContadorProveedores();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                Clientes = DAO.ConsultarDao.ContadorClientes();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                Productos = DAO.ConsultarDao.ContadorProductos();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                Marcas = DAO.ConsultarDao.ContadorMarcas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                Ventas = DAO.ConsultarDao.ContadorVentas();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            try
            {
                Usuarios = DAO.ConsultarDao.ContadorUsuarios();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

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

            ////// Obtener Informacion clima
            ObtenerInformacion();
        }

        private void ObtengoCajaDiaria()
        {
            decimal Efectivo = 0;
            decimal Debito = 0;
            decimal Credito = 0;
            decimal CuentaDni = 0;
            decimal MercadoPago = 0;
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
                    if (item.medio == "EFECTIVO")
                    {
                        Efectivo = Efectivo + Convert.ToDecimal(item.precio);
                    }
                    if (item.medio == "DEBITO")
                    {
                        Debito = Debito + Convert.ToDecimal(item.precio);
                    }
                    if (item.medio == "CREDITO")
                    {
                        Credito = Credito + Convert.ToDecimal(item.precio);
                    }
                    if (item.medio == "CUENTA DNI PROVINCIA")
                    {
                        CuentaDni = CuentaDni + Convert.ToDecimal(item.precio);
                    }
                    if (item.medio == "MERCADO PAGO")
                    {
                        MercadoPago = MercadoPago + Convert.ToDecimal(item.precio);
                    }
                }
                ListaVentasDiariasFinal.Add(detalle);
                txtEfectivo.Text = Efectivo.ToString("N", new CultureInfo("es-CL"));
                txtDebito.Text = Debito.ToString("N", new CultureInfo("es-CL"));
                txtCredito.Text = Credito.ToString("N", new CultureInfo("es-CL"));
                txtCuentaDni.Text = CuentaDni.ToString("N", new CultureInfo("es-CL"));
                txtMercadoPago.Text = MercadoPago.ToString("N", new CultureInfo("es-CL"));
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
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                pictureBox7.Load($"https://w.bookcdn.com/weather/picture/3_55558_1_4_137AE9_350_ffffff_333333_08488D_1_ffffff_333333_0_6.png?scode=49053&domid=582&anc_id=81469");
            }
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

        private void button10_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Red, Color.Transparent);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
