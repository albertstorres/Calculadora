using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Lista de opções:");
                Console.WriteLine("1 - SOMA");
                Console.WriteLine("2 - SUBTRAÇÃO");
                Console.WriteLine("3 - DIVISÃO");
                Console.WriteLine("4 - MULTIPLICAÇÃO");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("");

                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 5: System.Environment.Exit(0); break;
                }
            }
            while (opcao > 0 && opcao < 5);
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro termo da soma: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo termo da soma: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float soma = primeiroTermo + segundoTermo;

            Console.WriteLine($"Soma = {soma}");
            Console.WriteLine("");
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro termo da subtração: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo termo da subtração: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float subtracao = primeiroTermo - segundoTermo;

            Console.WriteLine($"Subtração = {subtracao}");
            Console.WriteLine("");
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o dividendo: ");
            float dividendo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o divisor: ");
            float divisor = float.Parse(Console.ReadLine());

            if (divisor == 0)
            {
                do
                {
                    Console.WriteLine("Divisão por zero não é possível ser feita.");
                    Console.WriteLine("Digite um divisor diferente de zero: ");
                    divisor = float.Parse(Console.ReadLine());
                }
                while (divisor == 0);
            }

            float divisao = dividendo / divisor;

            Console.WriteLine($"Divisão = {divisao}");
            Console.WriteLine("");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro tero da multiplicação: ");
            float primeiroTermo = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo termo da multiplicação: ");
            float segundoTermo = float.Parse(Console.ReadLine());

            float multiplicacao = primeiroTermo * segundoTermo;

            Console.WriteLine($"Multiplicação = {multiplicacao}");
            Console.WriteLine("");
        }
    }
}
