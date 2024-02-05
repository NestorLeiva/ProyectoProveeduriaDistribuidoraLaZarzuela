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
            dgvListaFuncionarios = new DataGridView();
            colNombre = new DataGridViewTextBoxColumn();
            colApellidoPrimero = new DataGridViewTextBoxColumn();
            colSegundoApellido = new DataGridViewTextBoxColumn();
            colDNI = new DataGridViewTextBoxColumn();
            colCodFuncionario = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
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
            txtFuncionarioConsulta = new TextBox();
            lblFuncionarioConsulta = new Label();
            gbxModificarFuncionarioDatos = new GroupBox();
            btnModificarCancelar = new Button();
            btnModifcarLimpiar = new Button();
            btnModificarFuncionario = new Button();
            gbxFuncionarioModificarLista = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvListaFuncionarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxModificacion.SuspendLayout();
            gbxModificarFuncionarioDatos.SuspendLayout();
            gbxFuncionarioModificarLista.SuspendLayout();
            SuspendLayout();
            // 
            // dgvListaFuncionarios
            // 
            dgvListaFuncionarios.AllowUserToDeleteRows = false;
            dgvListaFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvListaFuncionarios.Columns.AddRange(new DataGridViewColumn[] { colNombre, colApellidoPrimero, colSegundoApellido, colDNI, colCodFuncionario, colEmail });
            dgvListaFuncionarios.Dock = DockStyle.Fill;
            dgvListaFuncionarios.Location = new Point(3, 19);
            dgvListaFuncionarios.Name = "dgvListaFuncionarios";
            dgvListaFuncionarios.RowTemplate.Height = 25;
            dgvListaFuncionarios.Size = new Size(588, 194);
            dgvListaFuncionarios.TabIndex = 8;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.Width = 76;
            // 
            // colApellidoPrimero
            // 
            colApellidoPrimero.HeaderText = "Primer Apellido";
            colApellidoPrimero.Name = "colApellidoPrimero";
            colApellidoPrimero.Width = 114;
            // 
            // colSegundoApellido
            // 
            colSegundoApellido.HeaderText = "Segundo Apellido";
            colSegundoApellido.Name = "colSegundoApellido";
            colSegundoApellido.Width = 126;
            // 
            // colDNI
            // 
            colDNI.HeaderText = "Identificacion";
            colDNI.Name = "colDNI";
            colDNI.ReadOnly = true;
            colDNI.Width = 104;
            // 
            // colCodFuncionario
            // 
            colCodFuncionario.HeaderText = "Codigo Funcionario";
            colCodFuncionario.Name = "colCodFuncionario";
            colCodFuncionario.ReadOnly = true;
            colCodFuncionario.Width = 137;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.Width = 61;
            // 
            // txtFuncionarioCodigo
            // 
            txtFuncionarioCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioCodigo.Location = new Point(246, 161);
            txtFuncionarioCodigo.Name = "txtFuncionarioCodigo";
            txtFuncionarioCodigo.ReadOnly = true;
            txtFuncionarioCodigo.Size = new Size(254, 29);
            txtFuncionarioCodigo.TabIndex = 6;
            txtFuncionarioCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioEmail
            // 
            txtFuncionarioEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioEmail.Location = new Point(246, 196);
            txtFuncionarioEmail.Name = "txtFuncionarioEmail";
            txtFuncionarioEmail.Size = new Size(254, 29);
            txtFuncionarioEmail.TabIndex = 7;
            txtFuncionarioEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioDNI
            // 
            txtFuncionarioDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioDNI.Location = new Point(246, 126);
            txtFuncionarioDNI.Name = "txtFuncionarioDNI";
            txtFuncionarioDNI.ReadOnly = true;
            txtFuncionarioDNI.Size = new Size(254, 29);
            txtFuncionarioDNI.TabIndex = 5;
            txtFuncionarioDNI.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioApellidoSegundo
            // 
            txtFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoSegundo.Location = new Point(246, 91);
            txtFuncionarioApellidoSegundo.Name = "txtFuncionarioApellidoSegundo";
            txtFuncionarioApellidoSegundo.Size = new Size(254, 29);
            txtFuncionarioApellidoSegundo.TabIndex = 4;
            txtFuncionarioApellidoSegundo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioApellidoPrimero
            // 
            txtFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioApellidoPrimero.Location = new Point(246, 56);
            txtFuncionarioApellidoPrimero.Name = "txtFuncionarioApellidoPrimero";
            txtFuncionarioApellidoPrimero.Size = new Size(254, 29);
            txtFuncionarioApellidoPrimero.TabIndex = 3;
            txtFuncionarioApellidoPrimero.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFuncionarioNombre
            // 
            txtFuncionarioNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioNombre.Location = new Point(246, 22);
            txtFuncionarioNombre.Name = "txtFuncionarioNombre";
            txtFuncionarioNombre.Size = new Size(254, 29);
            txtFuncionarioNombre.TabIndex = 2;
            txtFuncionarioNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFuncionarioEmail
            // 
            lblFuncionarioEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioEmail.Location = new Point(59, 203);
            lblFuncionarioEmail.Name = "lblFuncionarioEmail";
            lblFuncionarioEmail.Size = new Size(168, 22);
            lblFuncionarioEmail.TabIndex = 17;
            lblFuncionarioEmail.Text = "Correo Electronico";
            lblFuncionarioEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioCodigo
            // 
            lblFuncionarioCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioCodigo.Location = new Point(59, 168);
            lblFuncionarioCodigo.Name = "lblFuncionarioCodigo";
            lblFuncionarioCodigo.Size = new Size(168, 22);
            lblFuncionarioCodigo.TabIndex = 16;
            lblFuncionarioCodigo.Text = "Codigo de Funcionario";
            lblFuncionarioCodigo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioDNI
            // 
            lblFuncionarioDNI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioDNI.Location = new Point(59, 133);
            lblFuncionarioDNI.Name = "lblFuncionarioDNI";
            lblFuncionarioDNI.Size = new Size(168, 22);
            lblFuncionarioDNI.TabIndex = 15;
            lblFuncionarioDNI.Text = "Identificacion";
            lblFuncionarioDNI.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoSegundo
            // 
            lblFuncionarioApellidoSegundo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoSegundo.Location = new Point(59, 98);
            lblFuncionarioApellidoSegundo.Name = "lblFuncionarioApellidoSegundo";
            lblFuncionarioApellidoSegundo.Size = new Size(168, 22);
            lblFuncionarioApellidoSegundo.TabIndex = 14;
            lblFuncionarioApellidoSegundo.Text = "Segundo Apellido";
            lblFuncionarioApellidoSegundo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioApellidoPrimero
            // 
            lblFuncionarioApellidoPrimero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioApellidoPrimero.Location = new Point(59, 63);
            lblFuncionarioApellidoPrimero.Name = "lblFuncionarioApellidoPrimero";
            lblFuncionarioApellidoPrimero.Size = new Size(168, 22);
            lblFuncionarioApellidoPrimero.TabIndex = 13;
            lblFuncionarioApellidoPrimero.Text = "Primer Apellido";
            lblFuncionarioApellidoPrimero.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblFuncionarioNombre
            // 
            lblFuncionarioNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioNombre.Location = new Point(59, 29);
            lblFuncionarioNombre.Name = "lblFuncionarioNombre";
            lblFuncionarioNombre.Size = new Size(168, 22);
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
            lblFuncionarioTitulo.Location = new Point(204, 22);
            lblFuncionarioTitulo.Name = "lblFuncionarioTitulo";
            lblFuncionarioTitulo.Size = new Size(296, 31);
            lblFuncionarioTitulo.TabIndex = 25;
            lblFuncionarioTitulo.Text = "Modificacion de Funcionarios";
            lblFuncionarioTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxModificacion
            // 
            gbxModificacion.Controls.Add(txtFuncionarioConsulta);
            gbxModificacion.Controls.Add(lblFuncionarioConsulta);
            gbxModificacion.Controls.Add(pbLogo);
            gbxModificacion.Controls.Add(lblFuncionarioTitulo);
            gbxModificacion.Dock = DockStyle.Top;
            gbxModificacion.Location = new Point(0, 0);
            gbxModificacion.Name = "gbxModificacion";
            gbxModificacion.Size = new Size(594, 155);
            gbxModificacion.TabIndex = 26;
            gbxModificacion.TabStop = false;
            // 
            // txtFuncionarioConsulta
            // 
            txtFuncionarioConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFuncionarioConsulta.Location = new Point(226, 93);
            txtFuncionarioConsulta.Name = "txtFuncionarioConsulta";
            txtFuncionarioConsulta.Size = new Size(254, 29);
            txtFuncionarioConsulta.TabIndex = 1;
            txtFuncionarioConsulta.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFuncionarioConsulta
            // 
            lblFuncionarioConsulta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionarioConsulta.Location = new Point(226, 67);
            lblFuncionarioConsulta.Name = "lblFuncionarioConsulta";
            lblFuncionarioConsulta.Size = new Size(194, 23);
            lblFuncionarioConsulta.TabIndex = 26;
            lblFuncionarioConsulta.Text = "Consulta de Funcionarios";
            // 
            // gbxModificarFuncionarioDatos
            // 
            gbxModificarFuncionarioDatos.Controls.Add(btnModificarCancelar);
            gbxModificarFuncionarioDatos.Controls.Add(btnModifcarLimpiar);
            gbxModificarFuncionarioDatos.Controls.Add(btnModificarFuncionario);
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
            gbxModificarFuncionarioDatos.Size = new Size(594, 506);
            gbxModificarFuncionarioDatos.TabIndex = 27;
            gbxModificarFuncionarioDatos.TabStop = false;
            // 
            // btnModificarCancelar
            // 
            btnModificarCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarCancelar.Location = new Point(380, 245);
            btnModificarCancelar.Name = "btnModificarCancelar";
            btnModificarCancelar.Size = new Size(120, 30);
            btnModificarCancelar.TabIndex = 10;
            btnModificarCancelar.Text = "Cancelar";
            btnModificarCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModifcarLimpiar
            // 
            btnModifcarLimpiar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModifcarLimpiar.Location = new Point(226, 245);
            btnModifcarLimpiar.Name = "btnModifcarLimpiar";
            btnModifcarLimpiar.Size = new Size(120, 30);
            btnModifcarLimpiar.TabIndex = 9;
            btnModifcarLimpiar.Text = "Limpiar";
            btnModifcarLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnModificarFuncionario
            // 
            btnModificarFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarFuncionario.Location = new Point(82, 245);
            btnModificarFuncionario.Name = "btnModificarFuncionario";
            btnModificarFuncionario.Size = new Size(120, 30);
            btnModificarFuncionario.TabIndex = 8;
            btnModificarFuncionario.Text = "Modificar";
            btnModificarFuncionario.UseVisualStyleBackColor = true;
            // 
            // gbxFuncionarioModificarLista
            // 
            gbxFuncionarioModificarLista.Controls.Add(dgvListaFuncionarios);
            gbxFuncionarioModificarLista.Dock = DockStyle.Bottom;
            gbxFuncionarioModificarLista.Location = new Point(0, 445);
            gbxFuncionarioModificarLista.Name = "gbxFuncionarioModificarLista";
            gbxFuncionarioModificarLista.Size = new Size(594, 216);
            gbxFuncionarioModificarLista.TabIndex = 28;
            gbxFuncionarioModificarLista.TabStop = false;
            // 
            // frmModificacionFuncionarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 661);
            Controls.Add(gbxFuncionarioModificarLista);
            Controls.Add(gbxModificarFuncionarioDatos);
            Controls.Add(gbxModificacion);
            MinimumSize = new Size(610, 700);
            Name = "frmModificacionFuncionarios";
            Text = "Modificacion Funcionarios";
            Load += frmModificacionFuncionarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaFuncionarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxModificacion.ResumeLayout(false);
            gbxModificacion.PerformLayout();
            gbxModificarFuncionarioDatos.ResumeLayout(false);
            gbxModificarFuncionarioDatos.PerformLayout();
            gbxFuncionarioModificarLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListaFuncionarios;
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
        private Label lblFuncionarioConsulta;
        private GroupBox gbxModificarFuncionarioDatos;
        private TextBox txtFuncionarioConsulta;
        private GroupBox gbxFuncionarioModificarLista;
        private Button btnModificarCancelar;
        private Button btnModifcarLimpiar;
        private Button btnModificarFuncionario;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellidoPrimero;
        private DataGridViewTextBoxColumn colSegundoApellido;
        private DataGridViewTextBoxColumn colDNI;
        private DataGridViewTextBoxColumn colCodFuncionario;
        private DataGridViewTextBoxColumn colEmail;
    }
}