/*
 Faça um programa para imprimir uma tabuada.
*/

using System;

namespace Exercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numer;

            Console.WriteLine("Digite um número: ");
            numer = double.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numer, numer, numer*i);
            }
        }
    }
}
