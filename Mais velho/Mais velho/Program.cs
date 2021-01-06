using System;


namespace Mais_velho
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;
            pessoa1 = new Dados();
            pessoa2 = new Dados();

            Console.WriteLine("Digite seu nome e idade");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu nome e idade");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());

            if (pessoa2.idade > pessoa1.idade)
            {
                Console.WriteLine("A pessoa mais velha é: "+ pessoa2.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + pessoa1.nome);
            }


        }
    }
}
