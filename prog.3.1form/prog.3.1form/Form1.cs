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

namespace prog._3._1form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

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

		private void button1_Click(object sender, EventArgs e)
		{
			int a = int.Parse(numericUpDown1.Text, NumberStyles.Float);
			int b = int.Parse(numericUpDown2.Text, NumberStyles.Float);

			if (a > b)
			{
				MessageBox.Show("Начальное число диапазона А не должно быть больше конечного числа B");
			}

			textBox1.Text = $"Результат вычисления метода диапазоне от {a} до {b}" + Environment.NewLine;
			for (int i = a; i <= b; i++)
			{
				textBox1.Text += $"i = {i}, результат метода i = {MethodZero(i)}" + Environment.NewLine;
			}
		}
	}
}
