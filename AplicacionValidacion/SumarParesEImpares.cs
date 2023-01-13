using System;

namespace AplicacionValidacion
{
    public class SumarParesEImpares
    {
        public void HallarSumaDeParesEImpares()
        {
            var result = 0;
            var resultIm = 0;
            
            for (int i = 1; i <=7; i++)
            {
                Console.WriteLine("Ingrese un numero");
                var num = Convert.ToInt32(Console.ReadLine());
                
                if (num %2 == 0)
                {
                    result += num;
                }
                else
                {
                    resultIm += num;
                }
                
            }
            Console.WriteLine($"La suma de tus numeros pares es {result}");
            Console.WriteLine($"La suma de tus impares es {resultIm}");
            
        }
        
    }
}