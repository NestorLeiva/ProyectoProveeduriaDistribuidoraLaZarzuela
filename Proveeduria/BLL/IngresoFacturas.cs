using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class IngresoFacturas : Productos
    {
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string codigoProv = string.Empty;
        private string nombreProv = string.Empty;
        private int dniProv;
        private DateTime fechaFactura;
        private string numeroFactura = string.Empty;
        private int montoFactura;
        private double montoIVA;

        XmlDocument xmlDocFactura = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        IngresoFacturas _ingresoFacturas = new IngresoFacturas(); /*instancia para el nodo XML crearCodigoProducto */

        public List<Productos> lstProductos { get; set; } = new List<Productos>();

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/

        public string CodigoProv { get { return codigoProv; } set { codigoProv = value; } }
        public string NombreProv { get { return nombreProv; } set { nombreProv = value; } }
        public int DniProveedor { get { return dniProv; } set { dniProv = value; } }
        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public string NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoFacturaCompra(string NumeroFactura)
        {
            string codigoFactura = "FC-" + NumeroFactura;
            return codigoFactura;
        }/*fin generarCodigoFactura*/



        public void grabarXMLFactura(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocFactura = _ArchivoXML.leerXML(rutaArchivo);
                //XmlNode nodoFuncionario = xmlDoc.SelectSingleNode($"//Factura[CodigoFuncionario='{codigoFuncionario}' and CodProducto='{contrasenia}']");

            }
            else
            {
                XmlNode xmlRoot = xmlDocFactura.CreateElement("Facturas");
                xmlDocFactura.AppendChild(xmlRoot);
                /*creacion del XML*/
            }/*validacion del XML*/

            /*nodo PadreFactura*/
            XmlNode xmlFactura = xmlDocFactura.CreateElement("Factura");
            xmlDocFactura.DocumentElement.AppendChild(xmlFactura);

            /*nodo Codigo Proveedor*/
            XmlNode xmlCodProveedor = xmlDocFactura.CreateElement("CodigoProveedor");
            xmlCodProveedor.InnerText = this.CodigoProv;
            xmlFactura.AppendChild(xmlCodProveedor);

            /*nodo Nombre Proveedor*/
            XmlNode xmlNombreProveedor = xmlDocFactura.CreateElement("NombreProveedor");
            xmlNombreProveedor.InnerText = this.NombreProv;
            xmlFactura.AppendChild(xmlNombreProveedor);

            /*nodo Fecha Factura*/
            XmlNode xmlFechaFactura = xmlDocFactura.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString();
            xmlFactura.AppendChild(xmlFechaFactura);

            /*nodo Numero Factura*/
            XmlNode xmlNumeroFactura = xmlDocFactura.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = generarCodigoFacturaCompra(NumeroFactura);
            xmlFactura.AppendChild(xmlNumeroFactura);

            /*nodo Monto Factura*/
            XmlNode xmlMontoFactura = xmlDocFactura.CreateElement("MontoFactura");
            xmlMontoFactura.InnerText = this.MontoFactura.ToString();
            xmlFactura.AppendChild(xmlMontoFactura);

            /*nodo Monto IVA*/
            XmlNode xmlMontoIva = xmlDocFactura.CreateElement("MontoIVA");
            xmlMontoIva.InnerText = this.MontoFactura.ToString();
            xmlFactura.AppendChild(xmlMontoIva);

            /*------------------------------------------------- Productos --------------------------------------------------------------------*/
            /*Nodo Productos*/
            XmlNode xmlProductos = xmlDocFactura.CreateElement("Productos");
            xmlFactura.AppendChild(xmlProductos);


            foreach (Productos _productos in this.lstProductos)
            {
                /*nodo Producto*/
                XmlNode _xmlCategoriaProducto = xmlDocFactura.CreateElement("Producto");
                xmlDocFactura.DocumentElement.AppendChild(_xmlCategoriaProducto);

                /*nodo Categoria Producto*/
                XmlNode xmlCategoriaProducto = xmlDocFactura.CreateElement("CategoriaProducto");
                xmlCategoriaProducto.InnerText = _productos.CategoriaProducto;
                _xmlCategoriaProducto.AppendChild(xmlCategoriaProducto);

                /*nodo CodigoProducto*/
                XmlNode xmlCodigoProducto = xmlDocFactura.CreateElement("CodigoProducto");
                xmlCodigoProducto.InnerText = _productos.crearCodigoProducto(_ingresoFacturas, _productos);
                _xmlCategoriaProducto.AppendChild(xmlCodigoProducto);

                /*nodo Descripcion Producto*/
                XmlNode xmlDescripcionProducto = xmlDocFactura.CreateElement("DescripcionProducto");
                xmlDescripcionProducto.InnerText = _productos.DescripcionProducto;
                _xmlCategoriaProducto.AppendChild(xmlDescripcionProducto);

                /*nodo Cantidad Producto*/
                XmlNode xmlCantidadProducto = xmlDocFactura.CreateElement("CantidadProducto");
                xmlCantidadProducto.InnerText = _productos.CantidadProducto.ToString();
                _xmlCategoriaProducto.AppendChild(xmlCantidadProducto);

                /*nodo Precio UND Producto*/
                XmlNode xmlPrecioUndProducto = xmlDocFactura.CreateElement("PrecioUndProducto");
                xmlPrecioUndProducto.InnerText = _productos.PrecioUndProducto.ToString();
                _xmlCategoriaProducto.AppendChild(xmlPrecioUndProducto);

            }

            _ArchivoXML.escribirXML(rutaArchivo, xmlDocFactura);/*se escribe el XML*/

        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
