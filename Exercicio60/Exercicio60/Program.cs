/*
 Escreva um programa que retorne o número do quadrante (1,2,3 ou 4) através de um método chamado
 VERIFICA_QUADRANTE, que deve receber um valor para x e um valor para y.
 Quadrantes

*/


using System;

namespace Exercicio60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Informe o valor x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor y: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine(VerificaQuad(x,y));
        }

        public static int VerificaQuad(int x, int y)
        {
            bool quadx, quady;

            if (x > 0)
            {
                quadx = true;
            }else
            {
                quadx = false;
            }

            if (y > 0)
            {
                quady = true;
            }
            else
            {
                quady= false; 
            }

            if (x == 0 || y == 0) 
            {
                return 0;
            }else if (quadx && quady)
            {
                return 1;
            } else if (!quadx && quady)
            {
                return 2;
            } else if(!quadx && !quady)
            {
                return 3;
            } else
            {
                return 4;
            }
             
        }
    }
}