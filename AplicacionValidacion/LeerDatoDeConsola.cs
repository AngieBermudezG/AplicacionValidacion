using System;
using System.ComponentModel.Design;

namespace AplicacionValidacion
{
    public class LeerDatoDeConsola
    {
        public void LeerElDatoIngresadoPorConsola()
        {
            Console.WriteLine("Ingrese un solo caracter, el que tu quieras");
            char caracter = Convert.ToChar(Console.ReadLine());


            if (Char.IsLetter(caracter))
            {
                if (Char.ToLower(caracter) == 'a' || Char.ToLower(caracter) == 'e' || Char.ToLower(caracter) == 'i' ||
                    Char.ToLower(caracter) == '0' || Char.ToLower(caracter) == 'u') 
                {
                    Console.WriteLine("Tu caracter es una vocal");
                }
                else 
                {
                    Console.WriteLine("Tu caracter es una consonante");
                }
                
            }
            else
            {
                Console.WriteLine("Ingresaste un numero");
                    
            }
            

         
        } 
        
    }
}