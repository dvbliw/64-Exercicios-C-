/*
 Fazer um programa para ler um vetor de inteiros positivos de 50 posições.
 Imprimir a quantidade de números pares e de múltiplos de 5.
*/

using System;

namespace Exercicio56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numInt = new int[50];
            int quantParM5 = 0, x = 0;

            while (x<50)
            {
                Console.WriteLine("Digite um número inteiro para a posição {0}: ", x+1);
                numInt[x] = int.Parse(Console.ReadLine());

                if (numInt[x] >= 0)
                {
                    if (numInt[x] % 5 == 0 && numInt[x] % 2 == 0)
                    {
                        quantParM5++;
                    }

                    x++;
                }
            }

            Console.WriteLine("A quantidade de números par e multiplos de 5 é: {0}", quantParM5);
        }
    }
}
