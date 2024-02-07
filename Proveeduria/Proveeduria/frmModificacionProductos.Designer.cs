namespace Proveeduria
{
    partial class frmModificacionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionProductos));
            gbxListaProductos = new GroupBox();
            dgvRegistroListaFuncionarios = new DataGridView();
            colFacturaCodigo = new DataGridViewTextBoxColumn();
            colFacturaProducto = new DataGridViewTextBoxColumn();
            colFacturaCantidad = new DataGridViewTextBoxColumn();
            colFacturaPrecioUnd = new DataGridViewTextBoxColumn();
            colFacturaPrecioVenta = new DataGridViewTextBoxColumn();
            gbxRegistroProductosTitulo = new GroupBox();
            pbLogo = new PictureBox();
            lblProductosTitulo = new Label();
            gbxRegistroDeProductos = new GroupBox();
            btnProductoModificar = new Button();
            lblProductoPrecioUnd = new Label();
            txtProductoPrecioUnd = new TextBox();
            lblProductoCantidad = new Label();
            btnProductoCancelar = new Button();
            btnProductoLimpiar = new Button();
            btnProductoAceptar = new Button();
            txtProductoCodigo = new TextBox();
            lblProductoCodigo = new Label();
            lblProductoNombre = new Label();
            txtProductoNombre = new TextBox();
            txtProductoCantidad = new TextBox();
            gbxDatosProductosFill = new GroupBox();
            gbxProductoBusqueda = new GroupBox();
            btnProductoBusqueda = new Button();
            txtProductoBusqueda = new TextBox();
            gbxListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).BeginInit();
            gbxRegistroProductosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroDeProductos.SuspendLayout();
            gbxDatosProductosFill.SuspendLayout();
            gbxProductoBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Controls.Add(dgvRegistroListaFuncionarios);
            gbxListaProductos.Dock = DockStyle.Bottom;
            gbxListaProductos.Location = new Point(0, 396);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(774, 265);
            gbxListaProductos.TabIndex = 11;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Lista de Productos";
            // 
            // dgvRegistroListaFuncionarios
            // 
            dgvRegistroListaFuncionarios.AllowUserToDeleteRows = false;
            dgvRegistroListaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRegistroListaFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colFacturaCodigo, colFacturaProducto, colFacturaCantidad, colFacturaPrecioUnd, colFacturaPrecioVenta });
            dgvRegistroListaFuncionarios.Dock = DockStyle.Fill;
            dgvRegistroListaFuncionarios.Location = new Point(3, 19);
            dgvRegistroListaFuncionarios.Name = "dgvRegistroListaFuncionarios";
            dgvRegistroListaFuncionarios.ReadOnly = true;
            dgvRegistroListaFuncionarios.RowTemplate.Height = 25;
            dgvRegistroListaFuncionarios.Size = new Size(768, 243);
            dgvRegistroListaFuncionarios.TabIndex = 12;
            // 
            // colFacturaCodigo
            // 
            colFacturaCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaCodigo.HeaderText = "Codigo";
            colFacturaCodigo.Name = "colFacturaCodigo";
            colFacturaCodigo.ReadOnly = true;
            // 
            // colFacturaProducto
            // 
            colFacturaProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaProducto.HeaderText = "Producto";
            colFacturaProducto.Name = "colFacturaProducto";
            colFacturaProducto.ReadOnly = true;
            // 
            // colFacturaCantidad
            // 
            colFacturaCantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFacturaCantidad.HeaderText = "Cantidad";
            colFacturaCantidad.Name = "colFacturaCantidad";
            colFacturaCantidad.ReadOnly = true;
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
            // gbxRegistroProductosTitulo
            // 
            gbxRegistroProductosTitulo.Controls.Add(pbLogo);
            gbxRegistroProductosTitulo.Controls.Add(lblProductosTitulo);
            gbxRegistroProductosTitulo.Dock = DockStyle.Top;
            gbxRegistroProductosTitulo.Location = new Point(0, 0);
            gbxRegistroProductosTitulo.Name = "gbxRegistroProductosTitulo";
            gbxRegistroProductosTitulo.Size = new Size(774, 136);
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
            lblProductosTitulo.Location = new Point(181, 59);
            lblProductosTitulo.Name = "lblProductosTitulo";
            lblProductosTitulo.Size = new Size(299, 36);
            lblProductosTitulo.TabIndex = 16;
            lblProductosTitulo.Text = "Modificacion Productos";
            lblProductosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxRegistroDeProductos
            // 
            gbxRegistroDeProductos.Controls.Add(btnProductoModificar);
            gbxRegistroDeProductos.Controls.Add(lblProductoPrecioUnd);
            gbxRegistroDeProductos.Controls.Add(txtProductoPrecioUnd);
            gbxRegistroDeProductos.Controls.Add(lblProductoCantidad);
            gbxRegistroDeProductos.Controls.Add(btnProductoCancelar);
            gbxRegistroDeProductos.Controls.Add(btnProductoLimpiar);
            gbxRegistroDeProductos.Controls.Add(btnProductoAceptar);
            gbxRegistroDeProductos.Controls.Add(txtProductoCodigo);
            gbxRegistroDeProductos.Controls.Add(lblProductoCodigo);
            gbxRegistroDeProductos.Controls.Add(lblProductoNombre);
            gbxRegistroDeProductos.Controls.Add(txtProductoNombre);
            gbxRegistroDeProductos.Controls.Add(txtProductoCantidad);
            gbxRegistroDeProductos.Dock = DockStyle.Right;
            gbxRegistroDeProductos.Location = new Point(352, 19);
            gbxRegistroDeProductos.Name = "gbxRegistroDeProductos";
            gbxRegistroDeProductos.Size = new Size(419, 238);
            gbxRegistroDeProductos.TabIndex = 3;
            gbxRegistroDeProductos.TabStop = false;
            gbxRegistroDeProductos.Text = "Datos Productos";
            // 
            // btnProductoModificar
            // 
            btnProductoModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoModificar.Location = new Point(291, 86);
            btnProductoModificar.Name = "btnProductoModificar";
            btnProductoModificar.Size = new Size(93, 32);
            btnProductoModificar.TabIndex = 8;
            btnProductoModificar.Text = "Modificar";
            btnProductoModificar.UseVisualStyleBackColor = true;
            // 
            // lblProductoPrecioUnd
            // 
            lblProductoPrecioUnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoPrecioUnd.Location = new Point(14, 170);
            lblProductoPrecioUnd.Name = "lblProductoPrecioUnd";
            lblProductoPrecioUnd.Size = new Size(114, 22);
            lblProductoPrecioUnd.TabIndex = 13;
            lblProductoPrecioUnd.Text = "Precio Und";
            lblProductoPrecioUnd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProductoPrecioUnd
            // 
            txtProductoPrecioUnd.AcceptsTab = true;
            txtProductoPrecioUnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoPrecioUnd.Location = new Point(134, 163);
            txtProductoPrecioUnd.Name = "txtProductoPrecioUnd";
            txtProductoPrecioUnd.Size = new Size(151, 29);
            txtProductoPrecioUnd.TabIndex = 6;
            txtProductoPrecioUnd.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductoCantidad
            // 
            lblProductoCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoCantidad.Location = new Point(14, 135);
            lblProductoCantidad.Name = "lblProductoCantidad";
            lblProductoCantidad.Size = new Size(114, 22);
            lblProductoCantidad.TabIndex = 11;
            lblProductoCantidad.Text = "Cantidad";
            lblProductoCantidad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProductoCancelar
            // 
            btnProductoCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoCancelar.Location = new Point(291, 162);
            btnProductoCancelar.Name = "btnProductoCancelar";
            btnProductoCancelar.Size = new Size(93, 32);
            btnProductoCancelar.TabIndex = 10;
            btnProductoCancelar.Text = "Cancelar";
            btnProductoCancelar.UseVisualStyleBackColor = true;
            // 
            // btnProductoLimpiar
            // 
            btnProductoLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoLimpiar.Location = new Point(291, 124);
            btnProductoLimpiar.Name = "btnProductoLimpiar";
            btnProductoLimpiar.Size = new Size(93, 32);
            btnProductoLimpiar.TabIndex = 9;
            btnProductoLimpiar.Text = "Limpiar";
            btnProductoLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnProductoAceptar
            // 
            btnProductoAceptar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoAceptar.Location = new Point(291, 48);
            btnProductoAceptar.Name = "btnProductoAceptar";
            btnProductoAceptar.Size = new Size(93, 32);
            btnProductoAceptar.TabIndex = 7;
            btnProductoAceptar.Text = "Aceptar";
            btnProductoAceptar.UseVisualStyleBackColor = true;
            // 
            // txtProductoCodigo
            // 
            txtProductoCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoCodigo.Location = new Point(134, 52);
            txtProductoCodigo.Name = "txtProductoCodigo";
            txtProductoCodigo.Size = new Size(151, 29);
            txtProductoCodigo.TabIndex = 3;
            txtProductoCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductoCodigo
            // 
            lblProductoCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoCodigo.Location = new Point(14, 52);
            lblProductoCodigo.Name = "lblProductoCodigo";
            lblProductoCodigo.Size = new Size(114, 22);
            lblProductoCodigo.TabIndex = 0;
            lblProductoCodigo.Text = "Codigo";
            lblProductoCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblProductoNombre
            // 
            lblProductoNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoNombre.Location = new Point(14, 93);
            lblProductoNombre.Name = "lblProductoNombre";
            lblProductoNombre.Size = new Size(114, 22);
            lblProductoNombre.TabIndex = 1;
            lblProductoNombre.Text = "Producto";
            lblProductoNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoNombre.Location = new Point(134, 93);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.Size = new Size(151, 29);
            txtProductoNombre.TabIndex = 4;
            txtProductoNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductoCantidad
            // 
            txtProductoCantidad.AcceptsTab = true;
            txtProductoCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoCantidad.Location = new Point(134, 128);
            txtProductoCantidad.Name = "txtProductoCantidad";
            txtProductoCantidad.Size = new Size(151, 29);
            txtProductoCantidad.TabIndex = 5;
            txtProductoCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxDatosProductosFill
            // 
            gbxDatosProductosFill.Controls.Add(gbxProductoBusqueda);
            gbxDatosProductosFill.Controls.Add(gbxRegistroDeProductos);
            gbxDatosProductosFill.Dock = DockStyle.Fill;
            gbxDatosProductosFill.Location = new Point(0, 136);
            gbxDatosProductosFill.Name = "gbxDatosProductosFill";
            gbxDatosProductosFill.Size = new Size(774, 260);
            gbxDatosProductosFill.TabIndex = 8;
            gbxDatosProductosFill.TabStop = false;
            // 
            // gbxProductoBusqueda
            // 
            gbxProductoBusqueda.Controls.Add(btnProductoBusqueda);
            gbxProductoBusqueda.Controls.Add(txtProductoBusqueda);
            gbxProductoBusqueda.Dock = DockStyle.Left;
            gbxProductoBusqueda.Location = new Point(3, 19);
            gbxProductoBusqueda.Name = "gbxProductoBusqueda";
            gbxProductoBusqueda.Size = new Size(310, 238);
            gbxProductoBusqueda.TabIndex = 2;
            gbxProductoBusqueda.TabStop = false;
            gbxProductoBusqueda.Text = "Busqueda de Productos por Nombre";
            // 
            // btnProductoBusqueda
            // 
            btnProductoBusqueda.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnProductoBusqueda.Location = new Point(6, 88);
            btnProductoBusqueda.Name = "btnProductoBusqueda";
            btnProductoBusqueda.Size = new Size(93, 32);
            btnProductoBusqueda.TabIndex = 2;
            btnProductoBusqueda.Text = "Buscar";
            btnProductoBusqueda.UseVisualStyleBackColor = true;
            // 
            // txtProductoBusqueda
            // 
            txtProductoBusqueda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoBusqueda.Location = new Point(6, 30);
            txtProductoBusqueda.Name = "txtProductoBusqueda";
            txtProductoBusqueda.Size = new Size(210, 29);
            txtProductoBusqueda.TabIndex = 1;
            txtProductoBusqueda.TextAlign = HorizontalAlignment.Center;
            // 
            // frmModificacionProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxDatosProductosFill);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxRegistroProductosTitulo);
            MinimumSize = new Size(790, 700);
            Name = "frmModificacionProductos";
            Text = "Modificacion Productos";
            gbxListaProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).EndInit();
            gbxRegistroProductosTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroDeProductos.ResumeLayout(false);
            gbxRegistroDeProductos.PerformLayout();
            gbxDatosProductosFill.ResumeLayout(false);
            gbxProductoBusqueda.ResumeLayout(false);
            gbxProductoBusqueda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxListaProductos;
        private DataGridView dgvRegistroListaFuncionarios;
        private DataGridViewTextBoxColumn colFacturaCodigo;
        private DataGridViewTextBoxColumn colFacturaProducto;
        private DataGridViewTextBoxColumn colFacturaCantidad;
        private DataGridViewTextBoxColumn colFacturaPrecioUnd;
        private DataGridViewTextBoxColumn colFacturaPrecioVenta;
        private GroupBox gbxRegistroProductosTitulo;
        private PictureBox pbLogo;
        private Label lblProductosTitulo;
        private GroupBox gbxRegistroDeProductos;
        private Label lblProductoPrecioUnd;
        private TextBox txtProductoPrecioUnd;
        private Label lblProductoCantidad;
        private Button btnProductoCancelar;
        private Button btnProductoLimpiar;
        private Button btnProductoAceptar;
        private TextBox txtProductoCodigo;
        private Label lblProductoCodigo;
        private Label lblProductoNombre;
        private TextBox txtProductoNombre;
        private TextBox txtProductoCantidad;
        private Button btnProductoModificar;
        private GroupBox gbxDatosProductosFill;
        private GroupBox gbxProductoBusqueda;
        private Button btnProductoBusqueda;
        private TextBox txtProductoBusqueda;
    }
}