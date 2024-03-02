namespace Proveeduria
{
    partial class frmVentasFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentasFacturacion));
            gbxVentasTitulo = new GroupBox();
            gbxClienteModificar = new GroupBox();
            btnBuscarCliente = new Button();
            txtBuscarCliente = new TextBox();
            lblBuscarCodigoCliente = new Label();
            pbLogo = new PictureBox();
            lblVentasTitulo = new Label();
            gbxVentasDatosCliente = new GroupBox();
            gbxCodigoProducto = new GroupBox();
            txtCantidadProducto = new TextBox();
            lblCantidadProducto = new Label();
            btnAgregarProducto = new Button();
            lblCodigoProducto = new Label();
            txtCodigoProducto = new TextBox();
            txtApellidoSegundo = new TextBox();
            txtApellidoPrimero = new TextBox();
            txtCodigoCliente = new TextBox();
            lblCodigoCliente = new Label();
            txtTipoIdentificacion = new TextBox();
            lblTipoIdentificacion = new Label();
            lblVentasFecha = new Label();
            dtpVentaFecha = new DateTimePicker();
            txtTelefono = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblClienteNombre = new Label();
            txtIdntificacion = new TextBox();
            lblClienteDNI = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            gbxVentasPago = new GroupBox();
            lblMontoIVARes = new Label();
            lblMontoIVA = new Label();
            btnNuevaFactura = new Button();
            btnVentasPagar = new Button();
            txtPagoEfectivo = new TextBox();
            lblVantasPago = new Label();
            label1 = new Label();
            lblVentasCambio = new Label();
            lblVentasFormaPago = new Label();
            cboVentasFormaPago = new ComboBox();
            lblTotalRes = new Label();
            lblVentasTotal = new Label();
            lblSubTotalRes = new Label();
            lblVentasSubTotal = new Label();
            gbxVentasDatos = new GroupBox();
            gbxVentasProductos = new GroupBox();
            lvwListaVenta = new ListView();
            colCategoriaProducto = new ColumnHeader();
            colCodigoProducto = new ColumnHeader();
            colProducto = new ColumnHeader();
            colCantidadProducto = new ColumnHeader();
            colPrecioUnitario = new ColumnHeader();
            colTotalProducto = new ColumnHeader();
            gbxVentasTitulo.SuspendLayout();
            gbxClienteModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxVentasDatosCliente.SuspendLayout();
            gbxCodigoProducto.SuspendLayout();
            gbxVentasPago.SuspendLayout();
            gbxVentasDatos.SuspendLayout();
            gbxVentasProductos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxVentasTitulo
            // 
            gbxVentasTitulo.Controls.Add(gbxClienteModificar);
            gbxVentasTitulo.Controls.Add(pbLogo);
            gbxVentasTitulo.Controls.Add(lblVentasTitulo);
            gbxVentasTitulo.Dock = DockStyle.Top;
            gbxVentasTitulo.Location = new Point(0, 0);
            gbxVentasTitulo.Name = "gbxVentasTitulo";
            gbxVentasTitulo.Size = new Size(774, 114);
            gbxVentasTitulo.TabIndex = 1;
            gbxVentasTitulo.TabStop = false;
            // 
            // gbxClienteModificar
            // 
            gbxClienteModificar.Controls.Add(btnBuscarCliente);
            gbxClienteModificar.Controls.Add(txtBuscarCliente);
            gbxClienteModificar.Controls.Add(lblBuscarCodigoCliente);
            gbxClienteModificar.Location = new Point(154, 45);
            gbxClienteModificar.Name = "gbxClienteModificar";
            gbxClienteModificar.Size = new Size(348, 47);
            gbxClienteModificar.TabIndex = 2;
            gbxClienteModificar.TabStop = false;
            gbxClienteModificar.Text = "Buscar Cliente";
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(255, 18);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(87, 23);
            btnBuscarCliente.TabIndex = 5;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCliente.Location = new Point(114, 19);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(135, 22);
            txtBuscarCliente.TabIndex = 3;
            txtBuscarCliente.TextAlign = HorizontalAlignment.Center;
            txtBuscarCliente.KeyPress += txtBuscarCliente_KeyPress;
            // 
            // lblBuscarCodigoCliente
            // 
            lblBuscarCodigoCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarCodigoCliente.Location = new Point(8, 19);
            lblBuscarCodigoCliente.Name = "lblBuscarCodigoCliente";
            lblBuscarCodigoCliente.Size = new Size(100, 22);
            lblBuscarCodigoCliente.TabIndex = 4;
            lblBuscarCodigoCliente.Text = "Codigo Cliente";
            lblBuscarCodigoCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(130, 92);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblVentasTitulo
            // 
            lblVentasTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasTitulo.Location = new Point(254, 12);
            lblVentasTitulo.Name = "lblVentasTitulo";
            lblVentasTitulo.Size = new Size(301, 30);
            lblVentasTitulo.TabIndex = 16;
            lblVentasTitulo.Text = "Ventas Distribuidora La Zarzuela";
            lblVentasTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxVentasDatosCliente
            // 
            gbxVentasDatosCliente.Controls.Add(gbxCodigoProducto);
            gbxVentasDatosCliente.Controls.Add(txtApellidoSegundo);
            gbxVentasDatosCliente.Controls.Add(txtApellidoPrimero);
            gbxVentasDatosCliente.Controls.Add(txtCodigoCliente);
            gbxVentasDatosCliente.Controls.Add(lblCodigoCliente);
            gbxVentasDatosCliente.Controls.Add(txtTipoIdentificacion);
            gbxVentasDatosCliente.Controls.Add(lblTipoIdentificacion);
            gbxVentasDatosCliente.Controls.Add(lblVentasFecha);
            gbxVentasDatosCliente.Controls.Add(dtpVentaFecha);
            gbxVentasDatosCliente.Controls.Add(txtTelefono);
            gbxVentasDatosCliente.Controls.Add(txtNombre);
            gbxVentasDatosCliente.Controls.Add(lblTelefono);
            gbxVentasDatosCliente.Controls.Add(lblClienteNombre);
            gbxVentasDatosCliente.Controls.Add(txtIdntificacion);
            gbxVentasDatosCliente.Controls.Add(lblClienteDNI);
            gbxVentasDatosCliente.Controls.Add(lblEmail);
            gbxVentasDatosCliente.Controls.Add(txtEmail);
            gbxVentasDatosCliente.Dock = DockStyle.Top;
            gbxVentasDatosCliente.Location = new Point(3, 19);
            gbxVentasDatosCliente.Name = "gbxVentasDatosCliente";
            gbxVentasDatosCliente.Size = new Size(768, 157);
            gbxVentasDatosCliente.TabIndex = 5;
            gbxVentasDatosCliente.TabStop = false;
            gbxVentasDatosCliente.Text = "Datos Clientes";
            // 
            // gbxCodigoProducto
            // 
            gbxCodigoProducto.Controls.Add(txtCantidadProducto);
            gbxCodigoProducto.Controls.Add(lblCantidadProducto);
            gbxCodigoProducto.Controls.Add(btnAgregarProducto);
            gbxCodigoProducto.Controls.Add(lblCodigoProducto);
            gbxCodigoProducto.Controls.Add(txtCodigoProducto);
            gbxCodigoProducto.Location = new Point(0, 98);
            gbxCodigoProducto.Name = "gbxCodigoProducto";
            gbxCodigoProducto.Size = new Size(774, 58);
            gbxCodigoProducto.TabIndex = 24;
            gbxCodigoProducto.TabStop = false;
            gbxCodigoProducto.Text = "Ingrese El Codigo del Producto";
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(357, 22);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(154, 23);
            txtCantidadProducto.TabIndex = 9;
            txtCantidadProducto.KeyPress += txtCantidadProducto_KeyPress;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadProducto.Location = new Point(230, 23);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(121, 22);
            lblCantidadProducto.TabIndex = 8;
            lblCantidadProducto.Text = "Cantidad Producto";
            lblCantidadProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(517, 22);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(125, 23);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoProducto.Location = new Point(6, 23);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(58, 22);
            lblCodigoProducto.TabIndex = 6;
            lblCodigoProducto.Text = "Codigo";
            lblCodigoProducto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(70, 22);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(154, 23);
            txtCodigoProducto.TabIndex = 10;
            txtCodigoProducto.KeyPress += txtCodigoProducto_KeyPress;
            // 
            // txtApellidoSegundo
            // 
            txtApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoSegundo.Location = new Point(553, 17);
            txtApellidoSegundo.Name = "txtApellidoSegundo";
            txtApellidoSegundo.ReadOnly = true;
            txtApellidoSegundo.Size = new Size(134, 22);
            txtApellidoSegundo.TabIndex = 23;
            txtApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtApellidoPrimero
            // 
            txtApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidoPrimero.Location = new Point(413, 17);
            txtApellidoPrimero.Name = "txtApellidoPrimero";
            txtApellidoPrimero.ReadOnly = true;
            txtApellidoPrimero.Size = new Size(134, 22);
            txtApellidoPrimero.TabIndex = 22;
            txtApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigoCliente.Location = new Point(116, 70);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.ReadOnly = true;
            txtCodigoCliente.Size = new Size(143, 22);
            txtCodigoCliente.TabIndex = 20;
            txtCodigoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodigoCliente.Location = new Point(9, 70);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(101, 22);
            lblCodigoCliente.TabIndex = 21;
            lblCodigoCliente.Text = "Codigo Cliente";
            lblCodigoCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTipoIdentificacion
            // 
            txtTipoIdentificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTipoIdentificacion.Location = new Point(397, 45);
            txtTipoIdentificacion.Name = "txtTipoIdentificacion";
            txtTipoIdentificacion.ReadOnly = true;
            txtTipoIdentificacion.Size = new Size(114, 22);
            txtTipoIdentificacion.TabIndex = 18;
            txtTipoIdentificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTipoIdentificacion
            // 
            lblTipoIdentificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoIdentificacion.Location = new Point(265, 45);
            lblTipoIdentificacion.Name = "lblTipoIdentificacion";
            lblTipoIdentificacion.Size = new Size(126, 22);
            lblTipoIdentificacion.TabIndex = 19;
            lblTipoIdentificacion.Text = "Tipo Identificacion";
            lblTipoIdentificacion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasFecha
            // 
            lblVentasFecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasFecha.Location = new Point(30, 21);
            lblVentasFecha.Name = "lblVentasFecha";
            lblVentasFecha.Size = new Size(45, 22);
            lblVentasFecha.TabIndex = 15;
            lblVentasFecha.Text = "Fecha";
            lblVentasFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpVentaFecha
            // 
            dtpVentaFecha.Format = DateTimePickerFormat.Short;
            dtpVentaFecha.Location = new Point(81, 19);
            dtpVentaFecha.Name = "dtpVentaFecha";
            dtpVentaFecha.Size = new Size(117, 23);
            dtpVentaFecha.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(337, 70);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(119, 22);
            txtTelefono.TabIndex = 8;
            txtTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(273, 17);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(134, 22);
            txtNombre.TabIndex = 6;
            txtNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTelefono
            // 
            lblTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTelefono.Location = new Point(265, 70);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(66, 22);
            lblTelefono.TabIndex = 12;
            lblTelefono.Text = "Telefono";
            lblTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(204, 20);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(63, 22);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Text = "Cliente: ";
            lblClienteNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtIdntificacion
            // 
            txtIdntificacion.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdntificacion.Location = new Point(116, 45);
            txtIdntificacion.Name = "txtIdntificacion";
            txtIdntificacion.ReadOnly = true;
            txtIdntificacion.Size = new Size(143, 22);
            txtIdntificacion.TabIndex = 7;
            txtIdntificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblClienteDNI
            // 
            lblClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteDNI.Location = new Point(18, 43);
            lblClienteDNI.Name = "lblClienteDNI";
            lblClienteDNI.Size = new Size(92, 22);
            lblClienteDNI.TabIndex = 3;
            lblClienteDNI.Text = "Identificacion";
            lblClienteDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(462, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 22);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(512, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(239, 22);
            txtEmail.TabIndex = 9;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxVentasPago
            // 
            gbxVentasPago.Controls.Add(lblMontoIVARes);
            gbxVentasPago.Controls.Add(lblMontoIVA);
            gbxVentasPago.Controls.Add(btnNuevaFactura);
            gbxVentasPago.Controls.Add(btnVentasPagar);
            gbxVentasPago.Controls.Add(txtPagoEfectivo);
            gbxVentasPago.Controls.Add(lblVantasPago);
            gbxVentasPago.Controls.Add(label1);
            gbxVentasPago.Controls.Add(lblVentasCambio);
            gbxVentasPago.Controls.Add(lblVentasFormaPago);
            gbxVentasPago.Controls.Add(cboVentasFormaPago);
            gbxVentasPago.Controls.Add(lblTotalRes);
            gbxVentasPago.Controls.Add(lblVentasTotal);
            gbxVentasPago.Controls.Add(lblSubTotalRes);
            gbxVentasPago.Controls.Add(lblVentasSubTotal);
            gbxVentasPago.Dock = DockStyle.Bottom;
            gbxVentasPago.Location = new Point(0, 572);
            gbxVentasPago.Name = "gbxVentasPago";
            gbxVentasPago.Size = new Size(774, 89);
            gbxVentasPago.TabIndex = 13;
            gbxVentasPago.TabStop = false;
            gbxVentasPago.Text = "Forma de Pago";
            // 
            // lblMontoIVARes
            // 
            lblMontoIVARes.BackColor = SystemColors.Info;
            lblMontoIVARes.BorderStyle = BorderStyle.FixedSingle;
            lblMontoIVARes.Enabled = false;
            lblMontoIVARes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoIVARes.Location = new Point(104, 19);
            lblMontoIVARes.Name = "lblMontoIVARes";
            lblMontoIVARes.Size = new Size(95, 23);
            lblMontoIVARes.TabIndex = 19;
            lblMontoIVARes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMontoIVA
            // 
            lblMontoIVA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblMontoIVA.Location = new Point(12, 19);
            lblMontoIVA.Name = "lblMontoIVA";
            lblMontoIVA.Size = new Size(86, 23);
            lblMontoIVA.TabIndex = 18;
            lblMontoIVA.Text = "IVA:";
            lblMontoIVA.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevaFactura.Location = new Point(682, 17);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(86, 40);
            btnNuevaFactura.TabIndex = 17;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // btnVentasPagar
            // 
            btnVentasPagar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentasPagar.Location = new Point(590, 17);
            btnVentasPagar.Name = "btnVentasPagar";
            btnVentasPagar.Size = new Size(86, 25);
            btnVentasPagar.TabIndex = 16;
            btnVentasPagar.Text = "Pagar";
            btnVentasPagar.UseVisualStyleBackColor = true;
            // 
            // txtPagoEfectivo
            // 
            txtPagoEfectivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPagoEfectivo.Location = new Point(465, 20);
            txtPagoEfectivo.Name = "txtPagoEfectivo";
            txtPagoEfectivo.Size = new Size(119, 22);
            txtPagoEfectivo.TabIndex = 15;
            txtPagoEfectivo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblVantasPago
            // 
            lblVantasPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVantasPago.Location = new Point(400, 19);
            lblVantasPago.Name = "lblVantasPago";
            lblVantasPago.Size = new Size(59, 23);
            lblVantasPago.TabIndex = 8;
            lblVantasPago.Text = "Paga: ";
            lblVantasPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Enabled = false;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(465, 51);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasCambio
            // 
            lblVentasCambio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasCambio.Location = new Point(400, 51);
            lblVentasCambio.Name = "lblVentasCambio";
            lblVentasCambio.Size = new Size(59, 23);
            lblVentasCambio.TabIndex = 6;
            lblVentasCambio.Text = "Cambio: ";
            lblVentasCambio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasFormaPago
            // 
            lblVentasFormaPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasFormaPago.Location = new Point(207, 54);
            lblVentasFormaPago.Name = "lblVentasFormaPago";
            lblVentasFormaPago.Size = new Size(86, 23);
            lblVentasFormaPago.TabIndex = 5;
            lblVentasFormaPago.Text = "Forma Pago: ";
            lblVentasFormaPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboVentasFormaPago
            // 
            cboVentasFormaPago.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cboVentasFormaPago.FormattingEnabled = true;
            cboVentasFormaPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA" });
            cboVentasFormaPago.Location = new Point(299, 51);
            cboVentasFormaPago.Name = "cboVentasFormaPago";
            cboVentasFormaPago.Size = new Size(95, 24);
            cboVentasFormaPago.TabIndex = 14;
            // 
            // lblTotalRes
            // 
            lblTotalRes.BackColor = SystemColors.Info;
            lblTotalRes.BorderStyle = BorderStyle.FixedSingle;
            lblTotalRes.Enabled = false;
            lblTotalRes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalRes.Location = new Point(299, 19);
            lblTotalRes.Name = "lblTotalRes";
            lblTotalRes.Size = new Size(95, 23);
            lblTotalRes.TabIndex = 3;
            lblTotalRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasTotal
            // 
            lblVentasTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasTotal.Location = new Point(205, 19);
            lblVentasTotal.Name = "lblVentasTotal";
            lblVentasTotal.Size = new Size(88, 23);
            lblVentasTotal.TabIndex = 2;
            lblVentasTotal.Text = "Total: ";
            lblVentasTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubTotalRes
            // 
            lblSubTotalRes.BackColor = SystemColors.Info;
            lblSubTotalRes.BorderStyle = BorderStyle.FixedSingle;
            lblSubTotalRes.Enabled = false;
            lblSubTotalRes.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTotalRes.Location = new Point(104, 52);
            lblSubTotalRes.Name = "lblSubTotalRes";
            lblSubTotalRes.Size = new Size(95, 23);
            lblSubTotalRes.TabIndex = 1;
            lblSubTotalRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasSubTotal
            // 
            lblVentasSubTotal.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasSubTotal.Location = new Point(12, 52);
            lblVentasSubTotal.Name = "lblVentasSubTotal";
            lblVentasSubTotal.Size = new Size(86, 23);
            lblVentasSubTotal.TabIndex = 0;
            lblVentasSubTotal.Text = "Sub Total: ";
            lblVentasSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gbxVentasDatos
            // 
            gbxVentasDatos.Controls.Add(gbxVentasProductos);
            gbxVentasDatos.Controls.Add(gbxVentasDatosCliente);
            gbxVentasDatos.Dock = DockStyle.Fill;
            gbxVentasDatos.Location = new Point(0, 114);
            gbxVentasDatos.Name = "gbxVentasDatos";
            gbxVentasDatos.Size = new Size(774, 458);
            gbxVentasDatos.TabIndex = 5;
            gbxVentasDatos.TabStop = false;
            // 
            // gbxVentasProductos
            // 
            gbxVentasProductos.Controls.Add(lvwListaVenta);
            gbxVentasProductos.Dock = DockStyle.Fill;
            gbxVentasProductos.Location = new Point(3, 176);
            gbxVentasProductos.Name = "gbxVentasProductos";
            gbxVentasProductos.Size = new Size(768, 279);
            gbxVentasProductos.TabIndex = 11;
            gbxVentasProductos.TabStop = false;
            gbxVentasProductos.Text = "Lista Productos";
            // 
            // lvwListaVenta
            // 
            lvwListaVenta.BackColor = SystemColors.Info;
            lvwListaVenta.Columns.AddRange(new ColumnHeader[] { colCategoriaProducto, colCodigoProducto, colProducto, colCantidadProducto, colPrecioUnitario, colTotalProducto });
            lvwListaVenta.Dock = DockStyle.Fill;
            lvwListaVenta.Location = new Point(3, 19);
            lvwListaVenta.Name = "lvwListaVenta";
            lvwListaVenta.Size = new Size(762, 257);
            lvwListaVenta.TabIndex = 0;
            lvwListaVenta.UseCompatibleStateImageBehavior = false;
            lvwListaVenta.View = View.Details;
            // 
            // colCategoriaProducto
            // 
            colCategoriaProducto.Text = "Categoria Producto";
            colCategoriaProducto.Width = 130;
            // 
            // colCodigoProducto
            // 
            colCodigoProducto.Text = "Codigo Producto";
            colCodigoProducto.Width = 130;
            // 
            // colProducto
            // 
            colProducto.Text = "Producto";
            colProducto.Width = 130;
            // 
            // colCantidadProducto
            // 
            colCantidadProducto.Text = "Cantidad Producto";
            colCantidadProducto.Width = 130;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.Text = "Precio Unitario";
            colPrecioUnitario.Width = 130;
            // 
            // colTotalProducto
            // 
            colTotalProducto.Text = "Total Producto";
            colTotalProducto.Width = 120;
            // 
            // frmVentasFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxVentasDatos);
            Controls.Add(gbxVentasPago);
            Controls.Add(gbxVentasTitulo);
            Name = "frmVentasFacturacion";
            Text = "Ventas Facturacion";
            Load += frmVentasFacturacion_Load;
            gbxVentasTitulo.ResumeLayout(false);
            gbxClienteModificar.ResumeLayout(false);
            gbxClienteModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxVentasDatosCliente.ResumeLayout(false);
            gbxVentasDatosCliente.PerformLayout();
            gbxCodigoProducto.ResumeLayout(false);
            gbxCodigoProducto.PerformLayout();
            gbxVentasPago.ResumeLayout(false);
            gbxVentasPago.PerformLayout();
            gbxVentasDatos.ResumeLayout(false);
            gbxVentasProductos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxVentasTitulo;
        private PictureBox pbLogo;
        private Label lblVentasTitulo;
        private GroupBox gbxVentasDatosCliente;
        private GroupBox gbxVentasPago;
        private GroupBox gbxVentasDatos;
        private GroupBox gbxVentasProductos;
        private GroupBox gbxClienteModificar;
        private TextBox txtBuscarCliente;
        private Label lblBuscarCodigoCliente;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtNombre;
        private Label lblClienteNombre;
        private Label lblClienteDNI;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtIdntificacion;
        private Label lblVentasFecha;
        private DateTimePicker dtpVentaFecha;
        private Label lblTotalRes;
        private Label lblVentasTotal;
        private Label lblSubTotalRes;
        private Label lblVentasSubTotal;
        private Label lblVentasFormaPago;
        private ComboBox cboVentasFormaPago;
        private Label label1;
        private Label lblVentasCambio;
        private Label lblVantasPago;
        private TextBox txtPagoEfectivo;
        private Button btnNuevaFactura;
        private Button btnVentasPagar;
        private TextBox txtCodigoCliente;
        private Label lblCodigoCliente;
        private TextBox txtTipoIdentificacion;
        private Label lblTipoIdentificacion;
        private TextBox txtApellidoSegundo;
        private TextBox txtApellidoPrimero;
        private ListView lvwListaVenta;
        private ColumnHeader colCategoriaProducto;
        private ColumnHeader colCodigoProducto;
        private ColumnHeader colProducto;
        private ColumnHeader colCantidadProducto;
        private ColumnHeader colPrecioUnitario;
        private ColumnHeader colTotalProducto;
        private GroupBox gbxCodigoProducto;
        private Button btnAgregarProducto;
        private Label lblCodigoProducto;
        private TextBox txtCodigoProducto;
        private Button btnBuscarCliente;
        private TextBox txtCantidadProducto;
        private Label lblCantidadProducto;
        private Label lblMontoIVARes;
        private Label lblMontoIVA;
    }
}