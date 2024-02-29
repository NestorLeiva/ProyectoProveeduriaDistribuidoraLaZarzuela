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
            gbxConsultaProductos.SuspendLayout();
            gbxListaProductos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxConsultaProductos
            // 
            gbxConsultaProductos.Controls.Add(btnLimpiar);
            gbxConsultaProductos.Controls.Add(btnBuscarCodigo);
            gbxConsultaProductos.Controls.Add(txtBuscarCodigo);
            gbxConsultaProductos.Controls.Add(lblBuscarCodigo);
            gbxConsultaProductos.Dock = DockStyle.Top;
            gbxConsultaProductos.Location = new Point(0, 0);
            gbxConsultaProductos.Name = "gbxConsultaProductos";
            gbxConsultaProductos.Size = new Size(800, 64);
            gbxConsultaProductos.TabIndex = 1;
            gbxConsultaProductos.TabStop = false;
            gbxConsultaProductos.Text = "Consultar por nombre";
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
            gbxListaProductos.Dock = DockStyle.Fill;
            gbxListaProductos.Location = new Point(0, 64);
            gbxListaProductos.Name = "gbxListaProductos";
            gbxListaProductos.Size = new Size(800, 386);
            gbxListaProductos.TabIndex = 2;
            gbxListaProductos.TabStop = false;
            gbxListaProductos.Text = "Lista De Clientes";
            // 
            // lvwListaProductos
            // 
            lvwListaProductos.BackColor = SystemColors.Info;
            lvwListaProductos.Columns.AddRange(new ColumnHeader[] { colCatProducto, colCodProducto, colDesProducto, colCantidadProducto, colPrecioUndProducto });
            lvwListaProductos.Dock = DockStyle.Fill;
            lvwListaProductos.Location = new Point(3, 19);
            lvwListaProductos.Name = "lvwListaProductos";
            lvwListaProductos.Size = new Size(794, 364);
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
            // frmConsultaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxListaProductos);
            Controls.Add(gbxConsultaProductos);
            Name = "frmConsultaProductos";
            Text = "Consulta Productos";
            Load += frmConsultaProductos_Load;
            gbxConsultaProductos.ResumeLayout(false);
            gbxConsultaProductos.PerformLayout();
            gbxListaProductos.ResumeLayout(false);
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
    }
}