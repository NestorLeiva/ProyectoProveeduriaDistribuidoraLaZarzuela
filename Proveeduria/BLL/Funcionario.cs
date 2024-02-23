using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml;
using System.IO;

namespace BLL
{
    public class Funcionario : Persona /*herencia de clase Persona*/
    {
        public Funcionario() { } /*Constructor Vacio*/

        /*------------------------------------------------- Objetos --------------------------------------------------------------------*/
        XmlDocument xmlDocFuncionario = new XmlDocument();

        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML(); /*instancia de la clase ArchivoXML en la Libreria DAL*/

        public Funcionario(string contrasenia, string estado)
        {
            Contrasenia = contrasenia;
            Estado = estado;
        }

        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string contrasenia = string.Empty;
        private int codFuncionario;
        private string estado = string.Empty;

        /*Getter & Setter*/
        public string Contrasenia { get { return contrasenia; } set { contrasenia = value; } }
        public int CodFuncionario { get { return codFuncionario; } set { codFuncionario = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarEmail()
        {
            return $"{Nombre.Substring(0, 1)}{ApellidoPrimero}{ApellidoSegundo.Substring(0, 1)}@LAZARZUELA.COM";
            /*metodo para generar automaticamente el correo del funcionario 
             1 letra del nombre + apellidoPrimero + 1 letra del apellidoSegundo + dominio '@LAZARZUELA.COM'*/
        } /*fin generarEmail*/

        public void grabarXMLFuncionario(string rutaArchivo)
        {
            /*Validacion si existe el archivo si existe lo lee. Si no existe lo crea*/
            if (File.Exists(rutaArchivo))
            {
                xmlDocFuncionario.Load(rutaArchivo);
                /*cargo el archivo*/

                XmlNode existeFuncionario = xmlDocFuncionario.SelectSingleNode($"//Funcionario [Identificacion='{this.DNI}']");
                /*valido si ya existe un usuario con la mista Identificicacion*/
                if (existeFuncionario != null)
                {
                    throw new Exception("*** Ya se encuentra Registrado el Funcionario ***");
                }

            }
            else
            {
                /*Nodo Funcionarios*/
                XmlNode xmlRoot = xmlDocFuncionario.CreateElement("Funcionarios");
                xmlDocFuncionario.AppendChild(xmlRoot);
            }

            /*nodo Funcionario*/
            XmlNode xmlFuncionario = xmlDocFuncionario.CreateElement("Funcionario");
            xmlDocFuncionario.DocumentElement.AppendChild(xmlFuncionario);
            /*accedo al nodo padre por medio del DocumentElement y posterior agrego los nodos Hijos */

            /*Nodo DNI*/
            XmlNode xmlDNI = xmlDocFuncionario.CreateElement("Identificacion");
            xmlDNI.InnerText = this.DNI.ToString();
            xmlFuncionario.AppendChild(xmlDNI);

            /*Nodo Nombre*/
            XmlNode xmlNombre = xmlDocFuncionario.CreateElement("Nombre");
            xmlNombre.InnerText = this.Nombre;
            xmlFuncionario.AppendChild(xmlNombre);

            /*Nodo ApellidoPrimero*/
            XmlNode xmlApellidoPrimero = xmlDocFuncionario.CreateElement("ApellidoPrimero");
            xmlApellidoPrimero.InnerText = this.ApellidoPrimero;
            xmlFuncionario.AppendChild(xmlApellidoPrimero);

            /*Nodo ApellidoSegundo*/
            XmlNode xmlApellidoSegundo = xmlDocFuncionario.CreateElement("ApellidoSegundo");
            xmlApellidoSegundo.InnerText = this.ApellidoSegundo;
            xmlFuncionario.AppendChild(xmlApellidoSegundo);

            /*Nodo Email*/
            XmlNode xmlEmail = xmlDocFuncionario.CreateElement("Email");
            xmlEmail.InnerText = this.generarEmail(); /*invoco al metodo*/
            xmlFuncionario.AppendChild(xmlEmail);


            /*Nodo CodigoFuncionario*/
            XmlNode xmlCodFuncionario = xmlDocFuncionario.CreateElement("CodigoFuncionario");
            xmlCodFuncionario.InnerText = this.DNI.ToString();
            xmlFuncionario.AppendChild(xmlCodFuncionario);

            /*Nodo Contrasenia*/
            XmlNode xmlContrasenia = xmlDocFuncionario.CreateElement("Contrasenia");
            xmlContrasenia.InnerText = this.Contrasenia;
            xmlFuncionario.AppendChild(xmlContrasenia);

            /*Nodo Estado*/
            XmlNode xmlEstado = xmlDocFuncionario.CreateElement("Estado");
            xmlEstado.InnerText = this.Estado;
            xmlFuncionario.AppendChild(xmlEstado);


            _ArchivoXML.escribirXML(rutaArchivo, xmlDocFuncionario);
            /*ingreso a la instancia para realizar la escritura del XML*/

        } /*fin metodo GrabarFuncionario*/








    }/*fin clase Funcionario*/

}/*fin namespace*/