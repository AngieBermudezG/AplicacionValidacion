using System;

namespace AplicacionValidacion
{
    public class NumerosInvertidos
    {
        public void InvertiendoDosNumeros()
        {
            Console.WriteLine("Ingrese un numero de dos cifras");
            var num = Convert.ToInt32(Console.ReadLine());

            var dividirNumero = num / 10;
            var reciduo = num % 10;
            var result = (reciduo * 10) + dividirNumero;

            Console.WriteLine($"Su numero invertido es {result}");
        }

        public void InvertirTresNumeros()
        {
            Console.WriteLine("Ingrese un numero de 3 cifras");
            var num = Convert.ToInt32(Console.ReadLine());

            var dividir = num / 100;
            num = num % 100;
            var dec = num / 10;
            var uni = num % 10;
            var result = (uni * 100) + (dec * 10) + dividir;

            Console.WriteLine($"Su numero invertido es {result}");
        }
        
    }
}