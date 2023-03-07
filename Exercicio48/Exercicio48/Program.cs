/*
 Uma agência de publicidade pediu à agência de modelos Luz & Beleza para
 encontrar uma modelo que tenha idade entre 18 e 20 anos para participar de
 uma campanha publicitária milionária de produtos de beleza. Foram inscritas
 20 candidatas e, ao se inscreverem, forneceram nome e idade. Tais informações
 foram armazenadas em 2 vetores distintos. Faça um programa para imprima o
 vetor que contém os nomes das candidatas aptas a concorrer a uma vaga para
 a campanha milionária.
*/

using System;

namespace Exercicio48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numCand = 5;
            int quantidadeApta = 0;

            string[] nome = new string[numCand];
            int[] idade = new int[quantidadeApta];


            for (int w = 0; w < numCand; w++)
            {
                Console.WriteLine("Digite o nome da {0}° candidata: ", w+1);
                nome[w] = Console.ReadLine();

                Console.WriteLine("Digite a idade da {0}° candidata: ", w+1);
                idade[w] = int.Parse(Console.ReadLine());

                if (idade[w] >= 18 && idade[w] < 21)
                {
                    quantidadeApta++;
                }
            }

            string[] nomeAp = new string[quantidadeApta];
            int[] idadeAp = new int[quantidadeApta];

            int y = 0;
            for (int x = 0; x < numCand; x++)
            {
                if (idade[x] >= 18 && idade[x] < 21)
                {
                    nomeAp[y] = nome[x];
                    idadeAp[y] = idade[x];
                    y++;
                }
            }

            for (int x = 0; x < quantidadeApta; x++)
            {
                Console.WriteLine("Nome: {0}, Idade: {1}", nomeAp[x], idadeAp[x]);
            }
        }
    }
}