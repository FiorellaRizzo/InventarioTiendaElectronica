using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Negocio
{
    public class NegocioCategoria

    {


        DatosCategorias objDatosCategoria = new DatosCategorias();

        public DataTable ListadoCategorias()
        {
            DatosCategorias datosCategoria = new DatosCategorias();
            return datosCategoria.ListadoCategorias();
        }


        // Método para Alta, Baja y Modificación de categorías
        public int AbmCategoria(string accion, Categoria objCategoria)
        {
            return objDatosCategoria.AbmCategoria(accion, objCategoria);
        }

        // Método para obtener el listado de categorías

        public DataSet ListadoCategorias(string nombre)
        {
            return objDatosCategoria.ListadoCategorias(nombre);
        }
       

        // Método para eliminar una categoría por Id
        public bool EliminarCategoria(int id)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.CategoriaId = id;
                int resultado = objDatosCategoria.AbmCategoria("Baja", categoria);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la categoría", ex);
            }
        }

        // Método de validación antes de agregar o modificar una categoría
        public bool ValidarCategoria(Categoria categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.CategNombre))
            {
                throw new ArgumentException("El nombre de la categoría no puede estar vacío.");
            }

            if (categoria.CategNombre.Length > 100)
            {
                throw new ArgumentException("El nombre de la categoría no puede tener más de 100 caracteres.");
            }

            return true;
        }

      


        // Método para generar un reporte de todas las categorías
        public DataTable GenerarReporteCategorias()
        {
            DataSet ds = objDatosCategoria.ListadoCategorias("Todos");

            // Configurar el DataTable para el reporte
            DataTable dtReporte = new DataTable();
            dtReporte.Columns.Add("ID", typeof(int));
            dtReporte.Columns.Add("Nombre de la Categoría", typeof(string));

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dtReporte.Rows.Add(row["Id"], row["Nombre"]);
            }

            return dtReporte;
        }

        


    }

}
