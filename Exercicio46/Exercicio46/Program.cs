/*
 Dados dois vetores x e y, ambos com n elementos, determinar o produto escalar desses
 vetores. Ou seja, realizar a soma de todos dos resultados da multiplicação de x[i] por y[i].
*/

using System;
using System.Net.Mail;

namespace Exercicio46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] vetorX = new int[quantidade];
            int[] vetorY = new int[quantidade];

            for (int x = 0; x < quantidade; x++)
            {
                Console.WriteLine("Digite o {0}° número do vetor X: ");
                vetorX[x] = int.Parse(Console.ReadLine());
            }

            for (int y = 0; y < quantidade; y++)
            {
                Console.WriteLine("Digite o {0}° número do vetor Y: ");
                vetorY[y] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A multiplicação dos vetores é: ");
            for (int w = 0; w < quantidade; w++)
            {
                Console.WriteLine("{0} * {1} = {2}", vetorX[w], vetorY[w], vetorY[w] * vetorX[w]);
            }


        }
    }
}