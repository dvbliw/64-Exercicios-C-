/*
  Escreva um programa que leia dois números e apresente a diferença do
  maior para o menor.
*/

using System;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, diferenca;

            Console.WriteLine("Digite o primeiro numero: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero >= segundoNumero)
            {
                diferenca = primeiroNumero - segundoNumero;
            }
            else
            {
                diferenca = segundoNumero - primeiroNumero;
            }

            Console.WriteLine("A diferença do menor para o menor é {0}", diferenca);
        }
    }
}