/*
 Durante uma corrida de automóveis com N voltas de duração foram anotados
 para um piloto, na ordem, os tempos registrados em cada volta. Fazer um
 programa para ler os tempos das N voltas, calcular e imprimir:
 	i. melhor tempo;
 	ii. a volta em que o melhor tempo ocorreu;
 	iii. tempo médio das N voltas;
*/

using System;

namespace Exercicio53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numVolta, total = 0, media, melhorTempo = 0, melhorVolta = 0;

            Console.WriteLine("Digite o número de voltas: ");
            numVolta = int.Parse(Console.ReadLine());

            int[] tempo = new int[numVolta];

            for (int w = 0; w < numVolta; w++)
            {
                Console.WriteLine("Digite o tempo da {1}° volta (em seg): ");
                tempo[w] = int.Parse(Console.ReadLine());

                total += tempo[w];

                if (tempo[w] < melhorTempo || w == 0)
                {
                    melhorTempo = tempo[w];
                    melhorVolta = w + 1;
                }
            }

            media = total / numVolta;

            Console.WriteLine("O melhor tempo foi: {0} segundos", melhorTempo);
            Console.WriteLine("A melhor volta foi a {0}", melhorVolta);
            Console.WriteLine("A média de tempo foi: ", media);

        }
    }
}
