using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Marca
    {
        public static bool CargarMarca(Entidades.Marca _marca)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_marca);
                bool MarcaExistente = Negocio.Consultar.ValidarMarcaExistente(_marca.NombreMarca);
                if (MarcaExistente == true)
                {
                    const string message = "Ya existe una marca registrada con el mismo nombre.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertMarca(_marca);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarDatos(Entidades.Marca _marca)
        {
            if (String.IsNullOrEmpty(_marca.NombreMarca))
            {
                const string message = "El campo nombre de marca es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
        }
    }
}
