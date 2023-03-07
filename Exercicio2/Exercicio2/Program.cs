/*
  Faça um programa que:
     - Leia a cotação do dólar
     - Leia um valor em dólares
     - Converta esse valor para Real
     - Mostre o resultado
 
 */

using System;

namespace Exercicio2
{
    internal class Program { 
    
        static void Main(string[] args)
        {
            double cotacaoDolar, real, dolares;

            Console.WriteLine("Informe a cotação do dolar em real: ");
            cotacaoDolar = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor em dolar: ");
            dolares = double.Parse(Console.ReadLine());

            real = dolares * cotacaoDolar;

            Console.WriteLine("O valor de $ {0} dolares, na cotação de  R$ {1} por dolar da R$ {2} reais.", cotacaoDolar, dolares real);
        }
    }
}