/*
  Faça um programa para pagamento de comissão de vendedores de peças,
		levando-se em consideração que sua comissão será de 5% do total da venda 
		e que você tem os seguintes dados:
 		- Identificação do vendedor
 		- Código da peça
 		- Preço unitário da peça
 		- Quantidade vendida
*/

using System;

namespace Exercicio3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int idVendedor, idPeca;
            double precoPeca, quantidade, valorComissao, porcentagemComissao = 0.05;

            Console.WriteLine("Digite a identificação do vendedor: ");
            idVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID da Peça: ");
            idPeca = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço unitario da peça: ");
            precoPeca = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            quantidade = int.Parse(Console.ReadLine());

            valorComissao = (precoPeca * quantidade) * porcentagemComissao;

            Console.WriteLine("O valor da comissão é de {0}", valorComissao);
        }
    }
}