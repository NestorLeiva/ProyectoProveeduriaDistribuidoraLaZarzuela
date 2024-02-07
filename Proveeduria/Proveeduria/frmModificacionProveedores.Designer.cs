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
            gbxModificacionProveedorTitulo = new GroupBox();
            pbLogo = new PictureBox();
            lblProveedorTitulo = new Label();
            gbxRegistroFuncionariosDatos = new GroupBox();
            txtProveedorNombre = new TextBox();
            lblProveedorNombre = new Label();
            btnProveedorCancelar = new Button();
            btnProveedorLimpiar = new Button();
            lblProveedorCodigo = new Label();
            btnProveedorAceptar = new Button();
            lblProveedorDNI = new Label();
            txtProveedorEmail = new TextBox();
            lblProveedorEmail = new Label();
            txtProveedorDNI = new TextBox();
            txtProveedorCodigo = new TextBox();
            gbListaProveedores = new GroupBox();
            dgvRegistroListaProveedores = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colIdentificacion = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colCorreoElectronico = new DataGridViewTextBoxColumn();
            gbxProveedorBuscar = new GroupBox();
            gbxDatosProveedor1 = new GroupBox();
            btnProveedorBuscar = new Button();
            txtProveedorBuscar = new TextBox();
            label1 = new Label();
            gbxModificacionProveedorTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroFuncionariosDatos.SuspendLayout();
            gbListaProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaProveedores).BeginInit();
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
            gbxModificacionProveedorTitulo.Size = new Size(774, 159);
            gbxModificacionProveedorTitulo.TabIndex = 1;
            gbxModificacionProveedorTitulo.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(6, 22);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(159, 125);
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
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorCancelar);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorLimpiar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorCodigo);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorAceptar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorCodigo);
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Right;
            gbxRegistroFuncionariosDatos.Location = new Point(339, 19);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(432, 255);
            gbxRegistroFuncionariosDatos.TabIndex = 2;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Proveedores";
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorNombre.Location = new Point(200, 39);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(155, 29);
            txtProveedorNombre.TabIndex = 2;
            txtProveedorNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorNombre
            // 
            lblProveedorNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorNombre.Location = new Point(56, 46);
            lblProveedorNombre.Name = "lblProveedorNombre";
            lblProveedorNombre.Size = new Size(138, 22);
            lblProveedorNombre.TabIndex = 0;
            lblProveedorNombre.Text = "Nombre";
            lblProveedorNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorCancelar
            // 
            btnProveedorCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorCancelar.Location = new Point(294, 198);
            btnProveedorCancelar.Name = "btnProveedorCancelar";
            btnProveedorCancelar.Size = new Size(117, 30);
            btnProveedorCancelar.TabIndex = 8;
            btnProveedorCancelar.Text = "Cancelar";
            btnProveedorCancelar.UseVisualStyleBackColor = true;
            // 
            // btnProveedorLimpiar
            // 
            btnProveedorLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorLimpiar.Location = new Point(151, 198);
            btnProveedorLimpiar.Name = "btnProveedorLimpiar";
            btnProveedorLimpiar.Size = new Size(117, 30);
            btnProveedorLimpiar.TabIndex = 7;
            btnProveedorLimpiar.Text = "Limpiar";
            btnProveedorLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblProveedorCodigo
            // 
            lblProveedorCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorCodigo.Location = new Point(56, 111);
            lblProveedorCodigo.Name = "lblProveedorCodigo";
            lblProveedorCodigo.Size = new Size(138, 22);
            lblProveedorCodigo.TabIndex = 1;
            lblProveedorCodigo.Text = "Codigo";
            lblProveedorCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorAceptar
            // 
            btnProveedorAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorAceptar.Location = new Point(13, 198);
            btnProveedorAceptar.Name = "btnProveedorAceptar";
            btnProveedorAceptar.Size = new Size(117, 30);
            btnProveedorAceptar.TabIndex = 6;
            btnProveedorAceptar.Text = "Aceptar";
            btnProveedorAceptar.UseVisualStyleBackColor = true;
            // 
            // lblProveedorDNI
            // 
            lblProveedorDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorDNI.Location = new Point(56, 76);
            lblProveedorDNI.Name = "lblProveedorDNI";
            lblProveedorDNI.Size = new Size(138, 22);
            lblProveedorDNI.TabIndex = 3;
            lblProveedorDNI.Text = "Identificacion";
            lblProveedorDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorEmail
            // 
            txtProveedorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorEmail.Location = new Point(200, 144);
            txtProveedorEmail.Name = "txtProveedorEmail";
            txtProveedorEmail.Size = new Size(155, 29);
            txtProveedorEmail.TabIndex = 5;
            txtProveedorEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorEmail
            // 
            lblProveedorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorEmail.Location = new Point(56, 146);
            lblProveedorEmail.Name = "lblProveedorEmail";
            lblProveedorEmail.Size = new Size(138, 22);
            lblProveedorEmail.TabIndex = 5;
            lblProveedorEmail.Text = "Correo Electronico";
            lblProveedorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorDNI
            // 
            txtProveedorDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorDNI.Location = new Point(200, 74);
            txtProveedorDNI.Name = "txtProveedorDNI";
            txtProveedorDNI.Size = new Size(155, 29);
            txtProveedorDNI.TabIndex = 3;
            txtProveedorDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProveedorCodigo
            // 
            txtProveedorCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorCodigo.Location = new Point(200, 109);
            txtProveedorCodigo.Name = "txtProveedorCodigo";
            txtProveedorCodigo.ReadOnly = true;
            txtProveedorCodigo.Size = new Size(155, 29);
            txtProveedorCodigo.TabIndex = 4;
            txtProveedorCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // gbListaProveedores
            // 
            gbListaProveedores.Controls.Add(dgvRegistroListaProveedores);
            gbListaProveedores.Dock = DockStyle.Bottom;
            gbListaProveedores.Location = new Point(0, 436);
            gbListaProveedores.Name = "gbListaProveedores";
            gbListaProveedores.Size = new Size(774, 225);
            gbListaProveedores.TabIndex = 4;
            gbListaProveedores.TabStop = false;
            gbListaProveedores.Text = "Lista de Provedores";
            // 
            // dgvRegistroListaProveedores
            // 
            dgvRegistroListaProveedores.AllowUserToDeleteRows = false;
            dgvRegistroListaProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRegistroListaProveedores.Columns.AddRange(new DataGridViewColumn[] { colNombre, colIdentificacion, colCodigo, colCorreoElectronico });
            dgvRegistroListaProveedores.Dock = DockStyle.Fill;
            dgvRegistroListaProveedores.Location = new Point(3, 19);
            dgvRegistroListaProveedores.Name = "dgvRegistroListaProveedores";
            dgvRegistroListaProveedores.RowTemplate.Height = 25;
            dgvRegistroListaProveedores.Size = new Size(768, 203);
            dgvRegistroListaProveedores.TabIndex = 8;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colIdentificacion
            // 
            colIdentificacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colIdentificacion.HeaderText = "Identificacion";
            colIdentificacion.Name = "colIdentificacion";
            // 
            // colCodigo
            // 
            colCodigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            // 
            // colCorreoElectronico
            // 
            colCorreoElectronico.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCorreoElectronico.HeaderText = "Correo Electronico";
            colCorreoElectronico.Name = "colCorreoElectronico";
            colCorreoElectronico.ReadOnly = true;
            // 
            // gbxProveedorBuscar
            // 
            gbxProveedorBuscar.Controls.Add(label1);
            gbxProveedorBuscar.Controls.Add(txtProveedorBuscar);
            gbxProveedorBuscar.Controls.Add(btnProveedorBuscar);
            gbxProveedorBuscar.Dock = DockStyle.Left;
            gbxProveedorBuscar.Location = new Point(3, 19);
            gbxProveedorBuscar.Name = "gbxProveedorBuscar";
            gbxProveedorBuscar.Size = new Size(291, 255);
            gbxProveedorBuscar.TabIndex = 18;
            gbxProveedorBuscar.TabStop = false;
            gbxProveedorBuscar.Text = "Buscar Proveedor ";
            // 
            // gbxDatosProveedor1
            // 
            gbxDatosProveedor1.Controls.Add(gbxProveedorBuscar);
            gbxDatosProveedor1.Controls.Add(gbxRegistroFuncionariosDatos);
            gbxDatosProveedor1.Dock = DockStyle.Fill;
            gbxDatosProveedor1.Location = new Point(0, 159);
            gbxDatosProveedor1.Name = "gbxDatosProveedor1";
            gbxDatosProveedor1.Size = new Size(774, 277);
            gbxDatosProveedor1.TabIndex = 19;
            gbxDatosProveedor1.TabStop = false;
            // 
            // btnProveedorBuscar
            // 
            btnProveedorBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorBuscar.Location = new Point(34, 126);
            btnProveedorBuscar.Name = "btnProveedorBuscar";
            btnProveedorBuscar.Size = new Size(117, 30);
            btnProveedorBuscar.TabIndex = 7;
            btnProveedorBuscar.Text = "Buscar";
            btnProveedorBuscar.UseVisualStyleBackColor = true;
            // 
            // txtProveedorBuscar
            // 
            txtProveedorBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorBuscar.Location = new Point(34, 74);
            txtProveedorBuscar.Name = "txtProveedorBuscar";
            txtProveedorBuscar.Size = new Size(155, 29);
            txtProveedorBuscar.TabIndex = 8;
            txtProveedorBuscar.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 9;
            label1.Text = "Buscar por Nombre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
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
            gbxModificacionProveedorTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroFuncionariosDatos.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.PerformLayout();
            gbListaProveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaProveedores).EndInit();
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
        private Button btnProveedorAceptar;
        private Label lblProveedorDNI;
        private TextBox txtProveedorEmail;
        private Label lblProveedorEmail;
        private TextBox txtProveedorDNI;
        private TextBox txtProveedorCodigo;
        private GroupBox gbListaProveedores;
        private DataGridView dgvRegistroListaProveedores;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colIdentificacion;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colCorreoElectronico;
        private GroupBox gbxProveedorBuscar;
        private Label label1;
        private TextBox txtProveedorBuscar;
        private Button btnProveedorBuscar;
        private GroupBox gbxDatosProveedor1;
    }
}