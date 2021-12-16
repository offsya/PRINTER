using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System;
using System.IO;

namespace TPExpCon
{
	public class Program
	{
		static void Main()
		{
			Console.Title = " ";
			Console.ForegroundColor = ConsoleColor.Black;
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Console.Write("Выберите откуда брать коды для печати");
			int key;
			do
			{
				Console.Write("\n1-Текстовый файл\n2-База данных\n>>");
			} while (!Int32.TryParse(Console.ReadLine(), out key) || key < 1 || key > 2);
			if(key == 1)
            {
	            while (true)
	            {
		            String path;
		            try
		            {
			            do
			            {
				            Console.Write("Введите путь к файлу с кодами\n");
				            path = Console.ReadLine();
				            if (path.Length == 0) Console.Write("Вы ничего не ввели\n");
				            else break;
			            } while (path.Length == 0);
			            var codes = Codes.GetCodesFromFile(path);
			            List<string> list = codes.ToList();
			            Printer.PrintOneByOne(list, new Point(90, 150), new Point(180, 180));
			            break;
		            }
		            catch (Exception e)
		            {
			            Console.WriteLine(e.Message);
		            }
	            }
            }else if(key == 2)
            {
				var codes = Codes.GetCodesFromDatabase();
				List<string> list = codes.ToList();

				Printer.PrintOneByOne(list, new Point(90, 150), new Point(180, 180));
			}			
		}
	}
}
