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
            btnModificarBuscar = new Button();
            txtBuscarCodigoCliente = new TextBox();
            lblBuscarCodigoCliente = new Label();
            pbLogo = new PictureBox();
            lblVentasTitulo = new Label();
            gbxVentasDatosCliente = new GroupBox();
            lblVentasNumeroFactura = new Label();
            lblVentasFacturaNumero = new Label();
            lblVentasFecha = new Label();
            dtpVentaFecha = new DateTimePicker();
            txtClienteTelefono = new TextBox();
            txtClienteNombre = new TextBox();
            lblClienteTelefono = new Label();
            lblClienteNombre = new Label();
            txtClienteDNI = new TextBox();
            lblClienteDNI = new Label();
            lblClienteEmail = new Label();
            txtClienteEmail = new TextBox();
            gbxVentasPago = new GroupBox();
            btnVentasNuevaFactura = new Button();
            btnVentasPagar = new Button();
            txtVentasPago = new TextBox();
            lblVantasPago = new Label();
            label1 = new Label();
            lblVentasCambio = new Label();
            lblVentasFormaPago = new Label();
            cboVentasFormaPago = new ComboBox();
            lblVentasTotalRes = new Label();
            lblVentasTotal = new Label();
            lblVentasSubTotalRes = new Label();
            lblVentasSubTotal = new Label();
            gbxVentasDatos = new GroupBox();
            gbxVentasProductos = new GroupBox();
            dgvVentaListaProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colProducto = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colPrecioUnitario = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            gbxVentasTitulo.SuspendLayout();
            gbxClienteModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxVentasDatosCliente.SuspendLayout();
            gbxVentasPago.SuspendLayout();
            gbxVentasDatos.SuspendLayout();
            gbxVentasProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentaListaProductos).BeginInit();
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
            gbxVentasTitulo.Size = new Size(774, 120);
            gbxVentasTitulo.TabIndex = 1;
            gbxVentasTitulo.TabStop = false;
            // 
            // gbxClienteModificar
            // 
            gbxClienteModificar.Controls.Add(btnModificarBuscar);
            gbxClienteModificar.Controls.Add(txtBuscarCodigoCliente);
            gbxClienteModificar.Controls.Add(lblBuscarCodigoCliente);
            gbxClienteModificar.Location = new Point(165, 57);
            gbxClienteModificar.Name = "gbxClienteModificar";
            gbxClienteModificar.Size = new Size(427, 53);
            gbxClienteModificar.TabIndex = 2;
            gbxClienteModificar.TabStop = false;
            gbxClienteModificar.Text = "Buscar Cliente";
            // 
            // btnModificarBuscar
            // 
            btnModificarBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarBuscar.Location = new Point(321, 22);
            btnModificarBuscar.Name = "btnModificarBuscar";
            btnModificarBuscar.Size = new Size(86, 25);
            btnModificarBuscar.TabIndex = 4;
            btnModificarBuscar.Text = "Buscar";
            btnModificarBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscarCodigoCliente
            // 
            txtBuscarCodigoCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigoCliente.Location = new Point(180, 25);
            txtBuscarCodigoCliente.Name = "txtBuscarCodigoCliente";
            txtBuscarCodigoCliente.Size = new Size(135, 22);
            txtBuscarCodigoCliente.TabIndex = 3;
            txtBuscarCodigoCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscarCodigoCliente
            // 
            lblBuscarCodigoCliente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarCodigoCliente.Location = new Point(5, 25);
            lblBuscarCodigoCliente.Name = "lblBuscarCodigoCliente";
            lblBuscarCodigoCliente.Size = new Size(137, 22);
            lblBuscarCodigoCliente.TabIndex = 4;
            lblBuscarCodigoCliente.Text = "Codigo Cliente";
            lblBuscarCodigoCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(147, 105);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblVentasTitulo
            // 
            lblVentasTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasTitulo.Location = new Point(239, 12);
            lblVentasTitulo.Name = "lblVentasTitulo";
            lblVentasTitulo.Size = new Size(412, 35);
            lblVentasTitulo.TabIndex = 16;
            lblVentasTitulo.Text = "Ventas Productos Distribuidora La Zarzuela";
            lblVentasTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxVentasDatosCliente
            // 
            gbxVentasDatosCliente.Controls.Add(lblVentasNumeroFactura);
            gbxVentasDatosCliente.Controls.Add(lblVentasFacturaNumero);
            gbxVentasDatosCliente.Controls.Add(lblVentasFecha);
            gbxVentasDatosCliente.Controls.Add(dtpVentaFecha);
            gbxVentasDatosCliente.Controls.Add(txtClienteTelefono);
            gbxVentasDatosCliente.Controls.Add(txtClienteNombre);
            gbxVentasDatosCliente.Controls.Add(lblClienteTelefono);
            gbxVentasDatosCliente.Controls.Add(lblClienteNombre);
            gbxVentasDatosCliente.Controls.Add(txtClienteDNI);
            gbxVentasDatosCliente.Controls.Add(lblClienteDNI);
            gbxVentasDatosCliente.Controls.Add(lblClienteEmail);
            gbxVentasDatosCliente.Controls.Add(txtClienteEmail);
            gbxVentasDatosCliente.Dock = DockStyle.Top;
            gbxVentasDatosCliente.Location = new Point(3, 19);
            gbxVentasDatosCliente.Name = "gbxVentasDatosCliente";
            gbxVentasDatosCliente.Size = new Size(768, 94);
            gbxVentasDatosCliente.TabIndex = 5;
            gbxVentasDatosCliente.TabStop = false;
            gbxVentasDatosCliente.Text = "Datos Clientes";
            // 
            // lblVentasNumeroFactura
            // 
            lblVentasNumeroFactura.BackColor = SystemColors.Info;
            lblVentasNumeroFactura.BorderStyle = BorderStyle.FixedSingle;
            lblVentasNumeroFactura.Enabled = false;
            lblVentasNumeroFactura.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasNumeroFactura.Location = new Point(637, 45);
            lblVentasNumeroFactura.Name = "lblVentasNumeroFactura";
            lblVentasNumeroFactura.Size = new Size(117, 23);
            lblVentasNumeroFactura.TabIndex = 17;
            lblVentasNumeroFactura.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasFacturaNumero
            // 
            lblVentasFacturaNumero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasFacturaNumero.Location = new Point(565, 47);
            lblVentasFacturaNumero.Name = "lblVentasFacturaNumero";
            lblVentasFacturaNumero.Size = new Size(66, 22);
            lblVentasFacturaNumero.TabIndex = 16;
            lblVentasFacturaNumero.Text = "# Factura";
            lblVentasFacturaNumero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasFecha
            // 
            lblVentasFecha.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasFecha.Location = new Point(565, 18);
            lblVentasFecha.Name = "lblVentasFecha";
            lblVentasFecha.Size = new Size(66, 22);
            lblVentasFecha.TabIndex = 15;
            lblVentasFecha.Text = "Fecha";
            lblVentasFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpVentaFecha
            // 
            dtpVentaFecha.Enabled = false;
            dtpVentaFecha.Format = DateTimePickerFormat.Short;
            dtpVentaFecha.Location = new Point(637, 17);
            dtpVentaFecha.Name = "dtpVentaFecha";
            dtpVentaFecha.Size = new Size(117, 23);
            dtpVentaFecha.TabIndex = 10;
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteTelefono.Location = new Point(415, 17);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.ReadOnly = true;
            txtClienteTelefono.Size = new Size(154, 22);
            txtClienteTelefono.TabIndex = 8;
            txtClienteTelefono.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(107, 19);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.ReadOnly = true;
            txtClienteNombre.Size = new Size(224, 22);
            txtClienteNombre.TabIndex = 6;
            txtClienteNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblClienteTelefono
            // 
            lblClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTelefono.Location = new Point(343, 17);
            lblClienteTelefono.Name = "lblClienteTelefono";
            lblClienteTelefono.Size = new Size(66, 22);
            lblClienteTelefono.TabIndex = 12;
            lblClienteTelefono.Text = "Telefono";
            lblClienteTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(9, 19);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(92, 22);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Text = "Cliente: ";
            lblClienteNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteDNI
            // 
            txtClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDNI.Location = new Point(107, 44);
            txtClienteDNI.Name = "txtClienteDNI";
            txtClienteDNI.ReadOnly = true;
            txtClienteDNI.Size = new Size(224, 22);
            txtClienteDNI.TabIndex = 7;
            txtClienteDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // lblClienteDNI
            // 
            lblClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteDNI.Location = new Point(9, 44);
            lblClienteDNI.Name = "lblClienteDNI";
            lblClienteDNI.Size = new Size(92, 22);
            lblClienteDNI.TabIndex = 3;
            lblClienteDNI.Text = "Identificacion";
            lblClienteDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteEmail.Location = new Point(343, 47);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(66, 22);
            lblClienteEmail.TabIndex = 5;
            lblClienteEmail.Text = "Email";
            lblClienteEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteEmail.Location = new Point(415, 45);
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.ReadOnly = true;
            txtClienteEmail.Size = new Size(154, 22);
            txtClienteEmail.TabIndex = 9;
            txtClienteEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxVentasPago
            // 
            gbxVentasPago.Controls.Add(btnVentasNuevaFactura);
            gbxVentasPago.Controls.Add(btnVentasPagar);
            gbxVentasPago.Controls.Add(txtVentasPago);
            gbxVentasPago.Controls.Add(lblVantasPago);
            gbxVentasPago.Controls.Add(label1);
            gbxVentasPago.Controls.Add(lblVentasCambio);
            gbxVentasPago.Controls.Add(lblVentasFormaPago);
            gbxVentasPago.Controls.Add(cboVentasFormaPago);
            gbxVentasPago.Controls.Add(lblVentasTotalRes);
            gbxVentasPago.Controls.Add(lblVentasTotal);
            gbxVentasPago.Controls.Add(lblVentasSubTotalRes);
            gbxVentasPago.Controls.Add(lblVentasSubTotal);
            gbxVentasPago.Dock = DockStyle.Bottom;
            gbxVentasPago.Location = new Point(0, 572);
            gbxVentasPago.Name = "gbxVentasPago";
            gbxVentasPago.Size = new Size(774, 89);
            gbxVentasPago.TabIndex = 13;
            gbxVentasPago.TabStop = false;
            gbxVentasPago.Text = "Forma de Pago";
            // 
            // btnVentasNuevaFactura
            // 
            btnVentasNuevaFactura.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentasNuevaFactura.Location = new Point(679, 43);
            btnVentasNuevaFactura.Name = "btnVentasNuevaFactura";
            btnVentasNuevaFactura.Size = new Size(78, 40);
            btnVentasNuevaFactura.TabIndex = 17;
            btnVentasNuevaFactura.Text = "Nueva Venta";
            btnVentasNuevaFactura.UseVisualStyleBackColor = true;
            // 
            // btnVentasPagar
            // 
            btnVentasPagar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnVentasPagar.Location = new Point(534, 54);
            btnVentasPagar.Name = "btnVentasPagar";
            btnVentasPagar.Size = new Size(86, 25);
            btnVentasPagar.TabIndex = 16;
            btnVentasPagar.Text = "Pagar";
            btnVentasPagar.UseVisualStyleBackColor = true;
            // 
            // txtVentasPago
            // 
            txtVentasPago.Location = new Point(324, 54);
            txtVentasPago.Name = "txtVentasPago";
            txtVentasPago.Size = new Size(119, 23);
            txtVentasPago.TabIndex = 15;
            txtVentasPago.TextAlign = HorizontalAlignment.Center;
            // 
            // lblVantasPago
            // 
            lblVantasPago.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVantasPago.Location = new Point(245, 52);
            lblVantasPago.Name = "lblVantasPago";
            lblVantasPago.Size = new Size(73, 23);
            lblVantasPago.TabIndex = 8;
            lblVantasPago.Text = "Paga: ";
            lblVantasPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Info;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Enabled = false;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(534, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 7;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasCambio
            // 
            lblVentasCambio.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasCambio.Location = new Point(455, 19);
            lblVentasCambio.Name = "lblVentasCambio";
            lblVentasCambio.Size = new Size(73, 23);
            lblVentasCambio.TabIndex = 6;
            lblVentasCambio.Text = "Cambio: ";
            lblVentasCambio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasFormaPago
            // 
            lblVentasFormaPago.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasFormaPago.Location = new Point(12, 52);
            lblVentasFormaPago.Name = "lblVentasFormaPago";
            lblVentasFormaPago.Size = new Size(100, 23);
            lblVentasFormaPago.TabIndex = 5;
            lblVentasFormaPago.Text = "Forma Pago: ";
            lblVentasFormaPago.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cboVentasFormaPago
            // 
            cboVentasFormaPago.FormattingEnabled = true;
            cboVentasFormaPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA" });
            cboVentasFormaPago.Location = new Point(118, 54);
            cboVentasFormaPago.Name = "cboVentasFormaPago";
            cboVentasFormaPago.Size = new Size(121, 23);
            cboVentasFormaPago.TabIndex = 14;
            // 
            // lblVentasTotalRes
            // 
            lblVentasTotalRes.BackColor = SystemColors.Info;
            lblVentasTotalRes.BorderStyle = BorderStyle.FixedSingle;
            lblVentasTotalRes.Enabled = false;
            lblVentasTotalRes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasTotalRes.Location = new Point(324, 19);
            lblVentasTotalRes.Name = "lblVentasTotalRes";
            lblVentasTotalRes.Size = new Size(119, 23);
            lblVentasTotalRes.TabIndex = 3;
            lblVentasTotalRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasTotal
            // 
            lblVentasTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasTotal.Location = new Point(245, 19);
            lblVentasTotal.Name = "lblVentasTotal";
            lblVentasTotal.Size = new Size(73, 23);
            lblVentasTotal.TabIndex = 2;
            lblVentasTotal.Text = "Total: ";
            lblVentasTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblVentasSubTotalRes
            // 
            lblVentasSubTotalRes.BackColor = SystemColors.Info;
            lblVentasSubTotalRes.BorderStyle = BorderStyle.FixedSingle;
            lblVentasSubTotalRes.Enabled = false;
            lblVentasSubTotalRes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasSubTotalRes.Location = new Point(118, 19);
            lblVentasSubTotalRes.Name = "lblVentasSubTotalRes";
            lblVentasSubTotalRes.Size = new Size(121, 23);
            lblVentasSubTotalRes.TabIndex = 1;
            lblVentasSubTotalRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVentasSubTotal
            // 
            lblVentasSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblVentasSubTotal.Location = new Point(12, 19);
            lblVentasSubTotal.Name = "lblVentasSubTotal";
            lblVentasSubTotal.Size = new Size(100, 23);
            lblVentasSubTotal.TabIndex = 0;
            lblVentasSubTotal.Text = "Sub Total: ";
            lblVentasSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // gbxVentasDatos
            // 
            gbxVentasDatos.Controls.Add(gbxVentasProductos);
            gbxVentasDatos.Controls.Add(gbxVentasDatosCliente);
            gbxVentasDatos.Dock = DockStyle.Fill;
            gbxVentasDatos.Location = new Point(0, 120);
            gbxVentasDatos.Name = "gbxVentasDatos";
            gbxVentasDatos.Size = new Size(774, 452);
            gbxVentasDatos.TabIndex = 5;
            gbxVentasDatos.TabStop = false;
            // 
            // gbxVentasProductos
            // 
            gbxVentasProductos.Controls.Add(dgvVentaListaProductos);
            gbxVentasProductos.Dock = DockStyle.Fill;
            gbxVentasProductos.Location = new Point(3, 113);
            gbxVentasProductos.Name = "gbxVentasProductos";
            gbxVentasProductos.Size = new Size(768, 336);
            gbxVentasProductos.TabIndex = 11;
            gbxVentasProductos.TabStop = false;
            gbxVentasProductos.Text = "Lista Productos";
            // 
            // dgvVentaListaProductos
            // 
            dgvVentaListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentaListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentaListaProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProducto, colCantidad, colPrecioUnitario, colTotal });
            dgvVentaListaProductos.Dock = DockStyle.Fill;
            dgvVentaListaProductos.Location = new Point(3, 19);
            dgvVentaListaProductos.Name = "dgvVentaListaProductos";
            dgvVentaListaProductos.ReadOnly = true;
            dgvVentaListaProductos.RowTemplate.Height = 25;
            dgvVentaListaProductos.Size = new Size(762, 314);
            dgvVentaListaProductos.TabIndex = 12;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // colProducto
            // 
            colProducto.HeaderText = "Producto";
            colProducto.Name = "colProducto";
            colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colPrecioUnitario
            // 
            colPrecioUnitario.HeaderText = "Precio Unitario";
            colPrecioUnitario.Name = "colPrecioUnitario";
            colPrecioUnitario.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
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
            gbxVentasTitulo.ResumeLayout(false);
            gbxClienteModificar.ResumeLayout(false);
            gbxClienteModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxVentasDatosCliente.ResumeLayout(false);
            gbxVentasDatosCliente.PerformLayout();
            gbxVentasPago.ResumeLayout(false);
            gbxVentasPago.PerformLayout();
            gbxVentasDatos.ResumeLayout(false);
            gbxVentasProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentaListaProductos).EndInit();
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
        private Button btnModificarBuscar;
        private TextBox txtBuscarCodigoCliente;
        private Label lblBuscarCodigoCliente;
        private TextBox txtClienteTelefono;
        private Label lblClienteTelefono;
        private TextBox txtClienteNombre;
        private Label lblClienteNombre;
        private Label lblClienteDNI;
        private TextBox txtClienteEmail;
        private Label lblClienteEmail;
        private TextBox txtClienteDNI;
        private Label lblVentasFecha;
        private DateTimePicker dtpVentaFecha;
        private DataGridView dgvVentaListaProductos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colProducto;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colTotal;
        private Label lblVentasTotalRes;
        private Label lblVentasTotal;
        private Label lblVentasSubTotalRes;
        private Label lblVentasSubTotal;
        private Label lblVentasFormaPago;
        private ComboBox cboVentasFormaPago;
        private Label label1;
        private Label lblVentasCambio;
        private Label lblVantasPago;
        private TextBox txtVentasPago;
        private Button btnVentasNuevaFactura;
        private Button btnVentasPagar;
        private Label lblVentasNumeroFactura;
        private Label lblVentasFacturaNumero;
    }
}