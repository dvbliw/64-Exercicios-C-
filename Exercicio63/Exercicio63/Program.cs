/*
   Escreva um programa que verifique se um número é par ou ímpar através de um método chamado VERIFICA. O
   método deverá receber um número inteiro (n) e deverá retornar a mensagem “PAR” ou “ÍMPAR”.
*/

using System;

namespace Exercicio63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Verifica(num));
        }

        public static String Verifica(int num)
        {
            if(num % 2 == 0)
            {
                return "PAR";
            }else
            {
                return "ÍMPAR";
            }
        }
    }
}