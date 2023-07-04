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
                bool ProveedorExistente = Negocio.Consultar.ValidarProveedorExistentePorCuit(_proveedor.Cuit);
                if (ProveedorExistente == true)
                {
                    const string message = "Ya existe un proveedor registrado.";
                    const string caption = "Error";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                               MessageBoxIcon.Exclamation);
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
            if (String.IsNullOrEmpty(_proveedor.Cuit))
            {
                const string message = "El campo Cuit es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
                throw new Exception();
            }
            if (String.IsNullOrEmpty(_proveedor.NombreEmpresa))
            {
                const string message = "El campo nombre es obligatorio.";
                const string caption = "Error";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                           MessageBoxIcon.Exclamation);
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
            {
            }
            return exito;
        }

        public static bool InsertarPagoAProveedores(HistorialPagoProveedores pago)
        {
            bool exito = false;
            try
            {
                exito = DAO.AgregarDao.InsertarPagoAProveedores(pago);
            }
            catch (Exception ex)
            { }
            return exito;
        }
    }
}
