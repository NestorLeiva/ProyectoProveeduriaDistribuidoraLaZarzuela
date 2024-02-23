namespace Proveeduria
{
    partial class frmRegistroFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroFuncionarios));
            lblFuncionarioNombre = new Label();
            lblFuncionarioApellidoPrimero = new Label();
            lblFuncionarioApellidoSegundo = new Label();
            lblFuncionarioDNI = new Label();
            txtFuncionarioNombre = new TextBox();
            txtFuncionarioApellidoPrimero = new TextBox();
            txtFuncionarioApellidoSegundo = new TextBox();
            txtFuncionarioDNI = new TextBox();
            btnFuncionarioAceptar = new Button();
            btnFuncionarioCancelar = new Button();
            pbLogo = new PictureBox();
            btnFuncionarioLimpiar = new Button();
            lblFuncionarioTitulo = new Label();
            gbxRegistroFuncionariosTitulo = new GroupBox();
            gbxRegistroFuncionariosDatos = new GroupBox();
            txtFuncionarioContrasenia = new TextBox();
            lblFuncionarioContrasenia = new Label();
            lblFuncionarioEstado = new Label();
            rbtnEstadoActivo = new RadioButton();
            gbListaFuncionarios = new GroupBox();
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
            gbxRegistroFuncionariosTitulo.SuspendLayout();
            gbxRegistroFuncionariosDatos.SuspendLayout();
            gbListaFuncionarios.SuspendLayout();
            SuspendLayout();
            // 
            // lblFuncionarioNombre
            // 
            lblFuncionarioNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioNombre.Location = new Point(49, 22);
            lblFuncionarioNombre.Name = "lblFuncionarioNombre";
            lblFuncionarioNombre.Size = new Size(130, 22);
            lblFuncionarioNombre.TabIndex = 0;
            lblFuncionarioNombre.Text = "Nombre";
            lblFuncionarioNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoPrimero
            // 
            lblFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoPrimero.Location = new Point(49, 63);
            lblFuncionarioApellidoPrimero.Name = "lblFuncionarioApellidoPrimero";
            lblFuncionarioApellidoPrimero.Size = new Size(130, 22);
            lblFuncionarioApellidoPrimero.TabIndex = 1;
            lblFuncionarioApellidoPrimero.Text = "Primer Apellido";
            lblFuncionarioApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoSegundo
            // 
            lblFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoSegundo.Location = new Point(49, 98);
            lblFuncionarioApellidoSegundo.Name = "lblFuncionarioApellidoSegundo";
            lblFuncionarioApellidoSegundo.Size = new Size(130, 22);
            lblFuncionarioApellidoSegundo.TabIndex = 2;
            lblFuncionarioApellidoSegundo.Text = "Segundo Apellido";
            lblFuncionarioApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioDNI
            // 
            lblFuncionarioDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioDNI.Location = new Point(50, 135);
            lblFuncionarioDNI.Name = "lblFuncionarioDNI";
            lblFuncionarioDNI.Size = new Size(130, 22);
            lblFuncionarioDNI.TabIndex = 3;
            lblFuncionarioDNI.Text = "Identificacion";
            lblFuncionarioDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFuncionarioNombre
            // 
            txtFuncionarioNombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioNombre.Location = new Point(185, 22);
            txtFuncionarioNombre.Name = "txtFuncionarioNombre";
            txtFuncionarioNombre.Size = new Size(211, 27);
            txtFuncionarioNombre.TabIndex = 1;
            txtFuncionarioNombre.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioNombre.KeyPress += txtFuncionarioNombre_KeyPress;
            // 
            // txtFuncionarioApellidoPrimero
            // 
            txtFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoPrimero.Location = new Point(185, 63);
            txtFuncionarioApellidoPrimero.Name = "txtFuncionarioApellidoPrimero";
            txtFuncionarioApellidoPrimero.Size = new Size(211, 27);
            txtFuncionarioApellidoPrimero.TabIndex = 2;
            txtFuncionarioApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoPrimero.KeyPress += txtFuncionarioApellidoPrimero_KeyPress;
            // 
            // txtFuncionarioApellidoSegundo
            // 
            txtFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoSegundo.Location = new Point(185, 98);
            txtFuncionarioApellidoSegundo.Name = "txtFuncionarioApellidoSegundo";
            txtFuncionarioApellidoSegundo.Size = new Size(211, 27);
            txtFuncionarioApellidoSegundo.TabIndex = 3;
            txtFuncionarioApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoSegundo.KeyPress += txtFuncionarioApellidoSegundo_KeyPress;
            // 
            // txtFuncionarioDNI
            // 
            txtFuncionarioDNI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioDNI.Location = new Point(185, 133);
            txtFuncionarioDNI.MaxLength = 10;
            txtFuncionarioDNI.Name = "txtFuncionarioDNI";
            txtFuncionarioDNI.Size = new Size(211, 27);
            txtFuncionarioDNI.TabIndex = 4;
            txtFuncionarioDNI.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioDNI.KeyPress += txtFuncionarioDNI_KeyPress;
            // 
            // btnFuncionarioAceptar
            // 
            btnFuncionarioAceptar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioAceptar.Location = new Point(421, 22);
            btnFuncionarioAceptar.Name = "btnFuncionarioAceptar";
            btnFuncionarioAceptar.Size = new Size(117, 30);
            btnFuncionarioAceptar.TabIndex = 8;
            btnFuncionarioAceptar.Text = "Aceptar";
            btnFuncionarioAceptar.UseVisualStyleBackColor = true;
            btnFuncionarioAceptar.Click += btnFuncionarioAceptar_Click;
            // 
            // btnFuncionarioCancelar
            // 
            btnFuncionarioCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioCancelar.Location = new Point(421, 168);
            btnFuncionarioCancelar.Name = "btnFuncionarioCancelar";
            btnFuncionarioCancelar.Size = new Size(117, 30);
            btnFuncionarioCancelar.TabIndex = 10;
            btnFuncionarioCancelar.Text = "Cancelar";
            btnFuncionarioCancelar.UseVisualStyleBackColor = true;
            btnFuncionarioCancelar.Click += btnFuncionarioCancelar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(6, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(154, 111);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // btnFuncionarioLimpiar
            // 
            btnFuncionarioLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioLimpiar.Location = new Point(421, 58);
            btnFuncionarioLimpiar.Name = "btnFuncionarioLimpiar";
            btnFuncionarioLimpiar.Size = new Size(117, 30);
            btnFuncionarioLimpiar.TabIndex = 9;
            btnFuncionarioLimpiar.Text = "Limpiar";
            btnFuncionarioLimpiar.UseVisualStyleBackColor = true;
            btnFuncionarioLimpiar.Click += btnFuncionarioLimpiar_Click;
            // 
            // lblFuncionarioTitulo
            // 
            lblFuncionarioTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioTitulo.Location = new Point(218, 51);
            lblFuncionarioTitulo.Name = "lblFuncionarioTitulo";
            lblFuncionarioTitulo.Size = new Size(253, 31);
            lblFuncionarioTitulo.TabIndex = 16;
            lblFuncionarioTitulo.Text = "Registro de Funcionarios";
            lblFuncionarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxRegistroFuncionariosTitulo
            // 
            gbxRegistroFuncionariosTitulo.Controls.Add(pbLogo);
            gbxRegistroFuncionariosTitulo.Controls.Add(lblFuncionarioTitulo);
            gbxRegistroFuncionariosTitulo.Dock = DockStyle.Top;
            gbxRegistroFuncionariosTitulo.Location = new Point(0, 0);
            gbxRegistroFuncionariosTitulo.Name = "gbxRegistroFuncionariosTitulo";
            gbxRegistroFuncionariosTitulo.Size = new Size(664, 131);
            gbxRegistroFuncionariosTitulo.TabIndex = 1;
            gbxRegistroFuncionariosTitulo.TabStop = false;
            // 
            // gbxRegistroFuncionariosDatos
            // 
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioContrasenia);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioContrasenia);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioEstado);
            gbxRegistroFuncionariosDatos.Controls.Add(rbtnEstadoActivo);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioNombre);
            gbxRegistroFuncionariosDatos.Controls.Add(btnFuncionarioCancelar);
            gbxRegistroFuncionariosDatos.Controls.Add(btnFuncionarioLimpiar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioApellidoPrimero);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioApellidoSegundo);
            gbxRegistroFuncionariosDatos.Controls.Add(btnFuncionarioAceptar);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioApellidoPrimero);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioApellidoSegundo);
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Fill;
            gbxRegistroFuncionariosDatos.Location = new Point(0, 131);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(664, 530);
            gbxRegistroFuncionariosDatos.TabIndex = 2;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Funcionarios";
            // 
            // txtFuncionarioContrasenia
            // 
            txtFuncionarioContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioContrasenia.Location = new Point(185, 168);
            txtFuncionarioContrasenia.Name = "txtFuncionarioContrasenia";
            txtFuncionarioContrasenia.Size = new Size(211, 27);
            txtFuncionarioContrasenia.TabIndex = 6;
            txtFuncionarioContrasenia.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioContrasenia.KeyPress += txtFuncionarioContrasenia_KeyPress;
            // 
            // lblFuncionarioContrasenia
            // 
            lblFuncionarioContrasenia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioContrasenia.Location = new Point(49, 170);
            lblFuncionarioContrasenia.Name = "lblFuncionarioContrasenia";
            lblFuncionarioContrasenia.Size = new Size(130, 22);
            lblFuncionarioContrasenia.TabIndex = 23;
            lblFuncionarioContrasenia.Text = "Contrasenia";
            lblFuncionarioContrasenia.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioEstado
            // 
            lblFuncionarioEstado.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEstado.Location = new Point(48, 203);
            lblFuncionarioEstado.Name = "lblFuncionarioEstado";
            lblFuncionarioEstado.Size = new Size(130, 22);
            lblFuncionarioEstado.TabIndex = 22;
            lblFuncionarioEstado.Text = "Estado";
            lblFuncionarioEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtnEstadoActivo
            // 
            rbtnEstadoActivo.AutoSize = true;
            rbtnEstadoActivo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnEstadoActivo.Location = new Point(184, 203);
            rbtnEstadoActivo.Name = "rbtnEstadoActivo";
            rbtnEstadoActivo.Size = new Size(69, 24);
            rbtnEstadoActivo.TabIndex = 7;
            rbtnEstadoActivo.TabStop = true;
            rbtnEstadoActivo.Text = "Activo";
            rbtnEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // gbListaFuncionarios
            // 
            gbListaFuncionarios.Controls.Add(lvListaFuncionarios);
            gbListaFuncionarios.Dock = DockStyle.Bottom;
            gbListaFuncionarios.Location = new Point(0, 378);
            gbListaFuncionarios.Name = "gbListaFuncionarios";
            gbListaFuncionarios.Size = new Size(664, 283);
            gbListaFuncionarios.TabIndex = 11;
            gbListaFuncionarios.TabStop = false;
            gbListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // lvListaFuncionarios
            // 
            lvListaFuncionarios.BackColor = SystemColors.Info;
            lvListaFuncionarios.Columns.AddRange(new ColumnHeader[] { colIdentificacion, colNombre, colApellidoPrimero, colApellidoSegundo, colEmail, colCodigoFuncionario, colContrasenia, colEstado });
            lvListaFuncionarios.Dock = DockStyle.Fill;
            lvListaFuncionarios.Location = new Point(3, 19);
            lvListaFuncionarios.Name = "lvListaFuncionarios";
            lvListaFuncionarios.Size = new Size(658, 261);
            lvListaFuncionarios.TabIndex = 0;
            lvListaFuncionarios.UseCompatibleStateImageBehavior = false;
            lvListaFuncionarios.View = View.Details;
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
            // frmRegistroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 661);
            Controls.Add(gbListaFuncionarios);
            Controls.Add(gbxRegistroFuncionariosDatos);
            Controls.Add(gbxRegistroFuncionariosTitulo);
            MinimumSize = new Size(680, 700);
            Name = "frmRegistroFuncionarios";
            Text = "Registro de Funcionarios ";
            Load += frmRegistroFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroFuncionariosTitulo.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.PerformLayout();
            gbListaFuncionarios.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblFuncionarioNombre;
        private Label lblFuncionarioApellidoPrimero;
        private Label lblFuncionarioApellidoSegundo;
        private Label lblFuncionarioDNI;
        private TextBox txtFuncionarioNombre;
        private TextBox txtFuncionarioApellidoPrimero;
        private TextBox txtFuncionarioApellidoSegundo;
        private TextBox txtFuncionarioDNI;
        private Button btnFuncionarioAceptar;
        private Button btnFuncionarioCancelar;
        private PictureBox pbLogo;
        private Button btnFuncionarioLimpiar;
        private Label lblFuncionarioTitulo;
        private GroupBox gbxRegistroFuncionariosTitulo;
        private GroupBox gbxRegistroFuncionariosDatos;
        private GroupBox gbListaFuncionarios;
        private Label lblFuncionarioEstado;
        private RadioButton rbtnEstadoActivo;
        private TextBox txtFuncionarioContrasenia;
        private Label lblFuncionarioContrasenia;
        private ListView lvListaFuncionarios;
        private ColumnHeader colIdentificacion;
        private ColumnHeader colNombre;
        private ColumnHeader colApellidoPrimero;
        private ColumnHeader colApellidoSegundo;
        private ColumnHeader colEmail;
        private ColumnHeader colCodigoFuncionario;
        private ColumnHeader colContrasenia;
        private ColumnHeader colEstado;
    }
}