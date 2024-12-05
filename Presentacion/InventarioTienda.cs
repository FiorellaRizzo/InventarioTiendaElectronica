using Entidades;
using Negocio;
using System;
using System.Data;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class InventarioTienda : Form


    {

        // Instancias de las clases de Entidad y Negocios
        private Producto objEntProducto = new Producto();
        private Categoria objEntCategoria = new Categoria();
        private Proveedor objEntProveedor = new Proveedor();
        private NegocioProducto objNegProducto = new NegocioProducto();
        private NegocioCategoria objNegCategoria = new NegocioCategoria();
        private NegocioProveedores objNegProveedores = new NegocioProveedores();

        public InventarioTienda()
        {
            InitializeComponent();
        }

        private void InventarioTienda_Load(object sender, EventArgs e)
        {
            LlenarDGV(); // Carga los productos en el DataGridView al iniciar
            CargarCategoriasProducto(); // Cargar los nombres de las categorías
            CargarCategoriasModificar();
            CargarCategoriasEliminar();
            CargarProveedores();  // Cargar los nombres de los proveedores
            CargarProveedoresModificar();
            CargarProveedoresEliminar();
            LlenarDGVCategoria();
            LlenarDGVProveedores();
        }


       //----------------------------------------PRODUCTO------------------------------------------

        // Método para llenar el DataGridView con productos
        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = objNegProducto.ListadoProductos("codigo");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(
                        dr["Codigo"].ToString(),
                        dr["Nombre"],
                        dr["Precio"],
                        dr["Stock"],
                        dr["Categoria"], // Nombre de la categoría
                        dr["Proveedor"]
                    );
                }
            }
            else
            {
                lblText.Text = "No hay productos cargados en el sistema.";
            }
        }

        // Método para limpiar los TextBoxes y restablecer el formulario
        private void Limpiar()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            cmbCategoria.SelectedIndex = -1;
            cmbProveedores.SelectedIndex = -1;
            btnAgregar.Visible = true;
            txtCodigo.Enabled = true;
        }

    
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto

            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                CategoriaId = (int)cmbCategoria.SelectedValue, // Usa el Id de la categoría
                ProveedorId = (int)cmbProveedores.SelectedValue // Usa el Id del proveedor
            };


            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text) ||


                cmbCategoria.SelectedIndex == -1 ||
                cmbProveedores.SelectedIndex == -1)
            {
                lblText.Text = "Por favor, complete todos los campos obligatorios.";
                return;
            }



            try
            {
                // Asigna los valores de los controles al objeto Producto
                objEntProducto.Codigo = txtCodigo.Text.Trim();
                objEntProducto.Nombre = txtNombre.Text.Trim();
                objEntProducto.Precio = int.Parse(txtPrecio.Text.Trim());
                objEntProducto.Stock = int.Parse(txtStock.Text.Trim());
                objEntProducto.CategoriaId = (int)cmbCategoria.SelectedValue;
                objEntProducto.ProveedorId = (int)cmbProveedores.SelectedValue;



                // Llama a la capa de negocio para agregar el producto
                int resultado = objNegProducto.AbmProducto("Alta", objEntProducto);

                if (resultado > 0)
                {
                    lblText.Text = "Producto agregado con éxito.";
                    MessageBox.Show("Producto agregado correctamente.");
                    LlenarDGV();  // Actualiza el DataGridView
                    Limpiar();    // Limpia los campos de entrada
                }
                else
                {
                    lblText.Text = "Error al intentar agregar el producto.";
                    MessageBox.Show("Error al agregar el producto.");
                }
            }
            catch (Exception ex)
            {
                lblText.Text = $"Error al guardar el producto: {ex.Message}";
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            {
                int nResultado = -1;
                TxtBox_a_Obj();
                nResultado = objNegProducto.AbmProducto("Modificar", objEntProducto);

                if (nResultado != -1)
                {
                    lblText.Text = "El producto fue modificado con éxito";
                    Limpiar();
                    LlenarDGV();
                    txtCodigo.Enabled = true;
                }
                else
                {
                    lblText.Text = "Error al intentar modificar el producto";
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores seleccionados a enteros (IDs)
                int categoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
                int proveedorId = Convert.ToInt32(cmbProveedores.SelectedValue);

                // Llamar al método EliminarProducto con los valores correctos
                bool nResultado = objNegProducto.EliminarProducto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    int.Parse(txtPrecio.Text),
                    int.Parse(txtStock.Text),
                    categoriaId,
                    proveedorId
                );

                if (nResultado)
                {
                    lblText.Text = "El producto fue eliminado con éxito.";
                    Limpiar();
                    LlenarDGV();
                    txtCodigo.Enabled = true;
                }
                else
                {
                    lblText.Text = "Error al intentar eliminar el producto.";
                }
            }
            catch (Exception ex)
            {
                lblText.Text = $"Ocurrió un error: {ex.Message}";
            }
        }

  

        // Método para cargar los datos de los TextBoxes al objeto Producto
        private void TxtBox_a_Obj()
        {
            // Asignar valores básicos
            objEntProducto.Codigo = txtCodigo.Text;
            objEntProducto.Nombre = txtNombre.Text;
            objEntProducto.Stock = int.Parse(txtStock.Text);
            objEntProducto.Precio = decimal.Parse(txtPrecio.Text);

            // Asignar claves foráneas (ID de categoría y proveedor) desde los ComboBox
            if (cmbCategoria.SelectedValue != null)
            {
                objEntProducto.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue);
            }
            else
            {
                throw new Exception("Debe seleccionar una categoría válida.");
            }

            if (cmbProveedores.SelectedValue != null)
            {
                objEntProducto.ProveedorId = Convert.ToInt32(cmbProveedores.SelectedValue);
            }
            else
            {
                throw new Exception("Debe seleccionar un proveedor válido.");
            }
        }

        

        // Método para cargar los datos del DataSet en los TextBoxes
        private void Ds_a_TxtBox(DataSet ds)
        {
            // Asignar valores a los TextBoxes
            txtCodigo.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();

            // Asignar valores al ComboBox de categoría y proveedores
            if (ds.Tables[0].Rows[0]["CategoriaId"] != DBNull.Value)
            {
                cmbCategoria.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["CategoriaId"]); // Usa "CategoriaId" de la base de datos
            }
            else
            {
                cmbCategoria.SelectedIndex = -1; // Limpia la selección si es NULL
            }

            if (ds.Tables[0].Rows[0]["ProveedorId"] != DBNull.Value)
            {
                cmbProveedores.SelectedValue = Convert.ToInt32(ds.Tables[0].Rows[0]["ProveedorId"]); // Usa "ProveedorId" de la base de datos
            }
            else
            {
                cmbProveedores.SelectedIndex = -1; // Limpia la selección si es NULL
            }

            // Deshabilitar el campo de código
            txtCodigo.Enabled = false;
        }

        private void CargarCategoriasProducto()
        {
            // Obtener las categorías desde la capa de negocio
            DataTable dtCategorias = objNegCategoria.ListadoCategorias(); // Asegúrate de que este método devuelva las columnas "CategoriaId" y "CategNombre"

            // Configurar el ComboBox de categorías
            cmbCategoria.DataSource = dtCategorias;
            cmbCategoria.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría al usuario
            cmbCategoria.ValueMember = "IdCategoria";   // Usar el ID de la categoría como valor interno
            cmbCategoria.SelectedIndex = -1;           // Sin selección por defecto
        }

       

        private void CargarProveedores()
        {
            // Obtener los proveedores desde la capa de negocio
            DataTable dtProveedores = objNegProveedores.ListadoProveedores(); // Asegúrate de que este método devuelva las columnas "ProveedorId" y "ProveedorNombre"

            // Configurar el ComboBox de proveedores
            cmbProveedores.DataSource = dtProveedores;
            cmbProveedores.DisplayMember = "Nombre";  // Mostrar el nombre del proveedor al usuario
            cmbProveedores.ValueMember = "IdProveedores";       // Usar el ID del proveedor como valor interno
            cmbProveedores.SelectedIndex = -1;               // Sin selección por defecto
        }


     

        //--------------------------------------------CATEGORIA---------------------------------------
        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria

            {

                CategNombre = txtAgregarCat.Text,

            };

            // Validación de campos obligatorios
            if (
                string.IsNullOrWhiteSpace(txtAgregarCat.Text))


            {
                lblText.Text = "Por favor, complete todos los campos obligatorios.";
                return;
            }



            try
            {
                // Asigna los valores de los controles al objeto Producto

                objEntCategoria.CategNombre = txtAgregarCat.Text.Trim();


                // Llama a la capa de negocio para agregar la categoria
                int resultado = objNegCategoria.AbmCategoria("Alta", objEntCategoria);

                if (resultado > 0)
                {
                    lblCat.Text = "Categoría agregada con éxito.";
                    MessageBox.Show("Categoría agregado correctamente.");
                    LlenarDGVCategoria();  // Actualiza el DataGridView
                    LimpiarCategoria();    // Limpia los campos de entrada
                }
                else
                {
                    lblCat.Text = "Error al intentar agregar la Categoría.";
                    MessageBox.Show("Error al agregar la Categoría.");
                }
            }
            catch (Exception ex)
            {
                lblCat.Text = $"Error al cargar la Categoría: {ex.Message}";
            }
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {

            {
                int nResultado = -1;
                TxtBox_a_ObjCatModificar();
                nResultado = objNegCategoria.AbmCategoria("Modificar", objEntCategoria);

                if (nResultado != -1)
                {
                    lblCat.Text = "La categoría fue modificado con éxito";
                    LimpiarCategoria();
                    LlenarDGVCategoria();

                }
                else
                {
                    lblCat.Text = "Error al intentar modificar la categoría";
                }

            }
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {

            int nResultado = -1;
            TxtBox_a_ObjCatEliminar();
            nResultado = objNegCategoria.AbmCategoria("Baja", objEntCategoria);

            if (nResultado != -1)
            {
                lblCat.Text = "La categoría fue eliminada con éxito";
                LimpiarCategoria();
                LlenarDGVCategoria();

            }
            else
            {
                lblCat.Text = "Error al intentar eliminar la categoría";
            }

        }


        private void TxtBox_a_ObjCatModificar()
        {
            // Asignar el nombre de la categoría desde el TextBox


            objEntCategoria.CategNombre = txtNombreCat.Text.Trim();


            // Asignar el ID de la categoría desde el ComboBox
            if (cmbModificarCat.SelectedValue != null)
            {
                objEntCategoria.CategoriaId = Convert.ToInt32(cmbModificarCat.SelectedValue);
            }
            else
            {
                throw new Exception("Debe seleccionar una categoría válida.");
            }

        }
        private void TxtBox_a_ObjCatEliminar()
        {
            // Asignar el nombre de la categoría desde el TextBox

            
            objEntCategoria.CategNombre = cmbEliminarCat.Text.Trim();

         
            // Asignar el ID de la categoría desde el ComboBox
            if (cmbEliminarCat.SelectedValue != null)
            {
                objEntCategoria.CategoriaId = Convert.ToInt32(cmbEliminarCat.SelectedValue);
            }
            else
            {
                throw new Exception("Debe seleccionar una categoría válida.");
            }

        }

        private void CargarCategoriasModificar()
        {
            // Obtener las categorías desde la capa de negocio
            DataTable dtCategorias = objNegCategoria.ListadoCategorias();

            // Configurar el ComboBox de categorías
            cmbModificarCat.DataSource = dtCategorias;
            cmbModificarCat.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría al usuario
            cmbModificarCat.ValueMember = "IdCategoria";   // Usar el ID de la categoría como valor interno
            cmbModificarCat.SelectedIndex = -1;           // Sin selección por defecto
        }
        private void CargarCategoriasEliminar()
        {
            // Obtener las categorías desde la capa de negocio
            DataTable dtCategorias = objNegCategoria.ListadoCategorias();

            // Configurar el ComboBox de categorías
            cmbEliminarCat.DataSource = dtCategorias;
            cmbEliminarCat.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría al usuario
            cmbEliminarCat.ValueMember = "IdCategoria";   // Usar el ID de la categoría como valor interno
            cmbEliminarCat.SelectedIndex = -1;           // Sin selección por defecto
        }
        private void LlenarDGVCategoria()
        {
            dataGridViewCategoria.Rows.Clear();
            DataSet ds = objNegCategoria.ListadoCategorias("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridViewCategoria.Rows.Add(

                        dr["Nombre"]

                    );
                }
            }
            else
            {
                lblText.Text = "No hay categorías cargadas en el sistema.";
            }
        }


        // Método para limpiar los TextBoxes y restablecer el formulario
        private void LimpiarCategoria()
        {
            txtAgregarCat.Text = string.Empty;
            cmbModificarCat.SelectedIndex = -1;
            cmbEliminarCat.SelectedIndex = -1;
            txtNombreCat.Text = string.Empty;

            CargarCategoriasModificar();
            CargarCategoriasEliminar();
            CargarCategoriasProducto();
        }

     


        //-------------------------------------------PROVEEDORES------------------------------------------
        private void LlenarDGVProveedores()
        {


            dataGridViewProv.Rows.Clear();
            DataSet ds = objNegProveedores.ListadoProveedores("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridViewProv.Rows.Add(

                        dr["Nombre"],
                        dr["Contacto"]

                    );
                }
            }
            else
            {
                lblText.Text = "No hay proveedores cargados en el sistema.";
            }

        }

        // Método para limpiar los TextBoxes y restablecer el formulario
        private void LimpiarProveedores()
        {
            txtAgregarNomProv.Text = string.Empty;
            txtAgregarContProv.Text = string.Empty;
            txtNuevoNombreProv.Text = string.Empty;
            txtNuevoContProv.Text = string.Empty;

            cmbModificarProv.SelectedIndex = -1;
            cmbEliminarProv.SelectedIndex = -1;
           

            CargarProveedoresModificar();
            CargarProveedoresEliminar();
            CargarProveedores();

        }

        
        private void CargarProveedoresModificar()
        {
            // Obtener las categorías desde la capa de negocio
            DataTable dtProveedor = objNegProveedores.ListadoProveedores();

            // Configurar el ComboBox de categorías
            cmbModificarProv.DataSource = dtProveedor;
            cmbModificarProv.DisplayMember = "Nombre";  // Mostrar el nombre del proveedor al usuario
            cmbModificarProv.ValueMember = "IdProveedores";   // Usar el ID de la proveedor como valor interno
            cmbModificarProv.SelectedIndex = -1;           // Sin selección por defecto
        }


        // Método para cargar los datos de los TextBoxes al objeto Proveedores

        private void TxtBox_a_ObjProv()
        {
            // Asignar valores básicos
            objEntProveedor.Nombre = txtNuevoNombreProv.Text;
            objEntProveedor.Contacto = txtNuevoContProv.Text;

            // Asignar claves foráneas (ID de proveedor) desde los ComboBox
            if (cmbModificarProv.SelectedValue != null)
            {
                objEntProveedor.Id = Convert.ToInt32(cmbModificarProv.SelectedValue);
            }
            else
            {
                throw new Exception("Debe seleccionar un proveedor válido.");
            }

        }

        private void TxtBox_a_ObjProvEliminar()
        {
            // Asignar el nombre del provedor desde el TextBox


            objEntProveedor.Nombre = cmbEliminarProv.Text.Trim();


            // Asignar el ID del provedor desde el ComboBox
            if (cmbEliminarProv.SelectedValue != null)
            {
                objEntProveedor.Id = Convert.ToInt32(cmbEliminarProv.SelectedValue);
                objEntProveedor.Contacto = cmbEliminarProv.DataSource.ToString();
            }
            else
            {
                throw new Exception("Debe seleccionar un proveedor válido.");
            }

        }

        private void CargarProveedoresEliminar()
        {
            // Obtener las categorías desde la capa de negocio
            DataTable dtProveedor = objNegProveedores.ListadoProveedores();

            // Configurar el ComboBox de categorías
            cmbEliminarProv.DataSource = dtProveedor;
            cmbEliminarProv.DisplayMember = "Nombre";  // Mostrar el nombre de la categoría al usuario
            cmbEliminarProv.ValueMember = "IdProveedores";   // Usar el ID de la categoría como valor interno
            cmbEliminarProv.SelectedIndex = -1;           // Sin selección por defecto
        }



        private void btnAgregarProv_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor

            {

                Nombre = txtAgregarNomProv.Text,
                Contacto = txtAgregarContProv.Text,


            };

            // Validación de campos obligatorios
            if (string.IsNullOrWhiteSpace(txtAgregarNomProv.Text) ||
                string.IsNullOrWhiteSpace(txtAgregarContProv.Text))

            {
                lblText.Text = "Por favor, complete todos los campos obligatorios.";
                return;
            }



            try
            {
                // Asigna los valores de los controles al objeto Producto

                objEntProveedor.Nombre = txtAgregarNomProv.Text.Trim();
                objEntProveedor.Contacto = txtAgregarContProv.Text.Trim();


                // Llama a la capa de negocio para agregar la categoria
                int resultado = objNegProveedores.AbmProveedor("Alta", objEntProveedor);

                if (resultado > 0)
                {
                    lblRespProv.Text = "Proveedor agregado con éxito.";
                    MessageBox.Show("Proveedor agregado correctamente.");
                    LlenarDGVProveedores();  // Actualiza el DataGridView
                    LimpiarProveedores();    // Limpia los campos de entrada
                }
                else
                {
                    lblRespProv.Text = "Error al intentar agregar nuevo proveedor.";
                    MessageBox.Show("Error al agregar proveedor.");
                }
            }
            catch (Exception ex)
            {
                lblRespProv.Text = $"Error al cargar proveedor: {ex.Message}";
            }
        }

        private void btnModificarProv_Click(object sender, EventArgs e)
        {
            {
                int nResultado = -1;
                TxtBox_a_ObjProv();
                nResultado = objNegProveedores.AbmProveedor("Modificar", objEntProveedor);

                if (nResultado != -1)
                {
                    lblRespProv.Text = "El proveedor fue modificado con éxito";
                    LimpiarProveedores();
                    LlenarDGVProveedores();

                }
                else
                {
                    lblRespProv.Text = "Error al intentar modificar proveedor";
                }
            }
        }

        private void btnEliminarProv_Click_1(object sender, EventArgs e)
        {

            int nResultado = -1;
            TxtBox_a_ObjProvEliminar();
            nResultado = objNegProveedores.AbmProveedor("Baja", objEntProveedor);

            if (nResultado != -1)
            {
                lblRespProv.Text = "La categoría fue eliminada con éxito";
                LimpiarProveedores();
                LlenarDGVProveedores();

            }
            else
            {
                lblRespProv.Text = "Error al intentar eliminar la categoría";
            }

        }

        
    }

}






            
    



