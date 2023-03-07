/*
 Escreva um programa que calcule e retorne o valor da hipotenusa através do método HIPOTENUSA. O método
recebe o valor da base e da altura de um triângulo.
Fórmulas: hipotenusa² = base² + altura²
*/

using System;

namespace Exercicio62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basee, altura;

            Console.WriteLine("Digite o tamanho da base: ");
            basee = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("A hipotenusa é: {0}", Hipotenusa(basee, altura));

        }

        public static double Hipotenusa(double basee, double altura)
        {
            double hipotenusa = (basee * basee) + (altura * altura);
            hipotenusa = Math.Sqrt(hipotenusa);
            return hipotenusa;
        }
    }
}