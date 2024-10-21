using System;

public class Punto13
{
    public Punto13()
    {
    }

    public void CalcularIMC()
    {
        Console.WriteLine("Ingrese su peso en kg: ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese su altura en m: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Se encuentra en estado desnutrido.");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Se encuentra en estado normal.");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Se encuentra en estado sobrepeso.");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Se encuentra en estado Obesidad Grado 1.");
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("Se encuentra en estado Obesidad Grado 2.");
        }
        else if (imc >= 40 && imc < 50)
        {
            Console.WriteLine("Se encuentra en estado Obesidad Grado 3.");
        }
        else if (imc >= 50)
        {
            Console.WriteLine("Se encuentra en estado Obesidad Grado 4.");
        }
        else
        {
            Console.WriteLine("Dato no correcto.");
        }
    }
}
