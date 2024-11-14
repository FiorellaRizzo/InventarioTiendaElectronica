using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        #region Atributos
        private int Id;
        private string Nombre;
        #endregion

        #region Propiedades

        public int CategCodigo
        {
            get { return Id; }
            set { Id = value; }
        }

        public string CategNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        #endregion

        #region Constructores
        // Constructor por defecto
        public Categoria()
        {
        }

        // Constructor con parámetros
        public Categoria(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }
        #endregion

        
    }

}
