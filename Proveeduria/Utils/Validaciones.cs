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
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter) && caracter != '\b')
                /*verificar explícitamente si el caracter es un espacio en blanco*/
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
        /*Este método toma una cadena de texto como parámetro y devuelve la misma cadena en mayúsculas. */
        {
            if (string.IsNullOrEmpty(texto))
            {
                return string.Empty;
            }
            return texto.ToUpper();
        }



        public static bool soloLetrasMayusculas(string texto)
        /*toma una cadena de texto como parámetro, verifica si contiene solo letras y luego convierte la cadena a mayúsculas*/
        {
            return soloLetras(texto) && !string.IsNullOrEmpty(ConvertirMayusculas(texto));
        }





    }
}
