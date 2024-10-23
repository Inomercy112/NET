using System;

public class Punto9
{
    public Punto9()
    {
    }

    public void CalcularFactorial()
    {
        Console.WriteLine("Digite un número para sacarle el factorial: ");
        int numero = int.Parse(Console.ReadLine());
        int resultado = 1;

        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }

        Console.WriteLine($"El factorial de {numero} es {resultado}");
    }
}
