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
            lblFuncionarioCodigo = new Label();
            lblFuncionarioEmail = new Label();
            txtFuncionarioNombre = new TextBox();
            txtFuncionarioApellidoPrimero = new TextBox();
            txtFuncionarioApellidoSegundo = new TextBox();
            txtFuncionarioDNI = new TextBox();
            txtFuncionarioEmail = new TextBox();
            txtFuncionarioCodigo = new TextBox();
            btnFuncionarioAceptar = new Button();
            btnFuncionarioCancelar = new Button();
            pbLogo = new PictureBox();
            btnFuncionarioLimpiar = new Button();
            lblFuncionarioTitulo = new Label();
            gbxRegistroFuncionariosTitulo = new GroupBox();
            gbxRegistroFuncionariosDatos = new GroupBox();
            lblFuncionarioEstado = new Label();
            rbtnEstadoActivo = new RadioButton();
            gbListaFuncionarios = new GroupBox();
            dgvRegistroListaFuncionarios = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellidoPrimero = new DataGridViewTextBoxColumn();
            colSegundoApellido = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colCodFuncionario = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            ColEstado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxRegistroFuncionariosTitulo.SuspendLayout();
            gbxRegistroFuncionariosDatos.SuspendLayout();
            gbListaFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // lblFuncionarioNombre
            // 
            lblFuncionarioNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioNombre.Location = new Point(102, 32);
            lblFuncionarioNombre.Name = "lblFuncionarioNombre";
            lblFuncionarioNombre.Size = new Size(168, 22);
            lblFuncionarioNombre.TabIndex = 0;
            lblFuncionarioNombre.Text = "Nombre";
            lblFuncionarioNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoPrimero
            // 
            lblFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoPrimero.Location = new Point(102, 73);
            lblFuncionarioApellidoPrimero.Name = "lblFuncionarioApellidoPrimero";
            lblFuncionarioApellidoPrimero.Size = new Size(168, 22);
            lblFuncionarioApellidoPrimero.TabIndex = 1;
            lblFuncionarioApellidoPrimero.Text = "Primer Apellido";
            lblFuncionarioApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoSegundo
            // 
            lblFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoSegundo.Location = new Point(102, 108);
            lblFuncionarioApellidoSegundo.Name = "lblFuncionarioApellidoSegundo";
            lblFuncionarioApellidoSegundo.Size = new Size(168, 22);
            lblFuncionarioApellidoSegundo.TabIndex = 2;
            lblFuncionarioApellidoSegundo.Text = "Segundo Apellido";
            lblFuncionarioApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioDNI
            // 
            lblFuncionarioDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioDNI.Location = new Point(102, 143);
            lblFuncionarioDNI.Name = "lblFuncionarioDNI";
            lblFuncionarioDNI.Size = new Size(168, 22);
            lblFuncionarioDNI.TabIndex = 3;
            lblFuncionarioDNI.Text = "Identificacion";
            lblFuncionarioDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioCodigo
            // 
            lblFuncionarioCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioCodigo.Location = new Point(102, 178);
            lblFuncionarioCodigo.Name = "lblFuncionarioCodigo";
            lblFuncionarioCodigo.Size = new Size(168, 22);
            lblFuncionarioCodigo.TabIndex = 4;
            lblFuncionarioCodigo.Text = "Codigo de Funcionario";
            lblFuncionarioCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioEmail
            // 
            lblFuncionarioEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEmail.Location = new Point(102, 213);
            lblFuncionarioEmail.Name = "lblFuncionarioEmail";
            lblFuncionarioEmail.Size = new Size(168, 22);
            lblFuncionarioEmail.TabIndex = 5;
            lblFuncionarioEmail.Text = "Correo Electronico";
            lblFuncionarioEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtFuncionarioNombre
            // 
            txtFuncionarioNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioNombre.Location = new Point(276, 32);
            txtFuncionarioNombre.Name = "txtFuncionarioNombre";
            txtFuncionarioNombre.Size = new Size(211, 29);
            txtFuncionarioNombre.TabIndex = 1;
            txtFuncionarioNombre.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioNombre.KeyPress += txtFuncionarioNombre_KeyPress;
            // 
            // txtFuncionarioApellidoPrimero
            // 
            txtFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoPrimero.Location = new Point(276, 73);
            txtFuncionarioApellidoPrimero.Name = "txtFuncionarioApellidoPrimero";
            txtFuncionarioApellidoPrimero.Size = new Size(211, 29);
            txtFuncionarioApellidoPrimero.TabIndex = 2;
            txtFuncionarioApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoPrimero.KeyPress += txtFuncionarioApellidoPrimero_KeyPress;
            // 
            // txtFuncionarioApellidoSegundo
            // 
            txtFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoSegundo.Location = new Point(276, 108);
            txtFuncionarioApellidoSegundo.Name = "txtFuncionarioApellidoSegundo";
            txtFuncionarioApellidoSegundo.Size = new Size(211, 29);
            txtFuncionarioApellidoSegundo.TabIndex = 3;
            txtFuncionarioApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioApellidoSegundo.KeyPress += txtFuncionarioApellidoSegundo_KeyPress;
            // 
            // txtFuncionarioDNI
            // 
            txtFuncionarioDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioDNI.Location = new Point(276, 143);
            txtFuncionarioDNI.Name = "txtFuncionarioDNI";
            txtFuncionarioDNI.Size = new Size(211, 29);
            txtFuncionarioDNI.TabIndex = 4;
            txtFuncionarioDNI.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioDNI.KeyPress += txtFuncionarioDNI_KeyPress;
            // 
            // txtFuncionarioEmail
            // 
            txtFuncionarioEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioEmail.Location = new Point(276, 213);
            txtFuncionarioEmail.Name = "txtFuncionarioEmail";
            txtFuncionarioEmail.Size = new Size(211, 29);
            txtFuncionarioEmail.TabIndex = 6;
            txtFuncionarioEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioCodigo
            // 
            txtFuncionarioCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioCodigo.Location = new Point(276, 178);
            txtFuncionarioCodigo.Name = "txtFuncionarioCodigo";
            txtFuncionarioCodigo.Size = new Size(211, 29);
            txtFuncionarioCodigo.TabIndex = 5;
            txtFuncionarioCodigo.TextAlign = HorizontalAlignment.Center;
            txtFuncionarioCodigo.KeyPress += txtFuncionarioCodigo_KeyPress;
            // 
            // btnFuncionarioAceptar
            // 
            btnFuncionarioAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioAceptar.Location = new Point(102, 281);
            btnFuncionarioAceptar.Name = "btnFuncionarioAceptar";
            btnFuncionarioAceptar.Size = new Size(117, 30);
            btnFuncionarioAceptar.TabIndex = 7;
            btnFuncionarioAceptar.Text = "Aceptar";
            btnFuncionarioAceptar.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarioCancelar
            // 
            btnFuncionarioCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioCancelar.Location = new Point(383, 281);
            btnFuncionarioCancelar.Name = "btnFuncionarioCancelar";
            btnFuncionarioCancelar.Size = new Size(117, 30);
            btnFuncionarioCancelar.TabIndex = 9;
            btnFuncionarioCancelar.Text = "Cancelar";
            btnFuncionarioCancelar.UseVisualStyleBackColor = true;
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
            // btnFuncionarioLimpiar
            // 
            btnFuncionarioLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFuncionarioLimpiar.Location = new Point(240, 281);
            btnFuncionarioLimpiar.Name = "btnFuncionarioLimpiar";
            btnFuncionarioLimpiar.Size = new Size(117, 30);
            btnFuncionarioLimpiar.TabIndex = 8;
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
            gbxRegistroFuncionariosTitulo.Size = new Size(664, 159);
            gbxRegistroFuncionariosTitulo.TabIndex = 1;
            gbxRegistroFuncionariosTitulo.TabStop = false;
            // 
            // gbxRegistroFuncionariosDatos
            // 
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
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioCodigo);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioCodigo);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(lblFuncionarioEmail);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioDNI);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioApellidoPrimero);
            gbxRegistroFuncionariosDatos.Controls.Add(txtFuncionarioApellidoSegundo);
            gbxRegistroFuncionariosDatos.Dock = DockStyle.Fill;
            gbxRegistroFuncionariosDatos.Location = new Point(0, 159);
            gbxRegistroFuncionariosDatos.Name = "gbxRegistroFuncionariosDatos";
            gbxRegistroFuncionariosDatos.Size = new Size(664, 502);
            gbxRegistroFuncionariosDatos.TabIndex = 2;
            gbxRegistroFuncionariosDatos.TabStop = false;
            gbxRegistroFuncionariosDatos.Text = "Datos Funcionarios";
            // 
            // lblFuncionarioEstado
            // 
            lblFuncionarioEstado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEstado.Location = new Point(102, 248);
            lblFuncionarioEstado.Name = "lblFuncionarioEstado";
            lblFuncionarioEstado.Size = new Size(168, 22);
            lblFuncionarioEstado.TabIndex = 22;
            lblFuncionarioEstado.Text = "Estado";
            lblFuncionarioEstado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rbtnEstadoActivo
            // 
            rbtnEstadoActivo.AutoSize = true;
            rbtnEstadoActivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbtnEstadoActivo.Location = new Point(276, 248);
            rbtnEstadoActivo.Name = "rbtnEstadoActivo";
            rbtnEstadoActivo.Size = new Size(71, 25);
            rbtnEstadoActivo.TabIndex = 21;
            rbtnEstadoActivo.TabStop = true;
            rbtnEstadoActivo.Text = "Activo";
            rbtnEstadoActivo.UseVisualStyleBackColor = true;
            // 
            // gbListaFuncionarios
            // 
            gbListaFuncionarios.Controls.Add(dgvRegistroListaFuncionarios);
            gbListaFuncionarios.Dock = DockStyle.Bottom;
            gbListaFuncionarios.Location = new Point(0, 506);
            gbListaFuncionarios.Name = "gbListaFuncionarios";
            gbListaFuncionarios.Size = new Size(664, 155);
            gbListaFuncionarios.TabIndex = 3;
            gbListaFuncionarios.TabStop = false;
            gbListaFuncionarios.Text = "Lista de Funcionarios";
            // 
            // dgvRegistroListaFuncionarios
            // 
            dgvRegistroListaFuncionarios.AllowUserToDeleteRows = false;
            dgvRegistroListaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRegistroListaFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellidoPrimero, colSegundoApellido, colDNI, colCodFuncionario, colEmail, ColEstado });
            dgvRegistroListaFuncionarios.Dock = DockStyle.Fill;
            dgvRegistroListaFuncionarios.Location = new Point(3, 19);
            dgvRegistroListaFuncionarios.Name = "dgvRegistroListaFuncionarios";
            dgvRegistroListaFuncionarios.ReadOnly = true;
            dgvRegistroListaFuncionarios.RowTemplate.Height = 25;
            dgvRegistroListaFuncionarios.Size = new Size(658, 133);
            dgvRegistroListaFuncionarios.TabIndex = 9;
            // 
            // colNombre
            // 
            colNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            // 
            // colApellidoPrimero
            // 
            colApellidoPrimero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colApellidoPrimero.HeaderText = "Primer Apellido";
            colApellidoPrimero.Name = "colApellidoPrimero";
            colApellidoPrimero.ReadOnly = true;
            // 
            // colSegundoApellido
            // 
            colSegundoApellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSegundoApellido.HeaderText = "Segundo Apellido";
            colSegundoApellido.Name = "colSegundoApellido";
            colSegundoApellido.ReadOnly = true;
            // 
            // colDNI
            // 
            colDNI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDNI.HeaderText = "Identificacion";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            // 
            // colCodFuncionario
            // 
            colCodFuncionario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCodFuncionario.HeaderText = "Codigo Funcionario";
            colCodFuncionario.Name = "colCodFuncionario";
            colCodFuncionario.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // ColEstado
            // 
            ColEstado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColEstado.HeaderText = "Estado";
            ColEstado.Name = "ColEstado";
            ColEstado.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxRegistroFuncionariosTitulo.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.ResumeLayout(false);
            gbxRegistroFuncionariosDatos.PerformLayout();
            gbListaFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroListaFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFuncionarioNombre;
        private Label lblFuncionarioApellidoPrimero;
        private Label lblFuncionarioApellidoSegundo;
        private Label lblFuncionarioDNI;
        private Label lblFuncionarioCodigo;
        private Label lblFuncionarioEmail;
        private TextBox txtFuncionarioNombre;
        private TextBox txtFuncionarioApellidoPrimero;
        private TextBox txtFuncionarioApellidoSegundo;
        private TextBox txtFuncionarioDNI;
        private TextBox txtFuncionarioEmail;
        private TextBox txtFuncionarioCodigo;
        private Button btnFuncionarioAceptar;
        private Button btnFuncionarioCancelar;
        private PictureBox pbLogo;
        private Button btnFuncionarioLimpiar;
        private Label lblFuncionarioTitulo;
        private GroupBox gbxRegistroFuncionariosTitulo;
        private GroupBox gbxRegistroFuncionariosDatos;
        private GroupBox gbListaFuncionarios;
        private DataGridView dgvRegistroListaFuncionarios;
        private Label lblFuncionarioEstado;
        private RadioButton rbtnEstadoActivo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellidoPrimero;
        private DataGridViewTextBoxColumn colSegundoApellido;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colCodFuncionario;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn ColEstado;
    }
}