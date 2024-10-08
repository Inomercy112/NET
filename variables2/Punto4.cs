using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables2
{
    internal class Punto4
    {
        public Punto4() { }
        public int Edad()
        {
            int año = DateTime.Now.Year;
            Console.WriteLine("ingrese su fecha de nacimiento");
            int edad = int.Parse(  Console.ReadLine());
            int op = año-edad;
            return op;

        }
    }
}
