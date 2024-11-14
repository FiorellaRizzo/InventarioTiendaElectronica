using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{


    public class DatosCategorias : DatosConexionBD
    {
        // Método para Alta, Baja y Modificación de categorías
        public int AbmCategoria(string accion, Categoria objCategoria)
        {
            int resultado = -1;
            string orden = string.Empty;

            // Definir la consulta SQL en función de la acción solicitada
            if (accion == "Alta")
            {
                orden = "INSERT INTO Categorias (Nombre) VALUES (@Nombre)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Categorias SET Nombre=@Nombre WHERE Id=@Id";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Categorias WHERE Id=@Id";
            }

            // Configuración del comando SQL
            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Nombre", objCategoria.CategNombre);
            cmd.Parameters.AddWithValue("@Id", objCategoria.CategCodigo);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al realizar la operación de ABM en la tabla Categorias", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return resultado;
        }

        // Método para listar categorías
        public DataSet ListadoCategorias(string id)
        {
            string orden = string.Empty;

            // Definir la consulta SQL para listar categorías en función del id o todas
            if (id != "Todos")
                orden = "SELECT * FROM Categorias WHERE Id = @Id";
            else
                orden = "SELECT * FROM Categorias";

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
                throw new Exception("Error al listar categorías", e);
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
