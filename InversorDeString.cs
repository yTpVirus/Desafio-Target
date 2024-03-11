using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target
{
	public class InversorDeString
	{
		public static string InverterString(string str)
		{
			string str2 = "";
            for (int i = str.Length - 1; i >= 0; i --)
            {
				str2 += str[i];
            }
			return str2;
		}
	}
}
