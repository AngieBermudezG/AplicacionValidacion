using System;

namespace AplicacionValidacion
{
    public class EjercicioPropuesto
    {
        //CRear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "David",
        //o bien le diga "NO te conozco" si teclea otro nombre

        public void ValidarNombre()
        {
            Console.WriteLine("Digite su nombre");
            var name = Console.ReadLine();

            if (name == "David" )
            {
                Console.WriteLine($"Hola Bienvenido {name}");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
        }
    }
}