namespace Proveeduria
{
    partial class frmConsultaProductos
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
            gbxConsultaProductos = new GroupBox();
            btnLimpiar = new Button();
            btnBuscarCodigo = new Button();
            txtBuscarCodigo = new TextBox();
            lblBuscarCodigo = new Label();
            gbxListaProductos = new GroupBox();
            lvwListaProductos = new ListView();
            colCatProducto = new ColumnHeader();
            colCodProducto = new ColumnHeader();
            colDesProducto = new ColumnHeader();
            colCantidadProducto = new ColumnHeader();
            colPrecioUndProducto = new ColumnHeader();
            gbxRegistroProductos = new GroupBox();
            lblCategoriaProducto = new Label();
            txtCantidadProducto = new TextBox();
            btnAgregarProducto = new Button();
            txtProductoNombre = new TextBox();
            txtCategoriaProducto = new TextBox();
            lblProductoNombre = new Label();
            btnCancelarProducto = new Button();
            lblCantidadProducto = new Label();
            btnLimpiarProducto = new Button();
            txtPrecioUndProducto = new TextBox();
            lblPrecioUndProducto = new Label();
            gbxConsultaProductos.SuspendLayout();
            gbxListaProductos.SuspendLayout();
            gbxRegistroProductos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxConsultaProductos
            // 
            gbxConsultaProductos.Controls.Add(btnLimpiar);
            gbxConsultaProductos.Controls.Add(btnBuscarCodigo);
            gbxConsultaProductos.Controls.Add(txtBuscarCodigo);
            gbxConsultaProductos.Controls.Add(lblBuscarCodigo);
            gbxConsultaProductos.Location = new Point(0, 103);
            gbxConsultaProductos.Name = "gbxConsultaProductos";
            gbxConsultaProductos.Size = new Size(750, 166);
            gbxConsultaProductos.TabIndex = 9;
            gbxConsultaProductos.TabStop = false;
            gbxConsultaProductos.Text = "Consultar Productos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(348, 17);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 22);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Actualizar Lista";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarCodigo
            // 
            btnBuscarCodigo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarCodigo.Location = new Point(264, 17);
            btnBuscarCodigo.Name = "btnBuscarCodigo";
            btnBuscarCodigo.Size = new Size(78, 22);
            btnBuscarCodigo.TabIndex = 11;
            btnBuscarCodigo.Text = "Buscar";
            btnBuscarCodigo.UseVisualStyleBackColor = true;
            btnBuscarCodigo.Click += btnBuscarCodigo_Click;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(112, 17);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(146, 22);
            txtBuscarCodigo.TabIndex = 10;
            txtBuscarCodigo.KeyPress += txtBuscarCodigo_KeyPress;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarCodigo.Location = new Point(12, 19);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(94, 19);
            lblBuscarCodigo.TabIndex = 1;
            lblBuscarCodigo.Text = "Codigo";
            lblBuscarCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Controls.Add(lvwListaProductos);
            gbxListaProductos.Dock = DockStyle.Bottom;
            gbxListaProductos.Location = new Point(0, 275);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(750, 386);
            gbxListaProductos.TabIndex = 20;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Lista De Productos";
            // 
            // lvwListaProductos
            // 
            lvwListaProductos.BackColor = SystemColors.Info;
            lvwListaProductos.Columns.AddRange(new ColumnHeader[] { colCatProducto, colCodProducto, colDesProducto, colCantidadProducto, colPrecioUndProducto });
            lvwListaProductos.Dock = DockStyle.Fill;
            lvwListaProductos.Location = new Point(3, 19);
            lvwListaProductos.Name = "lvwListaProductos";
            lvwListaProductos.Size = new Size(744, 364);
            lvwListaProductos.TabIndex = 21;
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
            colDesProducto.Text = "Descripcion Producto";
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
            // gbxRegistroProductos
            // 
            gbxRegistroProductos.Controls.Add(lblCategoriaProducto);
            gbxRegistroProductos.Controls.Add(txtCantidadProducto);
            gbxRegistroProductos.Controls.Add(btnAgregarProducto);
            gbxRegistroProductos.Controls.Add(txtProductoNombre);
            gbxRegistroProductos.Controls.Add(txtCategoriaProducto);
            gbxRegistroProductos.Controls.Add(lblProductoNombre);
            gbxRegistroProductos.Controls.Add(btnCancelarProducto);
            gbxRegistroProductos.Controls.Add(lblCantidadProducto);
            gbxRegistroProductos.Controls.Add(btnLimpiarProducto);
            gbxRegistroProductos.Controls.Add(txtPrecioUndProducto);
            gbxRegistroProductos.Controls.Add(lblPrecioUndProducto);
            gbxRegistroProductos.Dock = DockStyle.Top;
            gbxRegistroProductos.Location = new Point(0, 0);
            gbxRegistroProductos.Name = "gbxRegistroProductos";
            gbxRegistroProductos.Size = new Size(750, 97);
            gbxRegistroProductos.TabIndex = 1;
            gbxRegistroProductos.TabStop = false;
            gbxRegistroProductos.Text = "Ingreso Datos Productos";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoriaProducto.Location = new Point(5, 20);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(72, 22);
            lblCategoriaProducto.TabIndex = 40;
            lblCategoriaProducto.Text = "Categoria";
            lblCategoriaProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.AcceptsTab = true;
            txtCantidadProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadProducto.Location = new Point(83, 59);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(124, 22);
            txtCantidadProducto.TabIndex = 4;
            txtCantidadProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(534, 20);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(133, 24);
            btnAgregarProducto.TabIndex = 6;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoNombre.Location = new Point(294, 20);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.Size = new Size(143, 22);
            txtProductoNombre.TabIndex = 3;
            txtProductoNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.AcceptsTab = true;
            txtCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoriaProducto.Location = new Point(83, 20);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(124, 22);
            txtCategoriaProducto.TabIndex = 2;
            txtCategoriaProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductoNombre
            // 
            lblProductoNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoNombre.Location = new Point(213, 20);
            lblProductoNombre.Name = "lblProductoNombre";
            lblProductoNombre.Size = new Size(75, 22);
            lblProductoNombre.TabIndex = 42;
            lblProductoNombre.Text = "Producto";
            lblProductoNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarProducto.Location = new Point(638, 55);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(98, 26);
            btnCancelarProducto.TabIndex = 8;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadProducto.Location = new Point(16, 59);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(61, 22);
            lblCantidadProducto.TabIndex = 44;
            lblCantidadProducto.Text = "Cantidad";
            lblCantidadProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarProducto.Location = new Point(534, 55);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(98, 26);
            btnLimpiarProducto.TabIndex = 7;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // txtPrecioUndProducto
            // 
            txtPrecioUndProducto.AcceptsTab = true;
            txtPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUndProducto.Location = new Point(294, 59);
            txtPrecioUndProducto.Name = "txtPrecioUndProducto";
            txtPrecioUndProducto.Size = new Size(143, 22);
            txtPrecioUndProducto.TabIndex = 5;
            txtPrecioUndProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrecioUndProducto
            // 
            lblPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioUndProducto.Location = new Point(213, 63);
            lblPrecioUndProducto.Name = "lblPrecioUndProducto";
            lblPrecioUndProducto.Size = new Size(75, 22);
            lblPrecioUndProducto.TabIndex = 46;
            lblPrecioUndProducto.Text = "Precio Und";
            lblPrecioUndProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 661);
            ControlBox = false;
            Controls.Add(gbxRegistroProductos);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxConsultaProductos);
            MinimumSize = new Size(700, 700);
            Name = "frmConsultaProductos";
            Text = "Registro Y Consulta de Productos";
            Load += frmConsultaProductos_Load;
            gbxConsultaProductos.ResumeLayout(false);
            gbxConsultaProductos.PerformLayout();
            gbxListaProductos.ResumeLayout(false);
            gbxRegistroProductos.ResumeLayout(false);
            gbxRegistroProductos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxConsultaProductos;
        private Button btnLimpiar;
        private Button btnBuscarCodigo;
        private TextBox txtBuscarCodigo;
        private Label lblBuscarCodigo;
        private GroupBox gbxListaProductos;
        private ListView lvwListaProductos;
        private ColumnHeader colCatProducto;
        private ColumnHeader colCodProducto;
        private ColumnHeader colDesProducto;
        private ColumnHeader colCantidadProducto;
        private ColumnHeader colPrecioUndProducto;
        private GroupBox gbxRegistroProductos;
        private Label lblCategoriaProducto;
        private TextBox txtCantidadProducto;
        private Button btnAgregarProducto;
        private TextBox txtProductoNombre;
        private TextBox txtCategoriaProducto;
        private Label lblProductoNombre;
        private Button btnCancelarProducto;
        private Label lblCantidadProducto;
        private Button btnLimpiarProducto;
        private TextBox txtPrecioUndProducto;
        private Label lblPrecioUndProducto;
    }
}