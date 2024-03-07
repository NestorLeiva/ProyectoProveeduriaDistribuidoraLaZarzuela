using BLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proveeduria
{
    public partial class frmCalculoHacienda : Form
    {
        public frmCalculoHacienda()
        {
            InitializeComponent();
        }


        DAL.ArchivoXML _ArchivoXML = new DAL.ArchivoXML();
        XmlDocument xmldDoc = new XmlDocument();

        private DateTime fechaSeleccionada;
        private DateTime fechaFactura;


        private void frmCalculoHacienda_Load(object sender, EventArgs e)
        {

        }
        /*------------------------------------------------- Botones --------------------------------------------------------------------*/
        private void btnSalir_Click(object sender, EventArgs e) { this.Close(); }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFacturas("FacturasCompra", lvwFacturasCompra);
            BuscarFacturas("FacturasVenta", lvwFacturasVenta);
        } /*fin btn Buscar*/

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularImpuestoTotal();
        }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/
        public void BuscarFacturas(string tipoFactura, ListView listView)
        {
            try
            {
                listView.Items.Clear();
                fechaSeleccionada = dtpFechaConsulta.Value;


                // Asegurémonos de que el tipo de factura tenga un formato consistente
                tipoFactura = tipoFactura.Replace(" ", ""); // Eliminar espacios en blanco

                // Ruta relativa de la carpeta según la fecha seleccionada
                string carpeta = fechaSeleccionada.ToString("yyyy-MM") + " " + tipoFactura;

                // Ruta completa del directorio de facturas
                string rutaCompleta = Path.Combine(Environment.CurrentDirectory, carpeta);


                if (Directory.Exists(rutaCompleta))
                {
                    string[] archivosXML = Directory.GetFiles(rutaCompleta, "*.xml");
                    /*Obtiene todos los archivos XML en la carpeta*/


                    foreach (string _archivos in archivosXML)
                    {
                        xmldDoc = _ArchivoXML.leerXML(_archivos);
                        XmlNode fechaNodo = xmldDoc.SelectSingleNode("//FechaFactura");

                        int mesFactura = fechaNodo != null ? DateTime.Parse(fechaNodo.InnerText).Month : 0;
                        int anioFactura = fechaNodo != null ? DateTime.Parse(fechaNodo.InnerText).Year : 0;
                        /*Obtén el mes y año de la fecha de la factura*/

                        if (mesFactura == fechaSeleccionada.Month && anioFactura == fechaSeleccionada.Year)
                        {
                            string numeroFactura = xmldDoc.SelectSingleNode("//NumeroFactura").InnerText;
                            string nombreCliente = xmldDoc.SelectSingleNode("//Nombre").InnerText;
                            string fechaFactura = xmldDoc.SelectSingleNode("//FechaFactura").InnerText;
                            string montoIVAFactura = xmldDoc.SelectSingleNode("//MontoIVAFactura").InnerText;
                            string montoFactura = xmldDoc.SelectSingleNode("//TotalFactura").InnerText;

                            ListViewItem itemFactura = new ListViewItem(
                                new[] { nombreCliente, numeroFactura, fechaFactura, montoIVAFactura, montoFactura });
                            listView.Items.Add(itemFactura);
                        }
                    }/*fin foreach*/
                }
                else
                {
                    MessageBox.Show($"No se encontraron Facturas con la fecha: {fechaSeleccionada} ", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general al buscar facturas: {ex.Message}", "Distribuidora La Zarzuela", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }/*BuscarFacturas*/

        private void CalcularImpuestoTotal()
        {
            decimal impuestoAFavor = 0;
            decimal impuestoPorPagar = 0;

            // Iterar sobre las facturas de ventas
            foreach (ListViewItem itemVenta in lvwFacturasVenta.Items)
            {
                decimal montoIVAFactura = decimal.Parse(itemVenta.SubItems[3].Text, CultureInfo.InvariantCulture);
                impuestoAFavor += montoIVAFactura;
            }

            // Iterar sobre las facturas de compras
            foreach (ListViewItem itemCompra in lvwFacturasCompra.Items)
            {
                decimal montoIVAFactura = decimal.Parse(itemCompra.SubItems[3].Text, CultureInfo.InvariantCulture);
                impuestoPorPagar += montoIVAFactura;
            }

            // Calcular el resultado total
            decimal resultadoTotal = impuestoAFavor - impuestoPorPagar;

            // Mostrar el resultado en el label correspondiente
            if (resultadoTotal > 0)
            {
                lblCalculoRes.Text = $"Impuesto a favor: {resultadoTotal:C}";
            }
            else if (resultadoTotal < 0)
            {
                lblCalculoRes.Text = $"Impuesto por pagar: {Math.Abs(resultadoTotal):C}";
            }
            else
            {
                lblCalculoRes.Text = "No hay impuesto a favor ni por pagar.";
            }
        } /*CalcularImpuestoTotal*/


    }/*fin frmCalculoHacienda*/
}/*fin namespace*/
