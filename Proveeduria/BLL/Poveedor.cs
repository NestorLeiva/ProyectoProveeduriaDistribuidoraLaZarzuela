using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Poveedor : Persona
    {
        public Poveedor() { }

        public Poveedor(Guid codigoProveedor)
        {
            this.codigoProveedor = codigoProveedor;
        }

        private Guid codigoProveedor = Guid.Empty;
        



    }
}
