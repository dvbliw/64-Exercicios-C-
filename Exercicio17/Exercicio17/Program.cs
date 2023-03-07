/*
 Escreva um programa que leia um número inteiro. Verificar por meio de condição se o
 valor fornecido está na faixa entre 0 (zero) e 9 (nove). Caso o valor fornecido esteja dentro da
 faixa, apresentar a mensagem “valor válido”. Caso contrário, apresentar a mensagem “valor
  inválido”.
*/

using System;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o primeiro número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0 && numero <=9)
            {
                Console.WriteLine("Valor válido.");
            }
            else
            {
                Console.WriteLine("Valor inválido.");
            }
        }
    }
}