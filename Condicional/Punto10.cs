using System;

public class Punto10
{
    public Punto10()
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
            Console.WriteLine($"El valor de su compra es = {valor}");
        }
        else if (llantas >= 6 && llantas < 8)
        {
            valor = 221000 * llantas;
            Console.WriteLine($"El valor de su compra es = {valor}");
        }
        else
        {
            valor = 180000 * llantas;
            Console.WriteLine($"El valor de su compra es = {valor}");
        }
    }
}
