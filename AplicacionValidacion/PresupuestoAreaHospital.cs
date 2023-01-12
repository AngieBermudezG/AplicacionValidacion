using System;
using System.Threading.Channels;

namespace AplicacionValidacion
{
    public class PresupuestoAreaHospital
    {
        public void HallarPresupuestoPorArea()
        {
            Console.WriteLine("Cuantas areas vas a calcular");
            var calcu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el total del presupuesto");
            var presu = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= calcu; i++)
            {
                Console.WriteLine("Digite Area a consultar Pediatria, Odontologia, Cardiologia, Terapia");
                var area = Console.ReadLine();
                double recibe = 0;

                switch (area)
                {
                    case "Pediatria":
                        recibe = 40;
                       
                        break;
                    case "Odontologia":
                        recibe = 30;
                       
                        break;
                    case "Cardiologia":
                        recibe = 20;
                        
                        break;
                    case "Terapia":
                        recibe = 10;
                        
                        break;
                    default: Console.WriteLine("Esa area no existe");
                        break;
                }

                var total = (presu * recibe) / 100;
                Console.WriteLine($"El presupuesto de {area} es ${recibe}");
            }
        }
    }
}