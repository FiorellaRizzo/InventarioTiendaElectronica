using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DatosProducto : DatosConexionBD
    {
        // Método para Alta, Baja y Modificación de productos
        public int AbmProducto(string accion, Producto objProducto)
        {
            int resultado = -1;
            string orden = string.Empty;

            // Definir la consulta SQL en función de la acción solicitada
            if (accion == "Alta")
            {
                orden = "INSERT INTO Producto (Codigo, Nombre, Precio, Stock, Categoria_idCategoria, Proveedores_idProveedores) VALUES " +
                        "(@Codigo, @Nombre, @Precio, @Stock, @Categoria_idCategoria, @Proveedores_idProveedores)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Producto SET Nombre=@Nombre, Precio=@Precio, Categoria_idCategoria=@Categoria_idCategoria, Proveedores_idProveedores=@Proveedores_idProveedores, Stock=@Stock " +
                        "WHERE Codigo=@Codigo";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Producto WHERE Codigo=@Codigo";
            }

            // Configuración del comando SQL
            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Codigo", objProducto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", objProducto.Nombre);
            cmd.Parameters.AddWithValue("@Precio", objProducto.Precio);
            cmd.Parameters.AddWithValue("@Stock", objProducto.Stock);
            cmd.Parameters.AddWithValue("@Categoria_idCategoria", objProducto.CategoriaId);
            cmd.Parameters.AddWithValue("@Proveedores_idProveedores", objProducto.ProveedorId);
            

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al realizar la operación de ABM en la tabla Productos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }

        // Método para listar productos
        public DataSet ListadoProductos(string codigo)
        {
            string orden = string.Empty;

            // Definir la consulta SQL para listar productos en función del código o todos
            if (codigo != "Todos")
                orden = "SELECT p.Codigo, p.Nombre, p.Precio, p.Stock, c.Nombre AS Categoria, pr.Nombre AS Proveedor FROM Producto p JOIN Categoria c ON p.Categoria_idCategoria = c.IdCategoria JOIN Proveedores pr ON p.Proveedores_idProveedores = pr.IdProveedores;";
            else
                orden = "SELECT * FROM Producto";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            if (codigo != "Todos")
                cmd.Parameters.AddWithValue("@Codigo", codigo);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                AbrirConexion();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return ds;
        }
    }
}

