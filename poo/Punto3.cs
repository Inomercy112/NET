using System;

public class Circle
{
	public float Radio;
	public Circle(float radio)
	{
		this.Radio = radio;
	}
	public double Area()
	{
		double operacion;
		operacion = Radio * (3.1416 * 3.1416);
		return operacion;
	}
	public double Perimetro()
	{
		double operacion;
		operacion = (Radio * 2) * 3.1416;
		return operacion;
		
	}
}
