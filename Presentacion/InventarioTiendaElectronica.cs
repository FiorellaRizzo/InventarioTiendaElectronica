using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class InventarioTiendaElectronica : Form
    {

        // Instancias de las clases de Entidad y Negocios
        private Producto objEntProducto = new Producto();
        private NegocioProducto objNegProducto = new NegocioProducto();
        private NegocioCategoria objNegCategoria = new NegocioCategoria();
        private NegocioProveedores objNegProveedores = new NegocioProveedores();
        public InventarioTiendaElectronica()
        {
            InitializeComponent();

        }

        private void InventarioTiendaElectronica_Load(object sender, EventArgs e)
        {
            LlenarDGV(); // Carga los productos en el DataGridView al iniciar
            CargarCategorias(); // Cargar los nombres de las categorías
            CargarProveedores();  // Cargar los nombres de los proveedores
        }

        // Método para llenar el DataGridView con productos
        private void LlenarDGV()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = objNegProducto.ListadoProductos("Todos");

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

        // Evento para manejar la selección de categoría en el ComboBox
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                // Cargar el nombre de la categoría seleccionada en el DataGridView
                string categoriaSeleccionada = cmbCategoria.Text;

                // Limpia el DataGridView y muestra solo la categoría seleccionada
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("", "", "", "", categoriaSeleccionada, "");
            }
        }

        private void cmbProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue != null)
            {
                // Cargar el nombre de la categoría seleccionada en el DataGridView
                string ProveedorSeleccionado = cmbCategoria.Text;

                // Limpia el DataGridView y muestra solo la categoría seleccionada
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("", "", "", "", ProveedorSeleccionado, "");
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                Categoria = cmbCategoria.Text,  // Obtén el texto seleccionado
                Proveedor = cmbProveedores.Text // Obtén el texto seleccionado
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
                objEntProducto.Categoria = cmbCategoria.Text.Trim();
                objEntProducto.Proveedor = cmbProveedores.Text.Trim();


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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            bool nResultado = objNegProducto.EliminarProducto(txtCodigo.Text, txtNombre.Text, int.Parse(txtPrecio.Text), int.Parse(txtStock.Text), cmbCategoria.Text, cmbProveedores.Text);

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataSet ds = objNegProducto.ListadoProductos(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                if (ds.Tables[0].Rows.Count > 0)
                {
                    Ds_a_TxtBox(ds);
                    btnAgregar.Visible = false;
                    lblText.Text = string.Empty;
                }

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

        // Método para cargar los datos de los TextBoxes al objeto Producto
        private void TxtBox_a_Obj()
        {
            objEntProducto.Codigo = txtCodigo.Text;
            objEntProducto.Nombre = txtNombre.Text;
            objEntProducto.Stock = int.Parse(txtStock.Text);
            objEntProducto.Categoria = cmbCategoria.Text;
            objEntProducto.Proveedor = cmbProveedores.Text;

        }

        // Método para cargar los datos del DataSet en los TextBoxes
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();

            // Asignar valores al ComboBox de categoría y proveedores
            if (ds.Tables[0].Rows[0]["Categoria"] != DBNull.Value)
            {
                cmbCategoria.SelectedValue = ds.Tables[0].Rows[0]["Categoria"].ToString(); // "Categoria" debe coincidir con la columna de tu DataSet
            }

            if (ds.Tables[0].Rows[0]["Proveedor"] != DBNull.Value)
            {
                cmbProveedores.SelectedValue = ds.Tables[0].Rows[0]["Proveedor"].ToString(); // "Proveedor" debe coincidir con la columna de tu DataSet
            }



            txtCodigo.Enabled = false;
        }


        private void CargarCategorias()

        {
            DataTable dtCategorias = objNegCategoria.ListadoCategorias(); // Método que obtiene los datos de la base de datos

            cmbCategoria.DataSource = dtCategorias;
            cmbCategoria.DisplayMember = "Nombre";  // Muestra el nombre de la categoría
            cmbCategoria.ValueMember = "Nombre";   // Usa el nombre como valor
            cmbCategoria.SelectedIndex = -1;       // Sin selección por defecto
        }

        private void CargarProveedores()

        {
            DataTable dtProveedores = objNegProveedores.ListadoProveedores(); // Obtener los proveedores desde la capa de negocio
            cmbProveedores.DataSource = dtProveedores;
            cmbProveedores.DisplayMember = "Nombre";  // Mostrar el nombre del proveedor
            cmbProveedores.ValueMember = "Nombre";   // Usar el nombre del proveedor como valor
            cmbProveedores.SelectedIndex = -1;       // Sin selección por defecto
        }

        
        

        private void AgregarCategoriaAlComboBox(Categoria categoria)
        {
            // Accede a la fuente de datos actual del ComboBox y agrega la nueva categoría
            var dataSource = (List<Categoria>)cmbCategoria.DataSource;

            if (dataSource != null)
            {
                dataSource.Add(categoria); // Agregar la nueva categoría a la lista
                cmbCategoria.DataSource = null; // Resetear la fuente de datos
                cmbCategoria.DataSource = dataSource; // Asignar la lista actualizada
                cmbCategoria.DisplayMember = "CategNombre"; // Propiedad a mostrar
                cmbCategoria.ValueMember = "CategoriaId";  // Propiedad oculta para el valor
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el ComboBox, fuente de datos no inicializada.");
            }
        }

        private void cmbProveedores_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}    
