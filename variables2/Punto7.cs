using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace variables2
{
    internal class Punto7
    {
        public AreaCuadrado() { }

        public void CalcularArea()
        {
            Console.WriteLine("Ingrese la longitud de un lado en cm: ");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * lado;

            Console.WriteLine($"El área de su cuadrado es {area} cm²");
        }
    }
}
