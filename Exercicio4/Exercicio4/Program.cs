/*
   Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
 	valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
  	A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
  	com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
  	devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
  	multiplicações.
*/

using System;

namespace Exercicio4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o quarto valor: ");
            d = int.Parse(Console.ReadLine());


            // SOMA DOS PARES
            Console.WriteLine("SOMAS: ");
            Console.WriteLine("=================");
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a + c = {0}", a + c);
            Console.WriteLine("a + d = {0}", a + d);
            Console.WriteLine("b + c = {0}", b + c);
            Console.WriteLine("b + d = {0}", b + d);
            Console.WriteLine("c + d = {0}", c + d);
            Console.WriteLine("=================");

            // OS PARES
            Console.WriteLine("PRODUTOS: ");
            Console.WriteLine("=================");
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a * c = {0}", a * c);
            Console.WriteLine("a * d = {0}", a * d);
            Console.WriteLine("b * c = {0}", b * c);
            Console.WriteLine("b * d = {0}", b * d);
            Console.WriteLine("c * d = {0}", c * d);
            Console.WriteLine("=================");





        }
    }
}