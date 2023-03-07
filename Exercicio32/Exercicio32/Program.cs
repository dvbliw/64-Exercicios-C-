/*
 Escreva um programa que calcule e exiba a soma dos quadrados dos 20 primeiros
 números inteiros positivos ímpares a partir do número informado pelo usuário menor que 10
 e maior que zero.
*/

using System;

namespace Exercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, numeroQuad, resultado = 0;

            do
            {
                Console.WriteLine("Digite um número maior que 0 e menor que 10: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0 || numero >= 10); ;

            for (int i = numero; i < 40; i++)
            {
                if (i % 2 == 1)
                {
                    resultado += i * i;
                }
            }
            Console.WriteLine("O resultado da soma dos quadrados dos 20 primeiros números inteiros positivos ímpares a partir do número informado é: {0}", resultado);
        }
    }
}