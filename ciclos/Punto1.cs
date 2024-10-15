using System;

public class Punto1
{
	public Punto1()	{}

	public int[] Numeros()
	{
		int[] result = new int[10];
		for (int i = 0; i <= 9; i++)
		{
			result[i] = i+1;
		}
        return result;
    }
}