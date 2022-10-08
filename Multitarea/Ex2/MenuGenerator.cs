#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
	internal class MenuGenerator
	{
		public MenuGenerator(string[] options, MyDelegate[] operations)
		{
			if (Controler(options, operations))
			{
				Array.ForEach(options, option => { Console.WriteLine(option); });
				Console.WriteLine(options.Length + 1 + ".-Exit.");
				Console.WriteLine("Select option:");
				int menuOption;
				while (!int.TryParse(Console.ReadLine(), out menuOption) || menuOption < 0 || menuOption > options.Length + 1)
				{
					Console.WriteLine("Option not valid. Not a number or valid one. Please insert a new one:");
				}
				if (menuOption != options.Length + 1)
				{
					operations[menuOption - 1]();
				}
				else
				{
					Console.WriteLine("Hasta otra.");
				}

			}

		}

		public bool Controler(string[] options, MyDelegate[] operations)
		{
			if (options.Length != operations.Length)
			{
				return false;
			}

			if (options.Length == null || operations.Length == null)
			{
				return false;
			}

			if (options.Length == 0 || operations.Length == 0)
			{
				return false;
			}

			return true;
		}
	}
}
