using System;

namespace AplicacionValidacion
{
    public class OperacionesMatematicas
    {
        public void OperacionesMatematicasSinCiclo()
        {
            Console.WriteLine("Ingrese un numero");
            var numUno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            var numDos = Convert.ToInt32(Console.ReadLine());

            var suma = numUno + numDos;
            var resta = numUno - numDos;
            var multi = numUno * numDos;
            var divi = numUno / numDos;

            Console.WriteLine($"La suma de tus numeros es {suma}");
            Console.WriteLine($"La resta de tus numeros es {resta}");
            Console.WriteLine($"El resultado de tu multiplicación es {multi}");
            Console.WriteLine($"El resultado de tu division es {divi}");

        }

        public void OperacionesMatematicasConObcionesSwich()
        {
            Console.WriteLine("Escribe el numero de la opcion a realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese un numero");
                    var numUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese otro numero");
                    var numDos = Convert.ToInt32(Console.ReadLine());
                    var result = numUno + numDos;
                    Console.WriteLine($"El resultado de tu suma es {result}");
                    break;
                case 2:
                    Console.WriteLine("Ingrese un numero");
                    numUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa otro numero");
                    numDos = Convert.ToInt32(Console.ReadLine());
                    result = numUno - numDos;
                    Console.WriteLine($"El resultado de tu resta es {result}");
                    break;
                case 3:
                    Console.WriteLine("Ingrese un numero");
                    numUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa otro numero");
                    numDos = Convert.ToInt32(Console.ReadLine());
                    result = numUno * numDos;
                    Console.WriteLine($"El resultado de tu multiplicacion es {result}");
                    break;
                case 4:
                    Console.WriteLine("Ingrese un numero");
                    numUno = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa otro numero");
                    numDos = Convert.ToInt32(Console.ReadLine());
                    result = numUno / numDos;
                    Console.WriteLine($"El resultado de tu división es {result}");
                    break;
                default:
                    Console.WriteLine("La Opcion no existe");
                    break;
                    
            }
        }
    }
}