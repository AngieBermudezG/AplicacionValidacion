using System;

namespace AplicacionValidacion
{
    public class DiasDeLaSemana
    {
        public void HallarDiaSemana()
        {
            Console.WriteLine("Ingrese un numero para saber que dia de la semana es");
            var semana = Convert.ToInt32(Console.ReadLine());

            switch (semana)
            {
                case 1: Console.WriteLine("El numero que ingresaste corresponde al dia: LUNES");
                    break;
                case 2: Console.WriteLine("El numero que ingresaste corresponde al dia: MARTES");
                    break;
                case 3: Console.WriteLine("El numero que ingresaste corresponde al dia: MIERCOLES");
                    break;
                case 4: Console.WriteLine("El numero que ingresaste corresponde al dia: JUEVES");
                    break;
                case 5: Console.WriteLine("El numero que ingresaste corresponde al dia: VIERNES");
                    break;
                case 6: Console.WriteLine("El numero que ingresaste corresponde al dia: SABADO");
                    break;
                case 7: Console.WriteLine("El numero que ingresaste corresponde al dia: DOMINGO");
                    break;
                default: Console.WriteLine("Esa Opcion no existe");
                    break;
            }
        }
    }
}