using System;

namespace ImprimirNome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string EntradaNome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int EntradaIdade = int.Parse(Console.ReadLine());

            ImprimirTextoDados(EntradaNome, EntradaIdade);

            Console.ReadKey();
        }

        static void ImprimirTextoDados(string nome, int idade)
        {
            Console.WriteLine("Meu nome é: " + nome + ",e tenho " + idade + " anos de idade.");
        }

    }
}
