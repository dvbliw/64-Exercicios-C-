/*
 Faça um programa que conte de 1 até 100 e a cada múltiplo de 10 exiba uma
 mensagem: "Múltiplo de 10".
*/

using System;

namespace Exercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            for (numero = 1; numero <= 100; numero++)
            {
                if(numero % 10 == 0)
                {
                    Console.WriteLine("{0} - multiplo de 10", numero);
                }
                else
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
