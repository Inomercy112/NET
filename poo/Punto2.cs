using System;

public class Rectangle
{
	public int Longitud;
	public int Anchura;
	public Rectangle(int longitud , int anchura)
	{
		this.Longitud = longitud;
		this.Anchura = anchura;
	}
	public int area()
	{
		int operacion = 0;
		operacion = Longitud * Anchura;
		return operacion;
	}
}
