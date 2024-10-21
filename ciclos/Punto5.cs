using System;

public class Punto5
{
    public Punto5()
    {
    }

    public void TablaMultiplicar()
    {
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int mult = numero * i;
            Console.WriteLine($"La multiplicación de {numero} por {i} es {mult}");
        }
    }
}
