using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace variables2
{
    internal class Punto14
    {
        public ConversionDistancia() { }

        public void ConvertirDistancia()
        {
            Console.WriteLine("Ingrese una distancia en metros: ");
            double metros = double.Parse(Console.ReadLine());

            double km = metros / 1000;
            double cm = metros * 100;
            double mm = metros * 1000;

            Console.WriteLine($"La medida en km es: {km}");
            Console.WriteLine($"La medida en cm es: {cm}");
            Console.WriteLine($"La medida en mm es: {mm}");
        }
    }
}
