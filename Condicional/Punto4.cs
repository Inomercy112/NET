using System;

public class Punto4
{
    public Punto4()
    {
    }

    public void CompararNumeros()
    {
        Console.WriteLine("Ingrese dos números: ");
        int numero1 = int.Parse(Console.ReadLine());
        int numero2 = int.Parse(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"El número {numero1} es mayor que el número {numero2}");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine($"El número {numero2} es mayor que el número {numero1}");
        }
        else
        {
            Console.WriteLine("Son iguales");
        }
    }
}

