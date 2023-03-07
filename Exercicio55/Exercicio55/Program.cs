/*
 Fazer um programa que leia uma frase de até 50 caracteres e imprima a
 frase sem os espaços em branco.
 Imprimir também a quantidade de espaços em branco da frase.
*/


using System;

namespace Exercicio55
{
    internal class Program
    {
        static void Main(string[] args, string novaFrase)
        {
            string frase;

            do
            {
                Console.WriteLine("Digite sua frase: ");
                frase = Console.ReadLine();
            }while(frase.Length > 50);

            char[] arraychar = frase.ToCharArray();

            for (int i = 0; i < arraychar.Length; i++)
            {
                if (arraychar[i] != ' ')
                {
                    novaFrase = novaFrase + arraychar[i];
                }
            }

            Console.WriteLine("Nova frase: {0}", novaFrase);

        }
    }
}