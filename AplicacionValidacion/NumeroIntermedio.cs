using System;

namespace AplicacionValidacion
{
    public class NumeroIntermedio
    {
        public void HallarNumeroIntermedio()
        {
            Console.WriteLine("Ingrese un numero");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            var numDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero");
            var numTres = Convert.ToInt32(Console.ReadLine());

            if (numUno > numDos && numDos < numTres)
            {
                if (numUno > numTres)
                {
                    Console.WriteLine($"el numero intermedio es {numTres}");
                }
                else
                {
                    Console.WriteLine($"el numero intermedio es {numUno}");
                }

            }
            else if (numUno < numDos && numDos < numTres)
            {
                if (numUno > numTres)
                {
                    Console.WriteLine($"el numero intermedio es {numTres}");
                }
                
                Console.WriteLine($"el numero intermedio es {numDos}");
            }
            else if (numUno > numDos && numDos < numTres)
            {
                Console.WriteLine($"el numero intermedio es {numTres}");
            }
            else if (numUno < numDos && numDos < numTres)
            {
                Console.WriteLine($"el numero intermedio es {numUno}");
            }
            else if (numUno < numDos && numDos > numTres)
            {
                
                Console.WriteLine($"el numero intermedio es {numUno}");
            }
            else if (numUno > numDos && numDos > numTres)
            {
                Console.WriteLine($"el numero intermedio es {numDos}");
            }
            else if (numUno == numDos && numDos == numTres && numUno == numTres)
            {
                Console.WriteLine("Todos los numeros son iguales");
            }
            
        }
    }
}