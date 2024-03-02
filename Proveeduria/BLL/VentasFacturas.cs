using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class VentasFacturas : Cliente
    {

        public VentasFacturas() { }

        public VentasFacturas(string codigoProveedor, string nombreProveedor, string dniProveedor, string telProveedor, string emailProveedor, DateTime fechaFactura, int numeroFactura, double montoIVA, double subTotal, double total, XmlDocument xmlDocCliente, ArchivoXML archivoXML, List<Cliente> listaCliente, List<Producto> listaProductos, Producto productos, Cliente cliente)
        {
            this.codigoProveedor = codigoProveedor;
            this.nombreProveedor = nombreProveedor;
            this.dniProveedor = dniProveedor;
            this.telProveedor = telProveedor;
            this.emailProveedor = emailProveedor;
            this.fechaFactura = fechaFactura;
            this.numeroFactura = numeroFactura;
            this.montoIVA = montoIVA;
            this.subTotal = subTotal;
            this.total = total;
            this.xmlDocCliente = xmlDocCliente;
            _ArchivoXML = archivoXML;
            _ListaCliente = listaCliente;
            _ListaProductos = listaProductos;
            _Productos = productos;
            _Cliente = cliente;
        }


        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string codigoProveedor = string.Empty;
        private string nombreProveedor = string.Empty;
        private string dniProveedor = string.Empty;
        private string telProveedor = string.Empty;
        private string emailProveedor = string.Empty;
        private DateTime fechaFactura;
        private int numeroFactura;
        //private int montoFactura;
        private double montoIVA = 0.13;
        private double subTotal;
        private double total;

        private static int ConsecutivoVentaFactura = 1;


        XmlDocument xmlDocCliente = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        public List<Cliente> _ListaCliente { get; set; } = new List<Cliente>();
        public List<Producto> _ListaProductos { get; set; } = new List<Producto>();
        public Producto _Productos ;
        public Cliente _Cliente;

  

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/


        public string CodigoProveedor { get { return codigoProveedor; } set { codigoProveedor = value; } }
        public string NombreProveedor { get { return nombreProveedor; } set { nombreProveedor = value; } }
        public string DniProveedor { get { return dniProveedor; } set { dniProveedor = value; } }
        public string TelefonoProveedor { get { return telProveedor; } set { telProveedor = value; } }
        public string EmailProveedor{ get { return emailProveedor; } set { emailProveedor = value; } }
        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public int NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        //public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }
        public double SubTotal { get { return subTotal; } set {  subTotal = value; } }
        public double Total { get { return total; } set {  total = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoFacturaCompra()
        {
            return "FV-" + ConsecutivoVentaFactura ++;
        }/*fin generarCodigoFactura*/

      

        public void setFechaFactura(DateTime fecha)
        {
            FechaFactura = fecha;
        }


        public void grabarXMLFactura(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocCliente = _ArchivoXML.leerXML(rutaArchivo);

            }
            else
            {
                /*Nodo Facturas*/
                XmlNode xmlRoot = xmlDocCliente.CreateElement("FacturasVenta");
                xmlDocCliente.AppendChild(xmlRoot);
            }
            /*Nodo Factura*/
            XmlNode xmlFactura = xmlDocCliente.CreateElement("Factura");
            xmlDocCliente.DocumentElement.AppendChild(xmlFactura);

            /* ----------------------------------- Cliente --------------------------------------*/

            /*nodo # identificacion*/
            XmlNode xmlNumIdentificacion = xmlDocCliente.CreateElement("NumeroIdentificacion");
            xmlNumIdentificacion.InnerText = this.DNI.ToString();
            xmlFactura.AppendChild(xmlNumIdentificacion);

            /*nodo Tipo de Identificacion*/
            XmlNode xmlTipoIdentificacion = xmlDocCliente.CreateElement("TipoIdentificacion");
            xmlTipoIdentificacion.InnerText = this.TipoDni;
            xmlFactura.AppendChild(xmlTipoIdentificacion);

            /*nodo nombre*/
            XmlNode xmlNombre = xmlDocCliente.CreateElement("Nombre");
            xmlNombre.InnerText = this.Nombre;
            xmlFactura.AppendChild(xmlNombre);

            /*nodo ApellidoPrimero*/
            XmlNode xmlApellidoPrimero = xmlDocCliente.CreateElement("ApellidoPrimero");
            xmlApellidoPrimero.InnerText = this.ApellidoPrimero;
            xmlFactura.AppendChild(xmlApellidoPrimero);

            /*nodo ApellidoSegundo*/
            XmlNode xmlApellidoSegundo = xmlDocCliente.CreateElement("ApellidoSegundo");
            xmlApellidoSegundo.InnerText = this.ApellidoSegundo;
            xmlFactura.AppendChild(xmlApellidoSegundo);

            /*nodo CodigoCliente*/
            XmlNode xmlCodigoCliente = xmlDocCliente.CreateElement("CodigoCliente");
            xmlCodigoCliente.InnerText = generarCodCliente();
            xmlFactura.AppendChild(xmlCodigoCliente);

            /*nodo Telefono*/
            XmlNode xmlTelefono = xmlDocCliente.CreateElement("Telefono");
            xmlTelefono.InnerText = this.Telefono.ToString();
            xmlFactura.AppendChild(xmlTelefono);

            /*nodo Email*/
            XmlNode xmlEmail = xmlDocCliente.CreateElement("Email");
            xmlEmail.InnerText = this.Email;
            xmlFactura.AppendChild(xmlEmail);

            /* ----------------------------------- Factura --------------------------------------*/
            /*Nodo FechaFactura */
            XmlNode xmlFechaFactura = xmlDocCliente.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString("dd/MM/yyyy");
            xmlFactura.AppendChild(xmlFechaFactura);

            /*Nodo NumeroFactura */
            XmlNode xmlNumeroFactura = xmlDocCliente.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = this.generarCodigoFacturaCompra(); /*genero el cogido de la factura*/
            xmlFactura.AppendChild(xmlNumeroFactura);

            /*Nodo SubTotalFactura */
            XmlNode xmlsubTotalFactura = xmlDocCliente.CreateElement("SubTotalFactura");
            xmlsubTotalFactura.InnerText = this.SubTotal.ToString();
            xmlFactura.AppendChild(xmlsubTotalFactura);


            /*Nodo MontoIVAFactura */
            XmlNode xmlMontoIVAFactura = xmlDocCliente.CreateElement("MontoIVAFactura");
            xmlMontoIVAFactura.InnerText = MontoIVA.ToString(); /*Calculo del IVA de la factura*/
            xmlFactura.AppendChild(xmlMontoIVAFactura);

            /*Nodo MontoFactura */
            XmlNode xmlTotalFactura = xmlDocCliente.CreateElement("TotalFactura");
            xmlTotalFactura.InnerText = this.Total.ToString();
            xmlFactura.AppendChild(xmlTotalFactura);


            /*------------------------------------------------- Productos --------------------------------------------------------------------*/
            /*Nodo Productos*/
            XmlNode xmlProductos = xmlDocCliente.CreateElement("Productos");
            xmlFactura.AppendChild(xmlProductos);

            foreach (Producto _productosLista in this._ListaProductos)
            {
                /*Nodo Producto*/
                XmlNode _xmlProducto = xmlDocCliente.CreateElement("Producto");
                xmlProductos.AppendChild(_xmlProducto);

                /*Nodo CategoriaProducto*/
                XmlNode _xmlCategoriaProd = xmlDocCliente.CreateElement("CategoriaProducto");
                _xmlCategoriaProd.InnerText = _productosLista.CategoriaProducto;
                _xmlProducto.AppendChild(_xmlCategoriaProd);

                /*Nodo CodigoProducto*/
                XmlNode _xmlCodigoProd = xmlDocCliente.CreateElement("CodigoProducto");
                _xmlCodigoProd.InnerText = _productosLista.CodigoProducto;
                _xmlProducto.AppendChild(_xmlCodigoProd);

                /*Nodo NompreProducto*/
                XmlNode _xmlNombreProd = xmlDocCliente.CreateElement("NombreProducto");
                _xmlNombreProd.InnerText = _productosLista.NombreProducto;
                _xmlProducto.AppendChild(_xmlNombreProd);

                /*Nodo CantidadProducto*/
                XmlNode _xmlCantidadProd = xmlDocCliente.CreateElement("CantidadProducto");
                _xmlCantidadProd.InnerText = _productosLista.CantidadProducto.ToString();
                _xmlProducto.AppendChild(_xmlCantidadProd);

                /*Nodo PrecioProducto*/
                XmlNode _xmlPrecioUndProd = xmlDocCliente.CreateElement("PrecioProducto");
                _xmlPrecioUndProd.InnerText = _productosLista.PrecioUndProducto.ToString();
                _xmlProducto.AppendChild(_xmlPrecioUndProd);

                /*Nodo MontoIva*/
                XmlNode _xmlmontoIvaProd = xmlDocCliente.CreateElement("MontoIVA");
                _xmlmontoIvaProd.InnerText = _productosLista.PrecioUndProducto.ToString();
                _xmlProducto.AppendChild(_xmlmontoIvaProd);


                xmlProductos.AppendChild(_xmlProducto);/*Agrego los nodos Productos a la Factura*/
            } /*fin foreach*/



            _ArchivoXML.escribirXML(rutaArchivo, xmlDocCliente);
        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
