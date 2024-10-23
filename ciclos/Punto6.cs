using System;

public class Punto6
{
    public Punto6()
    {
    }

    public void ImprimirPatron()
    {
        // Primera parte del patrón
        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Segunda parte del patrón
        for (int i = 5 - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
