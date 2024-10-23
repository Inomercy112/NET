using System;

public class Punto9
{
    public Punto9()
    {
    }

    public void DeterminarMetodoPago()
    {
        Console.WriteLine("Ingrese la cantidad de dinero a pagar: ");
        decimal cuenta = decimal.Parse(Console.ReadLine());

        if (cuenta < 150000)
        {
            Console.WriteLine("El pago debe ser en efectivo.");
        }
        else if (cuenta >= 150000 && cuenta < 300000)
        {
            Console.WriteLine("El pago debe ser con el celular.");
        }
        else if (cuenta >= 300000 && cuenta < 600000)
        {
            Console.WriteLine("El pago debe ser con tarjeta débito.");
        }
        else
        {
            Console.WriteLine("El pago debe ser con tarjeta de crédito.");
        }
    }
}
