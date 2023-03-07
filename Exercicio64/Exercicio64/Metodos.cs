using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio64
{
    internal class Metodos
    {
        const int num = 10;
        int[] Numeros = new int[num];

        #region PREENCHER
        public void PreencherVetor()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Digite o valor para a {0} posição: ", i + 1);
                Numeros[i] = int.Parse(Console.ReadLine());
            }
        }
        #endregion

        #region LISTAR
        public void LerVetor()
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("O valor da posição {0} é {1}", i + 1, Numeros[i]);
            }
        }
        #endregion

        #region NUMEROS PARES
        public void numPAR()
        {
            for (int i = 0; i < num; i++)
            {
                if (Numeros[i] % 2 == 0)
                {
                    Console.WriteLine("{0}", Numeros[i]);
                }
            }
        }


        #endregion

        #region NUMEROS IMPAR
        public void numIMPAR()
        {
            for (int i = 0; i < num; i++)
            {
                if (Numeros[i] % 2 != 0)
                {
                    Console.WriteLine("{0}", Numeros[i]);
                }
            }
        }
        #endregion

        #region NUMEROS PAR LOCAL IMPAR VETOR
        public void numIMPARLPAR()
        {
            int i;
            int cont;
            cont = 0;


            Console.WriteLine("Os numeros pares em posições impar foram: ");
            Console.WriteLine("==========================");
            for (i = 0; i < num; i++)
            {
                if (Numeros[i] % 2 == 0 && (i + 1) % 2 != 0)
                {
                    cont = cont + 1;
                    Console.WriteLine("{0} na posição {1}", Numeros[i], i + 1);
                }

            }
            Console.WriteLine("==========================");
            Console.WriteLine("Com um total de: {0} numeros pares", cont);


        }
        #endregion

        #region NUMEROS IMPAR LOCAL PAR VETOR
        public void numPARLIMPAR()
        {
            int i;
            int cont;
            cont = 0;


            Console.WriteLine("Os numeros impar em posições pares foram: ");
            Console.WriteLine("==========================");
            for (i = 0; i < num; i++)
            {
                if (Numeros[i] % 2 != 0 && (i + 1) % 2 == 0)
                {
                    cont = cont + 1;
                    Console.WriteLine("{0} na posição {1}", Numeros[i], i + 1);
                }

            }
            Console.WriteLine("==========================");
            Console.WriteLine("Com um total de: {0} numeros impar", cont);


        }
        #endregion





    }
}
