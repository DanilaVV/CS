using System;

class Program
{
	static X	ft_met<X>(X[] ms) where X: IComparable
	{
		X	max;

		max = ms[0];
		foreach (var n in ms)
			if (max.CompareTo(n) < 0)
				max = n;
		return (max);
	}
	static void	Main()
	{
		int[]	ms;

		ms = new int[]{4, 6, 7, -2, 5, 7, 4};
		Console.WriteLine(ft_met(ms));
	}
}
