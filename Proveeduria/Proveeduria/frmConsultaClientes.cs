using DAL;
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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        /* ----------------------------------------------- Objetos -----------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        private string consultaDNI;
        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            cargarListaClientes("Clientes.xml");
        }

        /* ----------------------------------------------- TextBox -----------------------------------------------*/
        private void txtBuscarIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /* ----------------------------------------------- Botones -----------------------------------------------*/
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                consultaDNI = txtBuscarIdentificacion.Text; /*obtengo el DNI a consultar*/

                lvwListaClientes.Items.Clear();/*limieza del listview*/
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Clientes.xml"); /*lectura del XML*/

                XmlNode _nodoCliente = xmlDoc.SelectSingleNode($"//Cliente[NumeroIdentificacion='{consultaDNI}']");
                
                /* se realiza la busqueda en todos los nodos "Hijo /
				  [NumeroIdentificacion='{consultaDNI}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaDNI  "*/

                if (_nodoCliente != null)
                {
                    ListViewItem _itemDNI = new ListViewItem(_nodoCliente.SelectSingleNode("NumeroIdentificacion").InnerText);/*se realiza la busqueda en el XML*/
                    

                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("TipoIdentificacion").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Nombre").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("ApellidoPrimero").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("ApellidoSegundo").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("CodigoCliente").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Telefono").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Email").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Provincia").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Canton").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Distrito").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("OtrasSenias").InnerText);
                    
                    lvwListaClientes.Items.Add(_itemDNI); /*Agrego los datos al listview*/
                   
                }
                else
                {
                    MessageBox.Show("No se encotro al cliente con el ID: " + consultaDNI, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarIdentificacion.Text = string.Empty;
            cargarListaClientes("Clientes.xml");
        }

        /* ----------------------------------------------- Metodos -----------------------------------------------*/
        public void cargarListaClientes(string rutaArchivo)
        {
            lvwListaClientes.Items.Clear();

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
                /*obtengo los datos del XML y los almacelo en las variables*/

                ListViewItem itemCliente = new ListViewItem(
                    new[] { DNI, TipoDNI, CodigoCliente, Nombre, ApellidoPrimero, ApellidoSegundo, Telefono, Email, Provincia, Canton, Distrito, OtrasSenias });
                /*pinto los datos en el ListView */

                lvwListaClientes.Items.Add(itemCliente);

            }/*iteracion por los nodos */

        }/*fin cargarListaClientes*/


    }/*fin frmConsultaClientes*/
}/*fin namespace*/
