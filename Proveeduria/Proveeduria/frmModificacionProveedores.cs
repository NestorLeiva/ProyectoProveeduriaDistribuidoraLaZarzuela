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
    public partial class frmModificacionProveedores : Form
    {
        public frmModificacionProveedores()
        {
            InitializeComponent();
        }
        private void frmModificacionProveedores_Load(object sender, EventArgs e)
        {
            CargarListaProveedores("Proveedores.xml");
        }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/

        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        Proveedor _Proveedor;
        private int filaSeleccionada;

        private string codigoSeleccionado;
        private string nombreSeleccionado;
        private string IdentificacionSeleccionado;
        private string DniSeleccionado;
        private string TelefonoSeleccionado;
        private string EmailSeleccionado;

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/
        private void txtProveedorNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtProveedorDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtModificarTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
            string numeroTelefono = txtModificarTelefono.Text;

            bool esValido = Validaciones.validarTelefono(numeroTelefono);
            btnProveedorModificar.Enabled = esValido;
            /*se habilita / desabilita dependiendo si el numero es valido o no*/
        }


        /*------------------------------------------------- Botones --------------------------------------------------------------------*/

        private void btnProveedorCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedorLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void btnProveedorModificar_Click(object sender, EventArgs e)
        {
            try
            {

                string nuevoNombre = txtProveedorNombre.Text.ToUpper();
                string telefonoNuevo = txtModificarTelefono.Text;
                string emailNuevo = txtProveedorEmail.Text.ToUpper();
                // Obtener los nuevos valores de los TextBox

                _ArchivoXML.modificarXML("Proveedores.xml", $"//Proveedor[CodigoProveedor='{codigoSeleccionado}']/NombreProveedor", nuevoNombre);
                _ArchivoXML.modificarXML("Proveedores.xml", $"//Proveedor[CodigoProveedor='{codigoSeleccionado}']/TelefonoProveedor", telefonoNuevo);
                _ArchivoXML.modificarXML("Proveedores.xml", $"//Proveedor[CodigoProveedor='{codigoSeleccionado}']/EmailProveedor", emailNuevo);


                MessageBox.Show("Proveedor modificado correctamente.");
                CargarListaProveedores("Proveedores.xml");
                // Recargar la lista después de la modificación
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al modificar el Funcionario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin boton consultar*/

        private void btnProveedorBuscar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada != -1)
            {
                string consultaCodProv = txtProveedorBuscar.Text.ToUpper();
                lvRegistroProveedor.Items.Clear();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Proveedores.xml");

                XmlNode _nodoProveedor = xmlDoc.SelectSingleNode($"//Proveedor[CodigoProveedor='{consultaCodProv}']");
                /* se realiza la busqueda en todos los nodos "Hijo /
                 [Identificacion='{consulta}'] es una exprecion de busqueda en los atributos Id 
                con un valor igual al de la variable consultaId  "*/
                try
                {
                    if (_nodoProveedor != null)
                    {
                        ListViewItem _itemProveedor = new ListViewItem(_nodoProveedor.SelectSingleNode("CodigoProveedor").InnerText);
                        _itemProveedor.SubItems.Add(_nodoProveedor.SelectSingleNode("NombreProveedor").InnerText);
                        _itemProveedor.SubItems.Add(_nodoProveedor.SelectSingleNode("TipoIdentificacion").InnerText);
                        _itemProveedor.SubItems.Add(_nodoProveedor.SelectSingleNode("Identificacion").InnerText);
                        _itemProveedor.SubItems.Add(_nodoProveedor.SelectSingleNode("TelefonoProveedor").InnerText);
                        _itemProveedor.SubItems.Add(_nodoProveedor.SelectSingleNode("EmailProveedor").InnerText);

                        lvRegistroProveedor.Items.Add(_itemProveedor);
                        /*agrego los datos a la lista*/

                        if (_nodoProveedor != null)
                        {
                            ListViewItem _itemSeleccionado = lvRegistroProveedor.Items[filaSeleccionada];

                            if (filaSeleccionada != -1)
                            {
                                codigoSeleccionado = _itemSeleccionado.SubItems[0].Text;
                                nombreSeleccionado = _itemSeleccionado.SubItems[1].Text;
                                IdentificacionSeleccionado = _itemSeleccionado.SubItems[2].Text;
                                DniSeleccionado = _itemSeleccionado.SubItems[3].Text;
                                TelefonoSeleccionado = _itemSeleccionado.SubItems[4].Text;
                                EmailSeleccionado = _itemSeleccionado.SubItems[5].Text;
                                // Obtener los datos de la fila seleccionada

                                txtProveedorCodigo.Text = codigoSeleccionado;
                                txtProveedorNombre.Text = nombreSeleccionado;
                                txtProveedorDNI.Text = IdentificacionSeleccionado;
                                txtProveedorDNI1.Text = DniSeleccionado;
                                txtModificarTelefono.Text = TelefonoSeleccionado;
                                txtProveedorEmail.Text = EmailSeleccionado.ToUpper();
                                /*almaceno los datos en las variables*/
                            }
                        }
                    }  // Obtener el índice de la fila seleccionada
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al cargar la Lista de Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } /*fin boton Buscar*/

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public void LimpiarTextBox()
        {
            txtProveedorBuscar.Text = string.Empty;
            txtProveedorNombre.Text = string.Empty;
            txtProveedorDNI.Text = string.Empty;
            txtProveedorCodigo.Text = string.Empty;
            txtProveedorEmail.Text = string.Empty;
            txtModificarTelefono.Text = string.Empty;
            txtProveedorDNI1.Text = string.Empty;
        } /*fin LimpiarTextBox*/

        private void lvRegistroProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRegistroProveedor.SelectedItems.Count > 0)
            {
                ListViewItem obtenerItemProveedor = lvRegistroProveedor.SelectedItems[0];
                txtProveedorCodigo.Text = obtenerItemProveedor.SubItems[0].Text;
                txtProveedorNombre.Text = obtenerItemProveedor.SubItems[1].Text;
                txtProveedorDNI.Text = obtenerItemProveedor.SubItems[3].Text;
                txtModificarTelefono.Text = obtenerItemProveedor.SubItems[4].Text;
                txtProveedorEmail.Text = obtenerItemProveedor.SubItems[5].Text;

            }
        } /*Cargar TextBox*/

        private void CargarListaProveedores(string rutaArchivo)
        {
            lvRegistroProveedor.Items.Clear();
            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Proveedor = xmlDoc.SelectNodes("//Proveedor"); /*obtengo los nodos del XML*/

            foreach (XmlNode proveedor in _Proveedor)
            {

                string CodProveedor = proveedor.SelectSingleNode("CodigoProveedor").InnerText;
                string Nombre = proveedor.SelectSingleNode("NombreProveedor").InnerText;
                string TipoDNI = proveedor.SelectSingleNode("TipoIdentificacion").InnerText;
                string DNI = proveedor.SelectSingleNode("Identificacion").InnerText;
                string Telefono = proveedor.SelectSingleNode("TelefonoProveedor").InnerText;
                string Email = proveedor.SelectSingleNode("EmailProveedor").InnerText;

                ListViewItem itemProveedor = new ListViewItem(
                    new[] { CodProveedor, Nombre, TipoDNI, DNI, Telefono, Email });
                /*creo el ListView con los datos */

                lvRegistroProveedor.Items.Add(itemProveedor);
                /*Agrego los Items al ListView*/

            }/*iteracion por los nodos */


        } /*fin CargarListaProveedores*/


    }/*fin class FrmModificar*/
}
