/*
 Escreva um programa que leia um conjunto de números positivos e exiba o
 menor e o maior. Suporemos que o número de elementos deste conjunto não é
 conhecido, e que um número negativo será utilizado para sinalizar o fim dos
 dados.
*/

using System;

namespace Exercicio34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numAtual, maior, menor;
            bool primeiro = true;

            Console.WriteLine("Digite um número (negativo para sair): ");
            numAtual = int.Parse(Console.ReadLine());

            if(numAtual >= 0)
            {
                menor = numAtual;
                maior = numAtual;

                while(numAtual >= 0)
                {
                    Console.WriteLine("Digite outro número: ");
                    numAtual = int.Parse(Console.ReadLine());

                    if (numAtual > maior)
                    {
                        maior = numAtual;
                    }
                    if (numAtual < menor && numAtual >= 0)
                    {
                        menor = numAtual;
                    }
                }
                Console.WriteLine("O maior número foi {0} e o menor foi {1}",maior, menor);
            }
        }
    }
}