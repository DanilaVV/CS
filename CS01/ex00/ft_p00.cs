using System;

class Program
{
	static	int[]	ft_create(int n)
	{
		int[]	ms;

		ms = new int[n];
		for (int i = 0, j = 2; i < n; j++)
		{
			if (j % 5 == 2)
				ms[i++] = j;
		}
		return (ms);
	}

	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(" | "+ ms[i]);
		Console.WriteLine(" |");
	}

	static void	Main()
	{
		int	n;

		try
		{
			n = Int32.Parse(Console.ReadLine());
			ft_show(ft_create(n));
		}
		catch
		{
			Console.WriteLine("Wrong value\nTry again");
		}
	}
}
