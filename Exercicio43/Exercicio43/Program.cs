/*
 Uma rainha requisitou os serviços de um monge e disse-lhe que pagaria
 qualquer preço. O monge, necessitando de alimentos, indagou à rainha sobre o
 pagamento, se poderia ser feito com grãos de trigo dispostos em um tabuleiro
 de xadrez, de tal forma que o primeiro quadro deveria conter apenas um grão e
 os quadros subseqüentes, o dobro do quadro anterior. A rainha achou o trabalho
 barato e pediu que o serviço fosse executado, sem se dar conta de que seria
 impossível efetuar o pagamento. Faça um programa para calcular o número de
 grãos que o monge esperava receber.
*/

using System;

namespace Exercicio43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double graosCa = 1, casaTabu = 64, graos = 1;
            

            for (int i = 1; i < casaTabu; i++)
            {
                graosCa = graosCa * 2;
                graos += graosCa;
            }

            Console.WriteLine("A quantidade de grãos é: {0}", graos);
        }
    }
}