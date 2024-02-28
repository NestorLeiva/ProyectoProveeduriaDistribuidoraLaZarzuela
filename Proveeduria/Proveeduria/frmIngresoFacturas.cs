using BLL;
using System.Xml;
using Utils;

namespace Proveeduria
{
    public partial class frmIngresoFacturas : Form
    {
        public frmIngresoFacturas()
        {
            InitializeComponent();
        }

        private void frmRegistroProductos_Load(object sender, EventArgs e) { }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        private string consultarCodProveedor; /*btn Buscar Proveedor*/

        IngresoFacturas _IngresoFacturas;
        public Productos _Productos; 




        string codSeleccionado = string.Empty;
        string nomSeleccionado = string.Empty;
        string dniSeleccionado = string.Empty;
        string telefonoSeleccionado = string.Empty;
        string emailSeleccionado = string.Empty;



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
                consultarCodProveedor = this.txtBuscarProveedor.Text;
                XmlDocument xmlDoc = _ArchivoXML.leerXML("Proveedores.xml");

                XmlNode _nodoProveedor = xmlDoc.SelectSingleNode($"//Proveedor[CodigoProveedor='{consultarCodProveedor}']");

                if (_nodoProveedor != null)
                {
                    codSeleccionado = _nodoProveedor.SelectSingleNode("CodigoProveedor").InnerText;
                    nomSeleccionado = _nodoProveedor.SelectSingleNode("NombreProveedor").InnerText;
                    dniSeleccionado = _nodoProveedor.SelectSingleNode("Identificacion").InnerText;
                    telefonoSeleccionado = _nodoProveedor.SelectSingleNode("TelefonoProveedor").InnerText;
                    emailSeleccionado = _nodoProveedor.SelectSingleNode("EmailProveedor").InnerText;
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
        }

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
                    _Productos = _Productos,
                };
                _IngresoFacturas.grabarXMLFactura("FacturasCompra.xml"); /*Escribo el XML*/

                
                MessageBox.Show("Se registro la Factura y Producto Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }/*fin btn Aceptar*/

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _Productos = new Productos()
                {
                    CategoriaProducto = txtCategoriaProducto.Text.ToUpper(),
                    NombreProducto = txtProductoNombre.Text.ToUpper(),
                    CantidadProducto = Convert.ToInt32(txtCantidadProducto.Text),
                    PrecioUndProducto = Convert.ToInt32(txtPrecioUndProducto.Text),
                };
                _Productos.grabarXMLProductos("ListaProductos.xml");
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
        }/*fin Limpiar Datos Proveedor*/

        public void LimpiarDatosProductos()
        {
            txtCategoriaProducto.Text = string.Empty;
            txtProductoNombre.Text = string.Empty;
            txtCantidadProducto.Text = string.Empty;
            txtPrecioUndProducto.Text = string.Empty;
        }/*fin Limpiar Datos Proveedor*/


    }
}
