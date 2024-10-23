using System;
using System.Collections.Generic;

public class Punto5
{
    public Punto5()
    {
    }

    public void CalcularPromedioNotas()
    {
        Console.WriteLine("Ingrese 5 notas: ");
        List<double> notas = new List<double>();
        double sumaNotas = 0;

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Ingrese la nota {i}: ");
            double nota = double.Parse(Console.ReadLine());

            if (nota > 5 || nota < 0)
            {
                Console.WriteLine("Ingrese notas válidas!!");
                break;
            }
            else
            {
                sumaNotas += nota;
                notas.Add(nota);
            }
        }

        if (notas.Count == 5) // Verifica que se hayan ingresado 5 notas válidas
        {
            double promedio = sumaNotas / 5;
            if (promedio >= 3.0)
            {
                Console.WriteLine($"Usted aprobó con {promedio}");
            }
            else
            {
                Console.WriteLine($"Usted no aprobó con {promedio}");
            }
        }
    }
}
