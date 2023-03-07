/*
   Escreva um programa que leia um número inteiro e exiba o seu módulo.
   O módulo de um número x é:
   x se x é maior ou igual a zero
   x * (-1) se x é menor que zero
*/
using System;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, moduloNumero;

            Console.WriteLine("Digite um numero inteiro: ");
            numero = int.Parse(Console.ReadLine());

            moduloNumero = (numero < 0) ? moduloNumero = numero * (-1) : numero;

            Console.WriteLine("O módulo do número é {0}", moduloNumero);


        }
    }
}