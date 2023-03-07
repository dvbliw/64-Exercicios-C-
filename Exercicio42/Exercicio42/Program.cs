/*
 Faça um programa que determine o maior e o menor entre N números lidos.
 A condição de parada é a entrada de um valor 0, ou seja, o programa deve ficar
 executando até que a entrada seja igual a 0 (ZERO).
*/

using System;

namespace Exercicio41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, maior, menor;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            maior = numero;
            menor = numero;

            do
            {
                Console.WriteLine("Digite outro número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maior)
                {
                    maior = numero;
                }

                if (numero < menor && numero != 0)
                {
                    menor = numero;
                }


            } while (numero != 0);

            Console.WriteLine("O menor número é {0} e o maior número é {1}", menor, maior);
        }
    }
}