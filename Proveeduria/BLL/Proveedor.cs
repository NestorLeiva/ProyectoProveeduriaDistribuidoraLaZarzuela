using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace BLL
{
    public class Proveedor : Persona
    {
        public Proveedor() { }
        /*Constructor Vacio*/
        public Proveedor(string codigoProveedor)
        {
            CodigoProveedor = codigoProveedor;
        }
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string codigoProveedor;
        /*2 letras del nombre + ultimos 4 dijitos del ID*/


        public string CodigoProveedor { get { return codigoProveedor; } set { codigoProveedor = value; } }

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        XmlDocument xmlDocProveedor = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoProveedor()
        {
            // Verifica que el nombre tiene al menos dos letras y el DNI tiene al menos 4 dígitos
            if (Nombre.Length >= 2 && DNI >= 11)
            {
                string letrasNombre = Nombre.Substring(0, 2);
                string digitosDNI = DNI.ToString().Substring(Math.Max(0, DNI.ToString().Length - 4));
                return $"{letrasNombre}{digitosDNI}";
            }
            else
            {
                throw new InvalidOperationException("No se pudo generar el Codigo debido a Datos Insuficientes");
            }
        }


        public void grabarXMLProveedor(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocProveedor = _ArchivoXML.leerXML(rutaArchivo);
                /*realiza la lectura del XML*/

                XmlNode existeProveedor = xmlDocProveedor.SelectSingleNode($"//Proveedor [CodigoProveedor='{this.CodigoProveedor}']");


            }
            else
            {
                XmlNode xmlRoot = xmlDocProveedor.CreateElement("Proveedores");
                xmlDocProveedor.AppendChild(xmlRoot);
                /*Crea el XML*/
            }
            /*validacion del fichero XML*/

            /*nodo Proveedor*/
            XmlNode xmlProveedor = xmlDocProveedor.CreateElement("Proveedor");
            xmlDocProveedor.DocumentElement.AppendChild(xmlProveedor);
            /*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */

            /*nodo Cod.Proveedor*/
            XmlNode xmlCodProveedor = xmlDocProveedor.CreateElement("CodigoProveedor");
            xmlCodProveedor.InnerText = this.generarCodigoProveedor();
            xmlProveedor.AppendChild(xmlCodProveedor);
            /*genera y guarda automaticamente el codigo para cada proveedor*/

            /*nodo NombreProveedor*/
            XmlNode xmlNombreProveedor = xmlDocProveedor.CreateElement("NombreProveedor");
            xmlNombreProveedor.InnerText = this.Nombre;
            xmlProveedor.AppendChild(xmlNombreProveedor);

            /*nodo tipo Identificacion Proveedor*/
            XmlNode xmlTipoDNIProveedor = xmlDocProveedor.CreateElement("TipoIdentificacion");
            xmlTipoDNIProveedor.InnerText = this.TipoDni;
            xmlProveedor.AppendChild(xmlTipoDNIProveedor);

            /*nodo Identificacion Proveedor*/
            XmlNode xmlDNIProveedor = xmlDocProveedor.CreateElement("Identificacion");
            xmlDNIProveedor.InnerText = this.DNI.ToString();
            xmlProveedor.AppendChild(xmlDNIProveedor);

            /*nodo Telefono Proveedor*/
            XmlNode xmlTelefonoProveedor = xmlDocProveedor.CreateElement("TelefonoProveedor");
            xmlTelefonoProveedor.InnerText = this.Telefono.ToString();
            xmlProveedor.AppendChild(xmlTelefonoProveedor);

            /*nodo Email Proveedor*/
            XmlNode xmlEmailProveedor = xmlDocProveedor.CreateElement("EmailProveedor");
            xmlEmailProveedor.InnerText = this.Email;
            xmlProveedor.AppendChild(xmlEmailProveedor);

            _ArchivoXML.escribirXML(rutaArchivo, xmlDocProveedor);
            /*se realiza la escritura del XML*/


        }/*grabarXMLProveedor*/
    }/*fin class Proveedor*/
}/*fin namespace*/
