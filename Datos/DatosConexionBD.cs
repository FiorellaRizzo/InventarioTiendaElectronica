﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace Datos
{
    public class DatosConexionBD
    {
        // Objeto de conexión a la base de datos
        public SqlConnection conexion;

        // Cadena de conexión - Actualiza "YourServerName" y "YourDatabaseName"
        public string cadenaConexion = @"Server=(localdb)\MSSQLLocalDB;Database=InventarioTiendaE;Integrated Security=True;";
        //public string cadenaConexion2 = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Desktop\InventarioTienda.mdf;Integrated Security = True; Connect Timeout = 30;";


        // Constructor
        public DatosConexionBD()
        {
            // Inicializa la conexión con la cadena de conexión configurada
            conexion = new SqlConnection(cadenaConexion);
        }

        // Método para abrir la conexión
        public void AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed || conexion.State == ConnectionState.Broken)
                {
                    conexion.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }

}
