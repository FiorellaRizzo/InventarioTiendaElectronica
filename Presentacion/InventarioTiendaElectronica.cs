using System;
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
            ConfigurarDataGridView();
            LlenarComboBoxCategorias();
            LlenarComboBoxProveedores();
            LlenarDGV();

            

        }

        private void InventarioTiendaElectronica_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // Configura el DataGridView
        private void ConfigurarDataGridView()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Precio";
            dataGridView1.Columns[3].HeaderText = "Stock";
            dataGridView1.Columns[4].HeaderText = "Categoría";
            dataGridView1.Columns[5].HeaderText = "Proveedor";

            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 60;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
        }

        // Llena el ComboBox de Categorías
        private void LlenarComboBoxCategorias()
        {
            DataSet dsCategorias = objNegCategoria.ListadoCategorias("Todos");
            cmbCategoria.DataSource = dsCategorias.Tables[0];
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
        }

        // Llena el ComboBox de Proveedores
        private void LlenarComboBoxProveedores()
        {
            DataSet dsProveedores = objNegProveedores.ListadoProveedores("Todos");
            cmbProveedores.DataSource = dsProveedores.Tables[0];
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "Id";
        }

        // Llena el DataGridView con los productos existentes
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
                        dr["CategoriaId"],
                        dr["ProveedorId"]
                    );
                }
            }
            else
            {
                lblText.Text = "No hay productos cargados en el sistema";
            }
        }

        // Método para cargar los datos de los TextBoxes al objeto Producto
        private void TxtBox_a_Obj()
        {
            objEntProducto.Codigo = txtCodigo.Text;
            objEntProducto.Nombre = txtNombre.Text;
            objEntProducto.Precio = decimal.Parse(txtPrecio.Text);
            objEntProducto.Stock = int.Parse(txtStock.Text);
            objEntProducto.CategoriaId = (int)cmbCategoria.SelectedValue;
            objEntProducto.ProveedorId = (int)cmbProveedores.SelectedValue;
        }

        // Evento Click para agregar un producto
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;
            TxtBox_a_Obj();
            nGrabados = objNegProducto.AbmProducto("Alta", objEntProducto);

            if (nGrabados == -1)
            {
                lblText.Text = "No se pudo grabar el producto en el sistema";
            }
            else
            {
                lblText.Text = "Producto grabado con éxito";
                LlenarDGV();
                Limpiar();
            }
        }

        // Evento CellClick del DataGridView para seleccionar un producto y cargar sus datos en los TextBoxes
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        // Método para cargar los datos del DataSet en los TextBoxes
        private void Ds_a_TxtBox(DataSet ds)
        {
            txtCodigo.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtPrecio.Text = ds.Tables[0].Rows[0]["Precio"].ToString();
            txtStock.Text = ds.Tables[0].Rows[0]["Stock"].ToString();
            cmbCategoria.SelectedValue = ds.Tables[0].Rows[0]["CategoriaId"];
            cmbProveedores.SelectedValue = ds.Tables[0].Rows[0]["ProveedorId"];
            txtCodigo.Enabled = false;
        }

        // Evento Click para modificar un producto
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
            bool nResultado = objNegProducto.EliminarProducto(txtCodigo.Text);

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
    }

}

