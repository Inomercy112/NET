using System;

public class Punto8
{
    public Punto8()
    {
    }

    public void OrdenarNumeros()
    {
        Console.WriteLine("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número: ");
        int numero3 = int.Parse(Console.ReadLine());

        // Determinar el orden ascendente y descendente
        if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
        {
            Console.WriteLine($"El orden de los números de forma ascendente es {numero3} {numero2} {numero1}");
            Console.WriteLine($"El orden de los números de forma descendente es {numero1} {numero2} {numero3}");
        }
        else if (numero1 < numero2 && numero1 < numero3 && numero2 < numero3)
        {
            Console.WriteLine($"El orden de los números de forma ascendente es {numero1} {numero2} {numero3}");
            Console.WriteLine($"El orden de los números de forma descendente es {numero3} {numero2} {numero1}");
        }
        else
        {
            Console.WriteLine($"El orden de los números de forma ascendente es {numero3} {numero1} {numero2}");
            Console.WriteLine($"El orden de los números de forma descendente es {numero2} {numero1} {numero3}");
        }
    }
}

