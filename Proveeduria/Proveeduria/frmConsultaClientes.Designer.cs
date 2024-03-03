namespace Proveeduria
{
    partial class frmConsultaClientes
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
            btnBuscarCliente = new Button();
            txtBuscarIdentificacion = new TextBox();
            lblIdentificacionCliente = new Label();
            gbxListaClientes = new GroupBox();
            lvwListaClientes = new ListView();
            colNumIdentificacion = new ColumnHeader();
            colTipoIDentificacion = new ColumnHeader();
            colCodigoCliente = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellidoPrimero = new ColumnHeader();
            colApellidoSegundo = new ColumnHeader();
            colTelefono = new ColumnHeader();
            colEmail = new ColumnHeader();
            colProvincia = new ColumnHeader();
            colCanton = new ColumnHeader();
            colDistrito = new ColumnHeader();
            colOtrasSenias = new ColumnHeader();
            gbxConsultaClientes.SuspendLayout();
            gbxListaClientes.SuspendLayout();
            SuspendLayout();
            // 
            // gbxConsultaClientes
            // 
            gbxConsultaClientes.Controls.Add(btnLimpiar);
            gbxConsultaClientes.Controls.Add(btnBuscarCliente);
            gbxConsultaClientes.Controls.Add(txtBuscarIdentificacion);
            gbxConsultaClientes.Controls.Add(lblIdentificacionCliente);
            gbxConsultaClientes.Dock = DockStyle.Top;
            gbxConsultaClientes.Location = new Point(0, 0);
            gbxConsultaClientes.Name = "gbxConsultaClientes";
            gbxConsultaClientes.Size = new Size(938, 64);
            gbxConsultaClientes.TabIndex = 0;
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
            // btnBuscarCliente
            // 
            btnBuscarCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarCliente.Location = new Point(348, 22);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(90, 28);
            btnBuscarCliente.TabIndex = 3;
            btnBuscarCliente.Text = "Buscar";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // txtBuscarIdentificacion
            // 
            txtBuscarIdentificacion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarIdentificacion.Location = new Point(141, 25);
            txtBuscarIdentificacion.Name = "txtBuscarIdentificacion";
            txtBuscarIdentificacion.Size = new Size(201, 24);
            txtBuscarIdentificacion.TabIndex = 2;
            txtBuscarIdentificacion.KeyPress += txtBuscarIdentificacion_KeyPress;
            // 
            // lblIdentificacionCliente
            // 
            lblIdentificacionCliente.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdentificacionCliente.Location = new Point(12, 19);
            lblIdentificacionCliente.Name = "lblIdentificacionCliente";
            lblIdentificacionCliente.Size = new Size(123, 31);
            lblIdentificacionCliente.TabIndex = 1;
            lblIdentificacionCliente.Text = "Identificacion ";
            lblIdentificacionCliente.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListaClientes
            // 
            gbxListaClientes.Controls.Add(lvwListaClientes);
            gbxListaClientes.Dock = DockStyle.Fill;
            gbxListaClientes.Location = new Point(0, 64);
            gbxListaClientes.Name = "gbxListaClientes";
            gbxListaClientes.Size = new Size(938, 597);
            gbxListaClientes.TabIndex = 5;
            gbxListaClientes.TabStop = false;
            gbxListaClientes.Text = "Lista De Clientes";
            // 
            // lvwListaClientes
            // 
            lvwListaClientes.BackColor = SystemColors.Info;
            lvwListaClientes.Columns.AddRange(new ColumnHeader[] { colNumIdentificacion, colTipoIDentificacion, colCodigoCliente, colNombre, colApellidoPrimero, colApellidoSegundo, colTelefono, colEmail, colProvincia, colCanton, colDistrito, colOtrasSenias });
            lvwListaClientes.Dock = DockStyle.Fill;
            lvwListaClientes.Location = new Point(3, 19);
            lvwListaClientes.Name = "lvwListaClientes";
            lvwListaClientes.Size = new Size(932, 575);
            lvwListaClientes.TabIndex = 6;
            lvwListaClientes.UseCompatibleStateImageBehavior = false;
            lvwListaClientes.View = View.Details;
            // 
            // colNumIdentificacion
            // 
            colNumIdentificacion.Text = "Numero Identificacion";
            colNumIdentificacion.Width = 140;
            // 
            // colTipoIDentificacion
            // 
            colTipoIDentificacion.Text = "Tipo Identificacion";
            colTipoIDentificacion.Width = 140;
            // 
            // colCodigoCliente
            // 
            colCodigoCliente.Text = "Codigo Cliente";
            colCodigoCliente.Width = 120;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 120;
            // 
            // colApellidoPrimero
            // 
            colApellidoPrimero.Text = "Primer Apellido";
            colApellidoPrimero.Width = 120;
            // 
            // colApellidoSegundo
            // 
            colApellidoSegundo.Text = "Segundo Apellido";
            colApellidoSegundo.Width = 120;
            // 
            // colTelefono
            // 
            colTelefono.Text = "Telefono";
            colTelefono.Width = 120;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 120;
            // 
            // colProvincia
            // 
            colProvincia.Text = "Provincia";
            colProvincia.Width = 120;
            // 
            // colCanton
            // 
            colCanton.Text = "Canton";
            colCanton.Width = 120;
            // 
            // colDistrito
            // 
            colDistrito.Text = "Distrito";
            colDistrito.Width = 120;
            // 
            // colOtrasSenias
            // 
            colOtrasSenias.Text = "Otras Senias";
            colOtrasSenias.Width = 120;
            // 
            // frmConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 661);
            Controls.Add(gbxListaClientes);
            Controls.Add(gbxConsultaClientes);
            MinimumSize = new Size(800, 700);
            Name = "frmConsultaClientes";
            Text = "Consulta Clientes";
            Load += frmConsultaClientes_Load;
            gbxConsultaClientes.ResumeLayout(false);
            gbxConsultaClientes.PerformLayout();
            gbxListaClientes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxConsultaClientes;
        private TextBox txtBuscarIdentificacion;
        private Label lblIdentificacionCliente;
        private GroupBox gbxListaClientes;
        private Button btnBuscarCliente;
        private Button btnLimpiar;
        private ListView lvwListaClientes;
        private ColumnHeader colNumIdentificacion;
        private ColumnHeader colTipoIDentificacion;
        private ColumnHeader colCodigoCliente;
        private ColumnHeader colNombre;
        private ColumnHeader colApellidoPrimero;
        private ColumnHeader colApellidoSegundo;
        private ColumnHeader colTelefono;
        private ColumnHeader colEmail;
        private ColumnHeader colProvincia;
        private ColumnHeader colCanton;
        private ColumnHeader colDistrito;
        private ColumnHeader colOtrasSenias;
    }
}