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
                    const string message = "Ya existe un usuario registrado con el dni ingresado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertUsuario(_usuario);
                }
            }
            catch (Exception ex)
            {

            }
            return exito;
        }
        private static void ValidarDatos(Usuarios _usuario)
        {

            if (String.IsNullOrEmpty(_usuario.Dni))
            {
                const string message = "El campo dni es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Apellido))
            {
                const string message = "El campo apellido es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Nombre))
            {
                const string message = "El campo nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }

            if (String.IsNullOrEmpty(_usuario.Perfil))
            {
                const string message = "El perfil es un campo obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (_usuario.Perfil != "1" & _usuario.Perfil != "2" )
            {
                const string message = "El perfil ingresado es inexistente.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
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
            {

            }
            return exito;
        }
    }
}
