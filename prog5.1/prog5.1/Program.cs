using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog5._1
{
	class Program
	{
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
		static void Main(string[] args)
		{
			try
			{
				a1: Console.Write("Начальное число диапазона a= ");
				double a = double.Parse(Console.ReadLine());
				Console.Write("Конечное число диапазона b= ");
				double b = double.Parse(Console.ReadLine());
				if(a > b)
				{
					Console.WriteLine("Число a не может быть больше b");
					goto a1;
				}
				h1: Console.Write("Шаг функции h= ");
				double h = double.Parse(Console.ReadLine());
				if(h <= 0)
				{
					Console.WriteLine("Шаг функции не может быть меньше или равен 0");
					goto h1;
				}
				if(h > b)
				{
					Console.WriteLine("Шаг функции не должен превышать значения конечного числа диапазона b");
					goto h1;
				}
				for (double i = a; i <= b; i += h)
					try
					{
						Console.WriteLine("y({0})={1:f4}", i, f(i));
					}
					catch
					{
						Console.WriteLine("y({0})=error", i);
					}
			}
			catch (FormatException)
			{
				Console.WriteLine("Неверный формат ввода данных");
			}
			catch
			{
				Console.WriteLine("Неизвестная ошибка");
			}
		}
	}
}
