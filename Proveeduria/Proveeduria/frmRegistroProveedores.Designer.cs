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
            ListViewItem listViewItem2 = new ListViewItem("");
            gbxRegistroFuncionariosTitulo = new GroupBox();
            pbLogo = new PictureBox();
            lblProveedorTitulo = new Label();
            gbxRegistroFuncionariosDatos = new GroupBox();
            rbtnDniNacional = new RadioButton();
            lblProveedorTipoDNI = new Label();
            rbtnDniJuridico = new RadioButton();
            txtProveedorNombre = new TextBox();
            lblProveedorNombre = new Label();
            btnProveedorCancelar = new Button();
            btnProveedorLimpiar = new Button();
            lblProveedorTelefono = new Label();
            btnProveedorAceptar = new Button();
            lblProveedorDNI = new Label();
            txtProveedorEmail = new TextBox();
            lblProveedorEmail = new Label();
            txtProveedorDNI = new TextBox();
            txtProveedorTelefono = new TextBox();
            gbListaProveedores = new GroupBox();
            lvRegistroProveedor = new ListView();
            colCodProveedor = new ColumnHeader();
            colNombre = new ColumnHeader();
            colTipoDNI = new ColumnHeader();
            colIdentificacion = new ColumnHeader();
            colTelefono = new ColumnHeader();
            colEmail = new ColumnHeader();
            gbxRegistroFuncionariosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroFuncionariosDatos.SuspendLayout();
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
            gbxRegistroFuncionariosDatos.Controls.Add(rbtnDniNacional);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorTipoDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(rbtnDniJuridico);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorCancelar);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorLimpiar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorTelefono);
            gbxRegistroFuncionariosDatos.Controls.Add(btnProveedorAceptar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(lblProveedorEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtProveedorTelefono);
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Fill;
            gbxRegistroFuncionariosDatos.Location = new Point(0, 159);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(594, 525);
            gbxRegistroFuncionariosDatos.TabIndex = 2;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Proveedores";
            // 
            // rbtnDniNacional
            // 
            rbtnDniNacional.AutoSize = true;
            rbtnDniNacional.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDniNacional.Location = new Point(367, 39);
            rbtnDniNacional.Name = "rbtnDniNacional";
            rbtnDniNacional.Size = new Size(84, 22);
            rbtnDniNacional.TabIndex = 10;
            rbtnDniNacional.TabStop = true;
            rbtnDniNacional.Text = "Nacional";
            rbtnDniNacional.UseVisualStyleBackColor = true;
            // 
            // lblProveedorTipoDNI
            // 
            lblProveedorTipoDNI.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorTipoDNI.Location = new Point(99, 41);
            lblProveedorTipoDNI.Name = "lblProveedorTipoDNI";
            lblProveedorTipoDNI.Size = new Size(168, 22);
            lblProveedorTipoDNI.TabIndex = 9;
            lblProveedorTipoDNI.Text = "Tipo de Identificacion";
            lblProveedorTipoDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtnDniJuridico
            // 
            rbtnDniJuridico.AutoSize = true;
            rbtnDniJuridico.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnDniJuridico.Location = new Point(273, 39);
            rbtnDniJuridico.Name = "rbtnDniJuridico";
            rbtnDniJuridico.Size = new Size(78, 22);
            rbtnDniJuridico.TabIndex = 8;
            rbtnDniJuridico.TabStop = true;
            rbtnDniJuridico.Text = "Juridico";
            rbtnDniJuridico.UseVisualStyleBackColor = true;
            // 
            // txtProveedorNombre
            // 
            txtProveedorNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorNombre.Location = new Point(273, 70);
            txtProveedorNombre.Name = "txtProveedorNombre";
            txtProveedorNombre.Size = new Size(211, 24);
            txtProveedorNombre.TabIndex = 1;
            txtProveedorNombre.TextAlign = HorizontalAlignment.Center;
            txtProveedorNombre.KeyPress += txtProveedorNombre_KeyPress;
            // 
            // lblProveedorNombre
            // 
            lblProveedorNombre.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorNombre.Location = new Point(99, 77);
            lblProveedorNombre.Name = "lblProveedorNombre";
            lblProveedorNombre.Size = new Size(168, 22);
            lblProveedorNombre.TabIndex = 0;
            lblProveedorNombre.Text = "Nombre";
            lblProveedorNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorCancelar
            // 
            btnProveedorCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorCancelar.Location = new Point(406, 229);
            btnProveedorCancelar.Name = "btnProveedorCancelar";
            btnProveedorCancelar.Size = new Size(78, 30);
            btnProveedorCancelar.TabIndex = 7;
            btnProveedorCancelar.Text = "Cancelar";
            btnProveedorCancelar.UseVisualStyleBackColor = true;
            btnProveedorCancelar.Click += btnProveedorCancelar_Click;
            // 
            // btnProveedorLimpiar
            // 
            btnProveedorLimpiar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorLimpiar.Location = new Point(263, 229);
            btnProveedorLimpiar.Name = "btnProveedorLimpiar";
            btnProveedorLimpiar.Size = new Size(78, 30);
            btnProveedorLimpiar.TabIndex = 6;
            btnProveedorLimpiar.Text = "Limpiar";
            btnProveedorLimpiar.UseVisualStyleBackColor = true;
            btnProveedorLimpiar.Click += btnProveedorLimpiar_Click;
            // 
            // lblProveedorTelefono
            // 
            lblProveedorTelefono.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorTelefono.Location = new Point(99, 142);
            lblProveedorTelefono.Name = "lblProveedorTelefono";
            lblProveedorTelefono.Size = new Size(168, 22);
            lblProveedorTelefono.TabIndex = 1;
            lblProveedorTelefono.Text = "Telefono";
            lblProveedorTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProveedorAceptar
            // 
            btnProveedorAceptar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProveedorAceptar.Location = new Point(125, 229);
            btnProveedorAceptar.Name = "btnProveedorAceptar";
            btnProveedorAceptar.Size = new Size(78, 30);
            btnProveedorAceptar.TabIndex = 5;
            btnProveedorAceptar.Text = "Aceptar";
            btnProveedorAceptar.UseVisualStyleBackColor = true;
            btnProveedorAceptar.Click += btnProveedorAceptar_Click;
            // 
            // lblProveedorDNI
            // 
            lblProveedorDNI.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorDNI.Location = new Point(99, 107);
            lblProveedorDNI.Name = "lblProveedorDNI";
            lblProveedorDNI.Size = new Size(168, 22);
            lblProveedorDNI.TabIndex = 3;
            lblProveedorDNI.Text = "Identificacion";
            lblProveedorDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorEmail
            // 
            txtProveedorEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorEmail.Location = new Point(273, 175);
            txtProveedorEmail.Name = "txtProveedorEmail";
            txtProveedorEmail.Size = new Size(211, 24);
            txtProveedorEmail.TabIndex = 4;
            txtProveedorEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblProveedorEmail
            // 
            lblProveedorEmail.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProveedorEmail.Location = new Point(99, 177);
            lblProveedorEmail.Name = "lblProveedorEmail";
            lblProveedorEmail.Size = new Size(168, 22);
            lblProveedorEmail.TabIndex = 5;
            lblProveedorEmail.Text = "Correo Electronico";
            lblProveedorEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtProveedorDNI
            // 
            txtProveedorDNI.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorDNI.Location = new Point(273, 105);
            txtProveedorDNI.MaxLength = 11;
            txtProveedorDNI.Name = "txtProveedorDNI";
            txtProveedorDNI.Size = new Size(211, 24);
            txtProveedorDNI.TabIndex = 2;
            txtProveedorDNI.TextAlign = HorizontalAlignment.Center;
            txtProveedorDNI.KeyPress += txtProveedorDNI_KeyPress;
            // 
            // txtProveedorTelefono
            // 
            txtProveedorTelefono.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtProveedorTelefono.Location = new Point(273, 140);
            txtProveedorTelefono.MaxLength = 7;
            txtProveedorTelefono.Name = "txtProveedorTelefono";
            txtProveedorTelefono.Size = new Size(211, 24);
            txtProveedorTelefono.TabIndex = 3;
            txtProveedorTelefono.TextAlign = HorizontalAlignment.Center;
            txtProveedorTelefono.KeyPress += txtProveedorTelefono_KeyPress;
            // 
            // gbListaProveedores
            // 
            gbListaProveedores.Controls.Add(lvRegistroProveedor);
            gbListaProveedores.Dock = DockStyle.Bottom;
            gbListaProveedores.Location = new Point(0, 459);
            gbListaProveedores.Name = "gbListaProveedores";
            gbListaProveedores.Size = new Size(594, 225);
            gbListaProveedores.TabIndex = 3;
            gbListaProveedores.TabStop = false;
            gbListaProveedores.Text = "Lista de Provedores";
            // 
            // lvRegistroProveedor
            // 
            lvRegistroProveedor.BackColor = SystemColors.Info;
            lvRegistroProveedor.Columns.AddRange(new ColumnHeader[] { colCodProveedor, colNombre, colTipoDNI, colIdentificacion, colTelefono, colEmail });
            lvRegistroProveedor.Dock = DockStyle.Fill;
            lvRegistroProveedor.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lvRegistroProveedor.Location = new Point(3, 19);
            lvRegistroProveedor.Name = "lvRegistroProveedor";
            lvRegistroProveedor.Size = new Size(588, 203);
            lvRegistroProveedor.TabIndex = 0;
            lvRegistroProveedor.UseCompatibleStateImageBehavior = false;
            lvRegistroProveedor.View = View.Details;
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
            // frmRegistroProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 684);
            ControlBox = false;
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
        private Label lblProveedorTelefono;
        private Button btnProveedorAceptar;
        private TextBox txtProveedorTelefono;
        private GroupBox gbListaProveedores;
        private TextBox txtProveedorNombre;
        private Label lblProveedorDNI;
        private TextBox txtProveedorEmail;
        private Label lblProveedorEmail;
        private TextBox txtProveedorDNI;
        private ListView lvRegistroProveedor;
        private ColumnHeader colCodProveedor;
        private ColumnHeader colNombre;
        private ColumnHeader colTipoDNI;
        private ColumnHeader colIdentificacion;
        private ColumnHeader colTelefono;
        private ColumnHeader colEmail;
        private RadioButton rbtnDniNacional;
        private Label lblProveedorTipoDNI;
        private RadioButton rbtnDniJuridico;
    }
}