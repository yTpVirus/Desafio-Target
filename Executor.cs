using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target
{
	public class Executor
	{

		public static void DoLineBreak()
		{
			Console.WriteLine("---------------------------------------------------------------------\n");
		}

		public static void ExecutaSoma()
		{ 
			int Indice = 13;
			int resultado = SOMA.FazSoma(Indice);
			//
			Console.WriteLine($"Resultado da Questão 1: {resultado} \n");
			DoLineBreak();
		}

		public static void ExecutaFibonacci()
		{
			//Valor Padrão
			int ValorPadrao = 21;
			//
			Console.WriteLine("Digite Um Numero Para Verificar sua Existência na Sequência de Fibonacci: \n");
			Console.WriteLine($"Se Nenhum número for fornecido ou for inválido, o valor {ValorPadrao} será atribuido!");
			//
			var input = Console.ReadLine();
			if (input != null)
			{
				try
				{
					int parsed = int.Parse(input);
					Fibonacci.CheckFibo(parsed);
				}
				catch (Exception)
				{
					Console.WriteLine($"Um valor inválido foi inserido! atribuindo o valor {ValorPadrao}!");
					Fibonacci.CheckFibo(ValorPadrao);
				}
			}
		}

		public static void ExecutaInversorDeString()
		{
			//
			string ValorPadrao = "ABCDEF";
			//
			Console.WriteLine("Digite Qualquer texto para ser Invertido: \n");
			Console.WriteLine($"Caso Nenhum Texto for fornecido, o texto {ValorPadrao} será Atribuido! ");
			var input = Console.ReadLine();
			if (input != null)
			{
				if (input.Length > 0)
				{
					Console.WriteLine($"Texto Fornecido: {input}");
					string resultado = InversorDeString.InverterString(input);
					Console.WriteLine($"Resultado da Questão Numero 5: \n {resultado}");
					DoLineBreak();
				}
				else
				{
					Console.WriteLine($"Texto Fornecido: {ValorPadrao}\n");
					string resultado = InversorDeString.InverterString(ValorPadrao);
					Console.WriteLine($"Resultado da Questão Numero 5: \n {resultado}");
					DoLineBreak();
				}
			}
			else
			{
				Console.WriteLine($"Texto Fornecido: {ValorPadrao}\n");
				string resultado = InversorDeString.InverterString(ValorPadrao);
				Console.WriteLine($"Resultado da Questão Numero 5: \n {resultado}");
				DoLineBreak();
			}
		}
		///MAIN
		public static void Main(string[] args)
		{
			//Aqui executaremos os Exercícios em ordem
			//Questão Numero 1

			Console.WriteLine("Executando Questão Número 1:\n");
			ExecutaSoma();

			//Questão Numero 2

			Console.WriteLine("Executando Questão Numero 2:\n");
			ExecutaFibonacci();
			
			//Questão Numero 5

			Console.WriteLine("Executando Questão Numero 5:\n");
			ExecutaInversorDeString();
		}
	}
}
