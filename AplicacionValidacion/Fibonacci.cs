using System;

namespace AplicacionValidacion
{
    public class Fibonacci
    {
        public void HallarElFibonacci()
        {
            var va1 = 0;
            var va2 =1;
            var total = 0;
            
            Console.WriteLine("De cuantos numero va hacer el Fibonacci");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            for (int i = 1; i <=numUno;i++)
            {
                total = va1;
                va1 = va2;
                va2 = total + va1;
                Console.WriteLine(va2);
            }
        }
    }
}