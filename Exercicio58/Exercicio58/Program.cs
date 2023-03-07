/*
    Fazer um programa para armazenar em um vetor, vários números inteiros e positivos e calcular a média. Imprimir
    também o maior. A quantidade de números lidos será definida pelo usuário. 
  
 */


using System;

namespace Exercicio58
{
    internal class Program
    {
        static void Main(string[] args, int media)
        {
            int quantidade;

            Console.WriteLine("Digite a quantidade de números: ");
            quantidade = int.Parse(Console.ReadLine());

            int[] num = new int[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o valor {0}: ", i+1);
                num[i] = int.Parse(Console.ReadLine());
                media += num[i];
            }

            media = media / quantidade;
            Array.Sort(num);

            Console.WriteLine("A média dos valores é: {0}, O maior valor é: {1}", media, quantidade - 1);


        }
    }
}