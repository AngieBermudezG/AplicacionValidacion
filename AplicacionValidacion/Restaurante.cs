using System;

namespace AplicacionValidacion
{
    public class Restaurante
    {
        public void CompresRestaurante()
        {
            
            Console.WriteLine("Cuantas Hamburguesas vas a llevar");
            var resulHam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas Papas Fritas vas a llevar");
            var resulPapa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas Pizzas vas a llevar");
            var resulPizza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantos Perros calientes vas a llevar");
            var resulPerro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas Empanadas vas a llevar");
            var resulEmpa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas Gaseosas vas a llevar");
            var resulGase = Convert.ToInt32(Console.ReadLine());

            var hamburger = resulHam * 6500;
            var papas = resulPapa * 4000;
            var pizza  = resulPizza * 2500;
            var perro = resulPerro * 5500;
            var empa = resulEmpa * 1500;
            var gas = resulGase * 1800;
            var result = hamburger + papas + pizza + perro + empa + gas;

            Console.WriteLine($"El total de tu pedido es {result}");

        }
    }
}