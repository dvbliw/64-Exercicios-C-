/*
  Escreva um programa que leia 3 números inteiros e imprima na tela os
  valores em ordem decrescente.
*/

using System;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quant = 3;
            int[] numeros = new int[quant];

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o {0}° número: ",i+1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);
            Array.Reverse(numeros);


            Console.WriteLine("Os numeros em ordem decrescente são: ");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}