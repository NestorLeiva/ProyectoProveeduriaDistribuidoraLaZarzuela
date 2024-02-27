namespace Proveeduria
{
    partial class frmRegistroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroClientes));
            gbxClienteRegistro = new GroupBox();
            pbLogo = new PictureBox();
            lblClienteTitulo = new Label();
            gbxClienteLista = new GroupBox();
            lvwRegistroClientes = new ListView();
            colTipoIdentificacion = new ColumnHeader();
            colNumIdentificacion = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellidoPrimero = new ColumnHeader();
            colApellidoSegundo = new ColumnHeader();
            colCodigo = new ColumnHeader();
            colTelefono = new ColumnHeader();
            colEmail = new ColumnHeader();
            colProvinvia = new ColumnHeader();
            colCanton = new ColumnHeader();
            colDistrito = new ColumnHeader();
            colOtrasSenias = new ColumnHeader();
            gbxClienteDireccion = new GroupBox();
            lblClienteProvincia = new Label();
            cbxClienteProvincia = new ComboBox();
            lblClienteCanton = new Label();
            txtClienteOtrasSenias = new TextBox();
            lblClienteDistrito = new Label();
            btnClienteCancelar = new Button();
            txtClienteDistrito = new TextBox();
            btnClienteLimpiar = new Button();
            lblClienteOtrasSenias = new Label();
            txtClienteCanton = new TextBox();
            btnClienteAceptar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtClienteApellidoSegundo = new TextBox();
            txtClienteApellidoPrimero = new TextBox();
            txtClienteDNI = new TextBox();
            lblClienteEmail = new Label();
            txtClienteEmail = new TextBox();
            lblClienteDNI = new Label();
            lblClienteApellidoSegundo = new Label();
            lblClienteApellidoPrimero = new Label();
            lblClienteNombre = new Label();
            txtClienteNombre = new TextBox();
            lblClienteTipoDNI = new Label();
            cbxClienteTipoDNI = new ComboBox();
            lblClienteTelefono = new Label();
            txtClienteTelefono = new TextBox();
            gbxClientesRegistrarDatos = new GroupBox();
            gbxClienteRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxClienteLista.SuspendLayout();
            gbxClienteDireccion.SuspendLayout();
            gbxClientesRegistrarDatos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxClienteRegistro
            // 
            gbxClienteRegistro.Controls.Add(pbLogo);
            gbxClienteRegistro.Controls.Add(lblClienteTitulo);
            gbxClienteRegistro.Dock = DockStyle.Top;
            gbxClienteRegistro.Location = new Point(0, 0);
            gbxClienteRegistro.Name = "gbxClienteRegistro";
            gbxClienteRegistro.Size = new Size(774, 159);
            gbxClienteRegistro.TabIndex = 1;
            gbxClienteRegistro.TabStop = false;
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
            // lblClienteTitulo
            // 
            lblClienteTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTitulo.Location = new Point(218, 51);
            lblClienteTitulo.Name = "lblClienteTitulo";
            lblClienteTitulo.Size = new Size(287, 59);
            lblClienteTitulo.TabIndex = 16;
            lblClienteTitulo.Text = "Registro de Clientes";
            lblClienteTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxClienteLista
            // 
            gbxClienteLista.Controls.Add(lvwRegistroClientes);
            gbxClienteLista.Dock = DockStyle.Bottom;
            gbxClienteLista.Location = new Point(0, 445);
            gbxClienteLista.Name = "gbxClienteLista";
            gbxClienteLista.Size = new Size(774, 216);
            gbxClienteLista.TabIndex = 19;
            gbxClienteLista.TabStop = false;
            gbxClienteLista.Text = "Lista de Clientes";
            // 
            // lvwRegistroClientes
            // 
            lvwRegistroClientes.BackColor = SystemColors.Info;
            lvwRegistroClientes.Columns.AddRange(new ColumnHeader[] { colTipoIdentificacion, colNumIdentificacion, colNombre, colApellidoPrimero, colApellidoSegundo, colCodigo, colTelefono, colEmail, colProvinvia, colCanton, colDistrito, colOtrasSenias });
            lvwRegistroClientes.Dock = DockStyle.Fill;
            lvwRegistroClientes.Location = new Point(3, 19);
            lvwRegistroClientes.Name = "lvwRegistroClientes";
            lvwRegistroClientes.Size = new Size(768, 194);
            lvwRegistroClientes.TabIndex = 20;
            lvwRegistroClientes.UseCompatibleStateImageBehavior = false;
            lvwRegistroClientes.View = View.Details;
            // 
            // colTipoIdentificacion
            // 
            colTipoIdentificacion.Text = "Tipo Identificacion";
            colTipoIdentificacion.Width = 120;
            // 
            // colNumIdentificacion
            // 
            colNumIdentificacion.Text = "Identificacion";
            colNumIdentificacion.Width = 120;
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
            colApellidoSegundo.Text = "SegundoApellido";
            colApellidoSegundo.Width = 120;
            // 
            // colCodigo
            // 
            colCodigo.Text = "Codigo";
            colCodigo.Width = 120;
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
            // colProvinvia
            // 
            colProvinvia.Text = "Provincia";
            colProvinvia.Width = 120;
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
            // gbxClienteDireccion
            // 
            gbxClienteDireccion.Controls.Add(lblClienteProvincia);
            gbxClienteDireccion.Controls.Add(cbxClienteProvincia);
            gbxClienteDireccion.Controls.Add(lblClienteCanton);
            gbxClienteDireccion.Controls.Add(txtClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(lblClienteDistrito);
            gbxClienteDireccion.Controls.Add(btnClienteCancelar);
            gbxClienteDireccion.Controls.Add(txtClienteDistrito);
            gbxClienteDireccion.Controls.Add(btnClienteLimpiar);
            gbxClienteDireccion.Controls.Add(lblClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(txtClienteCanton);
            gbxClienteDireccion.Controls.Add(btnClienteAceptar);
            gbxClienteDireccion.Dock = DockStyle.Right;
            gbxClienteDireccion.Location = new Point(401, 159);
            gbxClienteDireccion.Name = "gbxClienteDireccion";
            gbxClienteDireccion.Size = new Size(373, 286);
            gbxClienteDireccion.TabIndex = 10;
            gbxClienteDireccion.TabStop = false;
            gbxClienteDireccion.Text = "Datos Direccion";
            // 
            // lblClienteProvincia
            // 
            lblClienteProvincia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteProvincia.Location = new Point(15, 46);
            lblClienteProvincia.Name = "lblClienteProvincia";
            lblClienteProvincia.Size = new Size(89, 22);
            lblClienteProvincia.TabIndex = 14;
            lblClienteProvincia.Text = "Provincia";
            lblClienteProvincia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxClienteProvincia
            // 
            cbxClienteProvincia.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxClienteProvincia.FormattingEnabled = true;
            cbxClienteProvincia.Items.AddRange(new object[] { "SAN JOSE", "ALAJUELA", "CARTAGO", "HEREDIA", "GUANACASTE", "PUNTARENAS", "LIMON" });
            cbxClienteProvincia.Location = new Point(110, 46);
            cbxClienteProvincia.Name = "cbxClienteProvincia";
            cbxClienteProvincia.Size = new Size(229, 24);
            cbxClienteProvincia.TabIndex = 11;
            // 
            // lblClienteCanton
            // 
            lblClienteCanton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteCanton.Location = new Point(15, 74);
            lblClienteCanton.Name = "lblClienteCanton";
            lblClienteCanton.Size = new Size(89, 22);
            lblClienteCanton.TabIndex = 15;
            lblClienteCanton.Text = "Canton";
            lblClienteCanton.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteOtrasSenias
            // 
            txtClienteOtrasSenias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteOtrasSenias.Location = new Point(110, 132);
            txtClienteOtrasSenias.Name = "txtClienteOtrasSenias";
            txtClienteOtrasSenias.Size = new Size(229, 22);
            txtClienteOtrasSenias.TabIndex = 14;
            txtClienteOtrasSenias.TextAlign = HorizontalAlignment.Center;
            txtClienteOtrasSenias.KeyPress += txtClienteOtrasSenias_KeyPress;
            // 
            // lblClienteDistrito
            // 
            lblClienteDistrito.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteDistrito.Location = new Point(15, 102);
            lblClienteDistrito.Name = "lblClienteDistrito";
            lblClienteDistrito.Size = new Size(89, 22);
            lblClienteDistrito.TabIndex = 16;
            lblClienteDistrito.Text = "Distrito";
            lblClienteDistrito.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClienteCancelar
            // 
            btnClienteCancelar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteCancelar.Location = new Point(238, 216);
            btnClienteCancelar.Name = "btnClienteCancelar";
            btnClienteCancelar.Size = new Size(86, 25);
            btnClienteCancelar.TabIndex = 18;
            btnClienteCancelar.Text = "Cancelar";
            btnClienteCancelar.UseVisualStyleBackColor = true;
            btnClienteCancelar.Click += btnClienteCancelar_Click;
            // 
            // txtClienteDistrito
            // 
            txtClienteDistrito.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDistrito.Location = new Point(110, 104);
            txtClienteDistrito.Name = "txtClienteDistrito";
            txtClienteDistrito.Size = new Size(229, 22);
            txtClienteDistrito.TabIndex = 13;
            txtClienteDistrito.TextAlign = HorizontalAlignment.Center;
            txtClienteDistrito.KeyPress += txtClienteDistrito_KeyPress;
            // 
            // btnClienteLimpiar
            // 
            btnClienteLimpiar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteLimpiar.Location = new Point(146, 216);
            btnClienteLimpiar.Name = "btnClienteLimpiar";
            btnClienteLimpiar.Size = new Size(86, 25);
            btnClienteLimpiar.TabIndex = 17;
            btnClienteLimpiar.Text = "Limpiar";
            btnClienteLimpiar.UseVisualStyleBackColor = true;
            btnClienteLimpiar.Click += btnClienteLimpiar_Click;
            // 
            // lblClienteOtrasSenias
            // 
            lblClienteOtrasSenias.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteOtrasSenias.Location = new Point(15, 130);
            lblClienteOtrasSenias.Name = "lblClienteOtrasSenias";
            lblClienteOtrasSenias.Size = new Size(89, 22);
            lblClienteOtrasSenias.TabIndex = 17;
            lblClienteOtrasSenias.Text = "Otras Senias";
            lblClienteOtrasSenias.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteCanton
            // 
            txtClienteCanton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteCanton.Location = new Point(110, 76);
            txtClienteCanton.Name = "txtClienteCanton";
            txtClienteCanton.Size = new Size(229, 22);
            txtClienteCanton.TabIndex = 12;
            txtClienteCanton.TextAlign = HorizontalAlignment.Center;
            txtClienteCanton.KeyPress += txtClienteCanton_KeyPress;
            // 
            // btnClienteAceptar
            // 
            btnClienteAceptar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteAceptar.Location = new Point(54, 216);
            btnClienteAceptar.Name = "btnClienteAceptar";
            btnClienteAceptar.Size = new Size(86, 25);
            btnClienteAceptar.TabIndex = 16;
            btnClienteAceptar.Text = "Aceptar";
            btnClienteAceptar.UseVisualStyleBackColor = true;
            btnClienteAceptar.Click += btnClienteAceptar_Click;
            // 
            // txtClienteApellidoSegundo
            // 
            txtClienteApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoSegundo.Location = new Point(171, 158);
            txtClienteApellidoSegundo.Name = "txtClienteApellidoSegundo";
            txtClienteApellidoSegundo.Size = new Size(167, 22);
            txtClienteApellidoSegundo.TabIndex = 7;
            txtClienteApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            txtClienteApellidoSegundo.KeyPress += txtClienteApellidoSegundo_KeyPress;
            // 
            // txtClienteApellidoPrimero
            // 
            txtClienteApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoPrimero.Location = new Point(171, 130);
            txtClienteApellidoPrimero.Name = "txtClienteApellidoPrimero";
            txtClienteApellidoPrimero.Size = new Size(167, 22);
            txtClienteApellidoPrimero.TabIndex = 6;
            txtClienteApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            txtClienteApellidoPrimero.KeyPress += txtClienteApellidoPrimero_KeyPress;
            // 
            // txtClienteDNI
            // 
            txtClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDNI.Location = new Point(171, 74);
            txtClienteDNI.Name = "txtClienteDNI";
            txtClienteDNI.Size = new Size(167, 22);
            txtClienteDNI.TabIndex = 4;
            txtClienteDNI.TextAlign = HorizontalAlignment.Center;
            txtClienteDNI.KeyPress += txtClienteDNI_KeyPress;
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteEmail.Location = new Point(28, 216);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(137, 22);
            lblClienteEmail.TabIndex = 5;
            lblClienteEmail.Text = "Correo Electronico";
            lblClienteEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteEmail.Location = new Point(171, 214);
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.Size = new Size(167, 22);
            txtClienteEmail.TabIndex = 9;
            txtClienteEmail.TextAlign = HorizontalAlignment.Center;
            txtClienteEmail.KeyPress += txtClienteEmail_KeyPress;
            // 
            // lblClienteDNI
            // 
            lblClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteDNI.Location = new Point(28, 76);
            lblClienteDNI.Name = "lblClienteDNI";
            lblClienteDNI.Size = new Size(137, 22);
            lblClienteDNI.TabIndex = 3;
            lblClienteDNI.Text = "Identificacion";
            lblClienteDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteApellidoSegundo
            // 
            lblClienteApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellidoSegundo.Location = new Point(28, 158);
            lblClienteApellidoSegundo.Name = "lblClienteApellidoSegundo";
            lblClienteApellidoSegundo.Size = new Size(137, 22);
            lblClienteApellidoSegundo.TabIndex = 2;
            lblClienteApellidoSegundo.Text = "Segundo Apellido";
            lblClienteApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteApellidoPrimero
            // 
            lblClienteApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellidoPrimero.Location = new Point(28, 130);
            lblClienteApellidoPrimero.Name = "lblClienteApellidoPrimero";
            lblClienteApellidoPrimero.Size = new Size(137, 22);
            lblClienteApellidoPrimero.TabIndex = 1;
            lblClienteApellidoPrimero.Text = "Primer Apellido";
            lblClienteApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(28, 102);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(137, 22);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Text = "Nombre";
            lblClienteNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(171, 102);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(167, 22);
            txtClienteNombre.TabIndex = 5;
            txtClienteNombre.TextAlign = HorizontalAlignment.Center;
            txtClienteNombre.KeyPress += txtClienteNombre_KeyPress;
            // 
            // lblClienteTipoDNI
            // 
            lblClienteTipoDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTipoDNI.Location = new Point(28, 44);
            lblClienteTipoDNI.Name = "lblClienteTipoDNI";
            lblClienteTipoDNI.Size = new Size(137, 22);
            lblClienteTipoDNI.TabIndex = 10;
            lblClienteTipoDNI.Text = "Tipo de Identificacion";
            lblClienteTipoDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxClienteTipoDNI
            // 
            cbxClienteTipoDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxClienteTipoDNI.FormattingEnabled = true;
            cbxClienteTipoDNI.Items.AddRange(new object[] { "JURIDICO", "FISICO" });
            cbxClienteTipoDNI.Location = new Point(171, 44);
            cbxClienteTipoDNI.Name = "cbxClienteTipoDNI";
            cbxClienteTipoDNI.Size = new Size(167, 24);
            cbxClienteTipoDNI.TabIndex = 3;
            // 
            // lblClienteTelefono
            // 
            lblClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTelefono.Location = new Point(28, 186);
            lblClienteTelefono.Name = "lblClienteTelefono";
            lblClienteTelefono.Size = new Size(137, 22);
            lblClienteTelefono.TabIndex = 12;
            lblClienteTelefono.Text = "Telefono";
            lblClienteTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteTelefono.Location = new Point(171, 186);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.Size = new Size(167, 22);
            txtClienteTelefono.TabIndex = 8;
            txtClienteTelefono.TextAlign = HorizontalAlignment.Center;
            txtClienteTelefono.KeyPress += txtClienteTelefono_KeyPress;
            // 
            // gbxClientesRegistrarDatos
            // 
            gbxClientesRegistrarDatos.Controls.Add(txtClienteTelefono);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteTelefono);
            gbxClientesRegistrarDatos.Controls.Add(cbxClienteTipoDNI);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteTipoDNI);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteNombre);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteNombre);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteApellidoPrimero);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteApellidoSegundo);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteDNI);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteEmail);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteEmail);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteDNI);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteApellidoPrimero);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteApellidoSegundo);
            gbxClientesRegistrarDatos.Dock = DockStyle.Left;
            gbxClientesRegistrarDatos.Location = new Point(0, 159);
            gbxClientesRegistrarDatos.Name = "gbxClientesRegistrarDatos";
            gbxClientesRegistrarDatos.Size = new Size(370, 286);
            gbxClientesRegistrarDatos.TabIndex = 2;
            gbxClientesRegistrarDatos.TabStop = false;
            gbxClientesRegistrarDatos.Text = "Datos Cliente";
            gbxClientesRegistrarDatos.UseCompatibleTextRendering = true;
            // 
            // frmRegistroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            ControlBox = false;
            Controls.Add(gbxClienteDireccion);
            Controls.Add(gbxClientesRegistrarDatos);
            Controls.Add(gbxClienteLista);
            Controls.Add(gbxClienteRegistro);
            MinimumSize = new Size(790, 700);
            Name = "frmRegistroClientes";
            Text = "Registro Clientes";
            Load += frmRegistroClientes_Load;
            gbxClienteRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxClienteLista.ResumeLayout(false);
            gbxClienteDireccion.ResumeLayout(false);
            gbxClienteDireccion.PerformLayout();
            gbxClientesRegistrarDatos.ResumeLayout(false);
            gbxClientesRegistrarDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxClienteRegistro;
        private PictureBox pbLogo;
        private Label lblClienteTitulo;
        private GroupBox gbxClienteLista;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblClienteCanton;
        private Label lblClienteProvincia;
        private TextBox txtClienteOtrasSenias;
        private TextBox txtClienteDistrito;
        private TextBox txtClienteCanton;
        private Label lblClienteOtrasSenias;
        private Label lblClienteDistrito;
        private ComboBox cbxClienteProvincia;
        private GroupBox gbxClienteDireccion;
        private TextBox txtClienteApellidoSegundo;
        private TextBox txtClienteApellidoPrimero;
        private TextBox txtClienteDNI;
        private Label lblClienteEmail;
        private TextBox txtClienteEmail;
        private Label lblClienteDNI;
        private Button btnClienteAceptar;
        private Label lblClienteApellidoSegundo;
        private Label lblClienteApellidoPrimero;
        private Button btnClienteLimpiar;
        private Button btnClienteCancelar;
        private Label lblClienteNombre;
        private TextBox txtClienteNombre;
        private Label lblClienteTipoDNI;
        private ComboBox cbxClienteTipoDNI;
        private Label lblClienteTelefono;
        private TextBox txtClienteTelefono;
        private GroupBox gbxClientesRegistrarDatos;
        private ListView lvwRegistroClientes;
        private ColumnHeader colTipoIdentificacion;
        private ColumnHeader colNumIdentificacion;
        private ColumnHeader colNombre;
        private ColumnHeader colApellidoPrimero;
        private ColumnHeader colApellidoSegundo;
        private ColumnHeader colTelefono;
        private ColumnHeader colEmail;
        private ColumnHeader colProvinvia;
        private ColumnHeader colCanton;
        private ColumnHeader colDistrito;
        private ColumnHeader colOtrasSenias;
        private ColumnHeader colCodigo;
    }
}