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

        private string codigoProveedor = string.Empty;
        private string nombreProveedor = string.Empty;
        private string dniProveedor = string.Empty;
        private string telProveedor = string.Empty;
        private string emailProveedor = string.Empty;
        private DateTime fechaFactura;
        private int numeroFactura;
        private int montoFactura;
        private double montoIVA;

        XmlDocument xmlDocFactura = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        public Productos _Productos;

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/

        public string CodigoProveedor { get { return codigoProveedor; } set { codigoProveedor = value; } }
        public string NombreProveedor { get { return nombreProveedor; } set { nombreProveedor = value; } }
        public string DniProveedor { get { return dniProveedor; } set { dniProveedor = value; } }

        public string TelefonoProveedor { get { return telProveedor; } set { telProveedor = value; } }

        public string EmailProveedor { get { return emailProveedor; } set { emailProveedor = value; } }

        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public int NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoFacturaCompra()
        {
            return "FC-" + NumeroFactura;
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
                xmlDocFactura = _ArchivoXML.leerXML(rutaArchivo);

            }
            else
            {
                /*Nodo Facturas*/
                XmlNode xmlRoot = xmlDocFactura.CreateElement("Facturas");
                xmlDocFactura.AppendChild(xmlRoot);
            }
            /*Nodo Factura*/
            XmlNode xmlFactura = xmlDocFactura.CreateElement("Factura");
            xmlDocFactura.DocumentElement.AppendChild(xmlFactura);

            /* ----------------------------------- Proveedor --------------------------------------*/

            /*Nodo CodigoProveedor */
            XmlNode xmlCodigoProveedor = xmlDocFactura.CreateElement("CodigoProveedor");
            xmlCodigoProveedor.InnerText = this.CodigoProveedor;
            xmlFactura.AppendChild(xmlCodigoProveedor);

            /*Nodo NombreProveedor */
            XmlNode xmlNombreProveedor = xmlDocFactura.CreateElement("NombreProveedor");
            xmlNombreProveedor.InnerText = this.NombreProveedor;
            xmlFactura.AppendChild(xmlNombreProveedor);

            /*Nodo IdentificacionProveedor */
            XmlNode xmlDNIProveedor = xmlDocFactura.CreateElement("IdentificacionProveedor");
            xmlDNIProveedor.InnerText = this.DniProveedor.ToString();
            xmlFactura.AppendChild(xmlDNIProveedor);

            /*Nodo TelefonoProveedor */
            XmlNode xmlTelefonoProveedor = xmlDocFactura.CreateElement("TelefonoProveedor");
            xmlTelefonoProveedor.InnerText = this.TelefonoProveedor.ToString();
            xmlFactura.AppendChild(xmlTelefonoProveedor);

            /*Nodo EmailProveedor */
            XmlNode xmlEmailProveedor = xmlDocFactura.CreateElement("EmailProveedor");
            xmlEmailProveedor.InnerText = this.EmailProveedor;
            xmlFactura.AppendChild(xmlEmailProveedor);

            /* ----------------------------------- Factura --------------------------------------*/
            /*Nodo FechaFactura */
            XmlNode xmlFechaFactura = xmlDocFactura.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString("dd/MM/yyyy");
            xmlFactura.AppendChild(xmlFechaFactura);

            /*Nodo NumeroFactura */
            XmlNode xmlNumeroFactura = xmlDocFactura.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = this.generarCodigoFacturaCompra(); /*genero el cogido de la factura*/
            xmlFactura.AppendChild(xmlNumeroFactura);

            /*Nodo MontoFactura */
            XmlNode xmlMontoFactura = xmlDocFactura.CreateElement("MontoFactura");
            xmlMontoFactura.InnerText = this.MontoFactura.ToString();
            xmlFactura.AppendChild(xmlMontoFactura);

            /*Nodo MontoIVAFactura */
            XmlNode xmlMontoIVAFactura = xmlDocFactura.CreateElement("MontoIVAFactura");
            xmlMontoIVAFactura.InnerText = calcularIVA(MontoFactura).ToString(); /*Calculo del IVA de la factura*/
            xmlFactura.AppendChild(xmlMontoIVAFactura);




























            _ArchivoXML.escribirXML(rutaArchivo, xmlDocFactura);
        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
