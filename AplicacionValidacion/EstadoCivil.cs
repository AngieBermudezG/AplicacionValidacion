using System;

namespace AplicacionValidacion
{
    public class EstadoCivil
    {
        public void EscribirEstadoCivil()
        {
            Console.WriteLine("Ingrese una de esta Letras para saber tu estado C, S, D, V, U");
            var estado = Console.ReadLine();

            switch (estado)
            {
                case "c": Console.WriteLine("Estas Casado");
                    break;
                case "s": Console.WriteLine("Estas Soltero");
                    break;
                case "d": Console.WriteLine("Estas Divorciado");
                    break;
                case "v": Console.WriteLine("Estas Viudo");
                    break;
                case "u" : Console.WriteLine("Estas en Union Libre");
                    break;
                default: Console.WriteLine("La opcion no existe");
                    break;
            }
        }
        
        
    }
}