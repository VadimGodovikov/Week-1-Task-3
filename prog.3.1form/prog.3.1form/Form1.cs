using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			if (x % 2 == 1)
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
			textBox1.Text = "Демонстрация метода: числа от 0 до 20" + Environment.NewLine;
			for (int i = 0; i < 20; i++)
			{
				textBox1.Text += $"i = {i}, результат метода i = {MethodZero(i)}" + Environment.NewLine;
			}
		}
	}
}
