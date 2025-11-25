using System;
using System.Threading;

class Program
{
	static void	ft_fill(char[,] ms, int j, int top)
	{
		Random	r;

		r = new Random();
		for (int i = 0; i < ms.GetLength(0); i++)
		{
			ms[i, j] = (char)('A' + r.Next(26));
			Console.SetCursorPosition(5 * j, top + i + 1);
			Console.Write(ms[i, j]);
			Thread.Sleep(200);
		}
	}
	static void	Main()
	{
		int	top;
		int	i;
		int	j;
		char[,]	ms;
		Thread[]	tms;
		
		Console.Write("Write number of lines: ");
		i = Int32.Parse(Console.ReadLine());
		Console.Write("Write number of columns: ");
		j = Int32.Parse(Console.ReadLine());
		top = Console.CursorTop;
		ms = new char[i, j];
		tms = new Thread[j];
		for (int k = 0; k < j; k++)
		{
			int	l;

			l = k;
			tms[l] = new Thread(() => ft_fill(ms, l, top));
			tms[l].Start();
			if (tms[l].IsAlive)
				tms[l].Join();
		}
		Console.WriteLine();
	}
}
