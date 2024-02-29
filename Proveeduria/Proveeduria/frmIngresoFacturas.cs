﻿using BLL;
using System.Xml;
using System.Xml.Linq;
using Utils;

namespace Proveeduria
{
    public partial class frmIngresoFacturas : Form
    {
        public frmIngresoFacturas()
        {
            InitializeComponent();
        }

        private void frmRegistroProductos_Load(object sender, EventArgs e) { _lstProductos = new List<Producto>(); }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        private string consultarCodProveedor; /*btn Buscar Proveedor*/
        private string conusltaProducto; /*btn Buscar Producto*/
        private string rutaArchivo = "FacturasCompra.xml";

        IngresoFacturas _IngresoFacturas;
        List<Producto> _lstProductos;
        public Producto _Productos;

        string codSeleccionado = string.Empty;
        string nomSeleccionado = string.Empty;
        string dniSeleccionado = string.Empty;
        string telefonoSeleccionado = string.Empty;
        string emailSeleccionado = string.Empty;

        string busqCategoriaSeleccionado = string.Empty;
        string busqProductoSeleccionado = string.Empty;
        string busqCantidadSeleccionado = string.Empty;
        string busqPrecioSeleccionado = string.Empty;

        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/
        private void txtNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMontoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMontoIvaFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCategoriaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUndProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtBuscarProductoCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()) && !Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*------------------------------------------------- Botones --------------------------------------------------------------------*/
        private void btnLimpiarDatosProveedor_Click(object sender, EventArgs e)
        {
            LimpiarDatosProveedor();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarDatosProductos();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                consultarCodProveedor = this.txtBuscarProveedor.Text.ToUpper();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Proveedores.xml");

                XmlNode _nodoBuscarProveedor = xmlDoc.SelectSingleNode($"//Proveedor[CodigoProveedor='{consultarCodProveedor}']");

                if (_nodoBuscarProveedor != null)
                {
                    codSeleccionado = _nodoBuscarProveedor.SelectSingleNode("CodigoProveedor").InnerText;
                    nomSeleccionado = _nodoBuscarProveedor.SelectSingleNode("NombreProveedor").InnerText;
                    dniSeleccionado = _nodoBuscarProveedor.SelectSingleNode("Identificacion").InnerText;
                    telefonoSeleccionado = _nodoBuscarProveedor.SelectSingleNode("TelefonoProveedor").InnerText;
                    emailSeleccionado = _nodoBuscarProveedor.SelectSingleNode("EmailProveedor").InnerText;
                    /* Obtengo los datos del proveedor */

                    /*pinto en pantalla los datos del Proveedor*/
                    txtCodigoProveedor.Text = codSeleccionado;
                    txtNombreProveedor.Text = nomSeleccionado;
                    txtDniProveedor.Text = dniSeleccionado;
                    txtTelefonoProveedor.Text = telefonoSeleccionado;
                    txtEmailProveedor.Text = emailSeleccionado;
                }
                else
                {
                    MessageBox.Show("Proveedor no encontrado", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btnBuscarProveedor */

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conusltaProducto = this.txtBuscarProductoCodigo.Text.ToUpper();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("ListaProductos.xml");

                XmlNode _nodoBuscarProducto = xmlDoc.SelectSingleNode($"//Producto[CodigoProducto='{conusltaProducto}']");

                if (_nodoBuscarProducto != null)
                {
                    busqCategoriaSeleccionado = _nodoBuscarProducto.SelectSingleNode("CategoriaProducto").InnerText;
                    busqProductoSeleccionado = _nodoBuscarProducto.SelectSingleNode("NombreProducto").InnerText;
                    busqCantidadSeleccionado = _nodoBuscarProducto.SelectSingleNode("CantidadProducto").InnerText;
                    busqPrecioSeleccionado = _nodoBuscarProducto.SelectSingleNode("PrecioProducto").InnerText;
                    /* Obtengo los datos del proveedor */

                    /*pinto en pantalla los datos del Proveedor*/
                    txtCategoriaProducto.Text = busqCategoriaSeleccionado;
                    txtCantidadProducto.Text = busqCantidadSeleccionado;
                    txtProductoNombre.Text = busqPrecioSeleccionado;
                    txtPrecioUndProducto.Text = busqPrecioSeleccionado;

                    // Desactivar los TextBox
                    txtCategoriaProducto.Enabled = false;
                    txtProductoNombre.Enabled = false;
                }
                else
                {
                    // Activo los TextBox
                    txtCategoriaProducto.Enabled = true;
                    txtProductoNombre.Enabled = true;
                    MessageBox.Show("Producto No encontrado", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btnBuscarProducto*/

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _IngresoFacturas = new IngresoFacturas()
                {
                    /*Datos Proveedor*/
                    CodigoProveedor = codSeleccionado,
                    NombreProveedor = nomSeleccionado.ToUpper(),
                    DniProveedor = dniSeleccionado,
                    TelefonoProveedor = telefonoSeleccionado,
                    EmailProveedor = emailSeleccionado.ToUpper(),
                    /*Datos Factura*/
                    FechaFactura = dtpFechaFactura.Value.Date,
                    NumeroFactura = Convert.ToInt32(txtNumeroFactura.Text),
                    MontoFactura = Convert.ToInt32(txtMontoFactura.Text),
                    /*Datos Producto*/
                    _ListaProductos = this._lstProductos
                    /* _ListaProductos Parametro del foreach en BLL.IngresoFactura
                    _lstProductos parametro de la Lista <Productos>*/
                };
                _IngresoFacturas.grabarXMLFactura("FacturasCompra.xml"); /*Escribo el XML*/

                MessageBox.Show("Se registro la Factura Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarDatosProveedor();

                /*muestro los Productos de la Ultima Factura*/
                MostrarFactura(rutaArchivo);
            }
            catch (Exception)
            {
                MessageBox.Show("*** Error al Guardar la Factura *** ", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }/*fin btn Aceptar*/

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

                this._lstProductos.Add(_Productos);/*Agrego los productos al xmlFacturaCompras*/

                _Productos.grabarXMLProductos("ListaProductos.xml");/*Genero el XML ListaProductos*/
                MessageBox.Show("Se registro el Producto Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosProductos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidroa La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }/*fin btn Agregar Productos*/

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/
        public void LimpiarDatosProveedor()
        {
            txtCodigoProveedor.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtDniProveedor.Text = string.Empty;
            txtTelefonoProveedor.Text = string.Empty;
            txtEmailProveedor.Text = string.Empty;
            txtNumeroFactura.Text = string.Empty;
            txtMontoFactura.Text = string.Empty;
            txtMontoIvaFactura.Text = string.Empty;
            txtBuscarProveedor.Text = string.Empty;
        }/*fin Limpiar Datos Proveedor*/

        public void LimpiarDatosProductos()
        {
            txtCategoriaProducto.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
            txtCantidadProducto.Text = string.Empty;
            txtPrecioUndProducto.Text = string.Empty;
            txtBuscarProductoCodigo.Text = string.Empty;
        }/*fin Limpiar Datos Proveedor*/

        public void MostrarFactura(string rutaArchivo)
        {
            try
            {
                XmlDocument xmlDoc = _ArchivoXML.leerXML(rutaArchivo);

                XmlNodeList _ultimaFactura = xmlDoc.SelectNodes("//Factura[last()]/Productos/Producto");
                lvwListaProductos.Items.Clear();

                foreach (XmlNode nodoProducto in _ultimaFactura)
                {
                    string _categoriaProducto = obtenerTexto(nodoProducto, "CategoriaProducto");
                    string _codigoProducto = obtenerTexto(nodoProducto, "CodigoProducto");
                    string _nombreProducto = obtenerTexto(nodoProducto, "NombreProducto");
                    string _cantidadProducto = obtenerTexto(nodoProducto, "CantidadProducto");
                    string _precioProducto = obtenerTexto(nodoProducto, "PrecioProducto");

                    ListViewItem itemProductos = new ListViewItem(new[] 
                    { _categoriaProducto, _codigoProducto, _nombreProducto, _cantidadProducto, _precioProducto });
                    lvwListaProductos.Items.Add(itemProductos);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la Factura", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }/*fin MostrarFactura*/
        private string obtenerTexto(XmlNode node, string nodeName)
        {
            XmlNode childNode = node.SelectSingleNode(nodeName);
            /* SelectSingleNode(nodeName) para encontrar el subnodo con el nombre especificado.*/
            return (childNode != null) ? childNode.InnerText : string.Empty;
            /* Verificamos si el subnodo fue encontrado.
             Si childNode es diferente de null, significa que el subnodo existe y podemos obtener su contenido.
             En ese caso, retornamos el contenido del subnodo, que es el texto dentro del elemento XML.
             Si childNode es null, retornamos una cadena vacía.*/
        }/*funcion auxiliar para obtner el texto dentro del nodo XML*/

    } /*fin frmIngresoFacturas*/
}/*fin namespace*/
