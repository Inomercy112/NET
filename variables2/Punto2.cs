using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables2
{
    internal class Punto2
    {
        public Punto2() { }
        public int Raiz()
        {
            Console.WriteLine("ingrese el numero a sacar la raiz");
            int numero = int.Parse( Console.ReadLine());
            int resultado = numero * numero;
            return resultado;
        }
    }
}
