using System;

namespace AplicacionValidacion
{
    public class MayorMenorDeNNumeros
    {
        public void HallarCualesMayorYMenor()
        {
            var numME = Int32.MaxValue;
            var numMA = Int32.MinValue;
            
            Console.WriteLine("Cuantos Numeros vas a validar");
            var limite = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine("Digite un numero");
                 var num = Convert.ToInt32(Console.ReadLine());
                 
                 if (num < numME)
                 {
                     numME = num;
                     
                 }

                 if (num > numMA)
                 {
                     numMA = num;
                 }
            }
            Console.WriteLine($"El numero mayor es {numMA}");
            Console.WriteLine($"El numero menor es {numME}");

        }
        
    }
}