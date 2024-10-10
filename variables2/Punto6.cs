using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace variables2
{
    internal class Punto6
    {
        public Porcentajes() { }

        public void CalcularPorcentajes()
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            double calculo30 = numero * 0.30;
            double calculo60 = numero * 0.60;
            double calculo90 = numero * 0.90;

            Console.WriteLine($"El 30% de {numero} es {calculo30}");
            Console.WriteLine($"El 60% de {numero} es {calculo60}");
            Console.WriteLine($"El 90% de {numero} es {calculo90}");
        }
    }
}
