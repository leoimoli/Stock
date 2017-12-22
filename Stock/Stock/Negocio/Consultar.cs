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
    }
}
