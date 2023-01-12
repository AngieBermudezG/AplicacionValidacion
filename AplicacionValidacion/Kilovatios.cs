using System;

namespace AplicacionValidacion
{
    public class Kilovatios
    {
        public void HallatKilovatios()
        {
            Console.WriteLine("Cantidad de Kilovatios a facturar");
            var factura = Convert.ToDouble(Console.ReadLine());

            if (factura < 1000)
            {
                var result = factura * 0.14;
                Console.WriteLine($"El valor a pagar es {result}");
            }
            else if (factura > 1000 && factura < 1800)
            {
                var result = factura * 0.12;
                Console.WriteLine($"El valor a pagar es {result}");
            }
            else if (factura > 1800)
            {
                var result = factura * 0.8;
                Console.WriteLine($"El valor a pagar es {result}");
            }
        }
    }
}