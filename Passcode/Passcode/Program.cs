using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
	class Program
	{
		static void Main(string[] args)
		{
			// Passcode challenge from the C# training

			var passcode = "";

			while (passcode != "Pambix")
			{
				Console.WriteLine("Enter passcode");
				passcode = Console.ReadLine();

				if (passcode != "Pambix")
				{
					Console.WriteLine("Try another passcode");
				}
			}
			Console.WriteLine("You are authenticated");
			Console.ReadKey();

			// Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
		}
	}
}
