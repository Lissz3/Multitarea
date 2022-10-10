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
				int menuOption;
				do
				{
					for (int i = 0; i < options.Length; i++)
					{
						Console.WriteLine((i + 1) + ".-" + options[i]);
					}
					Console.WriteLine(options.Length + 1 + ".-Exit");
					Console.WriteLine("Select option:");
					while (!int.TryParse(Console.ReadLine(), out menuOption) || menuOption <= 0 || menuOption > options.Length + 1)
					{
						Console.WriteLine("Option not valid. Not a number or valid one. Please insert a new one:");
					}
					if (menuOption != options.Length + 1)
					{
						operations[menuOption - 1]();
					}
					else
					{
						Console.WriteLine("Cya!");
					}

				} while (menuOption != options.Length + 1);

			}

		}

		public bool Controler(string[] options, MyDelegate[] operations)
		{
			if (options.Length != operations.Length)
			{
				return false;
			}

			if (options == null || operations == null)
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
