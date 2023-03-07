/*
 Leia 2 vetores de inteiros V1 e V2 de N componentes cada (no máximo 50).
 Determine e imprima quantas vezes que V1 e V2 possuem valores idênticos nas
 mesmas posições.
*/

using System;

namespace Exercicio49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numComp;

            Console.WriteLine("Digite o número de posições: ");
            numComp = int.Parse(Console.ReadLine());

            int[] n1 = new int[numComp];
            int[] n2 = new int[numComp];

            for (int x = 0; x < numComp; x++)
            {
                Console.WriteLine("Digite um valor para a posição {0} do vetor 1: ", x+1);
                n1[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < numComp; x++)
            {
                Console.WriteLine("Digite um valor para a posição {0} do vetor 2: ", x+1);
                n2[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < numComp; x++)
            {
                if (n1[x] == n2[x])
                {
                    Console.WriteLine("Valores das posições {0} dos vetores é igual.", x+1);
                }
            }
        }
    }
}