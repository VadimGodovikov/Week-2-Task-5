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

namespace prog5._1form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		static double f(double x)
		{
			try
			{
				if (x == 1 || x == 0.25) throw new Exception();
				else return (1 / (x - 1)) + (2 / (1 - 4 * x));
			}
			catch
			{
				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(numericUpDown1.Text, NumberStyles.Float);
				double b = double.Parse(numericUpDown2.Text, NumberStyles.Float);

				if (a > b)
				{
					MessageBox.Show("Число a не может быть больше b");
					return;
				}
				double h = double.Parse(numericUpDown3.Text, NumberStyles.Float);
				if (h <= 0)
				{
					MessageBox.Show("Шаг функции не может быть меньше или равен 0");
					return;
				}
				if (h > b)
				{
					MessageBox.Show("Шаг функции не должен превышать значения конечного числа диапазона b");
					return;
				}
				textBox1.Text = "Результат работы программы: " + Environment.NewLine;
				for (double i = a; i <= b; i += h)
					try
					{
						textBox1.Text += $"y({i})={f(i):f4}" + Environment.NewLine;
					}
					catch
					{
						textBox1.Text += $"y({i})=error" + Environment.NewLine;
					}
			}
			catch (FormatException)
			{
				MessageBox.Show("Неверный формат ввода данных");
				return;
			}
			catch
			{
				MessageBox.Show("Неизвестная ошибка");
				return;
			}
		}
	}
}
