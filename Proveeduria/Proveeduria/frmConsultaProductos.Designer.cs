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
            gbxConsultaProductos.Size = new Size(750, 64);
            gbxConsultaProductos.TabIndex = 1;
            gbxConsultaProductos.TabStop = false;
            gbxConsultaProductos.Text = "Consultar Productos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(444, 22);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 28);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscarCodigo
            // 
            btnBuscarCodigo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarCodigo.Location = new Point(348, 22);
            btnBuscarCodigo.Name = "btnBuscarCodigo";
            btnBuscarCodigo.Size = new Size(90, 28);
            btnBuscarCodigo.TabIndex = 3;
            btnBuscarCodigo.Text = "Buscar";
            btnBuscarCodigo.UseVisualStyleBackColor = true;
            btnBuscarCodigo.Click += btnBuscarCodigo_Click;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(141, 25);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.Size = new Size(201, 24);
            txtBuscarCodigo.TabIndex = 2;
            txtBuscarCodigo.KeyPress += txtBuscarCodigo_KeyPress;
            // 
            // lblBuscarCodigo
            // 
            lblBuscarCodigo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarCodigo.Location = new Point(12, 19);
            lblBuscarCodigo.Name = "lblBuscarCodigo";
            lblBuscarCodigo.Size = new Size(123, 31);
            lblBuscarCodigo.TabIndex = 1;
            lblBuscarCodigo.Text = "Identificacion ";
            lblBuscarCodigo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListaProductos
            // 
            gbxListaProductos.Controls.Add(lvwListaProductos);
            gbxListaProductos.Dock = DockStyle.Bottom;
            gbxListaProductos.Location = new Point(0, 173);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(750, 277);
            gbxListaProductos.TabIndex = 2;
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
            lvwListaProductos.Size = new Size(744, 255);
            lvwListaProductos.TabIndex = 42;
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
            gbxRegistroProductos.TabIndex = 3;
            gbxRegistroProductos.TabStop = false;
            gbxRegistroProductos.Text = "Ingreso Datos Productos";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCategoriaProducto.Location = new Point(5, 20);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(61, 22);
            lblCategoriaProducto.TabIndex = 40;
            lblCategoriaProducto.Text = "Categoria";
            lblCategoriaProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.AcceptsTab = true;
            txtCantidadProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadProducto.Location = new Point(461, 22);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(75, 21);
            txtCantidadProducto.TabIndex = 45;
            txtCantidadProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarProducto.Location = new Point(395, 59);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(133, 24);
            btnAgregarProducto.TabIndex = 48;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtProductoNombre
            // 
            txtProductoNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductoNombre.Location = new Point(245, 21);
            txtProductoNombre.Name = "txtProductoNombre";
            txtProductoNombre.Size = new Size(143, 21);
            txtProductoNombre.TabIndex = 43;
            txtProductoNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.AcceptsTab = true;
            txtCategoriaProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoriaProducto.Location = new Point(72, 21);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(94, 21);
            txtCategoriaProducto.TabIndex = 41;
            txtCategoriaProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProductoNombre
            // 
            lblProductoNombre.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblProductoNombre.Location = new Point(172, 21);
            lblProductoNombre.Name = "lblProductoNombre";
            lblProductoNombre.Size = new Size(67, 22);
            lblProductoNombre.TabIndex = 42;
            lblProductoNombre.Text = "Producto";
            lblProductoNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelarProducto.Location = new Point(644, 59);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(98, 26);
            btnCancelarProducto.TabIndex = 51;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = true;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidadProducto.Location = new Point(394, 20);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(61, 22);
            lblCantidadProducto.TabIndex = 44;
            lblCantidadProducto.Text = "Cantidad";
            lblCantidadProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiarProducto
            // 
            btnLimpiarProducto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiarProducto.Location = new Point(534, 59);
            btnLimpiarProducto.Name = "btnLimpiarProducto";
            btnLimpiarProducto.Size = new Size(98, 26);
            btnLimpiarProducto.TabIndex = 50;
            btnLimpiarProducto.Text = "Limpiar";
            btnLimpiarProducto.UseVisualStyleBackColor = true;
            btnLimpiarProducto.Click += btnLimpiarProducto_Click;
            // 
            // txtPrecioUndProducto
            // 
            txtPrecioUndProducto.AcceptsTab = true;
            txtPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioUndProducto.Location = new Point(623, 22);
            txtPrecioUndProducto.Name = "txtPrecioUndProducto";
            txtPrecioUndProducto.Size = new Size(119, 21);
            txtPrecioUndProducto.TabIndex = 47;
            txtPrecioUndProducto.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPrecioUndProducto
            // 
            lblPrecioUndProducto.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioUndProducto.Location = new Point(542, 20);
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
            ClientSize = new Size(750, 450);
            ControlBox = false;
            Controls.Add(gbxRegistroProductos);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxConsultaProductos);
            Name = "frmConsultaProductos";
            Text = "Registro de Productos";
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