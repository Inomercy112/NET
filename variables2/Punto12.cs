using System;

namespace variables2
{
    internal class Punto12
    {
        public CalculoHipotenusa() { }

        public void CalcularHipotenusa()
        {
            Console.WriteLine("Ingresa el cateto opuesto: ");
            double catetoOpuesto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cateto adyacente: ");
            double catetoAdyacente = double.Parse(Console.ReadLine());

            double hipotenusa = Math.Sqrt((catetoAdyacente * catetoAdyacente) + (catetoOpuesto * catetoOpuesto));

            Console.WriteLine($"La hipotenusa es: {hipotenusa}");
        }
    }
}
