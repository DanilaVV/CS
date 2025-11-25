using System;
using System.Threading;

class Program
{
	static void	ft_fill(int[,] ms, int i, int top)
	{
		for (int j = 0; j < ms.GetLength(1); j++)
		{
			ms[i, j] = (int)Math.Pow(2 + i, j);
			Console.SetCursorPosition(10 * j, top + i + 1);
			Console.Write(ms[i, j]);
			Thread.Sleep(600);
		}
	}
	static void	Main()
	{
		int	top;
		int	i;
		int	j;
		int[,]	ms;
		Thread[]	tms;
		
		Console.Write("Write number of lines: ");
		i = Int32.Parse(Console.ReadLine());
		Console.Write("Write number of columns: ");
		j = Int32.Parse(Console.ReadLine());
		top = Console.CursorTop;
		ms = new int[i, j];
		tms = new Thread[i];
		for (int k = 0; k < i; k++)
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
