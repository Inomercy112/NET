using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables2
{
    internal class Punto3
    {
        public Punto3()
        {

        }
        public int Velocidad()
        {
            Console.WriteLine("ingrese la velocidad en km/h");
            int velocidad = int.Parse( Console.ReadLine());
            Console.WriteLine("ingrese el tiempo en horas");
            int tiempo = int.Parse( Console.ReadLine());
            
            int x = velocidad * tiempo;
            return x;
        }
    }
}
