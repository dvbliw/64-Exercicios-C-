/*
 Escrever um programa declarando três variáveis do tipo inteiro (a, b e c). Ler um valor
 maior que zero para cada variável (se o valor digitado não é válido, mostrar mensagem e ler
 novamente). Exibe o menor valor lido multiplicado pelo maior e o maior valor dividido pelo
 menor.
*/

using System;

namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o {0}° valor: ",i+1);
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            Console.WriteLine("Exibe o menor valor lido multiplicado pelo maior: {0}", valores[0] * valores[2]);
            Console.WriteLine("e o maior valor dividido pelo menor: {0}", valores[2] / valores[0]);
        }
    }
}