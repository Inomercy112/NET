using System;

public class Punto7
{
    public Punto7()
    {
    }

    public void ImprimirPatronNumeros()
    {
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numero; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
