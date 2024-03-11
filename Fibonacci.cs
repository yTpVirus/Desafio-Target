using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target
{ 
	public static class Fibonacci
	{
		//
		public static bool CheckFibo(int Numero)
		{
			bool resultado = Fibo(Numero);
			//
			Console.WriteLine($"Resultado da Questão 2:\n");
			Console.WriteLine($"Número fornecido: {Numero}");
			//
			if (resultado)
			{
				Console.WriteLine($"O número fornecido existe na sequência de Fibonacci!");
				Executor.DoLineBreak();
				return true;
			}
			else
			{
				Console.WriteLine($"O numero fornecido não existe na sequência de Fibonacci!");
				Executor.DoLineBreak();
				return false;
			}
		}
		//
		public static bool Fibo(int Numero)
		{
			int i = 0;
			int last = 0;
			int next = 1;
			int res = 0;
			while (res < Numero) 
			{
				res = last + next;
				//Se o numero existe na sequencia retornamos verdade
				if(res == Numero) { return true; }
				//
				next = last;
				last = res;
				//
				i++;
			}
			//Senão, falso
			return false;
		}
	}
}
