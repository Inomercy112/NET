using System;

public class Punto7
{
    public Punto7()
    {
    }

    public void CalcularValorLlantas()
    {
        Console.WriteLine("Ingrese las llantas compradas: ");
        int llantas = int.Parse(Console.ReadLine());

        int valor;

        if (llantas < 6 && llantas > 0)
        {
            valor = 240000 * llantas;
            Console.WriteLine($"El valor de su compra es = ${valor}");
        }
        else if (llantas >= 6 && llantas < 8)
        {
            valor = 221000 * llantas;
            Console.WriteLine($"El valor de su compra es = ${valor}");
        }
        else if (llantas >= 8)
        {
            valor = 180000 * llantas;
            Console.WriteLine($"El valor de su compra es = ${valor}");
        }
        else
        {
            Console.WriteLine("Ingrese un número válido de llantas.");
        }
    }
}
