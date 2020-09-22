// Kevin Fee
// 09/22/2020
using System;

namespace TechProject3a
{
	class Program
	{
		static void Main(string[] args)
		{
			// Gives opportunity to type name and press enter
			Console.WriteLine("Enter name");
			// Creates a string variable to store the user input
			string userName = Console.ReadLine();
			// Prints Hello followed by the user input
			Console.WriteLine("Hello " + userName);
			Console.ReadKey(true);
		}
	}
}
