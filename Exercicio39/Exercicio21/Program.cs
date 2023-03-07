/*
 Faça um programa que leia um número inteiro e mostre uma mensagem
 indicando se este número é par ou ímpar, e se é positivo ou negativo. O
 programa só deve parar de rodar quando o usuário responder "S" na seguinte
 pergunta, "Deseja encerrar o programa?" .
*/

using System;

namespace Exercicio39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool parar = false;
            char letra;

            do
            {
                Console.WriteLine("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par");
                }
                else
                {
                    Console.WriteLine("O número não é par");
                }

                if (numero < 0)
                {
                    Console.WriteLine("O número é negativo");
                }
                else
                {
                    Console.WriteLine("O número é positivo");
                }

                Console.WriteLine("Deseja sair: (s/N)? ");
                letra = char.Parse(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }

            }while(parar==false);
        }
    }
}