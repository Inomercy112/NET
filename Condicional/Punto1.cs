using System;

public class Punto1
{
    public Punto1()
    {
    }

    public void VerificarParImpar()
    {
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Su número es par");
        }
        else
        {
            Console.WriteLine("Su número es impar");
        }
    }
}
