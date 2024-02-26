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
        private string desProducto = string.Empty;
        private int cantProducto;
        private double precioProducto;
        private static int numeroConsecutivo = 1; /* Variable estática para mantener el número consecutivo*/


        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/
        public string CategoriaProducto { get { return categoriaProducto; } set { categoriaProducto = value; } }
        public string DescripcionProducto { get { return desProducto; } set { desProducto = value; } }
        public int CantidadProducto { get { return cantProducto; } set { cantProducto = value; } }
        public double PrecioUndProducto { get { return precioProducto; } set { precioProducto = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/
        public string crearCodigoProducto(IngresoFacturas ingresoFactura, Productos productos)
        {

            if (ingresoFactura != null && productos != null &&
                productos.CategoriaProducto.Length >= 2 && productos.DescripcionProducto.Length >= 2 &&
                ingresoFactura.NombreProv.Length >= 2 && ingresoFactura.DniProveedor >= 10000000000 /*11 dijitos*/ )
            {
                string letrasCategoria = ingresoFactura.CategoriaProducto.Substring(0, 2);
                string letrasDescripcion = productos.DescripcionProducto.Substring(0, 2);
                string letrasNombreProveedor = ingresoFactura.NombreProv.Substring(0, 2);
                string digitoDniProveedor = ingresoFactura.DniProveedor.ToString()[0].ToString();
                int numeroProducto = numeroConsecutivo++;

                return $"{letrasCategoria}{letrasDescripcion}{letrasNombreProveedor}{digitoDniProveedor}{numeroProducto}";

            }
            else
            {
                throw new InvalidOperationException("No se pudo generar el Codigo debido a Datos Insuficientes");
            }
        }/*fin crearCodigoProducto
           recibe como parámetros instancias de ambas clases: IngresoFactura y Productos*/


    }/*Fin Productos*/
}/*fin namespace*/
