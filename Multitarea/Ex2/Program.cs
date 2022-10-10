using System;
using System.Diagnostics;

namespace Ex2
{
	public delegate void MyDelegate();
	class Program
	{
		static void Main(string[] args)
		{

			new MenuGenerator(new string[] { "Op", "Op2", "Op3" },
			new MyDelegate[] { () => Console.WriteLine("A"), () => Console.WriteLine("B"), () => Console.WriteLine("C") });
		}
	}
}