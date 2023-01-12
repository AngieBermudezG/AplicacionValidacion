using System;

namespace AplicacionValidacion
{
    public class TablaDeMultiplicar
    {
        public void TablaMultiplicar()
        {
            Console.WriteLine("Ingrese el numero de la tabla de multiplicar a consultar");
            var tabla = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var result = i * tabla;
                Console.WriteLine($"{tabla} * {i} = {result}");
            }
        }
    }
}