using BLL;
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
using Utils;

namespace Proveeduria
{
    public partial class frmRegistroProveedores : Form
    {
        public frmRegistroProveedores()
        {
            InitializeComponent();
            cargarListaProveedores("Proveedores.xml");
        }

        Proveedor _Proveedor; /*instancia*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/

        private void txtProveedorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtProveedorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProveedorTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
            string numeroTelefono = txtProveedorTelefono.Text;

            bool esValido = Validaciones.validarTelefono(numeroTelefono);
            btnProveedorAceptar.Enabled = esValido;
            /*se habilita / desabilita dependiendo si el numero es valido o no*/

        }

        /*------------------------------------------------- Botones --------------------------------------------------------------------*/

        private void btnProveedorLimpiar_Click(object sender, EventArgs e)
        {
            txtProveedorDNI.Text = string.Empty;
            txtProveedorEmail.Text = string.Empty;
            txtProveedorNombre.Text = string.Empty;
            txtProveedorTelefono.Text = string.Empty;
        }

        private void btnProveedorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedorAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoDniSeleccionado = "";

                if (rbtnDniJuridico.Checked)
                {
                    tipoDniSeleccionado = "Juridico";
                }
                else if (rbtnDniNacional.Checked)
                {
                    tipoDniSeleccionado = "Nacional";
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona un tipo de DNI.", "Registrar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                /*valido cual opcion del radioButon esta seleccionada y la asigno a la variable*/


                _Proveedor = new Proveedor()
                {
                    Nombre = this.txtProveedorNombre.Text,
                    TipoDni = tipoDniSeleccionado,
                    DNI = Convert.ToInt32(this.txtProveedorDNI.Text),
                    Telefono = Convert.ToInt32(this.txtProveedorTelefono.Text),
                    Email = this.txtProveedorEmail.Text,
                };
                /*inicializo el objeto*/

                _Proveedor.grabarXMLProveedor("Proveedores.xml");
                // ruta para escribir el XML
                MessageBox.Show("*Se Registro al Proveedor Exitosamente*", "Registrar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // mensaje de exito 

                cargarListaProveedores("Proveedores.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registrar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } /*fin boton aceptar*/

        public void cargarListaProveedores(string rutaArchivo)
        {
            lvRegistroProveedor.Items.Clear();
            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo);

            XmlNodeList _Proveedores = xmlDoc.SelectNodes("//Proveedor");

            foreach (XmlNode proveedor in _Proveedores)
            {
                string codProveedor = proveedor.SelectSingleNode("CodigoProveedor").InnerText;
                string nombreProveedor = proveedor.SelectSingleNode("NombreProveedor").InnerText;
                string tipoDNI = proveedor.SelectSingleNode("TipoIdentificacion").InnerText;
                string DNI = proveedor.SelectSingleNode("Identificacion").InnerText;
                string telProveedor = proveedor.SelectSingleNode("TelefonoProveedor").InnerText;
                string emailProveedor = proveedor.SelectSingleNode("EmailProveedor").InnerText;


                ListViewItem itemProveedor = new ListViewItem(
                    new[] { codProveedor, nombreProveedor, tipoDNI, DNI, telProveedor, emailProveedor });
                /*creo el ListView con los datos */

                lvRegistroProveedor.Items.Add(itemProveedor);
                /*Agrego los Items al ListView*/

            } /*iteracion por los nodos */




        }/*fin cargarListaProveedores*/



    }/*fin froms*/
}/*fin namespace*/
