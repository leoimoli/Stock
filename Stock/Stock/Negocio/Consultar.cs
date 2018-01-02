using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;

namespace Stock.Negocio
{
    public static class Consultar
    {
        public static List<Usuarios> LoginUsuario(string usuario, string contraseña)
        {
            List<Entidades.Usuarios> lista = new List<Entidades.Usuarios>();
            lista = DAO.ConsultarDao.LoginUsuario(usuario, contraseña);
            int idUsuario = Convert.ToInt32(lista[0].IdUsuario.ToString());
            //ActualizarDAO.ActualizarUltimaConexion(idUsuario);
            return lista;
        }
        public static bool ValidarUsuarioExistente(string dni)
        {
            bool existe = DAO.ConsultarDao.ValidarUsuarioExistente(dni);
            return existe;
        }
        public static List<Usuarios> ListaDeUsuarios()
        {
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            try
            {
                _listaUsuarios = DAO.ConsultarDao.ListarUsuarios();
            }
            catch (Exception ex)
            { }
            return _listaUsuarios;
        }
        public static List<Usuarios> BuscarUsuarioPorID(int idUsuarioSeleccionado)
        {
            List<Usuarios> _listaUsuarios = new List<Usuarios>();
            try
            {
                _listaUsuarios = DAO.ConsultarDao.BuscarUsuarioPorID(idUsuarioSeleccionado);
            }
            catch (Exception ex)
            { }
            return _listaUsuarios;
        }
    }
}
