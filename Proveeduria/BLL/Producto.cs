using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace BLL
{
    public class Producto
    {

        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/
        private string categoriaProducto = string.Empty;
        private string nombreProducto = string.Empty;
        private int cantidadProducto;
        private int precioProducto;
        private string codigoProducto = string.Empty;
        private static string rutaRelativaXML = "ListaProductos.xml";
        private int nuevaCantidad;


        XmlDocument xmlDocProducto = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();

        public Producto() { }

        public Producto(string categoriaProducto, string nombreProducto, int cantidadProducto, int precioProducto, string codigoProducto)
        {
            this.categoriaProducto = categoriaProducto;
            this.nombreProducto = nombreProducto;
            this.cantidadProducto = cantidadProducto;
            this.precioProducto = precioProducto;
            this.codigoProducto = codigoProducto;
        }

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/
        public string CategoriaProducto { get { return categoriaProducto; } set { categoriaProducto = value; } }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
        public int CantidadProducto { get { return cantidadProducto; } set { cantidadProducto = value; } }
        public int PrecioUndProducto { get { return precioProducto; } set { precioProducto = value; } }

        public string CodigoProducto { get { return codigoProducto; } set { codigoProducto = value; } }
        public int NuevaCantidad { get { return nuevaCantidad; } set { nuevaCantidad = value; } }


        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public double CalcularIVA()
        {
            double ivaProducto = ((PrecioUndProducto * 0.13)*CantidadProducto);
            return ivaProducto;
        } /*CalcularIVA*/

        public double CalcularSubTotal()
        {
            double subTotal = ((PrecioUndProducto * CantidadProducto));
            return subTotal;
        }/*CalcularSubTotal*/

        public double CalcularTotal(double ivaAcumulado)
        {
            double subtotal = CalcularSubTotal();
            double total = subtotal + ivaAcumulado;
            return total;
        }/*CalcularTotal*/

        public string generarCodigoProducto()
        {

            if (CategoriaProducto.Length >= 2 && NombreProducto.Length >= 2)
            {
                Random codRandom = new Random(); /* instancia de la clase Random para generar números aleatorios */

                string cateProducto = CategoriaProducto.Substring(0, 2);

                string[] palabrasProducto = NombreProducto.Split(' ');
                /*Obtengo las primeras dos letras de cada palabra en NombreProducto*/
                string nombProducto = string.Join(" ", palabrasProducto.Select(palabra => palabra.Substring(0, Math.Min(2, palabra.Length))));
                /* esta lina de codigo es un array de palabras individuales, para transformar cada palabra tomando las primeras dos letras
                 * Substring(0, Math.Min(2, palabra.Length)) asegura que no intentamos acceder a más caracteres de los que tiene la palabra.
                 * string.Join("", ...) se utiliza para concatenar todas estas partes en una sola cadena
                 */

                int numeroPrimero = codRandom.Next(1, 100);
                int numeroSegundo = codRandom.Next(1, 100);
                /*random.Next(min, max) para obtener dos números aleatorios entre un rango específico */

                CodigoProducto = $"{cateProducto}{nombProducto}{numeroPrimero}{numeroSegundo}";

                CodigoProducto = CodigoProducto.Replace(" ", "");
                /*elimino espacios vacios*/

                return CodigoProducto;
            }
            else
            {
                throw new InvalidOperationException("No se pudo generar el Codigo debido a Datos Insuficientes");
            }

        }/*fin generarCodigoProducto*/

        public int calcularCantidad(string rutaArchivo, string xpath)
        {
            XElement xml = XElement.Load(rutaArchivo);
            XElement nodo = xml.XPathSelectElement(xpath);

            if (nodo != null && int.TryParse(nodo.Value, out int valor))
            {
                return valor;
            }
            else
            {
                throw new InvalidOperationException("No se pudo obtener el valor numérico del nodo.");
            }

            /*XElement representa un elemento XML en un documento. Pertenece a la Biblioteca La biblioteca LINQ to XML
              XElement incluyen la obtención y modificación de atributos, la navegación a través de elementos secundarios,
              la creación de nuevos elementos y la carga y guardado de documentos XML.*/

        }/*obtenerValor frmIngresoFactura & frmVentas Facturacion*/

        public void grabarXMLProductos(string rutaArchivo)
        {
            if (File.Exists(rutaArchivo))
            {
                xmlDocProducto = _ArchivoXML.leerXML(rutaArchivo);
                /*valido si existe el Fichero*/
            }
            else
            {
                XmlNode xmlRoot = xmlDocProducto.CreateElement("Productos");
                xmlDocProducto.AppendChild(xmlRoot);
            }

            /*nodo Producto*/
            XmlNode xmlProducto = xmlDocProducto.CreateElement("Producto");
            xmlDocProducto.DocumentElement.AppendChild(xmlProducto);

            /*nodo CategoriaProducto*/
            XmlNode xmlCategoriaProducto = xmlDocProducto.CreateElement("CategoriaProducto");
            xmlCategoriaProducto.InnerText = CategoriaProducto;
            xmlProducto.AppendChild(xmlCategoriaProducto);

            /*nodo CodigoProducto*/
            XmlNode xmlCodProducto = xmlDocProducto.CreateElement("CodigoProducto");
            xmlCodProducto.InnerText = generarCodigoProducto();/*obtengo el codigo por medio del metodo*/
            xmlProducto.AppendChild(xmlCodProducto);

            /*nodo NombreProducto*/
            XmlNode xmlNombreProducto = xmlDocProducto.CreateElement("NombreProducto");
            xmlNombreProducto.InnerText = NombreProducto;
            xmlProducto.AppendChild(xmlNombreProducto);

            /*nodo CantidadProducto*/
            XmlNode xmlCantidadProducto = xmlDocProducto.CreateElement("CantidadProducto");
            xmlCantidadProducto.InnerText = CantidadProducto.ToString();
            xmlProducto.AppendChild(xmlCantidadProducto);

            /*nodo PrecioProducto*/
            XmlNode xmlPrecioProducto = xmlDocProducto.CreateElement("PrecioProducto");
            xmlPrecioProducto.InnerText = PrecioUndProducto.ToString();
            xmlProducto.AppendChild(xmlPrecioProducto);

            _ArchivoXML.escribirXML(rutaArchivo, xmlDocProducto);
            /*Escritura del xmlProductos*/

        }/*fin grabarXMLProductos*/


    }/*Fin Productos*/
}/*fin namespace*/
