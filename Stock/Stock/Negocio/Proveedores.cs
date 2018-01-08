using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock.Entidades;
using System.Windows.Forms;

namespace Stock.Negocio
{
    public class Proveedores
    {
        public static bool CargarProducto(Entidades.Proveedores _proveedor)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_proveedor);
                bool ProveedorExistente = Negocio.Consultar.ValidarProveedorExistente(_proveedor.NombreEmpresa);
                if (ProveedorExistente == true)
                {
                    MessageBox.Show("YA EXISTE UN PROVEEDOR REGISTRADO CON EL NOMBRE INGRESADO.");
                    throw new Exception();
                }
                else
                {
                    exito = DAO.AgregarDao.InsertProveedor(_proveedor);
                }
            }
            catch (Exception ex)
            { }
            return exito;
        }

        private static void ValidarDatos(Entidades.Proveedores _proveedor)
        {
            if (String.IsNullOrEmpty(_proveedor.NombreEmpresa))
            {
                MessageBox.Show("EL CAMPO NOMBRE EMPRESA ES OBLIGATORIO.");
                throw new Exception();
            }
        }
        public static bool EditarProducto(Entidades.Proveedores _proveedor, int idProductoGrillaSeleccionado)
        {
            bool exito = false;
            try
            {
                ValidarDatos(_proveedor);
                exito = DAO.EditarDao.EditarProveedor(_proveedor, idProductoGrillaSeleccionado);
            }
            catch (Exception ex)
            { }
            return exito;
        }
    }
}
