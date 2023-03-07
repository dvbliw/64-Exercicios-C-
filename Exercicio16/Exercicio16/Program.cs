/*
 Escreva um programa que leia dois números e exiba mensagem informando o
 valor do maior número e o valor do menor número. Se os dois números forem
 iguais, o programa deve exibir mensagem informando este fato.
*/

using System;

namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero;

            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            if (primeiroNumero > segundoNumero)
            {
                Console.WriteLine("O primeiro número é maior que o segundo número.");
            }else if(primeiroNumero < segundoNumero)
            {
                Console.WriteLine("O primeiro numero é menor que o segundo número.");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais.");
            }
        }
    }
}