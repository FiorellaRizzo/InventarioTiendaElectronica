using System;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{


    public class DatosCategorias : DatosConexionBD
    
    {
        

        public DataTable ListadoCategorias()
        {
            using (SqlConnection conexion = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=InventarioTiendaE;Integrated Security=True;"))
            {
                string query = "SELECT IdCategoria, Nombre FROM Categoria";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }


        // Método para Alta, Baja y Modificación de categorías
        public int AbmCategoria(string accion, Categoria objCategoria)
        {
            int resultado = -1;
            string orden = string.Empty;

            // Definir la consulta SQL en función de la acción solicitada
            if (accion == "Alta")
            {
                orden = "INSERT INTO Categoria (Nombre) VALUES (@Nombre)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Categoria SET Nombre=@Nombre WHERE IdCategoria=@IdCategoria";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Categoria WHERE IdCategoria=@IdCategoria";
            }

            // Configuración del comando SQL
            SqlCommand cmd = new SqlCommand(orden, conexion);
            cmd.Parameters.AddWithValue("@Nombre", objCategoria.CategNombre);
            cmd.Parameters.AddWithValue("@IdCategoria", objCategoria.CategoriaId);

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
        public DataSet ListadoCategorias(string nombre)
        {
            string orden = string.Empty;

            // Definir la consulta SQL para listar categorías en función del id o todas
            if (nombre != "Todos")
                orden = "SELECT * FROM Categoria WHERE Nombre = @Nombre";
            else
                orden = "SELECT * FROM Categoria";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            if (nombre != "Todos")
               cmd.Parameters.AddWithValue("@Nombre", nombre);

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
