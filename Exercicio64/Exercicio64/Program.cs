/*
  Escreva um programa que deverá ter as seguintes opções:
1 - Carregar Vetor
2 - Listar Vetor
3 - Exibir apenas os números pares do vetor
4 - Exibir apenas os números ímpares do vetor
5 - Exibir a quantidade de números pares existem nas posições ímpares do vetor
6 - Exibir a quantidade de números ímpares existem nas posições pares do vetor
7 - Sair 
*/

using System;

namespace Exercicio64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sair;
            int menu;
            Metodos metodo = new Metodos();

            #region MENU
            do
            {



                Console.WriteLine("Digite um valor: ");
                Console.WriteLine("[1] Carregar Vetores     ");
                Console.WriteLine("[2] Listar Vetores       ");
                Console.WriteLine("[3] Listar Numeros PARES ");
                Console.WriteLine("[4] Listar Numeros IMPAR ");
                Console.WriteLine("[5] QNT Numeros PARES    ");
                Console.WriteLine("[6] QNT Numeros IMPAR    ");
                Console.WriteLine("[7] Sair");

                menu = int.Parse(Console.ReadLine());

                #region MENU
                switch (menu)
                {
                    #region CADASTRO
                    case 1:

                        metodo.PreencherVetor();
                        Console.WriteLine("Cadastro realizado");
                        break;
                    #endregion
                    #region LISTAR
                    case 2:
                        Console.WriteLine("Numeros digitados: ");
                        Console.WriteLine("==========================");
                        metodo.LerVetor();
                        Console.WriteLine("==========================");
                        break;
                    #endregion
                    #region NUM PAR
                    case 3:
                        Console.WriteLine("Numeros pares digitados foram: ");
                        Console.WriteLine("==========================");
                        metodo.numPAR();
                        Console.WriteLine("==========================");
                        break;
                    #endregion
                    #region NUM IMPAR
                    case 4:
                        Console.WriteLine("Numeros impar digitados foram: ");
                        Console.WriteLine("==========================");
                        metodo.numIMPAR();
                        Console.WriteLine("==========================");
                        break;
                    #endregion
                    #region NUM PAR POSI IMPA
                    case 5:
                        metodo.numIMPARLPAR();
                        break;
                    #endregion
                    #region NUM IMPA POSI PAR
                    case 6:
                        metodo.numPARLIMPAR();
                        break;
                    #endregion
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Valor informado incorreto.");
                        break;
                }
                #endregion

                Console.WriteLine("Deseja retornar menu principal? (s/n): ");
                sair = Console.ReadLine();

            } while (sair.Equals("s"));
            #endregion
        }

    }
}