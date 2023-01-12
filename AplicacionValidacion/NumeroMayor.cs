using System;

namespace AplicacionValidacion
{
    public class NumeroMayor
    {
        public void HallarNumeroMayor()
        {
            Console.WriteLine("Ingrese un numero");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            var numDos = Convert.ToInt32(Console.ReadLine());

            if (numUno > numDos)
            {
                Console.WriteLine($"El numero {numUno} es mayor que {numDos}");
            }
            else if (numUno == numDos)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                Console.WriteLine($"El numero {numDos} es mayor que {numUno}");
            }
        }
        
        public void HallarNumeroMayorDeTres()
        {
            Console.WriteLine("Ingrese un numero");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            var numDos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo numero");
            var numTres = Convert.ToInt32(Console.ReadLine());

            if (numUno > numDos && numUno > numTres)
            {
                if (numDos > numTres)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numUno},  {numDos}, {numTres} ");
                }
                else if (numTres > numDos)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numUno},  {numTres}, {numDos} ");
                }

            }
            else if (numDos > numUno && numDos > numTres)
            {
                if (numUno > numTres)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numDos},  {numUno}, {numTres} ");
                }
                else if (numTres > numUno)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numDos},  {numTres}, {numUno} ");
                }
            }
            else if (numTres > numUno && numTres > numDos)
            {
                if (numUno > numDos)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numTres},  {numUno}, {numDos} ");
                }
                else if (numDos > numUno)
                {
                    Console.WriteLine($"El orden de los numero de mayor a menor son {numTres},  {numDos}, {numUno} ");
                }
            }
            else if (numUno == numDos && numUno == numTres)
            {
                Console.WriteLine("Todos los numero son iguales");
                
            }

        }
    }
    
   
}