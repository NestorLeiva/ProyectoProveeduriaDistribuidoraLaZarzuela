namespace Proveeduria
{
    partial class frmModificacionClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionClientes));
            gbxClienteDireccion = new GroupBox();
            lblClienteProvincia = new Label();
            cbxClienteProvincia = new ComboBox();
            lblClienteCanton = new Label();
            txtClienteOtrasSenias = new TextBox();
            lblClienteDistrito = new Label();
            btnClienteCancelar = new Button();
            btnClienteLimpiar = new Button();
            txtClienteDistrito = new TextBox();
            lblClienteOtrasSenias = new Label();
            txtClienteCanton = new TextBox();
            btnClienteModificar = new Button();
            gbxClientesRegistrarDatos = new GroupBox();
            txtClienteTelefono = new TextBox();
            lblClienteTelefono = new Label();
            cbxClienteTipoDNI = new ComboBox();
            lblClienteTipoDNI = new Label();
            txtClienteNombre = new TextBox();
            lblClienteNombre = new Label();
            lblClienteApellidoPrimero = new Label();
            lblClienteApellidoSegundo = new Label();
            lblClienteDNI = new Label();
            txtClienteCodigo = new TextBox();
            lblClienteCodigo = new Label();
            txtClienteEmail = new TextBox();
            lblClienteEmail = new Label();
            txtClienteDNI = new TextBox();
            txtClienteApellidoPrimero = new TextBox();
            txtClienteApellidoSegundo = new TextBox();
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
            gbxClienteRegistro = new GroupBox();
            gbxClienteModificar = new GroupBox();
            btnModificarBuscar = new Button();
            cbxBuscarTipoDNI = new ComboBox();
            lblBuscarClienteDNI = new Label();
            txtBuscarDNI = new TextBox();
            lblBuscarDNI = new Label();
            pbLogo = new PictureBox();
            lblClienteTitulo = new Label();
            gbxClienteDireccion.SuspendLayout();
            gbxClientesRegistrarDatos.SuspendLayout();
            gbxClienteLista.SuspendLayout();
            gbxClienteRegistro.SuspendLayout();
            gbxClienteModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // gbxClienteDireccion
            // 
            gbxClienteDireccion.Controls.Add(lblClienteProvincia);
            gbxClienteDireccion.Controls.Add(cbxClienteProvincia);
            gbxClienteDireccion.Controls.Add(lblClienteCanton);
            gbxClienteDireccion.Controls.Add(txtClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(lblClienteDistrito);
            gbxClienteDireccion.Controls.Add(btnClienteCancelar);
            gbxClienteDireccion.Controls.Add(btnClienteLimpiar);
            gbxClienteDireccion.Controls.Add(txtClienteDistrito);
            gbxClienteDireccion.Controls.Add(lblClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(txtClienteCanton);
            gbxClienteDireccion.Controls.Add(btnClienteModificar);
            gbxClienteDireccion.Dock = DockStyle.Right;
            gbxClienteDireccion.Location = new Point(401, 159);
            gbxClienteDireccion.Name = "gbxClienteDireccion";
            gbxClienteDireccion.Size = new Size(373, 286);
            gbxClienteDireccion.TabIndex = 15;
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
            cbxClienteProvincia.TabIndex = 16;
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
            txtClienteOtrasSenias.TabIndex = 19;
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
            btnClienteCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteCancelar.Location = new Point(225, 237);
            btnClienteCancelar.Name = "btnClienteCancelar";
            btnClienteCancelar.Size = new Size(86, 25);
            btnClienteCancelar.TabIndex = 22;
            btnClienteCancelar.Text = "Cancelar";
            btnClienteCancelar.UseVisualStyleBackColor = true;
            btnClienteCancelar.Click += btnClienteCancelar_Click;
            // 
            // btnClienteLimpiar
            // 
            btnClienteLimpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteLimpiar.Location = new Point(133, 237);
            btnClienteLimpiar.Name = "btnClienteLimpiar";
            btnClienteLimpiar.Size = new Size(86, 25);
            btnClienteLimpiar.TabIndex = 21;
            btnClienteLimpiar.Text = "Limpiar";
            btnClienteLimpiar.UseVisualStyleBackColor = true;
            btnClienteLimpiar.Click += btnClienteLimpiar_Click;
            // 
            // txtClienteDistrito
            // 
            txtClienteDistrito.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDistrito.Location = new Point(110, 104);
            txtClienteDistrito.Name = "txtClienteDistrito";
            txtClienteDistrito.Size = new Size(229, 22);
            txtClienteDistrito.TabIndex = 18;
            txtClienteDistrito.TextAlign = HorizontalAlignment.Center;
            txtClienteDistrito.KeyPress += txtClienteDistrito_KeyPress;
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
            txtClienteCanton.TabIndex = 17;
            txtClienteCanton.TextAlign = HorizontalAlignment.Center;
            txtClienteCanton.KeyPress += txtClienteCanton_KeyPress;
            // 
            // btnClienteModificar
            // 
            btnClienteModificar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteModificar.Location = new Point(41, 237);
            btnClienteModificar.Name = "btnClienteModificar";
            btnClienteModificar.Size = new Size(86, 25);
            btnClienteModificar.TabIndex = 20;
            btnClienteModificar.Text = "Modificar";
            btnClienteModificar.UseVisualStyleBackColor = true;
            btnClienteModificar.Click += btnClienteModificar_Click;
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
            gbxClientesRegistrarDatos.Controls.Add(txtClienteCodigo);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteCodigo);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteEmail);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteEmail);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteDNI);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteApellidoPrimero);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteApellidoSegundo);
            gbxClientesRegistrarDatos.Dock = DockStyle.Left;
            gbxClientesRegistrarDatos.Location = new Point(0, 159);
            gbxClientesRegistrarDatos.Name = "gbxClientesRegistrarDatos";
            gbxClientesRegistrarDatos.Size = new Size(370, 286);
            gbxClientesRegistrarDatos.TabIndex = 6;
            gbxClientesRegistrarDatos.TabStop = false;
            gbxClientesRegistrarDatos.Text = "Datos Cliente";
            gbxClientesRegistrarDatos.UseCompatibleTextRendering = true;
            // 
            // txtClienteTelefono
            // 
            txtClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteTelefono.Location = new Point(203, 189);
            txtClienteTelefono.Name = "txtClienteTelefono";
            txtClienteTelefono.Size = new Size(135, 22);
            txtClienteTelefono.TabIndex = 13;
            txtClienteTelefono.TextAlign = HorizontalAlignment.Center;
            txtClienteTelefono.KeyPress += txtClienteTelefono_KeyPress;
            // 
            // lblClienteTelefono
            // 
            lblClienteTelefono.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTelefono.Location = new Point(28, 189);
            lblClienteTelefono.Name = "lblClienteTelefono";
            lblClienteTelefono.Size = new Size(137, 22);
            lblClienteTelefono.TabIndex = 12;
            lblClienteTelefono.Text = "Telefono";
            lblClienteTelefono.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxClienteTipoDNI
            // 
            cbxClienteTipoDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxClienteTipoDNI.FormattingEnabled = true;
            cbxClienteTipoDNI.Items.AddRange(new object[] { "JURIDICO", "FISICO" });
            cbxClienteTipoDNI.Location = new Point(203, 19);
            cbxClienteTipoDNI.Name = "cbxClienteTipoDNI";
            cbxClienteTipoDNI.Size = new Size(135, 24);
            cbxClienteTipoDNI.TabIndex = 7;
            // 
            // lblClienteTipoDNI
            // 
            lblClienteTipoDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteTipoDNI.Location = new Point(28, 19);
            lblClienteTipoDNI.Name = "lblClienteTipoDNI";
            lblClienteTipoDNI.Size = new Size(137, 22);
            lblClienteTipoDNI.TabIndex = 10;
            lblClienteTipoDNI.Text = "Tipo de Identificacion";
            lblClienteTipoDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteNombre.Location = new Point(203, 77);
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(135, 22);
            txtClienteNombre.TabIndex = 9;
            txtClienteNombre.TextAlign = HorizontalAlignment.Center;
            txtClienteNombre.KeyPress += txtClienteNombre_KeyPress;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteNombre.Location = new Point(28, 77);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(137, 22);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Text = "Nombre";
            lblClienteNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteApellidoPrimero
            // 
            lblClienteApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellidoPrimero.Location = new Point(28, 105);
            lblClienteApellidoPrimero.Name = "lblClienteApellidoPrimero";
            lblClienteApellidoPrimero.Size = new Size(137, 22);
            lblClienteApellidoPrimero.TabIndex = 1;
            lblClienteApellidoPrimero.Text = "Primer Apellido";
            lblClienteApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteApellidoSegundo
            // 
            lblClienteApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteApellidoSegundo.Location = new Point(28, 133);
            lblClienteApellidoSegundo.Name = "lblClienteApellidoSegundo";
            lblClienteApellidoSegundo.Size = new Size(137, 22);
            lblClienteApellidoSegundo.TabIndex = 2;
            lblClienteApellidoSegundo.Text = "Segundo Apellido";
            lblClienteApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblClienteDNI
            // 
            lblClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteDNI.Location = new Point(28, 51);
            lblClienteDNI.Name = "lblClienteDNI";
            lblClienteDNI.Size = new Size(137, 22);
            lblClienteDNI.TabIndex = 3;
            lblClienteDNI.Text = "Identificacion";
            lblClienteDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteCodigo
            // 
            txtClienteCodigo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteCodigo.Location = new Point(203, 161);
            txtClienteCodigo.Name = "txtClienteCodigo";
            txtClienteCodigo.ReadOnly = true;
            txtClienteCodigo.Size = new Size(135, 22);
            txtClienteCodigo.TabIndex = 12;
            txtClienteCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // lblClienteCodigo
            // 
            lblClienteCodigo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteCodigo.Location = new Point(28, 161);
            lblClienteCodigo.Name = "lblClienteCodigo";
            lblClienteCodigo.Size = new Size(137, 22);
            lblClienteCodigo.TabIndex = 4;
            lblClienteCodigo.Text = "Codigo Cliente";
            lblClienteCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteEmail.Location = new Point(203, 217);
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.Size = new Size(135, 22);
            txtClienteEmail.TabIndex = 14;
            txtClienteEmail.TextAlign = HorizontalAlignment.Center;
            txtClienteEmail.KeyPress += txtClienteEmail_KeyPress;
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblClienteEmail.Location = new Point(28, 219);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(137, 22);
            lblClienteEmail.TabIndex = 5;
            lblClienteEmail.Text = "Correo Electronico";
            lblClienteEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtClienteDNI
            // 
            txtClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDNI.Location = new Point(203, 49);
            txtClienteDNI.Name = "txtClienteDNI";
            txtClienteDNI.ReadOnly = true;
            txtClienteDNI.Size = new Size(135, 22);
            txtClienteDNI.TabIndex = 8;
            txtClienteDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClienteApellidoPrimero
            // 
            txtClienteApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoPrimero.Location = new Point(203, 105);
            txtClienteApellidoPrimero.Name = "txtClienteApellidoPrimero";
            txtClienteApellidoPrimero.Size = new Size(135, 22);
            txtClienteApellidoPrimero.TabIndex = 10;
            txtClienteApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            txtClienteApellidoPrimero.KeyPress += txtClienteApellidoPrimero_KeyPress;
            // 
            // txtClienteApellidoSegundo
            // 
            txtClienteApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoSegundo.Location = new Point(203, 133);
            txtClienteApellidoSegundo.Name = "txtClienteApellidoSegundo";
            txtClienteApellidoSegundo.Size = new Size(135, 22);
            txtClienteApellidoSegundo.TabIndex = 11;
            txtClienteApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            txtClienteApellidoSegundo.KeyPress += txtClienteApellidoSegundo_KeyPress;
            // 
            // gbxClienteLista
            // 
            gbxClienteLista.Controls.Add(lvwRegistroClientes);
            gbxClienteLista.Dock = DockStyle.Bottom;
            gbxClienteLista.Location = new Point(0, 445);
            gbxClienteLista.Name = "gbxClienteLista";
            gbxClienteLista.Size = new Size(774, 216);
            gbxClienteLista.TabIndex = 23;
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
            lvwRegistroClientes.TabIndex = 24;
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
            // gbxClienteRegistro
            // 
            gbxClienteRegistro.Controls.Add(gbxClienteModificar);
            gbxClienteRegistro.Controls.Add(pbLogo);
            gbxClienteRegistro.Controls.Add(lblClienteTitulo);
            gbxClienteRegistro.Dock = DockStyle.Top;
            gbxClienteRegistro.Location = new Point(0, 0);
            gbxClienteRegistro.Name = "gbxClienteRegistro";
            gbxClienteRegistro.Size = new Size(774, 159);
            gbxClienteRegistro.TabIndex = 1;
            gbxClienteRegistro.TabStop = false;
            // 
            // gbxClienteModificar
            // 
            gbxClienteModificar.Controls.Add(btnModificarBuscar);
            gbxClienteModificar.Controls.Add(cbxBuscarTipoDNI);
            gbxClienteModificar.Controls.Add(lblBuscarClienteDNI);
            gbxClienteModificar.Controls.Add(txtBuscarDNI);
            gbxClienteModificar.Controls.Add(lblBuscarDNI);
            gbxClienteModificar.Location = new Point(203, 67);
            gbxClienteModificar.Name = "gbxClienteModificar";
            gbxClienteModificar.Size = new Size(442, 80);
            gbxClienteModificar.TabIndex = 2;
            gbxClienteModificar.TabStop = false;
            gbxClienteModificar.Text = "Buscar Cliente";
            // 
            // btnModificarBuscar
            // 
            btnModificarBuscar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarBuscar.Location = new Point(347, 49);
            btnModificarBuscar.Name = "btnModificarBuscar";
            btnModificarBuscar.Size = new Size(86, 25);
            btnModificarBuscar.TabIndex = 5;
            btnModificarBuscar.Text = "Buscar";
            btnModificarBuscar.UseVisualStyleBackColor = true;
            btnModificarBuscar.Click += btnModificarBuscar_Click;
            // 
            // cbxBuscarTipoDNI
            // 
            cbxBuscarTipoDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbxBuscarTipoDNI.FormattingEnabled = true;
            cbxBuscarTipoDNI.Items.AddRange(new object[] { "JURIDICO", "FISICO" });
            cbxBuscarTipoDNI.Location = new Point(206, 19);
            cbxBuscarTipoDNI.Name = "cbxBuscarTipoDNI";
            cbxBuscarTipoDNI.Size = new Size(135, 24);
            cbxBuscarTipoDNI.TabIndex = 3;
            // 
            // lblBuscarClienteDNI
            // 
            lblBuscarClienteDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarClienteDNI.Location = new Point(31, 19);
            lblBuscarClienteDNI.Name = "lblBuscarClienteDNI";
            lblBuscarClienteDNI.Size = new Size(137, 22);
            lblBuscarClienteDNI.TabIndex = 12;
            lblBuscarClienteDNI.Text = "Tipo de Identificacion";
            lblBuscarClienteDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBuscarDNI
            // 
            txtBuscarDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarDNI.Location = new Point(206, 52);
            txtBuscarDNI.Name = "txtBuscarDNI";
            txtBuscarDNI.Size = new Size(135, 22);
            txtBuscarDNI.TabIndex = 4;
            txtBuscarDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // lblBuscarDNI
            // 
            lblBuscarDNI.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscarDNI.Location = new Point(31, 52);
            lblBuscarDNI.Name = "lblBuscarDNI";
            lblBuscarDNI.Size = new Size(137, 22);
            lblBuscarDNI.TabIndex = 4;
            lblBuscarDNI.Text = "Identificacion";
            lblBuscarDNI.TextAlign = ContentAlignment.MiddleRight;
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
            lblClienteTitulo.Location = new Point(203, 22);
            lblClienteTitulo.Name = "lblClienteTitulo";
            lblClienteTitulo.Size = new Size(253, 31);
            lblClienteTitulo.TabIndex = 16;
            lblClienteTitulo.Text = "Modificacion de Clientes";
            lblClienteTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmModificacionClientes
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
            Name = "frmModificacionClientes";
            Text = "Modificacion Clientes";
            Load += frmModificacionClientes_Load;
            gbxClienteDireccion.ResumeLayout(false);
            gbxClienteDireccion.PerformLayout();
            gbxClientesRegistrarDatos.ResumeLayout(false);
            gbxClientesRegistrarDatos.PerformLayout();
            gbxClienteLista.ResumeLayout(false);
            gbxClienteRegistro.ResumeLayout(false);
            gbxClienteModificar.ResumeLayout(false);
            gbxClienteModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxClienteDireccion;
        private Label lblClienteProvincia;
        private ComboBox cbxClienteProvincia;
        private Label lblClienteCanton;
        private TextBox txtClienteOtrasSenias;
        private Label lblClienteDistrito;
        private TextBox txtClienteDistrito;
        private Label lblClienteOtrasSenias;
        private TextBox txtClienteCanton;
        private GroupBox gbxClientesRegistrarDatos;
        private TextBox txtClienteTelefono;
        private Label lblClienteTelefono;
        private ComboBox cbxClienteTipoDNI;
        private Label lblClienteTipoDNI;
        private TextBox txtClienteNombre;
        private Label lblClienteNombre;
        private Button btnClienteCancelar;
        private Button btnClienteLimpiar;
        private Label lblClienteApellidoPrimero;
        private Label lblClienteApellidoSegundo;
        private Button btnClienteModificar;
        private Label lblClienteDNI;
        private TextBox txtClienteCodigo;
        private Label lblClienteCodigo;
        private TextBox txtClienteEmail;
        private Label lblClienteEmail;
        private TextBox txtClienteDNI;
        private TextBox txtClienteApellidoPrimero;
        private TextBox txtClienteApellidoSegundo;
        private GroupBox gbxClienteLista;
        private GroupBox gbxClienteRegistro;
        private PictureBox pbLogo;
        private Label lblClienteTitulo;
        private GroupBox gbxClienteModificar;
        private ComboBox cbxBuscarTipoDNI;
        private Label lblBuscarClienteDNI;
        private TextBox txtBuscarDNI;
        private Label lblBuscarDNI;
        private Button btnModificarBuscar;
        private ListView lvwRegistroClientes;
        private ColumnHeader colTipoIdentificacion;
        private ColumnHeader colNumIdentificacion;
        private ColumnHeader colNombre;
        private ColumnHeader colApellidoPrimero;
        private ColumnHeader colApellidoSegundo;
        private ColumnHeader colCodigo;
        private ColumnHeader colTelefono;
        private ColumnHeader colEmail;
        private ColumnHeader colProvinvia;
        private ColumnHeader colCanton;
        private ColumnHeader colDistrito;
        private ColumnHeader colOtrasSenias;
    }
}