/*
 Faça um programa para calcular o estoque médio de uma peça, sendo que:
 ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2.

*/

using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeMin = 3;
            int quantidadeMax = 10;
            double estoqueMEDIO = (quantidadeMin + quantidadeMax) / 2;

            Console.WriteLine(estoqueMEDIO);
        }
    }
}