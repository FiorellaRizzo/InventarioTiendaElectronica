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
        private string codigo;
        private string nombre;
        private decimal precio;
        private int stock;
        private int categoriaId;
        private int proveedorId;
        #endregion

        #region Propiedades
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int CategoriaId
        {
            get { return categoriaId; }
            set { categoriaId = value; }
        }

        public int ProveedorId
        {
            get { return proveedorId; }
            set { proveedorId = value; }
        }
        #endregion

        #region Constructores
        // Constructor por defecto
        public Producto() { }

        // Constructor con parámetros
        public Producto(string codigo, string nombre, decimal precio, int stock, int categoriaId, int proveedorId)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
            this.categoriaId = categoriaId;
            this.proveedorId = proveedorId;
        }
        #endregion
    }
}

      







    