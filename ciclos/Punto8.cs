using System;

public class Punto8
{
    public Punto8()
    {
    }

    public void ImprimirPatronNumerico()
    {
        int numero = 1;

        for (int i = 1; i <= 4; i++)
        {
            // Espacios en blanco
            for (int j = 1; j <= 4 - i; j++)
            {
                Console.Write(" ");
            }
            // Números incrementales
            for (int k = 1; k <= i; k++)
            {
                Console.Write(numero++ + " ");
            }
            Console.WriteLine();
        }
    }
}
