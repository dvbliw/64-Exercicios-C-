/*
  Escreva um programa que calcule e retorne o salário atualizado através do método REAJUSTE. O método deve
  receber o valor do salário e o índice de reajuste. 
*/

using System;

namespace Exercicio61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, reajuste, rea;

            Console.WriteLine("Digite o salario atual: ");
            salarioAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de reajuste: ");
            reajuste = double.Parse(Console.ReadLine());
            rea = reajuste / 100;

            Console.WriteLine("O novo salario é de R$ {0}", Reajuste(salarioAtual, rea));
        }

        public static double Reajuste(double salario, double indiceReajuste)
        {
            double novoSalario = salario + (salario * indiceReajuste);
            return novoSalario;
        }
    }
}
