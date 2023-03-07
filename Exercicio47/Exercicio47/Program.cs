/*
 Considere um vetor de 10 números inteiros positivos maiores que zero e um único número
 inteiro, também positivo e maior que zero. Faça um programa para:
 		a. ler pelo teclado o vetor;
 		b. ler pelo teclado o número X;
 		c. dizer quantos números no vetor são maiores que X, menores que X e iguais a X.
*/

using System;

namespace Exercicio47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o {0}° número do vetor: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int numeroX;
            Console.WriteLine("Digite o número X: ");
            numeroX = int.Parse(Console.ReadLine());

            int maior = 0, menor = 0, iguais = 0;

            Console.WriteLine("Números maiores que o número X: ");

            for (int w = 0; w < 10; w++)
            {
                if (vetor[w] > numeroX)
                {
                    Console.WriteLine(vetor[w]);
                    maior++;
                }
                else if (vetor[w] == numeroX)
                {
                    iguais++;
                }
                else
                {
                    maior++;
                }

                Console.WriteLine("Maiores: {0}, Iguais: {1}, Menores: [2]", maior, iguais, menor);

            }
        }
    }
}