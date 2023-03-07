/*
 Faça um programa que dada a idade de um nadador, classifique-o em uma das
 seguintes categorias:
 	- Infantil A = 5 a 7 anos
 	- Infantil B = 8 a 11 anos
 	- Juvenil A = 12 a 13 anos
 	- Juvenil B = 14 a 17 anos
 	- Adultos = Maiores de 18 anos
*/

using System;

namespace Exercicio41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade;
            bool parar = false;
            char letra;
            string categoria;

            do
            {
                do
                {
                    Console.WriteLine("Digite a idade do nadador: ");
                    idade = int.Parse(Console.ReadLine());
                    if (idade < 5)
                    {
                        Console.WriteLine("Idade inválida");
                    }
                } while (idade < 5);

                if (idade >= 5 && idade < 8)
                    {
                        categoria = "Infantil A";
                    }else if( idade >= 8 && idade < 12) {
                        categoria = "Infantil B";
                    } else if (idade >= 12 && idade < 14)
                    {
                        categoria = "Juvenil A";
                    } else if( idade >= 14 && idade < 18)
                    {
                        categoria = "Juvenil B";
                    }
                    else
                    {
                        categoria = "Adulto";
                    }

                    Console.WriteLine("A categoria é: {0}", categoria);

                    Console.WriteLine("Deseja encerra? (s/N) ");
                    letra =  char.Parse(Console.ReadLine());
                    if (letra == 's' || letra == 'S')
                    {
                        parar = true;
                    }

                

            } while (parar == false);
        }
    }
}