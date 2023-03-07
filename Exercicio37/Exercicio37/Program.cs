/*
 Faça um programa de conversão de base numérica. O programa deverá
 apresentar uma tela de entrada com as seguintes opções:
		1 – Adição
		2 – Subtração
		3 – Multiplicação
		4 – Divisão
 Informe a opção:
 A partir da opção escolhida, o programa deverá solicitar para que o usuário
 digite dois números. Em seguida, o programa deve exibir o resultado da opção
 indicada pelo usuário e perguntar ao usuário se ele deseja voltar ao menu
 principal. Caso a resposta seja  ́S ́ ou  ́s ́, deverá voltar ao menu, caso
 contrário deverá encerrar o programa.
*/

using System;

namespace Exercicio37
{
    internal class Program
    {
        private static double primeiro, segundo;

        static void Main(string[] args)
        {
            int opcao;
            string charOp;
            bool encerra=false;

            while(encerra=false)
            {
                Console.WriteLine("Digite uma opção para as operações");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        pegarNum();
                        Console.WriteLine("Resultado de {0} + {1} = {2}", primeiro, segundo, primeiro + segundo);
                        break;
                    case 2:
                        pegarNum();
                        Console.WriteLine("Resultado de {0} - {1} = {2}", primeiro, segundo, primeiro - segundo);
                        break;
                    case 3:
                        pegarNum();
                        Console.WriteLine("Resultado de {0} x {1} = {2}", primeiro, segundo, primeiro * segundo);
                        break;
                    case 4:
                        pegarNum();
                        Console.WriteLine("Resultado de {0} / {1} = {2}", primeiro, segundo, primeiro / segundo);
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente: ");
                        opcao = int.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Deseja continuar? (s/n)");
                charOp = Console.ReadLine();

                if (charOp == "N" || charOp == "n")
                {
                    encerra = true;
                }
            }
        }
        public static void pegarNum()
        {
             double primeiro, segundo;

            Console.WriteLine("Digite o primeiro número: ");
            primeiro = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            segundo = double.Parse(Console.ReadLine());


        }
    }
}