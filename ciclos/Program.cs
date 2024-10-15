namespace ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto3 punto1 = new Punto3 ();
            int[] resultado= punto1.Secuencia();
            Console.WriteLine("la secuencia es");
            for (int i = 0; i < resultado.Length; i++) {
              Console.WriteLine(resultado[i]);
            }
        }
    }
}
