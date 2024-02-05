namespace Proveeduria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
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
           // this.Close();
            frmLogin pantallaLogin = new frmLogin();
            pantallaLogin.Show();
 
        }
    }
}
