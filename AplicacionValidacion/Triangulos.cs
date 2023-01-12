using System;

namespace AplicacionValidacion
{
    public class Triangulos
    {
        public void TiposDeTriangulos()
        {
            Console.WriteLine("Clases de triangulos segun sus lados");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite el primer lado del triangulo");
            var primero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el segundo lado del triangulo");
            var segundo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite el tercer lado del triangulo");
            var tercero = Convert.ToDouble(Console.ReadLine());

            if (primero == segundo && segundo == tercero && primero == tercero)
            {
                Console.WriteLine("El triangulo es Equilatero");
            }
            else if (primero == segundo && segundo != tercero)
            {
                Console.WriteLine("El triangulo es Isósceles");
            }
            else if (primero != segundo && segundo != tercero)
            {
                Console.WriteLine("El triangulo es escaleno");
            }
            else
            {
                Console.WriteLine("El triangulo no existe sus medidas no son correctas");
            }
        }
    }
}