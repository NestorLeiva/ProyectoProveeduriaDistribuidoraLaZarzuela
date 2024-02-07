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
            dgvClientesLista = new DataGridView();
            colTipoDNI = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellidoPrimero = new DataGridViewTextBoxColumn();
            colApellidoSegundo = new DataGridViewTextBoxColumn();
            colCodigoCliente = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colProvincia = new DataGridViewTextBoxColumn();
            colCanton = new DataGridViewTextBoxColumn();
            colDistrito = new DataGridViewTextBoxColumn();
            colOtrasSenias = new DataGridViewTextBoxColumn();
            gbxClientesRegistrarDatos = new GroupBox();
            txtClienteTelefono = new TextBox();
            lblClienteTelefono = new Label();
            cbxClienteTipoDNI = new ComboBox();
            lblClienteTipoDNI = new Label();
            txtClienteNombre = new TextBox();
            lblClienteNombre = new Label();
            btnClienteCancelar = new Button();
            btnClienteLimpiar = new Button();
            lblClienteApellidoPrimero = new Label();
            lblClienteApellidoSegundo = new Label();
            btnClienteAceptar = new Button();
            lblClienteDNI = new Label();
            txtClienteCodigo = new TextBox();
            lblClienteCodigo = new Label();
            txtClienteEmail = new TextBox();
            lblClienteEmail = new Label();
            txtClienteDNI = new TextBox();
            txtClienteApellidoPrimero = new TextBox();
            txtClienteApellidoSegundo = new TextBox();
            gbxClienteDireccion = new GroupBox();
            btnClienteDireccionAceptar = new Button();
            lblClienteProvincia = new Label();
            cbxClienteProvincia = new ComboBox();
            lblClienteCanton = new Label();
            txtClienteOtrasSenias = new TextBox();
            lblClienteDistrito = new Label();
            txtClienteDistrito = new TextBox();
            lblClienteOtrasSenias = new Label();
            txtClienteCanton = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbxClienteRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxClienteLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientesLista).BeginInit();
            gbxClientesRegistrarDatos.SuspendLayout();
            gbxClienteDireccion.SuspendLayout();
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
            lblClienteTitulo.Size = new Size(253, 31);
            lblClienteTitulo.TabIndex = 16;
            lblClienteTitulo.Text = "Registro de Clientes";
            lblClienteTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxClienteLista
            // 
            gbxClienteLista.Controls.Add(dgvClientesLista);
            gbxClienteLista.Dock = DockStyle.Bottom;
            gbxClienteLista.Location = new Point(0, 445);
            gbxClienteLista.Name = "gbxClienteLista";
            gbxClienteLista.Size = new Size(774, 216);
            gbxClienteLista.TabIndex = 4;
            gbxClienteLista.TabStop = false;
            gbxClienteLista.Text = "Lista de Clientes";
            // 
            // dgvClientesLista
            // 
            dgvClientesLista.AllowUserToDeleteRows = false;
            dgvClientesLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvClientesLista.Columns.AddRange(new DataGridViewColumn[] { colTipoDNI, colDNI, colNombre, colApellidoPrimero, colApellidoSegundo, colCodigoCliente, colTelefono, colEmail, colProvincia, colCanton, colDistrito, colOtrasSenias });
            dgvClientesLista.Dock = DockStyle.Fill;
            dgvClientesLista.Location = new Point(3, 19);
            dgvClientesLista.Name = "dgvClientesLista";
            dgvClientesLista.ReadOnly = true;
            dgvClientesLista.RowTemplate.Height = 25;
            dgvClientesLista.Size = new Size(768, 194);
            dgvClientesLista.TabIndex = 17;
            // 
            // colTipoDNI
            // 
            colTipoDNI.HeaderText = "Tipo Indentificacion";
            colTipoDNI.Name = "colTipoDNI";
            colTipoDNI.ReadOnly = true;
            colTipoDNI.Width = 137;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "Identificacion";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            colDNI.Width = 104;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 76;
            // 
            // colApellidoPrimero
            // 
            colApellidoPrimero.HeaderText = "Primer Apellido";
            colApellidoPrimero.Name = "colApellidoPrimero";
            colApellidoPrimero.ReadOnly = true;
            colApellidoPrimero.Width = 114;
            // 
            // colApellidoSegundo
            // 
            colApellidoSegundo.HeaderText = "Segundo Apellido";
            colApellidoSegundo.Name = "colApellidoSegundo";
            colApellidoSegundo.ReadOnly = true;
            colApellidoSegundo.Width = 126;
            // 
            // colCodigoCliente
            // 
            colCodigoCliente.HeaderText = "Codigo Cliente";
            colCodigoCliente.Name = "colCodigoCliente";
            colCodigoCliente.ReadOnly = true;
            colCodigoCliente.Width = 111;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Telefono";
            colTelefono.Name = "colTelefono";
            colTelefono.ReadOnly = true;
            colTelefono.Width = 77;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            colEmail.Width = 61;
            // 
            // colProvincia
            // 
            colProvincia.HeaderText = "Provincia";
            colProvincia.Name = "colProvincia";
            colProvincia.ReadOnly = true;
            colProvincia.Width = 81;
            // 
            // colCanton
            // 
            colCanton.HeaderText = "Canton";
            colCanton.Name = "colCanton";
            colCanton.ReadOnly = true;
            colCanton.Width = 71;
            // 
            // colDistrito
            // 
            colDistrito.HeaderText = "Distrito";
            colDistrito.Name = "colDistrito";
            colDistrito.ReadOnly = true;
            colDistrito.Width = 70;
            // 
            // colOtrasSenias
            // 
            colOtrasSenias.HeaderText = "Otras Senias";
            colOtrasSenias.Name = "colOtrasSenias";
            colOtrasSenias.ReadOnly = true;
            colOtrasSenias.Width = 96;
            // 
            // gbxClientesRegistrarDatos
            // 
            gbxClientesRegistrarDatos.Controls.Add(txtClienteTelefono);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteTelefono);
            gbxClientesRegistrarDatos.Controls.Add(cbxClienteTipoDNI);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteTipoDNI);
            gbxClientesRegistrarDatos.Controls.Add(txtClienteNombre);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteNombre);
            gbxClientesRegistrarDatos.Controls.Add(btnClienteCancelar);
            gbxClientesRegistrarDatos.Controls.Add(btnClienteLimpiar);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteApellidoPrimero);
            gbxClientesRegistrarDatos.Controls.Add(lblClienteApellidoSegundo);
            gbxClientesRegistrarDatos.Controls.Add(btnClienteAceptar);
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
            gbxClientesRegistrarDatos.TabIndex = 2;
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
            txtClienteTelefono.TabIndex = 7;
            txtClienteTelefono.TextAlign = HorizontalAlignment.Center;
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
            cbxClienteTipoDNI.TabIndex = 1;
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
            txtClienteNombre.TabIndex = 3;
            txtClienteNombre.TextAlign = HorizontalAlignment.Center;
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
            // btnClienteCancelar
            // 
            btnClienteCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteCancelar.Location = new Point(263, 255);
            btnClienteCancelar.Name = "btnClienteCancelar";
            btnClienteCancelar.Size = new Size(86, 25);
            btnClienteCancelar.TabIndex = 16;
            btnClienteCancelar.Text = "Cancelar";
            btnClienteCancelar.UseVisualStyleBackColor = true;
            // 
            // btnClienteLimpiar
            // 
            btnClienteLimpiar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteLimpiar.Location = new Point(171, 255);
            btnClienteLimpiar.Name = "btnClienteLimpiar";
            btnClienteLimpiar.Size = new Size(86, 25);
            btnClienteLimpiar.TabIndex = 15;
            btnClienteLimpiar.Text = "Limpiar";
            btnClienteLimpiar.UseVisualStyleBackColor = true;
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
            // btnClienteAceptar
            // 
            btnClienteAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteAceptar.Location = new Point(79, 255);
            btnClienteAceptar.Name = "btnClienteAceptar";
            btnClienteAceptar.Size = new Size(86, 25);
            btnClienteAceptar.TabIndex = 14;
            btnClienteAceptar.Text = "Aceptar";
            btnClienteAceptar.UseVisualStyleBackColor = true;
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
            txtClienteCodigo.Size = new Size(135, 22);
            txtClienteCodigo.TabIndex = 6;
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
            txtClienteEmail.TabIndex = 8;
            txtClienteEmail.TextAlign = HorizontalAlignment.Center;
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
            txtClienteDNI.Size = new Size(135, 22);
            txtClienteDNI.TabIndex = 2;
            txtClienteDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClienteApellidoPrimero
            // 
            txtClienteApellidoPrimero.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoPrimero.Location = new Point(203, 105);
            txtClienteApellidoPrimero.Name = "txtClienteApellidoPrimero";
            txtClienteApellidoPrimero.Size = new Size(135, 22);
            txtClienteApellidoPrimero.TabIndex = 4;
            txtClienteApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClienteApellidoSegundo
            // 
            txtClienteApellidoSegundo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteApellidoSegundo.Location = new Point(203, 133);
            txtClienteApellidoSegundo.Name = "txtClienteApellidoSegundo";
            txtClienteApellidoSegundo.Size = new Size(135, 22);
            txtClienteApellidoSegundo.TabIndex = 5;
            txtClienteApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            // 
            // gbxClienteDireccion
            // 
            gbxClienteDireccion.Controls.Add(btnClienteDireccionAceptar);
            gbxClienteDireccion.Controls.Add(lblClienteProvincia);
            gbxClienteDireccion.Controls.Add(cbxClienteProvincia);
            gbxClienteDireccion.Controls.Add(lblClienteCanton);
            gbxClienteDireccion.Controls.Add(txtClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(lblClienteDistrito);
            gbxClienteDireccion.Controls.Add(txtClienteDistrito);
            gbxClienteDireccion.Controls.Add(lblClienteOtrasSenias);
            gbxClienteDireccion.Controls.Add(txtClienteCanton);
            gbxClienteDireccion.Dock = DockStyle.Right;
            gbxClienteDireccion.Location = new Point(401, 159);
            gbxClienteDireccion.Name = "gbxClienteDireccion";
            gbxClienteDireccion.Size = new Size(373, 286);
            gbxClienteDireccion.TabIndex = 3;
            gbxClienteDireccion.TabStop = false;
            gbxClienteDireccion.Text = "Datos Direccion";
            // 
            // btnClienteDireccionAceptar
            // 
            btnClienteDireccionAceptar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClienteDireccionAceptar.Location = new Point(131, 186);
            btnClienteDireccionAceptar.Name = "btnClienteDireccionAceptar";
            btnClienteDireccionAceptar.Size = new Size(86, 25);
            btnClienteDireccionAceptar.TabIndex = 13;
            btnClienteDireccionAceptar.Text = "Aceptar";
            btnClienteDireccionAceptar.UseVisualStyleBackColor = true;
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
            cbxClienteProvincia.TabIndex = 9;
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
            txtClienteOtrasSenias.TabIndex = 12;
            txtClienteOtrasSenias.TextAlign = HorizontalAlignment.Center;
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
            // txtClienteDistrito
            // 
            txtClienteDistrito.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtClienteDistrito.Location = new Point(110, 104);
            txtClienteDistrito.Name = "txtClienteDistrito";
            txtClienteDistrito.Size = new Size(229, 22);
            txtClienteDistrito.TabIndex = 11;
            txtClienteDistrito.TextAlign = HorizontalAlignment.Center;
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
            txtClienteCanton.TabIndex = 10;
            txtClienteCanton.TextAlign = HorizontalAlignment.Center;
            // 
            // frmRegistroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxClienteDireccion);
            Controls.Add(gbxClientesRegistrarDatos);
            Controls.Add(gbxClienteLista);
            Controls.Add(gbxClienteRegistro);
            MinimumSize = new Size(790, 700);
            Name = "frmRegistroClientes";
            Text = "Registro Clientes";
            gbxClienteRegistro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxClienteLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientesLista).EndInit();
            gbxClientesRegistrarDatos.ResumeLayout(false);
            gbxClientesRegistrarDatos.PerformLayout();
            gbxClienteDireccion.ResumeLayout(false);
            gbxClienteDireccion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxClienteRegistro;
        private PictureBox pbLogo;
        private Label lblClienteTitulo;
        private GroupBox gbxClienteLista;
        private DataGridView dgvClientesLista;
        private GroupBox gbxClientesRegistrarDatos;
        private TextBox txtClienteNombre;
        private Label lblClienteNombre;
        private Button btnClienteCancelar;
        private Button btnClienteLimpiar;
        private Label lblClienteApellidoPrimero;
        private Label lblClienteApellidoSegundo;
        private Button btnClienteAceptar;
        private Label lblClienteDNI;
        private TextBox txtClienteCodigo;
        private Label lblClienteCodigo;
        private TextBox txtClienteEmail;
        private Label lblClienteEmail;
        private TextBox txtClienteDNI;
        private TextBox txtClienteApellidoPrimero;
        private TextBox txtClienteApellidoSegundo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbxClienteTipoDNI;
        private Label lblClienteTipoDNI;
        private TextBox txtClienteTelefono;
        private Label lblClienteTelefono;
        private Label lblClienteCanton;
        private Label lblClienteProvincia;
        private TextBox txtClienteOtrasSenias;
        private TextBox txtClienteDistrito;
        private TextBox txtClienteCanton;
        private Label lblClienteOtrasSenias;
        private Label lblClienteDistrito;
        private ComboBox cbxClienteProvincia;
        private GroupBox gbxClienteDireccion;
        private Button btnClienteDireccionAceptar;
        private DataGridViewTextBoxColumn colTipoDNI;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellidoPrimero;
        private DataGridViewTextBoxColumn colApellidoSegundo;
        private DataGridViewTextBoxColumn colCodigoCliente;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colProvincia;
        private DataGridViewTextBoxColumn colCanton;
        private DataGridViewTextBoxColumn colDistrito;
        private DataGridViewTextBoxColumn colOtrasSenias;
    }
}