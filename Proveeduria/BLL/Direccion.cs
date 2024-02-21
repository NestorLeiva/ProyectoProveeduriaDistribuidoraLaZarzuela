using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Direccion
    {
        public Direccion()
        {
            /*Constructor Vacio*/
        }

        public Direccion(string provincia, string canton, string distrito, string otrasSenias)
        {
            /*constructo con parametros*/
            this.provincia = provincia;
            this.canton = canton;
            this.distrito = distrito;
            this.otrasSenias = otrasSenias;
        }


        private string provincia = string.Empty;
        private string canton = string.Empty;
        private string distrito = string.Empty;
        private string otrasSenias = string.Empty;



        public string Provincia { get { return provincia; } set { provincia = value; } }
        public string Canton { get { return canton; } set { canton = value; } }
        public string Distrito { get {  return distrito; } set {  distrito = value; } }
        public string OtrasSenias { get {  return otrasSenias; } set {  otrasSenias = value; } }





    }
}
