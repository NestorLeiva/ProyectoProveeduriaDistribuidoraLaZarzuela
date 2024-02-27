namespace Utils
{
    public class Validaciones
    {
        public static bool soloNumeros(char caracter)
        {
            return char.IsControl(caracter) || char.IsDigit(caracter) || caracter == '\b' || caracter == '.' || caracter == ',';
            /* metodo para validar solamente el ingreso de numeros*/
        }

        public static bool validarTelefono(string numeroTelefono)
        {
            return numeroTelefono.Length == 7 && numeroTelefono.All(char.IsDigit);
            /*Valido la cantidad de numeros del numero de telefono*/
        }


        public static bool soloLetras(string texto)  // metodo para realizar la validacion de solamente texto 
        {
            string textoMayusclas = texto.ToUpperInvariant();
            foreach (char caracter in textoMayusclas) // con este bucle realizo un recorrido por cada caracter del string 
            {
                if (!char.IsLetter(caracter) && !char.IsWhiteSpace(caracter) && caracter != '\b' || caracter == '@')
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






    }
}
