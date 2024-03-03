namespace Proveeduria
{
    partial class frmCalculoHacienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoHacienda));
            gbxRegistroProductosTitulo = new GroupBox();
            pbLogo = new PictureBox();
            lblImpuestosTitulo = new Label();
            gbxCalculoIVA = new GroupBox();
            gbxListView = new GroupBox();
            gbxFacturasCompra = new GroupBox();
            gbxFacturasVenta = new GroupBox();
            lvwFacturasCompra = new ListView();
            lvwFacturasVenta = new ListView();
            dtpFechaConsulta = new DateTimePicker();
            gbxConsultarFecha = new GroupBox();
            btnBuscar = new Button();
            gbxRegistroProductosTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxListView.SuspendLayout();
            gbxFacturasCompra.SuspendLayout();
            gbxFacturasVenta.SuspendLayout();
            gbxConsultarFecha.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRegistroProductosTitulo
            // 
            gbxRegistroProductosTitulo.Controls.Add(gbxConsultarFecha);
            gbxRegistroProductosTitulo.Controls.Add(pbLogo);
            gbxRegistroProductosTitulo.Controls.Add(lblImpuestosTitulo);
            gbxRegistroProductosTitulo.Dock = DockStyle.Top;
            gbxRegistroProductosTitulo.Location = new Point(0, 0);
            gbxRegistroProductosTitulo.Name = "gbxRegistroProductosTitulo";
            gbxRegistroProductosTitulo.Size = new Size(884, 116);
            gbxRegistroProductosTitulo.TabIndex = 2;
            gbxRegistroProductosTitulo.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 19);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(126, 86);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblImpuestosTitulo
            // 
            lblImpuestosTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImpuestosTitulo.Location = new Point(262, 19);
            lblImpuestosTitulo.Name = "lblImpuestosTitulo";
            lblImpuestosTitulo.Size = new Size(224, 86);
            lblImpuestosTitulo.TabIndex = 16;
            lblImpuestosTitulo.Text = "Calculo de Impuestos ";
            lblImpuestosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxCalculoIVA
            // 
            gbxCalculoIVA.Dock = DockStyle.Bottom;
            gbxCalculoIVA.Location = new Point(0, 661);
            gbxCalculoIVA.Name = "gbxCalculoIVA";
            gbxCalculoIVA.Size = new Size(884, 100);
            gbxCalculoIVA.TabIndex = 3;
            gbxCalculoIVA.TabStop = false;
            gbxCalculoIVA.Text = "Calculo IVA";
            // 
            // gbxListView
            // 
            gbxListView.Controls.Add(gbxFacturasVenta);
            gbxListView.Controls.Add(gbxFacturasCompra);
            gbxListView.Dock = DockStyle.Fill;
            gbxListView.Location = new Point(0, 116);
            gbxListView.Name = "gbxListView";
            gbxListView.Size = new Size(884, 545);
            gbxListView.TabIndex = 4;
            gbxListView.TabStop = false;
            // 
            // gbxFacturasCompra
            // 
            gbxFacturasCompra.Controls.Add(lvwFacturasCompra);
            gbxFacturasCompra.Dock = DockStyle.Left;
            gbxFacturasCompra.Location = new Point(3, 19);
            gbxFacturasCompra.Name = "gbxFacturasCompra";
            gbxFacturasCompra.Size = new Size(423, 523);
            gbxFacturasCompra.TabIndex = 0;
            gbxFacturasCompra.TabStop = false;
            gbxFacturasCompra.Text = "Facturas Compra";
            // 
            // gbxFacturasVenta
            // 
            gbxFacturasVenta.Controls.Add(lvwFacturasVenta);
            gbxFacturasVenta.Dock = DockStyle.Right;
            gbxFacturasVenta.Location = new Point(432, 19);
            gbxFacturasVenta.Name = "gbxFacturasVenta";
            gbxFacturasVenta.Size = new Size(449, 523);
            gbxFacturasVenta.TabIndex = 1;
            gbxFacturasVenta.TabStop = false;
            gbxFacturasVenta.Text = "Facturas Venta";
            // 
            // lvwFacturasCompra
            // 
            lvwFacturasCompra.BackColor = SystemColors.Info;
            lvwFacturasCompra.Dock = DockStyle.Fill;
            lvwFacturasCompra.Location = new Point(3, 19);
            lvwFacturasCompra.Name = "lvwFacturasCompra";
            lvwFacturasCompra.Size = new Size(417, 501);
            lvwFacturasCompra.TabIndex = 0;
            lvwFacturasCompra.UseCompatibleStateImageBehavior = false;
            lvwFacturasCompra.View = View.Details;
            // 
            // lvwFacturasVenta
            // 
            lvwFacturasVenta.BackColor = SystemColors.Info;
            lvwFacturasVenta.Dock = DockStyle.Fill;
            lvwFacturasVenta.Location = new Point(3, 19);
            lvwFacturasVenta.Name = "lvwFacturasVenta";
            lvwFacturasVenta.Size = new Size(443, 501);
            lvwFacturasVenta.TabIndex = 0;
            lvwFacturasVenta.UseCompatibleStateImageBehavior = false;
            lvwFacturasVenta.View = View.Details;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtpFechaConsulta.Location = new Point(6, 24);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(141, 25);
            dtpFechaConsulta.TabIndex = 17;
            // 
            // gbxConsultarFecha
            // 
            gbxConsultarFecha.Controls.Add(btnBuscar);
            gbxConsultarFecha.Controls.Add(dtpFechaConsulta);
            gbxConsultarFecha.Location = new Point(606, 49);
            gbxConsultarFecha.Name = "gbxConsultarFecha";
            gbxConsultarFecha.Size = new Size(266, 61);
            gbxConsultarFecha.TabIndex = 18;
            gbxConsultarFecha.TabStop = false;
            gbxConsultarFecha.Text = "Consultar IVA por Fecha";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.Location = new Point(153, 26);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 23);
            btnBuscar.TabIndex = 18;
            btnBuscar.Text = "Consultar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmCalculoHacienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 761);
            ControlBox = false;
            Controls.Add(gbxListView);
            Controls.Add(gbxCalculoIVA);
            Controls.Add(gbxRegistroProductosTitulo);
            MinimumSize = new Size(900, 800);
            Name = "frmCalculoHacienda";
            Text = "Calculo Impuestos";
            Load += frmCalculoHacienda_Load;
            gbxRegistroProductosTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxListView.ResumeLayout(false);
            gbxFacturasCompra.ResumeLayout(false);
            gbxFacturasVenta.ResumeLayout(false);
            gbxConsultarFecha.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxRegistroProductosTitulo;
        private PictureBox pbLogo;
        private Label lblImpuestosTitulo;
        private GroupBox gbxCalculoIVA;
        private GroupBox gbxListView;
        private GroupBox gbxFacturasVenta;
        private ListView lvwFacturasVenta;
        private GroupBox gbxFacturasCompra;
        private ListView lvwFacturasCompra;
        private GroupBox gbxConsultarFecha;
        private Button btnBuscar;
        private DateTimePicker dtpFechaConsulta;
    }
}