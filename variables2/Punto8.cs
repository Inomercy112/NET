using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace variables2
{
    internal class Punto8
    {
        public PromedioNumeros() { }

        public void CalcularPromedio()
        {
            Console.WriteLine("Ingresa el primer número: ");
            double numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo número: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer número: ");
            double numero3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cuarto número: ");
            double numero4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el quinto número: ");
            double numero5 = double.Parse(Console.ReadLine());

            double suma = numero1 + numero2 + numero3 + numero4 + numero5;
            double resultado = suma / 5;

            Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
