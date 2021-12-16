using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;

namespace TPExpCon
{
	public class Program
	{
		static void Main()
		{
			Console.Title = " ";
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			var codes = Codes.GetCodesFromDatabase();
			List<string> list = codes.ToList();
			
			Printer.PrintOneByOne(list, new Point(90, 150), new Point(180, 180));
		}
	}
}
