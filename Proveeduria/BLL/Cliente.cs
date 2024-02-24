using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    public class Cliente : Direccion /*herencia*/
    {
        /* ----------------------------------------------- Atributos -----------------------------------------------*/
        private string codigoCliente;


        public string CodigoCliente { get { return codigoCliente; } set { codigoCliente = value; } }

        /* ----------------------------------------------- Objetos -----------------------------------------------*/

        XmlDocument xmlDocCliente = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        /* ----------------------------------------------- Metodos -----------------------------------------------*/

        public string generarCodCliente()
        {
            /*2 nombre+ 1 apellido + 1 apelledio+ 3 DNI*/

            if (Nombre.Length >= 2 && ApellidoPrimero.Length >= 2
                && ApellidoSegundo.Length >= 2 && DNI >= 9)
            {
                string letrasNombre = Nombre.Substring(0, 2);
                string letrasApellido1 = ApellidoPrimero.Substring(0, 1);
                string letrasApellido2 = ApellidoSegundo.Substring(0, 1);
                string numeroDNI = DNI.ToString().Substring(Math.Max(0, DNI.ToString().Length - 3));

                return $"{letrasNombre}{letrasApellido1}{letrasApellido2}{numeroDNI}";
            }
            else
            {
                throw new InvalidOperationException("No se pudo generar el Codigo debido a Datos Insuficientes");
            }

        } /*fin generarCodCliente*/


        public void grabarXMLCliente(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocCliente = _ArchivoXML.leerXML(rutaArchivo);/*Lectura del XML*/

                XmlNode existeCliente = xmlDocCliente.SelectSingleNode($"//Cliente [NumeroIdentificacion='{this.DNI}']");
                if ( existeCliente != null )
                {
                    throw new Exception("*** Ya se encuentra Registrado el Cliente ***");
                }
                /*Valido si ya existe un cliente registrado por medio de la Identificacion*/
            }
            else
            {
                XmlNode xmlRoot = xmlDocCliente.CreateElement("Clientes");
                xmlDocCliente.AppendChild(xmlRoot);
                /*creacion del XML*/
            }
            /*validacion del fichero XML*/

            /*nodo CLiente*/
            XmlNode xmlCliente = xmlDocCliente.CreateElement("Cliente");
            xmlDocCliente.DocumentElement.AppendChild(xmlCliente);

            /*nodo # identificacion*/
            XmlNode xmlNumIdentificacion = xmlDocCliente.CreateElement("NumeroIdentificacion");
            xmlNumIdentificacion.InnerText = this.DNI.ToString();
            xmlCliente.AppendChild(xmlNumIdentificacion);

            /*nodo Tipo de Identificacion*/
            XmlNode xmlTipoIdentificacion = xmlDocCliente.CreateElement("TipoIdentificacion");
            xmlTipoIdentificacion.InnerText = this.TipoDni;
            xmlCliente.AppendChild (xmlTipoIdentificacion);

            /*nodo nombre*/
            XmlNode xmlNombre = xmlDocCliente.CreateElement("Nombre");
            xmlNombre.InnerText = this.Nombre;
            xmlCliente.AppendChild(xmlNombre);

            /*nodo ApellidoPrimero*/
            XmlNode xmlApellidoPrimero = xmlDocCliente.CreateElement("ApellidoPrimero");
            xmlApellidoPrimero.InnerText = this.ApellidoPrimero;
            xmlCliente.AppendChild(xmlApellidoPrimero);

            /*nodo ApellidoSegundo*/
            XmlNode xmlApellidoSegundo = xmlDocCliente.CreateElement("ApellidoSegundo");
            xmlApellidoSegundo.InnerText = this.ApellidoSegundo;
            xmlCliente.AppendChild(xmlApellidoSegundo);

            /*nodo CodigoCliente*/
            XmlNode xmlCodigoCliente = xmlDocCliente.CreateElement("CodigoCliente");
            xmlCodigoCliente.InnerText = generarCodCliente();
            xmlCliente.AppendChild(xmlCodigoCliente);

            /*nodo Telefono*/
            XmlNode xmlTelefono = xmlDocCliente.CreateElement("Telefono");
            xmlTelefono.InnerText = this.Telefono.ToString();
            xmlCliente.AppendChild(xmlTelefono);

            /*nodo Email*/
            XmlNode xmlEmail = xmlDocCliente.CreateElement("Email");
            xmlEmail.InnerText = this.Email;
            xmlCliente.AppendChild(xmlEmail);

            /*nodo Provincia*/
            XmlNode xmlProvinvia = xmlDocCliente.CreateElement("Provincia");
            xmlProvinvia.InnerText = this.Provincia;
            xmlCliente.AppendChild(xmlProvinvia);

            /*nodo Canton*/
            XmlNode xmlCanton= xmlDocCliente.CreateElement("Canton");
            xmlCanton.InnerText = this.Canton;
            xmlCliente.AppendChild(xmlCanton);

            /*nodo Distrito*/
            XmlNode xmlDistrito = xmlDocCliente.CreateElement("Distrito");
            xmlDistrito.InnerText = this.Distrito;
            xmlCliente.AppendChild(xmlDistrito);

            /*nodo OtrasSenias*/
            XmlNode xmlOtrasSenias = xmlDocCliente.CreateElement("OtrasSenias");
            xmlOtrasSenias.InnerText = this.OtrasSenias;
            xmlCliente.AppendChild(xmlOtrasSenias);



            _ArchivoXML.escribirXML(rutaArchivo, xmlDocCliente);
            /*escritura del XML*/

        } /*fin grabarXMLCLiente*/

    }/*fin class Cliente*/

}/*fin namespace*/
