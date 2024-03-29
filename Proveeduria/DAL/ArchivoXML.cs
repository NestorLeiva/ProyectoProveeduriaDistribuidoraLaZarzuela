﻿using System.Xml;

namespace DAL
{
    public class ArchivoXML
    {
        XmlDocument xmlDoc = new XmlDocument(); /*instancia del objeto XML Document*/
        public XmlDocument leerXML(string rutaArchivo)
        {
            xmlDoc.Load(rutaArchivo);  /*se realiza la lectura del XML desde la ruta*/
            return xmlDoc;/* se devuelve el objeto XML que contiene el XML*/
        } /*fin metodo leerXML */


        public void escribirXML(string rutaArchivo, XmlDocument datosXML)
        {
            datosXML.Save(rutaArchivo);
            /*Guardo los datos del XML*/
        } /*fin metodo escribirXML @Override*/

        public void modificarXML(string rutaArchivo, string nodoXMLMod, string nuevoNodoXML)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(rutaArchivo);
            /*se carga el archivo*/

            XmlNode nodoXML = xmlDoc.SelectSingleNode(nodoXMLMod);
            /*Selecciono el nodo del XML a modificar*/

            if (nodoXML != null)
            {
                nodoXML.InnerText = nuevoNodoXML; /*se actualiza el valor del nodo*/
                xmlDoc.Save(rutaArchivo);
                /*se guardan los cambios en el documento*/
            }
        } /*fin metodo modificarXML*/


        public bool validarCredenciales(string rutaArchivo, string codigoFuncionario, string contrasenia, out string estado)
        {
            try
            {
                leerXML(rutaArchivo);

                XmlNode nodoFuncionario = xmlDoc.SelectSingleNode($"//Funcionario[CodigoFuncionario='{codigoFuncionario}' and Contrasenia='{contrasenia}']");

                if (nodoFuncionario != null)
                {
                    estado = nodoFuncionario.SelectSingleNode("Estado").InnerText;
                    return true;
                }

            }
            catch (Exception)
            {
                throw;
            }
            estado = null;
            return false;

        } /*fin metodo validarCredenciales*/
    } /*flin clase ArchivoXML*/
}/*fin namespace DAL*/
