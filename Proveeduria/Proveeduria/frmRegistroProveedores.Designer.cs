namespace Proveeduria
{
    partial class frmRegistroProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroProveedores));
            gbxRegistroFuncionariosTitulo = new GroupBox();
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
            dgvRegistroListaProveedores = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colIdentificacion = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            colCorreoElectronico = new DataGridViewTextBoxColumn();
            gbListaProveedores = new GroupBox();
            gbxRegistroFuncionariosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroFuncionariosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaProveedores).BeginInit();
            gbListaProveedores.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRegistroFuncionariosTitulo
            // 
            gbxRegistroFuncionariosTitulo.Controls.Add(pbLogo);
            gbxRegistroFuncionariosTitulo.Controls.Add(lblProveedorTitulo);
            gbxRegistroFuncionariosTitulo.Dock = DockStyle.Top;
            gbxRegistroFuncionariosTitulo.Location = new Point(0, 0);
            gbxRegistroFuncionariosTitulo.Name = "gbxRegistroFuncionariosTitulo";
            gbxRegistroFuncionariosTitulo.Size = new Size(594, 159);
            gbxRegistroFuncionariosTitulo.TabIndex = 1;
            gbxRegistroFuncionariosTitulo.TabStop = false;
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
            lblProveedorTitulo.Location = new Point(218, 51);
            lblProveedorTitulo.Name = "lblProveedorTitulo";
            lblProveedorTitulo.Size = new Size(253, 31);
            lblProveedorTitulo.TabIndex = 16;
            lblProveedorTitulo.Text = "Registro de Proveedor";
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
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Fill;
            gbxRegistroFuncionariosDatos.Location = new Point(0, 159);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(594, 502);
            gbxRegistroFuncionariosDatos.TabIndex = 2;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Proveedores";
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorNombre.Location = new Point(273, 70);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(211, 29);
            txtProveedorNombre.TabIndex = 1;
            txtProveedorNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorNombre
            // 
            lblProveedorNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorNombre.Location = new Point(99, 77);
            lblProveedorNombre.Name = "lblProveedorNombre";
            lblProveedorNombre.Size = new Size(168, 22);
            lblProveedorNombre.TabIndex = 0;
            lblProveedorNombre.Text = "Nombre";
            lblProveedorNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorCancelar
            // 
            btnProveedorCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorCancelar.Location = new Point(367, 229);
            btnProveedorCancelar.Name = "btnProveedorCancelar";
            btnProveedorCancelar.Size = new Size(117, 30);
            btnProveedorCancelar.TabIndex = 7;
            btnProveedorCancelar.Text = "Cancelar";
            btnProveedorCancelar.UseVisualStyleBackColor = true;
            // 
            // btnProveedorLimpiar
            // 
            btnProveedorLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorLimpiar.Location = new Point(224, 229);
            btnProveedorLimpiar.Name = "btnProveedorLimpiar";
            btnProveedorLimpiar.Size = new Size(117, 30);
            btnProveedorLimpiar.TabIndex = 6;
            btnProveedorLimpiar.Text = "Limpiar";
            btnProveedorLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblProveedorCodigo
            // 
            lblProveedorCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorCodigo.Location = new Point(99, 142);
            lblProveedorCodigo.Name = "lblProveedorCodigo";
            lblProveedorCodigo.Size = new Size(168, 22);
            lblProveedorCodigo.TabIndex = 1;
            lblProveedorCodigo.Text = "Codigo";
            lblProveedorCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorAceptar
            // 
            btnProveedorAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorAceptar.Location = new Point(86, 229);
            btnProveedorAceptar.Name = "btnProveedorAceptar";
            btnProveedorAceptar.Size = new Size(117, 30);
            btnProveedorAceptar.TabIndex = 5;
            btnProveedorAceptar.Text = "Aceptar";
            btnProveedorAceptar.UseVisualStyleBackColor = true;
            // 
            // lblProveedorDNI
            // 
            lblProveedorDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorDNI.Location = new Point(99, 107);
            lblProveedorDNI.Name = "lblProveedorDNI";
            lblProveedorDNI.Size = new Size(168, 22);
            lblProveedorDNI.TabIndex = 3;
            lblProveedorDNI.Text = "Identificacion";
            lblProveedorDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorEmail
            // 
            txtProveedorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorEmail.Location = new Point(273, 175);
            txtProveedorEmail.Name = "txtProveedorEmail";
            txtProveedorEmail.Size = new Size(211, 29);
            txtProveedorEmail.TabIndex = 4;
            txtProveedorEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorEmail
            // 
            lblProveedorEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorEmail.Location = new Point(99, 177);
            lblProveedorEmail.Name = "lblProveedorEmail";
            lblProveedorEmail.Size = new Size(168, 22);
            lblProveedorEmail.TabIndex = 5;
            lblProveedorEmail.Text = "Correo Electronico";
            lblProveedorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorDNI
            // 
            txtProveedorDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorDNI.Location = new Point(273, 105);
            txtProveedorDNI.Name = "txtProveedorDNI";
            txtProveedorDNI.Size = new Size(211, 29);
            txtProveedorDNI.TabIndex = 2;
            txtProveedorDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProveedorCodigo
            // 
            txtProveedorCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorCodigo.Location = new Point(273, 140);
            txtProveedorCodigo.Name = "txtProveedorCodigo";
            txtProveedorCodigo.Size = new Size(211, 29);
            txtProveedorCodigo.TabIndex = 3;
            txtProveedorCodigo.TextAlign = HorizontalAlignment.Center;
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
            dgvRegistroListaProveedores.Size = new Size(588, 203);
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
            // gbListaProveedores
            // 
            gbListaProveedores.Controls.Add(dgvRegistroListaProveedores);
            gbListaProveedores.Dock = DockStyle.Bottom;
            gbListaProveedores.Location = new Point(0, 436);
            gbListaProveedores.Name = "gbListaProveedores";
            gbListaProveedores.Size = new Size(594, 225);
            gbListaProveedores.TabIndex = 3;
            gbListaProveedores.TabStop = false;
            gbListaProveedores.Text = "Lista de Provedores";
            // 
            // frmRegistroProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 661);
            Controls.Add(gbListaProveedores);
            Controls.Add(gbxRegistroFuncionariosDatos);
            Controls.Add(gbxRegistroFuncionariosTitulo);
            MinimumSize = new Size(610, 700);
            Name = "frmRegistroProveedores";
            Text = "Registro Proveedores";
            gbxRegistroFuncionariosTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroFuncionariosDatos.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaProveedores).EndInit();
            gbListaProveedores.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxRegistroFuncionariosTitulo;
        private PictureBox pbLogo;
        private Label lblProveedorTitulo;
        private GroupBox gbxRegistroFuncionariosDatos;
        private Label lblProveedorNombre;
        private Button btnProveedorCancelar;
        private Button btnProveedorLimpiar;
        private Label lblProveedorCodigo;
        private Button btnProveedorAceptar;
        private TextBox txtProveedorCodigo;
        private DataGridView dgvRegistroListaProveedores;
        private GroupBox gbListaProveedores;
        private TextBox txtProveedorNombre;
        private Label lblProveedorDNI;
        private TextBox txtProveedorEmail;
        private Label lblProveedorEmail;
        private TextBox txtProveedorDNI;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colIdentificacion;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colCorreoElectronico;
    }
}