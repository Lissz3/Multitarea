using System;
using System.Diagnostics;

namespace Ex1
{

	class Program
	{

		static void Main(string[] args)
		{
			int[] v = { 2, 2, 6, 7, 1, 10, 3 };
			Array.ForEach(v, item =>
			{
				Console.ForegroundColor = item >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
				Console.WriteLine($"Student grade: {item,3}.");
				Console.ResetColor();
			});

			int res = Array.FindLastIndex(v, item => item >= 5);
			Console.WriteLine($"The last passing student is number {res + 1} in the list.");

			int[] approveds = Array.FindAll(v, item => item >= 5);
			
			Console.WriteLine("There are {0}approved students.", approveds.Length > 0 ? "" : "no ");

			Array.ForEach(v, item => Console.WriteLine((double)1/item));
		}
	}
}