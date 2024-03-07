namespace Proveeduria
{
    partial class frmIngresoFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoFacturas));
            gbxRegistroProductosTitulo = new GroupBox();
            gbxBuscarProveedor = new GroupBox();
            btnBuscarProveedor = new Button();
            lblCodProveedor = new Label();
            txtBuscarProveedor = new TextBox();
            pbLogo = new PictureBox();
            lblProductosTitulo = new Label();
            gbxListaProductos = new GroupBox();
            lvwListaProductos = new ListView();
            colCatProducto = new ColumnHeader();
            colCodProducto = new ColumnHeader();
            colDesProducto = new ColumnHeader();
            colCantidadProducto = new ColumnHeader();
            colPrecioUndProducto = new ColumnHeader();
            colTotal = new ColumnHeader();
            txtMontoIvaFactura = new TextBox();
            lblMontoIvaFactura = new Label();
            txtMontoFactura = new TextBox();
            lblMontoFactura = new Label();
            dtpFechaFactura = new DateTimePicker();
            txtNumeroFactura = new TextBox();
            lblFechaFactura = new Label();
            lblNumeroFactura = new Label();
            gbxFacturasRegistro = new GroupBox();
            gbxIngresoProductos = new GroupBox();
            btnNuevaFactura = new Button();
            lblBuscarProducto = new Label();
            btnBuscarProducto = new Button();
            lblCategoriaProducto = new Label();
            txtBuscarProductoCodigo = new TextBox();
            txtCantidadProducto = new TextBox();
            btnAgregarProducto = new Button();
            txtProductoNombre = new TextBox();
            txtCategoriaProducto = new TextBox();
            lblProductoNombre = new Label();
            btnSalir = new Button();
            lblCantidadProducto = new Label();
            btnLimpiarProducto = new Button();
            txtPrecioUndProducto = new TextBox();
            btnAceptarProducto = new Button();
            lblPrecioUndProducto = new Label();
            gbxDatosProveedor = new GroupBox();
            btnLimpiarDatosProveedor = new Button();
            lblCodigoProveedor = new Label();
            txtCodigoProveedor = new TextBox();
            lblEmailProveedor = new Label();
            lblTelefonoProveedor = new Label();
            txtEmailProveedor = new TextBox();
            txtTelefonoProveedor = new TextBox();
            lblDniProveedor = new Label();
            lblNombreProveedor = new Label();
            txtDniProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            gbxRegistroProductosTitulo.SuspendLayout();
            gbxBuscarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxListaProductos.SuspendLayout();
            gbxFacturasRegistro.SuspendLayout();
            gbxIngresoProductos.SuspendLayout();
            gbxDatosProveedor.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRegistroProductosTitulo
            // 
            gbxRegistroProductosTitulo.Controls.Add(btnNuevaFactura);
            gbxRegistroProductosTitulo.Controls.Add(gbxBuscarProveedor);
            gbxRegistroProductosTitulo.Controls.Add(pbLogo);
            gbxRegistroProductosTitulo.Controls.Add(lblProductosTitulo);
            gbxRegistroProductosTitulo.Dock = DockStyle.Top;
            gbxRegistroProductosTitulo.Location = new Point(0, 0);
            gbxRegistroProductosTitulo.Name = "gbxRegistroProductosTitulo";
            gbxRegistroProductosTitulo.Size = new Size(774, 138);
            gbxRegistroProductosTitulo.TabIndex = 1;
            gbxRegistroProductosTitulo.TabStop = false;
            // 
            // gbxBuscarProveedor
            // 
            gbxBuscarProveedor.Controls.Add(btnBuscarProveedor);
            gbxBuscarProveedor.Controls.Add(lblCodProveedor);
            gbxBuscarProveedor.Controls.Add(txtBuscarProveedor);
            gbxBuscarProveedor.Location = new Point(199, 75);
            gbxBuscarProveedor.Name = "gbxBuscarProveedor";
            gbxBuscarProveedor.Size = new Size(462, 49);
            gbxBuscarProveedor.TabIndex = 2;
            gbxBuscarProveedor.TabStop = false;
            gbxBuscarProveedor.Text = "Buscar Proveedor";
            // 
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProveedor.Location = new Point(311, 12);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(140, 28);
            btnBuscarProveedor.TabIndex = 5;
            btnBuscarProveedor.Text = "Buscar Proveedor";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // lblCodProveedor
            // 
            lblCodProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodProveedor.Location = new Point(6, 19);
            lblCodProveedor.Name = "lblCodProveedor";
            lblCodProveedor.Size = new Size(140, 22);
            lblCodProveedor.TabIndex = 3;
            lblCodProveedor.Text = "Codigo de Proveedor";
            lblCodProveedor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBuscarProveedor
            // 
            txtBuscarProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProveedor.Location = new Point(152, 18);
            txtBuscarProveedor.Name = "txtBuscarProveedor";
            txtBuscarProveedor.Size = new Size(153, 22);
            txtBuscarProveedor.TabIndex = 4;
            txtBuscarProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 19);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(147, 105);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblProductosTitulo
            // 
            lblProductosTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductosTitulo.Location = new Point(257, 9);
            lblProductosTitulo.Name = "lblProductosTitulo";
            lblProductosTitulo.Size = new Size(224, 70);
            lblProductosTitulo.TabIndex = 16;
            lblProductosTitulo.Text = "Ingreso de Facturas  Productos";
            lblProductosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Controls.Add(lvwListaProductos);
            gbxListaProductos.Dock = DockStyle.Bottom;
            gbxListaProductos.Location = new Point(0, 393);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(774, 291);
            gbxListaProductos.TabIndex = 40;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Lista de Productos";
            // 
            // lvwListaProductos
            // 
            lvwListaProductos.BackColor = SystemColors.Info;
            lvwListaProductos.Columns.AddRange(new ColumnHeader[] { colCatProducto, colCodProducto, colDesProducto, colCantidadProducto, colPrecioUndProducto, colTotal });
            lvwListaProductos.Dock = DockStyle.Fill;
            lvwListaProductos.Location = new Point(3, 19);
            lvwListaProductos.Name = "lvwListaProductos";
            lvwListaProductos.Size = new Size(768, 269);
            lvwListaProductos.TabIndex = 41;
            lvwListaProductos.UseCompatibleStateImageBehavior = false;
            lvwListaProductos.View = View.Details;
            // 
            // colCatProducto
            // 
            colCatProducto.Text = "Categoria Producto";
            colCatProducto.Width = 130;
            // 
            // colCodProducto
            // 
            colCodProducto.Text = "Codigo Producto";
            colCodProducto.Width = 120;
            // 
            // colDesProducto
            // 
            colDesProducto.Text = "Producto";
            colDesProducto.Width = 130;
            // 
            // colCantidadProducto
            // 
            colCantidadProducto.Text = "Cantidad Producto";
            colCantidadProducto.Width = 120;
            // 
            // colPrecioUndProducto
            // 
            colPrecioUndProducto.Text = "Precio Unitario";
            colPrecioUndProducto.Width = 120;
            // 
            // colTotal
            // 
            colTotal.Text = "Total Productos";
            colTotal.Width = 120;
            // 
            // txtMontoIvaFactura
            // 
            txtMontoIvaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoIvaFactura.Location = new Point(411, 99);
            txtMontoIvaFactura.Name = "txtMontoIvaFactura";
            txtMontoIvaFactura.ReadOnly = true;
            txtMontoIvaFactura.Size = new Size(116, 22);
            txtMontoIvaFactura.TabIndex = 24;
            txtMontoIvaFactura.TextAlign = HorizontalAlignment.Center;
            txtMontoIvaFactura.KeyPress += txtMontoIvaFactura_KeyPress;
            // 
            // lblMontoIvaFactura
            // 
            lblMontoIvaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoIvaFactura.Location = new Point(290, 99);
            lblMontoIvaFactura.Name = "lblMontoIvaFactura";
            lblMontoIvaFactura.Size = new Size(115, 22);
            lblMontoIvaFactura.TabIndex = 23;
            lblMontoIvaFactura.Text = "Monto IVA";
            lblMontoIvaFactura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMontoFactura
            // 
            txtMontoFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoFactura.Location = new Point(131, 99);
            txtMontoFactura.Name = "txtMontoFactura";
            txtMontoFactura.Size = new Size(153, 22);
            txtMontoFactura.TabIndex = 22;
            txtMontoFactura.TextAlign = HorizontalAlignment.Center;
            txtMontoFactura.KeyPress += txtMontoFactura_KeyPress;
            // 
            // lblMontoFactura
            // 
            lblMontoFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoFactura.Location = new Point(9, 99);
            lblMontoFactura.Name = "lblMontoFactura";
            lblMontoFactura.Size = new Size(116, 22);
            lblMontoFactura.TabIndex = 21;
            lblMontoFactura.Text = "Monto Factura";
            lblMontoFactura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFechaFactura
            // 
            dtpFechaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaFactura.Format = DateTimePickerFormat.Short;
            dtpFechaFactura.Location = new Point(131, 71);
            dtpFechaFactura.Name = "dtpFechaFactura";
            dtpFechaFactura.Size = new Size(152, 22);
            dtpFechaFactura.TabIndex = 18;
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroFactura.Location = new Point(411, 69);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(116, 22);
            txtNumeroFactura.TabIndex = 20;
            txtNumeroFactura.TextAlign = HorizontalAlignment.Center;
            txtNumeroFactura.KeyPress += txtNumeroFactura_KeyPress;
            // 
            // lblFechaFactura
            // 
            lblFechaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaFactura.Location = new Point(9, 74);
            lblFechaFactura.Name = "lblFechaFactura";
            lblFechaFactura.Size = new Size(116, 20);
            lblFechaFactura.TabIndex = 17;
            lblFechaFactura.Text = "Fecha";
            lblFechaFactura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNumeroFactura
            // 
            lblNumeroFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumeroFactura.Location = new Point(289, 69);
            lblNumeroFactura.Name = "lblNumeroFactura";
            lblNumeroFactura.Size = new Size(116, 22);
            lblNumeroFactura.TabIndex = 19;
            lblNumeroFactura.Text = "Factura Numero ";
            lblNumeroFactura.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gbxFacturasRegistro
            // 
            gbxFacturasRegistro.Controls.Add(gbxIngresoProductos);
            gbxFacturasRegistro.Controls.Add(gbxDatosProveedor);
            gbxFacturasRegistro.Dock = DockStyle.Fill;
            gbxFacturasRegistro.Location = new Point(0, 138);
            gbxFacturasRegistro.Name = "gbxFacturasRegistro";
            gbxFacturasRegistro.Size = new Size(774, 255);
            gbxFacturasRegistro.TabIndex = 6;
            gbxFacturasRegistro.TabStop = false;
            gbxFacturasRegistro.Text = "Registro Facturas";
            // 
            // gbxIngresoProductos
            // 
            gbxIngresoProductos.Controls.Add(lblBuscarProducto);
            gbxIngresoProductos.Controls.Add(btnBuscarProducto);
            gbxIngresoProductos.Controls.Add(lblCategoriaProducto);
            gbxIngresoProductos.Controls.Add(txtBuscarProductoCodigo);
            gbxIngresoProductos.Controls.Add(txtCantidadProducto);
            gbxIngresoProductos.Controls.Add(btnAgregarProducto);
            gbxIngresoProductos.Controls.Add(txtProductoNombre);
            gbxIngresoProductos.Controls.Add(txtCategoriaProducto);
            gbxIngresoProductos.Controls.Add(lblProductoNombre);
            gbxIngresoProductos.Controls.Add(btnSalir);
            gbxIngresoProductos.Controls.Add(lblCantidadProducto);
            gbxIngresoProductos.Controls.Add(btnLimpiarProducto);
            gbxIngresoProductos.Controls.Add(txtPrecioUndProducto);
            gbxIngresoProductos.Controls.Add(btnAceptarProducto);
            gbxIngresoProductos.Controls.Add(lblPrecioUndProducto);
            gbxIngresoProductos.Location = new Point(3, 154);
            gbxIngresoProductos.Name = "gbxIngresoProductos";
            gbxIngresoProductos.Size = new Size(771, 114);
            gbxIngresoProductos.TabIndex = 49;
            gbxIngresoProductos.TabStop = false;
            gbxIngresoProductos.Text = "Ingreso Datos Productos Nuevos";
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaFactura.Location = new Point(664, 22);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(98, 45);
            btnNuevaFactura.TabIndex = 43;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            btnNuevaFactura.Click += btnNuevaFactura_Click;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarProducto.Location = new Point(6, 21);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(61, 22);
            lblBuscarProducto.TabIndex = 40;
            lblBuscarProducto.Text = "Codigo";
            lblBuscarProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProducto.Location = new Point(222, 17);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(200, 24);
            btnBuscarProducto.TabIndex = 42;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click_1;
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoriaProducto.Location = new Point(6, 46);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(61, 22);
            lblCategoriaProducto.TabIndex = 28;
            lblCategoriaProducto.Text = "Categoria";
            lblCategoriaProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBuscarProductoCodigo
            // 
            txtBuscarProductoCodigo.AcceptsTab = true;
            txtBuscarProductoCodigo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarProductoCodigo.Location = new Point(73, 22);
            txtBuscarProductoCodigo.Name = "txtBuscarProductoCodigo";
            txtBuscarProductoCodigo.Size = new Size(143, 21);
            txtBuscarProductoCodigo.TabIndex = 41;
            txtBuscarProductoCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.AcceptsTab = true;
            txtCantidadProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadProducto.Location = new Point(303, 47);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(119, 21);
            txtCantidadProducto.TabIndex = 33;
            txtCantidadProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(428, 17);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(133, 24);
            btnAgregarProducto.TabIndex = 36;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click_1;
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoNombre.Location = new Point(73, 74);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.ReadOnly = true;
            txtProductoNombre.Size = new Size(143, 21);
            txtProductoNombre.TabIndex = 31;
            txtProductoNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.AcceptsTab = true;
            txtCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoriaProducto.Location = new Point(73, 47);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.ReadOnly = true;
            txtCategoriaProducto.Size = new Size(143, 21);
            txtCategoriaProducto.TabIndex = 29;
            txtCategoriaProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductoNombre
            // 
            lblProductoNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoNombre.Location = new Point(0, 74);
            lblProductoNombre.Name = "lblProductoNombre";
            lblProductoNombre.Size = new Size(67, 22);
            lblProductoNombre.TabIndex = 30;
            lblProductoNombre.Text = "Producto";
            lblProductoNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(661, 72);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 26);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadProducto.Location = new Point(222, 46);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(75, 22);
            lblCantidadProducto.TabIndex = 32;
            lblCantidadProducto.Text = "Cantidad";
            lblCantidadProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarProducto.Location = new Point(557, 73);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(98, 26);
            btnLimpiarProducto.TabIndex = 38;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            // 
            // txtPrecioUndProducto
            // 
            txtPrecioUndProducto.AcceptsTab = true;
            txtPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUndProducto.Location = new Point(303, 71);
            txtPrecioUndProducto.Name = "txtPrecioUndProducto";
            txtPrecioUndProducto.Size = new Size(119, 21);
            txtPrecioUndProducto.TabIndex = 35;
            txtPrecioUndProducto.TextAlign = HorizontalAlignment.Center;
            txtPrecioUndProducto.KeyPress += txtPrecioUndProducto_KeyPress_1;
            // 
            // btnAceptarProducto
            // 
            btnAceptarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptarProducto.Location = new Point(567, 15);
            btnAceptarProducto.Name = "btnAceptarProducto";
            btnAceptarProducto.Size = new Size(130, 26);
            btnAceptarProducto.TabIndex = 37;
            btnAceptarProducto.Text = "Guardar Factura";
            btnAceptarProducto.UseVisualStyleBackColor = true;
            btnAceptarProducto.Click += btnAceptarProducto_Click_1;
            // 
            // lblPrecioUndProducto
            // 
            lblPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioUndProducto.Location = new Point(222, 73);
            lblPrecioUndProducto.Name = "lblPrecioUndProducto";
            lblPrecioUndProducto.Size = new Size(75, 22);
            lblPrecioUndProducto.TabIndex = 34;
            lblPrecioUndProducto.Text = "Precio Und";
            lblPrecioUndProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gbxDatosProveedor
            // 
            gbxDatosProveedor.Controls.Add(btnLimpiarDatosProveedor);
            gbxDatosProveedor.Controls.Add(lblCodigoProveedor);
            gbxDatosProveedor.Controls.Add(txtMontoIvaFactura);
            gbxDatosProveedor.Controls.Add(lblMontoIvaFactura);
            gbxDatosProveedor.Controls.Add(txtCodigoProveedor);
            gbxDatosProveedor.Controls.Add(lblEmailProveedor);
            gbxDatosProveedor.Controls.Add(lblTelefonoProveedor);
            gbxDatosProveedor.Controls.Add(txtMontoFactura);
            gbxDatosProveedor.Controls.Add(lblMontoFactura);
            gbxDatosProveedor.Controls.Add(txtEmailProveedor);
            gbxDatosProveedor.Controls.Add(txtTelefonoProveedor);
            gbxDatosProveedor.Controls.Add(txtNumeroFactura);
            gbxDatosProveedor.Controls.Add(lblNumeroFactura);
            gbxDatosProveedor.Controls.Add(dtpFechaFactura);
            gbxDatosProveedor.Controls.Add(lblDniProveedor);
            gbxDatosProveedor.Controls.Add(lblFechaFactura);
            gbxDatosProveedor.Controls.Add(lblNombreProveedor);
            gbxDatosProveedor.Controls.Add(txtDniProveedor);
            gbxDatosProveedor.Controls.Add(txtNombreProveedor);
            gbxDatosProveedor.Dock = DockStyle.Top;
            gbxDatosProveedor.Location = new Point(3, 19);
            gbxDatosProveedor.Name = "gbxDatosProveedor";
            gbxDatosProveedor.Size = new Size(768, 129);
            gbxDatosProveedor.TabIndex = 7;
            gbxDatosProveedor.TabStop = false;
            gbxDatosProveedor.Text = "Datos Proveedor";
            // 
            // btnLimpiarDatosProveedor
            // 
            btnLimpiarDatosProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarDatosProveedor.Location = new Point(615, 97);
            btnLimpiarDatosProveedor.Name = "btnLimpiarDatosProveedor";
            btnLimpiarDatosProveedor.Size = new Size(120, 22);
            btnLimpiarDatosProveedor.TabIndex = 26;
            btnLimpiarDatosProveedor.Text = "Limpiar";
            btnLimpiarDatosProveedor.UseVisualStyleBackColor = true;
            btnLimpiarDatosProveedor.Click += btnLimpiarDatosProveedor_Click;
            // 
            // lblCodigoProveedor
            // 
            lblCodigoProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoProveedor.Location = new Point(9, 19);
            lblCodigoProveedor.Name = "lblCodigoProveedor";
            lblCodigoProveedor.Size = new Size(116, 19);
            lblCodigoProveedor.TabIndex = 8;
            lblCodigoProveedor.Text = "Codigo";
            lblCodigoProveedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCodigoProveedor
            // 
            txtCodigoProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoProveedor.Location = new Point(9, 41);
            txtCodigoProveedor.Name = "txtCodigoProveedor";
            txtCodigoProveedor.ReadOnly = true;
            txtCodigoProveedor.Size = new Size(116, 22);
            txtCodigoProveedor.TabIndex = 9;
            txtCodigoProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEmailProveedor
            // 
            lblEmailProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailProveedor.Location = new Point(533, 19);
            lblEmailProveedor.Name = "lblEmailProveedor";
            lblEmailProveedor.Size = new Size(116, 19);
            lblEmailProveedor.TabIndex = 16;
            lblEmailProveedor.Text = "Email";
            lblEmailProveedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTelefonoProveedor
            // 
            lblTelefonoProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefonoProveedor.Location = new Point(411, 19);
            lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            lblTelefonoProveedor.Size = new Size(116, 19);
            lblTelefonoProveedor.TabIndex = 14;
            lblTelefonoProveedor.Text = "Telefono";
            lblTelefonoProveedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmailProveedor
            // 
            txtEmailProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailProveedor.Location = new Point(533, 41);
            txtEmailProveedor.Name = "txtEmailProveedor";
            txtEmailProveedor.ReadOnly = true;
            txtEmailProveedor.Size = new Size(202, 22);
            txtEmailProveedor.TabIndex = 16;
            txtEmailProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefonoProveedor.Location = new Point(411, 41);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.ReadOnly = true;
            txtTelefonoProveedor.Size = new Size(116, 22);
            txtTelefonoProveedor.TabIndex = 15;
            txtTelefonoProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDniProveedor
            // 
            lblDniProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDniProveedor.Location = new Point(289, 19);
            lblDniProveedor.Name = "lblDniProveedor";
            lblDniProveedor.Size = new Size(116, 19);
            lblDniProveedor.TabIndex = 12;
            lblDniProveedor.Text = "Identificacion";
            lblDniProveedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombreProveedor
            // 
            lblNombreProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreProveedor.Location = new Point(131, 19);
            lblNombreProveedor.Name = "lblNombreProveedor";
            lblNombreProveedor.Size = new Size(152, 19);
            lblNombreProveedor.TabIndex = 10;
            lblNombreProveedor.Text = "Proveedor";
            lblNombreProveedor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDniProveedor
            // 
            txtDniProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtDniProveedor.Location = new Point(289, 41);
            txtDniProveedor.Name = "txtDniProveedor";
            txtDniProveedor.ReadOnly = true;
            txtDniProveedor.Size = new Size(116, 22);
            txtDniProveedor.TabIndex = 13;
            txtDniProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreProveedor.Location = new Point(131, 41);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.ReadOnly = true;
            txtNombreProveedor.Size = new Size(152, 22);
            txtNombreProveedor.TabIndex = 11;
            txtNombreProveedor.TextAlign = HorizontalAlignment.Center;
            // 
            // frmIngresoFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 684);
            ControlBox = false;
            Controls.Add(gbxFacturasRegistro);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxRegistroProductosTitulo);
            MinimumSize = new Size(790, 700);
            Name = "frmIngresoFacturas";
            Text = "Ingreso de Facturas";
            Load += frmRegistroProductos_Load;
            gbxRegistroProductosTitulo.ResumeLayout(false);
            gbxBuscarProveedor.ResumeLayout(false);
            gbxBuscarProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxListaProductos.ResumeLayout(false);
            gbxFacturasRegistro.ResumeLayout(false);
            gbxIngresoProductos.ResumeLayout(false);
            gbxIngresoProductos.PerformLayout();
            gbxDatosProveedor.ResumeLayout(false);
            gbxDatosProveedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxRegistroProductosTitulo;
        private PictureBox pbLogo;
        private Label lblProductosTitulo;
        private DataGridViewTextBoxColumn colNombreProducto;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colPrecioVenta;
        private GroupBox gbxListaProductos;
        private Label lblFuncionarioApellidoSegundo;
        private Label lblFuncionarioDNI;
        private TextBox txtFuncionarioCodigo;
        private Label lblFuncionarioCodigo;
        private TextBox txtFuncionarioEmail;
        private Label lblFuncionarioEmail;
        private TextBox txtFuncionarioDNI;
        private TextBox txtNumeroFactura;
        private Label lblNumeroFactura;
        private Label lblFechaFactura;
        private DateTimePicker dtpFechaFactura;
        private TextBox txtMontoFactura;
        private Label lblMontoFactura;
        private GroupBox gbxFacturasRegistro;
        private Label lblCodProveedor;
        private Button btnBuscarProveedor;
        private TextBox txtBuscarProveedor;
        private GroupBox gbxBuscarProveedor;
        private GroupBox gbxDatosProveedor;
        private Label lblCodigoProveedor;
        private TextBox txtCodigoProveedor;
        private Label lblEmailProveedor;
        private Label lblTelefonoProveedor;
        private TextBox txtEmailProveedor;
        private TextBox txtTelefonoProveedor;
        private Label lblDniProveedor;
        private Label lblNombreProveedor;
        private TextBox txtDniProveedor;
        private TextBox txtNombreProveedor;
        private TextBox txtMontoIvaFactura;
        private Label lblMontoIvaFactura;
        private Button btnLimpiarDatosProveedor;
        private ListView lvwListaProductos;
        private ColumnHeader colCatProducto;
        private ColumnHeader colCodProducto;
        private ColumnHeader colDesProducto;
        private ColumnHeader colPrecioUndProducto;
        private ColumnHeader colCantidadProducto;
        private GroupBox gbxIngresoProductos;
        private Label lblBuscarProducto;
        private Button btnBuscarProducto;
        private Label lblCategoriaProducto;
        private TextBox txtBuscarProductoCodigo;
        private TextBox txtCantidadProducto;
        private Button btnAgregarProducto;
        private TextBox txtProductoNombre;
        private TextBox txtCategoriaProducto;
        private Label lblProductoNombre;
        private Button btnSalir;
        private Label lblCantidadProducto;
        private Button btnLimpiarProducto;
        private TextBox txtPrecioUndProducto;
        private Button btnAceptarProducto;
        private Label lblPrecioUndProducto;
        private ColumnHeader colTotal;
        private Button btnNuevaFactura;
    }
}