using System;

public class Punto12
{
    public Punto12()
    {
    }

    public void CalcularValorCompra()
    {
        Console.WriteLine("Ingrese el valor de la compra: ");
        decimal valor = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad de artículos comprados: ");
        int cosas = int.Parse(Console.ReadLine());

        if (cosas < 5)
        {
            Console.WriteLine($"El valor de su compra es {valor}");
        }
        else if (cosas >= 5 && cosas < 10)
        {
            decimal desc = valor * 0.05m; // Aplicar 5% de descuento
            decimal valort = valor - desc;
            Console.WriteLine($"El valor de su compra es {valort}");
        }
        else if (cosas >= 10)
        {
            decimal desc = valor * 0.08m; // Aplicar 8% de descuento
            decimal valort = valor - desc;
            Console.WriteLine($"El valor de su compra es {valort}");
        }
        else
        {
            Console.WriteLine("Hubo un error.");
        }
    }
}
