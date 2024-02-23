namespace Proveeduria
{
    partial class frmModificacionFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificacionFuncionarios));
            txtFuncionarioCodigo = new TextBox();
            txtFuncionarioEmail = new TextBox();
            txtFuncionarioDNI = new TextBox();
            txtFuncionarioApellidoSegundo = new TextBox();
            txtFuncionarioApellidoPrimero = new TextBox();
            txtFuncionarioNombre = new TextBox();
            lblFuncionarioEmail = new Label();
            lblFuncionarioCodigo = new Label();
            lblFuncionarioDNI = new Label();
            lblFuncionarioApellidoSegundo = new Label();
            lblFuncionarioApellidoPrimero = new Label();
            lblFuncionarioNombre = new Label();
            pbLogo = new PictureBox();
            lblFuncionarioTitulo = new Label();
            gbxModificacion = new GroupBox();
            gbxConsultaFuncionario = new GroupBox();
            btnModificarConsutar = new Button();
            txtFuncionarioConsulta = new TextBox();
            gbxModificarFuncionarioDatos = new GroupBox();
            txtModificarContrasenia = new TextBox();
            lblModificarContrasenia = new Label();
            btnModificarActualizar = new Button();
            lblFuncionarioEstado = new Label();
            rbtnEstadoActivo = new RadioButton();
            rbtnEstadoInactivo = new RadioButton();
            btnModificarCancelar = new Button();
            btnModifcarLimpiar = new Button();
            btnModificarModificar = new Button();
            gbxFuncionarioModificarLista = new GroupBox();
            lvListaFuncionarios = new ListView();
            colIdentificacion = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellidoPrimero = new ColumnHeader();
            colApellidoSegundo = new ColumnHeader();
            colEmail = new ColumnHeader();
            colCodigoFuncionario = new ColumnHeader();
            colContrasenia = new ColumnHeader();
            colEstado = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxModificacion.SuspendLayout();
            gbxConsultaFuncionario.SuspendLayout();
            gbxModificarFuncionarioDatos.SuspendLayout();
            gbxFuncionarioModificarLista.SuspendLayout();
            SuspendLayout();
            // 
            // txtFuncionarioCodigo
            // 
            txtFuncionarioCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioCodigo.Location = new Point(527, 52);
            txtFuncionarioCodigo.Name = "txtFuncionarioCodigo";
            txtFuncionarioCodigo.ReadOnly = true;
            txtFuncionarioCodigo.Size = new Size(223, 27);
            txtFuncionarioCodigo.TabIndex = 10;
            txtFuncionarioCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioEmail
            // 
            txtFuncionarioEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioEmail.Location = new Point(527, 85);
            txtFuncionarioEmail.Name = "txtFuncionarioEmail";
            txtFuncionarioEmail.Size = new Size(223, 27);
            txtFuncionarioEmail.TabIndex = 11;
            txtFuncionarioEmail.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioEmail.KeyPress += txtFuncionarioEmail_KeyPress;
            // 
            // txtFuncionarioDNI
            // 
            txtFuncionarioDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioDNI.Location = new Point(527, 19);
            txtFuncionarioDNI.Name = "txtFuncionarioDNI";
            txtFuncionarioDNI.ReadOnly = true;
            txtFuncionarioDNI.Size = new Size(223, 27);
            txtFuncionarioDNI.TabIndex = 9;
            txtFuncionarioDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioApellidoSegundo
            // 
            txtFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoSegundo.Location = new Point(202, 83);
            txtFuncionarioApellidoSegundo.Name = "txtFuncionarioApellidoSegundo";
            txtFuncionarioApellidoSegundo.Size = new Size(179, 27);
            txtFuncionarioApellidoSegundo.TabIndex = 8;
            txtFuncionarioApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoSegundo.KeyPress += txtFuncionarioApellidoSegundo_KeyPress;
            // 
            // txtFuncionarioApellidoPrimero
            // 
            txtFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoPrimero.Location = new Point(202, 50);
            txtFuncionarioApellidoPrimero.Name = "txtFuncionarioApellidoPrimero";
            txtFuncionarioApellidoPrimero.Size = new Size(179, 27);
            txtFuncionarioApellidoPrimero.TabIndex = 7;
            txtFuncionarioApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoPrimero.KeyPress += txtFuncionarioApellidoPrimero_KeyPress;
            // 
            // txtFuncionarioNombre
            // 
            txtFuncionarioNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioNombre.Location = new Point(202, 17);
            txtFuncionarioNombre.Name = "txtFuncionarioNombre";
            txtFuncionarioNombre.Size = new Size(179, 27);
            txtFuncionarioNombre.TabIndex = 6;
            txtFuncionarioNombre.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioNombre.KeyPress += txtFuncionarioNombre_KeyPress;
            // 
            // lblFuncionarioEmail
            // 
            lblFuncionarioEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEmail.Location = new Point(387, 90);
            lblFuncionarioEmail.Name = "lblFuncionarioEmail";
            lblFuncionarioEmail.Size = new Size(134, 22);
            lblFuncionarioEmail.TabIndex = 17;
            lblFuncionarioEmail.Text = "Correo Electronico";
            lblFuncionarioEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioCodigo
            // 
            lblFuncionarioCodigo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioCodigo.Location = new Point(387, 57);
            lblFuncionarioCodigo.Name = "lblFuncionarioCodigo";
            lblFuncionarioCodigo.Size = new Size(134, 22);
            lblFuncionarioCodigo.TabIndex = 16;
            lblFuncionarioCodigo.Text = "Codigo Funcionario";
            lblFuncionarioCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioDNI
            // 
            lblFuncionarioDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioDNI.Location = new Point(387, 24);
            lblFuncionarioDNI.Name = "lblFuncionarioDNI";
            lblFuncionarioDNI.Size = new Size(134, 22);
            lblFuncionarioDNI.TabIndex = 15;
            lblFuncionarioDNI.Text = "Identificacion";
            lblFuncionarioDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoSegundo
            // 
            lblFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoSegundo.Location = new Point(37, 88);
            lblFuncionarioApellidoSegundo.Name = "lblFuncionarioApellidoSegundo";
            lblFuncionarioApellidoSegundo.Size = new Size(134, 22);
            lblFuncionarioApellidoSegundo.TabIndex = 14;
            lblFuncionarioApellidoSegundo.Text = "Segundo Apellido";
            lblFuncionarioApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoPrimero
            // 
            lblFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoPrimero.Location = new Point(37, 55);
            lblFuncionarioApellidoPrimero.Name = "lblFuncionarioApellidoPrimero";
            lblFuncionarioApellidoPrimero.Size = new Size(134, 22);
            lblFuncionarioApellidoPrimero.TabIndex = 13;
            lblFuncionarioApellidoPrimero.Text = "Primer Apellido";
            lblFuncionarioApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioNombre
            // 
            lblFuncionarioNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioNombre.Location = new Point(29, 19);
            lblFuncionarioNombre.Name = "lblFuncionarioNombre";
            lblFuncionarioNombre.Size = new Size(134, 22);
            lblFuncionarioNombre.TabIndex = 12;
            lblFuncionarioNombre.Text = "Nombre";
            lblFuncionarioNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 22);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(159, 125);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 24;
            pbLogo.TabStop = false;
            // 
            // lblFuncionarioTitulo
            // 
            lblFuncionarioTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioTitulo.Location = new Point(204, 37);
            lblFuncionarioTitulo.Name = "lblFuncionarioTitulo";
            lblFuncionarioTitulo.Size = new Size(296, 31);
            lblFuncionarioTitulo.TabIndex = 1;
            lblFuncionarioTitulo.Text = "Modificacion de Funcionarios";
            lblFuncionarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxModificacion
            // 
            gbxModificacion.Controls.Add(gbxConsultaFuncionario);
            gbxModificacion.Controls.Add(pbLogo);
            gbxModificacion.Controls.Add(lblFuncionarioTitulo);
            gbxModificacion.Dock = DockStyle.Top;
            gbxModificacion.Location = new Point(0, 0);
            gbxModificacion.Name = "gbxModificacion";
            gbxModificacion.Size = new Size(774, 155);
            gbxModificacion.TabIndex = 1;
            gbxModificacion.TabStop = false;
            // 
            // gbxConsultaFuncionario
            // 
            gbxConsultaFuncionario.Controls.Add(btnModificarConsutar);
            gbxConsultaFuncionario.Controls.Add(txtFuncionarioConsulta);
            gbxConsultaFuncionario.Location = new Point(182, 90);
            gbxConsultaFuncionario.Name = "gbxConsultaFuncionario";
            gbxConsultaFuncionario.Size = new Size(466, 59);
            gbxConsultaFuncionario.TabIndex = 2;
            gbxConsultaFuncionario.TabStop = false;
            gbxConsultaFuncionario.Text = "Consulta Funcionraio por Identificacion";
            // 
            // btnModificarConsutar
            // 
            btnModificarConsutar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarConsutar.Location = new Point(266, 22);
            btnModificarConsutar.Name = "btnModificarConsutar";
            btnModificarConsutar.Size = new Size(90, 28);
            btnModificarConsutar.TabIndex = 4;
            btnModificarConsutar.Text = "Consultar";
            btnModificarConsutar.UseVisualStyleBackColor = true;
            btnModificarConsutar.Click += btnModificarConsutar_Click;
            // 
            // txtFuncionarioConsulta
            // 
            txtFuncionarioConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioConsulta.Location = new Point(6, 22);
            txtFuncionarioConsulta.Name = "txtFuncionarioConsulta";
            txtFuncionarioConsulta.Size = new Size(254, 29);
            txtFuncionarioConsulta.TabIndex = 3;
            txtFuncionarioConsulta.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioConsulta.KeyPress += txtFuncionarioConsulta_KeyPress;
            // 
            // gbxModificarFuncionarioDatos
            // 
            gbxModificarFuncionarioDatos.Controls.Add(txtModificarContrasenia);
            gbxModificarFuncionarioDatos.Controls.Add(lblModificarContrasenia);
            gbxModificarFuncionarioDatos.Controls.Add(btnModificarActualizar);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioEstado);
            gbxModificarFuncionarioDatos.Controls.Add(rbtnEstadoActivo);
            gbxModificarFuncionarioDatos.Controls.Add(rbtnEstadoInactivo);
            gbxModificarFuncionarioDatos.Controls.Add(btnModificarCancelar);
            gbxModificarFuncionarioDatos.Controls.Add(btnModifcarLimpiar);
            gbxModificarFuncionarioDatos.Controls.Add(btnModificarModificar);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioNombre);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioNombre);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioCodigo);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioApellidoPrimero);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioEmail);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioApellidoSegundo);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioDNI);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioDNI);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioApellidoSegundo);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioCodigo);
            gbxModificarFuncionarioDatos.Controls.Add(txtFuncionarioApellidoPrimero);
            gbxModificarFuncionarioDatos.Controls.Add(lblFuncionarioEmail);
            gbxModificarFuncionarioDatos.Dock = DockStyle.Fill;
            gbxModificarFuncionarioDatos.Location = new Point(0, 155);
            gbxModificarFuncionarioDatos.Name = "gbxModificarFuncionarioDatos";
            gbxModificarFuncionarioDatos.Size = new Size(774, 506);
            gbxModificarFuncionarioDatos.TabIndex = 5;
            gbxModificarFuncionarioDatos.TabStop = false;
            gbxModificarFuncionarioDatos.Text = "Datos Funcionarios";
            // 
            // txtModificarContrasenia
            // 
            txtModificarContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarContrasenia.Location = new Point(527, 118);
            txtModificarContrasenia.Multiline = true;
            txtModificarContrasenia.Name = "txtModificarContrasenia";
            txtModificarContrasenia.Size = new Size(223, 30);
            txtModificarContrasenia.TabIndex = 14;
            txtModificarContrasenia.TextAlign = HorizontalAlignment.Center;
            txtModificarContrasenia.KeyPress += txtModificarContrasenia_KeyPress;
            // 
            // lblModificarContrasenia
            // 
            lblModificarContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarContrasenia.Location = new Point(387, 118);
            lblModificarContrasenia.Name = "lblModificarContrasenia";
            lblModificarContrasenia.Size = new Size(134, 28);
            lblModificarContrasenia.TabIndex = 21;
            lblModificarContrasenia.Text = "Contrasenia";
            lblModificarContrasenia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnModificarActualizar
            // 
            btnModificarActualizar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarActualizar.Location = new Point(495, 160);
            btnModificarActualizar.Name = "btnModificarActualizar";
            btnModificarActualizar.Size = new Size(90, 31);
            btnModificarActualizar.TabIndex = 17;
            btnModificarActualizar.Text = "Actualizar";
            btnModificarActualizar.UseVisualStyleBackColor = true;
            btnModificarActualizar.Click += btnModificarActualizar_Click;
            // 
            // lblFuncionarioEstado
            // 
            lblFuncionarioEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEstado.Location = new Point(29, 124);
            lblFuncionarioEstado.Name = "lblFuncionarioEstado";
            lblFuncionarioEstado.Size = new Size(134, 22);
            lblFuncionarioEstado.TabIndex = 20;
            lblFuncionarioEstado.Text = "Estado";
            lblFuncionarioEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtnEstadoActivo
            // 
            rbtnEstadoActivo.AutoSize = true;
            rbtnEstadoActivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnEstadoActivo.Location = new Point(312, 122);
            rbtnEstadoActivo.Name = "rbtnEstadoActivo";
            rbtnEstadoActivo.Size = new Size(69, 24);
            rbtnEstadoActivo.TabIndex = 13;
            rbtnEstadoActivo.TabStop = true;
            rbtnEstadoActivo.Text = "Activo";
            rbtnEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // rbtnEstadoInactivo
            // 
            rbtnEstadoInactivo.AutoSize = true;
            rbtnEstadoInactivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnEstadoInactivo.Location = new Point(202, 124);
            rbtnEstadoInactivo.Name = "rbtnEstadoInactivo";
            rbtnEstadoInactivo.Size = new Size(79, 24);
            rbtnEstadoInactivo.TabIndex = 12;
            rbtnEstadoInactivo.TabStop = true;
            rbtnEstadoInactivo.Text = "Inactivo";
            rbtnEstadoInactivo.UseVisualStyleBackColor = true;
            // 
            // btnModificarCancelar
            // 
            btnModificarCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarCancelar.Location = new Point(660, 158);
            btnModificarCancelar.Name = "btnModificarCancelar";
            btnModificarCancelar.Size = new Size(78, 33);
            btnModificarCancelar.TabIndex = 18;
            btnModificarCancelar.Text = "Cancelar";
            btnModificarCancelar.UseVisualStyleBackColor = true;
            btnModificarCancelar.Click += btnModificarCancelar_Click;
            // 
            // btnModifcarLimpiar
            // 
            btnModifcarLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifcarLimpiar.Location = new Point(306, 158);
            btnModifcarLimpiar.Name = "btnModifcarLimpiar";
            btnModifcarLimpiar.Size = new Size(78, 33);
            btnModifcarLimpiar.TabIndex = 16;
            btnModifcarLimpiar.Text = "Limpiar";
            btnModifcarLimpiar.UseVisualStyleBackColor = true;
            btnModifcarLimpiar.Click += btnModifcarLimpiar_Click;
            // 
            // btnModificarModificar
            // 
            btnModificarModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarModificar.Location = new Point(162, 158);
            btnModificarModificar.Name = "btnModificarModificar";
            btnModificarModificar.Size = new Size(78, 33);
            btnModificarModificar.TabIndex = 15;
            btnModificarModificar.Text = "Modificar";
            btnModificarModificar.UseVisualStyleBackColor = true;
            btnModificarModificar.Click += btnModificarModificar_Click;
            // 
            // gbxFuncionarioModificarLista
            // 
            gbxFuncionarioModificarLista.Controls.Add(lvListaFuncionarios);
            gbxFuncionarioModificarLista.Dock = DockStyle.Bottom;
            gbxFuncionarioModificarLista.Location = new Point(0, 352);
            gbxFuncionarioModificarLista.Name = "gbxFuncionarioModificarLista";
            gbxFuncionarioModificarLista.Size = new Size(774, 309);
            gbxFuncionarioModificarLista.TabIndex = 19;
            gbxFuncionarioModificarLista.TabStop = false;
            gbxFuncionarioModificarLista.Text = "Lista funcionarios";
            // 
            // lvListaFuncionarios
            // 
            lvListaFuncionarios.BackColor = SystemColors.Info;
            lvListaFuncionarios.Columns.AddRange(new ColumnHeader[] { colIdentificacion, colNombre, colApellidoPrimero, colApellidoSegundo, colEmail, colCodigoFuncionario, colContrasenia, colEstado });
            lvListaFuncionarios.Dock = DockStyle.Fill;
            lvListaFuncionarios.Location = new Point(3, 19);
            lvListaFuncionarios.Name = "lvListaFuncionarios";
            lvListaFuncionarios.Size = new Size(768, 287);
            lvListaFuncionarios.TabIndex = 20;
            lvListaFuncionarios.UseCompatibleStateImageBehavior = false;
            lvListaFuncionarios.View = View.Details;
            lvListaFuncionarios.SelectedIndexChanged += lvListaFuncionarios_SelectedIndexChanged_1;
            // 
            // colIdentificacion
            // 
            colIdentificacion.Text = "Identificacion";
            colIdentificacion.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 100;
            // 
            // colApellidoPrimero
            // 
            colApellidoPrimero.Text = "PrimerApelledio";
            colApellidoPrimero.Width = 100;
            // 
            // colApellidoSegundo
            // 
            colApellidoSegundo.Text = "SegundoApellido";
            colApellidoSegundo.Width = 120;
            // 
            // colEmail
            // 
            colEmail.Text = "Email";
            colEmail.Width = 100;
            // 
            // colCodigoFuncionario
            // 
            colCodigoFuncionario.Text = "Cod. Funcionario";
            colCodigoFuncionario.Width = 120;
            // 
            // colContrasenia
            // 
            colContrasenia.Text = "Contrasenia";
            colContrasenia.Width = 100;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 100;
            // 
            // frmModificacionFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(774, 661);
            Controls.Add(gbxFuncionarioModificarLista);
            Controls.Add(gbxModificarFuncionarioDatos);
            Controls.Add(gbxModificacion);
            MinimumSize = new Size(790, 700);
            Name = "frmModificacionFuncionarios";
            Text = "Modificacion Funcionarios";
            Load += frmModificacionFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxModificacion.ResumeLayout(false);
            gbxConsultaFuncionario.ResumeLayout(false);
            gbxConsultaFuncionario.PerformLayout();
            gbxModificarFuncionarioDatos.ResumeLayout(false);
            gbxModificarFuncionarioDatos.PerformLayout();
            gbxFuncionarioModificarLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtFuncionarioCodigo;
        private TextBox txtFuncionarioEmail;
        private TextBox txtFuncionarioDNI;
        private TextBox txtFuncionarioApellidoSegundo;
        private TextBox txtFuncionarioApellidoPrimero;
        private TextBox txtFuncionarioNombre;
        private Label lblFuncionarioEmail;
        private Label lblFuncionarioCodigo;
        private Label lblFuncionarioDNI;
        private Label lblFuncionarioApellidoSegundo;
        private Label lblFuncionarioApellidoPrimero;
        private Label lblFuncionarioNombre;
        private PictureBox pbLogo;
        private Label lblFuncionarioTitulo;
        private GroupBox gbxModificacion;
        private GroupBox gbxModificarFuncionarioDatos;
        private TextBox txtFuncionarioConsulta;
        private GroupBox gbxFuncionarioModificarLista;
        private Button btnModificarCancelar;
        private Button btnModifcarLimpiar;
        private Button btnModificarModificar;
        private GroupBox gbxConsultaFuncionario;
        private Label lblFuncionarioEstado;
        private RadioButton rbtnEstadoActivo;
        private RadioButton rbtnEstadoInactivo;
        private Button btnModificarConsutar;
        private Button btnModificarActualizar;
        private ListView lvListaFuncionarios;
        private ColumnHeader colIdentificacion;
        private ColumnHeader colNombre;
        private ColumnHeader colApellidoPrimero;
        private ColumnHeader colApellidoSegundo;
        private ColumnHeader colEmail;
        private ColumnHeader colCodigoFuncionario;
        private ColumnHeader colContrasenia;
        private ColumnHeader colEstado;
        private TextBox txtModificarContrasenia;
        private Label lblModificarContrasenia;
    }
}