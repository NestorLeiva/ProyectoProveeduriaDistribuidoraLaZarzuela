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

        public VentasFacturas(DateTime fechaFactura, int numeroFactura, double montoIVA, double subTotal, double total, XmlDocument xmlDocCliente, ArchivoXML archivoXML, List<Cliente> listaCliente, List<Producto> listaProductos, Producto productos, Cliente cliente)
        {
            this.fechaFactura = fechaFactura;
            this.numeroFactura = numeroFactura;
            this.montoIVA = montoIVA;
            this.subTotal = subTotal;
            this.total = total;
            this.xmlDocFacturaVenta = xmlDocCliente;
            _ArchivoXML = archivoXML;
            _ListaCliente = listaCliente;
            _ListaProductos = listaProductos;
            _Productos = productos;
            _Cliente = cliente;
        }

        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private DateTime fechaFactura;
        private int numeroFactura;
        //private int montoFactura;
        private double montoIVA = 0.13;
        private double subTotal;
        private double total;

        private int ConsecutivoVentaFactura = 1;

        XmlDocument xmlDocFacturaVenta = new XmlDocument();
        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        public List<Cliente> _ListaCliente { get; set; } = new List<Cliente>();
        public List<Producto> _ListaProductos { get; set; } = new List<Producto>();
        public Producto _Productos;
        public Cliente _Cliente;


        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/


        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public int NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        //public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }
        public double MontoSubTotal { get { return subTotal; } set { subTotal = value; } }
        public double MontoTotal { get { return total; } set { total = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/

        public string generarCodigoFacturaVenta()
        {
            int consecutivo = ConsecutivoVentaFactura++;
            return "FV-" + (consecutivo ).ToString();
        }/*fin generarCodigoFactura*/



        public void setFechaFactura(DateTime fecha)
        {
            FechaFactura = fecha;
        }


        public void grabarXMLFacturaVentas(string rutaArchivo)
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

            /* ----------------------------------- Cliente --------------------------------------*/

            /*nodo # identificacion*/
            XmlNode xmlNumIdentificacion = xmlDocFacturaVenta.CreateElement("NumeroIdentificacion");
            xmlNumIdentificacion.InnerText = this.DNI.ToString();
            xmlFactura.AppendChild(xmlNumIdentificacion);

            /*nodo Tipo de Identificacion*/
            XmlNode xmlTipoIdentificacion = xmlDocFacturaVenta.CreateElement("TipoIdentificacion");
            xmlTipoIdentificacion.InnerText = this.TipoDni;
            xmlFactura.AppendChild(xmlTipoIdentificacion);

            /*nodo nombre*/
            XmlNode xmlNombre = xmlDocFacturaVenta.CreateElement("Nombre");
            xmlNombre.InnerText = this.Nombre;
            xmlFactura.AppendChild(xmlNombre);

            /*nodo ApellidoPrimero*/
            XmlNode xmlApellidoPrimero = xmlDocFacturaVenta.CreateElement("ApellidoPrimero");
            xmlApellidoPrimero.InnerText = this.ApellidoPrimero;
            xmlFactura.AppendChild(xmlApellidoPrimero);

            /*nodo ApellidoSegundo*/
            XmlNode xmlApellidoSegundo = xmlDocFacturaVenta.CreateElement("ApellidoSegundo");
            xmlApellidoSegundo.InnerText = this.ApellidoSegundo;
            xmlFactura.AppendChild(xmlApellidoSegundo);

            /*nodo CodigoCliente*/
            XmlNode xmlCodigoCliente = xmlDocFacturaVenta.CreateElement("CodigoCliente");
            xmlCodigoCliente.InnerText = CodigoCliente;
            xmlFactura.AppendChild(xmlCodigoCliente);

            /*nodo Telefono*/
            XmlNode xmlTelefono = xmlDocFacturaVenta.CreateElement("Telefono");
            xmlTelefono.InnerText = this.Telefono.ToString();
            xmlFactura.AppendChild(xmlTelefono);

            /*nodo Email*/
            XmlNode xmlEmail = xmlDocFacturaVenta.CreateElement("Email");
            xmlEmail.InnerText = this.Email;
            xmlFactura.AppendChild(xmlEmail);

            /* ----------------------------------- Factura --------------------------------------*/
            /*Nodo FechaFactura */
            XmlNode xmlFechaFactura = xmlDocFacturaVenta.CreateElement("FechaFactura");
            xmlFechaFactura.InnerText = this.FechaFactura.ToString("dd/MM/yyyy");
            xmlFactura.AppendChild(xmlFechaFactura);

            /*Nodo NumeroFactura */
            ConsecutivoVentaFactura++;
            XmlNode xmlNumeroFactura = xmlDocFacturaVenta.CreateElement("NumeroFactura");
            xmlNumeroFactura.InnerText = this.generarCodigoFacturaVenta(); /*genero el cogido de la factura*/
            xmlFactura.AppendChild(xmlNumeroFactura);
            

            /*Nodo SubTotalFactura */
            XmlNode xmlsubTotalFactura = xmlDocFacturaVenta.CreateElement("SubTotalFactura");
            xmlsubTotalFactura.InnerText = this.MontoSubTotal.ToString();
            xmlFactura.AppendChild(xmlsubTotalFactura);


            /*Nodo MontoIVAFactura */
            XmlNode xmlMontoIVAFactura = xmlDocFacturaVenta.CreateElement("MontoIVAFactura");
            xmlMontoIVAFactura.InnerText = MontoIVA.ToString(); /*Calculo del IVA de la factura*/
            xmlFactura.AppendChild(xmlMontoIVAFactura);

            /*Nodo MontoFactura */
            XmlNode xmlTotalFactura = xmlDocFacturaVenta.CreateElement("TotalFactura");
            xmlTotalFactura.InnerText = this.MontoTotal.ToString();
            xmlFactura.AppendChild(xmlTotalFactura);


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
                _xmlProducto.AppendChild(_xmlPrecioUndProd);


                xmlProductos.AppendChild(_xmlProducto);/*Agrego los nodos Productos a la Factura*/
            } /*fin foreach*/


    




            _ArchivoXML.escribirXML(rutaArchivo, xmlDocFacturaVenta);
        }/*fin grabarXMLFactura*/

    }/*fin IngresoFacturas*/
}/*fin namespace*/
