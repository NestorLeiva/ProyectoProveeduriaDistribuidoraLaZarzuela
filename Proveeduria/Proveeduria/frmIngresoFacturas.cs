using BLL;
using System.Runtime.Intrinsics.X86;
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
        private int totalProductos = 0;

        IngresoFacturas _IngresoFacturas;
        List<Producto> _lstProductos;
        public Producto _Productos = new Producto();

        string codSeleccionado = string.Empty;
        string nomSeleccionado = string.Empty;
        string dniSeleccionado = string.Empty;
        string telefonoSeleccionado = string.Empty;
        string emailSeleccionado = string.Empty;

        string busqCategoriaSeleccionado = string.Empty; /* btnBuscarProducto*/
        string busqProductoSeleccionado = string.Empty;  /* btnBuscarProducto*/
        string busqCantidadSeleccionado = string.Empty;  /* btnBuscarProducto*/
        string busqPrecioSeleccionado = string.Empty;    /* btnBuscarProducto*/





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

        private void txtPrecioUndProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
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

            txtCategoriaProducto.Enabled = true;
            txtProductoNombre.Enabled = true;
            txtCantidadProducto.Enabled = true;
            txtPrecioUndProducto.Enabled = true;
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            this.Close();
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
            catch (Exception)
            {
                MessageBox.Show("***No se Encontro al Proveedor ***", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btnBuscarProveedor */

        private void btnBuscarProducto_Click_1(object sender, EventArgs e)
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
                    txtProductoNombre.Text = busqProductoSeleccionado;
                    txtCantidadProducto.Text = busqCantidadSeleccionado;
                    txtPrecioUndProducto.Text = busqPrecioSeleccionado;
                }
                else
                {
                    MessageBox.Show("Producto No encontrado", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } /*btnBuscarProducto_Click*/

        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                conusltaProducto = this.txtBuscarProductoCodigo.Text.ToUpper();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("ListaProductos.xml");

                XmlNodeList nodosProducto = xmlDoc.SelectNodes($"//Producto[CodigoProducto='{conusltaProducto}']");
                if (nodosProducto.Count > 0)
                {
                    int cantidadCompraUnd = Convert.ToInt32(txtCantidadProducto.Text);
                    int precioProducto = Convert.ToInt32(txtPrecioUndProducto.Text);

                    foreach (XmlNode nodoProducto in nodosProducto)
                    {
                        Producto _Productos = new Producto()
                        {
                            CategoriaProducto = nodoProducto.SelectSingleNode("CategoriaProducto").InnerText,
                            CodigoProducto = nodoProducto.SelectSingleNode("CodigoProducto").InnerText,
                            NombreProducto = nodoProducto.SelectSingleNode("NombreProducto").InnerText,
                            CantidadProducto = Convert.ToInt32(cantidadCompraUnd),
                            PrecioUndProducto = Convert.ToInt32(precioProducto),

                        };
                        totalProductos = (cantidadCompraUnd * _Productos.PrecioUndProducto);
                        this._lstProductos.Add(_Productos);
                        ListViewItem itemVenta = new ListViewItem(_Productos.CategoriaProducto);
                        itemVenta.SubItems.Add(_Productos.CodigoProducto);
                        itemVenta.SubItems.Add(_Productos.NombreProducto);
                        itemVenta.SubItems.Add(cantidadCompraUnd.ToString());
                        itemVenta.SubItems.Add(precioProducto.ToString());
                        itemVenta.SubItems.Add(totalProductos.ToString());
                        /*Agrego los datos al listview*/

                        lvwListaProductos.Items.Add(itemVenta);
                    };
                    SumarCantidades();
                    MessageBox.Show("Se registro el Producto Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Producto no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("*** No se Encontro el Producto ***", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } /*btnAgregarProducto_Click*/

        private void btnAceptarProducto_Click_1(object sender, EventArgs e)
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

            }
            catch (Exception)
            {
                MessageBox.Show("*** Error al Guardar la Factura *** ", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*btnAceptarProducto_Click*/

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            LimpiarDatosProductos();
            LimpiarDatosProveedor();
            lvwListaProductos.Items.Clear();
        }
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

        public void SumarCantidades()
        {
            int valorActual = _Productos.calcularCantidad("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CantidadProducto");
            int TotalProductos = Convert.ToInt32(txtPrecioUndProducto.Text);

            if (int.TryParse(txtCantidadProducto.Text, out int valorIngresado))
            {
                int nuevoValor = valorActual + valorIngresado;
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CantidadProducto", nuevoValor.ToString());
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/PrecioProducto", TotalProductos.ToString());

            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido en el TextBox.");
            }
        }/*SumarCantidades*/

        private string obtenerTexto(XmlNode node, string nodeName)
        {
            XmlNode childNode = node.SelectSingleNode(nodeName);
            /* SelectSingleNode(nodeName) para encontrar el subnodo con el nombre especificado.*/
            return (childNode != null) ? childNode.InnerText : string.Empty;
            /* Verificamos si el subnodo fue encontrado.
             Si childNode es diferente de null, significa que el subnodo existe y podemos obtener su contenido.
             En ese caso, retornamos el contenido del subnodo, que es el texto dentro del elemento XML.
             Si childNode es null, retornamos una cadena vacía.*/
        }/*funcion auxiliar para MostrarFactura() para obtner el texto dentro del nodo XML*/


    } /*fin frmIngresoFacturas*/
}/*fin namespace*/
