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

        /*------------------------------------------------- Getter & Setter --------------------------------------------------------------------*/
        public string CategoriaProducto { get { return categoriaProducto; } set { categoriaProducto = value; } }
        public string DesProducto { get { return desProducto; } set { desProducto = value} }
        public int CantProducto { get { return cantProducto; } set { cantProducto = value; } }
        public double PrecioProducto { get { return precioProducto; } set { precioProducto = value; } }

        /*------------------------------------------------- Metodos --------------------------------------------------------------------*/


    }/*Fin Productos*/
}/*fin namespace*/
