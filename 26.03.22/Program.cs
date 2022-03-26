using System;
using System.Globalization;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			NumberFormatInfo nfi = new NumberFormatInfo()
			{
				NumberDecimalSeparator = ".",
			};

			int k = 0;
			double a, b, res;
			char c;
			string str1, str2;

			while (k != 1)
			{
				Console.WriteLine("Введите первое число...");
				str1 = Console.ReadLine();
				bool tryParse1 = double.TryParse(str1, out a);
				Console.WriteLine("Введите второе число...");
				str2 = Console.ReadLine();
				bool tryParse2 = double.TryParse(str2, out b);

				if (tryParse1 && tryParse2)
				{
					Console.WriteLine("Введите знак: '+' '-' '*' '/'");
					c = Convert.ToChar(Console.ReadLine());
					switch (c)
					{
						case '+':
							res = a + b;
							Console.WriteLine($"{a} + {b} = {res}");
							break;
						case '-':
							res = a - b;
							Console.WriteLine($"{a} - {b} = {res}");
							break;
						case '*':
							res = a * b;
							Console.WriteLine($"{a} * {b} = {res}");
							break;
						case '/':
							res = a / b;
							Console.WriteLine($"{a} / {b} = {res}");
							break;
					}
					k++;
				}
				else
				{
					try
					{
						a = double.Parse(str1, nfi);
						b = double.Parse(str2, nfi);
						Console.WriteLine("Введите знак: '+' '-' '*' '/'");
						c = Convert.ToChar(Console.ReadLine());
						switch (c)
						{
							case '+':
								res = a + b;
								Console.WriteLine($"{a} + {b} = {res}");
								break;
							case '-':
								res = a - b;
								Console.WriteLine($"{a} - {b} = {res}");
								break;
							case '*':
								res = a * b;
								Console.WriteLine($"{a} * {b} = {res}");
								break;
							case '/':
								res = a / b;
								Console.WriteLine($"{a} / {b} = {res}");
								break;
						}
						k++;
					}
					catch
					{
						Console.WriteLine("Ошибка! Вы ввели неверные данные.");
					}
				}
			}
		}
	}
}