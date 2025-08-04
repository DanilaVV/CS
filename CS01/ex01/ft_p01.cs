using System;

class Program
{

	static int	ft_pow(int n, int pw)
	{
		if (pw == 0)
			return (1);
		return (n * ft_pow(n, pw - 1));
	}

	static int[]	ft_create(int n)
	{
		int[] ms;

		if (n > 11)
			n = 11;
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = ft_pow(2, i);
		return (ms);
	}

	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
		for (int i = ms.Length - 1; i >= 0; i--)
			Console.Write(ms[i] + " ");
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
			Console.WriteLine("Error");
		}
	}
}
