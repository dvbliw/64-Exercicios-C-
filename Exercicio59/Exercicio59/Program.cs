/* 
 Escreva um programa que solicite dois caracteres de A a Z ao usuário e imprima o número de caracteres existente
 entre eles. Assuma que o usuário digite os 2 caracteres em ordem alfabética. Caso não o estejam, emitir
 mensagem de erro.
 Exemplo: Digite 2 caracteres: j t O numero de caracteres entre eles é: 9

*/

using System;

namespace Exercicio59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfa = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'w', 'y', 'z' };

            Console.WriteLine("Digite o primeiro caractere: ");
            char caract = char.Parse(Console.ReadLine());

            int primeiroCarac = ChecarCharact(caract, alfa);

            Console.WriteLine("Digite o segundo caractere: ");
            char outroCaract = char.Parse(Console.ReadLine());

            int segundoCaract = ChecarCharact(caract, alfa);

            int dif = segundoCaract - primeiroCarac - 1;

            if(primeiroCarac >= 0 && segundoCaract >= 0 && dif >=0)
            {
                Console.WriteLine("O número de caracteres entre eles é: {0}", dif);
            }else {
                Console.WriteLine("Erro!");
            }
        }

        public static int ChecarCharact(char ch, char[] alfa)
        {
            int num = -1;

            for (int i = 0; i < alfa.Length; i++)
            {
                if (alfa[i] == ch)
                {
                    num = i;
                }
            }
            return num;
        }
    }
}