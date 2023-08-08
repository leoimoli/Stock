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
                    const string message2 = "Ya existe un cliente con el dni ingresado.";
                    const string caption2 = "Éxito";
                    var result2 = MessageBox.Show(message2, caption2,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertCliente(_cliente);
                }
            }
            catch (Exception ex)
            {
            }
            return exito;
        }
        private static void ValidarDatos(Entidades.Clientes _cliente)
        {
            if (String.IsNullOrEmpty(_cliente.Dni))
            {
                const string message = "El campo dni es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (_cliente.Sexo == "Seleccione")
            {
                const string message = "El campo sexo es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);

                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Apellido))
            {
                const string message = "El campo apellido es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_cliente.Nombre))
            {
                const string message = "El campo nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
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
                exito = DAO.AgregarDao.RegistrarPagoDeDeuda(pagoIngresado, _cliente.IdCliente, _cliente.idUsuario);
                if (exito == true)
                {
                    exito = DAO.EditarDao.ActualizarDeuda(ValorDeuda, _cliente.IdCliente);
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
            {
                //const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                //const string caption = "Atención";
                //var result = MessageBox.Show(message, caption,
                //                             MessageBoxButtons.OK,
                //                           MessageBoxIcon.Warning);
                throw new Exception();
            }
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
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return exito;
        }
        public static bool RegistrarCuentaCorriente(int idCliente, string deudaGuardar, DateTime fecha, int idVenta)
        {
            bool exito = false;
            decimal deudaNueva = Convert.ToDecimal(deudaGuardar);
            try
            {
                bool ExisteCC = DAO.ConsultarDao.BuscarCCExistente(idCliente);
                decimal DeudaVieja = DAO.ConsultarDao.BuscarDeudaExistente(idCliente);
                if (DeudaVieja >= 0 & ExisteCC == true)
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
                    exito = DAO.AgregarDao.InsertarCuentaCorriente(idCliente, deudaNueva);
                    if (exito == true)
                    {
                        exito = DAO.AgregarDao.InsertarDetalleCuentaCorriente(idCliente, deudaNueva, fecha, idVenta);
                    }
                    else { }
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
            {
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
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
                const string message = "Error en el sistema. Intente nuevamente o comuniquese con el administrador.";
                const string caption = "Atención";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Warning);
                throw new Exception();
            }
            return _lista;
        }
    }
}
