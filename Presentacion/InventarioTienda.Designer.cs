namespace Presentacion
{
    partial class InventarioTienda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProductPage = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lbProveedores = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.CatePage = new System.Windows.Forms.TabPage();
            this.cmbEliminarCat = new System.Windows.Forms.ComboBox();
            this.cmbModificarCat = new System.Windows.Forms.ComboBox();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAgregarCat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnModificarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNombreCat = new System.Windows.Forms.Label();
            this.ProvPage = new System.Windows.Forms.TabPage();
            this.txtNuevoContProv = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAgregarContProv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbEliminarProv = new System.Windows.Forms.ComboBox();
            this.cmbModificarProv = new System.Windows.Forms.ComboBox();
            this.txtNuevoNombreProv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgregarNomProv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAgregarProv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRespProv = new System.Windows.Forms.Label();
            this.btnModificarProv = new System.Windows.Forms.Button();
            this.btnEliminarProv = new System.Windows.Forms.Button();
            this.btnAgregarProv = new System.Windows.Forms.Button();
            this.dataGridViewProv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ProductPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CatePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.ProvPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductPage);
            this.tabControl1.Controls.Add(this.CatePage);
            this.tabControl1.Controls.Add(this.ProvPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1391, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductPage
            // 
            this.ProductPage.Controls.Add(this.label15);
            this.ProductPage.Controls.Add(this.lblText);
            this.ProductPage.Controls.Add(this.btnModificar);
            this.ProductPage.Controls.Add(this.btnEliminar);
            this.ProductPage.Controls.Add(this.btnAgregar);
            this.ProductPage.Controls.Add(this.dataGridView1);
            this.ProductPage.Controls.Add(this.cmbProveedores);
            this.ProductPage.Controls.Add(this.cmbCategoria);
            this.ProductPage.Controls.Add(this.txtStock);
            this.ProductPage.Controls.Add(this.txtPrecio);
            this.ProductPage.Controls.Add(this.txtCodigo);
            this.ProductPage.Controls.Add(this.txtNombre);
            this.ProductPage.Controls.Add(this.lblCategoria);
            this.ProductPage.Controls.Add(this.lblPrecio);
            this.ProductPage.Controls.Add(this.lblStock);
            this.ProductPage.Controls.Add(this.lbProveedores);
            this.ProductPage.Controls.Add(this.lblNombre);
            this.ProductPage.Controls.Add(this.lblCodigo);
            this.ProductPage.Location = new System.Drawing.Point(4, 25);
            this.ProductPage.Name = "ProductPage";
            this.ProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductPage.Size = new System.Drawing.Size(1383, 529);
            this.ProductPage.TabIndex = 0;
            this.ProductPage.Text = "Productos";
            this.ProductPage.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(134, 40);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 50;
            this.label15.Text = "Productos";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(166, 459);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(146, 16);
            this.lblText.TabIndex = 35;
            this.lblText.Text = "Esperando respuesta...";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(729, 363);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 38);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(887, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 38);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(561, 363);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 42);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Categoria,
            this.Proveedores});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(478, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 206);
            this.dataGridView1.TabIndex = 30;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 85;
            // 
            // Precio
            // 
            this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 75;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Stock.HeaderText = "Stock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Width = 70;
            // 
            // Categoria
            // 
            this.Categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 95;
            // 
            // Proveedores
            // 
            this.Proveedores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Proveedores.HeaderText = "Proveedores";
            this.Proveedores.MinimumWidth = 6;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Width = 115;
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(169, 371);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(258, 24);
            this.cmbProveedores.TabIndex = 29;
            this.cmbProveedores.UseWaitCursor = true;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(169, 309);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCategoria.Size = new System.Drawing.Size(258, 24);
            this.cmbCategoria.TabIndex = 28;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(169, 252);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 22);
            this.txtStock.TabIndex = 27;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(169, 196);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 26;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(169, 96);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 25;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(169, 144);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 24;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(48, 317);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 16);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoría";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(48, 199);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(48, 255);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(46, 16);
            this.lblStock.TabIndex = 21;
            this.lblStock.Text = "Stock";
            // 
            // lbProveedores
            // 
            this.lbProveedores.AutoSize = true;
            this.lbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProveedores.Location = new System.Drawing.Point(48, 376);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(97, 16);
            this.lbProveedores.TabIndex = 20;
            this.lbProveedores.Text = "Proveedores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(48, 147);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 16);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(48, 99);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código";
            // 
            // CatePage
            // 
            this.CatePage.Controls.Add(this.cmbEliminarCat);
            this.CatePage.Controls.Add(this.cmbModificarCat);
            this.CatePage.Controls.Add(this.txtNombreCat);
            this.CatePage.Controls.Add(this.label6);
            this.CatePage.Controls.Add(this.txtAgregarCat);
            this.CatePage.Controls.Add(this.label5);
            this.CatePage.Controls.Add(this.label4);
            this.CatePage.Controls.Add(this.label3);
            this.CatePage.Controls.Add(this.label2);
            this.CatePage.Controls.Add(this.label1);
            this.CatePage.Controls.Add(this.lblCat);
            this.CatePage.Controls.Add(this.btnModificarCat);
            this.CatePage.Controls.Add(this.btnEliminarCat);
            this.CatePage.Controls.Add(this.btnAgregarCat);
            this.CatePage.Controls.Add(this.dataGridViewCategoria);
            this.CatePage.Controls.Add(this.lblNombreCat);
            this.CatePage.Location = new System.Drawing.Point(4, 25);
            this.CatePage.Name = "CatePage";
            this.CatePage.Padding = new System.Windows.Forms.Padding(3);
            this.CatePage.Size = new System.Drawing.Size(1383, 529);
            this.CatePage.TabIndex = 1;
            this.CatePage.Text = "Categorías";
            this.CatePage.UseVisualStyleBackColor = true;
            // 
            // cmbEliminarCat
            // 
            this.cmbEliminarCat.FormattingEnabled = true;
            this.cmbEliminarCat.Location = new System.Drawing.Point(210, 392);
            this.cmbEliminarCat.Name = "cmbEliminarCat";
            this.cmbEliminarCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEliminarCat.Size = new System.Drawing.Size(258, 24);
            this.cmbEliminarCat.TabIndex = 60;
            // 
            // cmbModificarCat
            // 
            this.cmbModificarCat.FormattingEnabled = true;
            this.cmbModificarCat.Location = new System.Drawing.Point(212, 225);
            this.cmbModificarCat.Name = "cmbModificarCat";
            this.cmbModificarCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbModificarCat.Size = new System.Drawing.Size(258, 24);
            this.cmbModificarCat.TabIndex = 59;
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNombreCat.Location = new System.Drawing.Point(212, 276);
            this.txtNombreCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(260, 22);
            this.txtNombreCat.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nuevo Nombre Categoría";
            // 
            // txtAgregarCat
            // 
            this.txtAgregarCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgregarCat.Location = new System.Drawing.Point(210, 98);
            this.txtAgregarCat.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgregarCat.Name = "txtAgregarCat";
            this.txtAgregarCat.Size = new System.Drawing.Size(260, 22);
            this.txtAgregarCat.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(45, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Eliminar categoría de la lista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(45, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Agregar categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(45, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Modificar nombre de categoría";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Location = new System.Drawing.Point(105, 461);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(146, 16);
            this.lblCat.TabIndex = 46;
            this.lblCat.Text = "Esperando respuesta...";
            // 
            // btnModificarCat
            // 
            this.btnModificarCat.Location = new System.Drawing.Point(490, 233);
            this.btnModificarCat.Name = "btnModificarCat";
            this.btnModificarCat.Size = new System.Drawing.Size(85, 30);
            this.btnModificarCat.TabIndex = 45;
            this.btnModificarCat.Text = "Modificar";
            this.btnModificarCat.UseVisualStyleBackColor = true;
            this.btnModificarCat.Click += new System.EventHandler(this.btnModificarCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(490, 391);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(92, 25);
            this.btnEliminarCat.TabIndex = 44;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(490, 98);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(87, 28);
            this.btnAgregarCat.TabIndex = 43;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategoria.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewCategoria.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(692, 57);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.RowHeadersWidth = 51;
            this.dataGridViewCategoria.RowTemplate.Height = 24;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(616, 387);
            this.dataGridViewCategoria.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lista De Categorias";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 141;
            // 
            // lblNombreCat
            // 
            this.lblNombreCat.AutoSize = true;
            this.lblNombreCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCat.Location = new System.Drawing.Point(46, 101);
            this.lblNombreCat.Name = "lblNombreCat";
            this.lblNombreCat.Size = new System.Drawing.Size(62, 16);
            this.lblNombreCat.TabIndex = 36;
            this.lblNombreCat.Text = "Nombre";
            // 
            // ProvPage
            // 
            this.ProvPage.Controls.Add(this.txtNuevoContProv);
            this.ProvPage.Controls.Add(this.label17);
            this.ProvPage.Controls.Add(this.txtAgregarContProv);
            this.ProvPage.Controls.Add(this.label10);
            this.ProvPage.Controls.Add(this.cmbEliminarProv);
            this.ProvPage.Controls.Add(this.cmbModificarProv);
            this.ProvPage.Controls.Add(this.txtNuevoNombreProv);
            this.ProvPage.Controls.Add(this.label7);
            this.ProvPage.Controls.Add(this.txtAgregarNomProv);
            this.ProvPage.Controls.Add(this.label8);
            this.ProvPage.Controls.Add(this.label9);
            this.ProvPage.Controls.Add(this.lblAgregarProv);
            this.ProvPage.Controls.Add(this.label11);
            this.ProvPage.Controls.Add(this.label12);
            this.ProvPage.Controls.Add(this.lblRespProv);
            this.ProvPage.Controls.Add(this.btnModificarProv);
            this.ProvPage.Controls.Add(this.btnEliminarProv);
            this.ProvPage.Controls.Add(this.btnAgregarProv);
            this.ProvPage.Controls.Add(this.dataGridViewProv);
            this.ProvPage.Controls.Add(this.label14);
            this.ProvPage.Location = new System.Drawing.Point(4, 25);
            this.ProvPage.Name = "ProvPage";
            this.ProvPage.Size = new System.Drawing.Size(1383, 529);
            this.ProvPage.TabIndex = 2;
            this.ProvPage.Text = "Proveedores";
            this.ProvPage.UseVisualStyleBackColor = true;
            // 
            // txtNuevoContProv
            // 
            this.txtNuevoContProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNuevoContProv.Location = new System.Drawing.Point(226, 306);
            this.txtNuevoContProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoContProv.Name = "txtNuevoContProv";
            this.txtNuevoContProv.Size = new System.Drawing.Size(260, 22);
            this.txtNuevoContProv.TabIndex = 82;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(27, 312);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 16);
            this.label17.TabIndex = 81;
            this.label17.Text = "Nuevo Contacto";
            // 
            // txtAgregarContProv
            // 
            this.txtAgregarContProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgregarContProv.Location = new System.Drawing.Point(110, 118);
            this.txtAgregarContProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgregarContProv.Name = "txtAgregarContProv";
            this.txtAgregarContProv.Size = new System.Drawing.Size(260, 22);
            this.txtAgregarContProv.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Contacto";
            // 
            // cmbEliminarProv
            // 
            this.cmbEliminarProv.FormattingEnabled = true;
            this.cmbEliminarProv.Location = new System.Drawing.Point(228, 458);
            this.cmbEliminarProv.Name = "cmbEliminarProv";
            this.cmbEliminarProv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbEliminarProv.Size = new System.Drawing.Size(258, 24);
            this.cmbEliminarProv.TabIndex = 76;
            // 
            // cmbModificarProv
            // 
            this.cmbModificarProv.FormattingEnabled = true;
            this.cmbModificarProv.Location = new System.Drawing.Point(230, 206);
            this.cmbModificarProv.Name = "cmbModificarProv";
            this.cmbModificarProv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbModificarProv.Size = new System.Drawing.Size(258, 24);
            this.cmbModificarProv.TabIndex = 75;
            // 
            // txtNuevoNombreProv
            // 
            this.txtNuevoNombreProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNuevoNombreProv.Location = new System.Drawing.Point(230, 253);
            this.txtNuevoNombreProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtNuevoNombreProv.Name = "txtNuevoNombreProv";
            this.txtNuevoNombreProv.Size = new System.Drawing.Size(260, 22);
            this.txtNuevoNombreProv.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Nuevo Proveedor";
            // 
            // txtAgregarNomProv
            // 
            this.txtAgregarNomProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgregarNomProv.Location = new System.Drawing.Point(110, 60);
            this.txtAgregarNomProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtAgregarNomProv.Name = "txtAgregarNomProv";
            this.txtAgregarNomProv.Size = new System.Drawing.Size(260, 22);
            this.txtAgregarNomProv.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(26, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 70;
            this.label9.Text = "Eliminar Proveedor";
            // 
            // lblAgregarProv
            // 
            this.lblAgregarProv.AutoSize = true;
            this.lblAgregarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarProv.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAgregarProv.Location = new System.Drawing.Point(29, 18);
            this.lblAgregarProv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgregarProv.Name = "lblAgregarProv";
            this.lblAgregarProv.Size = new System.Drawing.Size(166, 20);
            this.lblAgregarProv.TabIndex = 69;
            this.lblAgregarProv.Text = "Agregar Proveedor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 68;
            this.label11.Text = "Nombre ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(26, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 20);
            this.label12.TabIndex = 67;
            this.label12.Text = "Modificar nombre de categoría";
            // 
            // lblRespProv
            // 
            this.lblRespProv.AutoSize = true;
            this.lblRespProv.Location = new System.Drawing.Point(734, 435);
            this.lblRespProv.Name = "lblRespProv";
            this.lblRespProv.Size = new System.Drawing.Size(146, 16);
            this.lblRespProv.TabIndex = 66;
            this.lblRespProv.Text = "Esperando respuesta...";
            // 
            // btnModificarProv
            // 
            this.btnModificarProv.Location = new System.Drawing.Point(528, 249);
            this.btnModificarProv.Name = "btnModificarProv";
            this.btnModificarProv.Size = new System.Drawing.Size(85, 30);
            this.btnModificarProv.TabIndex = 65;
            this.btnModificarProv.Text = "Modificar";
            this.btnModificarProv.UseVisualStyleBackColor = true;
            this.btnModificarProv.Click += new System.EventHandler(this.btnModificarProv_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.Location = new System.Drawing.Point(528, 457);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Size = new System.Drawing.Size(92, 25);
            this.btnEliminarProv.TabIndex = 64;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.UseVisualStyleBackColor = true;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click_1);
            // 
            // btnAgregarProv
            // 
            this.btnAgregarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarProv.Location = new System.Drawing.Point(535, 95);
            this.btnAgregarProv.Name = "btnAgregarProv";
            this.btnAgregarProv.Size = new System.Drawing.Size(87, 28);
            this.btnAgregarProv.TabIndex = 63;
            this.btnAgregarProv.Text = "Agregar";
            this.btnAgregarProv.UseVisualStyleBackColor = true;
            this.btnAgregarProv.Click += new System.EventHandler(this.btnAgregarProv_Click);
            // 
            // dataGridViewProv
            // 
            this.dataGridViewProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Contacto});
            this.dataGridViewProv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewProv.Location = new System.Drawing.Point(721, 50);
            this.dataGridViewProv.Name = "dataGridViewProv";
            this.dataGridViewProv.RowHeadersWidth = 51;
            this.dataGridViewProv.RowTemplate.Height = 24;
            this.dataGridViewProv.Size = new System.Drawing.Size(555, 323);
            this.dataGridViewProv.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Lista De Proveedores";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 153;
            // 
            // Contacto
            // 
            this.Contacto.HeaderText = "Contacto";
            this.Contacto.MinimumWidth = 6;
            this.Contacto.Name = "Contacto";
            this.Contacto.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 16);
            this.label14.TabIndex = 61;
            this.label14.Text = "Nombre";
            // 
            // InventarioTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 630);
            this.Controls.Add(this.tabControl1);
            this.Name = "InventarioTienda";
            this.Text = "Inventario Tienda Electrónica";
            this.Load += new System.EventHandler(this.InventarioTienda_Load);
            this.tabControl1.ResumeLayout(false);
            this.ProductPage.ResumeLayout(false);
            this.ProductPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CatePage.ResumeLayout(false);
            this.CatePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ProvPage.ResumeLayout(false);
            this.ProvPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductPage;
        private System.Windows.Forms.TabPage CatePage;
        private System.Windows.Forms.TabPage ProvPage;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lbProveedores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.Label lblNombreCat;
        private System.Windows.Forms.Button btnModificarCat;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAgregarCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedores;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.ComboBox cmbEliminarCat;
        private System.Windows.Forms.ComboBox cmbModificarCat;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.ComboBox cmbEliminarProv;
        private System.Windows.Forms.ComboBox cmbModificarProv;
        private System.Windows.Forms.TextBox txtNuevoNombreProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgregarNomProv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAgregarProv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblRespProv;
        private System.Windows.Forms.Button btnModificarProv;
        private System.Windows.Forms.Button btnEliminarProv;
        private System.Windows.Forms.Button btnAgregarProv;
        private System.Windows.Forms.DataGridView dataGridViewProv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAgregarContProv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNuevoContProv;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contacto;
    }
}