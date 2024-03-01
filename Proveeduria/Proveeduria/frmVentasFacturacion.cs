using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proveeduria
{
    public partial class frmVentasFacturacion : Form
    {
        public frmVentasFacturacion()
        {
            InitializeComponent();
        }

        private void frmVentasFacturacion_Load(object sender, EventArgs e) { }
        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        XmlDocument xmlDoc;

        private string consutlaCliente = string.Empty;

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                consutlaCliente = this.txtBuscarCliente.Text.ToUpper();
                xmlDoc = _ArchivoXML.leerXML("Clientes.xml");

                XmlNode _nodoBuscarCliente = xmlDoc.SelectSingleNode($"//Cliente[CodigoCliente='{consutlaCliente}']");

                if (_nodoBuscarCliente != null)
                {
                    string codigoCliente = _nodoBuscarCliente.SelectSingleNode("CodigoCliente").InnerText;
                    string tipoIdentificacionCliente = _nodoBuscarCliente.SelectSingleNode("TipoIdentificacion").InnerText;
                    string identificacionCliente = _nodoBuscarCliente.SelectSingleNode("NumeroIdentificacion").InnerText;
                    string NombreCliente = _nodoBuscarCliente.SelectSingleNode("Nombre").InnerText;
                    string ApellidoPrimeroCliente = _nodoBuscarCliente.SelectSingleNode("ApellidoPrimero").InnerText;
                    string ApellidoSegundoCliente = _nodoBuscarCliente.SelectSingleNode("ApellidoSegundo").InnerText;
                    string TelefonoCliente = _nodoBuscarCliente.SelectSingleNode("Telefono").InnerText;
                    string emailCliente = _nodoBuscarCliente.SelectSingleNode("Email").InnerText;
                    /* Obtengo los datos del cliente */

                    txtCodigoCliente.Text = codigoCliente;
                    txtTipoIdentificacion.Text = tipoIdentificacionCliente;
                    txtIdntificacion.Text = identificacionCliente;
                    txtNombre.Text = NombreCliente;
                    txtApellidoPrimero.Text = ApellidoPrimeroCliente;
                    txtApellidoSegundo.Text = ApellidoSegundoCliente;
                    txtTelefono.Text = TelefonoCliente;
                    txtEmail.Text = emailCliente;
                    /*pinto en pantalla los datos del Cliente*/
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("***No se Encontro al Proveedor ***", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*------------------------------------------------- Botones --------------------------------------------------------------------*/



        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/
        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

    }/*fin frmVentasFacturacion*/
}/*fin namespace*/
