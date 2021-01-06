using System;
using System.Globalization;

namespace Circunferencia
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("CIRCUNFERÊNCIA: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("VOLUME: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("VALOR DE PI: " + Calculadora.PI.ToString("F2", CultureInfo.InvariantCulture));

        }
        

    }
}
