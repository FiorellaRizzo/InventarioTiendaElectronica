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
        private string categoria;
        private string proveedor;
        private int stock;
        public decimal precio;

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
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Proveedor
        {
            get { return proveedor; }
            set { proveedor = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        
        
        #endregion

        #region Constructores
        // Constructor por defecto
        public Producto() { }

        // Constructor con parámetros
        public Producto(string codigo, string nombre, decimal precio, string categoria, string proveedor, int stock)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.proveedor = proveedor;
            this.stock = stock;
           
        }
        #endregion
    }
}

      







    