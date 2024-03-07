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
    public partial class frmVentasFacturacion : Form
    {
        public frmVentasFacturacion()
        {
            InitializeComponent();
        }

        private void frmVentasFacturacion_Load(object sender, EventArgs e)
        {
            _lstProductos = new List<Producto>();
            _Productos = new Producto();
            _VentasFactura = new VentasFacturas();

        }
        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        XmlDocument xmlDoc = new XmlDocument();
        Producto _Productos;
        Cliente _Clientes;
        VentasFacturas _VentasFactura;
        List<Producto> _lstProductos;
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/
        private string consutlaCliente = string.Empty;
        private string conusltaProducto = string.Empty;

        string codigoCliente = string.Empty;
        string tipoIdentificacionCliente = string.Empty;
        int identificacionCliente;
        string NombreCliente = string.Empty;
        string ApellidoPrimeroCliente = string.Empty;
        string ApellidoSegundoCliente = string.Empty;
        int TelefonoCliente;
        string emailCliente = string.Empty;

        double ivaAcumulado = 0;
        double subtotalAcumulado = 0;
        double totalRes = 0;


        /*------------------------------------------------- TextBox --------------------------------------------------------------------*/
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()) && !Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloLetras(e.KeyChar.ToString()) && !Validaciones.soloNumeros(e.KeyChar))
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

        private void txtPagoEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Validaciones.soloNumeros(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /*------------------------------------------------- Botones --------------------------------------------------------------------*/
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                consutlaCliente = this.txtBuscarCliente.Text.ToUpper();
                xmlDoc = _ArchivoXML.leerXML("Clientes.xml");

                XmlNode _nodoBuscarCliente = xmlDoc.SelectSingleNode($"//Cliente[CodigoCliente='{consutlaCliente}']");

                if (_nodoBuscarCliente != null)
                {
                    codigoCliente = _nodoBuscarCliente.SelectSingleNode("CodigoCliente").InnerText;
                    tipoIdentificacionCliente = _nodoBuscarCliente.SelectSingleNode("TipoIdentificacion").InnerText;
                    identificacionCliente = Convert.ToInt32(_nodoBuscarCliente.SelectSingleNode("NumeroIdentificacion").InnerText);
                    NombreCliente = _nodoBuscarCliente.SelectSingleNode("Nombre").InnerText;
                    ApellidoPrimeroCliente = _nodoBuscarCliente.SelectSingleNode("ApellidoPrimero").InnerText;
                    ApellidoSegundoCliente = _nodoBuscarCliente.SelectSingleNode("ApellidoSegundo").InnerText;
                    TelefonoCliente = Convert.ToInt32(_nodoBuscarCliente.SelectSingleNode("Telefono").InnerText);
                    emailCliente = _nodoBuscarCliente.SelectSingleNode("Email").InnerText;
                    /* Obtengo los datos del cliente */

                    txtCodigoCliente.Text = codigoCliente;
                    txtTipoIdentificacion.Text = tipoIdentificacionCliente;
                    txtIdntificacion.Text = identificacionCliente.ToString();
                    txtNombre.Text = NombreCliente;
                    txtApellidoPrimero.Text = ApellidoPrimeroCliente;
                    txtApellidoSegundo.Text = ApellidoSegundoCliente;
                    txtTelefono.Text = TelefonoCliente.ToString();
                    txtEmail.Text = emailCliente;
                    /*pinto en pantalla los datos del Cliente*/
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("***No se Encontro al Proveedor ***", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*fin btnAgregarProducto*/
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                conusltaProducto = this.txtCodigoProducto.Text.ToUpper();
                XmlDocument xmlDoc = _ArchivoXML.leerXML("ListaProductos.xml");

                XmlNodeList nodosProducto = xmlDoc.SelectNodes($"//Producto[CodigoProducto='{conusltaProducto}']");
                if (nodosProducto.Count > 0)
                {
                    int cantidadVenta = Convert.ToInt32(txtCantidadProducto.Text);

                    foreach (XmlNode nodoProducto in nodosProducto)
                    {
                        Producto _Productos = new Producto()
                        {
                            CategoriaProducto = nodoProducto.SelectSingleNode("CategoriaProducto").InnerText,
                            CodigoProducto = nodoProducto.SelectSingleNode("CodigoProducto").InnerText,
                            NombreProducto = nodoProducto.SelectSingleNode("NombreProducto").InnerText,
                            CantidadProducto = Convert.ToInt32(cantidadVenta),
                            PrecioUndProducto = Convert.ToInt32(nodoProducto.SelectSingleNode("PrecioProducto").InnerText),

                        };
                        int totalProductos = cantidadVenta * _Productos.PrecioUndProducto;
                        this._lstProductos.Add(_Productos);
                        ListViewItem itemVenta = new ListViewItem(_Productos.CategoriaProducto);
                        itemVenta.SubItems.Add(_Productos.CodigoProducto);
                        itemVenta.SubItems.Add(_Productos.NombreProducto);
                        itemVenta.SubItems.Add(cantidadVenta.ToString());
                        itemVenta.SubItems.Add(_Productos.PrecioUndProducto.ToString());
                        itemVenta.SubItems.Add(totalProductos.ToString());
                        /*Agrego los datos al listview*/

                        double ivaUnidad = _Productos.CalcularIVA();
                        double subTotal = _Productos.CalcularSubTotal();
                        double total = _Productos.CalcularTotal(ivaUnidad);

                        ivaAcumulado += ivaUnidad;
                        subtotalAcumulado += subTotal;
                        totalRes = (subtotalAcumulado + ivaAcumulado);

                        lblMontoIVARes.Text = ivaAcumulado.ToString(); /*impresion y llamada al metodo */
                        lblSubTotalRes.Text = subtotalAcumulado.ToString();/*/*impresion y llamada al metodo */
                        lblTotalRes.Text = (totalRes).ToString();

                        lvwListaVenta.Items.Add(itemVenta);
                    };
                    restarCantidades();
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
            txtCodigoProducto.Text = string.Empty;
            txtCantidadProducto.Text = string.Empty;
        }/*btnAgregarProducto*/
        private void btnVentasPagar_Click(object sender, EventArgs e)
        {

            _VentasFactura = new VentasFacturas()
            {
                Nombre = txtNombre.Text,
                ApellidoPrimero = txtApellidoPrimero.Text,
                ApellidoSegundo = txtApellidoSegundo.Text,
                DNI = Convert.ToInt32(txtIdntificacion.Text),
                TipoDni = txtTipoIdentificacion.Text,
                CodigoCliente = txtCodigoCliente.Text,
                Telefono = Convert.ToInt32(txtTelefono.Text),
                Email = txtEmail.Text,
                FechaFactura = dtpVentaFecha.Value.Date,

                MontoIVA = Convert.ToInt32(ivaAcumulado),
                MontoSubTotal = Convert.ToInt32(subtotalAcumulado),
                MontoTotal = Convert.ToInt32(totalRes),
                /*-------------------------------------------*/
                _ListaProductos = this._lstProductos

            };
            _VentasFactura.grabarXMLFacturaVentas("FacturasVenta.xml");

            MessageBox.Show("Venta Realizada con Exito", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }/*fin btnPagar*/
        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            lvwListaVenta.Items.Clear();
            LimpiarTextbox();
        }
        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public void LimpiarTextbox()
        {
            txtNombre.Text = string.Empty;
            txtApellidoPrimero.Text = string.Empty;
            txtApellidoSegundo.Text = string.Empty;
            txtIdntificacion.Text = string.Empty;
            txtTipoIdentificacion.Text = string.Empty;
            txtCodigoCliente.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }/*LimpiarTextbox*/
        public void restarCantidades()
        {
            conusltaProducto = this.txtCodigoProducto.Text.ToUpper();
            int valorActual = _Productos.calcularCantidad("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CantidadProducto");

            if (int.TryParse(txtCantidadProducto.Text, out int valorIngresado))
            {
                int nuevoValor = valorActual - valorIngresado;
                _ArchivoXML.modificarXML("ListaProductos.xml", $"//Producto[CodigoProducto='{conusltaProducto}']/CantidadProducto", nuevoValor.ToString());
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido en el TextBox.");
            }
        }/*restarCantidades*/
        private string obtenerTexto(XmlNode node, string nodeName)
        {
            XmlNode childNode = node.SelectSingleNode(nodeName);
            /* SelectSingleNode(nodeName) para encontrar el subnodo con el nombre especificado.*/
            return (childNode != null) ? childNode.InnerText : string.Empty;
            /* Verificamos si el subnodo fue encontrado.
             Si childNode es diferente de null, significa que el subnodo existe y podemos obtener su contenido.
             En ese caso, retornamos el contenido del subnodo, que es el texto dentro del elemento XML.
             Si childNode es null, retornamos una cadena vacía.*/
        }/*funcion auxiliar para MostrarFacturaVenta() para obtner el texto dentro del nodo XML*/


    }/*fin frmVentasFacturacion*/
}/*fin namespace*/
