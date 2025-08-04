using System;

class Program
{
	static int[]	ft_create(int n)
	{
		int[]	ms;
		Random	rnd;

		ms = new int[n];
		rnd = new Random();
		for (int i = 0; i < n; i++)
			ms[i] = rnd.Next(1, 100);
		return (ms);
	}
	
	static	int	ft_min(int[] ms)
	{
		int	min;

		min = ms[0];
		for (int i = 1; i < ms.Length; i++)
			if (min > ms[i])
				min = ms[i];
		return (min);
	}

	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine("\nMin: " + ft_min(ms));
		for (int i = 0; i < ms.Length; i++)
			if (ms[i] == ft_min(ms))
				Console.Write(i + " ");
		Console.WriteLine();
	}

	static void	Main()
	{
		try
		{
			ft_show(ft_create(Int32.Parse(Console.ReadLine())));
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
