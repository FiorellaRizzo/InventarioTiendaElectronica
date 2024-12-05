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
       
        private int stock;
        private decimal precio;
        private int Categoria_idCategoria; // Clave foránea para Categoría
        private int Proveedores_idProveedores; // Clave foránea para Proveedor
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
            get { return Categoria_idCategoria; }
            set { Categoria_idCategoria = value; }
        }

        public int ProveedorId
        {
            get { return Proveedores_idProveedores; }
            set { Proveedores_idProveedores = value; }
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
            this.Categoria_idCategoria = categoriaId;
            this.Proveedores_idProveedores = proveedorId;
        }
        #endregion
    }
}








