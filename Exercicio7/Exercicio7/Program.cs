/* 
     Ler uma temperatura em graus Fahrenheit e apresentá-Ia convertida em graus Celsius. A fórmula de conversão de
    temperatura a ser utilizada é C = (F - 32) * 5 / 9, em que a variável F é a temperatura em graus Fahrenheit e a
    variável C é a temperatura em graus Celsius.
 
 */

using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cel, fah;

            Console.WriteLine("Informe a temperatura em graus Fahrenheit: ");
            fah = double.Parse(Console.ReadLine());

            cel = (fah - 32) * 5 / 9;

            Console.WriteLine("O valor convertido em celsius é: {0}", cel);
        }
    }
}