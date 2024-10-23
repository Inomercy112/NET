using System;

public class Punto3
{
    public Punto3()
    {
    }

    public void VerificarNumero()
    {
        Console.WriteLine("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine($"El número {numero} es positivo");
        }
        else if (numero < 0)
        {
            Console.WriteLine($"El número {numero} es negativo");
        }
        else
        {
            Console.WriteLine("El número es cero");
        }
    }
}
