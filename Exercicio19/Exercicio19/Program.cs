/*
 Escreva um programa que leia três valores para os lados de um triângulo
 (variáveis A, B e C). Verificar se cada lado é menor que a soma dos outros dois lados. Se sim,
 saber de A==B e se B==C, sendo verdade o triângulo é eqüilátero; Se não, verificar de A==B
 ou se A==C ou se B==C, sendo verdade o triângulo é isósceles; e caso contrário, o triângulo
 será escaleno. Caso os lados fornecidos não caracterizarem um triângulo, avisar a ocorrência.
*/

using System;

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite o lado A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado C: ");
            c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }else if (a == b || a == c || b ==c)
                {
                    Console.WriteLine("O triângulo é Isósceles.");
                }
                else
                {
                    Console.WriteLine("O triangulo é Escaleno.");
                }

            }
            else
            {
                Console.WriteLine("Os lados fornecidos não caracterizam um triangulo.");
            }
        }
    }
}


