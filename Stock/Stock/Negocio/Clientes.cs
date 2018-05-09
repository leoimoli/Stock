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
            { }
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
        internal static bool EditarCliente(Entidades.Clientes _cliente, int idUsuarioSeleccionado)
        {
            throw new NotImplementedException();
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
    }
}
