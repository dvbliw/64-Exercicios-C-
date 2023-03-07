/*
 Faça um programa que leia um número inteiro e mostre uma mensagem na tela
 indicando se este número é positivo ou negativo. Pare a execução do programa
 quando o usuário requisitar.
*/

using System;

namespace Exercicio39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um numero, 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo");
                }
                else
                {
                    Console.WriteLine("O número não é negativo");
                }


            } while (numero != 0);
        }
    }
}
