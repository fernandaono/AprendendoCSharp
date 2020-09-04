using System;
using System.Runtime.Serialization.Formatters;

namespace P13_ForEncadeado
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Projeto 13");

			// *
			// **
			// ***
			// um for para cada linha e cada coluna

			for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
			{
				for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
				{
					Console.Write("*");
					if (contadorColuna >= contadorLinha)
						break;
				}
				Console.WriteLine();
			}

			//Outra forma sem o break
			for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
			{
				for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
