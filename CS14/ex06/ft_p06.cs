using System;

class Program
{
	static void	ft_show<X>(X[] ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}
	static void	ft_sort<X>(X[] ms) where X: IComparable
	{
		X	n;
		int	ch;

		do{
			ch = 0;
			for (int i = 0; i < ms.Length - 1; i++)
				if (ms[i].CompareTo(ms[i + 1]) <= 0)
					ch++;
				else
				{
					n = ms[i];
					ms[i] = ms[i + 1];
					ms[i + 1] = n;
				}
		}while (ch != ms.Length - 1);
		
	}
	static void	Main()
	{
		int[]	ms;

		ms = new int[]{0, -23, 10, 4, 11, -4, 7};
		ft_show(ms);
		ft_sort(ms);
		ft_show(ms);
	}
}
