using System;
using System.Globalization;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func = new Funcionario();

            Console.WriteLine("Nome: ");
            Func.Nome = Console.ReadLine();
            Console.WriteLine("Salário Bruto: ");
            Func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Imposto: ");
            Func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + Func);

            Console.WriteLine();
            Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + Func);

        }
    }
}
