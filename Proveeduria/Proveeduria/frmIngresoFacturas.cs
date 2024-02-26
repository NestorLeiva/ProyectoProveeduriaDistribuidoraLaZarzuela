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

        private void frmRegistroProductos_Load(object sender, EventArgs e)
        {
            _lstProductos = new List<Productos>();
        }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        private string consultarCodProveedor;

        List<Productos> _lstProductos;
        IngresoFacturas _ingresoFacturas;

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
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void txtProductoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetrasMayusculas(e.KeyChar.ToString()))
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
                    string codSeleccionado = _nodoProveedor.SelectSingleNode("CodigoProveedor").InnerText;
                    string nomSeleccionado = _nodoProveedor.SelectSingleNode("NombreProveedor").InnerText;

                    string dniSeleccionado = _nodoProveedor.SelectSingleNode("Identificacion").InnerText;
                    string telefonoSeleccionado = _nodoProveedor.SelectSingleNode("TelefonoProveedor").InnerText;
                    string emailSeleccionado = _nodoProveedor.SelectSingleNode("EmailProveedor").InnerText;
                    /* Obtengo los datos del proveedor */

                    txtCodigoProveedor.Text = codSeleccionado;
                    txtNombreProveedor.Text = nomSeleccionado;
                    txtDniProveedor.Text = dniSeleccionado;
                    txtTelefonoProveedor.Text = telefonoSeleccionado;
                    txtEmailProveedor.Text = emailSeleccionado;
                    /* Mostrar los datos en los TextBox*/
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Productos _listaProductos = new Productos()
                {
                    CategoriaProducto = this.txtCategoriaProducto.Text,
                    DescripcionProducto = this.txtProductoNombre.Text,
                    CantidadProducto = Convert.ToInt32(this.txtCantidadProducto.Text),
                    PrecioUndProducto = Convert.ToInt32(this.txtPrecioUndProducto.Text),
                };
                this._lstProductos.Add(_listaProductos);
                /*agrego los datos a la lista*/
                MessageBox.Show("Se agrego el Producto Exitosamente.", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarDatosProductos();
            }
            catch (Exception ex)
            {
                /*Mensaje de error*/
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }/*fin btn Agregar Producto*/

        private void btnAceptarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                _ingresoFacturas = new IngresoFacturas()
                {
                    CodigoProv = txtCodigoProveedor.Text,
                    NombreProv = txtNombreProveedor.Text,
                    FechaFactura = dtpFechaFactura.Value.Date,
                    NumeroFactura = txtNumeroFactura.Text,
                    MontoFactura = Convert.ToInt32(txtMontoFactura.Text),
                    MontoIVA = Convert.ToInt32(txtMontoIvaFactura.Text),
                };
                _ingresoFacturas.grabarXMLFactura("Facturas.xml");
                MessageBox.Show("Se registro la Factura y Producto Exitosamente", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }/*fin btn Aceptar*/

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
