/*
 Faça um programa que leia as variáveis C e N, respectivamente código e
 número de horas trabalhadas de um operário. E calcule o salário sabendo-se que
 ele ganha R$ 10,00 por hora. Quando o número de horas exceder a 50, calcule o
 excesso de pagamento armazenando-o na variável E, caso contrário zerar tal
 variável. A hora excedente de trabalho vale R$ 20,00. No final do processamento
 imprimir o salário total e o salário excedente. O programa só deve parar de
 rodar quando o usuário responder "S" na seguinte pergunta, "Deseja encerrar o
 programa?".
*/

using System;

namespace Exercicio38
{
    internal class Program
    {
        private static double primeiro, segundo;

        static void Main(string[] args)
        {
            int codOp;
            double hTrabalhada, E = 0, precoHora, precoExcedente;
            bool continuar = true;
            char text;

            do
            {
                E = 0;
                precoHora = 0;
                precoExcedente = precoHora * 2;

                Console.WriteLine("Digite o código do operário: ");
                codOp = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de horas trabalhadas: ");
                hTrabalhada = int.Parse(Console.ReadLine());

                if (hTrabalhada > 50)
                {
                    E = hTrabalhada - 50;
                }

                Console.WriteLine("ID: {0} , Salario: {1}, Salario excedente: {2}, Salario total: {3}, Deseja encerrar? (s/N) ", codOp, hTrabalhada * precoHora, E * precoExcedente, E * precoExcedente + hTrabalhada * precoHora);
                text = char.Parse(Console.ReadLine());
                if (text == 's' || text == 'S')
                {
                    continuar = false;
                }

            } while (continuar);
        }
    }
}