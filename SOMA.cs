using System;
namespace Desafio_Target
{
	public static class SOMA
	{
		public static int FazSoma(int Indice)
		{
			int Soma = 0;
			int K = 0;
			while (K < Indice)
			{
				K++;
				Soma += K;
			}
			return Soma;
		}
	}
}
