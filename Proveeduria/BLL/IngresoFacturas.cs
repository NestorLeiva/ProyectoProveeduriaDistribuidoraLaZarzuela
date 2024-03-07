using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class IngresoFacturas : Producto
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

        XmlDocument xmlDocFacturaCompra = new XmlDocument();
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
            return "FC-" + NumeroFactura;
        }/*fin generarCodigoFactura*/

        public void setFechaFactura(DateTime fecha)
        {
            FechaFactura = fecha;
        }

        public void grabarXMLFactura(string rutaArchivo)
        {

            DateTime fechaNueva = FechaFactura;
            string carpetaMes = Path.Combine(Path.GetDirectoryName(rutaArchivo), fechaNueva.ToString("yyyy-MM")+ " FacturasCompra");
            //string nombreArchivo = $"factura_{this.generarCodigoFacturaCompra}_{fechaFactura.ToString("yyyyMMdd")}.xml";
            string nombreArchivo = $"factura_{this.generarCodigoFacturaCompra()}_{fechaFactura.ToString("yyyyMMdd")}.xml";
            //string rutaCarpeta = Path.Combine(carpetaMes, fechaNueva.ToString("yyyy-MM-dd") + " FacturasCompra.xml");
            string rutaCarpeta = Path.Combine(carpetaMes, nombreArchivo);
            if (File.Exists(rutaCarpeta))
            {
                xmlDocFacturaCompra = _ArchivoXML.leerXML(rutaCarpeta);
            }
            else
            {
                if (!Directory.Exists(carpetaMes))
                {
                    Directory.CreateDirectory(carpetaMes);
                }
                /*Nodo Facturas*/
                XmlNode xmlRoot = xmlDocFacturaCompra.CreateElement("Facturas");
                xmlDocFacturaCompra.AppendChild(xmlRoot);
            }
            /*Nodo Factura*/
            XmlNode xmlFactura = xmlDocFacturaCompra.CreateElement("Factura");
            xmlDocFacturaCompra.DocumentElement.AppendChild(xmlFactura);

            /* ----------------------------------- Proveedor --------------------------------------*/

            /*Nodo CodigoProveedor */
            XmlNode xmlCodigoProveedor = xmlDocFacturaCompra.CreateElement("CodigoProveedor");
            xmlCodigoProveedor.InnerText = this.CodigoProveedor;
            xmlFactura.AppendChild(xmlCodigoProveedor);

            /*Nodo NombreProveedor */
            XmlNode xmlNombreProveedor = xmlDocFacturaCompra.CreateElement("Nombre");
            xmlNombreProveedor.InnerText = this.NombreProveedor;
            xmlFactura.AppendChild(xmlNombreProveedor);

            /*Nodo IdentificacionProveedor */
            XmlNode xmlDNIProveedor = xmlDocFacturaCompra.CreateElement("IdentificacionProveedor");
            xmlDNIProveedor.InnerText = this.DniProveedor.ToString();
            xmlFactura.AppendChild(xmlDNIProveedor);

            /*Nodo TelefonoProveedor */
            XmlNode xmlTelefonoProveedor = xmlDocFacturaCompra.CreateElement("TelefonoProveedor");
            xmlTelefonoProveedor.InnerText = this.TelefonoProveedor.ToString();
            xmlFactura.AppendChild(xmlTelefonoProveedor);

            /*Nodo EmailProveedor */
            XmlNode xmlEmailProveedor = xmlDocFacturaCompra.CreateElement("EmailProveedor");
            xmlEmailProveedor.InnerText = this.EmailProveedor;
            xmlFactura.AppendChild(xmlEmailProveedor);

            /* ----------------------------------- Factura --------------------------------------*/
            /*Nodo FechaFactura */
            XmlNode xmlFechaFactura = xmlDocFacturaCompra.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString("dd/MM/yyyy");
            xmlFactura.AppendChild(xmlFechaFactura);

            /*Nodo NumeroFactura */
            XmlNode xmlNumeroFactura = xmlDocFacturaCompra.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = this.generarCodigoFacturaCompra(); /*genero el cogido de la factura*/
            xmlFactura.AppendChild(xmlNumeroFactura);

            /*Nodo MontoFactura */
            XmlNode xmlMontoFactura = xmlDocFacturaCompra.CreateElement("TotalFactura");
            xmlMontoFactura.InnerText = this.MontoFactura.ToString();
            xmlFactura.AppendChild(xmlMontoFactura);

            /*Nodo MontoIVAFactura */
            XmlNode xmlMontoIVAFactura = xmlDocFacturaCompra.CreateElement("MontoIVAFactura");
            xmlMontoIVAFactura.InnerText = this.MontoIVA.ToString(); /*Calculo del IVA de la factura*/
            xmlFactura.AppendChild(xmlMontoIVAFactura);

            /*------------------------------------------------- Productos --------------------------------------------------------------------*/
            /*Nodo Productos*/
            XmlNode xmlProductos = xmlDocFacturaCompra.CreateElement("Productos");
            xmlFactura.AppendChild(xmlProductos);

            foreach (Producto _productosLista in this._ListaProductos)
            {
                /*Nodo Producto*/
                XmlNode _xmlProducto = xmlDocFacturaCompra.CreateElement("Producto");
                xmlProductos.AppendChild(_xmlProducto);

                /*Nodo CategoriaProducto*/
                XmlNode _xmlCategoriaProd = xmlDocFacturaCompra.CreateElement("CategoriaProducto");
                _xmlCategoriaProd.InnerText = _productosLista.CategoriaProducto;
                _xmlProducto.AppendChild(_xmlCategoriaProd);

                /*Nodo CodigoProducto*/
                XmlNode _xmlCodigoProd = xmlDocFacturaCompra.CreateElement("CodigoProducto");
                _xmlCodigoProd.InnerText = _productosLista.CodigoProducto;
                _xmlProducto.AppendChild(_xmlCodigoProd);

                /*Nodo NompreProducto*/
                XmlNode _xmlNombreProd = xmlDocFacturaCompra.CreateElement("NombreProducto");
                _xmlNombreProd.InnerText = _productosLista.NombreProducto;
                _xmlProducto.AppendChild(_xmlNombreProd);

                /*Nodo CantidadProducto*/
                XmlNode _xmlCantidadProd = xmlDocFacturaCompra.CreateElement("CantidadProducto");
                _xmlCantidadProd.InnerText = _productosLista.CantidadProducto.ToString();
                _xmlProducto.AppendChild(_xmlCantidadProd);

                /*Nodo PrecioProducto*/
                XmlNode _xmlPrecioUndProd = xmlDocFacturaCompra.CreateElement("PrecioProducto");
                _xmlPrecioUndProd.InnerText = _productosLista.PrecioUndProducto.ToString();
                _xmlProducto.AppendChild( _xmlPrecioUndProd);

                xmlProductos.AppendChild(_xmlProducto);/*Agrego los nodos Productos a la Factura*/
            } /*fin foreach*/
            _ArchivoXML.escribirXML(rutaCarpeta, xmlDocFacturaCompra);
        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
