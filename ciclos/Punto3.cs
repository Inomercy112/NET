using System;

public class Punto3
{
	public Punto3()
	{
	}
	public int[] Secuencia()
	{
		Console.WriteLine("ingrese su secuencia de fibonacci");
		int secuencia = int.Parse(Console.ReadLine());
		int[] resultado = new int[secuencia];

		if (secuencia >= 1) resultado[0] = 0;
		if (secuencia >= 2) resultado[1] = 1;
		for (int i = 2; i < secuencia; i++)
		{
			resultado[i] = resultado[i - 1] + resultado[i - 2];
		}
		return resultado;
	}
}
