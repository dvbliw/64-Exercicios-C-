/*
 Faça um programa que leia 10 valores inteiros e positivos e:
 - Encontre o maior valor
 - Encontre o menor valor
 - Calcule a média dos números lidos
*/

using System;

namespace Exercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantNum = 10;
            double media = 0;

            int[] numeros = new int[quantNum];

            for (int i = 0; i < quantNum; i++)
            {
                Console.WriteLine("Digite o {0}° numero: ", i+1);
                numeros[i] = int.Parse(Console.ReadLine());
                media += numeros[i];
            }

            media = media / quantNum;

            Array.Sort(numeros);

            Console.WriteLine("O menor número é: {0}", numeros[0]);
            Console.WriteLine("O maior número é: {0}", numeros[quantNum - 1]);
            Console.WriteLine("A média dos números é: {0}", media);
        }
    }
}
