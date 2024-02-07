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
            pbLogo = new PictureBox();
            lblProductosTitulo = new Label();
            dgvRegistroListaFuncionarios = new DataGridView();
            colFacturaCodigo = new DataGridViewTextBoxColumn();
            colFacturaProducto = new DataGridViewTextBoxColumn();
            colFacturaCantidad = new DataGridViewTextBoxColumn();
            colFacturaPrecioUnd = new DataGridViewTextBoxColumn();
            colFacturaPrecioVenta = new DataGridViewTextBoxColumn();
            gbxListaProductos = new GroupBox();
            gbxRegistroDeProductos = new GroupBox();
            lblFacturaPrecioUnd = new Label();
            txtFacturaPrecioUnd = new TextBox();
            lblFacturaCantidad = new Label();
            btnFacturaCancelar = new Button();
            btnFacturaLimpiar = new Button();
            btnFacturaAceptar = new Button();
            txtFacturaCodigo = new TextBox();
            lblFacturaCodigo = new Label();
            lblFacturaNombre = new Label();
            txtFuncionarioApellidoPrimero = new TextBox();
            txtFacturaCantidad = new TextBox();
            gbxIngresoFactura = new GroupBox();
            txtFacturaMonto = new TextBox();
            lblFacturaMonto = new Label();
            dtpFacturaFecha = new DateTimePicker();
            txtFacturaNumero = new TextBox();
            lblFacturaFecha = new Label();
            lblFacturaNumero = new Label();
            btnFacturaPagar = new Button();
            gbxFacturasRegistro = new GroupBox();
            gbxRegistroProductosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).BeginInit();
            gbxListaProductos.SuspendLayout();
            gbxRegistroDeProductos.SuspendLayout();
            gbxIngresoFactura.SuspendLayout();
            gbxFacturasRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRegistroProductosTitulo
            // 
            gbxRegistroProductosTitulo.Controls.Add(pbLogo);
            gbxRegistroProductosTitulo.Controls.Add(lblProductosTitulo);
            gbxRegistroProductosTitulo.Dock = DockStyle.Top;
            gbxRegistroProductosTitulo.Location = new Point(0, 0);
            gbxRegistroProductosTitulo.Name = "gbxRegistroProductosTitulo";
            gbxRegistroProductosTitulo.Size = new Size(774, 138);
            gbxRegistroProductosTitulo.TabIndex = 1;
            gbxRegistroProductosTitulo.TabStop = false;
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
            lblProductosTitulo.Location = new Point(253, 19);
            lblProductosTitulo.Name = "lblProductosTitulo";
            lblProductosTitulo.Size = new Size(224, 82);
            lblProductosTitulo.TabIndex = 16;
            lblProductosTitulo.Text = "Registro de Facturas  Productos";
            lblProductosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvRegistroListaFuncionarios
            // 
            dgvRegistroListaFuncionarios.AllowUserToDeleteRows = false;
            dgvRegistroListaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRegistroListaFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colFacturaCodigo, colFacturaProducto, colFacturaCantidad, colFacturaPrecioUnd, colFacturaPrecioVenta });
            dgvRegistroListaFuncionarios.Dock = DockStyle.Fill;
            dgvRegistroListaFuncionarios.Location = new Point(3, 19);
            dgvRegistroListaFuncionarios.Name = "dgvRegistroListaFuncionarios";
            dgvRegistroListaFuncionarios.RowTemplate.Height = 25;
            dgvRegistroListaFuncionarios.Size = new Size(768, 193);
            dgvRegistroListaFuncionarios.TabIndex = 11;
            // 
            // colFacturaCodigo
            // 
            colFacturaCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaCodigo.HeaderText = "Codigo";
            colFacturaCodigo.Name = "colFacturaCodigo";
            // 
            // colFacturaProducto
            // 
            colFacturaProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaProducto.HeaderText = "Producto";
            colFacturaProducto.Name = "colFacturaProducto";
            // 
            // colFacturaCantidad
            // 
            colFacturaCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaCantidad.HeaderText = "Cantidad";
            colFacturaCantidad.Name = "colFacturaCantidad";
            // 
            // colFacturaPrecioUnd
            // 
            colFacturaPrecioUnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaPrecioUnd.HeaderText = "Precio Unitario";
            colFacturaPrecioUnd.Name = "colFacturaPrecioUnd";
            colFacturaPrecioUnd.ReadOnly = true;
            // 
            // colFacturaPrecioVenta
            // 
            colFacturaPrecioVenta.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaPrecioVenta.HeaderText = "Precio Venta";
            colFacturaPrecioVenta.Name = "colFacturaPrecioVenta";
            colFacturaPrecioVenta.ReadOnly = true;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Controls.Add(dgvRegistroListaFuncionarios);
            gbxListaProductos.Dock = DockStyle.Bottom;
            gbxListaProductos.Location = new Point(0, 446);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(774, 215);
            gbxListaProductos.TabIndex = 4;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Lista de Productos";
            // 
            // gbxRegistroDeProductos
            // 
            gbxRegistroDeProductos.Controls.Add(lblFacturaPrecioUnd);
            gbxRegistroDeProductos.Controls.Add(txtFacturaPrecioUnd);
            gbxRegistroDeProductos.Controls.Add(lblFacturaCantidad);
            gbxRegistroDeProductos.Controls.Add(btnFacturaCancelar);
            gbxRegistroDeProductos.Controls.Add(btnFacturaLimpiar);
            gbxRegistroDeProductos.Controls.Add(btnFacturaAceptar);
            gbxRegistroDeProductos.Controls.Add(txtFacturaCodigo);
            gbxRegistroDeProductos.Controls.Add(lblFacturaCodigo);
            gbxRegistroDeProductos.Controls.Add(lblFacturaNombre);
            gbxRegistroDeProductos.Controls.Add(txtFuncionarioApellidoPrimero);
            gbxRegistroDeProductos.Controls.Add(txtFacturaCantidad);
            gbxRegistroDeProductos.Dock = DockStyle.Right;
            gbxRegistroDeProductos.Location = new Point(370, 19);
            gbxRegistroDeProductos.Name = "gbxRegistroDeProductos";
            gbxRegistroDeProductos.Size = new Size(401, 286);
            gbxRegistroDeProductos.TabIndex = 3;
            gbxRegistroDeProductos.TabStop = false;
            gbxRegistroDeProductos.Text = "Datos Productos";
            // 
            // lblFacturaPrecioUnd
            // 
            lblFacturaPrecioUnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaPrecioUnd.Location = new Point(12, 149);
            lblFacturaPrecioUnd.Name = "lblFacturaPrecioUnd";
            lblFacturaPrecioUnd.Size = new Size(114, 22);
            lblFacturaPrecioUnd.TabIndex = 13;
            lblFacturaPrecioUnd.Text = "Precio Und";
            lblFacturaPrecioUnd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFacturaPrecioUnd
            // 
            txtFacturaPrecioUnd.AcceptsTab = true;
            txtFacturaPrecioUnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacturaPrecioUnd.Location = new Point(132, 142);
            txtFacturaPrecioUnd.Name = "txtFacturaPrecioUnd";
            txtFacturaPrecioUnd.Size = new Size(151, 29);
            txtFacturaPrecioUnd.TabIndex = 7;
            txtFacturaPrecioUnd.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFacturaCantidad
            // 
            lblFacturaCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaCantidad.Location = new Point(12, 114);
            lblFacturaCantidad.Name = "lblFacturaCantidad";
            lblFacturaCantidad.Size = new Size(114, 22);
            lblFacturaCantidad.TabIndex = 11;
            lblFacturaCantidad.Text = "Cantidad";
            lblFacturaCantidad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFacturaCancelar
            // 
            btnFacturaCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturaCancelar.Location = new Point(289, 109);
            btnFacturaCancelar.Name = "btnFacturaCancelar";
            btnFacturaCancelar.Size = new Size(93, 32);
            btnFacturaCancelar.TabIndex = 10;
            btnFacturaCancelar.Text = "Cancelar";
            btnFacturaCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFacturaLimpiar
            // 
            btnFacturaLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturaLimpiar.Location = new Point(289, 71);
            btnFacturaLimpiar.Name = "btnFacturaLimpiar";
            btnFacturaLimpiar.Size = new Size(93, 32);
            btnFacturaLimpiar.TabIndex = 9;
            btnFacturaLimpiar.Text = "Limpiar";
            btnFacturaLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnFacturaAceptar
            // 
            btnFacturaAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturaAceptar.Location = new Point(289, 33);
            btnFacturaAceptar.Name = "btnFacturaAceptar";
            btnFacturaAceptar.Size = new Size(93, 32);
            btnFacturaAceptar.TabIndex = 8;
            btnFacturaAceptar.Text = "Aceptar";
            btnFacturaAceptar.UseVisualStyleBackColor = true;
            // 
            // txtFacturaCodigo
            // 
            txtFacturaCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacturaCodigo.Location = new Point(132, 31);
            txtFacturaCodigo.Name = "txtFacturaCodigo";
            txtFacturaCodigo.Size = new Size(151, 29);
            txtFacturaCodigo.TabIndex = 4;
            txtFacturaCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFacturaCodigo
            // 
            lblFacturaCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaCodigo.Location = new Point(12, 31);
            lblFacturaCodigo.Name = "lblFacturaCodigo";
            lblFacturaCodigo.Size = new Size(114, 22);
            lblFacturaCodigo.TabIndex = 0;
            lblFacturaCodigo.Text = "Codigo";
            lblFacturaCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFacturaNombre
            // 
            lblFacturaNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaNombre.Location = new Point(12, 72);
            lblFacturaNombre.Name = "lblFacturaNombre";
            lblFacturaNombre.Size = new Size(114, 22);
            lblFacturaNombre.TabIndex = 1;
            lblFacturaNombre.Text = "Producto";
            lblFacturaNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFuncionarioApellidoPrimero
            // 
            txtFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoPrimero.Location = new Point(132, 72);
            txtFuncionarioApellidoPrimero.Name = "txtFuncionarioApellidoPrimero";
            txtFuncionarioApellidoPrimero.Size = new Size(151, 29);
            txtFuncionarioApellidoPrimero.TabIndex = 5;
            txtFuncionarioApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFacturaCantidad
            // 
            txtFacturaCantidad.AcceptsTab = true;
            txtFacturaCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacturaCantidad.Location = new Point(132, 107);
            txtFacturaCantidad.Name = "txtFacturaCantidad";
            txtFacturaCantidad.Size = new Size(151, 29);
            txtFacturaCantidad.TabIndex = 6;
            txtFacturaCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxIngresoFactura
            // 
            gbxIngresoFactura.Controls.Add(btnFacturaPagar);
            gbxIngresoFactura.Controls.Add(txtFacturaMonto);
            gbxIngresoFactura.Controls.Add(lblFacturaMonto);
            gbxIngresoFactura.Controls.Add(dtpFacturaFecha);
            gbxIngresoFactura.Controls.Add(txtFacturaNumero);
            gbxIngresoFactura.Controls.Add(lblFacturaFecha);
            gbxIngresoFactura.Controls.Add(lblFacturaNumero);
            gbxIngresoFactura.Dock = DockStyle.Left;
            gbxIngresoFactura.Location = new Point(3, 19);
            gbxIngresoFactura.Name = "gbxIngresoFactura";
            gbxIngresoFactura.Size = new Size(345, 286);
            gbxIngresoFactura.TabIndex = 2;
            gbxIngresoFactura.TabStop = false;
            gbxIngresoFactura.Text = "Ingreso Datos Factura";
            // 
            // txtFacturaMonto
            // 
            txtFacturaMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacturaMonto.Location = new Point(168, 85);
            txtFacturaMonto.Name = "txtFacturaMonto";
            txtFacturaMonto.Size = new Size(153, 29);
            txtFacturaMonto.TabIndex = 3;
            txtFacturaMonto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFacturaMonto
            // 
            lblFacturaMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaMonto.Location = new Point(16, 85);
            lblFacturaMonto.Name = "lblFacturaMonto";
            lblFacturaMonto.Size = new Size(146, 22);
            lblFacturaMonto.TabIndex = 16;
            lblFacturaMonto.Text = "Monto Factura";
            lblFacturaMonto.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFacturaFecha
            // 
            dtpFacturaFecha.Format = DateTimePickerFormat.Short;
            dtpFacturaFecha.Location = new Point(168, 18);
            dtpFacturaFecha.Name = "dtpFacturaFecha";
            dtpFacturaFecha.Size = new Size(153, 23);
            dtpFacturaFecha.TabIndex = 1;
            // 
            // txtFacturaNumero
            // 
            txtFacturaNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFacturaNumero.Location = new Point(168, 47);
            txtFacturaNumero.Name = "txtFacturaNumero";
            txtFacturaNumero.Size = new Size(153, 29);
            txtFacturaNumero.TabIndex = 2;
            txtFacturaNumero.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFacturaFecha
            // 
            lblFacturaFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaFecha.Location = new Point(6, 19);
            lblFacturaFecha.Name = "lblFacturaFecha";
            lblFacturaFecha.Size = new Size(147, 22);
            lblFacturaFecha.TabIndex = 14;
            lblFacturaFecha.Text = "Fecha";
            lblFacturaFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFacturaNumero
            // 
            lblFacturaNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFacturaNumero.Location = new Point(16, 52);
            lblFacturaNumero.Name = "lblFacturaNumero";
            lblFacturaNumero.Size = new Size(146, 22);
            lblFacturaNumero.TabIndex = 1;
            lblFacturaNumero.Text = "Factura Numero ";
            lblFacturaNumero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnFacturaPagar
            // 
            btnFacturaPagar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFacturaPagar.Location = new Point(91, 121);
            btnFacturaPagar.Name = "btnFacturaPagar";
            btnFacturaPagar.Size = new Size(176, 32);
            btnFacturaPagar.TabIndex = 17;
            btnFacturaPagar.Text = "Pagar Factura";
            btnFacturaPagar.UseVisualStyleBackColor = true;
            // 
            // gbxFacturasRegistro
            // 
            gbxFacturasRegistro.Controls.Add(gbxIngresoFactura);
            gbxFacturasRegistro.Controls.Add(gbxRegistroDeProductos);
            gbxFacturasRegistro.Dock = DockStyle.Fill;
            gbxFacturasRegistro.Location = new Point(0, 138);
            gbxFacturasRegistro.Name = "gbxFacturasRegistro";
            gbxFacturasRegistro.Size = new Size(774, 308);
            gbxFacturasRegistro.TabIndex = 5;
            gbxFacturasRegistro.TabStop = false;
            // 
            // frmIngresoFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxFacturasRegistro);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxRegistroProductosTitulo);
            MinimumSize = new Size(790, 700);
            Name = "frmIngresoFacturas";
            Text = "Ingreso de Facturas";
            Load += frmRegistroProductos_Load;
            gbxRegistroProductosTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).EndInit();
            gbxListaProductos.ResumeLayout(false);
            gbxRegistroDeProductos.ResumeLayout(false);
            gbxRegistroDeProductos.PerformLayout();
            gbxIngresoFactura.ResumeLayout(false);
            gbxIngresoFactura.PerformLayout();
            gbxFacturasRegistro.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxRegistroProductosTitulo;
        private PictureBox pbLogo;
        private Label lblProductosTitulo;
        private DataGridView dgvRegistroListaFuncionarios;
        private DataGridViewTextBoxColumn colNombreProducto;
        private DataGridViewTextBoxColumn colCantidadProducto;
        private DataGridViewTextBoxColumn colPrecioUnitario;
        private DataGridViewTextBoxColumn colPrecioVenta;
        private GroupBox gbxListaProductos;
        private GroupBox gbxRegistroDeProductos;
        private TextBox txtFacturaCodigo;
        private Label lblFacturaCodigo;
        private Label lblFacturaNombre;
        private Label lblFuncionarioApellidoSegundo;
        private Label lblFuncionarioDNI;
        private TextBox txtFuncionarioCodigo;
        private Label lblFuncionarioCodigo;
        private TextBox txtFuncionarioEmail;
        private Label lblFuncionarioEmail;
        private TextBox txtFuncionarioDNI;
        private TextBox txtFuncionarioApellidoPrimero;
        private TextBox txtFacturaCantidad;
        private GroupBox gbxIngresoFactura;
        private TextBox txtFacturaNumero;
        private Label lblFacturaNumero;
        private DataGridViewTextBoxColumn colFacturaCodigo;
        private DataGridViewTextBoxColumn colFacturaProducto;
        private DataGridViewTextBoxColumn colFacturaCantidad;
        private DataGridViewTextBoxColumn colFacturaPrecioUnd;
        private DataGridViewTextBoxColumn colFacturaPrecioVenta;
        private Button btnFacturaCancelar;
        private Button btnFacturaLimpiar;
        private Button btnFacturaAceptar;
        private Label lblFacturaFecha;
        private DateTimePicker dtpFacturaFecha;
        private TextBox txtFacturaMonto;
        private Label lblFacturaMonto;
        private Label lblFacturaPrecioUnd;
        private TextBox txtFacturaPrecioUnd;
        private Label lblFacturaCantidad;
        private Button btnFacturaPagar;
        private GroupBox gbxFacturasRegistro;
    }
}