using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Utils;

namespace Proveeduria
{
    public partial class frmConsultaProductos : Form
    {
        public frmConsultaProductos()
        {
            InitializeComponent();
        }

        private void frmConsultaProductos_Load(object sender, EventArgs e)
        {
            cargarListaProductos("ListaProductos.xml");
        }
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/
        private string conusltaProducto; /*btn Buscar Producto*/
        private int filaSeleccionada;
        private string _categoriProducto = string.Empty;
        private string _codigoProducto = string.Empty;
        private string _nombreProducto = string.Empty;
        private int _cantidadProducto;
        private decimal _precioProducto;

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/

        Producto _Productos;
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        XmlDocument _xmlDoc = new XmlDocument();

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/
        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()) && !Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*------------------------------------------------- Botones --------------------------------------------------------------------*/
        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                conusltaProducto = txtBuscarCodigo.Text.ToUpper(); /*obtengo el DNI a consultar*/

                lvwListaProductos.Items.Clear();/*limieza del listview*/
                XmlDocument xmlDoc = _ArchivoXML.leerXML("ListaProductos.xml"); /*lectura del XML*/

                XmlNode _nodoCliente = xmlDoc.SelectSingleNode($"//Producto[CodigoProducto='{conusltaProducto}']");

                /* se realiza la busqueda en todos los nodos "Hijo /
				  [NumeroIdentificacion='{consultaDNI}'] es una exprecion de busqueda en los atributos Id con un valor igual al de la variable consultaDNI  "*/

                if (_nodoCliente != null)
                {
                    ListViewItem _itemDNI = new ListViewItem(_nodoCliente.SelectSingleNode("CategoriaProducto").InnerText);/*se realiza la busqueda en el XML*/

                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("CodigoProducto").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("NombreProducto").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("CantidadProducto").InnerText);
                    _itemDNI.SubItems.Add(_nodoCliente.SelectSingleNode("PrecioProducto").InnerText);
                    /*Obtengo los datos */

                    lvwListaProductos.Items.Add(_itemDNI); /*Agrego los datos al listview*/

                    if (filaSeleccionada != null)
                    {
                        ListViewItem itemSeleccionado = lvwListaProductos.Items[filaSeleccionada];
                        if (filaSeleccionada != -1)
                        {
                            _categoriProducto = itemSeleccionado.SubItems[0].Text;
                            _codigoProducto = itemSeleccionado.SubItems[1].Text;
                            _nombreProducto = itemSeleccionado.SubItems[2].Text;
                            _cantidadProducto = Convert.ToInt32(itemSeleccionado.SubItems[3].Text);
                            _precioProducto = Convert.ToInt32(itemSeleccionado.SubItems[4].Text);
                            /*obtengo los datos del listview*/


                            txtCategoriaModificar.Text = _categoriProducto.ToUpper();
                            txtProductoModificar.Text = _nombreProducto.ToUpper();
                            txtCantidadModificar.Text = _cantidadProducto.ToString();
                            txtPrecioModificar.Text = _precioProducto.ToString();
                            /*pinto los datos en los texbox*/
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encotro al Producto con el ID: " + conusltaProducto, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Text = string.Empty;
            cargarListaProductos("ListaProductos.xml");
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarDatosProductosNuevos();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _Productos = new Producto()
                {
                    CategoriaProducto = txtCategoriaProducto.Text.ToUpper(),
                    NombreProducto = txtProductoNombre.Text.ToUpper(),
                    CantidadProducto = Convert.ToInt32(txtCantidadProducto.Text),
                    PrecioUndProducto = Convert.ToInt32(txtPrecioUndProducto.Text),
                };


                _Productos.grabarXMLProductos("ListaProductos.xml");/*Genero el XML ListaProductos*/
                MessageBox.Show("Se registro el Producto Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosProductosNuevos();
                cargarListaProductos("ListaProductos.xml");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidroa La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }/*fin btn AgregarProducto*/

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevaCategoriaProducto = txtCategoriaModificar.Text.ToUpper();
                string nuevoNombreProducto = txtProductoModificar.Text.ToUpper();
                string nuevaCantidadProducto = (txtCantidadModificar.Text);
                string nuevoPrecioProducto = (txtPrecioModificar.Text);

                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CategoriaProducto", nuevaCategoriaProducto);
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/NombreProducto", nuevoNombreProducto);
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CantidadProducto", nuevaCantidadProducto);
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/PrecioProducto", nuevoPrecioProducto);

                MessageBox.Show("*** Producto Modificado con Exito ***", "Dostribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cargarListaProductos("ListaProductos.xml");
                LimpiarDatosProductosModificados();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Modificar el Producto", "Dostribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*se realiza la sobre esctritura del XML*/
        }/*fin btnModificar_Click*/
        private void btnLimpiarModificar_Click(object sender, EventArgs e)
        {
            LimpiarDatosProductosModificados();
        }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public void cargarListaProductos(string rutaArchivo)
        {
            lvwListaProductos.Items.Clear();

            XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo); /*realizo la lectura del archivo*/

            XmlNodeList _Productos = xmlDoc.SelectNodes("//Producto");   /*obtengo los nodos del XML*/

            foreach (XmlNode cliente in _Productos)
            {
                string CategoriaProducto = cliente.SelectSingleNode("CategoriaProducto").InnerText;
                string NombreProducto = cliente.SelectSingleNode("NombreProducto").InnerText;
                string CodigoProducto = cliente.SelectSingleNode("CodigoProducto").InnerText;
                string CantidadProducto = cliente.SelectSingleNode("CantidadProducto").InnerText;
                string PrecioProducto = cliente.SelectSingleNode("PrecioProducto").InnerText;


                int cantidad = Convert.ToInt32(CantidadProducto);
                double precioUND = Convert.ToInt32(PrecioProducto);
                double costoTotal = cantidad * precioUND;

                /*obtengo los datos del XML y los almacelo en las variables*/
                ListViewItem itemCliente = new ListViewItem(
                    new[] { CategoriaProducto, CodigoProducto, NombreProducto, CantidadProducto, PrecioProducto, costoTotal.ToString() });
                /*pinto los datos en el ListView */

                lvwListaProductos.Items.Add(itemCliente);

            }/*iteracion por los nodos */

        }/*fin cargarLista Productos*/

        public void LimpiarDatosProductosNuevos()
        {
            txtCategoriaProducto.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
            txtCantidadProducto.Text = string.Empty;
            txtPrecioUndProducto.Text = string.Empty;
        } /*fin limpiarDatos*/

        public void LimpiarDatosProductosModificados()
        {
            txtCategoriaModificar.Text = string.Empty;
            txtProductoModificar.Text = string.Empty;
            txtCantidadModificar.Text = string.Empty;
            txtPrecioModificar.Text = string.Empty;
            txtBuscarCodigo.Text = string.Empty;
        } /*fin limpiarDatos*/


    }/*fin frmConsultaProductos*/
}/*fin namespace*/
