using System;

namespace AplicacionValidacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*NumerosInvertidos invertirDos = new NumerosInvertidos();
            invertirDos.InvertiendoDosNumeros();
            invertirDos.InvertirTresNumeros();*/
            OperacionesMatematicas operacionesMatematicas = new OperacionesMatematicas();
            operacionesMatematicas.OperacionesMatematicasSinCiclo();
            operacionesMatematicas.OperacionesMatematicasConObcionesSwich();
        }
    }
}