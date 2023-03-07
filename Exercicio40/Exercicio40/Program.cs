/*
 A Secretaria de Meio Ambiente que controla o índice de poluição mantém 03
 grupos de indústrias que são altamente poluentes do meio ambiente. O índice
 de poluição aceitável varia de 0,05 até 0,25. Se o índice sobe para 0,3 as
 indústrias do 1o grupo são intimadas a suspenderem suas atividades, se o
 índice crescer para 0,4 as industrias do 1o e 2o grupo são intimadas a
 suspenderem suas atividades, se o índice atingir 0,5 todos os grupos devem ser
 notificados a paralisarem suas atividades. Faça um programa que leia o índice
 de poluição medido e emita a notificação adequada aos diferentes grupos de
 empresas. O algoritmo só deve parar de rodar quando o usuário responder "S" na
 seguinte pergunta, "Deseja encerrar o programa?".
*/

using System;

namespace Exercicio40
{
    internal class Program
    {
        private static double primeiro, segundo;

        static void Main(string[] args)
        {
            double numero;
            bool parar = false;
            char letra;

            do
            {
                do
                {
                    Console.WriteLine("Digite o índice de poluição: ");
                    numero = double.Parse(Console.ReadLine());
                    if (numero < 0)
                    {
                        Console.WriteLine("Numero inválido digite um número positivo.");
                    }
                } while (numero < 0);

                if (numero >= 0.3)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 1° Grupo!");
                }

                if (numero >= 0.4)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 2° Grupo!");
                }

                if (numero >= 0.5)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 3° Grupo!");
                }

                Console.WriteLine("Deseja encerrar o programa? (s/N)");
                letra = char.Parse(Console.ReadLine());

                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }
            } while (parar == false);
        }
    }
}