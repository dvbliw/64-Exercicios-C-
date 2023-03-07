
/*
 Fazer um programa que sorteie um número de 0 a 100 e que permita que o
 usuário (sem conhecer o número sorteado) tente acertar. Caso não acerte, o
 programa deve imprimir uma mensagem informando se o número sorteado é maior ou
 menor que a tentativa feita. Ao acertar o número, o programa deve imprimir a
 quantidade de tentativas feitas.
*/

using System;

namespace Exercicio50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            bool acertou = false;
            int chute, tentativa = 0;

            int numero = gerador.Next(101);

            while (acertou == false)
            {
                Console.WriteLine("Digite um número de 0 a 100: ");
                chute = int.Parse(Console.ReadLine());
                tentativa++;

                if (chute == numero)
                {
                    Console.WriteLine("Você acertou em {0} tentativas!", tentativa);
                    acertou = true;
                } else if (chute > numero)
                {
                    Console.WriteLine("O número é menor.");
                } else
                {
                    Console.WriteLine("O número é maior.");
                }
            }
        }
    }
}