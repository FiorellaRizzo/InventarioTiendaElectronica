using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocio
{
    
    public class NegocioProveedores
    {
        
        // Atributo de tipo DatosProveedores para acceder a la capa de Datos
        DatosProveedores objDatosProveedores = new DatosProveedores();

        // Método para Alta, Baja y Modificación de proveedores
        public int AbmProveedor(string accion, Proveedor objProveedor)
        {
            if (ValidarProveedor(objProveedor))
            {
                return objDatosProveedores.AbmProveedor(accion, objProveedor);
            }
            else
            {
                throw new ArgumentException("El proveedor no pasó las validaciones.");
            }
        }

        // Método para obtener el listado de proveedores
        public DataSet ListadoProveedores(string id)
        {
            return objDatosProveedores.ListadoProveedores(id);
        }

        // Método para eliminar un proveedor por Id
        public bool EliminarProveedor(int id)
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.Id = id;
                int resultado = objDatosProveedores.AbmProveedor("Baja", proveedor);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el proveedor", ex);
            }
        }

        // Método de validación antes de agregar o modificar un proveedor
        public bool ValidarProveedor(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
            {
                throw new ArgumentException("El nombre del proveedor no puede estar vacío.");
            }

            if (proveedor.Nombre.Length > 100)
            {
                throw new ArgumentException("El nombre del proveedor no puede tener más de 100 caracteres.");
            }

            if (!string.IsNullOrEmpty(proveedor.Contacto) && proveedor.Contacto.Length > 100)
            {
                throw new ArgumentException("El contacto del proveedor no puede tener más de 100 caracteres.");
            }

            return true;
        }

        // Método para generar un reporte de todos los proveedores
        public DataTable GenerarReporteProveedores()
        {
            DataSet ds = objDatosProveedores.ListadoProveedores("Todos");

            // Configurar el DataTable para el reporte
            DataTable dtReporte = new DataTable();
            dtReporte.Columns.Add("ID", typeof(int));
            dtReporte.Columns.Add("Nombre del Proveedor", typeof(string));
            dtReporte.Columns.Add("Contacto", typeof(string));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dtReporte.Rows.Add(
                    row["Id"],
                    row["Nombre"],
                    row["Contacto"]
                );
            }

            return dtReporte;
        }
    }
}
    