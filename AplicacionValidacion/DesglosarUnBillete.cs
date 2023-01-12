using System;

namespace AplicacionValidacion
{
    public class DesglosarUnBillete
    {
        public void DesglosandoBillete()
        {
            Console.WriteLine("Ingrese el valor del billete");
            var valor = Convert.ToInt32(Console.ReadLine());

            var valorMil = 0;
            var valorCincuenta = 0;
            var valorVeinte = 0;
            var valorDies = 0;
            var valorCinco = 0;
            var valorUno = 0;

            if (valor >= 10000)
            {
                valorMil = (valor / 10000);
                valor = valor - (valorMil * 10000);
            }
            if (valor >= 5000)
            {
                valorCincuenta = (valor / 5000);
                valor = valor - (valorCincuenta * 5000);
            }
            if (valor >= 2000)
            {
                valorVeinte = (valor / 2000);
                valor = valor - (valorVeinte * 2000);
            }
            if (valor >= 1000)
            {
                valorUno = (valor / 1000);
                valor = valor - (valorUno * 1000);
            }
            if (valor >= 500)
            {
                valorCinco = (valor / 500);
                valor = valor - (valorCinco * 500);
            }

            Console.WriteLine($"Tienes {valorMil} Billetes de $10.000 ");
            Console.WriteLine($"Tienes {valorCincuenta} Billetes de $5.000 ");
            Console.WriteLine($"Tienes {valorVeinte} Billetes de $2.000 ");
            Console.WriteLine($"Tienes {valorDies} Billetes de $1.000 ");
            Console.WriteLine($"Tienes {valorCinco} Billetes de $500 ");
            Console.WriteLine($"Tienes {valorUno} Billetes de $100 ");
        }
    }
}