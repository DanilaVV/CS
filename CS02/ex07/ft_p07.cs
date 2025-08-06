using System;

class Program
{

	static void	ft_show(char[] ms)
	{
		foreach (char n in ms)
			Console.Write(n + " ");
		Console.WriteLine("\n");
	}

	static void	ft_show(int[] ms)
	{
		foreach (int n in ms)
			Console.Write(n + " ");
		Console.WriteLine("\n");
	}

	static int	ft_max(int n1, int n2)
	{
		if (n1 > n2)
			return (n1);
		return (n2);
	}

	static int	ft_min(int n1, int n2)
	{
		if (n1 < n2)
			return (n1);
		return (n2);
	}

	static int[]	ft_create(int n1, int n2)
	{
		int	min;
		int	max;
		int[]	ms;

		min = ft_min(n1, n2);
		max = ft_max(n1, n2);
		ms = new int[max - min + 1];
		for (int i = 0; i < ms.Length; i++)
			ms[i] = min + i;
		return (ms);
	}

	static char[]	ft_create(char c1, char c2)
	{
		char	min;
		char	max;
		char[]	ms;

		min = (char)ft_min(c1, c2);
		max = (char)ft_max(c1, c2);
		ms = new char[max - min + 1];
		for (int i = 0; i < ms.Length; i++)
			ms[i] = (char)(min + i);
		return (ms);
	}

	static void	Main()
	{
		ft_show(ft_create(4, -8));
		ft_show(ft_create('d', 'E'));
	}
}
