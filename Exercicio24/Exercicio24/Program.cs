/*
 Escreva um programa que leia dois números inteiros e apresente as opções para usuário escolher o que deseja
 realizar:
 1 – Verificar se um dos números lidos é ou não múltiplo do outro
 2 – Verificar se os dois números lidos são pares
 3 – Verificar se a média dos dois números é maior ou igual a 7.
 4 – Sair
*/

using System;

namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero, segundoNumero, resultado;
            int menu;
            bool loopMenu = true;


            Console.WriteLine("Digite o primeiro numero: ");
            primeiroNumero = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            segundoNumero = double.Parse(Console.ReadLine());

            while (loopMenu)
            {
                Console.WriteLine("Deseja verificar se ");
                Console.WriteLine("1 - um dos números lidos é ou não multiplo do outro");
                Console.WriteLine("2 - os dois números lidos são pares ");
                Console.WriteLine("3 - a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        if(primeiroNumero%segundoNumero == 0 || segundoNumero%primeiroNumero == 0)
                        {
                            Console.WriteLine("Sim, um dos números é múltiplo do outro");
                        }
                        else
                        {
                            Console.WriteLine("Não, nenhum dos números é múltiplos do outros");
                        }
                        break;
                    case 2:
                        if(primeiroNumero % 2 == 0 && segundoNumero % 2 == 0)
                        {
                            Console.WriteLine("Sim, os dois números lidos são pares");
                        }
                        else
                        {
                            Console.WriteLine("Não, os dois números lidos são ímpares");
                        }
                        break;
                    case 3:
                        if ((primeiroNumero + segundoNumero) /2 >= 7)
                        {
                            Console.WriteLine("Sim, a média dos dois números é maior ou igual a 7");
                        }
                        else
                        {
                            Console.WriteLine("Não, a média dos dois números não é maior ou igual a 7");
                        }
                        break;
                    case 4:
                        loopMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}