/*
 Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e 
 dias e escreva a idade dessa pessoa expressa apenas em dias. Considerar ano
 com 365 dias e mês com 30 dias.
*/

using System;

namespace Exercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeAnos, idadeMeses, idadeDias, idadeTotal;

            Console.WriteLine("Digite o ano: ");
            idadeAnos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o mes");
            idadeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o dia: ");
            idadeDias = int.Parse(Console.ReadLine());


            idadeTotal = idadeAnos * 365 + idadeMeses * 30 + idadeDias;

            Console.WriteLine("Idade total em dias é: {0}", idadeTotal);
        }
    }
}