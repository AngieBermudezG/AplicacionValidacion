using System;

namespace AplicacionValidacion
{
    public class BonoEmpleado
    {
        public void GenerandoBonoEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado");
            var name = Console.ReadLine();
            Console.WriteLine("Cuantos hijos tiene?");
            var hijos = Convert.ToInt32(Console.ReadLine());
            var sueldo = 350450;
            var bono = 25000;
            var result = bono * hijos;

            Console.WriteLine($"Nombre del Empleado {name}");
            Console.WriteLine($"Salario del Empleado {sueldo}");
            Console.WriteLine($"Numero de hijos {hijos}");
            Console.WriteLine($"Recibe Bono de {result}");
            Console.WriteLine($"Total a recibir este mes {result + sueldo}");
        }
    }
}