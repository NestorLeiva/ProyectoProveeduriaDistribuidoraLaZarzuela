using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IngresoFacturas : Productos
    {
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/

        private string codigoProv = string.Empty;
        private string nombreProv = string.Empty;
        private DateTime fechaFactura;
        private string numeroFactura = string.Empty;
        private int montoFactura;
        private double montoIVA;


        public List<Productos> lstProductos { get; set; } = new List<Productos>(); 

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/

        public string CodigoProv { get { return codigoProv; } set { codigoProv = value; } }
        public string NombreProv { get { return nombreProv; } set { nombreProv = value; } }
        public DateTime FechaFactura { get { return fechaFactura; } set { fechaFactura = value; } }
        public string NumeroFactura { get { return numeroFactura; } set { numeroFactura = value; } }
        public int MontoFactura { get { return montoFactura; } set { montoFactura = value; } }
        public double MontoIVA { get { return montoIVA; } set { montoIVA = value; } }
        


        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/






    }/*fin IngresoFacturas*/
}/*fin namespace*/
