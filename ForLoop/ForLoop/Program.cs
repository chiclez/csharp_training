using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 1; i < 5; i++)
			{
				for (int c = 1; c <= 10; c++)
				{
					Console.WriteLine(c);
				}
				for (int c = 10; c >= 1; c--)
				{
					Console.WriteLine(c);
				}
			}
			Console.ReadKey();
		}
	}
}
