using System;

public class Punto11
{
    public Punto11()
    {
    }

    public void CalcularValorPizza()
    {
        string lista = "Escoja el tamaño de la pizza:\n1- valor 15.000\n2- valor 24.000\n3- valor 36.000";
        Console.WriteLine(lista);
        
        int elec = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la cantidad de ingredientes adicionales: ");
        int extra = int.Parse(Console.ReadLine());

        int valor;

        if (elec == 1)
        {
            valor = 15000 + (extra * 4000);
            Console.WriteLine($"El valor de su compra es {valor}");
        }
        else if (elec == 2)
        {
            valor = 24000 + (extra * 4000);
            Console.WriteLine($"El valor de su compra es {valor}");
        }
        else if (elec == 3)
        {
            valor = 36000 + (extra * 4000);
            Console.WriteLine($"El valor de su compra es {valor}");
        }
        else
        {
            Console.WriteLine("No existe ese tamaño de pizza.");
        }
    }
}

