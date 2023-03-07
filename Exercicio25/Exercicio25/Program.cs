/*
 Tendo como dados de entrada a altura e o sexo de uma pessoa, faça um
 programa que calcule seu peso ideal, utilizando as seguintes fórmulas:
 (h = altura)
   - Para homens: (72.7*h) - 58
   - Para mulheres: (62.1 *h) - 44.7
*/

using System;

namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double altura, pesoideal;
            char sexo = 'n';

            Console.WriteLine("Digite sua altura (em metros): ");
            altura = double.Parse(Console.ReadLine());

            while (sexo != 'm'  && sexo != 'M' && sexo != 'h' && sexo != 'H')
            {
                Console.WriteLine("Digite H ou M para especificar o sexo: ");
                sexo = char.Parse(Console.ReadLine());

                switch (sexo)
                {
                    case 'h':
                    case 'H':
                        pesoideal = (72.7 * altura) - 58;
                        Console.WriteLine("Seu peso ideia é de: {0} KG", pesoideal);
                        break;
                    case 'm':
                    case 'M':
                        pesoideal = (62.1 * altura) - 44.7;
                        Console.WriteLine("Seu peso ideal é de: {0} KG", pesoideal);
                        break;
                    default:
                        Console.WriteLine("Não é M");
                        break;
                }
            }
        }
    }
}
