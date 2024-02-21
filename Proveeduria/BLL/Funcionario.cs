using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Funcionario : Persona /*herencia de clase Persona*/
    {
        public Funcionario() { }

        public Funcionario(string contrasenia, Guid codigoFuncionario)
        {
            Contrasenia = contrasenia;
            CodigoFuncionario = codigoFuncionario;
 
        }

        private string contrasenia = string.Empty;  
        private Guid codigoFuncionario = Guid.Empty;


        /*Getter & Setter*/
        public string Contrasenia { get { return contrasenia; } set {  contrasenia = value; } }
        public Guid CodigoFuncionario { get {  return codigoFuncionario; } set {  codigoFuncionario = value; } }


    }
}
