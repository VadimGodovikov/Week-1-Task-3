using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3._2
{
	class Program
	{
		static double f(double x) // Задание 2
		{
			double y;
			if (x < 1) y = Math.Pow((x * x - 1), 2);
			else if (x == 1) y = 0;
			else y = 1 / Math.Pow((1 + x), 2);
			return y;
		}

		static void f(double x, out double y) // Задание 3
		{
			if (x < 1) y = Math.Pow((x * x - 1), 2);
			else if (x == 1) y = 0;
			else y = 1 / Math.Pow((1 + x), 2);
		}

		static void Main(string[] args)
		{
			double a = 0, b = 0, h = 0;

			while (true)
			{
				try
				{
					Console.Write("Введите начальное значение интервала: ");
					a = double.Parse(Console.ReadLine());

					Console.Write("Введите конечное значение интервала: ");
					b = double.Parse(Console.ReadLine());

					Console.Write("Введите шаг функции: ");
					h = double.Parse(Console.ReadLine());

					if (h == 0) throw new Exception("Выберите шаг отличный от нуля! Количество итераций будет бесконечно!");
					break;

				}
				catch (Exception ex)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Ошибка: ");
					Console.ResetColor();
					Console.WriteLine(ex.Message);
				}
			}

			Console.WriteLine("\n\n");

			if (a <= b)
			{
				Console.WriteLine($"Результат вычисления функции с интервалом [{a}, {b}]\n");
				Console.WriteLine("x\ty");
				for (double i = a; i <= b; i += h)
				{
					Console.WriteLine("Вызов функции с возвращаемым значением: \nf({0:f2})={1:f4}", i, f(i)); // Задание 1

					double y;
					f(i, out y);
					Console.WriteLine("Вызов функции с сылкой: \nf({0:f2})={1:f4}", i, y); // Задание 2
				}
			}
			else if (a > b) // Если начальный диапазон больше конечного.
			{
				Console.WriteLine($"Результат вычисления функции с интервалом [{a}, {b}]\n");
				for (double i = a; i >= b; i -= h)
				{
					Console.WriteLine("Вызов функции с возвращаемым значением: \nf({0:f2})={1:f4}", i, f(i)); // Задание 1

					double y;
					f(i, out y);
					Console.WriteLine("Вызов функции с сылкой: \nf({0:f2})={1:f4}", i, y); // Задание 2
				}
			}

		}
	}
}
