using System;

namespace variables2
{
    internal class Punto13
    {
        public ConversionTiempo() { }

        public void ConvertirSegundos()
        {
            Console.WriteLine("Ingrese el tiempo en segundos para convertirlos en minutos y horas: ");
            double segundos = double.Parse(Console.ReadLine());

            double minutos = segundos / 60;
            double horas = minutos / 60;

            Console.WriteLine($"Sus segundos en minutos son: {minutos}, y en horas son: {horas}");
        }
    }
}
