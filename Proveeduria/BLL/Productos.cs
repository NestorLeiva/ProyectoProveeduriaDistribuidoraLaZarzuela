using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Productos
    {
        /*------------------------------------------------- Atributos --------------------------------------------------------------------*/
        private string categoriaProducto = string.Empty;
        private string nombreProducto = string.Empty;
        private int cantidadProducto;
        private decimal precioProducto;
        private int totalPrecioUndProducto;

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/
        public string CategoriaProducto { get { return categoriaProducto; } set { categoriaProducto = value; } }
        public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
        public int CantidadProducto { get { return cantidadProducto; } set { cantidadProducto = value; } }
        public decimal PrecioUndProducto { get { return precioProducto; } set { precioProducto = value; } }

        public int TotalPrecioProducto { get { return totalPrecioUndProducto; } set { totalPrecioUndProducto = value; } }


        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/


        public string generarCodigoProducto()
        {
            if (CategoriaProducto.Length >= 2 && NombreProducto.Length >= 2)
            {
                Random codRandom = new Random(); /* instancia de la clase Random para generar números aleatorios */

                string cateProducto = CategoriaProducto.Substring(0, 2);
                string nombProducto = NombreProducto.Substring(0, 2);

                int numeroPrimero = codRandom.Next(1, 100);
                int numeroSegundo = codRandom.Next(1, 100);
                /*random.Next(min, max) para obtener dos números aleatorios entre un rango específico */

                string codigoProducto = $"{cateProducto}{nombProducto}{numeroPrimero}{numeroSegundo}";

                return codigoProducto;
            }
            else
            {
                throw new InvalidOperationException("No se pudo generar el Codigo debido a Datos Insuficientes");
            }

        }/*fin generarCodigoProducto*/



    }/*Fin Productos*/
}/*fin namespace*/
