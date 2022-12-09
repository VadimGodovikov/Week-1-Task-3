using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog3._1
{
	class Method
	{
		public int MethodZero(int x)
		{
			if (x % 2 != 0)
			{
				return 0;
			}
			else
			{
				return x / 2;
			}
		}
	}
	class Program
	{
		static int readInt()
		{
			do
			{
				int res;
				bool pars = int.TryParse(Console.ReadLine(), out res);
				if (pars) return res;
				else Console.WriteLine("Введите корректное число:");
			} while (true);
		}
		static void Main(string[] args)
		{
			Method res = new Method();
			dip: Console.WriteLine("Введите начало диапазона А: ");
			int a = readInt();
			Console.WriteLine("Введите конец диапазона B: ");
			int b = readInt();

			if (a > b)
			{
				Console.WriteLine("Начальное число диапазона не должно быть больше конечного");
				goto dip;
			}

			for (int i = a; i <= b; i++)
			{
				Console.WriteLine("i = {0}, результат метода i = {1}", i, res.MethodZero(i));
			}
		}
	}
}
