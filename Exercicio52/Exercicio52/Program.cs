
/*
 Fazer um programa ler um vetor de inteiros e positivos e imprimir quantas
 vezes aparece o número 1, 3 e 4, nesta ordem. O vetor terá no máximo 100
 posições. Sair do programa quando for digitado -1.
*/

using System;

namespace Exercicio52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPosi = 100, w = 0;
            
            int[] num = new int[numPosi];

            int cont1 = 0, cont3 = 0, cont4 = 0;

            do
            {
                Console.WriteLine("Digite o próximo número (valor -1 cancela): ");
                num[w] = int.Parse(Console.ReadLine());

                if (num[w] == 1)
                {
                    cont1++;
                }

                if (num[w] == 3)
                {
                    cont3++;
                }

                if (num[w] == 4)
                {
                    cont4++;
                }

                w++;
            } while (num[w - 1] != -1 && w < numPosi);

            Console.WriteLine("Quantidades Numero 1: {0}, Numero 3: {1}, Numero 4: {2}", cont1, cont3, cont4);
        }
    }
}