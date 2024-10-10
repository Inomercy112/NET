using System;

namespace variables2
{
    internal class Punto11
    {
        public CalculoRaizCuadrada() { }

        public void CalcularRaizCuadrada()
        {
            Console.WriteLine("Ingrese un número: ");
            double numero = double.Parse(Console.ReadLine());

            double raiz = Math.Sqrt(numero);

            Console.WriteLine($"La raíz cuadrada del número {numero} es {raiz}");
        }
    }
}
