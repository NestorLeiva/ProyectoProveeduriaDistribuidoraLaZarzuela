using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor : Persona
    {
        public Proveedor() { }

        public Proveedor(Guid codigoProveedor)
        {
            this.codigoProveedor = codigoProveedor;
        }

        private Guid codigoProveedor = Guid.Empty;
        



    }
}
