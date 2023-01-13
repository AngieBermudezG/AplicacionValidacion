using System;

namespace AplicacionValidacion
{
    public class PromedioCalificaciones
    {
        public void HallarPromedio()
        {
            double nota1 = 0;
            double nota2 = 0;
            double total = 0;
            
            Console.WriteLine("Cuantos estudiantes vas a sacar promedio");
            var cant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                var name = Console.ReadLine();
                Console.WriteLine("Ingrese la nota 1");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la nota 2");
                nota2 = Convert.ToDouble(Console.ReadLine());
                var result = (nota1 + nota2) / 2;
                total += result;
                Console.WriteLine($"Promedio de las notas {result}");
            }

            var media = total / cant;
            Console.WriteLine($"Suma Total de las notas {total}");
            Console.WriteLine($"Promedio de todos los alumnos {media}");
        }
    }
}