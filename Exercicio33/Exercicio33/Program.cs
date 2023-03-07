
/*
 Escreva um programa que calcule e exiba a média da nota dos alunos de uma
 turma em uma prova. O número de alunos é desconhecido. Os dados de um aluno
 são: número de matrícula e a sua nota na prova em questão.
*/

using System;
using System.Xml;

namespace Exercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantAlunos;
            string matricula;
            double mediaAlunos = 0;

            Console.WriteLine("Digite uma quantidade de alunos: ");
            quantAlunos = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[quantAlunos];

            for (int i = 0; i < quantAlunos; i++)
            {
                Console.WriteLine("Digite o número da matrícula do aluno: ");
                matricula = Console.ReadLine();

                Console.WriteLine("Digite a nota do aluno: ");
                double nota = double.Parse(Console.ReadLine());

                alunos[i] = new Aluno();
                alunos[i].setAluno(matricula, nota);

                mediaAlunos += nota;
            }

            mediaAlunos = mediaAlunos / quantAlunos;
            Console.WriteLine("A média da turma foi de {0}", mediaAlunos);
        }
    }
}
