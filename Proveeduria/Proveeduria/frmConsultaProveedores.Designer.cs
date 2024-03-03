namespace Proveeduria
{
    partial class frmConsultaProveedores
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
            gbxConsultaClientes = new GroupBox();
            btnLimpiar = new Button();
            btnBuscarProveedor = new Button();
            txtBuscar = new TextBox();
            lblIdentificacionProveedor = new Label();
            gbxListaProveedores = new GroupBox();
            lvwListaProveedores = new ListView();
            colCodigoProv = new ColumnHeader();
            colNombreProv = new ColumnHeader();
            colTipoIdentificacionProv = new ColumnHeader();
            colIdentificacionProv = new ColumnHeader();
            colTelefonoProv = new ColumnHeader();
            colEmailProv = new ColumnHeader();
            gbxConsultaClientes.SuspendLayout();
            gbxListaProveedores.SuspendLayout();
            SuspendLayout();
            // 
            // gbxConsultaClientes
            // 
            gbxConsultaClientes.Controls.Add(btnLimpiar);
            gbxConsultaClientes.Controls.Add(btnBuscarProveedor);
            gbxConsultaClientes.Controls.Add(txtBuscar);
            gbxConsultaClientes.Controls.Add(lblIdentificacionProveedor);
            gbxConsultaClientes.Dock = DockStyle.Top;
            gbxConsultaClientes.Location = new Point(0, 0);
            gbxConsultaClientes.Name = "gbxConsultaClientes";
            gbxConsultaClientes.Size = new Size(800, 64);
            gbxConsultaClientes.TabIndex = 1;
            gbxConsultaClientes.TabStop = false;
            gbxConsultaClientes.Text = "Buscar por Numero de Identificacion de Cliente";
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
            // btnBuscarProveedor
            // 
            btnBuscarProveedor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarProveedor.Location = new Point(348, 22);
            btnBuscarProveedor.Name = "btnBuscarProveedor";
            btnBuscarProveedor.Size = new Size(90, 28);
            btnBuscarProveedor.TabIndex = 3;
            btnBuscarProveedor.Text = "Buscar";
            btnBuscarProveedor.UseVisualStyleBackColor = true;
            btnBuscarProveedor.Click += btnBuscarProveedor_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscar.Location = new Point(141, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(201, 24);
            txtBuscar.TabIndex = 2;
            txtBuscar.KeyPress += txtBuscar_KeyPress;
            // 
            // lblIdentificacionProveedor
            // 
            lblIdentificacionProveedor.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificacionProveedor.Location = new Point(12, 19);
            lblIdentificacionProveedor.Name = "lblIdentificacionProveedor";
            lblIdentificacionProveedor.Size = new Size(123, 31);
            lblIdentificacionProveedor.TabIndex = 1;
            lblIdentificacionProveedor.Text = "Identificacion ";
            lblIdentificacionProveedor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListaProveedores
            // 
            gbxListaProveedores.Controls.Add(lvwListaProveedores);
            gbxListaProveedores.Dock = DockStyle.Fill;
            gbxListaProveedores.Location = new Point(0, 64);
            gbxListaProveedores.Name = "gbxListaProveedores";
            gbxListaProveedores.Size = new Size(800, 386);
            gbxListaProveedores.TabIndex = 6;
            gbxListaProveedores.TabStop = false;
            gbxListaProveedores.Text = "Lista De Proveedores";
            // 
            // lvwListaProveedores
            // 
            lvwListaProveedores.BackColor = SystemColors.Info;
            lvwListaProveedores.Columns.AddRange(new ColumnHeader[] { colCodigoProv, colNombreProv, colTipoIdentificacionProv, colIdentificacionProv, colTelefonoProv, colEmailProv });
            lvwListaProveedores.Dock = DockStyle.Fill;
            lvwListaProveedores.Location = new Point(3, 19);
            lvwListaProveedores.Name = "lvwListaProveedores";
            lvwListaProveedores.Size = new Size(794, 364);
            lvwListaProveedores.TabIndex = 6;
            lvwListaProveedores.UseCompatibleStateImageBehavior = false;
            lvwListaProveedores.View = View.Details;
            // 
            // colCodigoProv
            // 
            colCodigoProv.Text = "Codigo Proveedor";
            colCodigoProv.Width = 130;
            // 
            // colNombreProv
            // 
            colNombreProv.Text = "Proveedor";
            colNombreProv.Width = 130;
            // 
            // colTipoIdentificacionProv
            // 
            colTipoIdentificacionProv.Text = "Tipo Identificacion";
            colTipoIdentificacionProv.Width = 130;
            // 
            // colIdentificacionProv
            // 
            colIdentificacionProv.Text = "Identificacion";
            colIdentificacionProv.Width = 130;
            // 
            // colTelefonoProv
            // 
            colTelefonoProv.Text = "Telefono";
            colTelefonoProv.Width = 130;
            // 
            // colEmailProv
            // 
            colEmailProv.Text = "Email";
            colEmailProv.Width = 130;
            // 
            // frmConsultaProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbxListaProveedores);
            Controls.Add(gbxConsultaClientes);
            Name = "frmConsultaProveedores";
            Text = "Consulta Proveedores";
            Load += frmConsultaProveedores_Load;
            gbxConsultaClientes.ResumeLayout(false);
            gbxConsultaClientes.PerformLayout();
            gbxListaProveedores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxConsultaClientes;
        private Button btnLimpiar;
        private Button btnBuscarProveedor;
        private TextBox txtBuscar;
        private Label lblIdentificacionProveedor;
        private GroupBox gbxListaProveedores;
        private ListView lvwListaProveedores;
        private ColumnHeader colCodigoProv;
        private ColumnHeader colNombreProv;
        private ColumnHeader colTipoIdentificacionProv;
        private ColumnHeader colTelefonoProv;
        private ColumnHeader colEmailProv;
        private ColumnHeader colIdentificacionProv;
    }
}