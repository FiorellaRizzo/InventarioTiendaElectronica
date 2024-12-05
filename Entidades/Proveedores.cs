using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        #region Atributos
        private int id;
        private string nombre;
        private string contacto;
        #endregion

        #region Constructor
        // Constructor por defecto
        public Proveedor()
        {
           
        }

        // Constructor con parámetros
        public Proveedor(int id, string nombre, string contacto)
        {
            this.id = id;
            this.nombre = nombre;
            this.contacto = contacto;
        }
        #endregion

        #region Propiedades/Encapsulamiento
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; }
        }
        #endregion
    }
}
