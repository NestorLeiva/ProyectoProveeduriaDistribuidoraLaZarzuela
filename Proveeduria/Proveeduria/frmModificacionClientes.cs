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
    public partial class frmModificacionClientes : Form
    {
        public frmModificacionClientes()
        {
            InitializeComponent();
        }

        private void frmModificacionClientes_Load(object sender, EventArgs e)
        {
            LimpiarTexBox();
            CargarListaClientes("Clientes.xml");
        }

        /* ----------------------------------------------- Objetos -----------------------------------------------*/
        Cliente _Cliente;
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        private int filaSeleccionada;
        private string consultaDNI;

        /* ----------------------------------------------- textbox -----------------------------------------------*/
        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteApellidoPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        private void txtClienteApellidoSegundo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
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
            btnClienteModificar.Enabled = esValido;
            /*se habilita / desabilita dependiendo si el numero es valido o no*/
        }

        private void txtClienteEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteCanton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteDistrito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtClienteOtrasSenias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }


        /* ----------------------------------------------- Botones -----------------------------------------------*/

        private void btnClienteLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexBox();
        }

        private void btnClienteCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificarBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                consultaDNI = txtBuscarDNI.Text; /*obtengo el DNI a consultar*/
                lvwRegistroClientes.Items.Clear();/*limieza del listview*/
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Clientes.xml"); /*lectura del XML*/

                XmlNode _nodoCliente = xmlDoc.SelectSingleNode($"//Cliente[NumeroIdentificacion='{consultaDNI}']");
                /* se realiza la busqueda en todos los nodos "Hijo /
				  [NumeroIdentificacion='{consultaDNI}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaDNI  "*/

                if (_nodoCliente != null)
                {
                    ListViewItem _itemCliente = new ListViewItem(_nodoCliente.SelectSingleNode("NumeroIdentificacion").InnerText);/*se realiza la busqueda en el XML*/

                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("TipoIdentificacion").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Nombre").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("ApellidoPrimero").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("ApellidoSegundo").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("CodigoCliente").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Telefono").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Email").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Provincia").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Canton").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("Distrito").InnerText);
                    _itemCliente.SubItems.Add(_nodoCliente.SelectSingleNode("OtrasSenias").InnerText);

                    lvwRegistroClientes.Items.Add(_itemCliente); /*Agrego los datos al listview*/

                    if (_nodoCliente != null)
                    {
                        ListViewItem itemSeleccionado = lvwRegistroClientes.Items[filaSeleccionada];
                        if (filaSeleccionada != -1)
                        {
                            string TipoDniClienteSeleccionado = itemSeleccionado.SubItems[0].Text;
                            string NumDniSeleccionado = itemSeleccionado.SubItems[1].Text;
                            string NombreSeleccionado = itemSeleccionado.SubItems[2].Text;
                            string ApellidoPrimeroSeleccionado = itemSeleccionado.SubItems[3].Text;
                            string ApellidoSegungoSeleccionado = itemSeleccionado.SubItems[4].Text;
                            string CodClienteSeleccionado = itemSeleccionado.SubItems[5].Text;
                            string telefonoSeleccionado = itemSeleccionado.SubItems[6].Text;
                            string EmailSeleccionado = itemSeleccionado.SubItems[7].Text;
                            string ProvinciaSeleccionado = itemSeleccionado.SubItems[8].Text;
                            string CantonSeleccionado = itemSeleccionado.SubItems[9].Text;
                            string DistritoSeleccionado = itemSeleccionado.SubItems[10].Text;
                            string OtrasSeniasSeleccionado = itemSeleccionado.SubItems[11].Text;
                            /*almaceno los datos en las variables*/
                            
                            txtClienteDNI.Text = TipoDniClienteSeleccionado;
                            txtClienteNombre.Text = NombreSeleccionado;
                            txtClienteApellidoPrimero.Text = ApellidoPrimeroSeleccionado;
                            txtClienteApellidoSegundo.Text = ApellidoSegungoSeleccionado;
                            txtClienteCodigo.Text = CodClienteSeleccionado;
                            txtClienteTelefono.Text = telefonoSeleccionado;
                            txtClienteEmail.Text = EmailSeleccionado;
                            cbxClienteProvincia.SelectedItem = ProvinciaSeleccionado;
                            txtClienteCanton.Text = CantonSeleccionado;
                            txtClienteDistrito.Text = DistritoSeleccionado;
                            txtClienteOtrasSenias.Text = OtrasSeniasSeleccionado;
                            /*pinta los datos en los TextBox*/

                        }// Obtener los datos de la fila seleccionada
                    }
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
        }/*fin btn Buscar*/


        private void btnClienteModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (filaSeleccionada != -1)
                {

                    string nuevoClienteNombre = this.txtClienteNombre.Text.ToUpper();
                    string nuevoApellidoPrimero = txtClienteApellidoPrimero.Text.ToUpper();
                    string nuevoApellidoSegundo = txtClienteApellidoSegundo.Text.ToUpper();
                    string nuevoTelefono = txtClienteTelefono.Text.ToUpper();
                    string nuevoEmail = txtClienteEmail.Text.ToUpper();
                    string nuevoProvincia = cbxClienteProvincia.SelectedItem.ToString();
                    string nuevoCanton = txtClienteCanton.Text.ToUpper();
                    string nuevoDistrito = txtClienteDistrito.Text.ToUpper();
                    string nuevoOtrasSenias = txtClienteOtrasSenias.Text.ToUpper();

                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Nombre", nuevoClienteNombre);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/ApellidoPrimero", nuevoApellidoPrimero);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/ApellidoSegundo", nuevoApellidoSegundo);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Telefono", nuevoTelefono);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Email", nuevoEmail);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Provincia", nuevoProvincia);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Canton", nuevoCanton);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/Distrito", nuevoDistrito);
                    _ArchivoXML.modificarXML("Clientes.xml", $"//Cliente[NumeroIdentificacion='{consultaDNI}']/OtrasSenias", nuevoOtrasSenias);
                    /*Guardo los nuevos Datos en el XML*/

                    MessageBox.Show("*** Datos del Cliente Modificados con Exito ***", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarTexBox();
                    CargarListaClientes("Clientes.xml");
                }
                else
                {
                    MessageBox.Show("Error al Modificar los Datos del Cliente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Modificar los Datos del Cliente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btn Modificar*/


        /* ----------------------------------------------- Metodos -----------------------------------------------*/
        public void LimpiarTexBox()
        {
            
            txtClienteDNI.Text = string.Empty;
            txtClienteNombre.Text = string.Empty;
            txtClienteApellidoPrimero.Text = string.Empty;
            txtClienteApellidoSegundo.Text = string.Empty;
            txtClienteCodigo.Text = string.Empty;
            txtClienteTelefono.Text = string.Empty;
            txtClienteEmail.Text = string.Empty;

            cbxClienteProvincia.SelectedIndex = 0;
            txtClienteCanton.Text = string.Empty;
            txtClienteDistrito.Text = string.Empty;
            txtClienteOtrasSenias.Text = string.Empty;

        }/*fin LimpiarTexBox*/

        public void CargarListaClientes(string rutaArchivo)
        {

            lvwRegistroClientes.Items.Clear();
            /*limpia la lista*/

            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Clientes = xmlDoc.SelectNodes("//Cliente");
            /*obtengo los nodos del XML*/

            foreach (XmlNode cliente in _Clientes)
            {
                string numDNI = cliente.SelectSingleNode("NumeroIdentificacion").InnerText;
                string tipoDNI = cliente.SelectSingleNode("TipoIdentificacion").InnerText;
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


                ListViewItem itemCliente = new ListViewItem(new[]
                {numDNI, tipoDNI, Nombre, ApellidoPrimero, ApellidoSegundo, CodigoCliente,Telefono, Email, Provincia, Canton, Distrito, OtrasSenias });
                /*creo el ListView con los datos */

                lvwRegistroClientes.Items.Add(itemCliente);
                /*Agrego los Items al ListView*/

            } /*iteracion por los nodos */

        }/*fin CargarListaClientes*/


    }/*fin frmModificacionClientes*/
}/*fin namespace*/
