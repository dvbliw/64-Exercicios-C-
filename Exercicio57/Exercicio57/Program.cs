/*
 Fazer um programa que leia uma frase e imprima somente as vogais.
*/

using System;

namespace Exercicio57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase, vogais = "aeiouAEIOU", stringVog = "";

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            char[] arraychar = frase.ToCharArray();

            for (int i = 0; i < arraychar.Length; i++)
            {
                if (vogais.Contains("" + arraychar[i]))
                {
                    stringVog += arraychar[i];
                }
            }

            Console.WriteLine("Nova Frase: {0}", stringVog);
        }
    }
}
