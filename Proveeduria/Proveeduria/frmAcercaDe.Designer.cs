namespace Proveeduria
{
    partial class frmAcercaDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            pbLogo = new PictureBox();
            lblAcercaDeTitulo = new Label();
            lblAcercaDeNombreTarea = new Label();
            lblAcercaDeInstitucion = new Label();
            lblAcercaDeEstudiante = new Label();
            lblAcercaDeCurso = new Label();
            lblAcercaDeProfesor = new Label();
            lblAcercaDeAnio = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(266, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(171, 184);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblAcercaDeTitulo
            // 
            lblAcercaDeTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeTitulo.Location = new Point(12, 9);
            lblAcercaDeTitulo.Name = "lblAcercaDeTitulo";
            lblAcercaDeTitulo.Size = new Size(222, 40);
            lblAcercaDeTitulo.TabIndex = 1;
            lblAcercaDeTitulo.Text = "Tarea Programada ";
            lblAcercaDeTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeNombreTarea
            // 
            lblAcercaDeNombreTarea.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeNombreTarea.Location = new Point(12, 64);
            lblAcercaDeNombreTarea.Name = "lblAcercaDeNombreTarea";
            lblAcercaDeNombreTarea.Size = new Size(248, 66);
            lblAcercaDeNombreTarea.TabIndex = 2;
            lblAcercaDeNombreTarea.Text = "Proveeduria Distribuidora La Zarzuela";
            lblAcercaDeNombreTarea.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeInstitucion
            // 
            lblAcercaDeInstitucion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeInstitucion.Location = new Point(12, 151);
            lblAcercaDeInstitucion.Name = "lblAcercaDeInstitucion";
            lblAcercaDeInstitucion.Size = new Size(248, 64);
            lblAcercaDeInstitucion.TabIndex = 3;
            lblAcercaDeInstitucion.Text = "Institucion: Colegio Universitario de Cartago";
            lblAcercaDeInstitucion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeEstudiante
            // 
            lblAcercaDeEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeEstudiante.Location = new Point(12, 308);
            lblAcercaDeEstudiante.Name = "lblAcercaDeEstudiante";
            lblAcercaDeEstudiante.Size = new Size(248, 64);
            lblAcercaDeEstudiante.TabIndex = 4;
            lblAcercaDeEstudiante.Text = "Estudiante: Nestor Leiva Villalobos";
            lblAcercaDeEstudiante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeCurso
            // 
            lblAcercaDeCurso.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeCurso.Location = new Point(41, 215);
            lblAcercaDeCurso.Name = "lblAcercaDeCurso";
            lblAcercaDeCurso.Size = new Size(193, 93);
            lblAcercaDeCurso.TabIndex = 5;
            lblAcercaDeCurso.Text = "Curso: TI - 131 Programacion II Grupo 2";
            lblAcercaDeCurso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeProfesor
            // 
            lblAcercaDeProfesor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeProfesor.Location = new Point(12, 372);
            lblAcercaDeProfesor.Name = "lblAcercaDeProfesor";
            lblAcercaDeProfesor.Size = new Size(248, 64);
            lblAcercaDeProfesor.TabIndex = 6;
            lblAcercaDeProfesor.Text = "Profesor: Roger Rodrigez Lopez";
            lblAcercaDeProfesor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAcercaDeAnio
            // 
            lblAcercaDeAnio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAcercaDeAnio.Location = new Point(67, 436);
            lblAcercaDeAnio.Name = "lblAcercaDeAnio";
            lblAcercaDeAnio.Size = new Size(135, 33);
            lblAcercaDeAnio.TabIndex = 7;
            lblAcercaDeAnio.Text = "Anio 2024";
            lblAcercaDeAnio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(358, 436);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(91, 32);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 480);
            Controls.Add(btnCerrar);
            Controls.Add(lblAcercaDeAnio);
            Controls.Add(lblAcercaDeProfesor);
            Controls.Add(lblAcercaDeCurso);
            Controls.Add(lblAcercaDeEstudiante);
            Controls.Add(lblAcercaDeInstitucion);
            Controls.Add(lblAcercaDeNombreTarea);
            Controls.Add(lblAcercaDeTitulo);
            Controls.Add(pbLogo);
            Name = "frmAcercaDe";
            Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblAcercaDeTitulo;
        private Label lblAcercaDeNombreTarea;
        private Label lblAcercaDeInstitucion;
        private Label lblAcercaDeEstudiante;
        private Label lblAcercaDeCurso;
        private Label lblAcercaDeProfesor;
        private Label lblAcercaDeAnio;
        private Button btnCerrar;
    }
}