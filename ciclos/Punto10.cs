using System;

public class Punto10
{
    public Punto10()
    {
    }

    public void ImprimirPatronZ()
    int n = 5;
    {
        // Línea superior
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Diagonal descendente
        for (int i = 1; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }

        // Línea inferior
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
