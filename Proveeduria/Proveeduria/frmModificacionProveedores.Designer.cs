namespace Proveeduria
{
    partial class frmModificacionProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionProveedores));
            ListViewItem listViewItem3 = new ListViewItem("");
            gbxModificacionProveedorTitulo = new GroupBox();
            pbLogo = new PictureBox();
            lblProveedorTitulo = new Label();
            gbxRegistroFuncionariosDatos = new GroupBox();
            lblProveedorDNI1 = new Label();
            txtProveedorDNI1 = new TextBox();
            txtModificarTelefono = new TextBox();
            lblModificarTelefono = new Label();
            txtProveedorNombre = new TextBox();
            lblProveedorNombre = new Label();
            btnProveedorCancelar = new Button();
            btnProveedorLimpiar = new Button();
            lblProveedorCodigo = new Label();
            btnProveedorModificar = new Button();
            lblProveedorDNI = new Label();
            txtProveedorEmail = new TextBox();
            lblProveedorEmail = new Label();
            txtProveedorDNI = new TextBox();
            txtProveedorCodigo = new TextBox();
            gbListaProveedores = new GroupBox();
            lvRegistroProveedor = new ListView();
            colCodProveedor = new ColumnHeader();
            colNombre = new ColumnHeader();
            colTipoDNI = new ColumnHeader();
            colIdentificacion = new ColumnHeader();
            colTelefono = new ColumnHeader();
            colEmail = new ColumnHeader();
            gbxProveedorBuscar = new GroupBox();
            lblProveedorBuscar = new Label();
            txtProveedorBuscar = new TextBox();
            btnProveedorBuscar = new Button();
            gbxDatosProveedor1 = new GroupBox();
            gbxModificacionProveedorTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroFuncionariosDatos.SuspendLayout();
            gbListaProveedores.SuspendLayout();
            gbxProveedorBuscar.SuspendLayout();
            gbxDatosProveedor1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxModificacionProveedorTitulo
            // 
            gbxModificacionProveedorTitulo.Controls.Add(pbLogo);
            gbxModificacionProveedorTitulo.Controls.Add(lblProveedorTitulo);
            gbxModificacionProveedorTitulo.Dock = DockStyle.Top;
            gbxModificacionProveedorTitulo.Location = new Point(0, 0);
            gbxModificacionProveedorTitulo.Name = "gbxModificacionProveedorTitulo";
            gbxModificacionProveedorTitulo.Size = new Size(774, 142);
            gbxModificacionProveedorTitulo.TabIndex = 1;
            gbxModificacionProveedorTitulo.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(6, 22);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(126, 96);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblProveedorTitulo
            // 
            lblProveedorTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorTitulo.Location = new Point(223, 22);
            lblProveedorTitulo.Name = "lblProveedorTitulo";
            lblProveedorTitulo.Size = new Size(253, 67);
            lblProveedorTitulo.TabIndex = 16;
            lblProveedorTitulo.Text = "Modificacion de Proveedor";
            lblProveedorTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxRegistroFuncionariosDatos
            // 
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorDNI1);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorDNI1);
            gbxRegistroFuncionariosDatos.Controls.Add(txtModificarTelefono);
            gbxRegistroFuncionariosDatos.Controls.Add(lblModificarTelefono);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorCancelar);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorLimpiar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorCodigo);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorModificar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorCodigo);
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Right;
            gbxRegistroFuncionariosDatos.Location = new Point(339, 19);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(432, 272);
            gbxRegistroFuncionariosDatos.TabIndex = 5;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Proveedores";
            // 
            // lblProveedorDNI1
            // 
            lblProveedorDNI1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorDNI1.Location = new Point(56, 136);
            lblProveedorDNI1.Name = "lblProveedorDNI1";
            lblProveedorDNI1.Size = new Size(138, 22);
            lblProveedorDNI1.TabIndex = 11;
            lblProveedorDNI1.Text = "Identificacion";
            lblProveedorDNI1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorDNI1
            // 
            txtProveedorDNI1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorDNI1.Location = new Point(200, 134);
            txtProveedorDNI1.Name = "txtProveedorDNI1";
            txtProveedorDNI1.ReadOnly = true;
            txtProveedorDNI1.Size = new Size(155, 27);
            txtProveedorDNI1.TabIndex = 9;
            txtProveedorDNI1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarTelefono.Location = new Point(200, 167);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(155, 27);
            txtModificarTelefono.TabIndex = 10;
            txtModificarTelefono.TextAlign = HorizontalAlignment.Center;
            txtModificarTelefono.KeyPress += txtModificarTelefono_KeyPress;
            // 
            // lblModificarTelefono
            // 
            lblModificarTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarTelefono.Location = new Point(56, 169);
            lblModificarTelefono.Name = "lblModificarTelefono";
            lblModificarTelefono.Size = new Size(138, 22);
            lblModificarTelefono.TabIndex = 10;
            lblModificarTelefono.Text = "Telefono";
            lblModificarTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorNombre.Location = new Point(200, 68);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(155, 27);
            txtProveedorNombre.TabIndex = 7;
            txtProveedorNombre.TextAlign = HorizontalAlignment.Center;
            txtProveedorNombre.KeyPress += txtProveedorNombre_KeyPress;
            // 
            // lblProveedorNombre
            // 
            lblProveedorNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorNombre.Location = new Point(56, 75);
            lblProveedorNombre.Name = "lblProveedorNombre";
            lblProveedorNombre.Size = new Size(138, 22);
            lblProveedorNombre.TabIndex = 0;
            lblProveedorNombre.Text = "Nombre";
            lblProveedorNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorCancelar
            // 
            btnProveedorCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorCancelar.Location = new Point(294, 235);
            btnProveedorCancelar.Name = "btnProveedorCancelar";
            btnProveedorCancelar.Size = new Size(117, 30);
            btnProveedorCancelar.TabIndex = 14;
            btnProveedorCancelar.Text = "Cancelar";
            btnProveedorCancelar.UseVisualStyleBackColor = true;
            btnProveedorCancelar.Click += btnProveedorCancelar_Click;
            // 
            // btnProveedorLimpiar
            // 
            btnProveedorLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorLimpiar.Location = new Point(151, 235);
            btnProveedorLimpiar.Name = "btnProveedorLimpiar";
            btnProveedorLimpiar.Size = new Size(117, 30);
            btnProveedorLimpiar.TabIndex = 13;
            btnProveedorLimpiar.Text = "Limpiar";
            btnProveedorLimpiar.UseVisualStyleBackColor = true;
            btnProveedorLimpiar.Click += btnProveedorLimpiar_Click;
            // 
            // lblProveedorCodigo
            // 
            lblProveedorCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorCodigo.Location = new Point(56, 37);
            lblProveedorCodigo.Name = "lblProveedorCodigo";
            lblProveedorCodigo.Size = new Size(138, 22);
            lblProveedorCodigo.TabIndex = 1;
            lblProveedorCodigo.Text = "Codigo";
            lblProveedorCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorModificar
            // 
            btnProveedorModificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorModificar.Location = new Point(13, 235);
            btnProveedorModificar.Name = "btnProveedorModificar";
            btnProveedorModificar.Size = new Size(117, 30);
            btnProveedorModificar.TabIndex = 12;
            btnProveedorModificar.Text = "Modificar";
            btnProveedorModificar.UseVisualStyleBackColor = true;
            btnProveedorModificar.Click += btnProveedorModificar_Click;
            // 
            // lblProveedorDNI
            // 
            lblProveedorDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorDNI.Location = new Point(56, 103);
            lblProveedorDNI.Name = "lblProveedorDNI";
            lblProveedorDNI.Size = new Size(138, 22);
            lblProveedorDNI.TabIndex = 3;
            lblProveedorDNI.Text = "Tipo Identificacion";
            lblProveedorDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorEmail
            // 
            txtProveedorEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorEmail.Location = new Point(200, 200);
            txtProveedorEmail.Name = "txtProveedorEmail";
            txtProveedorEmail.Size = new Size(155, 27);
            txtProveedorEmail.TabIndex = 11;
            txtProveedorEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorEmail
            // 
            lblProveedorEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorEmail.Location = new Point(56, 202);
            lblProveedorEmail.Name = "lblProveedorEmail";
            lblProveedorEmail.Size = new Size(138, 22);
            lblProveedorEmail.TabIndex = 5;
            lblProveedorEmail.Text = "Correo Electronico";
            lblProveedorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorDNI
            // 
            txtProveedorDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorDNI.Location = new Point(200, 101);
            txtProveedorDNI.Name = "txtProveedorDNI";
            txtProveedorDNI.Size = new Size(155, 27);
            txtProveedorDNI.TabIndex = 8;
            txtProveedorDNI.TextAlign = HorizontalAlignment.Center;
            txtProveedorDNI.KeyPress += txtProveedorDNI_KeyPress;
            // 
            // txtProveedorCodigo
            // 
            txtProveedorCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorCodigo.Location = new Point(200, 35);
            txtProveedorCodigo.Name = "txtProveedorCodigo";
            txtProveedorCodigo.ReadOnly = true;
            txtProveedorCodigo.Size = new Size(155, 27);
            txtProveedorCodigo.TabIndex = 6;
            txtProveedorCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // gbListaProveedores
            // 
            gbListaProveedores.Controls.Add(lvRegistroProveedor);
            gbListaProveedores.Dock = DockStyle.Bottom;
            gbListaProveedores.Location = new Point(0, 436);
            gbListaProveedores.Name = "gbListaProveedores";
            gbListaProveedores.Size = new Size(774, 225);
            gbListaProveedores.TabIndex = 15;
            gbListaProveedores.TabStop = false;
            gbListaProveedores.Text = "Lista de Provedores";
            // 
            // lvRegistroProveedor
            // 
            lvRegistroProveedor.BackColor = SystemColors.Info;
            lvRegistroProveedor.Columns.AddRange(new ColumnHeader[] { colCodProveedor, colNombre, colTipoDNI, colIdentificacion, colTelefono, colEmail });
            lvRegistroProveedor.Dock = DockStyle.Fill;
            lvRegistroProveedor.Items.AddRange(new ListViewItem[] { listViewItem3 });
            lvRegistroProveedor.Location = new Point(3, 19);
            lvRegistroProveedor.Name = "lvRegistroProveedor";
            lvRegistroProveedor.Size = new Size(768, 203);
            lvRegistroProveedor.TabIndex = 16;
            lvRegistroProveedor.UseCompatibleStateImageBehavior = false;
            lvRegistroProveedor.View = View.Details;
            lvRegistroProveedor.SelectedIndexChanged += lvRegistroProveedor_SelectedIndexChanged;
            // 
            // colCodProveedor
            // 
            colCodProveedor.Text = "Cod. Proveedor";
            colCodProveedor.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Proveedor";
            colNombre.Width = 100;
            // 
            // colTipoDNI
            // 
            colTipoDNI.Text = "Tipo Identificacion";
            colTipoDNI.Width = 120;
            // 
            // colIdentificacion
            // 
            colIdentificacion.Text = "Identificacion";
            colIdentificacion.Width = 100;
            // 
            // colTelefono
            // 
            colTelefono.Text = "Telefono";
            colTelefono.Width = 100;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 100;
            // 
            // gbxProveedorBuscar
            // 
            gbxProveedorBuscar.Controls.Add(lblProveedorBuscar);
            gbxProveedorBuscar.Controls.Add(txtProveedorBuscar);
            gbxProveedorBuscar.Controls.Add(btnProveedorBuscar);
            gbxProveedorBuscar.Dock = DockStyle.Left;
            gbxProveedorBuscar.Location = new Point(3, 19);
            gbxProveedorBuscar.Name = "gbxProveedorBuscar";
            gbxProveedorBuscar.Size = new Size(291, 272);
            gbxProveedorBuscar.TabIndex = 2;
            gbxProveedorBuscar.TabStop = false;
            gbxProveedorBuscar.Text = "Buscar Proveedor ";
            // 
            // lblProveedorBuscar
            // 
            lblProveedorBuscar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorBuscar.Location = new Point(34, 39);
            lblProveedorBuscar.Name = "lblProveedorBuscar";
            lblProveedorBuscar.Size = new Size(153, 23);
            lblProveedorBuscar.TabIndex = 9;
            lblProveedorBuscar.Text = "Buscar por Codigo";
            lblProveedorBuscar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProveedorBuscar
            // 
            txtProveedorBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorBuscar.Location = new Point(34, 74);
            txtProveedorBuscar.Name = "txtProveedorBuscar";
            txtProveedorBuscar.Size = new Size(155, 29);
            txtProveedorBuscar.TabIndex = 3;
            txtProveedorBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // btnProveedorBuscar
            // 
            btnProveedorBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorBuscar.Location = new Point(34, 126);
            btnProveedorBuscar.Name = "btnProveedorBuscar";
            btnProveedorBuscar.Size = new Size(117, 30);
            btnProveedorBuscar.TabIndex = 4;
            btnProveedorBuscar.Text = "Buscar";
            btnProveedorBuscar.UseVisualStyleBackColor = true;
            btnProveedorBuscar.Click += btnProveedorBuscar_Click;
            // 
            // gbxDatosProveedor1
            // 
            gbxDatosProveedor1.Controls.Add(gbxProveedorBuscar);
            gbxDatosProveedor1.Controls.Add(gbxRegistroFuncionariosDatos);
            gbxDatosProveedor1.Dock = DockStyle.Fill;
            gbxDatosProveedor1.Location = new Point(0, 142);
            gbxDatosProveedor1.Name = "gbxDatosProveedor1";
            gbxDatosProveedor1.Size = new Size(774, 294);
            gbxDatosProveedor1.TabIndex = 19;
            gbxDatosProveedor1.TabStop = false;
            // 
            // frmModificacionProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxDatosProveedor1);
            Controls.Add(gbListaProveedores);
            Controls.Add(gbxModificacionProveedorTitulo);
            MinimumSize = new Size(790, 700);
            Name = "frmModificacionProveedores";
            Text = "Modificacion de Proveedores";
            Load += frmModificacionProveedores_Load;
            gbxModificacionProveedorTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroFuncionariosDatos.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.PerformLayout();
            gbListaProveedores.ResumeLayout(false);
            gbxProveedorBuscar.ResumeLayout(false);
            gbxProveedorBuscar.PerformLayout();
            gbxDatosProveedor1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxModificacionProveedorTitulo;
        private PictureBox pbLogo;
        private Label lblProveedorTitulo;
        private GroupBox gbxRegistroFuncionariosDatos;
        private TextBox txtProveedorNombre;
        private Label lblProveedorNombre;
        private Button btnProveedorCancelar;
        private Button btnProveedorLimpiar;
        private Label lblProveedorCodigo;
        private Button btnProveedorModificar;
        private Label lblProveedorDNI;
        private TextBox txtProveedorEmail;
        private Label lblProveedorEmail;
        private TextBox txtProveedorDNI;
        private TextBox txtProveedorCodigo;
        private GroupBox gbListaProveedores;
        private GroupBox gbxProveedorBuscar;
        private Label lblProveedorBuscar;
        private TextBox txtProveedorBuscar;
        private Button btnProveedorBuscar;
        private GroupBox gbxDatosProveedor1;
        private ListView lvRegistroProveedor;
        private ColumnHeader colCodProveedor;
        private ColumnHeader colNombre;
        private ColumnHeader colTipoDNI;
        private ColumnHeader colIdentificacion;
        private ColumnHeader colTelefono;
        private ColumnHeader colEmail;
        private TextBox txtModificarTelefono;
        private Label lblModificarTelefono;
        private Label lblProveedorDNI1;
        private TextBox txtProveedorDNI1;
    }
}