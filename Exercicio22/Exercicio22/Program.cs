/*
 Faça um programa que leia um número. Se positivo armazene-o em A, se for
 negativo, em B. No final mostrar o resultado.
*/

using System;

namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, numero;
            do
            {
                Console.WriteLine("Digite um numero, digite 0 para sair: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    a += numero;
                    Console.WriteLine("Numero armazenado em A");
                }else if (numero < 0)
                {
                    a += numero;
                    Console.WriteLine("Numero armazenada em B");
                }
            }while(numero != 0);
            Console.WriteLine("A = {0}, B = {1}",a,b);
        }
    }
}
