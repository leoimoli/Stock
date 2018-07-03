using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Clientes
    {
        public static bool CargarCliente(Entidades.Clientes _cliente)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_cliente);
                bool UsuarioExistente = Negocio.Consultar.ValidarClienteExistente(_cliente.Dni);
                if (UsuarioExistente == true)
                {
                    MessageBox.Show("YA EXISTE UN CLIENTE REGISTRADO CON EL DNI INGRESADO.");
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertCliente(_cliente);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
            return exito;
        }
        private static void ValidarDatos(Entidades.Clientes _cliente)
        {
            if (String.IsNullOrEmpty(_cliente.Dni))
            {
                MessageBox.Show("EL CAMPO DNI ES OBLIGATORIO.");
                throw new Exception();
            }
            if (_cliente.Sexo == "Seleccione")
            {
                MessageBox.Show("EL CAMPO SEXO ES OBLIGATORIO.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Apellido))
            {
                MessageBox.Show("EL CAMPO APELLIDO ES OBLIGATORIO.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Nombre))
            {
                MessageBox.Show("EL CAMPO NOMBRE ES OBLIGATORIO.");
                throw new Exception();
            }
        }

        public static bool ActualizarDeuda(List<Entidades.Clientes> cliente, string deuda, decimal pagoIngresado)
        {
            bool exito = false;
            try
            {
                decimal ValorDeuda = 0;
                var _cliente = cliente.First();
                string var = deuda.ToString();
                var split = var.Split('$')[1];
                split = split.Trim();
                decimal DeudaVieja = Convert.ToDecimal(split);
                ValorDeuda = DeudaVieja - pagoIngresado;
                exito = DAO.AgregarDao.RegistrarPagoDeDeuda(ValorDeuda, _cliente.IdCliente, _cliente.idUsuario);
                if (exito == true)
                {
                    exito = DAO.EditarDao.ActualizarDeuda(ValorDeuda, _cliente.IdCliente);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }

        public static bool EditarCliente(Entidades.Clientes _cliente, int idUsuarioSeleccionado)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_cliente);
                exito = DAO.EditarDao.EditarCliente(_cliente, idUsuarioSeleccionado);
            }
            catch (Exception ex)
            { }
            return exito;
        }
        public static bool RegistrarPuntos(int idCliente, string puntos)
        {
            bool exito = false;
            try
            {
                int PuntosAntiguos = Negocio.Consultar.BuscarPuntosViejos(idCliente);
                if (PuntosAntiguos > 0)
                {
                    int PuntosNuevos = Convert.ToInt32(puntos);
                    int ActualizarPuntos = PuntosAntiguos + PuntosNuevos;
                    exito = DAO.EditarDao.ActualizarPuntaje(idCliente, ActualizarPuntos);
                }
                else
                {
                    int PuntosNuevos = Convert.ToInt32(puntos);
                    int ActualizarPuntos = PuntosAntiguos + PuntosNuevos;
                    exito = DAO.AgregarDao.RegistrarPuntos(idCliente, ActualizarPuntos);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }
        public static bool RegistrarCuentaCorriente(int idCliente, string deudaGuardar, DateTime fecha, int idVenta)
        {
            bool exito = false;
            decimal deudaNueva = Convert.ToDecimal(deudaGuardar);
            try
            {
                decimal DeudaVieja = DAO.ConsultarDao.BuscarDeudaExistente(idCliente);
                if (DeudaVieja >= 0)
                {
                    decimal DEUDA = DeudaVieja + deudaNueva;
                    exito = DAO.EditarDao.ActualizarDeuda(DEUDA, idCliente);
                    if (exito == true)
                    {
                        exito = DAO.AgregarDao.InsertarDetalleCuentaCorriente(idCliente, deudaNueva, fecha, idVenta);
                    }
                    else { }
                }
                else
                {
                    exito = DAO.AgregarDao.InsertarCuentaCorriente(idCliente, deudaGuardar);
                    if (exito == true)
                    {
                        exito = DAO.AgregarDao.InsertarDetalleCuentaCorriente(idCliente, deudaNueva, fecha, idVenta);
                    }
                    else { }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
            return exito;
        }
        public static bool ActualizarDeudaTotal(List<Entidades.Clientes> cliente, string deuda)
        {
            bool exito = false;
            try
            {
                string var = deuda.ToString();
                var split = var.Split('$')[1];
                split = split.Trim();
                decimal PagoRealizado = Convert.ToDecimal(split);
                decimal ValorDeuda = 0;
                var _cliente = cliente.First();
                decimal DeudaVieja = Convert.ToDecimal(split);
                exito = DAO.AgregarDao.RegistrarPagoDeDeuda(PagoRealizado, _cliente.IdCliente, _cliente.idUsuario);
                if (exito == true)
                {
                    exito = DAO.EditarDao.ActualizarDeuda(ValorDeuda, _cliente.IdCliente);
                    if (exito == true)
                    {
                        exito = DAO.EditarDao.ModificarEstadoDetalleCuentaCorriente(_cliente.IdCliente);
                    }
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }

        public static List<ListaPagosDeDeudas> ConsultaPagoDeuda(int idClienteSeleccionado)
        {
            List<ListaPagosDeDeudas> _lista = new List<ListaPagosDeDeudas>();
            try
            {
                _lista = DAO.ConsultarDao.ConsultaPagoDeuda(idClienteSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el sistema. Intente nuevamente o comuniquese con el administrador.");
                throw new Exception();
            }
            return _lista;
        }
    }
}
