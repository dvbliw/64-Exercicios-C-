/*
 Escreva um programa que leia:
   - a quantidade de números que deverá processar;
   - os números que deverá processar,e calcule e exiba, para cada número a ser
     processado o seu fatorial.
 Lembrete: O fatorial de um número N é dado pela fórmula:
     N! = 1 * 2 * 3 * 4 * 5 * ... * N
*/

using System;

namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            long[] numeros = new long[quantidade];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                long resultado = 1;
                for (long y = numeros[i]; y > 0; y--)
                {
                    resultado = y * resultado;
                }

                Console.WriteLine("O fatorial de {0} é: {1}", numeros[i], resultado);
            }
        }
    }
}