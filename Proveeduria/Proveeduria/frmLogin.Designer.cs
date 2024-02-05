namespace Proveeduria
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTituloLogin = new Label();
            lblFuncionario = new Label();
            lblContrasenia = new Label();
            txtIdentificacion = new TextBox();
            txtContrasenia = new TextBox();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            pbLogo = new PictureBox();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloLogin.Location = new Point(40, 32);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(242, 120);
            lblTituloLogin.TabIndex = 0;
            lblTituloLogin.Text = "Inicio de Sesion al Departamento de Proveeduria Distribuidora La Zarzuela";
            lblTituloLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuncionario
            // 
            lblFuncionario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblFuncionario.Location = new Point(40, 384);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(144, 31);
            lblFuncionario.TabIndex = 1;
            lblFuncionario.Text = "Identificacion";
            // 
            // lblContrasenia
            // 
            lblContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(40, 454);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(144, 31);
            lblContrasenia.TabIndex = 2;
            lblContrasenia.Text = "Contrasenia";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacion.Location = new Point(40, 418);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(193, 33);
            txtIdentificacion.TabIndex = 3;
            txtIdentificacion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(40, 488);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(193, 33);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.TextAlign = HorizontalAlignment.Center;
            txtContrasenia.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.Location = new Point(28, 550);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(117, 34);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(184, 550);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(117, 34);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(40, 155);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(242, 195);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 7;
            pbLogo.TabStop = false;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(105, 606);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(117, 34);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 664);
            Controls.Add(btnCerrar);
            Controls.Add(pbLogo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(txtContrasenia);
            Controls.Add(txtIdentificacion);
            Controls.Add(lblContrasenia);
            Controls.Add(lblFuncionario);
            Controls.Add(lblTituloLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloLogin;
        private Label lblFuncionario;
        private Label lblContrasenia;
        private TextBox txtIdentificacion;
        private TextBox txtContrasenia;
        private Button btnAceptar;
        private Button btnLimpiar;
        private PictureBox pbLogo;
        private Button btnCerrar;
    }
}