namespace Proveeduria
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnMenu = new MenuStrip();
            mnArchivo = new ToolStripMenuItem();
            mnClientes = new ToolStripMenuItem();
            mnRegistro = new ToolStripMenuItem();
            mnModificacion = new ToolStripMenuItem();
            mnProveedores = new ToolStripMenuItem();
            mnRgistroProveedores = new ToolStripMenuItem();
            mnRegistroProductos = new ToolStripMenuItem();
            mnModificacionProveedores = new ToolStripMenuItem();
            mnModificacionProductos = new ToolStripMenuItem();
            mnFuncionarios = new ToolStripMenuItem();
            registroToolStripMenuItem1 = new ToolStripMenuItem();
            modificacionToolStripMenuItem1 = new ToolStripMenuItem();
            mnConsultas = new ToolStripMenuItem();
            mnConsultaClientes = new ToolStripMenuItem();
            mnConsultaProveedores = new ToolStripMenuItem();
            mnConsultaFacturas = new ToolStripMenuItem();
            mnConsultaProductos = new ToolStripMenuItem();
            mnVentas = new ToolStripMenuItem();
            mnVentasVentas = new ToolStripMenuItem();
            mnVentasHacienda = new ToolStripMenuItem();
            mnAcercaDe = new ToolStripMenuItem();
            mnCerrarSesion = new ToolStripMenuItem();
            mnSalir = new ToolStripMenuItem();
            mnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnMenu
            // 
            mnMenu.Items.AddRange(new ToolStripItem[] { mnArchivo, mnConsultas, mnVentas, mnAcercaDe, mnCerrarSesion, mnSalir });
            mnMenu.Location = new Point(0, 0);
            mnMenu.Name = "mnMenu";
            mnMenu.Size = new Size(984, 24);
            mnMenu.TabIndex = 1;
            mnMenu.Text = "menuStrip1";
            // 
            // mnArchivo
            // 
            mnArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnClientes, mnProveedores, mnFuncionarios });
            mnArchivo.Name = "mnArchivo";
            mnArchivo.Size = new Size(62, 20);
            mnArchivo.Text = "Registro";
            // 
            // mnClientes
            // 
            mnClientes.DropDownItems.AddRange(new ToolStripItem[] { mnRegistro, mnModificacion });
            mnClientes.Name = "mnClientes";
            mnClientes.Size = new Size(142, 22);
            mnClientes.Text = "Clientes";
            // 
            // mnRegistro
            // 
            mnRegistro.Name = "mnRegistro";
            mnRegistro.Size = new Size(189, 22);
            mnRegistro.Text = "Registro Clientes";
            // 
            // mnModificacion
            // 
            mnModificacion.Name = "mnModificacion";
            mnModificacion.Size = new Size(189, 22);
            mnModificacion.Text = "Modificacion Clientes";
            // 
            // mnProveedores
            // 
            mnProveedores.DropDownItems.AddRange(new ToolStripItem[] { mnRgistroProveedores, mnRegistroProductos, mnModificacionProveedores, mnModificacionProductos });
            mnProveedores.Name = "mnProveedores";
            mnProveedores.Size = new Size(142, 22);
            mnProveedores.Text = "Proveedores";
            // 
            // mnRgistroProveedores
            // 
            mnRgistroProveedores.Name = "mnRgistroProveedores";
            mnRgistroProveedores.Size = new Size(212, 22);
            mnRgistroProveedores.Text = "Registro Proveedores";
            // 
            // mnRegistroProductos
            // 
            mnRegistroProductos.Name = "mnRegistroProductos";
            mnRegistroProductos.Size = new Size(212, 22);
            mnRegistroProductos.Text = "Registro Productos";
            // 
            // mnModificacionProveedores
            // 
            mnModificacionProveedores.Name = "mnModificacionProveedores";
            mnModificacionProveedores.Size = new Size(212, 22);
            mnModificacionProveedores.Text = "Modificacion Proveedores";
            // 
            // mnModificacionProductos
            // 
            mnModificacionProductos.Name = "mnModificacionProductos";
            mnModificacionProductos.Size = new Size(212, 22);
            mnModificacionProductos.Text = "Modificacion Productos";
            // 
            // mnFuncionarios
            // 
            mnFuncionarios.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem1, modificacionToolStripMenuItem1 });
            mnFuncionarios.Name = "mnFuncionarios";
            mnFuncionarios.Size = new Size(142, 22);
            mnFuncionarios.Text = "Funcionarios";
            // 
            // registroToolStripMenuItem1
            // 
            registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            registroToolStripMenuItem1.Size = new Size(215, 22);
            registroToolStripMenuItem1.Text = "Registro Funcionarios";
            // 
            // modificacionToolStripMenuItem1
            // 
            modificacionToolStripMenuItem1.Name = "modificacionToolStripMenuItem1";
            modificacionToolStripMenuItem1.Size = new Size(215, 22);
            modificacionToolStripMenuItem1.Text = "Modificacion Funcionarios";
            // 
            // mnConsultas
            // 
            mnConsultas.DropDownItems.AddRange(new ToolStripItem[] { mnConsultaClientes, mnConsultaProveedores });
            mnConsultas.Name = "mnConsultas";
            mnConsultas.Size = new Size(71, 20);
            mnConsultas.Text = "Consultas";
            // 
            // mnConsultaClientes
            // 
            mnConsultaClientes.Name = "mnConsultaClientes";
            mnConsultaClientes.Size = new Size(139, 22);
            mnConsultaClientes.Text = "Clientes";
            // 
            // mnConsultaProveedores
            // 
            mnConsultaProveedores.DropDownItems.AddRange(new ToolStripItem[] { mnConsultaFacturas, mnConsultaProductos });
            mnConsultaProveedores.Name = "mnConsultaProveedores";
            mnConsultaProveedores.Size = new Size(139, 22);
            mnConsultaProveedores.Text = "Proveedores";
            // 
            // mnConsultaFacturas
            // 
            mnConsultaFacturas.Name = "mnConsultaFacturas";
            mnConsultaFacturas.Size = new Size(128, 22);
            mnConsultaFacturas.Text = "Facturas";
            // 
            // mnConsultaProductos
            // 
            mnConsultaProductos.Name = "mnConsultaProductos";
            mnConsultaProductos.Size = new Size(128, 22);
            mnConsultaProductos.Text = "Productos";
            // 
            // mnVentas
            // 
            mnVentas.DropDownItems.AddRange(new ToolStripItem[] { mnVentasVentas, mnVentasHacienda });
            mnVentas.Name = "mnVentas";
            mnVentas.Size = new Size(53, 20);
            mnVentas.Text = "Ventas";
            // 
            // mnVentasVentas
            // 
            mnVentasVentas.Name = "mnVentasVentas";
            mnVentasVentas.Size = new Size(124, 22);
            mnVentasVentas.Text = "Ventas";
            // 
            // mnVentasHacienda
            // 
            mnVentasHacienda.Name = "mnVentasHacienda";
            mnVentasHacienda.Size = new Size(124, 22);
            mnVentasHacienda.Text = "Hacienda";
            // 
            // mnAcercaDe
            // 
            mnAcercaDe.Name = "mnAcercaDe";
            mnAcercaDe.Size = new Size(72, 20);
            mnAcercaDe.Text = "Acerca De";
            mnAcercaDe.Click += mnAcercaDe_Click;
            // 
            // mnCerrarSesion
            // 
            mnCerrarSesion.Name = "mnCerrarSesion";
            mnCerrarSesion.Size = new Size(88, 20);
            mnCerrarSesion.Text = "Cerrar Sesion";
            mnCerrarSesion.Click += mnCerrarSesion_Click;
            // 
            // mnSalir
            // 
            mnSalir.Name = "mnSalir";
            mnSalir.Size = new Size(41, 20);
            mnSalir.Text = "Salir";
            mnSalir.Click += mnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 861);
            Controls.Add(mnMenu);
            IsMdiContainer = true;
            MainMenuStrip = mnMenu;
            MinimumSize = new Size(1000, 900);
            Name = "frmPrincipal";
            Text = "Proveedura Distribuidora La Zarzuela";
            mnMenu.ResumeLayout(false);
            mnMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnMenu;
        private ToolStripMenuItem mnArchivo;
        private ToolStripMenuItem mnAcercaDe;
        private ToolStripMenuItem mnClientes;
        private ToolStripMenuItem mnProveedores;
        private ToolStripMenuItem mnSalir;
        private ToolStripMenuItem mnRegistro;
        private ToolStripMenuItem mnModificacion;
        private ToolStripMenuItem mnRgistroProveedores;
        private ToolStripMenuItem mnRegistroProductos;
        private ToolStripMenuItem mnModificacionProveedores;
        private ToolStripMenuItem mnModificacionProductos;
        private ToolStripMenuItem mnFuncionarios;
        private ToolStripMenuItem registroToolStripMenuItem1;
        private ToolStripMenuItem modificacionToolStripMenuItem1;
        private ToolStripMenuItem mnVentas;
        private ToolStripMenuItem mnConsultas;
        private ToolStripMenuItem mnConsultaClientes;
        private ToolStripMenuItem mnConsultaProveedores;
        private ToolStripMenuItem mnConsultaFacturas;
        private ToolStripMenuItem mnVentasVentas;
        private ToolStripMenuItem mnVentasHacienda;
        private ToolStripMenuItem mnConsultaProductos;
        private ToolStripMenuItem mnCerrarSesion;
    }
}
