namespace Entidades
{
    public class Categoria
    {
        #region Atributos
        private int Id; // Cambia "string" por un nombre válido
        private string nombre;
        #endregion

        #region Propiedades
        public int CategoriaId
        {
            get { return Id; }
            set { Id = value; }
        }

        public string CategNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region Constructores
        // Constructor por defecto
        public Categoria()
        {
        }

        // Constructor con parámetros
        public Categoria(int Id, string nombre)
        {
            this.CategoriaId = Id; // Usar la propiedad en lugar de atributos directamente
            this.CategNombre = nombre;
        }
        #endregion
    }
}

