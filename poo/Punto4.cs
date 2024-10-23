using System;

public class Pow
{
	public int x;
	public int n;
	public Pow(int x , int n)
	{
		this.x = x;
		this.n = n;

	}
	public int pow()
	{
		int result = 1;
		for (int i = 0; i < n; i++)
		{
			result *=x;
		}
		return x;

	}
}
