using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables2
{
    internal class Punto5
    {
        public Punto5() { }
        public string Porcentaje()
        {
            Console.WriteLine("ingrese un numero");
            int numero = int.Parse(Console.ReadLine());
            double op = numero * 0.2;
            string texto = "el 20% del " + numero + " es " + op ;
            return texto ;
        }
    }
}
