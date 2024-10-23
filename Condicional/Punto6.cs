using System;

public class Punto6
{
    public Punto6()
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

        // Ordenar y mostrar los números en forma ascendente y descendente
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
            Console.WriteLine($"El orden de los números de forma ascendente es {Math.Min(numero1, Math.Min(numero2, numero3))} " +
                            $"{Math.Max(Math.Min(numero1, numero2), Math.Min(numero2, numero3))} " +
                            $"{Math.Max(numero1, Math.Max(numero2, numero3))}");
            Console.WriteLine($"El orden de los números de forma descendente es {Math.Max(numero1, Math.Max(numero2, numero3))} " +
                            $"{Math.Max(Math.Min(numero1, numero2), Math.Min(numero2, numero3))} " +
                            $"{Math.Min(numero1, Math.Min(numero2, numero3))}");
        }
    }
}

