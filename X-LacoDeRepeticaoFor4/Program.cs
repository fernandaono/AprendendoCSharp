using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_LacoDeRepeticaoFor4
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int multiplos = 1; multiplos < 100; multiplos++)
			{
				if (multiplos % 3 == 0)
				{
					Console.WriteLine(multiplos);
				}
			}
			Console.ReadLine();
		}
	}
}