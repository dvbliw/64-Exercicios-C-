/*
 Faça um programa que exiba as opções:
 	1 – Conversão de Graus Celsius em Graus Fahrenheit
 	2 – Conversão de Graus Fahrenheit em Graus Celsius
 	3 – Peso ideal do homem
 	4 – Peso ideal da mulher
 O programa só deve encerrar quando o usuário digitar  ́S ́ para a pergunta
  “Deseja encerrar o programa?”
 Obs.: Nas opções 3 e 4 informar se o usuário está acima ou abaixo do peso ideal.
*/

using System;
using System.Net.Mail;

namespace Exercicio44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            char letra;
            int opcao;

            do
            {
                do
                {
                    Console.WriteLine("Digite uma das opções: ");
                    Console.WriteLine("1 - Conversão de graus Celsius em graus Fahrenheit ");
                    Console.WriteLine("2 - Conversão de graus Fahrenheit em graus Celsius ");
                    Console.WriteLine("3 - Peso ideal do homem ");
                    Console.WriteLine("4 - Peso ideal da mulher ");
                    opcao = int.Parse(Console.ReadLine());

                    if (opcao < 1 || opcao > 4)
                    {
                        Console.WriteLine("Opção errada.");
                    }
                }while (opcao < 1 || opcao > 4);

                double celsius, fahrenheit, altura, pesoideal;

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Digite a temperatura em °C: ");
                            celsius = double.Parse(Console.ReadLine());
                            fahrenheit = (celsius * 1.8) + 32;
                            Console.WriteLine("A temperatura convertida é: {0}°F", fahrenheit);
                            break;
                        case 2:
                            Console.WriteLine("Digite a temperatura em °F: ");
                            fahrenheit = double.Parse(Console.ReadLine());
                            celsius = (fahrenheit - 32) / 1.8;
                            Console.WriteLine("A temperatura convertida é: {0}°C", celsius);
                            break;
                        case 3:
                            Console.WriteLine("Digite a altura: ");
                            altura = double.Parse(Console.ReadLine());
                            pesoideal = (72.7 * altura) - 58;
                            Console.WriteLine("Seu peso ideal é: {0} kg", pesoideal);
                            break;
                        case 4:
                            Console.WriteLine("Digite a altura: ");
                            altura = double.Parse(Console.ReadLine());
                            pesoideal = (62.1 * altura) - 44.7;
                            Console.WriteLine("Seu peso ideal é: {0} kg", pesoideal);
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }

                    Console.WriteLine("Deseja encerrar? (s/N)");
                    letra = char.Parse(Console.ReadLine());
                    if (letra == 's' || letra == 'S')
                    {
                        continuar = false;
                    }
            } while (continuar);
        }
    }
}