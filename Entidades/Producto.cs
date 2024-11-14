using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Producto
    {
        #region Atributos
        private string Codigo;
        private string Nombre;
        private decimal Precio;
        private int Stock;
        private int CategoriaId;
        private int ProveedorId;
        #endregion

        #region Propiedades

        public string ProducCodigo
        {
            set { Codigo = value; }
            get { return Codigo; }

        }

        public string ProducNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public decimal ProducPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        public int ProducStock
        {
            get { return Stock; }
            set { Stock = value; }
        }

        public int ProducCategoriaId
        {
            get { return CategoriaId; }
            set { CategoriaId = value; }
        }

        public int ProducProveedorId
        {
            get { return ProveedorId; }
            set { ProveedorId = value; }
        }

        #endregion

        #region Constructores
        // Constructor por defecto
        public Producto()
        {
        }

        // Constructor con parámetros
        public Producto(string Cod, string nombre, decimal precio, int stock, int categoriaId, int proveedorId)
        {

            this.Codigo = Cod;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.CategoriaId = categoriaId;
            this.ProveedorId = proveedorId;

        }
        #endregion

        #region Metodos
        public void IngresarStock(int cantidad)
        {
            ProducStock += cantidad;
        }

        public bool RetirarStock(int cantidad)
        {
            if (cantidad > ProducStock)
            {
                return false;
            }

            ProducStock -= cantidad;
            return true;
        }

        public void ActualizarProducto(string nombre, decimal precio, int stock, int categoriaId, int proveedorId)
        {
            ProducNombre = nombre;
            ProducPrecio = precio;
            ProducStock = stock;
            ProducCategoriaId = categoriaId;
            ProducProveedorId = proveedorId;
        }
        #endregion
    }
}







    