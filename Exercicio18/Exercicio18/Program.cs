/*
 Escreva um programa que leia um número inteiro (variável CODIGO). Verificar se o código
 é igual a 1, igual a 2 ou igual a 3. Caso não seja, apresentar a mensagem “Código inválido”.
 Ao ser verificado o código e constatado que é um valor válido, o programa deve verificar cada
 código em separado para determinar seu valor por extenso, ou seja, apresentar a mensagem
 “um”, ”dois” ou “três”. (Utilizar o comando Switch).
*/

using System;

namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.WriteLine("Digite o código: ");
            codigo = int.Parse(Console.ReadLine());

            switch (codigo)
            {
                case 1:
                    Console.WriteLine("um");
                    break;
                case 2:
                    Console.WriteLine("dois");
                    break;
                case 3:
                    Console.WriteLine("três");
                    break;
                default:
                    Console.WriteLine("Codigo inválido.");
                    break;
            }
        }
    }
}