using System;

namespace AplicacionValidacion
{
    public class AdivinaNumero
    {
        public void NumeroAleatorio()
        {
            Random numero = new Random();
            var createNumber = numero.Next(0, 100);
            
            int i = 0;
            var num = 0;

            while (createNumber != num)
            {
                Console.WriteLine("Adivina el numero oculto del 1 al 100");
                num = Convert.ToInt32(Console.ReadLine());
                i++;
                if (num < createNumber)
                {
                    Console.WriteLine("El numero oculto es mayor");
                }
                else if (num == createNumber)
                {
                    Console.WriteLine($"!!! Adivinaste el numero ¡¡¡¡¡¡¡ {createNumber} y tuviste {i} intentos");
                }
                else
                {
                    Console.WriteLine("El numero oculto es menor");
                }
            }

            
        }
       
    }
}