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
            gbxConsultarFecha = new GroupBox();
            btnBuscar = new Button();
            dtpFechaConsulta = new DateTimePicker();
            pbLogo = new PictureBox();
            lblImpuestosTitulo = new Label();
            gbxCalculoIVA = new GroupBox();
            btnSalir = new Button();
            btnCalcular = new Button();
            lblCalculoRes = new Label();
            gbxListView = new GroupBox();
            gbxFacturasVenta = new GroupBox();
            lvwFacturasVenta = new ListView();
            colClienteVenta = new ColumnHeader();
            colFacturaVenta = new ColumnHeader();
            colFechaVenta = new ColumnHeader();
            colMontoIVAVenta = new ColumnHeader();
            colTotalVenta = new ColumnHeader();
            gbxFacturasCompra = new GroupBox();
            lvwFacturasCompra = new ListView();
            colProveedorCompra = new ColumnHeader();
            colFacturaCompra = new ColumnHeader();
            colFechaCompra = new ColumnHeader();
            colMontoIVACompra = new ColumnHeader();
            ColTotalCompra = new ColumnHeader();
            gbxRegistroProductosTitulo.SuspendLayout();
            gbxConsultarFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            gbxCalculoIVA.SuspendLayout();
            gbxListView.SuspendLayout();
            gbxFacturasVenta.SuspendLayout();
            gbxFacturasCompra.SuspendLayout();
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
            gbxRegistroProductosTitulo.Size = new Size(889, 104);
            gbxRegistroProductosTitulo.TabIndex = 2;
            gbxRegistroProductosTitulo.TabStop = false;
            // 
            // gbxConsultarFecha
            // 
            gbxConsultarFecha.Controls.Add(btnBuscar);
            gbxConsultarFecha.Controls.Add(dtpFechaConsulta);
            gbxConsultarFecha.Location = new Point(609, 22);
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
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Format = DateTimePickerFormat.Short;
            dtpFechaConsulta.Location = new Point(6, 26);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(141, 23);
            dtpFechaConsulta.TabIndex = 19;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(12, 19);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(119, 79);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 14;
            pbLogo.TabStop = false;
            // 
            // lblImpuestosTitulo
            // 
            lblImpuestosTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblImpuestosTitulo.Location = new Point(285, 22);
            lblImpuestosTitulo.Name = "lblImpuestosTitulo";
            lblImpuestosTitulo.Size = new Size(224, 61);
            lblImpuestosTitulo.TabIndex = 16;
            lblImpuestosTitulo.Text = "Calculo de Impuestos ";
            lblImpuestosTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxCalculoIVA
            // 
            gbxCalculoIVA.Controls.Add(btnSalir);
            gbxCalculoIVA.Controls.Add(btnCalcular);
            gbxCalculoIVA.Controls.Add(lblCalculoRes);
            gbxCalculoIVA.Dock = DockStyle.Bottom;
            gbxCalculoIVA.Location = new Point(0, 713);
            gbxCalculoIVA.Name = "gbxCalculoIVA";
            gbxCalculoIVA.Size = new Size(889, 71);
            gbxCalculoIVA.TabIndex = 3;
            gbxCalculoIVA.TabStop = false;
            gbxCalculoIVA.Text = "Calculo IVA";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(796, 31);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(81, 34);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(102, 15);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(108, 41);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblCalculoRes
            // 
            lblCalculoRes.BackColor = SystemColors.Info;
            lblCalculoRes.BorderStyle = BorderStyle.FixedSingle;
            lblCalculoRes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalculoRes.Location = new Point(318, 13);
            lblCalculoRes.Name = "lblCalculoRes";
            lblCalculoRes.Size = new Size(322, 41);
            lblCalculoRes.TabIndex = 1;
            lblCalculoRes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxListView
            // 
            gbxListView.Controls.Add(gbxFacturasVenta);
            gbxListView.Controls.Add(gbxFacturasCompra);
            gbxListView.Dock = DockStyle.Fill;
            gbxListView.Location = new Point(0, 104);
            gbxListView.Name = "gbxListView";
            gbxListView.Size = new Size(889, 609);
            gbxListView.TabIndex = 4;
            gbxListView.TabStop = false;
            // 
            // gbxFacturasVenta
            // 
            gbxFacturasVenta.Controls.Add(lvwFacturasVenta);
            gbxFacturasVenta.Location = new Point(6, 302);
            gbxFacturasVenta.Name = "gbxFacturasVenta";
            gbxFacturasVenta.Size = new Size(869, 278);
            gbxFacturasVenta.TabIndex = 1;
            gbxFacturasVenta.TabStop = false;
            gbxFacturasVenta.Text = "Facturas Venta";
            // 
            // lvwFacturasVenta
            // 
            lvwFacturasVenta.BackColor = SystemColors.Info;
            lvwFacturasVenta.Columns.AddRange(new ColumnHeader[] { colClienteVenta, colFacturaVenta, colFechaVenta, colMontoIVAVenta, colTotalVenta });
            lvwFacturasVenta.Dock = DockStyle.Fill;
            lvwFacturasVenta.Location = new Point(3, 19);
            lvwFacturasVenta.Name = "lvwFacturasVenta";
            lvwFacturasVenta.Size = new Size(863, 256);
            lvwFacturasVenta.TabIndex = 0;
            lvwFacturasVenta.UseCompatibleStateImageBehavior = false;
            lvwFacturasVenta.View = View.Details;
            // 
            // colClienteVenta
            // 
            colClienteVenta.Text = "Cliente";
            colClienteVenta.Width = 100;
            // 
            // colFacturaVenta
            // 
            colFacturaVenta.Text = "Factura";
            colFacturaVenta.Width = 100;
            // 
            // colFechaVenta
            // 
            colFechaVenta.Text = "Fecha";
            colFechaVenta.Width = 100;
            // 
            // colMontoIVAVenta
            // 
            colMontoIVAVenta.Text = "Monto IVA";
            colMontoIVAVenta.Width = 100;
            // 
            // colTotalVenta
            // 
            colTotalVenta.Text = "Total";
            colTotalVenta.Width = 100;
            // 
            // gbxFacturasCompra
            // 
            gbxFacturasCompra.Controls.Add(lvwFacturasCompra);
            gbxFacturasCompra.Location = new Point(3, 19);
            gbxFacturasCompra.Name = "gbxFacturasCompra";
            gbxFacturasCompra.Size = new Size(872, 280);
            gbxFacturasCompra.TabIndex = 0;
            gbxFacturasCompra.TabStop = false;
            gbxFacturasCompra.Text = "Facturas Compra";
            // 
            // lvwFacturasCompra
            // 
            lvwFacturasCompra.BackColor = SystemColors.Info;
            lvwFacturasCompra.Columns.AddRange(new ColumnHeader[] { colProveedorCompra, colFacturaCompra, colFechaCompra, colMontoIVACompra, ColTotalCompra });
            lvwFacturasCompra.Dock = DockStyle.Fill;
            lvwFacturasCompra.Location = new Point(3, 19);
            lvwFacturasCompra.Name = "lvwFacturasCompra";
            lvwFacturasCompra.Size = new Size(866, 258);
            lvwFacturasCompra.TabIndex = 0;
            lvwFacturasCompra.UseCompatibleStateImageBehavior = false;
            lvwFacturasCompra.View = View.Details;
            // 
            // colProveedorCompra
            // 
            colProveedorCompra.Text = "Proveedor";
            colProveedorCompra.Width = 100;
            // 
            // colFacturaCompra
            // 
            colFacturaCompra.Text = "Factura";
            colFacturaCompra.Width = 100;
            // 
            // colFechaCompra
            // 
            colFechaCompra.Text = "Fecha";
            colFechaCompra.Width = 100;
            // 
            // colMontoIVACompra
            // 
            colMontoIVACompra.Text = "Monto IVA";
            colMontoIVACompra.Width = 100;
            // 
            // ColTotalCompra
            // 
            ColTotalCompra.Text = "Total";
            ColTotalCompra.Width = 100;
            // 
            // frmCalculoHacienda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 784);
            ControlBox = false;
            Controls.Add(gbxListView);
            Controls.Add(gbxCalculoIVA);
            Controls.Add(gbxRegistroProductosTitulo);
            MinimumSize = new Size(900, 800);
            Name = "frmCalculoHacienda";
            Text = "Calculo Impuestos";
            Load += frmCalculoHacienda_Load;
            gbxRegistroProductosTitulo.ResumeLayout(false);
            gbxConsultarFecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            gbxCalculoIVA.ResumeLayout(false);
            gbxListView.ResumeLayout(false);
            gbxFacturasVenta.ResumeLayout(false);
            gbxFacturasCompra.ResumeLayout(false);
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
        private Button btnCalcular;
        private Label lblCalculoRes;
        private Button btnSalir;
        private ColumnHeader colProveedorCompra;
        private ColumnHeader colMontoIVACompra;
        private ColumnHeader ColTotalCompra;
        private ColumnHeader colFacturaCompra;
        private ColumnHeader colFechaCompra;
        private ColumnHeader colClienteVenta;
        private ColumnHeader colFacturaVenta;
        private ColumnHeader colFechaVenta;
        private ColumnHeader colMontoIVAVenta;
        private ColumnHeader colTotalVenta;
    }
}