/* 
    Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
    V = 3.14159 * R * R * A
    Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura.
 */


using System;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.WriteLine("Informe o valor do raio: ");
            raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = 3.14159 * raio * raio * altura;

            Console.WriteLine("O valor do volume é: {0}", volume);
        }
    }
}