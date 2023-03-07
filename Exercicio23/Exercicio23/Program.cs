/*
 Escreva um programa que exiba as seguintes opções e realize os que se pede em cada
 uma delas:
		1 – Adição
		2 – Subtração
		3 – Multiplicação
		4 – Divisão
*/

using System;

namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero, segundoNumero, resultado;
            int menu;

            Console.WriteLine("Digite uma das operações a seguir: ");
            Console.WriteLine("1 - Adição ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 - Divisão ");
            menu = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    resultado = primeiroNumero + segundoNumero;
                    Console.WriteLine("{0} + {1} = {2}", primeiroNumero, segundoNumero, resultado);
                    break;
                case 2:
                    resultado = primeiroNumero - segundoNumero;
                    Console.WriteLine("{0} - {1} = {2}", primeiroNumero, segundoNumero, resultado);
                    break;
                case 3:
                    resultado = primeiroNumero * segundoNumero;
                    Console.WriteLine("{0} x {1} = {2}", primeiroNumero, segundoNumero, resultado);
                    break;
                case 4:
                    resultado = primeiroNumero / segundoNumero;
                    Console.WriteLine("{0} / {1} = {2}", primeiroNumero, segundoNumero, resultado);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}