using System;

public class Punto2
{
    public Punto2()
    {
    }

    public void VerificarEdad()
    {
        Console.WriteLine("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad >= 0 && edad <= 17)
        {
            Console.WriteLine("Usted es menor de edad");
        }
        else if (edad >= 18 && edad <= 100)
        {
            Console.WriteLine("Usted es mayor de edad");
        }
        else
        {
            Console.WriteLine("Ingrese una edad válida");
        }
    }
}
