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
    using System;
    using System.Data;
    using Datos;
    using Entidades;

    public class NegocioProducto
    {
        DatosProducto objDatosProducto = new DatosProducto();

        // Método para Alta, Baja y Modificación de productos
        public int AbmProducto(string accion, Producto objProducto)
        {
            if (ValidarProducto(objProducto))
            {
                return objDatosProducto.AbmProducto(accion, objProducto);
            }
            else
            {
                throw new ArgumentException("El producto no pasó las validaciones.");
            }
        }

        // Método para obtener el listado de productos
        public DataSet ListadoProductos(string codigo)
        {
            return objDatosProducto.ListadoProductos(codigo);
        }

        // Método para eliminar un producto por Codigo
        public bool EliminarProducto(string codigo)
        {
            try
            {
                Producto producto = new Producto();
                producto.Codigo = codigo;
                int resultado = objDatosProducto.AbmProducto("Baja", producto);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto", ex);
            }
        }

        // Método de validación antes de agregar o modificar un producto
        public bool ValidarProducto(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(producto.Codigo))
            {
                throw new ArgumentException("El código del producto no puede estar vacío.");
            }

            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                throw new ArgumentException("El nombre del producto no puede estar vacío.");
            }

            if (producto.Precio <= 0)
            {
                throw new ArgumentException("El precio del producto debe ser mayor a cero.");
            }

            if (producto.Stock < 0)
            {
                throw new ArgumentException("El stock del producto no puede ser negativo.");
            }

            return true;
        }

        // Método para generar un reporte de todos los productos
        public DataTable GenerarReporteProductos()
        {
            DataSet ds = objDatosProducto.ListadoProductos("Todos");

            // Configurar el DataTable para el reporte
            DataTable dtReporte = new DataTable();
            dtReporte.Columns.Add("Código", typeof(string));
            dtReporte.Columns.Add("Nombre", typeof(string));
            dtReporte.Columns.Add("Precio", typeof(decimal));
            dtReporte.Columns.Add("Stock", typeof(int));
            dtReporte.Columns.Add("Categoría ID", typeof(int));
            dtReporte.Columns.Add("Proveedor ID", typeof(int));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dtReporte.Rows.Add(
                    row["Codigo"],
                    row["Nombre"],
                    row["Precio"],
                    row["Stock"],
                    row["CategoriaId"],
                    row["ProveedorId"]
                );
            }

            return dtReporte;
        }
    }
}
