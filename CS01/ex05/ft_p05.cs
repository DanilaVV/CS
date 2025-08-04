using System;

class Program
{
	static int[]	ft_create(int n)
	{
		Random rnd;
		int[]	ms;

		ms = new int[n];
		rnd = new Random();
		for (int i = 0; i < n; i++)
			ms[i] = rnd.Next(1, 100);
		return (ms);
	}

	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	ft_sort(int[] ms)
	{
		int	ch;
		int	i;
		int	n;

		ch = 0;
		i = 0;
		while (ch != ms.Length - 1)
		{
			ch = 0;
			i = 0;
			while (i++ < ms.Length - 1)
				if (ms[i - 1] >= ms[i])
					ch++;
				else
				{
					n = ms[i - 1];
					ms[i - 1] = ms[i];
					ms[i] = n;
				}
		}
	}

	static void	Main()
	{
		int[]	ms;

		try
		{
			ms = ft_create(Int32.Parse(Console.ReadLine()));
			ft_show(ms);
			ft_sort(ms);
			ft_show(ms);	
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
