using System;

namespace variables2
{
    internal class Punto9
    {
        public CalculoTotalCompra() { }

        public void CalcularCompra()
        {
            Console.WriteLine("Ingrese el valor del producto 1: ");
            double producto1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de producto 1: ");
            int cantidad1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del producto 2: ");
            double producto2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de producto 2: ");
            int cantidad2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del producto 3: ");
            double producto3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de producto 3: ");
            int cantidad3 = int.Parse(Console.ReadLine());

            double iva1 = (producto1 * cantidad1) + (producto1 * cantidad1 * 0.16);
            double iva2 = (producto2 * cantidad2) + (producto2 * cantidad2 * 0.16);
            double iva3 = (producto3 * cantidad3) + (producto3 * cantidad3 * 0.16);

            double total = iva1 + iva2 + iva3;

            Console.WriteLine($"El valor de su compra es {total}");
        }
    }
}
