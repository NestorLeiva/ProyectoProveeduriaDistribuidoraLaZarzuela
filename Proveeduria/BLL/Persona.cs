using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Persona
    {
        public Persona()
        {
            /*constructor Vacio = utiliza valorres predeterminados o nulos*/
        }
        public Persona(string nombre, string apellidoPrimero, string apellidoSegundo, int dni, int telefono, string email)
        {
            /*Constructor con parametros = para proporcionar valores iniciales especificos a los atributos al momento de la creacion*/
            Nombre = nombre;
            ApellidoPrimero = apellidoPrimero;
            ApellidoSegundo = apellidoSegundo;
            DNI = dni;
            Telefono = telefono;
            Email = email;
            TipoDni = tipoDni;
        }

        /*Atributos */
        private string nombre = string.Empty;
        private string apellidoPrimero = string.Empty;
        private string apellidoSegundo = string.Empty;
        private int dni;
        private int telefono;
        private string email = string.Empty;
        private string tipoDni = string.Empty;


        /*Getter & Setter*/

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string ApellidoPrimero { get { return apellidoPrimero; } set { apellidoPrimero = value; } }
        public string ApellidoSegundo { get { return apellidoSegundo; } set { apellidoSegundo = value; } }
        public int DNI { get { return dni; } set { dni = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string TipoDni { get { return tipoDni; } set { tipoDni = value; } }






    }/*fin class persona*/
}/*fin namespace*/
