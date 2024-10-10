using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace variables2
{
    internal class Punto10
    {
        public CalculoSalario() { }

        public void CalcularSalarioFinal()
        {
            Console.WriteLine("Ingresa el valor del salario diario: ");
            double salariod = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el número de días trabajados: ");
            int dias = int.Parse(Console.ReadLine());

            double salario = salariod * dias;
            double pension = salario * 0.1;
            double salud = salario * 0.15;
            double salariof = salario - pension - salud;

            Console.WriteLine($"Su salario final es: {salariof}");
        }
    }
}
