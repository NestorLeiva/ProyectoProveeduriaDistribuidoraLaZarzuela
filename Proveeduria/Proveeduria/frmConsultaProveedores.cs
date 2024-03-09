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
    public partial class frmConsultaProveedores : Form
    {
        public frmConsultaProveedores()
        {
            InitializeComponent();
        }

        private void frmConsultaProveedores_Load(object sender, EventArgs e)
        {
            cargarListaProveedores("Proveedores.xml");
        }
        /* ----------------------------------------------- Objetos -----------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        private string consultaDNI;
        /* ----------------------------------------------- TextBox -----------------------------------------------*/
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar) && !Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        /* ----------------------------------------------- Botones -----------------------------------------------*/
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                consultaDNI = txtBuscar.Text.ToUpper(); /*obtengo el DNI a consultar*/

                lvwListaProveedores.Items.Clear();/*limieza del listview*/
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Proveedores.xml"); /*lectura del XML*/

                XmlNode _nodoCliente = xmlDoc.SelectSingleNode($"//Proveedor[CodigoProveedor='{consultaDNI}']");

                /* se realiza la busqueda en todos los nodos "Hijo /
				  [NumeroIdentificacion='{consultaDNI}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaDNI  "*/

                if (_nodoCliente != null)
                {
                    ListViewItem _itemDNI = new ListViewItem(_nodoCliente.SelectSingleNode("CodigoProveedor").InnerText);/*se realiza la busqueda en el XML*/


                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("NombreProveedor").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("TipoIdentificacion").InnerText);;
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("Identificacion").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("TelefonoProveedor").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("EmailProveedor").InnerText);

                    lvwListaProveedores.Items.Add(_itemDNI); /*Agrego los datos al listview*/

                }
                else
                {
                    MessageBox.Show("No se encotro al Proveedor con el ID: " + consultaDNI, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
            cargarListaProveedores("Proveedores.xml");
        }

        /* ----------------------------------------------- Metodos -----------------------------------------------*/

        public void cargarListaProveedores(string rutaArchivo)
        {
            lvwListaProveedores.Items.Clear();

            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Proveedores = xmlDoc.SelectNodes("//Proveedor");   /*obtengo los nodos del XML*/

            foreach (XmlNode _proveedor_ in _Proveedores)
            {
                string codigo = _proveedor_.SelectSingleNode("CodigoProveedor").InnerText;
                string nombre = _proveedor_.SelectSingleNode("NombreProveedor").InnerText;
                string tipoDNI = _proveedor_.SelectSingleNode("TipoIdentificacion").InnerText;
                string Identificacion = _proveedor_.SelectSingleNode("Identificacion").InnerText;
                string telefono = _proveedor_.SelectSingleNode("TelefonoProveedor").InnerText;
                string email = _proveedor_.SelectSingleNode("EmailProveedor").InnerText;

                /*obtengo los datos del XML y los almacelo en las variables*/

                ListViewItem itemCliente = new ListViewItem(
                    new[] { codigo, nombre, tipoDNI, Identificacion, telefono, email });
                /*pinto los datos en el ListView */

                lvwListaProveedores.Items.Add(itemCliente);

            }/*iteracion por los nodos */

        }/*fin cargarListaClientes*/


    }/*fin frmConsultaProveedores*/
}/*fin namespace*/
