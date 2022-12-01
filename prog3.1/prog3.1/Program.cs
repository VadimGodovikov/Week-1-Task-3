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
			if (x % 2 == 1)
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
		static void Main(string[] args)
		{
			Method res = new Method();
			Console.WriteLine("Демонстрация метода: числа от 0 до 20");
			for(int i = 0; i < 20; i++)
			{
				Console.WriteLine("i = {0}, результат метода i = {1}", i, res.MethodZero(i));
			}
		}
	}
}
