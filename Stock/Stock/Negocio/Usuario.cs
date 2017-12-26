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
                MessageBox.Show("EL CAMPO DNI ES OBLIGATORIO.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Apellido))
            {
                MessageBox.Show("EL CAMPO APELLIDO ES OBLIGATORIO.");
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_usuario.Nombre))
            {
                MessageBox.Show("EL CAMPO NOMBRE ES OBLIGATORIO.");
                throw new Exception();
            }
            if (_usuario.Contraseña != _usuario.Contraseña2)
            {
                MessageBox.Show("LAS CONTRASEÑAS INGRESADAS NO COINCIDEN.");
                throw new Exception();
            }
        }
    }
}
