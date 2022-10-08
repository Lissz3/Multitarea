using System;
using System.Diagnostics;
using Ex1;

namespace Ex2
{
	public delegate void MyDelegate();
	class Program
	{
		static void Main(string[] args)
		{

			new MenuGenerator(new string[] { "1.-Op", "2.-Op2", "3.-Op3" },
			new MyDelegate[] { () => Console.WriteLine("A"), () => Console.WriteLine("B"), () => Console.WriteLine("C") });
		}
	}
}