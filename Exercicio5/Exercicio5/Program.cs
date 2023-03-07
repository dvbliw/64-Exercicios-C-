/*
 Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
 	12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
 	Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
	Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
 	fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
 	tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*/


using System;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double velocidadeMedia, tempoGasto, Autonomia = 12, distancia, litrosUsados;
            
            Console.WriteLine("Digite o tempo que voce gastou em sua viagem (horas): ");
            tempoGasto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média em que voce fez o percurso (Km/h): ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            distancia = velocidadeMedia * tempoGasto;
            litrosUsados = distancia / Autonomia;


            Console.WriteLine("RESULTADO: ");
            Console.WriteLine("=========================");
            Console.WriteLine("Velocidade média = {0} Km/h", velocidadeMedia);
            Console.WriteLine("Tempo gasto = {0} horas", tempoGasto);
            Console.WriteLine("Distancia percorrida = {0} Km", distancia);
            Console.WriteLine("Quantidade de combustivél utilizado: {0} Litros", litrosUsados);

        }
    }
}