using System;
using System.Security.Cryptography.X509Certificates;

public class Punto4
{
	public Punto4()
	{ 
	}
    public int[] suma()
    {
        Console.WriteLine("ingrese 10 numeros");
        int[] numeros = new int[10];
        int resultado = 0;
        int[] datos = new int[2];
        

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("ingrese el numero " + (i+1));
            numeros[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            resultado=+numeros[i];
        }
        int promedio = resultado / 10;
         datos[0] = promedio; datos[1] = resultado;
        return datos;
    }
}
