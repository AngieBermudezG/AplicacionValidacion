using System;

namespace AplicacionValidacion
{
    public class Operaciones
    {
        /*El usuario debe ingresar dos números y el programa mostrará el resultado de la
        operación (a+b)*(a-b)*/

        public void OperacionConParentesis()
        {
            Console.WriteLine("Ingrese Un numero");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            var numDos = Convert.ToInt32(Console.ReadLine());

            var result = (numUno + numDos) * (numUno - numDos);
            Console.WriteLine($"el resultado de tu operacion es {result}");
        }
    }
}