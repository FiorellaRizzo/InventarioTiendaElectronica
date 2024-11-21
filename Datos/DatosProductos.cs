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
                orden = "INSERT INTO Productos (Codigo, Nombre, Precio, Categoria, Proveedor, Stock) VALUES " +
                        "(@Codigo, @Nombre, @Precio, @Categoria, @Proveedor, @Stock)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Productos SET Codigo=@Codigo , Nombre=@Nombre,Precio=@Precio, Categoria=@Categoria,Proveedor=@Proveedor, Stock=@Stock  WHERE Codigo=@Codigo";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Productos WHERE Codigo=@Codigo and Nombre=@Nombre";
            }

            // Configuración del comando SQL
            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Codigo", objProducto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", objProducto.Nombre);
            cmd.Parameters.AddWithValue("@Precio", objProducto.Precio);
            cmd.Parameters.AddWithValue("@Categoria", objProducto.Categoria);
            cmd.Parameters.AddWithValue("@Proveedor", objProducto.Proveedor);
            cmd.Parameters.AddWithValue("@Stock", objProducto.Stock);
            

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
                orden = "SELECT * FROM Productos"; 
            else
                orden = "SELECT * FROM Productos";

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
