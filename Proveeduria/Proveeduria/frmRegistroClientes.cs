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
    public partial class frmRegistroClientes : Form
    {
        public frmRegistroClientes()
        {
            InitializeComponent();
        }

        private void frmRegistroClientes_Load(object sender, EventArgs e)
        {
            cargarListaClientes("Clientes.xml");
            LimpiarTextBox();
        }

        /* ----------------------------------------------- Objetos -----------------------------------------------*/
        Cliente _Cliente;
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        /* ----------------------------------------------- TextBox -----------------------------------------------*/

        private void txtClienteDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteApellidoPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteApellidoSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }

            string numeroTelefono = txtClienteTelefono.Text;

            bool esValido = Validaciones.validarTelefono(numeroTelefono);
            btnClienteAceptar.Enabled = esValido;
            /*se habilita / desabilita dependiendo si el numero es valido o no*/
        }

        private void txtClienteEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtClienteCanton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteOtrasSenias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        /*----------------------------------------- Botones ------------------------------------------------*/
        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }
        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClienteAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                _Cliente = new Cliente()
                {
                    DNI = Convert.ToInt32(this.txtClienteDNI.Text),
                    TipoDni = cbxClienteTipoDNI.SelectedItem.ToString(), /*obtengo el Item del ComboBox*/
                    Nombre = this.txtClienteNombre.Text.ToUpper(),
                    ApellidoPrimero = this.txtClienteApellidoPrimero.Text.ToUpper(),
                    ApellidoSegundo = this.txtClienteApellidoSegundo.Text.ToUpper(),
                    Telefono = Convert.ToInt32(this.txtClienteTelefono.Text),
                    Email = this.txtClienteEmail.Text.ToUpper(),
                    Provincia = cbxClienteProvincia.SelectedItem.ToString(),/*obtengo el Item del ComboBox*/
                    Canton = this.txtClienteCanton.Text.ToUpper(),
                    Distrito = this.txtClienteDistrito.Text.ToUpper(),
                    OtrasSenias = this.txtClienteOtrasSenias.Text.ToUpper(),

                };/*Inicializacion de la clase*/

                _Cliente.grabarXMLCliente("Clientes.xml"); /*guardo el XML*/


                MessageBox.Show("Registro de Clientes Exitoso", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                cargarListaClientes("Clientes.xml");
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registrar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btn Cliente Aceptar*/

        /*----------------------------------------- Metodos ------------------------------------------------*/

        public void LimpiarTextBox()
        {
            txtClienteDNI.Text = string.Empty;
            txtClienteNombre.Text = string.Empty;
            txtClienteApellidoPrimero.Text = string.Empty;
            txtClienteApellidoSegundo.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteEmail.Text = string.Empty;
            txtClienteCanton.Text = string.Empty;
            txtClienteDistrito.Text = string.Empty;
            txtClienteOtrasSenias.Text = string.Empty;
            cbxClienteProvincia.SelectedIndex = 0;
            cbxClienteTipoDNI.SelectedIndex = 0;
        }/*fin limpiarTextbox*/


        public void cargarListaClientes(string rutaArchivo)
        {
            lvwRegistroClientes.Items.Clear();

            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Clientes = xmlDoc.SelectNodes("//Cliente");   /*obtengo los nodos del XML*/

            foreach (XmlNode cliente in _Clientes)
            {
                string DNI = cliente.SelectSingleNode("NumeroIdentificacion").InnerText;
                string TipoDNI = cliente.SelectSingleNode("TipoIdentificacion").InnerText;
                string Nombre = cliente.SelectSingleNode("Nombre").InnerText;
                string ApellidoPrimero = cliente.SelectSingleNode("ApellidoPrimero").InnerText;
                string ApellidoSegundo = cliente.SelectSingleNode("ApellidoSegundo").InnerText;
                string CodigoCliente = cliente.SelectSingleNode("CodigoCliente").InnerText;
                string Telefono = cliente.SelectSingleNode("Telefono").InnerText;
                string Email = cliente.SelectSingleNode("Email").InnerText;
                string Provincia = cliente.SelectSingleNode("Provincia").InnerText;
                string Canton = cliente.SelectSingleNode("Canton").InnerText;
                string Distrito = cliente.SelectSingleNode("Distrito").InnerText;
                string OtrasSenias = cliente.SelectSingleNode("OtrasSenias").InnerText;

                ListViewItem itemCliente = new ListViewItem(
                    new[] { DNI,TipoDNI,Nombre,ApellidoPrimero,ApellidoSegundo,CodigoCliente,Telefono, Email,Provincia,Canton, Distrito,OtrasSenias});
                /*creo el ListView con los datos */

                lvwRegistroClientes.Items.Add(itemCliente);

            }/*iteracion por los nodos */

        }/*fin cargarListaClientes*/

    }/*fin frmRegistroClientes*/
}/*fin namespace*/
