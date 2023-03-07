/*
 Dado dois vetores, A (5 elementos) e B (8 elementos), faça um programa em
 C que imprima todos os elementos comuns aos dois vetores.
*/


using System;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace Exercicio54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5], b = new int[8];

            List<int> c = new ArrayList<int>();

            int w = 0;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Digite um número para o vetor A: ");
                a[x] = int.Parse(Console.ReadLine());
            }

            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine("Digite um número para o vetor B: ");
                b[x] = int.Parse(Console.ReadLine());

                for (int i = 0; i < 5; i++)
                {
                    if (b[x] == a[i])
                    {
                        c.Insert(w, b[x]);
                        w++;
                    }
                }
            }

            Console.WriteLine("Números comuns: ");
            for(int x = 0; x< c.Count; x++)
            {
                Console.WriteLine(c.ToArray()[x]);
            }
        }
    }
}