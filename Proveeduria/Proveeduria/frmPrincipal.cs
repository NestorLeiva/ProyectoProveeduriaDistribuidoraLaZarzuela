namespace Proveeduria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void CargarPantalla(Form pantalla) // metodo para cargar pantallas
        {
            pantalla.MdiParent = this;
            pantalla.Show();
        }

        private void mnAcercaDe_Click(object sender, EventArgs e)
        {
            frmAcercaDe pantalla = new frmAcercaDe();
            this.CargarPantalla(pantalla);
        }

        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin pantallaLogin = new frmLogin();
            pantallaLogin.Show();

        }

        private void mnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistroClientes pantalla = new frmRegistroClientes();
            this.CargarPantalla(pantalla);
        }

        private void mnModificacion_Click(object sender, EventArgs e)
        {
            frmModificacionClientes pantalla = new frmModificacionClientes();
            this.CargarPantalla(pantalla);
        }

        private void mnRgistroProveedores_Click(object sender, EventArgs e)
        {
            frmRegistroProveedores pantalla = new frmRegistroProveedores();
            this.CargarPantalla(pantalla);
        }

        private void mnRegistroProductos_Click(object sender, EventArgs e)
        {
            frmIngresoFacturas pantalla = new frmIngresoFacturas();
            this.CargarPantalla(pantalla);
        }

        private void mnModificacionProveedores_Click(object sender, EventArgs e)
        {
            frmModificacionProveedores pantalla = new frmModificacionProveedores();
            this.CargarPantalla(pantalla);
        }

        private void mnRegistroFuncionario_Click(object sender, EventArgs e)
        {
            frmRegistroFuncionarios pantalla = new frmRegistroFuncionarios();
            this.CargarPantalla(pantalla);
        }

        private void mnModificacionFuncionario_Click(object sender, EventArgs e)
        {
            frmModificacionFuncionarios pantalla = new frmModificacionFuncionarios();
            this.CargarPantalla(pantalla);
        }
        private void mnConsultaFacturas_Click(object sender, EventArgs e)
        {
            frmConsultaFacturas pantalla = new frmConsultaFacturas();
            this.CargarPantalla(pantalla);
        }

        private void mnVentasVentas_Click(object sender, EventArgs e)
        {
            frmVentasFacturacion pantalla = new frmVentasFacturacion();
            this.CargarPantalla(pantalla);
        }

        private void mnCalculoDeImpuestos_Click(object sender, EventArgs e)
        {
            frmCalculoHacienda pantalla = new frmCalculoHacienda();
            this.CargarPantalla(pantalla);
        }

        private void mnListaClientes_Click(object sender, EventArgs e)
        {
            frmConsultaClientes pantalla = new frmConsultaClientes();
            this.CargarPantalla(pantalla);
        }

        private void mnlistaProductos_Click(object sender, EventArgs e)
        {
            frmConsultaProductos pantalla = new frmConsultaProductos();
            this.CargarPantalla(pantalla);
        }
    }
}
