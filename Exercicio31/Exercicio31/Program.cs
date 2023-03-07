/*
 Escrever um programa que leia um conjunto de números positivos, e exiba se o número
 lido é par ou ímpar. Exiba ao final a soma total dos números pares lidos e também a soma dos
 números ímpares lidos. Suporemos que o número de elementos deste conjunto não é
 conhecido, e que um número negativo será utilizado para sinalizar o fim dos dados.
*/

using System;

namespace Exercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numer = 0, quantPar = 0, quantImpa = 0;

            while (numer >= 0) 
            {
                Console.WriteLine("Digite um número (numero negativo finaliza): ");
                numer = int.Parse(Console.ReadLine());

                if (numer >= 0)
                {
                    if (numer % 2 == 0)
                    {
                        quantPar++;
                    }
                    else
                    {
                        quantImpa++;
                    }
                }
            }

            Console.WriteLine("A quantidade de números pares: {0}", quantPar);
            Console.WriteLine("A quantidade de números ímpares: {0}", quantImpa);
        }
    }
}
