/*
  Escreva um programa que leia quatro notas escolares de um aluno e
  apresentar uma mensagem que o aluno foi aprovado se o valor da média escolar
  for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
  do recuperação, somar com o valor da média e obter a nova média. Se a nova
  média for maior ou igual a 7, apresentar uma mensagem informando que o aluno
  foi aprovado na recuperação. Se o aluno não foi aprovado, apresentar uma
  mensagem informando esta condição. Apresentar junto com as mensagens o valor
  da média do aluno.
*/
using System;

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiraNota, segundaNota, terceiraNota, quartaNota, recuperacao, media;
            bool aprovacao = false;

            Console.WriteLine("Digite a primeira nota: ");
            primeiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            segundaNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota: ");
            terceiraNota = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota: ");
            quartaNota = double.Parse(Console.ReadLine());

            media = (primeiraNota + segundaNota + terceiraNota + quartaNota) / 4;

            if (media >= 7)
            {
                aprovacao = true;
            }
            else
            {
                Console.WriteLine("O aluno ficou de recuperação, digite a nota: ");
                recuperacao = double.Parse(Console.ReadLine());

                media = (media + recuperacao) / 2;
                if (media >= 7)
                {
                    aprovacao = true;
                }
            }

            if (aprovacao == true)
            {
                Console.WriteLine("O aluno foi aprovado com a média {0}", media);
            }
            else
            {
                Console.WriteLine("O aluno foi reprovado com a média {0}", media);
            }
        }
    }
}