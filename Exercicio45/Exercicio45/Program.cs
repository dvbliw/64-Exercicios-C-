/*
 Dada uma seqüência de n números (vetor de inteiros), imprimi-la na ordem inversa que
 foi realizada a leitura.
*/

using System;
using System.Net.Mail;
using System.Xml;

namespace Exercicio45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidade;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] numeros = new int[quantidade];


            for (int i = 0; i < quantidade; i++) 
            {
                Console.WriteLine("Digite o {0}° número: ", i+1);
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A ordem contrária é: ");

            for (int w= quantidade ; w >= 0; w--)
            {
                Console.WriteLine(numeros[w]);
            }
        }
    }
}