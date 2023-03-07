/*
   Ler dois valores inteiros para as variáveis A e B, efetuar a troca dos
   valores de modo que a variável A passe a possuir o valor da variável B, e a
   variável B passe a possuir o valor da variável A. Apresentar os valores
   trocados.
*/

using System;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, variavelTemporaria;

            Console.WriteLine("Digite a variável A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a variável B:");
            b = int.Parse(Console.ReadLine());

            variavelTemporaria = a;
            a = b;
            b= variavelTemporaria;

            Console.WriteLine("A: {0} | B: {1} ", a, b);
        }
    }
}