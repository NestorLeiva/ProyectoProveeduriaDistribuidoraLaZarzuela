namespace Utils
{
    public class Validaciones
    {
        public static bool soloNumeros(char caracter)
        {
            return char.IsControl(caracter) || char.IsDigit(caracter) || caracter == '\b';
            /* metodo para validar solamente el ingreso de numeros*/
        }

        public static bool soloLetras(string texto)  // metodo para realizar la validacion de solamente texto 
        {
            foreach (char caracter in texto) // con este bucle realizo un recorrido por cada caracter del string 
            {
                if (!char.IsLetter(caracter) && caracter != ' ' && caracter != '\b')
                {
                    return false;
                    /* se valida cada caracter No es una letra y no sea el caracter de control de retroceso '\b'
                     * ' ' representa la tecla de espcaio
                     * si el return es false indica que el caracter no es valido*/
                }
            }
            return true;
        }

        public static string ConvertirMayusculas(string texto)
        /*Este método toma una cadena de texto como parámetro y devuelve la misma cadena en mayúsculas.
         */
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentException("No pueden haber espacios vacios");
            }
            return texto.ToUpper();
        }



        public static bool soloLetrasMayusculas(string texto)
        /*toma una cadena de texto como parámetro, verifica si contiene solo letras y luego convierte la cadena a mayúsculas*/
        {
            if (soloLetras(texto))
            {
                string texto_Mayusculas = ConvertirMayusculas(texto);
                return true;
            }
            else
            {
                return false;
            }
        }





    }
}
