using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog3._2_3form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

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

		private void button1_Click(object sender, EventArgs e)
		{
			double a, b, h;
			a = double.Parse(numericUpDown1.Text, NumberStyles.Float);
			b = double.Parse(numericUpDown2.Text, NumberStyles.Float);
			h = double.Parse(numericUpDown3.Text, NumberStyles.Float);

			textBox1.Text = "Результат работы метода: " + Environment.NewLine;
			textBox1.Text += $"Результат вычисления функции с интервалом [{a}, {b}]" + Environment.NewLine;
			textBox1.Text += "Задание 2. Вызов функции с возвращаемым значеним." + Environment.NewLine;
			textBox1.Text += "x\ty" + Environment.NewLine;

			if (a <= b)
			{
				for (double i = a; i <= b; i += h)
				{
					textBox1.Text += $"f({i:f2})={f(i):f4}" + Environment.NewLine; // Задание 1
					
				}
			}
			else if (a > b) // Если начальный диапазон больше конечного.
			{
				textBox1.Text += "Произошёл ввод так, что конечный интервал меньше начального, тогда программа будет работать так:" + Environment.NewLine;
				for (double i = a; i >= b; i -= h)
				{
					textBox1.Text += $"f({i:f2})={f(i):f4}" + Environment.NewLine; // Задание 1
					
				}
			}

				textBox1.Text += "Задание 3. Вызов функции с сылкой." + Environment.NewLine;
				textBox1.Text += "x\ty" + Environment.NewLine;

				if (a <= b)
				{
					for (double i = a; i <= b; i += h)
					{
						double y;
						f(i, out y);
						textBox1.Text += $"f({i:f2})={y:f4}" + Environment.NewLine; // Задание 2
				}
				}
				else if (a > b) // Если начальный диапазон больше конечного.
				{
					textBox1.Text += "Произошёл ввод так, что конечный интервал меньше начального, тогда программа будет работать так:" + Environment.NewLine;
					for (double i = a; i >= b; i -= h)
					{
						double y;
						f(i, out y);
						textBox1.Text += $"f({i:f2})={y:f4}" + Environment.NewLine; // Задание 2
					}

				}
		}
	}
}
