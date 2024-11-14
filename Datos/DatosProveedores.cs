using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
   

    public class DatosProveedores : DatosConexionBD
    {
        // Método para Alta, Baja y Modificación de proveedores
        public int AbmProveedor(string accion, Proveedor objProveedor)
        {
            int resultado = -1;
            string orden = string.Empty;

            // Definir la consulta SQL en función de la acción solicitada
            if (accion == "Alta")
            {
                orden = "INSERT INTO Proveedores (Nombre, Contacto) VALUES (@Nombre, @Contacto)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Proveedores SET Nombre=@Nombre, Contacto=@Contacto WHERE Id=@Id";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Proveedores WHERE Id=@Id";
            }

            // Configuración del comando SQL
            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Nombre", objProveedor.Nombre);
            cmd.Parameters.AddWithValue("@Contacto", objProveedor.Contacto);
            cmd.Parameters.AddWithValue("@Id", objProveedor.Id);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al realizar la operación de ABM en la tabla Proveedores", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }

        // Método para listar proveedores
        public DataSet ListadoProveedores(string id)
        {
            string orden = string.Empty;

            // Definir la consulta SQL para listar proveedores en función del id o todos
            if (id != "Todos")
                orden = "SELECT * FROM Proveedores WHERE Id = @Id";
            else
                orden = "SELECT * FROM Proveedores";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            if (id != "Todos")
                cmd.Parameters.AddWithValue("@Id", int.Parse(id));

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                AbrirConexion();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar proveedores", e);
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
