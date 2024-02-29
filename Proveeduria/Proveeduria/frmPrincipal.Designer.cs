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
            mnModificacionProveedores = new ToolStripMenuItem();
            mnIngresoFacturas = new ToolStripMenuItem();
            mnModificacionProductos = new ToolStripMenuItem();
            mnConsultaListaProductos = new ToolStripMenuItem();
            mnFuncionarios = new ToolStripMenuItem();
            mnRegistroFuncionario = new ToolStripMenuItem();
            mnModificacionFuncionario = new ToolStripMenuItem();
            mnConsultas = new ToolStripMenuItem();
            mnConsultaProveedores = new ToolStripMenuItem();
            mnConsultaFacturas = new ToolStripMenuItem();
            mnConsultaProductos = new ToolStripMenuItem();
            mnListaClientes = new ToolStripMenuItem();
            mnVentas = new ToolStripMenuItem();
            mnVentasVentas = new ToolStripMenuItem();
            mnVentasHacienda = new ToolStripMenuItem();
            mnCalculoDeImpuestos = new ToolStripMenuItem();
            mnAcercaDe = new ToolStripMenuItem();
            mnCerrarSesion = new ToolStripMenuItem();
            mnSalir = new ToolStripMenuItem();
            listaProductosToolStripMenuItem = new ToolStripMenuItem();
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
            mnRegistro.Click += mnRegistro_Click;
            // 
            // mnModificacion
            // 
            mnModificacion.Name = "mnModificacion";
            mnModificacion.Size = new Size(189, 22);
            mnModificacion.Text = "Modificacion Clientes";
            mnModificacion.Click += mnModificacion_Click;
            // 
            // mnProveedores
            // 
            mnProveedores.DropDownItems.AddRange(new ToolStripItem[] { mnRgistroProveedores, mnModificacionProveedores, mnIngresoFacturas, mnModificacionProductos, mnConsultaListaProductos });
            mnProveedores.Name = "mnProveedores";
            mnProveedores.Size = new Size(142, 22);
            mnProveedores.Text = "Proveedores";
            // 
            // mnRgistroProveedores
            // 
            mnRgistroProveedores.Name = "mnRgistroProveedores";
            mnRgistroProveedores.Size = new Size(217, 22);
            mnRgistroProveedores.Text = "Registro Proveedores";
            mnRgistroProveedores.Click += mnRgistroProveedores_Click;
            // 
            // mnModificacionProveedores
            // 
            mnModificacionProveedores.Name = "mnModificacionProveedores";
            mnModificacionProveedores.Size = new Size(217, 22);
            mnModificacionProveedores.Text = "Modificacion Proveedores";
            mnModificacionProveedores.Click += mnModificacionProveedores_Click;
            // 
            // mnIngresoFacturas
            // 
            mnIngresoFacturas.Name = "mnIngresoFacturas";
            mnIngresoFacturas.Size = new Size(217, 22);
            mnIngresoFacturas.Text = "Ingreso Facturas Proveedor";
            mnIngresoFacturas.Click += mnRegistroProductos_Click;
            // 
            // mnModificacionProductos
            // 
            mnModificacionProductos.Name = "mnModificacionProductos";
            mnModificacionProductos.Size = new Size(217, 22);
            mnModificacionProductos.Text = "Modificacion Productos";
            mnModificacionProductos.Click += mnModificacionProductos_Click;
            // 
            // mnConsultaListaProductos
            // 
            mnConsultaListaProductos.Name = "mnConsultaListaProductos";
            mnConsultaListaProductos.Size = new Size(217, 22);
            mnConsultaListaProductos.Text = "Consulta Productos";
            // 
            // mnFuncionarios
            // 
            mnFuncionarios.DropDownItems.AddRange(new ToolStripItem[] { mnRegistroFuncionario, mnModificacionFuncionario });
            mnFuncionarios.Name = "mnFuncionarios";
            mnFuncionarios.Size = new Size(142, 22);
            mnFuncionarios.Text = "Funcionarios";
            // 
            // mnRegistroFuncionario
            // 
            mnRegistroFuncionario.Name = "mnRegistroFuncionario";
            mnRegistroFuncionario.Size = new Size(215, 22);
            mnRegistroFuncionario.Text = "Registro Funcionarios";
            mnRegistroFuncionario.Click += mnRegistroFuncionario_Click;
            // 
            // mnModificacionFuncionario
            // 
            mnModificacionFuncionario.Name = "mnModificacionFuncionario";
            mnModificacionFuncionario.Size = new Size(215, 22);
            mnModificacionFuncionario.Text = "Modificacion Funcionarios";
            mnModificacionFuncionario.Click += mnModificacionFuncionario_Click;
            // 
            // mnConsultas
            // 
            mnConsultas.DropDownItems.AddRange(new ToolStripItem[] { mnConsultaProveedores, mnListaClientes, listaProductosToolStripMenuItem });
            mnConsultas.Name = "mnConsultas";
            mnConsultas.Size = new Size(71, 20);
            mnConsultas.Text = "Consultas";
            // 
            // mnConsultaProveedores
            // 
            mnConsultaProveedores.DropDownItems.AddRange(new ToolStripItem[] { mnConsultaFacturas, mnConsultaProductos });
            mnConsultaProveedores.Name = "mnConsultaProveedores";
            mnConsultaProveedores.Size = new Size(180, 22);
            mnConsultaProveedores.Text = "Proveedores";
            // 
            // mnConsultaFacturas
            // 
            mnConsultaFacturas.Name = "mnConsultaFacturas";
            mnConsultaFacturas.Size = new Size(128, 22);
            mnConsultaFacturas.Text = "Facturas";
            mnConsultaFacturas.Click += mnConsultaFacturas_Click;
            // 
            // mnConsultaProductos
            // 
            mnConsultaProductos.Name = "mnConsultaProductos";
            mnConsultaProductos.Size = new Size(128, 22);
            mnConsultaProductos.Text = "Productos";
            mnConsultaProductos.Click += mnConsultaProductos_Click;
            // 
            // mnListaClientes
            // 
            mnListaClientes.Name = "mnListaClientes";
            mnListaClientes.Size = new Size(180, 22);
            mnListaClientes.Text = "Lista Clientes";
            mnListaClientes.Click += mnListaClientes_Click;
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
            mnVentasVentas.Size = new Size(173, 22);
            mnVentasVentas.Text = "Ventas Facturacion";
            mnVentasVentas.Click += mnVentasVentas_Click;
            // 
            // mnVentasHacienda
            // 
            mnVentasHacienda.DropDownItems.AddRange(new ToolStripItem[] { mnCalculoDeImpuestos });
            mnVentasHacienda.Name = "mnVentasHacienda";
            mnVentasHacienda.Size = new Size(173, 22);
            mnVentasHacienda.Text = "Hacienda";
            // 
            // mnCalculoDeImpuestos
            // 
            mnCalculoDeImpuestos.Name = "mnCalculoDeImpuestos";
            mnCalculoDeImpuestos.Size = new Size(188, 22);
            mnCalculoDeImpuestos.Text = "Calculo de Impuestos";
            mnCalculoDeImpuestos.Click += mnCalculoDeImpuestos_Click;
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
            // listaProductosToolStripMenuItem
            // 
            listaProductosToolStripMenuItem.Name = "listaProductosToolStripMenuItem";
            listaProductosToolStripMenuItem.Size = new Size(180, 22);
            listaProductosToolStripMenuItem.Text = "Lista Productos";
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedura Distribuidora La Zarzuela";
            Load += frmPrincipal_Load;
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
        private ToolStripMenuItem mnIngresoFacturas;
        private ToolStripMenuItem mnModificacionProveedores;
        private ToolStripMenuItem mnModificacionProductos;
        private ToolStripMenuItem mnFuncionarios;
        private ToolStripMenuItem mnRegistroFuncionario;
        private ToolStripMenuItem mnModificacionFuncionario;
        private ToolStripMenuItem mnVentas;
        private ToolStripMenuItem mnConsultas;
        private ToolStripMenuItem mnConsultaProveedores;
        private ToolStripMenuItem mnConsultaFacturas;
        private ToolStripMenuItem mnVentasVentas;
        private ToolStripMenuItem mnVentasHacienda;
        private ToolStripMenuItem mnConsultaProductos;
        private ToolStripMenuItem mnCerrarSesion;
        private ToolStripMenuItem mnCalculoDeImpuestos;
        private ToolStripMenuItem mnConsultaListaProductos;
        private ToolStripMenuItem mnListaClientes;
        private ToolStripMenuItem listaProductosToolStripMenuItem;
    }
}
