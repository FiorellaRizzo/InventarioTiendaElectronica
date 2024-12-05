namespace Entidades
{
    public class Categoria
    {
        #region Atributos
        private int IdCategoria; 
        private string Nombre;
        #endregion

        #region Propiedades
        public int CategoriaId
        {
            get { return IdCategoria; }
            set { IdCategoria = value; }
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
        public Categoria(int IdCategoria, string nombre)
        {
            this.CategoriaId = IdCategoria; // Usar la propiedad en lugar de atributos directamente
            this.CategNombre = nombre;
        }
        #endregion
    }
}

