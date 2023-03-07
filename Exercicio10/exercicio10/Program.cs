/* Escrever um programa que leia dois números inteiros e mostre todos os 
   relacionamentos de ordem existentes entre eles. Os relacionamentos possíveis 
   são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.
 */

using System;

namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero;
            bool igual = false, naoIgual = false, menor = false, maior = false, maiorOuIgual = false, menorOuIgual = false;

            Console.WriteLine("Digite o primeiro numero: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            segundoNumero = int.Parse(Console.ReadLine());


            if (primeiroNumero == segundoNumero)
            {
                igual = true;
            }
            if (primeiroNumero != segundoNumero)
            {
                naoIgual = true;
            }
            if (primeiroNumero > segundoNumero)
            {
                maior = true;
            }
            if (primeiroNumero < segundoNumero)
            {
                menor = true;
            }
            if (primeiroNumero >= segundoNumero)
            {
                maiorOuIgual = true;
            }
            if (primeiroNumero <= segundoNumero)
            {
                menorOuIgual = true;
            }

            Console.WriteLine("Igual = {0}", igual);
            Console.WriteLine("Não igual = {0}", naoIgual);
            Console.WriteLine("Maior = {0}", maior);
            Console.WriteLine("Menor = {0}", menor);
            Console.WriteLine("Maior ou igual = {0}", maiorOuIgual);
            Console.WriteLine("Menor ou igual = {0}", menorOuIgual);

        }
    }
}