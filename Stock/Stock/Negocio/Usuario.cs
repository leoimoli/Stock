using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Usuario
    {
        public static bool CargarUsuario(Usuarios _usuario)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_usuario);
                bool UsuarioExistente = Negocio.Consultar.ValidarUsuarioExistente(_usuario.Dni);
                if (UsuarioExistente == true)
                {
                    MessageBox.Show("YA EXISTE UN USUARIO REGISTRADO CON EL DNI INGRESADO.");
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertUsuario(_usuario);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }
        private static void ValidarDatos(Usuarios _usuario)
        {

            if (String.IsNullOrEmpty(_usuario.Dni))
            {
                MessageBox.Show("El campo dni es obligatorio..");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Apellido))
            {
                MessageBox.Show("El campo apellido es obligatorio.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Nombre))
            {
                MessageBox.Show("El campo nombre es obligatorio.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Contraseña))
            {
                MessageBox.Show("El campo contraseña es obligatorio. ");
                throw new Exception();
            }
            if (_usuario.Contraseña != _usuario.Contraseña2)
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Perfil))
            {
                MessageBox.Show("El perfil es un campo obligatorio.");
                throw new Exception();
            }
            if (_usuario.Perfil != "ADMINISTRADOR" || _usuario.Perfil != "OPERADOR")
            {
                MessageBox.Show("El perfil ingresado es inexistente.");
                throw new Exception();
            }
        }
        public static bool EditarUsuario(Usuarios _usuario, int idusuario)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_usuario);
                exito = DAO.EditarDao.EditarUsuario(_usuario, idusuario);
            }
            catch (Exception ex)
            { }
            return exito;
        }
    }
}
