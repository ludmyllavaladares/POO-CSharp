using System;
using System.Globalization;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SalarioMedio media1, media2;
            media1 = new SalarioMedio();
            media2 = new SalarioMedio();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            media1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            media1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            media2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            media2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (media1.salario + media2.salario) / 2.0;

            Console.WriteLine("A média salarial é = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
