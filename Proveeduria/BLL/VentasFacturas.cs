using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class VentasFacturas : Producto
    {
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string codigoProveedor = string.Empty;
        private string nombreProveedor = string.Empty;
        private string dniProveedor = string.Empty;
        private string telProveedor = string.Empty;
        private string emailProveedor = string.Empty;
        private DateTime fechaFactura;
        private int numeroFactura;
        private int montoFactura;
        private double montoIVA;

        private static int ConsecutivoVentaFactura = 1;


        XmlDocument xmlDocFacturaVenta = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        public List<Producto> _ListaProductos { get; set; } = new List<Producto>();
        public Producto _Productos ;

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/

        
        public string CodigoProveedor { get { return codigoProveedor; } set { codigoProveedor = value; } }
        public string NombreProveedor { get { return nombreProveedor; } set { nombreProveedor = value; } }
        public string DniProveedor { get { return dniProveedor; } set { dniProveedor = value; } }
        public string TelefonoProveedor { get { return telProveedor; } set { telProveedor = value; } }
        public string EmailProveedor{ get { return emailProveedor; } set { emailProveedor = value; } }
        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public int NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoFacturaCompra()
        {
            return "FV-" + ConsecutivoVentaFactura ++;
        }/*fin generarCodigoFactura*/

        public double calcularIVA(double MontoFactura)
        {
            return MontoFactura * 0.13;
        }

        public void setFechaFactura(DateTime fecha)
        {
            FechaFactura = fecha;
        }

        public void grabarXMLFactura(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocFacturaVenta = _ArchivoXML.leerXML(rutaArchivo);

            }
            else
            {
                /*Nodo Facturas*/
                XmlNode xmlRoot = xmlDocFacturaVenta.CreateElement("Facturas");
                xmlDocFacturaVenta.AppendChild(xmlRoot);
            }
            /*Nodo Factura*/
            XmlNode xmlFactura = xmlDocFacturaVenta.CreateElement("Factura");
            xmlDocFacturaVenta.DocumentElement.AppendChild(xmlFactura);

            /* ----------------------------------- Proveedor --------------------------------------*/

            /*Nodo CodigoProveedor */
            XmlNode xmlCodigoProveedor = xmlDocFacturaVenta.CreateElement("CodigoProveedor");
            xmlCodigoProveedor.InnerText = this.CodigoProveedor;
            xmlFactura.AppendChild(xmlCodigoProveedor);

            /*Nodo NombreProveedor */
            XmlNode xmlNombreProveedor = xmlDocFacturaVenta.CreateElement("NombreProveedor");
            xmlNombreProveedor.InnerText = this.NombreProveedor;
            xmlFactura.AppendChild(xmlNombreProveedor);

            /*Nodo IdentificacionProveedor */
            XmlNode xmlDNIProveedor = xmlDocFacturaVenta.CreateElement("IdentificacionProveedor");
            xmlDNIProveedor.InnerText = this.DniProveedor.ToString();
            xmlFactura.AppendChild(xmlDNIProveedor);

            /*Nodo TelefonoProveedor */
            XmlNode xmlTelefonoProveedor = xmlDocFacturaVenta.CreateElement("TelefonoProveedor");
            xmlTelefonoProveedor.InnerText = this.TelefonoProveedor.ToString();
            xmlFactura.AppendChild(xmlTelefonoProveedor);

            /*Nodo EmailProveedor */
            XmlNode xmlEmailProveedor = xmlDocFacturaVenta.CreateElement("EmailProveedor");
            xmlEmailProveedor.InnerText = this.EmailProveedor;
            xmlFactura.AppendChild(xmlEmailProveedor);

            /* ----------------------------------- Factura --------------------------------------*/
            /*Nodo FechaFactura */
            XmlNode xmlFechaFactura = xmlDocFacturaVenta.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString("dd/MM/yyyy");
            xmlFactura.AppendChild(xmlFechaFactura);

            /*Nodo NumeroFactura */
            XmlNode xmlNumeroFactura = xmlDocFacturaVenta.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = this.generarCodigoFacturaCompra(); /*genero el cogido de la factura*/
            xmlFactura.AppendChild(xmlNumeroFactura);

            /*Nodo MontoFactura */
            XmlNode xmlMontoFactura = xmlDocFacturaVenta.CreateElement("MontoFactura");
            xmlMontoFactura.InnerText = this.MontoFactura.ToString();
            xmlFactura.AppendChild(xmlMontoFactura);

            /*Nodo MontoIVAFactura */
            XmlNode xmlMontoIVAFactura = xmlDocFacturaVenta.CreateElement("MontoIVAFactura");
            xmlMontoIVAFactura.InnerText = calcularIVA(MontoFactura).ToString(); /*Calculo del IVA de la factura*/
            xmlFactura.AppendChild(xmlMontoIVAFactura);

            /*------------------------------------------------- Productos --------------------------------------------------------------------*/
            /*Nodo Productos*/
            XmlNode xmlProductos = xmlDocFacturaVenta.CreateElement("Productos");
            xmlFactura.AppendChild(xmlProductos);

            foreach (Producto _productosLista in this._ListaProductos)
            {
                /*Nodo Producto*/
                XmlNode _xmlProducto = xmlDocFacturaVenta.CreateElement("Producto");
                xmlProductos.AppendChild(_xmlProducto);

                /*Nodo CategoriaProducto*/
                XmlNode _xmlCategoriaProd = xmlDocFacturaVenta.CreateElement("CategoriaProducto");
                _xmlCategoriaProd.InnerText = _productosLista.CategoriaProducto;
                _xmlProducto.AppendChild(_xmlCategoriaProd);

                /*Nodo CodigoProducto*/
                XmlNode _xmlCodigoProd = xmlDocFacturaVenta.CreateElement("CodigoProducto");
                _xmlCodigoProd.InnerText = _productosLista.CodigoProducto;
                _xmlProducto.AppendChild(_xmlCodigoProd);

                /*Nodo NompreProducto*/
                XmlNode _xmlNombreProd = xmlDocFacturaVenta.CreateElement("NombreProducto");
                _xmlNombreProd.InnerText = _productosLista.NombreProducto;
                _xmlProducto.AppendChild(_xmlNombreProd);

                /*Nodo CantidadProducto*/
                XmlNode _xmlCantidadProd = xmlDocFacturaVenta.CreateElement("CantidadProducto");
                _xmlCantidadProd.InnerText = _productosLista.CantidadProducto.ToString();
                _xmlProducto.AppendChild(_xmlCantidadProd);

                /*Nodo PrecioProducto*/
                XmlNode _xmlPrecioUndProd = xmlDocFacturaVenta.CreateElement("PrecioProducto");
                _xmlPrecioUndProd.InnerText = _productosLista.PrecioUndProducto.ToString();
                _xmlProducto.AppendChild( _xmlPrecioUndProd);


                xmlProductos.AppendChild(_xmlProducto);/*Agrego los nodos Productos a la Factura*/
            } /*fin foreach*/



            _ArchivoXML.escribirXML(rutaArchivo, xmlDocFacturaVenta);
        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
