/* 
    Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
    temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
    Fahrenheit e a variável C representa é a temperatura em graus Celsius.
 
 */

using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cel, fah;

            Console.WriteLine("Informe a temperatura em graus Celsius: ");
            cel = double.Parse(Console.ReadLine());

            fah = (9 * cel + 160) / 5;

            Console.WriteLine("O valor convertido em Fahrenheit é: {0}", fah);
        }
    }
}