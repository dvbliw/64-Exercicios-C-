/*
 Fazer um programa para ler uma quantidade N de alunos. Ler a nota de cada
 um dos N alunos e calcular a média aritmética das notas. Contar quantos alunos
 estão com a nota acima de 7.0. Obs.: Se nenhum aluno tirou nota acima de 5.0,
 imprimir mensagem: Não há nenhum aluno com nota acima de 5.
*/

using System;

namespace Exercicio51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAlunos, notasA = 0;
            bool salaF = true;

            Console.WriteLine("Digite a quantidade de alunos: ");
            quantidadeAlunos = int.Parse(Console.ReadLine());

            int[] notas = new int[quantidadeAlunos];

            for (int w = 0; w < quantidadeAlunos; w++)
            {
                Console.WriteLine("Digite a nota do {0}° aluno", w+1);
                notas[w] = int.Parse(Console.ReadLine());

                if (notas[w] > 7)
                {
                    notasA++;
                }
                if (notas[w] > 5)
                {
                    salaF = false;
                }
            }
            if (salaF == false)
            {
                Console.WriteLine("Existem {0} notas maiores que 7", notasA);
            }
            else
            {
                Console.WriteLine("Não há nenhum aluno com nota superior a 5");
            }
        }
    }
}