using System;

namespace AplicacionValidacion
{
    public class TodasTablasDeMultiplicar
    {
        public void TablasMultiplicar()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    var result = i * j;
                    Console.WriteLine($"{i} * {j} = {result}");
                }

                Console.WriteLine("*********** SIGUIENTE TABLA **************");
            }
            Console.WriteLine("*********** FINAL DE LAS TABLAS **************");
        }
    }
}